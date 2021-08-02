using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Fiddler;
using System.Threading.Tasks;

namespace WebSurge
{
    public partial class unlocker : Form
    {
        private UrlCaptureConfiguration CaptureConfiguration { get; set; }

        public unlocker()
        {
            InitializeComponent();
            CaptureConfiguration = new UrlCaptureConfiguration();
        }

        private void Logs(string message, Color color)
        {
            status.Text = message;
            status.ForeColor = color;

            status.Refresh();
        }

        private void Fiddler_corrupt(Session session)
        {
            if (session.RequestMethod == "CONNECT")
                return;

            if (!session.fullUrl.Contains("bhvrdbd.com"))
                return;

            if (session != null && session.oRequest != null && session.oRequest.headers != null)
            {
                if (session.fullUrl.Contains("v1/inventories"))
                {
                    this.Invoke(new Action(delegate {
                        session.utilSetRequestBody(File.ReadAllText($"Rules/{rules_menu.GetItemText(rules_menu.SelectedItem)}"));
                    }));
                }
            }
        }

        void Start()
        {
            FiddlerApplication.Startup(8888, true, true, true);
            FiddlerApplication.AfterSessionComplete += session =>
            {
                if (session.fullUrl.Contains("v1/inventories"))
                {
                    this.Invoke(new Action(delegate
                    {
                        session.utilSetRequestBody(File.ReadAllText($"Rules/{rules_menu.GetItemText(rules_menu.SelectedItem)}"));
                    }));
                }
            };
        }

        void Stop()
        {
            FiddlerApplication.AfterSessionComplete -= Fiddler_corrupt;

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
            return (true);
        }

        public static bool UninstallCertificate()
        {
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return (false);
            }
            return (true);
        }

        private void stop_all()
        {
            Cursor = Cursors.WaitCursor;

            Logs("Stopping proxy...", Color.DodgerBlue);
            Stop();
            Logs("Proxy stopped", Color.FromArgb(46, 213, 115));
            Logs("Uninstalling certificates...", Color.DodgerBlue);
            UninstallCertificate();
            Logs("Certificates uninstalled", Color.FromArgb(46, 213, 115));
            Logs("Proxy stopped", Color.FromArgb(46, 213, 115));

            rules_menu.Enabled = true;
            refresh.Enabled = true;
            run.Enabled = true;
            r_stop.Enabled = false;

            Cursor = Cursors.Default;
        }

        private void FiddlerCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_all();
        }

        private void run_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            rules_menu.Enabled = false;
            refresh.Enabled = false;
            run.Enabled = false;

            Logs("Checking Dead by Daylight status", Color.DodgerBlue);
            if (get_process() != -1)
            {
                Logs("Installing certificates...", Color.DodgerBlue);
                InstallCertificate();
                Logs("Certificates installed", Color.FromArgb(46, 213, 115));
                Logs("Starting proxy...", Color.DodgerBlue);
                Start();
                Logs("Proxy started", Color.FromArgb(46, 213, 115));
                r_stop.Enabled = true;
            }

            Cursor = Cursors.Default;
        }

        private int get_process()
        {
            Process[] dbd_process = Process.GetProcessesByName("DeadByDaylight-Win64-Shipping");
            if (dbd_process.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("To install certificates and be able to change your game content\n" +
                    "R-Unlocker need to have Dead by Daylight before starting\n\n" +
                    "Do you want to close it now ? ( Some datas may not be saved )", "Dead by Daylight running", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Logs("Closing Dead by Daylight", Color.DodgerBlue);
                    foreach (Process worker in dbd_process)
                    {
                        worker.Kill();
                        worker.WaitForExit();
                        worker.Dispose();
                    }
                    Logs("Dead by Daylight closed", Color.FromArgb(46, 213, 115));
                    return (1);
                }
                else if (dialogResult == DialogResult.No)
                {
                    Logs("Close Dead by Daylight first", Color.FromArgb(255, 71, 87));
                    return (-1);
                }
            }
            return (0);
        }

        private int get_files()
        {
            string[] files = null;
            rules_menu.Items.Clear();

            if (Directory.Exists("Rules"))
            {
                files = Directory.GetFiles("Rules", "*.*");

                if (files.Length > 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        rules_menu.Items.Add(files[i].Split('\\')[1]);
                        rules_menu.SelectedIndex = 0;
                        rules_menu.Refresh();
                    }
                    Logs($"{files.Length} rule founds", Color.FromArgb(46, 213, 115));
                }
                else
                {
                    Logs("No rule found", Color.FromArgb(255, 71, 87));
                    return (-1);
                }
            } else
            {
                Logs("Directory not found", Color.FromArgb(255, 71, 87));
                return (-1);
            }
            return (1);
        }

        private void update_rules()
        {
            if (get_files() == -1)
                run.Enabled = false;
            else
                run.Enabled = true;
        }

        private void unlocker_Load(object sender, EventArgs e)
        {
            update_rules();
            r_stop.Enabled = false;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            update_rules();
        }

        private void r_stop_Click(object sender, EventArgs e)
        {
            stop_all();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
