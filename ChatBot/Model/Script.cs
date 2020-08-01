using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ChatBot.Model
{
    public class Script
    {
        public string ChoosePhrase { get; set; }
        public string RestartPhrase { get; set; }
        public string ContinuePhrase { get; set; }

        public string[] Greetings { get; set; }
        public string[] Unknow { get; set; }
        
        public Dialog Start { get; set; }

        public Script()
        {
            ChoosePhrase = string.Empty;
            RestartPhrase = string.Empty;
            ContinuePhrase = string.Empty;

            Greetings = new string[0];
            Unknow = new string[0];
            Start = new Dialog();
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, JsonConvert.SerializeObject(this, Formatting.Indented), Encoding.UTF8);
        }

        public static Script LoadFromFile(string filename)
        {
            return JsonConvert.DeserializeObject<Script>(File.ReadAllText(filename, Encoding.UTF8));
        }
    }
}
