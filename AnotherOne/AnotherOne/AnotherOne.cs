using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace AnotherOne
{
    public partial class AnotherOne : Form
    {
        bool mouse_down = false;
        private Point offset;

        public AnotherOne()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private Task load_computer_username()
        {
            computer_username.Text = Environment.UserName;
            computer_username.ForeColor = Color.LimeGreen;

            return (Task.CompletedTask);
        }

        private Task load_computer_windows()
        {
            computer_version.Text = $"{Environment.OSVersion.Version}";
            computer_version.ForeColor = Color.LimeGreen;

            computer_platform.Text = $"{Environment.OSVersion.Platform}";
            computer_platform.ForeColor = Color.LimeGreen;

            return (Task.CompletedTask);
        }

        private Task load_computer()
        {
            load_computer_username().Wait();
            load_computer_windows().Wait();

            return (Task.CompletedTask);
        }

        private void AnotherOne_Load(object sender, EventArgs e)
        {
            load_computer().Wait();
        }
    }
}
