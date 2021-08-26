using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class earnplayer
    {
        public class Rootobject
        {
            public Levelinfo levelInfo { get; set; }
            public Xpgainbreakdown xpGainBreakdown { get; set; }
            public string extensionProgress { get; set; }
        }

        public class Levelinfo
        {
            public int totalXp { get; set; }
            public int levelVersion { get; set; }
            public int level { get; set; }
            public int prestigeLevel { get; set; }
            public int currentXp { get; set; }
            public int currentXpUpperBound { get; set; }
        }

        public class Xpgainbreakdown
        {
            public int baseMatchXp { get; set; }
            public int consecutiveMatchMultiplier { get; set; }
            public string playerType { get; set; }
            public int firstMatchBonus { get; set; }
            public int emblemsBonus { get; set; }
        }

    }
}
