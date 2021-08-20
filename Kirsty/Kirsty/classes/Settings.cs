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
            public string market { get; set; }
            public Streammer streammer { get; set; }
        }

        public class Streammer
        {
            public bool activated { get; set; }
            public string username { get; set; }
        }
    }
}
