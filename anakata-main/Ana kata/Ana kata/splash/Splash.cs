using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;

namespace Ana_kata.splash
{
    public partial class Splash : KryptonForm
    {
        private BackgroundWorker bw_loader = new BackgroundWorker();
        private Required required = new Required();
        private components.Manager manager = new components.Manager();
        private Dictionary<string, bool> result = new Dictionary<string, bool>();

        public bool success = false;
        public settings.Profile.Rootobject profile = null;

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
            result.Add("folders", folders());
            result.Add("files", files());
            result.Add("profile", load_profile());
            result.Add("market", download());
            resume();
        }

        private bool load_profile()
        {
            if (result["folders"] == true && result["files"] == true)
            {
                manager.label(label_status, "loading profile", Color.White);
                profile = JsonConvert.DeserializeObject<settings.Profile.Rootobject>(File.ReadAllText("settings\\profile.json"));
                return (true);
            }
            return (false);
        }

        public void resume()
        {
            bool display = false;
            string buffer = "";
            popup.ok failed = null;

            foreach (var data in result)
            {
                if (data.Value == false)
                {
                    buffer += $"{data.Key} : {data.Value}\n";
                    if (display == false)
                        display = true;
                }
            }
            if (display == true)
            {
                failed = new popup.ok("Missing requirements", $"Missing requirements:\n\n{buffer}");
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
                "settings",
                "market"
            };
            manager.label(label_status, "checking folders", Color.White);

            return (required.folders(list_folders));
        }

        public bool files()
        {
            List<string> list_files = new List<string>()
            {
                "settings\\profile.json"
            };
            manager.label(label_status, "checking files", Color.White);

            return (required.files(list_files));
        }

        public bool download()
        {
            WebClient client = null;

            if (profile != null)
            {
                if (profile.market.autoupdate == true)
                {
                    manager.label(label_status, "updating market", Color.White);
                    client = new WebClient();
                    client.DownloadFile("https://eclipsed.top/blob/market.json", "market\\market.json");
                }
            }

            return (true);
        }

        public void waiter()
        {
            return;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
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
    }
}
