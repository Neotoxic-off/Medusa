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

namespace Dies_Irae.Splash
{
    public partial class Splash : Form
    {
        private BackgroundWorker bw_loader = new BackgroundWorker();
        private Required required = new Required();
        private Controler.Manager manager = new Controler.Manager();

        public bool success = false;
        public Profile.Settings.Rootobject profile = null;

        public Popup.Error missing_file = null;
        public Popup.Error missing_folder = null;
        public Popup.Error invalid_profile = null;

        public bool status_folders = false;
        public bool status_files = false;
        public bool status_profile = false;
        public bool status_vm = false;

        public Splash()
        {
            InitializeComponent();
            InitializeWorker();

            Region = Region.FromHrgn(Controler.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void InitializeWorker()
        {
            bw_loader.DoWork += new DoWorkEventHandler(loader);
        }

        public void loader(object sender, EventArgs e)
        {
            status_folders = folders();

            if (status_folders == true)
            {
                status_files = files();
                status_profile = load_profile();
                if (status_files == true && status_profile == true)
                {
                    success = true;
                }
            }
        }

        private bool load_profile()
        {
            manager.label(label_status, "loading profile", Color.White);
            profile = JsonConvert.DeserializeObject<Profile.Settings.Rootobject>(File.ReadAllText("settings\\profile"));

            if (profile != null)
            {
                if (profile.data != null)
                {
                    return (true);
                }
            }
            invalid_profile = new Popup.Error("Your profile is not valid. Make sure you extracted the archive and downloaded Dies irae from Elevatia's server");
            invalid_profile.ShowDialog();
            return (false);
        }

        public bool folders()
        {
            List<string> list_folders = new List<string>()
            {
                "lib",
                "settings",
                "dump"
            };
            manager.label(label_status, "checking folders", Color.White);

            if (required.folders(list_folders) == false)
            {
                missing_folder = new Popup.Error("Oh well, this is embarasing, a required folder is missing. Make sure you extracted the archive and downloaded Dies irae from Elevatia's server");
                missing_folder.ShowDialog();
                return (false);
            }
            return (true);
        }

        public bool files()
        {
            List<string> list_files = new List<string>()
            {
                "settings\\profile"
            };
            manager.label(label_status, "checking files", Color.White);

            if (required.files(list_files) == false)
            {
                missing_file = new Popup.Error("Oh well, this is embarasing, a required file is missing. Make sure you extracted the archive and downloaded Dies irae from Elevatia's server");
                missing_file.ShowDialog();
                return (false);
            }
            return (true);
        }

        private void Splash_Shown_1(object sender, EventArgs e)
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
