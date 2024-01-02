using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace Stabbed.splash
{
    public partial class Splash : KryptonForm
    {
        private BackgroundWorker bw_loader = new BackgroundWorker();
        private Required required = new Required();
        private components.Manager manager = new components.Manager();
        private Dictionary<string, bool> result = new Dictionary<string, bool>();

        public bool success = false;
        public List<string> list_configs = new List<string>();
        public List<string> list_backups = new List<string>();

        public Splash()
        {
            InitializeComponent();
            InitializeWorker();
        }

        private void InitializeWorker()
        {
            bw_loader.DoWork += new DoWorkEventHandler(loader);
        }

        public void loader(object sender, EventArgs e)
        {
            waiter();
            manager.label(label_status, "checking folders");
            result.Add("folders", folders());
            manager.label(label_status, "checking files");
            result.Add("files", files());
            manager.label(label_status, "checking files");
            result.Add("configurations", configurations());
            manager.label(label_status, "loading configurations");
            result.Add("backups", backups());
            manager.label(label_status, "loading backups");
            resume();
        }

        public void resume()
        {
            bool display = false;
            popup.ok failed = new popup.ok("Missing requirements", "A resource is missing");

            foreach (var data in result)
            {
                if (data.Value == false)
                {
                    if (display == false)
                        display = true;
                }
            }
            if (display == true)
            {
                failed.ShowDialog();
            }
            else
            {
                success = true;
            }
        }

        public bool folders()
        {
            List<string> list_folders = new List<string>()
            {
                "lib",
                "backups",
                "generated",
                "configurations"
            };
            Thread.Sleep(200);

            return (required.folders(list_folders));
        }

        public bool files()
        {
            List<string> list_files = new List<string>();
            Thread.Sleep(200);

            return (required.files(list_files));
        }

        public bool configurations()
        {
            if (Directory.Exists("configurations") == true)
            {
                list_configs = Directory.GetFiles("configurations", "*.ini").ToList();
                Thread.Sleep(200);
                return (true);
            }
            return (false);
        }

        public bool backups()
        {
            if (Directory.Exists("backups") == true)
            {
                list_backups = Directory.GetFiles("backups", "*.stb").ToList();
                Thread.Sleep(200);
                return (true);
            }
            return (false);
        }


        public void waiter()
        {
            return;
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            bw_loader.RunWorkerAsync();

            while (bw_loader.IsBusy == true)
            {
                Application.DoEvents();
            }
            Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
