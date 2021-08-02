using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Fiddler;

namespace WebSurge
{
    public partial class Duality : Form
    {
        private const string Separator = "------------------------------------------------------------------";
        private UrlCaptureConfiguration CaptureConfiguration { get; set; }

        public Duality()
        {
            InitializeComponent();
            CaptureConfiguration = new UrlCaptureConfiguration();  // this usually comes from configuration settings
        }

        private void FiddlerApplication_AfterSessionComplete(Session sess)
        {
            if (sess.RequestMethod == "CONNECT")
                return;

            if (!sess.fullUrl.Contains("bhvrdbd.com"))
                return;

            if (sess != null && sess.oRequest != null && sess.oRequest.headers != null)
            {
                string headers = sess.oRequest.headers.ToString();
                var reqBody = Encoding.UTF8.GetString(sess.RequestBody);

                string firstLine = $"{sess.RequestMethod} {sess.fullUrl} {sess.oRequest.headers.HTTPVersion}";
                int at = headers.IndexOf("\r\n");
                if (at >= 0)
                {
                    headers = $"{firstLine}\r\n{headers.Substring(at + 1)}";
                    string output = $"{headers}\r\n{(!string.IsNullOrEmpty(reqBody) ? reqBody + "\r\n" : string.Empty)}{Separator}\r\n\r\n";

                    BeginInvoke(new Action<string>((text) =>
                    {
                        txtCapture.AppendText(text);
                        UpdateButtonStatus();
                    }), output);
                }
            }
        }

        void Start()
        {
            CaptureConfiguration.IgnoreResources = false;

            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Startup(8888, true, true, true);
        }

        void Stop()
        {
            FiddlerApplication.AfterSessionComplete -= FiddlerApplication_AfterSessionComplete;

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

        private void ButtonHandler(object sender, EventArgs e)
        {
            if (sender == capture_start)
                Start();
            else if (sender == capture_stop)
                Stop();
            else if (sender == tbSave)
            {
                var diag = new SaveFileDialog()
                {
                    AutoUpgradeEnabled = true,
                    CheckPathExists = true,
                    DefaultExt = "txt",
                    Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*",
                    OverwritePrompt = false,
                    Title = "Save Fiddler Capture File",
                    RestoreDirectory = true
                };
                var res = diag.ShowDialog();

                if (res == DialogResult.OK)
                {
                    if (File.Exists(diag.FileName))
                        File.Delete(diag.FileName);
                    File.WriteAllText(diag.FileName, txtCapture.Text);
                }
            }
            else if (sender == tbClear)
            {
                txtCapture.Text = string.Empty;
            }
            else if (sender == btnInstallSslCert)
            {
                Cursor = Cursors.WaitCursor;
                InstallCertificate();
                Cursor = Cursors.Default;
            }
            else if (sender == btnUninstallSslCert)
                UninstallCertificate();

            UpdateButtonStatus();
        }

        private void FiddlerCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        public void UpdateButtonStatus()
        {
            capture_start.Enabled = !FiddlerApplication.IsStarted();
            capture_stop.Enabled = !capture_start.Enabled;
            tbSave.Enabled = txtCapture.Text.Length > 0;
            tbClear.Enabled = tbSave.Enabled;

            btnInstallSslCert.Enabled = !CertMaker.rootCertExists();
            btnUninstallSslCert.Enabled = !btnInstallSslCert.Enabled;
        }

        private void capture_start_Click(object sender, EventArgs e)
        {
            ButtonHandler(sender, e);
        }

        private void capture_stop_Click(object sender, EventArgs e)
        {
            ButtonHandler(sender, e);
        }

        private void Duality_Load(object sender, EventArgs e)
        {
        }
    }
}
