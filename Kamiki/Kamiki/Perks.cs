using System.Collections.Generic;

namespace PERKS
{
    public class perks
    {
        string[] survivors =
        {
            "Ace_In_The_Hole",
            "Adrenaline",
            "Aftercare",
            "Alert",
            "AnyMeansNecessary",
            "Autodidact",
            "Babysitter",
            "Balanced_Landing",
            "BetterTogether",
            "BloodPact",
            "BoilOver",
            "Bond",
            "BorrowedTime",
            "Botany_Knowledge",
            "Breakdown",
            "Breakout",
            "BuckleUp",
            "BuiltToLast",
            "Calm_Spirit",
            "Camaraderie",
            "Dance_with_me",
            "Dark_Sense",
            "DeadHard",
            "DecisiveStrike",
            "Deja_Vu",
            "Deliverance",
            "DesperateMeasures",
            "DetectivesHunch",
            "Distortion",
            "Diversion",
            "Empathy",
            "Fixated",
            "FlipFlop",
            "ForThePeople",
            "HeadOn",
            "Hope",
            "InnerStrength",
            "Iron_Will",
            "Kindred",
            "Leader",
            "LeftBehind",
            "Lightweight",
            "Lithe",
            "LuckyBreak",
            "No_One_Left_Behind",
            "NoMither",
            "ObjectOfObsession",
            "OffTheRecord",
            "Open_Handed",
            "Pharmacy",
            "Plunderers_Instinct",
            "Poised",
            "Premonition",
            "Prove_Thyself",
            "QuickQuiet",
            "RedHerring",
            "RepressedAlliance",
            "Resilience",
            "Saboteur",
            "SecondWind",
            "Self_Care",
            "SelfSufficient",
            "Slippery_Meat",
            "Small_Game",
            "SoleSurvivor",
            "Solidarity",
            "SoulGuard",
            "Spine_Chill",
            "Sprint_Burst",
            "StakeOut",
            "Streetwise",
            "Technician",
            "Tenacity",
            "TheMettleOfMan",
            "This_Is_Not_Happening",
            "Up_The_Ante",
            "Urban_Evasion",
            "Vigil",
            "Visionary",
            "WakeUp",
            "WellMakeIt",
            "WereGonnaLiveForever",
            "WindowsOfOpportunity",
            "S24P01",
            "S24P02",
            "S24P03",

            "Last_Standing"
        };
   
        string[] teach_survivors = {
             // Claudette
            "Botany_Knowledge_TEACH_",
            "Empathy_TEACH_",
            "Self_Care_TEACH_",

                    // BILL
            "BorrowedTime_TEACH_",
            "LeftBehind_TEACH_",
            "SelfSufficient_TEACH_",

                    // DWIGHT
            "Bond_TEACH_",
            "Leader_TEACH_",
            "Prove_Thyself_TEACH_",

                    // MEG
            "Adrenaline_TEACH_",
            "QuickQuiet_TEACH_",
            "Sprint_Burst_TEACH_",

                    // JAKE
            "Calm_Spirit_TEACH_",
            "Iron_Will_TEACH_",
            "Saboteur_TEACH_",

                    // NEA
            "Balanced_Landing_TEACH_",
            "Streetwise_TEACH_",
            "Urban_Evasion_TEACH_",

                    // LAURIE
            "DecisiveStrike_TEACH_",
            "ObjectOfObsession_TEACH_",
            "SoleSurvivor_TEACH_",

                    // ACE
            "Ace_In_The_Hole_TEACH_",
            "Open_Handed_TEACH_",
            "Up_The_Ante_TEACH_",

                    // FENG
            "Alert_TEACH_",
            "Lithe_TEACH_",
            "Technician_TEACH_",

                    // DAVID
            "DeadHard_TEACH_",
            "NoMither_TEACH_",
            "WereGonnaLiveForever_TEACH_",

                    // QUENTIN
            "Pharmacy_TEACH_",
            "Vigil_TEACH_",
            "WakeUp_TEACH_",

                    // TAPP
            "DetectivesHunch_TEACH_",
            "StakeOut_TEACH_",
            "Tenacity_TEACH_",

                    // ADAM
            "Autodidact_TEACH_",
            "Deliverance_TEACH_",
            "Diversion_TEACH_",

                    // KATE
            "BoilOver_TEACH_",
            "Dance_with_me_TEACH_",
            "WindowsOfOpportunity_TEACH_",

                    // JEFF
            "Aftercare_TEACH_",
            "Breakdown_TEACH_",
            "Distortion_TEACH_",

                    // JANE
            "HeadOn_TEACH_",
            "Poised_TEACH_",
            "Solidarity_TEACH_",

                    // ASH
            "BuckleUp_TEACH_",
            "FlipFlop_TEACH_",
            "TheMettleOfMan_TEACH_",

                    // NANCY
            "BetterTogether_TEACH_",
            "Fixated_TEACH_",
            "InnerStrength_TEACH_",

                    // STEVE
            "Babysitter_TEACH_",
            "Camaraderie_TEACH_",
            "SecondWind_TEACH_",

                    // YUI
            "AnyMeansNecessary_TEACH_",
            "Breakout_TEACH_",
            "LuckyBreak_TEACH_",

                    // ZARINA
            "ForThePeople_TEACH_",
            "OffTheRecord_TEACH_",
            "RedHerring_TEACH_",

                    // CHERYL
            "BloodPact_TEACH_",
            "RepressedAlliance_TEACH_",
            "SoulGuard_TEACH_",

                    // FELIX
            "BuiltToLast_TEACH_",
            "DesperateMeasures_TEACH_",
            "Visionary_TEACH_",

                    // ELODIE
            "S24P01_TEACH_",
            "S24P02_TEACH_",
            "S24P03_TEACH_",
        };

