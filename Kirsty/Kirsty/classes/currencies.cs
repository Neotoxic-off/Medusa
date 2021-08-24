using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class currencies
    {
        public class Rootobject
        {
            public List<Data> list { get; set; }
        }

        public class Data
        {
            public int balance { get; set; }
            public string currency { get; set; }
        }

    }
}
