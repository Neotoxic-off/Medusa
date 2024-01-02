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
using System.Reflection;

using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;

using Fiddler;
using System.Net;

namespace Ana_kata
{
    public partial class Ana_kata : KryptonForm
    {
        class Variables
        {
            public settings.Profile.Rootobject profile = null;
            public Dictionary<string, Color> status = new Dictionary<string, Color>()
            {
                { "running", Color.LimeGreen },
                { "paused", Color.Orange },
                { "stopped", Color.Red },
            };
            public components.Manager manager = new components.Manager();
            public BackgroundWorker worker_save = new BackgroundWorker();
            public BackgroundWorker worker_update = new BackgroundWorker();
            public BackgroundWorker worker_run = new BackgroundWorker();
            public BackgroundWorker worker_cookie = new BackgroundWorker();
            public BackgroundWorker worker_logger = new BackgroundWorker();
            public settings.Queue.Rootobject queue = null;
            public string cookie = null;
            public string market = null;
            public string response = null;
            public string playername = null;
            public string token = null;
            public dev_mod.dev_mod dev_console = new dev_mod.dev_mod();
            public popup.ok warning = new popup.ok("Dev mod activated", "Be careful you activated an advanced option, use it only if you know what you do");
            public List<string> banned = new List<string>()
            {
                "InvalidTokenException",
                "NotAllowedException",
                "localizationCode"
            };
            public string previous = null;
        }

        Variables variables = new Variables();

        public Ana_kata(settings.Profile.Rootobject settings_profile)
        {
            InitializeComponent();
            initialize_variables(settings_profile);
            initialize_workers();
        }

        private void initialize_workers()
        {
            variables.worker_save.DoWork += new DoWorkEventHandler(saver);
            variables.worker_update.DoWork += new DoWorkEventHandler(update_market);
            variables.worker_cookie.DoWork += new DoWorkEventHandler(save_cookie);
        }

        private void initialize_variables(settings.Profile.Rootobject settings_profile)
        {
            variables.profile = settings_profile;

            switch_autorun.Checked = settings_profile.autorun;
            switch_auto_update.Checked = settings_profile.market.autoupdate;
            switch_active_market.Checked = settings_profile.market.activate;
            label_market_path.Text = settings_profile.market.path;
            switch_save_cookie.Checked = settings_profile.cookie.autosave;
            switch_dev_mod.Checked = settings_profile.dev_mod;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            event_worker(variables.worker_update);
        }

        private void eventer(string function, string message)
        {
            if (variables.previous != function)
            {
                variables.previous = function;
                send_log($"{function}:", message);
            } else
            {
                send_log(get_space(variables.previous.Length + 3), message);
            }
        }

        private string get_space(int size)
        {
            string spaces = "";

            for (int i = 0; i < size; i++)
                spaces += " ";

            return (spaces);
        }