        string[] killers =
        {
            "Agitation",
            "Bamboozle",
            "BBQAndChilli",
            "BeastOfPrey",
            "Bitter_Murmur",
            "BloodEcho",
            "Bloodhound",
            "BloodWarden",
            "Brutal_Strength",
            "CorruptIntervention",
            "Coulrophobia",
            "CruelConfinement",
            "DarkDevotion",
            "DeadMansSwitch",
            "Deathbound",
            "Deerstalker",
            "Discordance",
            "Distressing",
            "DragonsGrip",
            "Dying_Light",
            "Enduring",
            "FireUp",
            "ForcedPenance",
            "FranklinsLoss",
            "FurtiveChase",
            "Gearhead",
            "GeneratorOvercharge",
            "HangmansTrick",
            "Hex_Devour_Hope",
            "Hex_HauntedGround",
            "Hex_HuntressLullaby",
            "Hex_Ruin",
            "Hex_The_Third_Seal",
            "Hex_Thrill_Of_The_Hunt",
            "HexBloodFavor",
            "HexRetribution",
            "HexUndying",
            "ImAllEars",
            "InfectiousFright",
            "Insidious",
            "InTheDark",
            "Iron_Grasp",
            "IronMaiden",
            "K22P01",
            "K22P02",
            "K22P03",
            "Lightborn",
            "MadGrit",
            "MakeYourChoice",
            "MonitorAndAbuse",
            "Monstrous_Shrine",
            "Nemesis",
            "No_One_Escapes_Death",
            "NurseCalling",
            "OverwhelmingPresence",
            "Play_With_Your_Food",
            "pop_goes_the_weasel",
            "Predator",
            "Rancor",
            "RememberMe",
            "Save_The_Best_For_Last",
            "Shadowborn",
            "Sloppy_Butcher",
            "Spies_From_The_Shadows",
            "SpiritFury",
            "Stridor",
            "Surge",
            "Surveillance",
            "TerritorialImperative",
            "Thanatophobia",
            "ThrillingTremors",
            "Tinkerer",
            "TrailofTorment",
            "Unnerving_Presence",
            "Unrelenting",
            "Whispers",
            "ZanshinTactics"
        };

