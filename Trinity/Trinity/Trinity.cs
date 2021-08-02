using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using RestSharp;

namespace Trinity
{
    public partial class Trinity : Form
    {
        Random rnd = new Random();
        string cookie = null;
        int shards_total = 0;

        public class Rootobject_error
        {
            public string type { get; set; }
            public string localizationCode { get; set; }
            public string message { get; set; }
        }

        public class Rootobject
        {
            public Levelinfo levelInfo { get; set; }
            public Xpgainbreakdown xpGainBreakdown { get; set; }
            public string extensionProgress { get; set; }
        }

        public class Levelinfo
        {
            public int totalXp { get; set; }
            public int currentXp { get; set; }
            public int level { get; set; }
            public int currentXpUpperBound { get; set; }
            public int levelVersion { get; set; }
            public int prestigeLevel { get; set; }
        }

        public class Xpgainbreakdown
        {
            public int consecutiveMatchMultiplier { get; set; }
            public int emblemsBonus { get; set; }
            public int baseMatchXp { get; set; }
            public string playerType { get; set; }
        }


        public class ALL_Rootobject
        {
            public ALL_Levelinfo levelInfo { get; set; }
            public ALL_Xpgainbreakdown xpGainBreakdown { get; set; }
            public ALL_Reachedlevel[] reachedLevels { get; set; }
            public ALL_Updatedwallet[] updatedWallet { get; set; }
            public ALL_Grantedcurrency[] grantedCurrencies { get; set; }
            public string extensionProgress { get; set; }
        }

        public class ALL_Levelinfo
        {
            public int totalXp { get; set; }
            public int levelVersion { get; set; }
            public int level { get; set; }
            public int prestigeLevel { get; set; }
            public int currentXp { get; set; }
            public int currentXpUpperBound { get; set; }
        }

        public class ALL_Xpgainbreakdown
        {
            public int baseMatchXp { get; set; }
            public int consecutiveMatchMultiplier { get; set; }
            public string playerType { get; set; }
            public int emblemsBonus { get; set; }
        }

        public class ALL_Reachedlevel
        {
            public int level { get; set; }
            public int prestigeLevel { get; set; }
            public int xpUpperBound { get; set; }
        }

        public class ALL_Updatedwallet
        {
            public string currency { get; set; }
            public int balance { get; set; }
        }

        public class ALL_Grantedcurrency
        {
            public string currency { get; set; }
            public int balance { get; set; }
        }


        public Trinity()
        {
            InitializeComponent();
            logs("Ready", Color.FromArgb(46, 213, 115)).Wait();
        }

        private Task logs(string message, Color color)
        {
            if (status.InvokeRequired)
            {
                status.Invoke(new MethodInvoker(delegate
                {
                    status.Text = message;
                    status.ForeColor = color;
                }));
            } else
            {
                status.Text = message;
                status.ForeColor = color;
            }
            
            return (Task.CompletedTask);
        }

        private void _value_Scroll(object sender, EventArgs e)
        {
            resume_shards.Text = shards_value.Value.ToString();
        }

        private string emblem()
        {
            string[] emblems = { "\"Bronze\"", "\"Silver\"", "\"Gold\"", "\"Iridescent\"" };

            return (emblems[rnd.Next(0, emblems.Length)]);
        }

        public Task parser(string response)
        {
            Rootobject weps = JsonConvert.DeserializeObject<Rootobject>(response);
            ALL_Rootobject ALL_weps = JsonConvert.DeserializeObject<ALL_Rootobject>(response);

            if (weps.levelInfo != null)
            {
                if (user_level.InvokeRequired)
                {
                    user_level.Invoke(new Action(() =>
                    {
                        user_level.Text = weps.levelInfo.level.ToString();
                        user_prestige.Text = weps.levelInfo.prestigeLevel.ToString();
                        user_experience.Text = weps.levelInfo.totalXp.ToString();

                        user_level.Refresh();
                        user_prestige.Refresh();
                        user_experience.Refresh();
                    }));
                } else
                {
                    user_level.Text = weps.levelInfo.level.ToString();
                    user_prestige.Text = weps.levelInfo.prestigeLevel.ToString();
                    user_experience.Text = weps.levelInfo.totalXp.ToString();

                    user_level.Refresh();
                    user_prestige.Refresh();
                    user_experience.Refresh();
                }
            }
            
            if (ALL_weps.grantedCurrencies != null)
            {
                if (user_shards.InvokeRequired)
                {
                    user_shards.Invoke(new Action(() =>
                    {
                        shards_total += ALL_weps.grantedCurrencies[0].balance;

                        user_shards.Text = shards_total.ToString();
                        user_shards.Refresh();

                        user_total.Text = ALL_weps.updatedWallet[0].balance.ToString();
                        user_total.Refresh();
                    }));
                }
                else
                {
                    shards_total += ALL_weps.grantedCurrencies[0].balance;

                    user_shards.Text = shards_total.ToString();
                    user_shards.Refresh();

                    user_total.Text = ALL_weps.updatedWallet[0].balance.ToString();
                    user_total.Refresh();
                }
            }
            return (Task.CompletedTask);
        }

