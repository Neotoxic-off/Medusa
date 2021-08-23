using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class playername
    {
        public class Rootobject
        {
            public string userId { get; set; }
            public Providerplayernames providerPlayerNames { get; set; }
            public string playerName { get; set; }
        }

        public class Providerplayernames
        {
            public string steam { get; set; }
        }
    }
}
