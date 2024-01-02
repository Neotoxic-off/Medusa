using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace Kyrie.Popup
{
    public partial class Downloading : Form
    {
        private string url = null;
        private BackgroundWorker worker = new BackgroundWorker();

        public Downloading(string input_url)
        {
            InitializeComponent();

            url = input_url;
            InitializeWorker();

            Region = Region.FromHrgn(UI.Border.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void InitializeWorker()
        {
            worker.DoWork += new DoWorkEventHandler(download);
        }

        private void Downloading_Load(object sender, EventArgs e)
        {

        }

        private void Downloading_Shown(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.error);

            worker.RunWorkerAsync();
            simpleSound.Play();
            while (worker.IsBusy == true)
            {
                Application.DoEvents();
            }
            Close();
        }

        private string get_file(string path)
        {
            string[] splitted = path.Split('/');

            return (splitted[splitted.Length - 1]);
        }

        private void download(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            client.DownloadFile(url, $"downloads\\{get_file(url)}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
