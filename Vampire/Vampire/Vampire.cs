using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using RestSharp;

namespace Vampire
{
    public partial class Vampire : Form
    {
        bool mouse_down = false;
        private Point offset;
        Random rnd = new Random();

        public Vampire()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string request(string url, string json, string cookie, int method)
        {
            IRestResponse response;
            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = url
            };
            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", cookie);
            if (json != null)
                bhvr_request.AddJsonBody(json);
            if (method == 0)
                response = client.Post(bhvr_request);
            else
                response = client.Get(bhvr_request);
            Console.WriteLine("\nResponse:\n" + response.Content);
            return (response.Content);
        }

        private void boxer(string message, string title, System.Windows.Forms.MessageBoxIcon type)
        {
            const MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, title, buttons, type);
        }

        private int counter(string response)
        {
            if (response.Contains("Reached the maximum number of grants"))
            {
                boxer("You can't inject anymore, you need to wait. You reached the maximum number of grants per hour", "Maximum requests reached", MessageBoxIcon.Information);
                return (-1);
            }
            return (0);
        }

        private int maximum_wallet(string cookie)
        {
            var response = request("https://steam.live.bhvrdbd.com/api/v1/wallet/currencies", null, cookie, 1);

            classes.Settings.Rootobject weps = JsonConvert.DeserializeObject<classes.Settings.Rootobject>(response);
            classes.Settings.Rootobject_error weps_error = JsonConvert.DeserializeObject<classes.Settings.Rootobject_error>(response);

            if (weps != null && weps.list != null)
            {
                foreach (classes.Settings.data item in weps.list)
                {
                    if (item.currency == "Bloodpoints")
                    {
                        update_status($"{item.balance.ToString()}").Wait();
                        if (item.balance == 1000000)
                            return (1);
                    }
                }
            }
            else
            {
                boxer("Your cookie is incorrect", "Incorrect cookie", MessageBoxIcon.Error);
                return (-1);
            }
            return (0);
        }

        private int increase()
        {
            int[] array = { 10000, 12000, 15000 };

            return (array[rnd.Next(0, array.Length)]);
        }

        private Task update(Button button)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (button.Enabled == true)
                {
                    button.BackColor = Color.Gray;
                    button.ForeColor = Color.Gray;
                    button.Enabled = false;
                }
                else
                {
                    button.ForeColor = Color.DimGray;
                    button.BackColor = Color.Transparent;
                    button.Enabled = true;
                }
            }));

            return (Task.CompletedTask);
        }

        private Task update_status(string value)
        {
            allbloodpoint.Text = value;

            if (value == "ready")
                allbloodpoint.ForeColor = Color.LimeGreen;
            else if (value == "outdated")
                allbloodpoint.ForeColor = Color.Orange;
            else if (value == "downloading")
                allbloodpoint.ForeColor = Color.Cyan;
            else if (value == "downloaded")
                allbloodpoint.ForeColor = Color.LimeGreen;
            else if (value == "error")
                allbloodpoint.ForeColor = Color.Red;
            else if (value == "lastest")
                allbloodpoint.ForeColor = Color.Purple;
            else
                allbloodpoint.ForeColor = Color.Purple;

            return (Task.CompletedTask);
        }

        private async Task<Task> brain()
        {
            int stat = 0;
            string cookie = null;
            bool empty = false;

            this.Invoke(new MethodInvoker(delegate
            {
                if (Clipboard.ContainsText(TextDataFormat.Text) == false)
                {
                    boxer("Copy your bhvr cookie", "No cookie found", MessageBoxIcon.Error);
                    empty = true;
                }
            }));
            if (empty == false)
            {
                update(inject).Wait();
                cookie = Clipboard.GetText(TextDataFormat.Text);
                stat = maximum_wallet(cookie);

                for (int i = 0; stat == 0; i++)
                {
                    if (i < 4 && secret.Checked == true)
                    {
                        if (counter(request("https://steam.live.bhvrdbd.com/api/v1/extensions/rewards/grantCurrency/", "{\"data\":{\"rewardType\": \"shrineReward\",\"walletToGrant\": {\"balance\":150000,\"currency\": \"Bloodpoints\"}}}", cookie, 0)) == -1)
                        {
                            return (Task.CompletedTask);
                        }
                    }
                    else
                    {
                        if (counter(request("https://steam.live.bhvrdbd.com/api/v1/extensions/rewards/grantCurrency/", "{\"data\":{\"rewardType\": \"Story\",\"walletToGrant\": {\"balance\":" + increase() + ",\"currency\": \"Bloodpoints\"}}}", cookie, 0)) == -1)
                        {
                            return (Task.CompletedTask);
                        }
                    }
                    stat = maximum_wallet(cookie);
                }
                if (stat == 1)
                {
                    boxer("You reached the maximum of bloodpoints in your account", "Maximum reached", MessageBoxIcon.Information);
                }
                update(inject).Wait();
            }

            return (Task.CompletedTask);

        }

        private async void inject_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Task run = await Task.Run(() => brain());
            Cursor = Cursors.Default;
        }

        private void secret_CheckedChanged(object sender, EventArgs e)
        {
            if (secret.Checked == true)
            {
                boxer("Use it only if you don't have already purchased any perk on\nthe Shrine of secrets and use it only 1 time and wait Shrine reset", "Shrine of secrets", MessageBoxIcon.Information);
            }
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
    }
}
