using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Amsterdam.Text
{
    public class CharacterSet
    {
        public int LineHeight { get; set; }
        public int DefaultBaseline { get; set; } = 1;
        public List<Character> Characters { get; set; } = new List<Character>();

        public Character this[char representor] {
            get { return Characters.Find(c => c.RepresentingChar == representor); }
        }

        public static CharacterSet FromJson(string path) {
            return JsonConvert.DeserializeObject<CharacterSet>(File.ReadAllText(path));
        }
    }
}