        string[] teach_killers = 
        {
                    // FREDDY
            "BloodWarden_TEACH_",
            "FireUp_TEACH_",
            "RememberMe_TEACH_",
            
                    // HILLBILLY
            "Enduring_TEACH_",
            "Lightborn_TEACH_",
            "Tinkerer_TEACH_",

                    // HUNTRESS
            "BeastOfPrey_TEACH_",
            "Hex_HuntressLullaby_TEACH_",
            "TerritorialImperative_TEACH_",

                    // TRAPPER
            "Agitation_TEACH_",
            "Brutal_Strength_TEACH_",
            "Unnerving_Presence_TEACH_",
            
                    // LEATHERFACE
            "BBQAndChilli_TEACH_",
            "FranklinsLoss_TEACH_",
            "InTheDark_TEACH_",
            
                    // WRAITH
            "Bloodhound_TEACH_",
            "Predator_TEACH_",
            "Shadowborn_TEACH_",
            
                    // NURSE
            "NurseCalling_TEACH_",
            "Stridor_TEACH_",
            "Thanatophobia_TEACH_",
            
                    // MEYERS
            "Dying_Light_TEACH_",
            "Play_With_Your_Food_TEACH_",
            "Save_The_Best_For_Last_TEACH_",
            
            // HAG
            "Hex_Devour_Hope_TEACH_",
            "Hex_Ruin_TEACH_",
            "Hex_The_Third_Seal_TEACH_",
                    
                    // DOCTOR
            "GeneratorOvercharge_TEACH_",
            "MonitorAndAbuse_TEACH_",
            "OverwhelmingPresence_TEACH_",
                    
                    // PIG
            "HangmansTrick_TEACH_",
            "MakeYourChoice_TEACH_",
            "Surveillance_TEACH_",
                    
                    // SPIRIT
            "Hex_HauntedGround_TEACH_",
            "Rancor_TEACH_",
            "SpiritFury_TEACH_",
                    
                    // CLOWN
            "Bamboozle_TEACH_",
            "Coulrophobia_TEACH_",
            "pop_goes_the_weasel_TEACH_",
                    
                    // LEGION
            "Discordance_TEACH_",
            "Ironmaiden_TEACH_",
            "Madgrit_TEACH_",
                    
                    // PLAGUE
            "CorruptIntervention_TEACH_",
            "DarkDevotion_TEACH_",
            "InfectiousFright_TEACH_",
                    
                    // GHOSTFACE
            "FurtiveChase_TEACH_",
            "ImAllEars_TEACH_",
            "ThrillingTremors_TEACH_",
                    
                    // DEMOGORGON
            "CruelConfinement_TEACH_",
            "Mindbreaker_TEACH_",
            "Surge_TEACH_",
                    
                    // ONI
            "BloodEcho_TEACH_",
            "Nemesis_TEACH_",
            "ZanshinTactics_TEACH_",
                    
                    // DEATHSLINGER
            "DeadMansSwitch_TEACH_",
            "Gearhead_TEACH_",
            "HexRetribution_TEACH_",
                    
                    // PYRAMID HEAD
            "Deathbound_TEACH_",
            "ForcedPenance_TEACH_",
            "TrailofTorment_TEACH_",
                    
                    // BLIGHT
            "DragonsGrip_TEACH_",
            "HexBloodFavor_TEACH_",
            "HexUndying_TEACH_",
                    
                    // TWIN
            "K22P01_TEACH_",
            "K22P02_TEACH_",
            "K22P03_TEACH_",
        };

        public bool GPS(string key)
        {
            for (int i = 0; i < survivors.Length; i++)
            {
                if (key.Contains(survivors[i].ToLower()))
                    return (true);
            }
            return (false);
        }

        public bool GPTS(string key)
        {
            for (int i = 0; i < teach_survivors.Length; i++)
            {
                if (key.Contains(teach_survivors[i].ToLower()))
                    return (true);
            }
            return (false);
        }

        public bool GPK(string key)
        {
            for (int i = 0; i < killers.Length; i++)
            {
                if (key.Contains(killers[i].ToLower()))
                    return (true);
            }
            return (false);
        }

        public bool GPTK(string key)
        {
            for (int i = 0; i < teach_killers.Length; i++)
            {
                if (key.Contains(teach_killers[i].ToLower()))
                    return (true);
            }
            return (false);
        }
    }
}
