using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes
{
    class login
    {


        public class Rootobject
        {
            public string preferredLanguage { get; set; }
            public Friendsfirstsync friendsFirstSync { get; set; }
            public int creationDate { get; set; }
            public Fixedmyfriendsuserplatformid fixedMyFriendsUserPlatformId { get; set; }
            public string id { get; set; }
            public Provider provider { get; set; }
            public Providers[] providers { get; set; }
            public object[] friends { get; set; }
            public Triggerresults triggerResults { get; set; }
            public string tokenId { get; set; }
            public int generated { get; set; }
            public int expire { get; set; }
            public string userId { get; set; }
            public string token { get; set; }
        }

        public class Friendsfirstsync
        {
            public bool steam { get; set; }
        }

        public class Fixedmyfriendsuserplatformid
        {
            public bool steam { get; set; }
        }

        public class Provider
        {
            public string providerId { get; set; }
            public string providerName { get; set; }
            public string userId { get; set; }
        }

        public class Triggerresults
        {
            public object[] success { get; set; }
            public object[] error { get; set; }
        }

        public class Providers
        {
            public string providerName { get; set; }
            public string providerId { get; set; }
        }
    }
}
