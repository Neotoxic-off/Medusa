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

namespace Dies_Irae.Popup
{
    public partial class Settings : Form
    {
        public Profile.Settings.Rootobject profile = null;
        public Profile.Settings.Rootobject default_profile = null;
        private Controler.Manager manager = new Controler.Manager();

        BackgroundWorker saver = new BackgroundWorker();
        BackgroundWorker loader = new BackgroundWorker();

        public Settings(Profile.Settings.Rootobject input_profile)
        {
            InitializeComponent();
            InitializeWorkers();

            Region = Region.FromHrgn(Controler.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            profile = input_profile;
            default_profile = input_profile;

            loader.RunWorkerAsync();

            while (loader.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void InitializeWorkers()
        {
            saver.DoWork += new DoWorkEventHandler(save);
            loader.DoWork += new DoWorkEventHandler(load);
        }

        private void save(object sender, EventArgs e)
        {
            profile.data.numeric_magic = manager.get_numeric(numeric_magic);
            profile.data.numeric_string_minimum_size = manager.get_numeric(numeric_string_minimum_size);

            File.WriteAllText("settings\\profile", JsonConvert.SerializeObject(profile));
        }

        private void load(object sender, EventArgs e)
        {
            manager.set_numeric(numeric_magic, profile.data.numeric_magic);
            manager.set_numeric(numeric_string_minimum_size, profile.data.numeric_string_minimum_size);
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            saver.RunWorkerAsync();

            while (saver.IsBusy == true)
            {
                Application.DoEvents();
            }

            Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            profile = default_profile;

            Close();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
