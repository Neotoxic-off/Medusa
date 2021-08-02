using System;
using System.IO;
using System.Windows.Forms;

using Fiddler;
using Nana;

namespace Playername
{
    public partial class Playername : Form
    {
        string playername = null;
        string playerID = null;
        string token = null;
        string bhvrsession = null;

        private configuration nana_configuration { get; set; }

        public Playername()
        {
            InitializeComponent();
            nana_configuration = new configuration();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            start.Enabled = false;
            InstallCertificate();
            Start();
            b_stop.Enabled = true;
            Cursor = Cursors.Default;
        }

        private string resume()
        {
            string data = null;

            data = $"{playername}:\n\nPlayerID={playerID}\nToken={token}\n{bhvrsession}";

            return (data);
        }

        private void Dump_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog()
            {
                AutoUpgradeEnabled = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*",
                OverwritePrompt = false,
                Title = "Save player information file",
                RestoreDirectory = true
            };
            var res = diag.ShowDialog();

            if (res == DialogResult.OK)
            {
                if (File.Exists(diag.FileName))
                    File.Delete(diag.FileName);
                File.WriteAllText(diag.FileName, resume());
            }
        }

        void Start()
        {
            FiddlerCoreStartupSettings settings = new FiddlerCoreStartupSettingsBuilder()
                .RegisterAsSystemProxy()
                .DecryptSSL()
                .AllowRemoteClients()
                .Build();

            FiddlerApplication.Startup(settings);
            FiddlerApplication.AfterSessionComplete += session =>
            {
                if (session.fullUrl.Contains("bhvrdbd.com"))
                {
                    if (playername != null && bhvrsession != null && token != null && playerID != null)
                    {
                        if (Dump.InvokeRequired)
                        {
                            Dump.Invoke(new Action(() =>
                            {
                                Dump.Enabled = true;
                            }));
                        }
                    } else
                    {
                        if (session.fullUrl.Contains("playername/steam/") && playername == null)
                        {
                            playername = session.fullUrl.Replace("https://steam.live.bhvrdbd.com/api/v1/playername/steam/", "");
                        }

                        if (session.RequestHeaders.ToString().Contains("bhvrSession=") && bhvrsession == null)
                        {
                            bhvrsession = session.RequestHeaders["Cookie"];
                        }

                        if (session.fullUrl.Contains("token=") && token == null)
                        {
                            token = session.fullUrl.Split('=')[1];
                        }

                        if (session.fullUrl.Contains("friends/richPresence/") && playerID == null)
                        {
                            playerID = session.fullUrl.Replace("https://steam.live.bhvrdbd.com/api/v1/friends/richPresence/", "");
                        }
                    }
                }
            };
        }

        void Stop()
        {
            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        public static bool InstallCertificate()
        {
            if (!CertMaker.rootCertExists())
            {
                if (!CertMaker.createRootCert())
                    return (false);

                if (!CertMaker.trustRootCert())
                    return (false);
            }
            return true;
        }

        public static bool UninstallCertificate()
        {
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return (false);
            }
            return true;
        }

        private void Playername_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
            UninstallCertificate();
        }

        private void b_stop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            b_stop.Enabled = false;
            Dump.Enabled = false;
            Stop();
            UninstallCertificate();
            start.Enabled = true;

            playername = null;
            playerID = null;
            token = null;
            bhvrsession = null;
            Cursor = Cursors.Default;
        }
    }
}
