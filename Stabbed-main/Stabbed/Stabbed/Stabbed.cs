using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;

namespace Stabbed
{
    public partial class Stabbed : KryptonForm
    {
        class Component
        {
            public string path = null;
            public List<string> content = null;
        }

        class Backup
        {
            DateTime today = DateTime.Today;
            public string name = $"engine_{DateTime.Now.ToString("yyyyMMddhhmmss")}.stb";
            public Component backup = new Component();

            public void back(List<string> content)
            {
                backup.content = content;
                backup.path = $"backups\\{name}";

                File.WriteAllLines(backup.path, backup.content);
            }
        }

        class Configuration
        {
            public string default_ouput = "generated\\Engine.ini";
            public string ouput = null;
            public Backup backup = new Backup();
            public List<string> patch = new List<string>();
            public Component engine = new Component();
            public Component bypass = new Component();
            public components.Manager manager = new components.Manager();
            public popup.ok patch_completed = new popup.ok("Patch completed", "Patch successfully added to your game");
            public popup.ok engine_not_found = new popup.ok("Fail to locate", "'Engine.ini' file is not found in your game folder");
            public popup.ok readonly_error = new popup.ok("Read Only Error", "Your configuration file is Read Only");
            public Dictionary<string, bool> requirements = new Dictionary<string, bool>()
            {
                { "platform", false },
                { "configurations", false }
            };
            public string version = "64";
            public string selected = null;
            public string local = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\DeadByDaylight\\Saved\\Config";
            public string engine_name = "Engine.ini";
        }

        private BackgroundWorker worker = new BackgroundWorker();
        private Configuration configuration = new Configuration();

        public Stabbed(List<string> list_configurations)
        {
            InitializeComponent();
            InitializeWorkers();

            load_items(combo_configurations, list_configurations);
        }

        private void load_items(ComboBox box, List<string> content)
        {
            foreach (string data in content)
            {
                box.Items.Add(data);
            }
        }

        private void InitializeWorkers()
        {
            worker.DoWork += new DoWorkEventHandler(patcher);
        }

        private void Stabbed_Load(object sender, EventArgs e)
        {
            if (Environment.Is64BitOperatingSystem == true)
            {
                picture_version.Image = Properties.Resources.x64_48px;
                configuration.version = "64";
            } else
            {
                picture_version.Image = Properties.Resources.x86_48px;
                configuration.version = "86";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_patch_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();

            while (worker.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void patcher(object sender, EventArgs e)
        {
            if (platform_check() == true)
            {
                configuration.engine.content = File.ReadAllLines(configuration.engine.path).ToList();
                configuration.bypass.content = File.ReadAllLines(configuration.bypass.path).ToList();
                configuration.backup.backup.content = configuration.engine.content;
                compare();
                dump();
                configuration.patch_completed.ShowDialog();
            }
        }

        private bool platform_check()
        {
            Dictionary<string, bool> status = new Dictionary<string, bool>()
            {
                { "Steam",  platform_steam() },
                { "Epic Games",  platform_epic() },
                { "Microsoft Store",  platform_microsoft() },
                { "Custom",  platform_custom() }
            };

            if (status.ContainsKey(configuration.selected) == true)
            {
                if (status[configuration.selected] == false)
                {
                    configuration.engine_not_found.ShowDialog();
                } else
                {
                    return (true);
                }
            }

            return (false);
        }

        private bool platform_steam()
        {
            return (update_engine($"{configuration.local}\\WindowsNoEditor\\{configuration.engine_name}"));
        }

        private bool platform_epic()
        {
            return (update_engine($"{configuration.local}\\EGS\\{configuration.engine_name}"));
        }

        private bool platform_microsoft()
        {
            return (update_engine($"{configuration.local}\\GRDKNoEditor\\{configuration.engine_name}"));
        }

        private bool platform_custom()
        {
            if (File.Exists(open_custom_path.FileName) == true)
            {
                configuration.engine.path = open_custom_path.FileName;
                return (true);
            }
            return (false);
        }

        private bool update_engine(string path)
        {
            if (File.Exists(path) == true)
            {
                configuration.engine.path = path;
                return (true);
            }
            return (false);
        }

        private void dump()
        {
            if (switch_backup.Checked == true)
            {
                configuration.backup.back(configuration.backup.backup.content);
            }
            if (switch_edit.Checked == true)
            {
                configuration.ouput = configuration.engine.path;
            } else
            {
                configuration.ouput = configuration.default_ouput;
            }

            File.WriteAllLines(configuration.ouput, configuration.patch);
        }

        private void compare()
        {
            foreach (string line in configuration.engine.content)
            {
                if (configuration.patch.Contains(line) == false)
                {
                    configuration.patch.Add(line);
                }
            }
            foreach (string line in configuration.bypass.content)
            {
                if (configuration.patch.Contains(line) == false)
                {
                    configuration.patch.Add(line);
                }
            }
        }

        private void switch_backup_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }

        private void update_patch_button()
        {
            int count = 0;

            foreach (KeyValuePair<string, bool> data in configuration.requirements)
            {
                if (data.Value == true)
                {
                    count++;
                }
            }
            if (count == configuration.requirements.Count)
                button_patch.Enabled = true;
            else
                button_patch.Enabled = false;
        }

        private void update_platform(string platform)
        {
            configuration.selected = platform;
            label_platform.Text = platform;
            configuration.requirements["platform"] = true;
            if (switch_platform.Checked == false)
            {
                switch_platform.Checked = true;
            }
            update_patch_button();
        }

        private void button_epic_Click(object sender, EventArgs e)
        {
            update_platform("Epic Games");
        }

        private void button_microsoft_Click(object sender, EventArgs e)
        {
            update_platform("Microsoft Store");
        }

        private void button_steam_Click(object sender, EventArgs e)
        {
            update_platform("Steam");
        }

        private int get_value_index(string[] list, string field)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == field)
                    return (i);
            }

            return (-1);
        }

        private bool folder_exists(string[] folder, string field)
        {
            if (get_value_index(folder, field) > -1)
            {
                return (true);
            }
            return (false);
        }

        private void combo_configurations_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_configurations.Items.Count > 0)
            {
                if (combo_configurations.SelectedItem != null)
                {
                    configuration.bypass.path = combo_configurations.SelectedItem.ToString();
                    configuration.requirements["configurations"] = true;
                } else
                {
                    configuration.requirements["configurations"] = false;
                }
            } else
            {
                configuration.requirements["configurations"] = false;
            }
            update_patch_button();
        }

        private void button_custom_Click(object sender, EventArgs e)
        {
            open_custom_path.ShowDialog();

            if (open_custom_path.FileName != "")
            {
                update_platform("Custom");
            }
        }

        private void switch_platform_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (switch_platform.Checked != configuration.requirements["platform"])
            {
                switch_platform.Checked = configuration.requirements["platform"];
            }
        }

        private void switch_platform_Click(object sender, EventArgs e)
        {
            return;
        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
