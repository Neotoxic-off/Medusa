using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dies_Irae.Profile
{
    public class Settings
    {
        public class Rootobject
        {
            public Data data { get; set; }
        }

        public class Data
        {
            public decimal numeric_magic { get; set; }
            public decimal numeric_string_minimum_size { get; set; }
        }

    }
}
