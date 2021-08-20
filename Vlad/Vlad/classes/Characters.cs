using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlad.classes
{
    class Characters
    {

        public class Rootobject
        {
            public List<Survivor> survivors { get; set; }
            public List<Killer> killers { get; set; }
        }

        public class Survivor
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Killer
        {
            public int id { get; set; }
            public string name { get; set; }
        }
    }
}
