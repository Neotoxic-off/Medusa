using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Nysa
{
    public partial class Settings : Form
    {
        bool mouse_down = false;
        private Point offset;
        private classes.Tools.Rootobject settings_tools = null;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private Task load_settings()
        {
            string path = "Settings.json";

            if (File.Exists(path) == true)
            {
                settings_tools = JsonConvert.DeserializeObject<classes.Tools.Rootobject>(
                    File.ReadAllText(path)
                );
            }
            else
            {
                MessageBox.Show($"Settings file: '{path}' not found", $"{path}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            return (Task.CompletedTask);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/Y7YagcPXh8");
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Neotoxic-off");
        }

        private void simp_CheckedChanged(object sender, EventArgs e)
        {
            if (pure.Checked == true)
            {

            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
