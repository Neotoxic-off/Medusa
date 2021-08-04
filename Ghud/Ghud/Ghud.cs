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
using RestSharp;
using Fiddler;

namespace Ghud
{
    public partial class Ghud : Form
    {
        bool mouse_down = false;
        private Point offset;
        string cookie = null;

        classes.guest.Rootobject guest = null;

        public Ghud()
        {
            InitializeComponent();
        }

        private void Ghud_Load(object sender, EventArgs e)
        {
        }

        private Task generate_guest()
        {
            RestClient client = new RestClient();
            IRestRequest bhvr_request = new RestRequest("https://steam.live.bhvrdbd.com/api/v1/auth/login/guest")
                .AddHeader("Host", "steam.live.bhvrdbd.com")
                .AddHeader("Accept-Encoding", "deflate, gzip")
                .AddHeader("Accept", "*/*")
                .AddHeader("Content-Type", "application/octet-stream");
            IRestResponse response = client.Post(bhvr_request);

            guest = JsonConvert.DeserializeObject<classes.guest.Rootobject>(response.Content);

            update($"Account token: {guest.guestToken}").Wait();

            return (Task.CompletedTask);
        }

        private Task queue()
        {
            string json = "{'additionalUserIds':[],'category':'live-397052-live','checkOnly':false,'countA':1,'countB':4,'latencies':[{'latency':323,'regionName':'ap-south-1'},{'latency':73,'regionName':'eu-west-1'},{'latency':374,'regionName':'ap-southeast-1'},{'latency':398,'regionName':'ap-southeast-2'},{'latency':48,'regionName':'eu-central-1'},{'latency':293,'regionName':'ap-northeast-2'},{'latency':271,'regionName':'ap-northeast-1'},{'latency':132,'regionName':'us-east-1'},{'latency':238,'regionName':'sa-east-1'},{'latency':221,'regionName':'us-west-2'}],'platform':'Windows','props':{'CrossplayOptOut':'false','characterName':'Claudette'},'rank':20,'region':'all','side':'B'}";
            
            RestClient client = new RestClient();
            IRestRequest bhvr_request = new RestRequest("https://steam.live.bhvrdbd.com/api/v1/queue")
                .AddHeader("Host", "steam.live.bhvrdbd.com")
                .AddHeader("Accept-Encoding", "deflate, gzip")
                .AddHeader("Accept", "*/*")
                .AddHeader("Content-Type", "application/json")
                .AddCookie("bhvrSession", cookie)
                .AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);

            guest = JsonConvert.DeserializeObject<classes.guest.Rootobject>(response.Content);

            return (Task.CompletedTask);
        }

        private void about_Click(object sender, EventArgs e)
        {
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Stop();
            running.Text = "stopped";
            running.ForeColor = Color.Orange;
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

        private void FiddlerApplication_AfterSessionComplete(Session sess)
        {
            string url = null;

            if (sess != null)
            {
                if (cookie == null)
                {
                    if (sess.RequestHeaders.ToString().Contains("bhvrSession="))
                    {
                        this.Invoke(new Action(delegate {
                            cookie = sess.RequestHeaders["Cookie"];
                            update($"Cookie: {cookie}").Wait();
                        }));
                    }
                }
                url = ids(sess.fullUrl);
                if (url != null)
                {
                    this.Invoke(new Action(delegate {
                        update($"{url}").Wait();
                        update($"{corrupter(url, sess)}").Wait();
                        sess.fullUrl = corrupter(url, sess);
                        /*
                        if (sess.GetRequestBodyAsString().Length > 0)
                        {
                            update_body($"{sess.GetRequestBodyAsString()}").Wait();
                            sess.utilSetRequestBody(corrupter(url));
                            update_body($"{sess.GetRequestBodyAsString()}").Wait();
                        }
                        */
                    }));
                }
                else if (sess.fullUrl.Contains("https://steam.live.bhvrdbd.com") == true)
                {
                    this.Invoke(new Action(delegate {
                        update_body($"{sess.fullUrl}").Wait();
                    }));
                }
            }
        }

        private Task update(string value)
        {
            list_data.AppendText($"{value}\n");
            list_data.ForeColor = Color.LimeGreen;

            return (Task.CompletedTask);
        }

        private Task update_body(string value)
        {
            body_data.AppendText($"{value}\n");
            body_data.ForeColor = Color.Cyan;

            return (Task.CompletedTask);
        }

        private string ids(string url)
        {
            List<string> id = new List<string>()
            {
                { "/v1/auth/" }
            };

            for (int i = 0; i < id.Count; i++)
                if (url.Contains(id[i]) == true)
                    return (id[i]);
            return (null);
        }

        private string corrupter(string key, Session sess)
        {
            Dictionary<string, string> corruption = new Dictionary<string, string>()
            {
                { "/v1/auth/", $"https://steam.live.bhvrdbd.com/api/v1/auth/provider/kraken/login?token={guest.guestToken}" }
            };

            if (corruption.ContainsKey(key) == true)
                return (corruption[key]);
            return (null);
        }

        public void Start()
        {
            FiddlerCoreStartupSettings startupSettings = new FiddlerCoreStartupSettingsBuilder()
                .RegisterAsSystemProxy()
                .DecryptSSL()
                .Build();
            FiddlerApplication.Startup(startupSettings);

            FiddlerApplication.BeforeRequest += FiddlerApplication_AfterSessionComplete;
        }

        public void Stop()
        {
            FiddlerApplication.BeforeRequest -= FiddlerApplication_AfterSessionComplete;

            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        private void run_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            generate_guest().Wait();
            InstallCertificate();
            Start();
            running.Text = "running";
            running.ForeColor = Color.LimeGreen;
            Cursor = Cursors.Default;
        }

        private void stop_proxy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Stop();
            running.Text = "stopped";
            running.ForeColor = Color.Orange;
            Cursor = Cursors.Default;
        }

        private void dump_Click(object sender, EventArgs e)
        {
            string path = "dump.log";

            Cursor = Cursors.WaitCursor;
            if (File.Exists(path) == true)
                File.Delete(path);
            File.AppendAllText(path, $"{list_data.Text}\n");

            File.AppendAllText(path, $"{body_data.Text}\n");
            Cursor = Cursors.Default;
        }
    }
}
