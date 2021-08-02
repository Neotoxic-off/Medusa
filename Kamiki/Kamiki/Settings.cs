using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETTINGS
{
    class settings
    {
        public class Rootobject
        {
            public string theme { get; set; }
            public Update update { get; set; }
            public Sound sound { get; set; }
        }

        public class Update
        {
            public bool check { get; set; }
            public bool display { get; set; }
        }

        public class Sound
        {
            public bool enabled { get; set; }
            public string launch { get; set; }
            public string save { get; set; }
            public string theme { get; set; }
            public bool play_theme { get; set; }
        }
    }
}
