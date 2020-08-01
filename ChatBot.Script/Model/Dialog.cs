using System;
using System.Reflection;
using System.Collections.Generic;

namespace ChatBot.Core.Model
{
    public class Dialog
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string[] Phrases { get; set; }
        public Dialog[] Dialogs { get; set; }

        public Dialog()
        {
            Id = Guid.NewGuid().ToString("N");
            Phrases = new string[0];
            Dialogs = new Dialog[0];
        }

        public Dialog(Session session, string[] phrases, Dialog[] dialogs = null)
        {
            Id = Guid.NewGuid().ToString("N");
            Phrases = GetPhrases(session, phrases);
            Dialogs = dialogs ?? new Dialog[0];
        }

        public Dialog GetAsTemplate(Session session, string[] phrases = null)
        {
            return new Dialog()
            {
                Id = Id,
                Label = Label,
                Phrases = GetPhrases(session, phrases, Phrases),
                Dialogs = Dialogs
            };
        }

        private string[] GetPhrases(Session session, string[] phrases1, string[] phrases2 = null)
        {
            var phrases = new List<string>();

            if (phrases1 != null)
                phrases.AddRange(phrases1);
            if (phrases2 != null)
                phrases.AddRange(phrases2);

            for (var i=0; i<phrases.Count; i++)
            {
                var phrase = phrases[i];
                foreach (var property in session.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    var tag = string.Concat("{{", property.Name, "}}");
                    if (phrase.IndexOf(tag, StringComparison.Ordinal) > -1)
                    {
                        var value = Convert.ToString(property.GetValue(session, null));
                        phrase = phrase.Replace(tag, value);
                        phrases[i] = phrase;
                    }
                }
            }

            return phrases.ToArray();
        }
    }
}
