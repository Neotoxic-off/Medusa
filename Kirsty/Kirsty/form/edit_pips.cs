using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirsty.form
{
    public partial class edit_pips : Form
    {
        string backup = null;

        bool mouse_down = false;
        private Point offset;

        public edit_pips(string _key, string _value)
        {
            InitializeComponent();
            key.Text = _key;
            value.Text = _value;
            backup = _value;
        }

        public int get_data()
        {
            return (int.Parse(value.Text));
        }

        private void save_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (int.TryParse(value.Text, out n) == false)
            {
                MessageBox.Show("Value must be a number", "Error: wrong type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (n >= 0 && n <= 85)
                    Close();
                else
                    MessageBox.Show("Value must be between 0 and 85", "Error: wrong type value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abort_Click(object sender, EventArgs e)
        {
            value.Text = backup;
            Close();
        }

        private void border_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;

            mouse_down = true;
        }

        private void border_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down == true)
            {
                Point pos = PointToScreen(e.Location);
                Location = new Point(pos.X - offset.X, pos.Y - offset.Y);
            }
        }

        private void border_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void value_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
