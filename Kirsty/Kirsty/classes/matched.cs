using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class matched
    {
        public class Rootobject
        {
            public string status { get; set; }
            public Matchdata matchData { get; set; }
        }

        public class Matchdata
        {
            public string matchId { get; set; }
            public int schema { get; set; }
            public string category { get; set; }
            public int rank { get; set; }
            public Geolocation geolocation { get; set; }
            public long creationDateTime { get; set; }
            public string status { get; set; }
            public string creator { get; set; }
            public Customdata customData { get; set; }
            public int version { get; set; }
            public Skill skill { get; set; }
            public int churn { get; set; }
            public Props props { get; set; }
            public string reason { get; set; }
            public string region { get; set; }
            public string[] sideA { get; set; }
            public string[] sideB { get; set; }
        }

        public class Geolocation
        {
        }

        public class Customdata
        {
            public string SessionSettings { get; set; }
        }

        public class Skill
        {
            public string country { get; set; }
            public string continent { get; set; }
            public Rating rating { get; set; }
            public int rank { get; set; }
            public int version { get; set; }
            public int x { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public Regions regions { get; set; }
        }

        public class Rating
        {
            public float rating { get; set; }
            public float RD { get; set; }
            public float volatility { get; set; }
        }

        public class Regions
        {
            public string[] good { get; set; }
            public string[] ok { get; set; }
        }

        public class Props
        {
            public string EncryptionKey { get; set; }
            public int countA { get; set; }
            public int countB { get; set; }
            public string gameMode { get; set; }
            public string platform { get; set; }
            public string CrossplayOptOut { get; set; }
            public string characterName { get; set; }
        }
    }
}
