using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlad.classes
{
    class Perks
    {
        public class Rootobject
        {
            public Survivors survivors { get; set; }
            public Killers killers { get; set; }
        }

        public class Survivors
        {
            public string[] normal { get; set; }
            public string[] teachable { get; set; }
        }

        public class Killers
        {
            public string[] normal { get; set; }
            public string[] teachable { get; set; }
        }

    }
}