        private int gameTime()
        {
            return (rnd.Next(1, 1000) + 700);
        }

        private string RequestAsync(int levelversion)
        {
            string json = "{" +
                "\"data\":" +
                    "{\"consecutiveMatch\":1," +
                    "\"emblemQualities\":[" +
                            emblem() + "," +
                            emblem() + "," +
                            emblem() + "," +
                            emblem() +
                        "],\"isFirstMatch\":false," +
                        "\"krakenMatchId\":\"ab472806 -ee58-4c7c-a00e-de0e2533bb33\"," +
                        "\"levelVersion\":" + levelversion +
                        ",\"matchId\":\"19D45520-4080-45E6-8D85-ECD22C93033C\"" +
                        ",\"matchTime\":" + gameTime() +
                        ",\"platformVersion\":\"steam\",\"playerType\":\"survivor\"}}";
            var client = new RestClient();
            var bhvr_request = new RestRequest("https://steam.live.bhvrdbd.com/api/v1/extensions/playerLevels/earnPlayerXp")
                .AddHeader("Accept-Encoding", "deflate, gzip")
                .AddHeader("Accept", "*/*")
                .AddHeader("Content-Type", "application/json")
                .AddCookie("bhvrSession", cookie)
                .AddJsonBody(json);
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-377698 Windows/10.0.19042.1.768.64bit";
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine(response);
            return (response.Content);
        }

        private int levelVersionAsync()
        {
            int level = 0;
            var response = RequestAsync(level);
            Rootobject_error data = JsonConvert.DeserializeObject<Rootobject_error>(response);
            Rootobject weps = JsonConvert.DeserializeObject<Rootobject>(response);

            if (data == null || data.message == "Operation not allowed, invalid authTokenId")
            {
                logs("Invalid bhvrSession", Color.FromArgb(255, 71, 87)).Wait();
                return (-1);
            }
            else
            {
                if (weps.levelInfo != null)
                    level = weps.levelInfo.levelVersion;
            }
            return (level);
        }

        public static void thread_child()
        {
            Console.WriteLine("Child thread starts");
        }

        private async Task<Task> core()
        {
            int levelversion = 0;
            int limit = 0;
            string response = null;

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                logs("Running...", Color.FromArgb(255, 165, 2)).Wait();
                cookie = Clipboard.GetText(TextDataFormat.Text);
                levelversion = levelVersionAsync();

                if (levelversion >= 0)
                {
                    limit = int.Parse(resume_shards.Text);

                    while (shards_total < limit)
                    {
                        response = RequestAsync(levelversion);
                        await parser(response);
                        levelversion++;
                    }
                    logs("Shards added", Color.FromArgb(46, 213, 115)).Wait();
                }
            }
            else
            {
                logs("Copy your bhvrSession first", Color.FromArgb(255, 71, 87)).Wait();
            }
            return (Task.CompletedTask);
        }

        private void run_Click(object sender, EventArgs e)
        {
            run.ForeColor = Color.Gray;
            run.BackColor = Color.Gray;
            run.Enabled = false;
            shards_value.Enabled = false;

            core().Wait();

            run.ForeColor = Color.White;
            run.BackColor = Color.FromArgb(255, 71, 87);
            run.Enabled = true;
            shards_value.Enabled = true;
        }

        private void Trinity_Load(object sender, EventArgs e)
        {
            resume_shards.Text = shards_value.Value.ToString();
        }
    }
}
