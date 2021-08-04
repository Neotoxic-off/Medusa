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

using Newtonsoft.Json;
using Fiddler;

namespace SLOK
{
    public partial class Slock : Form
    {
        bool mouse_down = false;
        private Point offset;

        classes.Settings.Rootobject settings = null;

        string data = null;

        public Slock()
        {
            InitializeComponent();
        }

        private void Slock_Load(object sender, EventArgs e)
        {
            load_settings().Wait();
        }

        private Task load_settings()
        {
            string path = "Settings.json";

            if (File.Exists(path) == true)
            {
                settings = JsonConvert.DeserializeObject<classes.Settings.Rootobject>(
                    File.ReadAllText(path)
                );
                market_path.Text = crop(settings.path);
                if (settings.path == "not set")
                {
                    market_path.ForeColor = Color.Orange;
                }
                else
                {
                    if (File.Exists(settings.path) == true)
                    {
                        market_path.ForeColor = Color.LimeGreen;
                        data = File.ReadAllText(settings.path);
                    }
                    else
                        market_path.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show($"Settings file '{path}' not found", $"{path}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            return (Task.CompletedTask);
        }

        private Task save_settings()
        {
            string path = "Settings.json";

            if (File.Exists(path) == true)
                File.Delete(path);
            File.WriteAllText(path, JsonConvert.SerializeObject(settings));
            load_settings().Wait();

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

        private void about_Click(object sender, EventArgs e)
        {
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Stop();
            status.Text = "stopped";
            status.ForeColor = Color.Orange;
            UninstallCertificate();
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private int get_market()
        {
            folder_path.ShowDialog();
            if (folder_path.FileName.Length > 1)
                return (1);
            return (-1);
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (get_market() == 1)
            {
                settings.path = folder_path.FileName;
                save_settings().Wait();
            }
        }

        public bool InstallCertificate()
        {
            if (!CertMaker.rootCertExists())
            {
                if (!CertMaker.createRootCert())
                    return (false);

                if (!CertMaker.trustRootCert())
                    return (false);
            }
            return (true);
        }

        public bool UninstallCertificate()
        {
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return (false);
            }
            return (true);
        }

        private void FiddlerApplication_AfterSessionComplete(Session sess)
        {
            string body = null;

            if (sess != null)
            {
                if (sess.fullUrl.Contains(settings.url))
                {
                    this.Invoke(new Action(delegate {
                        body = sess.GetRequestBodyAsString();
                        if (body.Length > 0)
                        {
                            sess.utilSetRequestBody(data);
                        }
                    }));
                }
            }
        }

        public void Start()
        {
            FiddlerCoreStartupSettings startupSettings = new FiddlerCoreStartupSettingsBuilder()
                .RegisterAsSystemProxy()
                .DecryptSSL()
                .Build();
            FiddlerApplication.Startup(startupSettings);

            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
        }

        public void Stop()
        {
            FiddlerApplication.AfterSessionComplete -= FiddlerApplication_AfterSessionComplete;

            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        private void run_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (File.Exists(settings.path) == true)
            {
                InstallCertificate();
                Start();
                status.Text = "running";
                status.ForeColor = Color.LimeGreen;
                stop_button.Enabled = true;
                run.Enabled = false;
            }
            else
            {
                MessageBox.Show($"Market path not found: '{settings.path}'", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            Stop();
            status.Text = "stopped";
            status.ForeColor = Color.Orange;
            run.Enabled = true;
            stop_button.Enabled = false;
        }
    }
}
