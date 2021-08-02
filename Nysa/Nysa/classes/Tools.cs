﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nysa.classes
{
    class Tools
    {
        public class Rootobject
        {
            public string version { get; set; }
            public Color color { get; set; }
            public Tool[] tools { get; set; }
        }

        public class Tool
        {
            public string name { get; set; }
            public string link { get; set; }
            public string version { get; set; }
        }

    }
}
