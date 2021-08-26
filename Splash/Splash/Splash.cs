using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Splash : Form
    {
        bool mouse_down = false;
        private Point offset;

        string eac_splash = null;
        string splash_path = null;
        string dbd_splash = null;
        OpenFileDialog folder_path = new OpenFileDialog();

        public Splash()
        {
            InitializeComponent();
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

        private void about_Click(object sender, EventArgs e)
        {
            string about_data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            MessageBox.Show(about_data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process.Start("https://discord.gg/Y7YagcPXh8");
            Cursor = Cursors.Default;
        }

        private void coffee_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            MessageBox.Show("Paypal: neotoxic.off@gmail.com\n\nHave a nice day", "Buy me a coffee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor = Cursors.Default;
        }

        private int get_market()
        {
            folder_path.ShowDialog();
            if (folder_path.FileName.Length > 1)
                return (1);
            return (-1);
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (get_market() == 1)
            {
                splash_path = folder_path.FileName;
                splash_path_ui.Text = crop(splash_path);
                splash_path_ui.ForeColor = Color.LimeGreen;
            }
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

        private void Splash_Load(object sender, EventArgs e)
        {
            RegistryKey data = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam", false);

            if (data != null)
            {
                eac_splash = $"{data.GetValue("InstallPath")}\\steamapps\\common\\Dead by Daylight\\EasyAntiCheat\\Launcher\\SplashScreen.png";
                dbd_splash = $"{data.GetValue("InstallPath")}\\steamapps\\common\\Dead by Daylight\\DeadByDaylight\\Content\\Splash\\Splash.bmp";
                path_install.Text = crop(eac_splash);
                path_install.ForeColor = Color.LimeGreen;

                folder_path.RestoreDirectory = true;
                folder_path.FilterIndex = 2;
                folder_path.Filter = "Images (*.png *.jpg *.jpeg)|*.png;*.jpg;*.jpeg";
            }
            else
            {
                path_install.Text = eac_splash;
                path_install.ForeColor = Color.Red;
            }
        }

        private Task DUMP(string imagename)
        {
            Image image = Image.FromFile(imagename);

            if (File.Exists(eac_splash) == true)
                File.Delete(eac_splash);
            image.Save(eac_splash, ImageFormat.Png);

            return (Task.CompletedTask);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (splash_path != null)
            {
                Cursor = Cursors.WaitCursor;
                DUMP(splash_path).Wait();
                Cursor = Cursors.Default;
                MessageBox.Show("Splash screen modified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The replacement image hasn't be set", "Image not set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void path_install_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            custom_path.ShowDialog();
            if (custom_path.SelectedPath.Length > 0)
            {
                path_install.Text = custom_path.SelectedPath;
                eac_splash = $"{custom_path.SelectedPath}\\EasyAntiCheat\\Launcher\\SplashScreen.png";
            }
            Cursor = Cursors.Default;
        }
    }
}
