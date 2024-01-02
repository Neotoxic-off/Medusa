using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrie
{
    public partial class Kyrie : Form
    {
        private Settings.Profile.Rootobject profile = null;
        private Popup.Display logs = null;
        private Constants.Errors errors = new Constants.Errors();
        private BackgroundWorker sounder = new BackgroundWorker();

        public Kyrie(Settings.Profile.Rootobject input_profile)
        {
            InitializeComponent();
            InitializeWorker();

            profile = input_profile;
            Region = Region.FromHrgn(UI.Border.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            logs = new Popup.Display(errors.display_logs);
        }

        private void InitializeWorker()
        {
            sounder.DoWork += new DoWorkEventHandler(sounds);
        }

        private void Kyrie_Load(object sender, EventArgs e)
        {
            label_version.Text = profile.Kyrie.version;
            foreach (Settings.Profile.Module module in profile.Kyrie.modules)
            {
                list_tools.Items.Add(module.name);
            }
        }

        private string get_url(string data)
        {
            foreach (Settings.Profile.Module module in profile.Kyrie.modules)
            {
                if (module.name == data)
                    return (module.url);
            }
            return (null);
        }

        private void sounds(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.save);
            simpleSound.Play();
        }

        private void button_play_Click_1(object sender, EventArgs e)
        {
            Popup.Downloading popup = null;
            string url = null;

            if (list_tools.SelectedItem != null)
            {
                url = get_url(list_tools.SelectedItem.ToString());
                if (url != null)
                {
                    popup = new Popup.Downloading(url);
                    popup.ShowDialog();
                }
            }
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button_reduce_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Kyrie_Shown(object sender, EventArgs e)
        {
            sounder.RunWorkerAsync();

            while (sounder.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void button_changelogs_Click(object sender, EventArgs e)
        {
            logs.ShowDialog();
        }
    }
}
