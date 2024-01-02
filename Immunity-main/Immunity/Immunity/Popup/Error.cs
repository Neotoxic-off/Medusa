using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immunity.Popup
{
    public partial class Error : Form
    {
        public Error(string message)
        {
            InitializeComponent();

            label_content.Text = message;
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