        private void event_worker(BackgroundWorker worker)
        {
            worker.RunWorkerAsync();

            while (worker.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void send_log(string sender, string message)
        {
            if (variables.profile.dev_mod == true && variables.dev_console.running == true)
            {
                variables.dev_console.send(sender, message);
            }
        }

        private void update_market(object sender, EventArgs e)
        {
            string output = "market\\market.json";

            eventer(MethodBase.GetCurrentMethod().Name, $"updating market");
            if (variables.manager.get_switch_button(switch_auto_update) == true)
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"loading {output}");
                load_market(output);
            }
            else
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"loading {variables.profile.market.path}");
                load_market(variables.profile.market.path);
            }
        }

        private void saver(object sender, EventArgs e)
        {
            variables.profile.autorun = variables.manager.get_switch_button(switch_autorun);
            variables.profile.market.activate = variables.manager.get_switch_button(switch_active_market);
            variables.profile.market.autoupdate = variables.manager.get_switch_button(switch_auto_update);
            variables.profile.market.path = variables.manager.get_label(label_market_path);
            variables.profile.cookie.autosave = variables.manager.get_switch_button(switch_save_cookie);
            variables.profile.dev_mod = variables.manager.get_switch_button(switch_dev_mod);

            eventer(MethodBase.GetCurrentMethod().Name, $"saving current profile:");
            eventer(MethodBase.GetCurrentMethod().Name, $"variables.profile.autorun: {variables.profile.autorun}");
            eventer(MethodBase.GetCurrentMethod().Name, $"variables.profile.market.activate: {variables.profile.market.activate}");
            eventer(MethodBase.GetCurrentMethod().Name, $"variables.profile.market.autoupdate: {variables.profile.market.autoupdate}");
            eventer(MethodBase.GetCurrentMethod().Name, $"variables.profile.market.path: {variables.profile.market.path}");
            eventer(MethodBase.GetCurrentMethod().Name, $"variables.profile.cookie.autosave: {variables.profile.cookie.autosave}");
            eventer(MethodBase.GetCurrentMethod().Name, $"variables.profile.dev_mod: {variables.profile.dev_mod}");

            eventer(MethodBase.GetCurrentMethod().Name, $"writting profile");
            File.WriteAllText("settings\\profile.json", JsonConvert.SerializeObject(variables.profile));
            eventer(MethodBase.GetCurrentMethod().Name, $"profile written");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            event_worker(variables.worker_save);

            Close();
        }

        private void button_reduce_Click(object sender, EventArgs e)
        {
            eventer(MethodBase.GetCurrentMethod().Name, $"reducing window");
            WindowState = FormWindowState.Minimized;
            eventer(MethodBase.GetCurrentMethod().Name, $"window reduced");
        }

        private void label_market_path_Click(object sender, EventArgs e)
        {
            update_market();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            update_market();
        }

        private void update_market()
        {
            open_market.ShowDialog();

            if (open_market.FileName != string.Empty)
            {
                load_market(open_market.FileName);
                variables.manager.set_switch_button(switch_auto_update, false);
            }
        }

        private void load_market(string path)
        {
            eventer(MethodBase.GetCurrentMethod().Name, $"loading market");

            if (File.Exists(path) == true)
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"market path found: {path}");
                eventer(MethodBase.GetCurrentMethod().Name, $"reading market file");
                variables.market = File.ReadAllText(path);
                eventer(MethodBase.GetCurrentMethod().Name, $"market file read");
                eventer(MethodBase.GetCurrentMethod().Name, $"updating label");
                variables.manager.label(label_market_path, path, Color.Violet);
                eventer(MethodBase.GetCurrentMethod().Name, $"label updated");
            }
            else
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"market path not found");
                eventer(MethodBase.GetCurrentMethod().Name, $"updating path");
                variables.manager.label(label_market_path, "path not found", Color.Red);
                eventer(MethodBase.GetCurrentMethod().Name, $"path updated");
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            eventer(MethodBase.GetCurrentMethod().Name, $"starting anakata catch");
            InstallCertificate();
            Start();
            eventer(MethodBase.GetCurrentMethod().Name, $"anakata catch started");
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            eventer(MethodBase.GetCurrentMethod().Name, $"stopping anakata catch");
            Stop();
            eventer(MethodBase.GetCurrentMethod().Name, $"anakata catch stopped");
        }

        public bool InstallCertificate()
        {
            eventer(MethodBase.GetCurrentMethod().Name, $"installing certificate");
            Cursor.Current = Cursors.WaitCursor;

            if (!CertMaker.rootCertExists())
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"root certificate doesn't exists");
                if (!CertMaker.createRootCert())
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"failed to create root certificate");
                    Cursor.Current = Cursors.Default;
                    return (false);
                }
                else
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"successfully to create root certificate");
                }

                if (!CertMaker.trustRootCert())
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"failed to trust root certificate");
                    Cursor.Current = Cursors.Default;
                    return (false);
                }
                else
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"successfully to trust root certificate");
                }
            } else
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"certificate root exists");
            }

            Cursor.Current = Cursors.Default;
            return (true);
        }

        public bool UninstallCertificate()
        {
            Cursor.Current = Cursors.WaitCursor;

            if (CertMaker.rootCertExists())
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"root certificate exists");
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"certificate root removed");
                    Cursor.Current = Cursors.Default;
                    return (false);
                }
                else
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"failed to remove certificate root");
                }
            }
            else
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"no certificate root to remove");
            }
            Cursor.Current = Cursors.Default;
            return (true);
        }

        private void label_cookie_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(variables.manager.get_label(label_cookie));
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
            eventer(MethodBase.GetCurrentMethod().Name, $"checking proxy status");
            eventer(MethodBase.GetCurrentMethod().Name, $"proxy running: {FiddlerApplication.IsStarted()}");
            if (FiddlerApplication.IsStarted() == false)
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"starting proxy");
                FiddlerApplication.Startup(startupSettings);
                eventer(MethodBase.GetCurrentMethod().Name, $"proxy started");
            }

            FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
            FiddlerApplication.BeforeResponse += Bypasser;

            variables.manager.button(button_play, false);
            variables.manager.button(button_stop, true);

            variables.manager.enabler_switch_button(switch_dev_mod, false);
        }

        public void Stop()
        {
            FiddlerApplication.BeforeResponse -= Bypasser;

            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();

            variables.manager.button(button_play, true);
            variables.manager.button(button_stop, false);

            variables.manager.enabler_switch_button(switch_dev_mod, true);
        }

        private void save_cookie(object sender, EventArgs e)
        {
            List<string> credentials = new List<string>()
            {
                $"playername: {variables.playername}",
                $"token: {variables.token}",
                $"cookie: {variables.cookie}"
            };

            if (variables.playername != null && variables.token != null && variables.cookie != null)
            {
                eventer(MethodBase.GetCurrentMethod().Name, $"credentials:");
                foreach (string data in credentials)
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"\t{data}");
                }
                eventer(MethodBase.GetCurrentMethod().Name, $"dumping credentials in 'cookie.txt'");
                File.WriteAllLines("cookie.txt", credentials);
                eventer(MethodBase.GetCurrentMethod().Name, $"credentials dumped");
            }
        }

        private void update_cookie(string future)
        {
            if (variables.cookie != future)
            {
                variables.cookie = future;
                variables.manager.label(label_cookie, variables.cookie, Color.Violet);
                eventer(MethodBase.GetCurrentMethod().Name, $"cookie: {variables.cookie}");
                if (variables.manager.get_switch_button(switch_save_cookie) == true)
                {
                    event_worker(variables.worker_cookie);
                }
            }
        }

        private void update_token(string future)
        {
            if (variables.token != future)
            {
                variables.token = future;
                variables.manager.label(label_token, variables.token, Color.Violet);
                eventer(MethodBase.GetCurrentMethod().Name, $"token: {variables.token}");
                if (variables.manager.get_switch_button(switch_save_cookie) == true)
                {
                    event_worker(variables.worker_cookie);
                }
            }
        }

        private void update_playername(string future)
        {
            if (variables.playername != future)
            {
                variables.playername = future;
                variables.manager.label(label_playername, variables.playername, Color.Violet);
                eventer(MethodBase.GetCurrentMethod().Name, $"playername: {variables.playername}");
                if (variables.manager.get_switch_button(switch_save_cookie) == true)
                {
                    event_worker(variables.worker_cookie);
                }
            }
        }

        private void Bypasser(Session sess)
        {
            sess.bBufferResponse = true;

            if (sess != null && sess.oRequest != null && sess.oRequest.headers != null)
            {
                if (sess.fullUrl.Contains("bhvrdbd") == true)
                {
                    if (sess.fullUrl.Contains("playername") && variables.playername == null)
                    {
                        eventer(MethodBase.GetCurrentMethod().Name, $"checking playername");
                        update_playername(sess.fullUrl.Split('/')[7]);
                        eventer(MethodBase.GetCurrentMethod().Name, $"playername checked");
                    }
                    if (sess.fullUrl.Contains("token=") && variables.token == null)
                    {
                        eventer(MethodBase.GetCurrentMethod().Name, $"checking token");
                        update_token(sess.fullUrl.Split('=')[1]);
                        eventer(MethodBase.GetCurrentMethod().Name, $"token checked");
                    }
                    if (sess.RequestHeaders.ToString().Contains("bhvrSession=") == true)
                    {
                        eventer(MethodBase.GetCurrentMethod().Name, $"checking cookie");
                        update_cookie(sess.RequestHeaders["Cookie"].Replace("bhvrSession=", ""));
                        eventer(MethodBase.GetCurrentMethod().Name, $"cookie checked");
                    }
                    if (sess.fullUrl.Contains("/v1/inventories") == true && variables.manager.get_switch_button(switch_active_market) == true)
                    {
                        eventer(MethodBase.GetCurrentMethod().Name, $"bypassing inventory limitations");
                        sess.utilDecodeResponse();
                        sess.utilSetResponseBody(variables.market);
                        eventer(MethodBase.GetCurrentMethod().Name, $"inventory limitations bypassed");
                    }
                    if (sess.fullUrl.Contains("/v1/queue") == true)
                    {
                        eventer(MethodBase.GetCurrentMethod().Name, $"checking queue");
                        variables.response = sess.GetResponseBodyAsString();
                        if (variables.response.Contains("queueData") == true && variables.response.Contains("position") == true)
                        {
                            eventer(MethodBase.GetCurrentMethod().Name, $"deserializing body");
                            variables.queue = JsonConvert.DeserializeObject<settings.Queue.Rootobject>(
                                variables.response
                            );
                            eventer(MethodBase.GetCurrentMethod().Name, $"body deserialized");
                            if (variables.queue.status == "QUEUED")
                            {
                                eventer(MethodBase.GetCurrentMethod().Name, $"player in queue: {variables.queue.status}");
                                variables.manager.label(label_queue, $"{variables.queue.queueData.position}", Color.Violet);
                            } else
                            {
                                eventer(MethodBase.GetCurrentMethod().Name, $"queue status: {variables.queue.status}");
                            }
                        }
                    }
                    if (sess.fullUrl.Contains("bhvrdbd.com/api/v1/auth/provider/") == true)
                    {
                        eventer(MethodBase.GetCurrentMethod().Name, $"provided called");
                        variables.response = sess.GetResponseBodyAsString();
                        if (variables.response != null && variables.response != string.Empty)
                        {
                            eventer(MethodBase.GetCurrentMethod().Name, $"checking current ban status");
                            if (is_banned(variables.banned, variables.response) == true)
                            {
                                variables.manager.label(label_banned, "banned", Color.Red);
                            }
                            else
                            {
                                variables.manager.label(label_banned, "not banned", Color.LimeGreen);
                            }
                            eventer(MethodBase.GetCurrentMethod().Name, $"ban status checked");
                        }
                    }
                }
            }
        }

        private bool is_banned(List<string> messages, string body)
        {
            foreach (string message in messages)
            {
                if (body.Contains(message) == true)
                {
                    eventer(MethodBase.GetCurrentMethod().Name, $"client banned");
                    return (true);
                }
            }
            eventer(MethodBase.GetCurrentMethod().Name, $"client not banned");
            return (false);
        }

        private void Ana_kata_Shown(object sender, EventArgs e)
        {
            if (variables.profile.autorun == true)
            {
                InstallCertificate();
                Start();
            }
            if (variables.profile.dev_mod == true)
                variables.dev_console.Show();
        }

        private void Ana_kata_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
            UninstallCertificate();
            if (variables.profile.dev_mod == true && variables.dev_console.running == true)
            {
                variables.dev_console.running = false;
            }
            variables.dev_console.Dispose();
        }

        private void switch_dev_mod_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            update_dev_mod();
        }

        private void update_dev_mod()
        {
            if (switch_dev_mod.Checked == true)
            {
                variables.warning.ShowDialog();
            }
            variables.profile.dev_mod = switch_dev_mod.Checked;
        }
    }
}
