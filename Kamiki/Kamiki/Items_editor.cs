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

using SETTINGS;
using CONFIGURATION;

namespace Kamiki
{
    public partial class Items_editor : Form
    {
        settings.Rootobject _settings_ = null;
        configuration.Rootobject _configuration_ = null;

        string item = null;
        bool status = false;

        bool UIS_C = true;
        bool UAS_C = true;
        bool UOS_C = true;

        bool UAK_C = true;
        bool UOK_C = true;

        public Items_editor()
        {
            InitializeComponent();
        }

        private Task load_survivors()
        {
            for (int i = 0; i < _configuration_.SURVIVORS.ITEMS.Length; i++)
            {
                item = _configuration_.SURVIVORS.ITEMS[i].Split(',')[0];
                status = bool.Parse(_configuration_.SURVIVORS.ITEMS[i].Split(',')[1]);
                surv_items.Items.Add(item, status);
            }

            for (int i = 0; i < _configuration_.SURVIVORS.ADDONS.Length; i++)
            {
                item = _configuration_.SURVIVORS.ADDONS[i].Split(',')[0];
                status = bool.Parse(_configuration_.SURVIVORS.ADDONS[i].Split(',')[1]);
                surv_addons.Items.Add(item, status);
            }

            for (int i = 0; i < _configuration_.SURVIVORS.OFFERINGS.Length; i++)
            {
                item = _configuration_.SURVIVORS.OFFERINGS[i].Split(',')[0];
                status = bool.Parse(_configuration_.SURVIVORS.OFFERINGS[i].Split(',')[1]);
                surv_offerings.Items.Add(item, status);
            }

            return (Task.CompletedTask);
        }

        private Task load_killers()
        {
            for (int i = 0; i < _configuration_.KILLERS.ADDONS.Length; i++)
            {
                item = _configuration_.KILLERS.ADDONS[i].Split(',')[0];
                status = bool.Parse(_configuration_.KILLERS.ADDONS[i].Split(',')[1]);
                kill_addons.Items.Add(item, status);
            }

            for (int i = 0; i < _configuration_.KILLERS.OFFERINGS.Length; i++)
            {
                item = _configuration_.KILLERS.OFFERINGS[i].Split(',')[0];
                status = bool.Parse(_configuration_.KILLERS.OFFERINGS[i].Split(',')[1]);
                kill_offerings.Items.Add(item, status);
            }

            return (Task.CompletedTask);
        }

        private Task save_survivors()
        {
            for (int i = 0; i < surv_items.Items.Count; i++)
            {
                item = surv_items.GetItemText(surv_items.Items[i]);
                status = surv_items.GetItemChecked(i);
                _configuration_.SURVIVORS.ITEMS[i] = $"{item},{status}";
            }

            for (int i = 0; i < surv_addons.Items.Count; i++)
            {
                item = surv_addons.GetItemText(surv_addons.Items[i]);
                status = surv_addons.GetItemChecked(i);
                _configuration_.SURVIVORS.ADDONS[i] = $"{item},{status}";
            }

            for (int i = 0; i < surv_offerings.Items.Count; i++)
            {
                item = surv_offerings.GetItemText(surv_offerings.Items[i]);
                status = surv_offerings.GetItemChecked(i);
                _configuration_.SURVIVORS.OFFERINGS[i] = $"{item},{status}";
            }

            return (Task.CompletedTask);
        }

        private Task save_killers()
        {
            for (int i = 0; i < kill_addons.Items.Count; i++)
            {
                item = kill_addons.GetItemText(kill_addons.Items[i]);
                status = kill_addons.GetItemChecked(i);
                _configuration_.KILLERS.ADDONS[i] = $"{item},{status}";
            }

            for (int i = 0; i < kill_offerings.Items.Count; i++)
            {
                item = kill_offerings.GetItemText(kill_offerings.Items[i]);
                status = kill_offerings.GetItemChecked(i);
                _configuration_.KILLERS.OFFERINGS[i] = $"{item},{status}";
            }

            return (Task.CompletedTask);
        }

