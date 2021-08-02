using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Nysa
{
    public partial class Nysa : Form
    {
        bool mouse_down = false;
        private Point offset;
        private classes.Tools.Rootobject settings_tools = null;

        public Nysa()
        {
            InitializeComponent();
        }

        private void Nysa_Load(object sender, EventArgs e)
        {
            load_settings().Wait();
            autoupdate().Wait();
        }

        private Task update(string log)
        {
            logs.AppendText($"{log}\n");
            logs.Refresh();

            return (Task.CompletedTask);
        }

        private Task load_settings()
        {
            string path = "Settings.json";

            tools.Items.Clear();
            if (File.Exists(path) == true)
            {
                settings_tools = JsonConvert.DeserializeObject<classes.Tools.Rootobject>(
                    File.ReadAllText(path)
                );
                update("loading tools...").Wait();
                for (int i = 0; i < settings_tools.tools.Length; i++)
                {
                    tools.Items.Add($"{settings_tools.tools[i].name}");
                }
                update("tools loaded").Wait();
                update("loading version...").Wait();
                version.Text = settings_tools.version;
                update("version loaded").Wait();
                update("loading color...").Wait();
                border.BackColor = settings_tools.color;
                update("color loaded").Wait();
            } else
            {
                MessageBox.Show($"Settings file: '{path}' not found", $"{path}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            return (Task.CompletedTask);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            
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

        private void check_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tools.Items.Count; i++)
            {
                tools.SetItemChecked(i, true);
            }
        }

        private void uncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tools.Items.Count; i++)
            {
                tools.SetItemChecked(i, false);
            }
        }

        private int count(string value, char c)
        {
            int result = 0;

            for (int i = 0; i < value.Length; i++)
                if (value[i] == c)
                    result++;

            return (result);
        }

        private string cleanner(string value)
        {
            int data = count(value, '/');
            string result = value.Split('/')[data];

            return (result);
        }

        private async Task<Task> download_tool(int i)
        {
            WebClient client = new WebClient();

            client.DownloadFile($"{settings_tools.tools[i].link}", $"{cleanner(settings_tools.tools[i].link)}");
            
            return (Task.CompletedTask);
        }

        private async void download_Click(object sender, EventArgs e)
        {
            Task downloader = null;

            Cursor = Cursors.WaitCursor;

            if (tools.CheckedItems.Count > 0)
            {
                update_status("downloading").Wait();
                for (int i = 0; i < tools.Items.Count; i++)
                {
                    if (tools.GetItemChecked(i) == true)
                        downloader = await Task.Run(() => download_tool(i));
                }
                update_status("downloaded").Wait();
            }
            Cursor = Cursors.Default;
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process.Start("https://discord.gg/Y7YagcPXh8");
            Cursor = Cursors.Default;
        }

        private Task update_status(string value)
        {
            status.Text = value;

            if (value == "ready")
                status.ForeColor = Color.LimeGreen;
            if (value == "outdated")
                status.ForeColor = Color.Orange;
            if (value == "downloading")
                status.ForeColor = Color.Cyan;
            if (value == "downloaded")
                status.ForeColor = Color.LimeGreen;
            if (value == "error")
                status.ForeColor = Color.Red;
            if (value == "lastest")
                status.ForeColor = Color.Purple;

            return (Task.CompletedTask);
        }

        private Task autoupdate()
        {
            WebClient client = new WebClient();
            string link = "https://raw.githubusercontent.com/Neotoxic-off/Nysa/main/version";
            string settings = "https://raw.githubusercontent.com/Neotoxic-off/Nysa/main/Settings.json";
            string output = "version";
            string output_settings = "Settings.json";
            string lastest = null;

            Cursor = Cursors.WaitCursor;
            try
            {
                update("checking update").Wait();
                client.DownloadFile(link, output);
                if (File.Exists(output) == true)
                {
                    lastest = File.ReadAllText(output).Replace("\n", "");
                }
                if (lastest != settings_tools.version)
                {
                    update("version: outdated").Wait();
                    update_status("outdated").Wait();
                    update("downloading update").Wait();
                    update_status("downloading").Wait();
                    client.DownloadFile(settings, output_settings);
                    update_status("downloaded").Wait();
                    update("update downloaded").Wait();
                    load_settings().Wait();
                }
                else
                {
                    update("version: lastest").Wait();
                    update_status("ready").Wait();
                }
            }
            catch
            {
                update_status("error").Wait();
            }
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private void check_update_Click(object sender, EventArgs e)
        {
            autoupdate().Wait();
        }

        private void about_Click(object sender, EventArgs e)
        {
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
