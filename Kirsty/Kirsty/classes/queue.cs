using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class queue
    {
        public class Rootobject
        {
            public string status { get; set; }
            public Queuedata queueData { get; set; }
        }

        public class Queuedata
        {
            public float ETA { get; set; }
            public int position { get; set; }
            public bool stable { get; set; }
            public int sizeA { get; set; }
            public int sizeB { get; set; }
        }

    }
}
