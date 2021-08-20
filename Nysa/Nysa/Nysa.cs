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
        bool theme_on = false;
        bool mouse_down = false;
        private Point offset;
        OpenFileDialog folder_path = new OpenFileDialog();
        private classes.Tools.Rootobject settings_tools = null;

        static string resources_path = "resources";
        static string settings_path = $"{resources_path}\\Settings.json";
        static string download_path = "Downloads";
        static string logs_path = "Logs";

        private List<string> logs = new List<string>();

        public Nysa()
        {
            InitializeComponent();
        }

        private Task logger(string type, string value)
        {
            logs.Add($"{DateTime.Now.ToString("HH:mm:ss")} [{type}] {value}");

            return (Task.CompletedTask);
        }

        private void Nysa_Load(object sender, EventArgs e)
        {
            logger("INITIALISATING", "Welcome in Nysa").Wait();
            folder_path.RestoreDirectory = true;
            folder_path.FilterIndex = 2;
            folder_path.Filter = "Images (*.png *.jpg *.jpeg)|*.png;*.jpg;*.jpeg";

            panel.BackColor = Color.FromArgb(175, 21, 22, 28);

            load_settings().Wait();
            autoupdate().Wait();
        }

        private Task get_background()
        {
            folder_path.ShowDialog();

            if (folder_path.FileName.Length > 1)
            {
                settings_tools.background = folder_path.FileName;
                File.Delete(settings_path);
                File.WriteAllText(settings_path, JsonConvert.SerializeObject(settings_tools));
            }

            return (Task.CompletedTask);
        }

        private int count_char(string str, char c)
        {
            int total = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    total++;
            }
            return (total);
        }

        private string crop(string message)
        {
            string[] splitted = null;
            int count = count_char(message, '\\');


            if (count >= 3)
            {
                splitted = message.Split('\\');

                return ($"{splitted[0]}\\{splitted[1]}\\...\\{splitted[count]}");
            }

            return (message);
        }

        private Task load_background()
        {
            if (theme_on == true)
            {
                logger("LOAD", "Loading background").Wait();
                if (File.Exists(settings_tools.background) == true)
                {
                    this.BackgroundImage = Image.FromFile(settings_tools.background);
                    logger("DONE", "Background loaded").Wait();
                }
                else
                {
                    logger("ERROR", "Background path not found").Wait();
                }
            }
            logger("LOAD", "Loading blur").Wait();
            blur.BackColor = settings_tools.blur;
            logger("DONE", "Blur loaded").Wait();

            return (Task.CompletedTask);
        }

        private Task load_tools()
        {
            logger("LOAD", "Loading tools...").Wait();

            if (settings_tools.tools.Length > 0)
            {
                for (int i = 0; i < settings_tools.tools.Length; i++)
                {
                    tools.Items.Add($"{settings_tools.tools[i].name}");
                }
                logger("DONE", "Tools loaded").Wait();
            }
            else
            {
                logger("WARN", "No tools to load").Wait();
            }

            return (Task.CompletedTask);
        }

        private Task load_color()
        {
            logger("LOAD", "Loading color...").Wait();
            border.BackColor = settings_tools.color;
            logger("DONE", "Color loaded").Wait();

            return (Task.CompletedTask);
        }

        private Task load_minimalist()
        {
            logger("LOAD", "Loading theme...").Wait();
            theme_on = settings_tools.minimalist;
            logger("DONE", "Theme loaded").Wait();

            return (Task.CompletedTask);
        }

        private Task load_version()
        {
            bool valid = true;
            int result = 0;
            string[] splitted = null;

            logger("LOAD", "Loading version...").Wait();
            if (settings_tools.version.Contains('.') == true)
            {
                splitted = settings_tools.version.Split('.');
                if (splitted.Length == 3)
                {
                    for (int i = 0; i < splitted.Length; i++) {
                        if (int.TryParse(splitted[i], out result) == false) {
                            valid = false;
                        }
                    }
                }
                else
                {
                    valid = false;
                }
            }
            else
            {
                valid = false;
            }
            if (valid == false)
            {
                logger("ERROR", "Wrong version format").Wait();
                version.Text = "invalid version";
            }
            else
            {
                logger("DONE", "Version validated").Wait();
                version.Text = settings_tools.version;
            }
            logger("DONE", "Version loaded").Wait();

            return (Task.CompletedTask);
        }

        private Task load_settings()
        {
            tools.Items.Clear();
            if (File.Exists(settings_path) == true)
            {
                settings_tools = JsonConvert.DeserializeObject<classes.Tools.Rootobject>(
                    File.ReadAllText(settings_path)
                );
                load_minimalist().Wait();
                load_background().Wait();
                load_tools().Wait();
                load_version().Wait();
                load_color().Wait();
            } else
            {
                MessageBox.Show($"Settings file: '{settings_path}' not found", $"{settings_path}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (Task.CompletedTask);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            logger("WAIT", "Minimising").Wait();
            WindowState = FormWindowState.Minimized;
            logger("DONE", "Minimised").Wait();
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
            logger("WAIT", "Checking all...").Wait();
            for (int i = 0; i < tools.Items.Count; i++)
            {
                tools.SetItemChecked(i, true);
            }
            logger("DONE", "Checked all").Wait();
        }

        private void uncheck_Click(object sender, EventArgs e)
        {
            logger("WAIT", "Unchecking all...").Wait();
            for (int i = 0; i < tools.Items.Count; i++)
            {
                tools.SetItemChecked(i, false);
            }
            logger("DONE", "Unchecked all").Wait();
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

            client.DownloadFile($"{settings_tools.tools[i].link}", $"{download_path}\\{cleanner(settings_tools.tools[i].link)}");
            
            return (Task.CompletedTask);
        }

        private async void download_Click(object sender, EventArgs e)
        {
            Task downloader = null;
            string current = null;

            Cursor = Cursors.WaitCursor;

            if (Directory.Exists(download_path) == false)
            {
                logger("WAIT", $"Creating '{download_path}' directory").Wait();
                Directory.CreateDirectory(download_path);
                logger("DONE", "Directory created").Wait();
            }

            if (tools.CheckedItems.Count > 0)
            {
                update_status("downloading").Wait();
                for (int i = 0; i < tools.Items.Count; i++)
                {
                    current = cleanner(settings_tools.tools[i].link);
                    logger("WAIT", $"Downloading {current}").Wait();
                    if (tools.GetItemChecked(i) == true)
                        downloader = await Task.Run(() => download_tool(i));
                    logger("DONE", $"Downloaded {current}").Wait();
                }
                update_status("downloaded").Wait();
            }
            else
            {
                logger("WARN", "No tool to download").Wait();
            }
            Cursor = Cursors.Default;
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            logger("WAIT", "Launching discord...").Wait();
            Process.Start("https://discord.gg/Y7YagcPXh8");
            logger("DONE", "Discord launched").Wait();
            Cursor = Cursors.Default;
        }

        private Task update_status(string value)
        {
            status.Text = value;

            if (value == "ready")
                status.ForeColor = Color.LimeGreen;
            if (value == "outdated")
                status.ForeColor = Color.Orange;
            if (value == "downloading" || value == "extracting" || value == "launching" || value == "editing configuration")
                status.ForeColor = Color.Cyan;
            if (value == "downloaded" || value == "extracted" || value == "launched" || value == "configuration edited")
                status.ForeColor = Color.LimeGreen;
            if (value == "something went wrong")
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
            string output = $"{resources_path}\\version";
            string lastest = null;

            Cursor = Cursors.WaitCursor;
            
            try
            {
                if (File.Exists(settings_path) == false)
                {
                    logger("WAIT", "Downloading new settings...").Wait();
                    update_status("downloading").Wait();
                    client.DownloadFile(settings, settings_path);
                    update_status("downloaded").Wait();
                    logger("DONE", "Downloaded new settings").Wait();
                    load_settings().Wait();
                }
                logger("LOAD", "Checking version...").Wait();
                client.DownloadFile(link, output);
                if (File.Exists(output) == true)
                {
                    lastest = File.ReadAllText(output).Replace("\n", "");
                }
                if (lastest != settings_tools.version)
                {
                    logger("INFO", $"Outdated version: {settings_tools.version} required {lastest}").Wait();
                    logger("LOAD", "Checking version...").Wait();
                    logger("WAIT", "Downloading lastest version...").Wait();
                    update_status("downloading").Wait();
                    client.DownloadFile(settings, settings_path);
                    update_status("downloaded").Wait();
                    logger("DONE", "Downloaded lastest version").Wait();
                    load_settings().Wait();
                }
                else
                {
                    logger(" OK ", "Ready").Wait();
                    update_status("ready").Wait();
                }
            }
            catch (Exception e)
            {
                logger("ERROR", $"Error while checking version:\n{e}").Wait();
                update_status("something went wrong").Wait();
            }
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private void check_update_Click(object sender, EventArgs e)
        {
            logger("WAIT", "Updating...").Wait();
            autoupdate().Wait();
            logger("DONE", "Updated").Wait();
        }

        private void about_Click(object sender, EventArgs e)
        {
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void browse_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            logger("WAIT", "Browsing...").Wait();
            get_background().Wait();
            load_settings().Wait();
            logger("DONE", "Browser closed").Wait();
            Cursor = Cursors.Default;
        }

        private void dump_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("HH_mm_ss");

            Cursor = Cursors.WaitCursor;
            logger("WAIT", "Extracting logs...").Wait();
            update_status("extracting").Wait();
            if (Directory.Exists(logs_path) == false)
                Directory.CreateDirectory(logs_path);
            File.AppendAllLines($"{logs_path}\\logs_{date}.txt", logs);
            update_status("extracted").Wait();
            logger("DONE", "Logs extracted").Wait();
            Cursor = Cursors.Default;
        }

        private void theme_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            logger("WAIT", "Changing configuration...").Wait();
            logger("THEME", $"{theme_on}").Wait();
            if (theme_on == true)
            {
                theme_on = false;
                this.BackgroundImage = null;
            }
            else
            {
                theme_on = true;
                this.BackgroundImage = Image.FromFile(settings_tools.background);
            }
            settings_tools.minimalist = theme_on;
            logger("THEME", $"{theme_on}").Wait();
            logger("DONE", "Configuration changed").Wait();
            logger("WAIT", "Updating settings...").Wait();
            if (Directory.Exists(logs_path) == false)
            {
                logger("WAIT", $"Creating '{logs_path}' directory").Wait();
                Directory.CreateDirectory(logs_path);
                logger("DONE", "Directory created").Wait();
            }
            File.WriteAllText(settings_path, JsonConvert.SerializeObject(settings_tools));
            logger("DONE", "Settings updated").Wait();
            Cursor = Cursors.Default;
        }

        private void launch_Click(object sender, EventArgs e)
        {
            int id = 381210;

            Cursor = Cursors.WaitCursor;
            logger("WAIT", "Launching Dead By Daylight...").Wait();
            update_status("launching").Wait();
            Process.Start($"steam://rungameid/{id}");
            logger("DONE", "Dead By Daylight launched").Wait();
            update_status("launched").Wait();
            Cursor = Cursors.Default;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            logger("WAIT", "Editing configuration...").Wait();
            update_status("editing configuration").Wait();
            form.editor editor = new form.editor(settings_tools, settings_path);
            editor.ShowDialog();
            logger("DONE", "Configuration edited").Wait();
            update_status("configuration edited").Wait();
            load_settings().Wait();
            Cursor = Cursors.Default;
        }
    }
}
