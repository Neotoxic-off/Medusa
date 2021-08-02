using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAVEFILE
{
    class savefile
    {
        public class Rootobject
        {
            public string playerUId { get; set; }
            public int selectedCamperIndex { get; set; }
            public int selectedSlasherIndex { get; set; }
            public bool firstTimePlaying { get; set; }
            public int consecutiveMatchStreak { get; set; }
            public bool hasBeenGivenKillerTutorialEndReward { get; set; }
            public bool hasBeenGivenSurvivorTutorialEndReward { get; set; }
            public long currentSeasonTicks { get; set; }
            public int lastConnectedCharacterIndex { get; set; }
            public DateTime disconnectPenaltyTime { get; set; }
            public DateTime lastMatchEndTime { get; set; }
            public DateTime lastMatchStartTime { get; set; }
            public DateTime lastKillerMatchEndTime { get; set; }
            public DateTime lastSurvivorMatchEndTime { get; set; }
            public DateTime ongoingGameTime { get; set; }
            public int cumulativeMatches { get; set; }
            public Pagevisited[] pageVisited { get; set; }
            public Chatvisible[] chatVisible { get; set; }
            public int cumulativeMatchesAsSurvivor { get; set; }
            public int cumulativeMatchesAsKiller { get; set; }
            public string lastMatchTimestamp { get; set; }
            public string lastSessionTimestamp { get; set; }
            public int cumulativeSessions { get; set; }
            public string cumulativePlaytime { get; set; }
            public Characterdata[] characterData { get; set; }
            public Dailyrituals dailyRituals { get; set; }
            public Lastloadout lastLoadout { get; set; }
            public Playerstatprogression[] playerStatProgression { get; set; }
            public string[] ownedContent { get; set; }
            public Bloodstorekillers bloodStoreKillers { get; set; }
            public Bloodstoresurvivors bloodStoreSurvivors { get; set; }
            public int versionNumber { get; set; }
        }

        public class Dailyrituals
        {
            public DateTime lastRitualReceivedDate { get; set; }
            public DateTime lastRitualPopupDate { get; set; }
            public DateTime lastRitualDismissedDate { get; set; }
            public Ritual[] rituals { get; set; }
        }

        public class Ritual
        {
            public string ritualKey { get; set; }
            public int[] characterIds { get; set; }
            public float progress { get; set; }
            public int threshold { get; set; }
            public int displayThreshold { get; set; }
            public int expReward { get; set; }
            public bool active { get; set; }
            public string dateAssigned { get; set; }
            public int nbGameElapsed { get; set; }
        }

        public class Lastloadout
        {
            public string item { get; set; }
            public string camperFavor { get; set; }
            public string power { get; set; }
            public string[] powerAddOns { get; set; }
            public string slasherFavor { get; set; }
        }

        public class Bloodstorekillers
        {
            public int versionNumber { get; set; }
            public int level { get; set; }
        }

        public class Bloodstoresurvivors
        {
            public int versionNumber { get; set; }
            public int level { get; set; }
        }

        public class Pagevisited
        {
            public string key { get; set; }
            public bool value { get; set; }
        }

        public class Chatvisible
        {
            public string key { get; set; }
            public bool value { get; set; }
        }

        public class Characterdata
        {
            public int key { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public int bloodWebLevel { get; set; }
            public int prestigeLevel { get; set; }
            public DateTime[] prestigeDates { get; set; }
            public Bloodwebdata bloodWebData { get; set; }
            public Characterloadoutdata characterLoadoutData { get; set; }
            public Inventory[] inventory { get; set; }
            public string[] currentCustomization { get; set; }
            public Currentcharmcustomization[] currentCharmCustomization { get; set; }
            public string[] uniquePerksAdded { get; set; }
            public int timesConfronted { get; set; }
            public Statprogression[] statProgression { get; set; }
        }

        public class Bloodwebdata
        {
            public int versionNumber { get; set; }
            public int level { get; set; }
            public Ringdata[] ringData { get; set; }
            public string[] paths { get; set; }
            public string generationDate { get; set; }
            public string entityCurrentNode { get; set; }
        }

        public class Ringdata
        {
            public Nodedata[] nodeData { get; set; }
        }

        public class Nodedata
        {
            public Properties properties { get; set; }
            public string state { get; set; }
            public string nodeId { get; set; }
            public string contentId { get; set; }
            public Bloodwebchest bloodwebChest { get; set; }
        }

        public class Properties
        {
            public string rarity { get; set; }
            public string contentType { get; set; }
            public string[] tags { get; set; }
        }

        public class Bloodwebchest
        {
            public string iD { get; set; }
            public string rarity { get; set; }
            public int[] givenItemRarity { get; set; }
        }

        public class Characterloadoutdata
        {
            public string item { get; set; }
            public string[] itemAddOns { get; set; }
            public string[] camperPerks { get; set; }
            public int[] camperPerkLevels { get; set; }
            public string camperFavor { get; set; }
            public string power { get; set; }
            public string[] powerAddOns { get; set; }
            public string slasherFavor { get; set; }
            public string[] slasherPerks { get; set; }
            public int[] slasherPerkLevels { get; set; }
        }

        public class Inventory
        {
            public string i { get; set; }
        }

        public class Currentcharmcustomization
        {
            public int slotIndex { get; set; }
            public string charmId { get; set; }
        }

        public class Statprogression
        {
            public string name { get; set; }
            public int value { get; set; }
        }

        public class Playerstatprogression
        {
            public string name { get; set; }
            public int value { get; set; }
        }
    }
}
