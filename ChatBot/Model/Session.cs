using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBot.Model
{
    public class Session
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string CurrentDialog { get; set; }
        public DateTime Timestamp { get; set; }

        public Session()
        {
            Timestamp = DateTime.UtcNow;
        }
    }
}
