using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using Newtonsoft.Json;
using ChatBot.Core.Model;

namespace ChatBot.Core
{
    public class Assistant : IDisposable
    {
        private const int SESSION_TIMEOUT = 60;
        private const string SESSION_START = "start";

        private readonly object _semaphore;
        private readonly Script _script;
        private readonly CancellationTokenSource _cts;
        private readonly Dictionary<string, Dialog> _dialogs;
        private readonly Dictionary<long, Session> _session;

        public Assistant(string filename)
        {
            _semaphore = new object();
            _cts = new CancellationTokenSource();
            _session = new Dictionary<long, Session>();

            var thread = new Thread(AssistantLoop) { IsBackground = true };
            thread.Start();

            _script = JsonConvert.DeserializeObject<Script>(File.ReadAllText(filename, Encoding.UTF8));
            _script.Start.Id = SESSION_START;

            _dialogs = new Dictionary<string, Dialog>();
            AddDialog(_script.Start);
        }

        private void AddDialog(Dialog dialog)
        {
            _dialogs.Add(dialog.Id, dialog);
            foreach (var child in dialog.Dialogs)
            {
                AddDialog(child);
            }
        }

        private void AssistantLoop()
        {
            while (!_cts.IsCancellationRequested)
            {
                lock(_semaphore)
                {
                    foreach (var id in _session.Keys.ToArray())
                    {
                        var now = DateTime.UtcNow;
                        if ((now - _session[id].Timestamp).TotalMinutes > SESSION_TIMEOUT)
                        {
                            _session.Remove(id);
                        }
                    }
                }
            }
        }

        public Dialog GetResponseForId(Session session, string id)
        {
            if (_dialogs.ContainsKey(id))
            {
                lock (_semaphore)
                {
                    session.CurrentDialog = id;
                    if (_session.ContainsKey(session.Id))
                    {
                        _session[session.Id] = session;
                    }
                    else
                    {
                        _session.Add(session.Id, session);
                    }
                }

                var dialog = _dialogs[id];
                return dialog.GetAsTemplate(session);
            }
            else
            {
                return SendUnknow(session);
            }
        }

        public Dialog GetResponseForText(Session session, string text)
        {
            var currentDialog = string.Empty;

            lock (_semaphore)
            {
                if (_session.ContainsKey(session.Id))
                {
                    currentDialog = _session[session.Id].CurrentDialog;
                    session.CurrentDialog = currentDialog;
                    _session[session.Id] = session;
                }
                else
                {
                    session.CurrentDialog = SESSION_START;
                    _session.Add(session.Id, session);
                }
            }

            if (string.IsNullOrEmpty(currentDialog))
            {
                return SendGreeting(session);
            }
            else
            {
                return SendUnknow(session);
            }
        }

        private Dialog SendGreeting(Session session)
        {
            return _dialogs[SESSION_START].GetAsTemplate(session, _script.Greetings);
        }

        private Dialog SendUnknow(Session session)
        {
            return new Dialog(session, _script.Unknow);
        }

        public void Dispose()
        {
            _cts.Cancel();
            _session.Clear();
        }
    }
}
