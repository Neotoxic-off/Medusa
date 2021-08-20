using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Convert
{
    public partial class Converter : Form
    {
        bool mouse_down = false;
        private Point offset;

        OpenFileDialog folder_path = new OpenFileDialog();

        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            folder_path.Multiselect = true;
            folder_path.RestoreDirectory = true;
            folder_path.FilterIndex = 2;
            folder_path.Filter = "Images formats (*.png *.jpg *.jpeg *.ico *.bmp *.tiff)|*.png;*.jpg;*.jpeg;*.ico;*.bmp;*.tiff";
            output_format.SelectedIndex = 0;
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

        private void browse_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            folder_path.ShowDialog();
            if (folder_path.FileName.Length > 0)
            {
                convert.Enabled = true;
            }
            Cursor = Cursors.Default;
        }

        private string rename(string name, string format)
        {
            string converted = "Converted";
            string without_path = $"{converted}\\{name.Split('\\')[name.Split('\\').Length - 1]}";
            string cleanned = without_path.Replace($".{without_path.Split('.')[without_path.Split('.').Length - 1]}", "");
            string output = without_path;
            bool status = true;

            if (Directory.Exists($"{converted}") == false)
            {
                Directory.CreateDirectory($"{converted}");
            }

            for (uint i = 0; status == true; i++)
            {
                output = $"{cleanned}_{i}.{format}";
                status = File.Exists(output);
            }

            return (output);
        }

        private Task format(string path)
        {
            Image image = Image.FromFile(path);
            string renamed = null;
            string selected = output_format.SelectedItem.ToString();
            List<ImageFormat> formats = new List<ImageFormat>()
            {
                null,
                ImageFormat.Png,
                ImageFormat.Jpeg,
                ImageFormat.Icon,
                ImageFormat.Bmp,
                ImageFormat.Tiff
            };

            if (selected != "all")
            {
                renamed = rename(folder_path.FileName, selected);
                if (selected == "jpeg")
                    image.Save(renamed, ImageFormat.Jpeg);
                if (selected == "bmp")
                    image.Save(renamed, ImageFormat.Bmp);
                if (selected == "tiff")
                    image.Save(renamed, ImageFormat.Tiff);
                if (selected == "ico")
                    image.Save(renamed, ImageFormat.Icon);
            }
            else
            {
                for (int i = 1; i < formats.Count; i++)
                {
                    image.Save(rename(folder_path.FileName, output_format.Items[i].ToString()), formats[i]);
                }
            }
            
            return (Task.CompletedTask);
        }

        private void convert_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            status.Text = "converting";
            for (int i = 0; i < folder_path.FileNames.Length; i++)
            {
                format(folder_path.FileNames[i]).Wait();
            }
            status.Text = "converted";
            Cursor = Cursors.Default;
        }
    }
}
