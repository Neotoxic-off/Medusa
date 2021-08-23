using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using DiscordRPC;
using Newtonsoft.Json;
using Fiddler;
using System.Collections.Generic;

namespace Kirsty
{
    public partial class Kirsty : Form
    {
        bool mouse_down = false;
        private Point offset;

        classes.Settings.Rootobject settings = null;
        classes.playername.Rootobject playername = null;
        classes.steam.Rootobject steam = null;
        classes.login.Rootobject login = null;
        classes.queue.Rootobject queue = null;

        DiscordRpcClient client = null;

        string market_data = null;
        string tomes_data = null;

        static string folder = "resources";
        static string file = "Settings.json";
        static string tome = "Tomes.json";

        public Kirsty()
        {
            InitializeComponent();
        }

        void Initialize()
        {
            client = new DiscordRpcClient("879103253147688991");

            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Made by Neo",
                State = $"version: {version.Text}",

                Assets = new Assets()
                {
                    LargeImageKey = "cat",
                    LargeImageText = "Your soul is mine"
                }
            });
        }

        void Update_client()
        {
            client.Invoke();
        }

        void Deinitialize()
        {
            if (client != null)
                client.Dispose();
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
            status.Refresh();

            return (Task.CompletedTask);
        }

        private Task update_ui()
        {
            display_autorun_status.Text = $"{settings.autorun}";
            display_market_path.Text = $"{crop(settings.market)}";
            display_streammer_status.Text = $"{settings.streammer.activated}";
            display_streammer_username.Text = $"{settings.streammer.username}";
            display_discord_rpc.Text = $"{settings.discord}";
            display_friend_tag.Text = $"{settings.streammer.tag}";

            display_unlock_tomes.Text = $"{settings.unlocker.tomes.unlock}";

            return (Task.CompletedTask);
        }

        private Task check_market()
        {
            if (File.Exists(settings.market) == true)
                market_data = File.ReadAllText(settings.market);
            else
            {
                BOX($"Market file not found:\n{settings.market}", "Error: Market not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                market_data = null;
            }
            return (Task.CompletedTask);
        }

        private Task update_settings()
        {
            update_status($"loading settings").Wait();
            try
            {
                settings = JsonConvert.DeserializeObject<classes.Settings.Rootobject>(
                    File.ReadAllText($"{folder}\\{file}")
                );
                check_market().Wait();
                update_status($"settings loaded").Wait();
            }
            catch (Exception ex)
            {
                BOX($"Wrong settings format:\n{ex}", $"Error: settings format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            return (Task.CompletedTask);
        }

        private Task update_tomes()
        {
            update_status("loading tomes").Wait();
            try
            {
                tomes_data = File.ReadAllText($"{folder}\\{tome}");
                update_status("tomes loaded").Wait();
            }
            catch (Exception ex)
            {
                BOX($"Wrong tomes format:\n{ex}", "Error: tomes format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            return (Task.CompletedTask);
        }

        private Task save_settings()
        {
            if (File.Exists($"{folder}\\{file}") == true)
                File.Delete($"{folder}\\{file}");
            File.WriteAllText($"{folder}\\{file}", JsonConvert.SerializeObject(settings));

            return (Task.CompletedTask);
        }

        private void Kirsty_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(folder) == true)
            {
                if (File.Exists($"{folder}\\{file}") == true)
                {
                    if (File.Exists($"{folder}\\{tome}") == true)
                    {
                        update_tomes().Wait();
                    }
                    else
                    {
                        BOX($"{folder}\\{tome} file not found", "Error: tomes file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    update_settings().Wait();
                    if (settings.autorun == true)
                    {
                        autorun().Wait();
                    }
                    if (settings.discord == true)
                    {
                        autodiscord().Wait();
                    }
                    update_ui().Wait();
                }
                else
                {
                    BOX($"{folder}\\{file} file not found", "Error: settings file", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GAR().Wait();
        }

        private int get_market()
        {
            folder_path.ShowDialog();
            if (folder_path.FileName.Length > 1)
            {
                return (1);
            }
            return (-1);
        }

        private void market_path_Click(object sender, EventArgs e)
        {
            GMP().Wait();
        }

        private void streammer_status_Click(object sender, EventArgs e)
        {
            GSS().Wait();
        }

        private void streammer_username_Click(object sender, EventArgs e)
        {
            GSU().Wait();
        }

        private void Streammer_mod(Session sess)
        {
            if (sess.fullUrl.Contains("/v1/playername") == true)
            {
                sess.bBufferResponse = true;

                sess.utilDecodeResponse();
                playername = JsonConvert.DeserializeObject<classes.playername.Rootobject>(
                    sess.GetResponseBodyAsString()
                );
                playername.playerName = settings.streammer.username;
                playername.providerPlayerNames.steam = settings.streammer.username;

                sess.utilSetResponseBody(JsonConvert.SerializeObject(playername));
            }
            if (sess.fullUrl.Contains("/v1/playername/steam") == true)
            {
                sess.bBufferResponse = true;

                sess.utilDecodeResponse();
                steam = JsonConvert.DeserializeObject<classes.steam.Rootobject>(
                    sess.GetResponseBodyAsString()
                );
                steam.playerName = settings.streammer.username;
                steam.providerPlayerNames.steam = $"{settings.streammer.username}#{settings.streammer.tag}";

                sess.utilSetResponseBody(JsonConvert.SerializeObject(steam));
            }
            if (sess.fullUrl.Contains("/v1/auth/provider/steam") == true)
            {
                sess.bBufferResponse = true;

                sess.utilDecodeResponse();
                login = JsonConvert.DeserializeObject<classes.login.Rootobject>(
                    sess.GetResponseBodyAsString()
                );
                login.provider.providerId = "76561199154376974";
                login.providers[0].providerId = "76561199154376974";
                sess.utilSetResponseBody(JsonConvert.SerializeObject(login));
            }
        }

        private void Bypasser(Session sess)
        {
            if (sess != null && sess.oRequest != null && sess.oRequest.headers != null)
            {
                if (sess.fullUrl.Contains("bhvrdbd"))
                {
                    if (sess.RequestHeaders.ToString().Contains("bhvrSession=") && display_cookie_value.Text.Length == 0)
                    {
                        BeginInvoke(new Action(delegate {
                            display_cookie_value.Text = sess.RequestHeaders["Cookie"].Replace("bhvrSession=", "");
                            update_status("cookie grabbed");
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
                    if (sess.fullUrl.Contains(settings.unlocker.tomes.url) == true)
                    {
                        sess.bBufferResponse = true;

                        sess.utilDecodeResponse();
                        sess.utilSetResponseBody(tomes_data);
                    }
                    if (sess.fullUrl.Contains("/v1/queue") == true)
                    {
                        BeginInvoke(new Action(delegate {
                            try
                            {
                                queue = JsonConvert.DeserializeObject<classes.queue.Rootobject>(
                                    sess.GetResponseBodyAsString()
                                );
                                display_queue_position.Text = $"{queue.queueData.position}";
                                display_queue_position.Refresh();
                            } catch (Exception ex)
                            {
                                display_queue_position.Text = "not in queue";
                                display_queue_position.Refresh();
                            }
                        }));
                    }

                    if (settings.streammer.activated == true)
                    {
                        Streammer_mod(sess);
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
            check_market().Wait();
            if (market_data != null)
            {
                start.Enabled = false;
                InstallCertificate();
                Start();
                stop.Enabled = true;
            }
            

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

        private Task GSU()
        {
            Cursor = Cursors.WaitCursor;
            form.edit editor = new form.edit("Streammer Username", display_streammer_username.Text);
            editor.ShowDialog();
            settings.streammer.username = editor.get_data();
            save_settings().Wait();
            update_ui().Wait();
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private Task GFT()
        {
            Cursor = Cursors.WaitCursor;
            form.edit editor = new form.edit("Friend tag", display_friend_tag.Text);
            editor.ShowDialog();
            settings.streammer.tag = editor.get_data();
            if (settings.streammer.tag.Length < 4)
            {
                settings.streammer.tag = "Kirsty";
            }
            save_settings().Wait();
            update_ui().Wait();
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private Task GSS()
        {
            Cursor = Cursors.WaitCursor;
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
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private Task GMP()
        {
            Cursor = Cursors.WaitCursor;
            if (get_market() == 1)
            {
                settings.market = folder_path.FileName;
                check_market().Wait();
                save_settings().Wait();
                update_ui().Wait();
            }
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private Task GAR()
        {
            Cursor = Cursors.WaitCursor;
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
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private Task GCC()
        {
            Cursor = Cursors.WaitCursor;
            if (display_cookie_value.Text.Length > 0 && display_cookie_value.Text != "unknown")
            {
                Clipboard.SetText(display_cookie_value.Text);
                update_status("cookie copied").Wait();
            }
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private void display_market_path_Click(object sender, EventArgs e)
        {
            GMP().Wait();
        }

        private void display_autorun_status_Click(object sender, EventArgs e)
        {
            GAR().Wait();
        }

        private void display_streammer_status_Click(object sender, EventArgs e)
        {
            GSS().Wait();
        }

        private void display_streammer_username_Click(object sender, EventArgs e)
        {
            GSU().Wait();
        }

        private Task autodiscord()
        {
            update_status("starting discord status").Wait();
            Initialize();
            update_status("discord status started").Wait();

            return (Task.CompletedTask);
        }

        private Task GDRPC()
        {
            Cursor = Cursors.WaitCursor;
            if (settings.discord == true)
            {
                update_status("stopping discord status").Wait();
                Deinitialize();
                update_status("discord status stopped").Wait();
                settings.discord = false;
            }
            else
            {
                autodiscord().Wait();
                settings.discord = true;
            }
            save_settings().Wait();
            update_ui().Wait();
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private void discord_rpc_Click(object sender, EventArgs e)
        {
            GDRPC().Wait();
        }

        private void display_discord_rpc_Click(object sender, EventArgs e)
        {
            GDRPC().Wait();
        }

        private void Kirsty_FormClosing(object sender, FormClosingEventArgs e)
        {
            autostop().Wait();
            if (settings.discord == true)
                Deinitialize();
        }

        private void friend_tag_Click(object sender, EventArgs e)
        {
            GFT().Wait();
        }

        private void display_friend_tag_Click(object sender, EventArgs e)
        {
            GFT().Wait();
        }

        private void cookie_label_Click(object sender, EventArgs e)
        {
            GCC().Wait();
        }

        private void display_cookie_value_Click(object sender, EventArgs e)
        {
            GCC().Wait();
        }

        private Task GUT()
        {
            Cursor = Cursors.WaitCursor;
            if (settings.unlocker.tomes.unlock == true)
            {
                settings.unlocker.tomes.unlock = false;
            }
            else
            {
                settings.unlocker.tomes.unlock = true;
            }
            save_settings().Wait();
            update_ui().Wait();
            Cursor = Cursors.Default;

            return (Task.CompletedTask);
        }

        private void display_unlock_tomes_Click(object sender, EventArgs e)
        {
            GUT().Wait();
        }

        private void unlock_tomes_Click(object sender, EventArgs e)
        {
            GUT().Wait();
        }
    }
}
