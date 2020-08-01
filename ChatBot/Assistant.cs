using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using ChatBot.Model;

namespace ChatBot
{
    public class Assistant : IDisposable
    {
        private const int SESSION_TIMEOUT = 60;
        private const string SESSION_START = "start";
       
        private readonly Script _script;
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly Dictionary<string, Dialog> _dialogs = new Dictionary<string, Dialog>();
        private readonly Dictionary<long, Session> _session = new Dictionary<long, Session>();
        private readonly object _semaphore = new object();

        public Assistant(string filename)
        {
            _script = Script.LoadFromFile(filename);
            _script.Start.Id = SESSION_START;
            AddDialog(_script.Start);

            Run();
        }

        public Assistant(Script script)
        {
            _script = script;
            _script.Start.Id = SESSION_START;
            AddDialog(_script.Start);
            
            Run();
        }

        private void Run()
        {
            var thread = new Thread(AssistantLoop) { IsBackground = true };
            thread.Start();
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

                Thread.Sleep(TimeSpan.FromMinutes(1));
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
                if (!string.IsNullOrEmpty(dialog.Goto) && _dialogs.ContainsKey(dialog.Goto))
                {
                    lock (_semaphore)
                    {
                        session.CurrentDialog = dialog.Goto;
                        _session[session.Id] = session;
                    }

                    var next = _dialogs[dialog.Goto].GetAsTemplate(session);
                    if (dialog.Phrases.Length > 0)
                        next.Phrases = dialog.Phrases;
                    return next.GetAsTemplate(session);
                }
                else
                {
                    return dialog.GetAsTemplate(session);
                }
            }
            else
            {
                return SendUnknow(session);
            }
        }

        public Dialog GetResponseForText(Session session, string text)
        {
            var currentDialog = string.Empty;

            if (text.Equals("/start", StringComparison.OrdinalIgnoreCase))
            {
                lock (_semaphore)
                {
                    if (_session.ContainsKey(session.Id))
                    {
                        session.CurrentDialog = SESSION_START;
                        _session[session.Id] = session;
                    }
                    else
                    {
                        session.CurrentDialog = SESSION_START;
                        _session.Add(session.Id, session);
                    }
                }
            }
            else
            {
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
            }

            if (string.IsNullOrEmpty(currentDialog))
            {
                return SendGreeting(session);
            }
            else
            {
                if (_dialogs.ContainsKey(currentDialog))
                {
                    var dialog = _dialogs[currentDialog];
                    text = string.Concat(' ', text, ' ');
                    foreach (var choice in dialog.Dialogs.OrderByDescending(d => d.Label.Length))
                    {
                        if (string.Concat(' ', choice.Label, ' ').IndexOf(text, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            if (!string.IsNullOrEmpty(choice.Goto) && _dialogs.ContainsKey(choice.Goto))
                            {
                                lock (_semaphore)
                                {
                                    session.CurrentDialog = choice.Goto;
                                    _session[session.Id] = session;
                                }
                                var next = _dialogs[choice.Goto].GetAsTemplate(session);
                                if (choice.Phrases.Length > 0)
                                    next.Phrases = choice.Phrases;
                                return next.GetAsTemplate(session);
                            }
                            else
                            {
                                lock (_semaphore)
                                {
                                    session.CurrentDialog = choice.Id;
                                    _session[session.Id] = session;
                                }
                                return choice.GetAsTemplate(session);
                            }
                        }
                    }
                }
                return SendUnknow(session);
            }
        }

        private Dialog SendGreeting(Session session)
        {
            return _dialogs[SESSION_START].GetAsTemplate(session, _script.Greetings);
        }

        private Dialog SendUnknow(Session session)
        {
            if (string.IsNullOrEmpty(session.CurrentDialog))
            {
                return new Dialog(session, _script.Unknow);
            }
            else
            {
                var options = new List<Dialog>();

                var restart = _dialogs[SESSION_START].GetAsTemplate(session);
                if (!string.IsNullOrEmpty(_script.RestartPhrase))
                    restart.Label = _script.RestartPhrase;
                options.Add(restart);

                var dialog = _dialogs[session.CurrentDialog].GetAsTemplate(session);
                if (!string.IsNullOrEmpty(_script.ContinuePhrase))
                    dialog.Label = string.Concat(_script.ContinuePhrase, " ", dialog.Label);
                if (!dialog.Id.Equals(SESSION_START, StringComparison.Ordinal))
                    options.Add(dialog);

                return new Dialog(session, _script.Unknow, options.ToArray());
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
            _session.Clear();
            _dialogs.Clear();
        }
    }
}
