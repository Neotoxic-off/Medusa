using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrie.Settings
{
    public class Profile
    {
        public class Rootobject
        {
            public Kyrie Kyrie { get; set; }
        }

        public class Kyrie
        {
            public string version { get; set; }
            public string mod { get; set; }
            public List<Module> modules { get; set; }
        }

        public class Module
        {
            public string name { get; set; }
            public string url { get; set; }
        }
    }
}
