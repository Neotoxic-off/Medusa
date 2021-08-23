using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class steam
    {
        public class Rootobject
        {
            public Providerplayernames providerPlayerNames { get; set; }
            public string userId { get; set; }
            public string playerName { get; set; }
            public bool unchanged { get; set; }
        }

        public class Providerplayernames
        {
            public string steam { get; set; }
        }
    }
}
