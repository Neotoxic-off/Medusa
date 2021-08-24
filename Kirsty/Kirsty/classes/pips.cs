using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class pips
    {
        public class Rootobject
        {
            public Pips pips { get; set; }
            public bool seasonRefresh { get; set; }
        }

        public class Pips
        {
            public int survivorPips { get; set; }
            public int killerPips { get; set; }
        }
    }
}
