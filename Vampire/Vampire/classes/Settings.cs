using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vampire.classes
{
    class Settings
    {
        public class Rootobject
        {
            public List<data> list { get; set; }
        }

        public class data
        {
            public int balance { get; set; }
            public string currency { get; set; }
        }

        public class Rootobject_error
        {
            public string type { get; set; }
            public string localizationCode { get; set; }
            public string message { get; set; }
        }
    }
}
