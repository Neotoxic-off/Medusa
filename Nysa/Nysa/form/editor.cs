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

namespace Nysa.form
{
    public partial class editor : Form
    {
        bool mouse_down = false;
        private Point offset;

        classes.Tools.Rootobject tools = null;
        string settings_path = null;

        public editor(classes.Tools.Rootobject tools_data, string path)
        {
            InitializeComponent();
            tools = tools_data;
            settings_path = path;
        }

        private void exit_Click(object sender, EventArgs e)
        {
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

        private int count_char(string str, char c)
        {
            int total = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    total++;
            }
            return (total);
        }

        private string crop(string message)
        {
            string[] splitted = null;
            int count = count_char(message, '\\');


            if (count >= 3)
            {
                splitted = message.Split('\\');

                return ($"{splitted[0]}\\{splitted[1]}\\...\\{splitted[count]}");
            }

            return (message);
        }

        private void editor_Load(object sender, EventArgs e)
        {
            version.Text = tools.version;
            background.Text = crop(tools.background);
            blur.Text = $"{tools.blur.A},{tools.blur.R},{tools.blur.G},{tools.blur.B}";
            minimalist.Text = $"{tools.minimalist}";
            color.Text = $"{tools.color.A},{tools.color.R},{tools.color.G},{tools.color.B}";
        }

        private Task update_settings()
        {
            string[] splitted = blur.Text.Split(',');
            string[] splitted_color = color.Text.Split(',');
            Color blur_color = Color.White;
            Color color_color = Color.White;

            if (splitted.Length == 4)
            {
                blur.Text = blur.Text.Replace(" ", "");
                blur_color = Color.FromArgb(
                    Int32.Parse(splitted[0]),
                    Int32.Parse(splitted[1]),
                    Int32.Parse(splitted[2]),
                    Int32.Parse(splitted[3])
                );
            }
            else
            {
                MessageBox.Show(
                    "Invalid blur format required: A,R,G,B\nExample: 255,0,0,0",
                    "Invalid blur format",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            if (splitted_color.Length == 4)
            {
                color.Text = color.Text.Replace(" ", "");
                color_color = Color.FromArgb(
                    Int32.Parse(splitted_color[0]),
                    Int32.Parse(splitted_color[1]),
                    Int32.Parse(splitted_color[2]),
                    Int32.Parse(splitted_color[3])
                );
            }
            else
            {
                MessageBox.Show(
                    "Invalid color format required: A,R,G,B\nExample: 255,0,0,0",
                    "Invalid color format",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            tools.blur = blur_color;
            tools.color = color_color;

            return (Task.CompletedTask);
        }

        private void save_Click(object sender, EventArgs e)
        {
            update_settings().Wait();

            if (File.Exists(settings_path) == true)
            {
                File.Delete(settings_path);
            }
            File.WriteAllText(settings_path, JsonConvert.SerializeObject(tools));
            Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            if (File.Exists(settings_path) == true)
            {
                File.Delete(settings_path);
            }
            File.WriteAllText(settings_path, JsonConvert.SerializeObject(tools));
            Close();
        }
    }
}
