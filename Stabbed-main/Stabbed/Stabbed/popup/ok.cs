using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace Stabbed.popup
{
    public partial class ok : KryptonForm
    {
        public ok(string title, string content)
        {
            InitializeComponent();
            label_content.Text = content;
            label_title.Text = title;
        }

        private void ok_Load(object sender, EventArgs e)
        {

        }

        private void button_patch_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
