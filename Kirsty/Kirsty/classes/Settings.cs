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
            public string url { get; set; }
            public Streammer streammer { get; set; }
            public Unlocker unlocker { get; set; }
        }

        public class Streammer
        {
            public bool activated { get; set; }
            public string username { get; set; }
            public string tag { get; set; }
        }

        public class Unlocker
        {
            public Tomes tomes { get; set; }
        }

        public class Tomes
        {
            public bool unlock { get; set; }
            public string url { get; set; }
        }
    }
}
