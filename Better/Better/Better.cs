using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;

namespace Better
{
    public partial class Better : Form
    {
        bool mouse_down = false;
        private Point offset;

        static string icons = "icons";
        string survivor = $"{icons}\\survivor";
        string killer = $"{icons}\\killer";
        string cookie = null;

        Random rnd = new Random();

        private string emblem()
        {
            string[] emblems = { "\"Bronze\"", "\"Silver\"", "\"Gold\"", "\"Iridescent\"" };

            return (emblems[rnd.Next(0, emblems.Length)]);
        }

        private int gameTime()
        {
            return (rnd.Next(100, 2000) + 800);
        }

        public Better()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void about_Click(object sender, EventArgs e)
        {
            string about_data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(about_data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process.Start("https://discord.gg/Y7YagcPXh8");
            Cursor = Cursors.Default;
        }

        private void coffee_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            MessageBox.Show("Paypal: neotoxic.off@gmail.com\n\nHave a nice day", "Buy me a coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor = Cursors.Default;
        }

        private void border_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;

            mouse_down = true;
        }

        private void border_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down == true)
            {
                Point pos = PointToScreen(e.Location);
                Location = new Point(pos.X - offset.X, pos.Y - offset.Y);
            }
        }

        private void border_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void rank_survivor_wanted_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)rank_survivor_wanted.Value;

            if (File.Exists($"{survivor}\\{value}.png") == true)
            {
                logo_rank_survivor.Image = Image.FromFile($"{survivor}\\{value}.png");
            }
            else
            {
                MessageBox.Show($"icon: {survivor}\\{ value}.png is missing", "Missing icon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void rank_killer_wanted_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)rank_killer_wanted.Value;

            if (File.Exists($"{killer}\\{value}.png") == true)
            {
                logo_rank_killer.Image = Image.FromFile($"{killer}\\{value}.png");
            }
            else
            {
                MessageBox.Show($"icon: {killer}\\{ value}.png is missing", "Missing icon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void Better_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(icons) == true)
            {
                if (Directory.Exists(survivor) == true && Directory.Exists(killer) == true)
                {
                    if (Directory.GetFiles(survivor).Length == 20 && Directory.GetFiles(killer).Length == 20)
                    {
                        rank_killer_wanted_ValueChanged(sender, e);
                        rank_survivor_wanted_ValueChanged(sender, e);
                        status.Text = "ready";
                        status.ForeColor = Color.LimeGreen;
                    }
                    else
                    {
                        MessageBox.Show("Invalid amount of icons", "Invalid icons", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Missing icons files", "Missing icons files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Missing icons folder", "Missing icons folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private string game(int levelversion, string type)
        {
            string json = "{\"data\":{\"consecutiveMatch\":1,\"emblemQualities\":[" +
                emblem() + "," +
                emblem() + "," +
                emblem() + "," +
                emblem() + "],\"isFirstMatch\":false," +
            "\"levelVersion\":" + levelversion +
            ",\"matchTime\":" + gameTime() +
            ",\"platformVersion\":\"steam\",\"playerType\":\"" + type + "\"}}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/playerLevels/earnPlayerXp"
            };
            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", cookie);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);

            return (response.Content);
        }

        private int levelVersion()
        {
            int number = 0;
            string tmp = null;
            var response = game(number, "survivor");
            string[] cleanned = response.Split('"');
            if (response.Contains("levelInfo"))
            {
                for (int i = 0; i < cleanned.Length; i++)
                {
                    if (cleanned[i].StartsWith("levelVersion"))
                    {
                        tmp = cleanned[i + 1];
                        number = Int32.Parse(tmp.Split(':')[1].Split(',')[0]);
                        return (number);
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect BHVR cookie");
                return (-1);
            }
            return (number);
        }

        private string rank(decimal survivor, decimal killer)
        {
            string json = "{" +
                "\"forceReset\": true," +
                "\"killerPips\":" + killer + "," +
                "\"survivorPips\":" + survivor + "}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/ranks/pips"
            };
            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", cookie);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);

            return (response.Content);
        }

        private Task get_cookie()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                cookie = Clipboard.GetText(TextDataFormat.Text);
            }
            else
            {
                MessageBox.Show("No cookie copied", "No cookie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (Task.CompletedTask);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int version = 0;

            Cursor = Cursors.WaitCursor;
            get_cookie().Wait();
            if (cookie != null)
            {
                version = levelVersion();
                if (version > 0)
                {
                    for (int i = 20; i <= rank_survivor_wanted.Value; i--, version++)
                    {
                        Console.WriteLine(game(version, "survivor"));
                        Console.WriteLine(rank(i, 0));
                    }
                    for (int i = 20; i <= rank_killer_wanted.Value; i--, version++)
                    {
                        Console.WriteLine(game(version, "killer"));
                        Console.WriteLine(rank(0, i));
                    }
                    MessageBox.Show("Pips injected");
                }
            }
            Cursor = Cursors.Default;
        }
    }
}
