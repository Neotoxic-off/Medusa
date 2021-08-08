using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Fiddler;

namespace Cookie_Monster
{
    public partial class Form1 : Form
    {
        bool mouse_down = false;
        private Point offset;

        string playername = null;
        string playerID = null;
        string token = null;
        string bhvrsession = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            string about_data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(about_data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            run.Enabled = false;
            Stop();
            UninstallCertificate();
            Cursor = Cursors.Default;

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

        private void Bypasser(Session sess)
        {
            if (sess != null && sess.oRequest != null && sess.oRequest.headers != null)
            {
                if (sess.fullUrl.Contains("bhvrdbd"))
                {
                    if (sess.RequestHeaders.ToString().Contains("bhvrSession=") && bhvrsession == null)
                    {
                        bhvrsession = sess.RequestHeaders["Cookie"];
                        BeginInvoke(new Action(delegate {
                            cookie_status.Text = "grabbed";
                            cookie_status.ForeColor = Color.LimeGreen;
                        }));
                    }

                    if (sess.fullUrl.Contains("token=") && token == null)
                    {
                        token = sess.fullUrl.Split('=')[1];
                        BeginInvoke(new Action(delegate {
                            token_status.Text = "grabbed";
                            token_status.ForeColor = Color.LimeGreen;
                        }));
                    }

                    if (sess.fullUrl.Contains("friends/richPresence/") && playerID == null)
                    {
                        playerID = sess.fullUrl.Replace("https://steam.live.bhvrdbd.com/api/v1/friends/richPresence/", "");
                        BeginInvoke(new Action(delegate {
                            id_status.Text = "grabbed";
                            id_status.ForeColor = Color.LimeGreen;
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

            FiddlerApplication.BeforeResponse += Bypasser;
        }

        public void Stop()
        {
            FiddlerApplication.BeforeResponse -= Bypasser;

            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        private void run_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            run.Enabled = false;
            InstallCertificate();
            Start();
            Cursor = Cursors.Default;
        }
    }
}
