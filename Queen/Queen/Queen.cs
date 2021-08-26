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

namespace Majesty
{
    public partial class Majesty : Form
    {
        string[] config = null;
        string[] pak = null;
        string magic = null;
        List<byte> bhvr_config = new List<byte>();
        Dictionary<string, int> ids = new Dictionary<string, int>()
        {
            { "start", 0 },
            { "end", 0 }
        };

        bool mouse_down = false;
        private Point offset;

        public Majesty()
        {
            InitializeComponent();
        }

        private Task update_logs(string value)
        {
            logs.AppendText($"{value}\n");
            logs.Refresh();
            logs.SelectionStart = logs.Text.Length;
            logs.ScrollToCaret();

            return (Task.CompletedTask);
        }

        private Task update_status(string value)
        {
            status.Text = $"{value}";
            status.Refresh();

            return (Task.CompletedTask);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private bool load_template_content()
        {
            bool status = false;
            update_status("workplace loading").Wait();

            update_logs("----------------------------------------------------------").Wait();

            if (File.Exists($"{load_template.SelectedPath}\\patch") == true)
            {
                config = File.ReadAllLines($"{load_template.SelectedPath}\\patch");
                update_logs($"patch length: {config.Length}").Wait();
                if (File.Exists($"{load_template.SelectedPath}\\magic") == true)
                {
                    magic = File.ReadAllText($"{load_template.SelectedPath}\\magic");
                    update_logs($"magic: {magic}").Wait();
                }
                else
                {
                    update_logs($"ERROR: magic not found").Wait();
                }
            }
            else
            {
                update_logs($"ERROR: patch not found").Wait();
            }
            update_status("workplace loaded").Wait();

            update_logs("----------------------------------------------------------").Wait();

            return (status);
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            load_template.ShowDialog();
            if (load_template.SelectedPath.Length > 1)
            {
                update_logs($"workplace path set").Wait();
                load_template_content();
                button_load.Enabled = false;
                button_pakchunk.Enabled = true;
            }
            else
            {
                update_logs("no workplace path set").Wait();
            }
            Cursor = Cursors.Default;
        }

        private void button_pakchunk_Click(object sender, EventArgs e)
        {
            search_pakchunk.ShowDialog();
            if (search_pakchunk.FileName.Length > 1)
            {
                button_pakchunk.Enabled = false;
                build_bypass.Enabled = true;
            }
            else
            {
                update_logs("no pakchunk path set").Wait();
            }
        }

        private Task build_bypass_file()
        {
            bool valid = false;
            update_status("pakchunk scanning").Wait();
            update_logs("----------------------------------------------------------").Wait();

            BinaryReader br = new BinaryReader(File.OpenRead(search_pakchunk.FileName));
            int start = Convert.ToInt32(magic, 16);
            int end = 0;
            byte current = 0;

            update_logs($"start address: {start} : 0x{start.ToString("X")}").Wait();

            for (int i = start; valid != true; i++)
            {
                br.BaseStream.Position = i;
                current = br.ReadByte();
                if (bhvr_config.Count > 3)
                {
                    if (bhvr_config[bhvr_config.Count - 1].ToString("X2") == "00" &&
                        bhvr_config[bhvr_config.Count - 2].ToString("X2") == "0A" &&
                        bhvr_config[bhvr_config.Count - 3].ToString("X2") == "0D")
                        valid = true;
                }
                if (valid != true)
                    bhvr_config.Add(current);
                if (valid == true)
                {
                    bhvr_config.RemoveAt(bhvr_config.Count - 1);
                    bhvr_config.RemoveAt(bhvr_config.Count - 2);
                    bhvr_config.RemoveAt(bhvr_config.Count - 3);
                }
                end = (i - 2);
            }
            br.Close();
            update_logs($"end address:  {end} : 0x{end.ToString("X")}").Wait();
            update_logs($"total bytes:  {bhvr_config.Count}").Wait();
            update_logs("----------------------------------------------------------").Wait();
            ids["start"] = start;
            ids["end"] = end;
            update_status("pakchunk scanned").Wait();

            return (Task.CompletedTask);
        }

        private Task dump_config()
        {
            update_logs("extracting").Wait();
            File.WriteAllText($"{load_template.SelectedPath}\\bhvr_config.ini", Encoding.Default.GetString(bhvr_config.ToArray()));
            update_logs("extracted").Wait();

            return (Task.CompletedTask);
        }

        private Task clean_config()
        {
            string[] data = File.ReadAllLines($"{load_template.SelectedPath}\\bhvr_config.ini");
            List<string> cleanned = new List<string>();

            update_logs("cleanning").Wait();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Length > 0)
                {
                    if (data[i][0] != ';')
                    {
                        cleanned.Add(data[i]);
                    }
                }
                else
                {
                    cleanned.Add(data[i]);
                }
            }
            File.WriteAllLines($"{load_template.SelectedPath}\\bhvr_cleanned.ini", cleanned);
            update_logs("cleanned").Wait();
            