        private void Items_editor_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            _settings_ = JsonConvert.DeserializeObject<settings.Rootobject>(File.ReadAllText("Settings\\Settings.json"));
            _configuration_ = JsonConvert.DeserializeObject<configuration.Rootobject>(File.ReadAllText("Settings\\Configuration.json"));

            background.BackColor = Color.FromArgb(75, 0, 0, 0);

            if (Directory.Exists("Themes"))
            {
                BackgroundImage = Image.FromFile(_settings_.theme);
            }

            load_survivors().Wait();
            load_killers().Wait();

            Cursor = Cursors.Default;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            save_survivors().Wait();
            save_killers().Wait();

            try
            {
                if (File.Exists("Settings\\Configuration.json"))
                    File.Delete("Settings\\Configuration.json");
                File.WriteAllText("Settings\\Configuration.json", JsonConvert.SerializeObject(_configuration_));
                MessageBox.Show("Configuration saved");
            }
            catch
            {
                MessageBox.Show("Configuration failed to be saved");
            }

            Cursor = Cursors.Default;
        }

        private void UIS_Click(object sender, EventArgs e)
        {
            if (UIS_C == false)
            {
                UIS.Text = "Uncheck all Items";
            } else
            {
                UIS.Text = "Check all Items";
            }
            UIS.Refresh();

            for (int i = 0; i < surv_items.Items.Count; i++)
            {
                if (UIS_C == false)
                    surv_items.SetItemCheckState(i, CheckState.Checked);
                if (UIS_C == true)
                    surv_items.SetItemCheckState(i, CheckState.Unchecked);
            }
            UIS_C = !UIS_C;
        }

        private void UAS_Click(object sender, EventArgs e)
        {
            if (UAS_C == false)
            {
                UAS.Text = "Uncheck all Addons";
            }
            else
            {
                UAS.Text = "Check all Addons";
            }
            UAS.Refresh();

            for (int i = 0; i < surv_addons.Items.Count; i++)
            {
                if (UAS_C == false)
                    surv_addons.SetItemCheckState(i, CheckState.Checked);
                if (UAS_C == true)
                    surv_addons.SetItemCheckState(i, CheckState.Unchecked);
            }
            UAS_C = !UAS_C;
        }

        private void UOS_Click(object sender, EventArgs e)
        {
            if (UOS_C == false)
            {
                UOS.Text = "Uncheck all Offerings";
            }
            else
            {
                UOS.Text = "Check all Offerings";
            }
            UOS.Refresh();

            for (int i = 0; i < surv_offerings.Items.Count; i++)
            {
                if (UOS_C == false)
                    surv_offerings.SetItemCheckState(i, CheckState.Checked);
                if (UOS_C == true)
                    surv_offerings.SetItemCheckState(i, CheckState.Unchecked);
            }
            UOS_C = !UOS_C;
        }

        private void UAK_Click(object sender, EventArgs e)
        {
            if (UAK_C == false)
            {
                UAK.Text = "Uncheck all Addons";
            }
            else
            {
                UAK.Text = "Check all Addons";
            }
            UAK.Refresh();

            for (int i = 0; i < kill_addons.Items.Count; i++)
            {
                if (UAK_C == false)
                    kill_addons.SetItemCheckState(i, CheckState.Checked);
                if (UAK_C == true)
                    kill_addons.SetItemCheckState(i, CheckState.Unchecked);
            }
            UAK_C = !UAK_C;
        }

        private void UOK_Click(object sender, EventArgs e)
        {
            if (UOK_C == false)
            {
                UOK.Text = "Uncheck all Offerings";
            }
            else
            {
                UOK.Text = "Check all Offerings";
            }
            UOK.Refresh();

            for (int i = 0; i < kill_offerings.Items.Count; i++)
            {
                if (UOK_C == false)
                    kill_offerings.SetItemCheckState(i, CheckState.Checked);
                if (UOK_C == true)
                    kill_offerings.SetItemCheckState(i, CheckState.Unchecked);
            }
            UOK_C = !UOK_C;
        }
    }
}
