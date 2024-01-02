using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;

namespace Kyrie.Splash
{
    public partial class Splash : Form
    {
        private BackgroundWorker bw_loader = new BackgroundWorker();
        private Required required = new Required();
        private Components.Manager manager = new Components.Manager();
        private Constants.Paths paths = new Constants.Paths();
        private Constants.Errors errors = new Constants.Errors();

        public bool success = false;
        public Settings.Profile.Rootobject profile = null;

        public Popup.Error missing_file = null;
        public Popup.Error missing_folder = null;
        public Popup.Error profile_error = null;
        public Popup.Error vm_error = null;

        public bool status_folders = false;
        public bool status_files = false;
        public bool status_profile = false;
        public bool status_vm = false;

        public Splash()
        {
            InitializeComponent();
            InitializeWorker();

            Region = Region.FromHrgn(UI.Border.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void InitializeWorker()
        {
            bw_loader.DoWork += new DoWorkEventHandler(loader);
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

        public void loader(object sender, EventArgs e)
        {
            status_folders = folders();

            if (status_folders == true)
            {
                status_files = files();
                status_vm = vm();
                status_profile = load_profile();
                if (status_files == true && status_vm == true)
                {
                    success = update();
                }
            }
        }

        private bool load_profile()
        {
            manager.label(label_status, "loading profile", Color.White);
            profile = JsonConvert.DeserializeObject<Settings.Profile.Rootobject>(File.ReadAllText(paths.profile));

            if (profile != null)
                if (profile.Kyrie.version != null)
                    return (true);
            return (false);
        }

        public bool folders()
        {
            List<string> list_folders = new List<string>()
            {
                "lib",
                "settings",
                "downloads"
            };
            manager.label(label_status, "checking folders", Color.White);

            if (required.folders(list_folders) == false)
            {
                missing_folder = new Popup.Error(errors.missing_folder);
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
                missing_file = new Popup.Error(errors.missing_file);
                missing_file.ShowDialog();
                return (false);
            }
            return (true);
        }

        public bool vm()
        {
            Security.VM security = new Security.VM();

            manager.label(label_status, "checking platform", Color.White);

            if (security.status == true)
            {
                vm_error = new Popup.Error(errors.vm_error);
                vm_error.ShowDialog();
                return (false);
            }
            return (true);
        }

        public bool update()
        {
            Constants.Version current = new Constants.Version();
            WebClient client = new WebClient();
            string get_version = null;

            manager.label(label_status, "checking version", Color.White);
            
            client.DownloadFile("https://raw.githubusercontent.com/Elevatia/panel/main/version", paths.version);
            get_version = version(paths.version);
            if (get_version != current.value || status_profile == false || (status_profile == true && get_version != profile.Kyrie.version))
            {
                manager.label(label_status, "updating profile", Color.White);
                client.DownloadFile("https://raw.githubusercontent.com/Elevatia/panel/main/profile", paths.profile);
                client.DownloadFile("https://raw.githubusercontent.com/Elevatia/panel/main/changelog", paths.changelogs);
                manager.label(label_status, "profile updated", Color.White);
                if (load_profile() == false)
                {
                    profile_error = new Popup.Error(errors.missing_file);
                    profile_error.ShowDialog();
                    return (false);
                }
                else
                {
                    return (true);
                }
            }

            return (true);
        }

        public string version(string path)
        {
            return (File.ReadAllText(path).Replace("\n", ""));
        }

        public void waiter()
        {
            return;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
