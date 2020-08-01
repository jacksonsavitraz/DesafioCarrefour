using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBot.Core.Model
{
    public class Script
    {
        public string[] Greetings { get; set; }
        public string[] Unknow { get; set; }
        public Dialog Start { get; set; }

        public Script()
        {

        }
    }
}
