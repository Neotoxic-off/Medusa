using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghud.classes
{
    class guest
    {

        public class Rootobject
        {
            public Triggerresults triggerResults { get; set; }
            public string tokenId { get; set; }
            public int generated { get; set; }
            public int expire { get; set; }
            public string userId { get; set; }
            public string guestToken { get; set; }
        }

        public class Triggerresults
        {
            public object[] success { get; set; }
            public object[] error { get; set; }
        }

    }
}
