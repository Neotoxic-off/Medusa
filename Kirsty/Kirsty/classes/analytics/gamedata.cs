using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsty.classes.analytics
{
    class gamedata
    {
        public class Rootobject
        {
            public List<Event> events { get; set; }
        }

        public class Event
        {
            public string userId { get; set; }
            public string timestamp { get; set; }
            public string eventType { get; set; }
            public Data data { get; set; }
            public int eventTypeVersion { get; set; }
        }

        public class Data
        {
            public DateTime timestamp { get; set; }
            public string endpoints { get; set; }
            public string version { get; set; }
            public string mirrors_id { get; set; }
            public string client_id { get; set; }
            public string platform { get; set; }
            public string backend_env { get; set; }
            public string session_guid { get; set; }
            public int request_content_length { get; set; }
            public string content_type { get; set; }
            public float elapsed_time { get; set; }
            public string status { get; set; }
            public string url { get; set; }
            public string verb { get; set; }
            public int response_content_length { get; set; }
            public int response_code { get; set; }
            public int success { get; set; }
            public string game_flow_step { get; set; }
            public int total_physical { get; set; }
            public int total_virtual { get; set; }
            public int peak_used_physical { get; set; }
            public int peak_used_virtual { get; set; }
            public int available_physical { get; set; }
            public int available_virtual { get; set; }
            public string match_id { get; set; }
            public string lobby_id { get; set; }
            public DateTime step_change_timestamp { get; set; }
            public string loading_step { get; set; }
            public float time_on_prev_step { get; set; }
            public float total_load_time { get; set; }
            public string current_map_name { get; set; }
            public string transition_id { get; set; }
            public string current_context { get; set; }
            public float time_on_previous_context { get; set; }
            public DateTime context_change_timetamp { get; set; }
            public string previous_context { get; set; }
            public DateTime beat_time { get; set; }
            public int times_queued_survivor { get; set; }
            public int times_queued_killer { get; set; }
            public int matches_as_survivor { get; set; }
            public int matches_as_killer { get; set; }
            public string selected_country { get; set; }
            public string player_name { get; set; }
            public int first_time_playing { get; set; }
            public int cumulative_matches { get; set; }
            public int cumulative_matches_as_survivor { get; set; }
            public int cumulative_matches_as_killer { get; set; }
            public DateTime last_match_timestamp { get; set; }
            public DateTime session_start_timestamp { get; set; }
            public DateTime session_end_timestamp { get; set; }
            public DateTime last_session_timestamp { get; set; }
            public int cumulative_sessions { get; set; }
            public float cumulative_playtime { get; set; }
            public float time_in_character_menu { get; set; }
            public int time_in_bloodweb_menu { get; set; }
            public float time_in_loadout_menu { get; set; }
            public float time_in_customization_menu { get; set; }
            public int time_in_fear_market { get; set; }
            public int time_in_tally_screen { get; set; }
            public int time_in_game_match { get; set; }
            public int time_in_help_menu { get; set; }
            public int time_in_offline_lobby { get; set; }
            public int time_in_offline_lobby_survivor_group { get; set; }
            public int time_in_online_lobby { get; set; }
            public int time_in_online_lobby_survivor_group { get; set; }
        }
    }
}
