using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ana_kata.settings
{
    public class Profile
    {
        public class Rootobject
        {
            public bool autorun { get; set; }
            public bool dev_mod { get; set; }
            public Cookie cookie { get; set; }
            public Market market { get; set; }
        }

        public class Market
        {
            public bool autoupdate { get; set; }
            public bool activate { get; set; }
            public string path { get; set; }
        }

        public class Cookie
        {
            public bool autosave { get; set; }
        }
    }
}
