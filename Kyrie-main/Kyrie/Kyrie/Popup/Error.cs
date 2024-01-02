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

using ComponentFactory.Krypton.Toolkit;

namespace Kyrie.Popup
{
    public partial class Error : Form
    {
        public Error(Constants.Errors.Item item)
        {
            InitializeComponent();

            label_content.Text = item.message;
            Region = Region.FromHrgn(UI.Border.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Error_Load(object sender, EventArgs e)
        {

        }

        private void Error_Shown(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Error1);
            simpleSound.Play();
        }
    }
}
