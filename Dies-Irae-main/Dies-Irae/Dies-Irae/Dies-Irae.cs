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

namespace Dies_Irae
{
    public partial class Dies_Irae : Form
    {
        BackgroundWorker scanner = new BackgroundWorker();
        BackgroundWorker dumper = new BackgroundWorker();
        Controler.Manager manager = new Controler.Manager();
        Popup.Editor editor = null;
        Popup.Settings settings = null;
        Emma.Emma.Editor.Scan emma = null;

        Profile.Settings.Rootobject profile = null;

        public Dies_Irae(Profile.Settings.Rootobject input_profile)
        {
            InitializeComponent();
            InitializeUi();
            InitializeWorkers();

            profile = input_profile;
        }

        private void InitializeUi()
        {
            Region = Region.FromHrgn(Controler.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void InitializeWorkers()
        {
            scanner.DoWork += new DoWorkEventHandler(scan);
            dumper.DoWork += new DoWorkEventHandler(dump);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            select_file.ShowDialog();

            if (select_file.FileName != string.Empty)
            {
                button_scan.Enabled = true;
            } else
            {
                if (button_scan.Enabled == true)
                {
                    manager.button(button_scan, false);
                    manager.button(button_browse, false);
                    manager.button(button_scan, false);
                    manager.button(button_editor, false);
                }
            }
        }

        private void scan(object sender, EventArgs e)
        {
            manager.button(button_browse, false);
            manager.button(button_scan, false);
            manager.button(button_dump, false);
            manager.button(button_editor, false);
            manager.button(button_select_dump, false);

            emma = new Emma.Emma.Editor.Scan(profile, File.ReadAllBytes(select_file.FileName).ToList());
            editor = new Popup.Editor(emma.dump);

            manager.button(button_scan, true);
            manager.button(button_browse, true);
            manager.button(button_dump, true);
            manager.button(button_editor, true);
            manager.button(button_select_dump, true);
        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            scanner.RunWorkerAsync();

            while (scanner.IsBusy == true)
            {
                Application.DoEvents();
            }
            scanner.Dispose();
        }

        private void dump(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("hmmssddMMyyyy");

            manager.button(button_browse, false);
            manager.button(button_scan, false);
            manager.button(button_dump, false);
            manager.button(button_editor, false);
            manager.button(button_select_dump, false);

            // NDFF: Neo Data File Format
            WriteToBinaryFile<Emma.Emma.Editor.Dump>($"dump\\{date}.ndff", emma.dump);

            manager.button(button_browse, true);
            manager.button(button_scan, true);
            manager.button(button_dump, true);
            manager.button(button_editor, true);
            manager.button(button_select_dump, true);
        }

        public void WriteToBinaryFile<T>(string filePath, T objectToWrite)
        {
            Stream stream = File.Open(filePath, FileMode.Create);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binaryFormatter.Serialize(stream, objectToWrite);
        }

        public T ReadFromBinaryFile<T>(string filePath)
        {
            Stream stream = File.Open(filePath, FileMode.Open);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            
            return (T)binaryFormatter.Deserialize(stream);
        }

        private void button_dump_Click(object sender, EventArgs e)
        {
            dumper.RunWorkerAsync();

            while (dumper.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            settings = new Popup.Settings(profile);
            settings.ShowDialog();

            profile = settings.profile;
        }

        private void button_editor_Click(object sender, EventArgs e)
        {
            editor.ShowDialog();
        }

        private bool select_dump_event()
        {
            select_dump.ShowDialog();

            if (select_dump.FileName != string.Empty)
            {
                return (true);
            }

            return (false);
        }

        private void button_select_dump_Click(object sender, EventArgs e)
        {
            if (select_dump_event() == true)
            {
                manager.button(button_editor, true);
                editor = new Popup.Editor(
                    ReadFromBinaryFile<Emma.Emma.Editor.Dump>(select_dump.FileName)
                );
            }
            else
            {
                if (emma != null)
                {
                    editor = new Popup.Editor(emma.dump);
                } else if (button_editor.Enabled == true)
                {
                    manager.button(button_editor, false);
                }
            }
        }
    }
}
