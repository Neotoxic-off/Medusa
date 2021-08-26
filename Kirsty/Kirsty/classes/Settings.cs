using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class Settings
    {
        public class Rootobject
        {
            public bool autorun { get; set; }
            public bool discord { get; set; }
            public string market { get; set; }
            public bool activated { get; set; }
            public string url { get; set; }
            public Streammer streammer { get; set; }
        }

        public class Streammer
        {
            public bool activated { get; set; }
            public string username { get; set; }
            public string tag { get; set; }
            public bool penality { get; set; }
            public int level { get; set; }
            public int devotion { get; set; }
            public Currencies currencies { get; set; }
            public Pips pips { get; set; }
        }

        public class Currencies
        {
            public int cells { get; set; }
            public int shards { get; set; }
            public int bloodpoints { get; set; }
        }

        public class Pips
        {
            public int survivors { get; set; }
            public int killers { get; set; }
        }
    }
}
