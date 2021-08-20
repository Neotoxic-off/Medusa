using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Fiddler;

namespace Kirsty
{
    public partial class Kirsty : Form
    {
        bool mouse_down = false;
        private Point offset;

        classes.Settings.Rootobject settings = null;

        string market_data = null;

        static string folder = "resources";
        static string file = "Settings.json";
        string full_path = $"{folder}\\{file}";

        public Kirsty()
        {
            InitializeComponent();
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

        private void exit_Click(object sender, EventArgs e)
        {
            autostop().Wait();
            Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void about_Click(object sender, EventArgs e)
        {
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            BOX(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult BOX(string content, string title, MessageBoxButtons button, MessageBoxIcon messageBoxIcon)
        {
            return (MessageBox.Show(content, title, button, messageBoxIcon));
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

        private Task update_status(string value)
        {
            status.Text = value;

            return (Task.CompletedTask);
        }

        private Task update_ui()
        {
            display_autorun_status.Text = $"{settings.autorun}";
            display_market_path.Text = $"{crop(settings.market)}";
            display_streammer_status.Text = $"{settings.streammer.activated}";
            display_streammer_username.Text = $"{settings.streammer.username}";

            return (Task.CompletedTask);
        }

        private Task check_market()
        {
            if (File.Exists(settings.market) == true)
                market_data = File.ReadAllText(settings.market);
            else
                BOX($"Market file not found:\n{settings.market}", "Error: Market not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return (Task.CompletedTask);
        }

        private Task update_settings()
        {
            update_status("loading settings").Wait();
            try
            {
                settings = JsonConvert.DeserializeObject<classes.Settings.Rootobject>(
                    File.ReadAllText(full_path)
                );
                check_market().Wait();
                update_status("settings loaded").Wait();
            } catch (Exception ex)
            {
                BOX($"Wrong settings format:\n{ex}", "Error: Settings format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            return (Task.CompletedTask);
        }

        private Task save_settings()
        {
            if (File.Exists(full_path) == true)
                File.Delete(full_path);
            File.WriteAllText(full_path, JsonConvert.SerializeObject(settings));

            return (Task.CompletedTask);
        }

        private void Kirsty_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(folder) == true)
            {
                if (File.Exists(full_path) == true)
                {
                    update_settings().Wait();
                    if (settings.autorun == true)
                        autorun().Wait();
                    update_ui().Wait();
                }
                else
                {
                    BOX($"{full_path} file not found", "Error: settings file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                BOX($"{folder} folder not found", "Error: resources folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void autorun_status_Click(object sender, EventArgs e)
        {
            if (settings.autorun == true)
            {
                settings.autorun = false;
            }
            else
            {
                settings.autorun = true;
            }
            save_settings().Wait();
            update_ui().Wait();
        }

        private int get_market()
        {
            folder_path.ShowDialog();
            if (folder_path.FileName.Length > 1)
            {
                check_market().Wait();
                return (1);
            }
            return (-1);
        }

        private void market_path_Click(object sender, EventArgs e)
        {
            get_market();
            settings.market = folder_path.FileName;
            save_settings().Wait();
            update_ui().Wait();
        }

        private void streammer_status_Click(object sender, EventArgs e)
        {
            if (settings.streammer.activated == true)
            {
                settings.streammer.activated = false;
            }
            else
            {
                settings.streammer.activated = true;
            }
            save_settings().Wait();
            update_ui().Wait();
        }

        private void streammer_username_Click(object sender, EventArgs e)
        {
            form.edit editor = new form.edit("Streammer Username", display_streammer_username.Text);
            editor.ShowDialog();
            settings.streammer.username = editor.get_data();
            save_settings().Wait();
            update_ui().Wait();
        }

        private void Bypasser(Session sess)
        {
            if (sess != null && sess.oRequest != null && sess.oRequest.headers != null)
            {
                if (sess.fullUrl.Contains("bhvrdbd"))
                {
                    if (sess.RequestHeaders.ToString().Contains("bhvrSession=") && cookie.TextLength == 0)
                    {
                        BeginInvoke(new Action(delegate {
                            cookie.Text = sess.RequestHeaders["Cookie"].Replace("bhvrSession=", "");
                            display_cookie_status.Text = "grabbed";
                            copy.Enabled = true;
                        }));
                    }
                    if (sess.fullUrl.Contains(settings.url) == true)
                    {
                        sess.bBufferResponse = true;

                        sess.utilDecodeResponse();
                        sess.utilSetResponseBody(market_data);
                        BeginInvoke(new Action(delegate {
                            if (sess.GetResponseBodyAsString() == market_data)
                            {
                                update_status("market injected").Wait();
                            }
                            else
                            {
                                update_status("market fail to inject").Wait();
                            }
                        }));
                    }
                }
            }

            return;
        }

        private void FiddlerApplication_BeforeRequest(Session oSession)
        {
            oSession.bBufferResponse = true;
        }

        public void Start()
        {
            FiddlerCoreStartupSettings startupSettings = new FiddlerCoreStartupSettingsBuilder()
                .RegisterAsSystemProxy()
                .DecryptSSL()
                .Build();
            FiddlerApplication.Startup(startupSettings);

            FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
            FiddlerApplication.BeforeResponse += Bypasser;

            update_status("running").Wait();
        }

        public void Stop()
        {
            FiddlerApplication.BeforeRequest -= FiddlerApplication_BeforeRequest;
            FiddlerApplication.BeforeResponse -= Bypasser;

            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();

            update_status("stopped").Wait();
        }

        public bool InstallCertificate()
        {
            update_status("installing certificates").Wait();
            if (!CertMaker.rootCertExists())
            {
                if (!CertMaker.createRootCert())
                    return (false);

                if (!CertMaker.trustRootCert())
                    return (false);
            }
            update_status("certificates installed").Wait();
            return (true);
        }

        public bool UninstallCertificate()
        {
            update_status("uninstalling certificates").Wait();
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return (false);
            }
            update_status("certificates uninstalled").Wait();
            return (true);
        }

        private Task autorun()
        {
            start.Enabled = false;
            InstallCertificate();
            Start();
            stop.Enabled = true;

            return (Task.CompletedTask);
        }

        private Task autostop()
        {
            stop.Enabled = false;
            UninstallCertificate();
            Stop();
            start.Enabled = true;

            return (Task.CompletedTask);
        }

        private void start_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            autorun().Wait();
            Cursor = Cursors.Default;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            autostop().Wait();
            Cursor = Cursors.Default;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (cookie.Text.Length > 0)
            {
                Clipboard.SetText(cookie.Text);
                BOX("Cookie copied to clipboard", "Cookie copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor = Cursors.Default;
        }
    }
}