            return (Task.CompletedTask);
        }

        private Task patch_config()
        {
            string[] patch = File.ReadAllLines($"{load_template.SelectedPath}\\patch");
            string[] config = File.ReadAllLines($"{load_template.SelectedPath}\\bhvr_cleanned.ini");
            List<string> full_patch = new List<string>();

            update_status("bhvr_config patching").Wait();

            update_logs("bhvr_config patching").Wait();
            update_logs("config adding").Wait();
            for (int i = 0; i < config.Length; i++)
            {
                full_patch.Add(config[i]);
            }
            update_logs("config added").Wait();
            update_logs("patch adding").Wait();
            for (int i = 0; i < patch.Length; i++)
            {
                full_patch.Add(patch[i]);
            }
            update_logs("patch added").Wait();
            update_logs("exporting").Wait();
            File.WriteAllLines($"{load_template.SelectedPath}\\bhvr_patch.ini", full_patch);
            update_status("bhvr_config patched").Wait();

            return (Task.CompletedTask);
        }

        private Task copy_pak()
        {
            update_logs("pakchunk copying").Wait();
            if (File.Exists($"{load_template.SelectedPath}\\pakchunk1-WindowsNoEditor.pak") == true)
                File.Delete($"{load_template.SelectedPath}\\pakchunk1-WindowsNoEditor.pak");
            File.Copy(search_pakchunk.FileName, $"{load_template.SelectedPath}\\pakchunk1-WindowsNoEditor.pak");
            update_logs("pakchunk copied").Wait();

            return (Task.CompletedTask);
        }

        private Task inject_bypass_file()
        {
            int index = ids["start"];
            int save = 0;
            byte[] patch = File.ReadAllBytes($"{load_template.SelectedPath}\\bhvr_patch.ini");
            BinaryWriter br = new BinaryWriter(File.OpenWrite($"{load_template.SelectedPath}\\pakchunk1-WindowsNoEditor.pak"));

            update_logs("----------------------------------------------------------").Wait();

            update_logs("pakchunk injecting").Wait();
            update_logs("pakchunk patch injecting").Wait();
            for (int i = 0; i < patch.Length; i++, index++)
            {
                br.BaseStream.Position = index;
                br.Write(patch[i]);
            }
            update_logs("pakchunk patch injected").Wait();
            update_logs("pakchunk cleanning").Wait();
            save = index;
            for (; index < ids["end"]; index++)
            {
                br.BaseStream.Position = index;
                br.Write(0x00);
            }
            update_logs("pakchunk cleanned").Wait();

            br.Close();

            update_logs("pakchunk injected").Wait();
            update_logs($"injected bytes: {patch.Length}").Wait();
            update_logs($"cleanned bytes: {ids["end"] - save}").Wait();
            update_logs("----------------------------------------------------------").Wait();

            return (Task.CompletedTask);
        }

        private void build_bypass_Click(object sender, EventArgs e)
        {
            button_load.Enabled = false;
            button_pakchunk.Enabled = false;
            build_bypass.Enabled = false;
            build_bypass_file().Wait();
            dump_config().Wait();
            clean_config().Wait();
            patch_config().Wait();
            copy_pak().Wait();
            inject_bypass_file().Wait();
            MessageBox.Show("SSL Bypass built successfully", "SSL Bypass: built", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button_load.Enabled = true;
            button_pakchunk.Enabled = true;
            build_bypass.Enabled = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
