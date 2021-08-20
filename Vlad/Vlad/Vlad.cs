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

namespace Vlad
{
    public partial class Vlad : Form
    {
        bool mouse_down = false;
        private Point offset;

        Dictionary<string, int> ids = new Dictionary<string, int>();

        classes.Savefile.Rootobject savefile = null;
        classes.Configuration configuration = new classes.Configuration();
        classes.Characters.Rootobject characters = new classes.Characters.Rootobject();
        classes.Settings.Rootobject settings = null;
        classes.Perks.Rootobject perks = new classes.Perks.Rootobject();
        OpenFileDialog save_path = new OpenFileDialog();

        public Vlad()
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
            string data = "Hi i'm Neo, all my cheats are free, so if you bought this one or another one made by me, you got scammed, please report the scammer on discord, and download all my tools for free on the discord, thanks\n\nHave a nice day";

            BOX(data, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult BOX(string content, string title, MessageBoxButtons button, MessageBoxIcon messageBoxIcon)
        {
            return (MessageBox.Show(content, title, button, messageBoxIcon));
        }

        private Task update(string value, Color color)
        {
            status.Text = value;
            status.ForeColor = color;

            return (Task.CompletedTask);
        }

        public bool is_survivor(int key)
        {
            for (int i = 0; i < characters.survivors.Count; i++)
                if (characters.survivors[i].id == key)
                    return (true);

            return (false);
        }

        public string get_survivor(int key)
        {
            for (int i = 0; i < characters.survivors.Count; i++)
                if (characters.survivors[i].id == key)
                    return (characters.survivors[i].name);

            return (null);
        }

        public bool is_killer(int key)
        {
            for (int i = 0; i < characters.killers.Count; i++)
                if (characters.killers[i].id == key)
                    return (true);

            return (false);
        }

        public string get_killer(int key)
        {
            for (int i = 0; i < characters.killers.Count; i++)
                if (characters.killers[i].id == key)
                    return (characters.killers[i].name);

            return (null);
        }

        private void Vlad_Load(object sender, EventArgs e)
        {
            save_path.FileName = null;
            save_path.RestoreDirectory = true;
            save_path.FilterIndex = 2;
            save_path.Filter = "Savefile formats (*.txt *.json)|*.txt;*.json";

            check_resources().Wait();
            load_resources().Wait();
            load_version_settings().Wait();
        }

        private Task load_version_settings()
        {
            if (Directory.Exists($"{configuration.env("resources")}") == true)
            {
                try
                {
                    settings = JsonConvert.DeserializeObject<classes.Settings.Rootobject>(
                        File.ReadAllText($"{configuration.env("resources")}\\{configuration.env("settings")}")
                    );

                    /*
                     * NO SUPPORT
                    support.Text = settings.support;
                    updater.Text = settings.updater;
                    */
                    support.Text = "5.1.1";
                    updater.Text = "Neo";
                }
                catch (Exception ex)
                {
                    BOX($"Settings fail to load, wrong format:\n\n{ex}", "Error: Settings wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                BOX($"Resources folder not found: {configuration.env("resources")}", "Error: resources", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            return (Task.CompletedTask);
        }

        private Task load_settings()
        {
            purge().Wait();
            savefile.playerUId = "Edited with Vlad";
            load_ui_characters().Wait();
            if (survivors_list.Items.Count > 0)
                survivors_list.SelectedIndex = 0;
            if (killers_list.Items.Count > 0)
                killers_list.SelectedIndex = 0;
            write.Enabled = true;

            return (Task.CompletedTask);
        }

        private Task check_resources()
        {
            string path = null;
            List<string> requirements = new List<string>(){
                "characters",
                "perks",
            };

            if (Directory.Exists($"{configuration.env("resources")}") == true)
            {
                for (int i = 0; i < requirements.Count; i++)
                {
                    path = $"{configuration.env("resources")}\\{configuration.env(requirements[i])}";
                    if (File.Exists(path) == false)
                    {
                        BOX($"Resources content not found: {path}", "Error: resources content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
            else
            {
                BOX($"Resources folder not found: {configuration.env("resources")}", "Error: resources", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            return (Task.CompletedTask);
        }

        private Task load_characters()
        {
            update("loading characters", Color.Cyan).Wait();
            try
            {
                characters = JsonConvert.DeserializeObject<classes.Characters.Rootobject>(
                    File.ReadAllText($"{configuration.env("resources")}\\{configuration.env("characters")}")
                );
            }
            catch (Exception ex)
            {
                BOX($"Characters fail to load, wrong format:\n\n{ex}", "Error: Characters wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            update("characters loaded", Color.LimeGreen).Wait();

            return (Task.CompletedTask);
        }

        private Task load_perks()
        {
            update("loading perks", Color.Cyan).Wait();
            try
            {
                perks = JsonConvert.DeserializeObject<classes.Perks.Rootobject>(
                    File.ReadAllText($"{configuration.env("resources")}\\{configuration.env("perks")}")
                );
            }
            catch (Exception ex)
            {
                BOX($"Perks fail to load, wrong format:\n\n{ex}", "Error: Perks wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            update("perks loaded", Color.LimeGreen).Wait();

            return (Task.CompletedTask);
        }

        private Task load_resources()
        {
            update("loading resources", Color.Cyan).Wait();
            load_characters().Wait();
            load_perks().Wait();
            update("resources loaded", Color.LimeGreen).Wait();

            return (Task.CompletedTask);
        }

        private ListViewItem load_item(string key, string value)
        {
            ListViewItem item = new ListViewItem($"{key}");
            item.SubItems.Add($"{value}");

            return (item);
        }

        private Task load_inventory(ListView list, int index)
        {
            List<string> format = new List<string>();
            List<classes.Savefile.Inventory> data = savefile.characterData[index].data.inventory;
            string item = null;
            string amount = null;
            string[] splitted = null;
            string report = "\n";
            int bad = 0;

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].i.Contains(',') == true)
                {
                    splitted = data[i].i.Split(',');
                    item = splitted[0];
                    amount = splitted[1];
                    list.Items.Add(load_item($"{item}", $"{amount}"));
                } else
                {
                    format.Add(data[i].i);
                    bad++;
                }
            }
            if (bad > 0)
            {
                for (int i = 0; i < bad; i++)
                {
                    report += $"{format[i]}\n";
                }
                BOX($"Wrong items format:\n{report}", "Unknown items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (Task.CompletedTask);
        }

        private Task load_prestige(ListView list, int index)
        {
            list.Items.Add(load_item("prestige", $"{savefile.characterData[index].data.prestigeLevel}"));

            return (Task.CompletedTask);
        }

        private Task load_prestige_dates(ListView list, int index)
        {
            for (int i = 0; i < savefile.characterData[index].data.prestigeDates.Count; i++)
            {
                list.Items.Add(load_item($"prestige {i + 1}", $"{savefile.characterData[index].data.prestigeDates[i]}"));
            }

            return (Task.CompletedTask);
        }

        private Task load_level(ListView list, int index)
        {
            list.Items.Add(load_item("level", $"{savefile.characterData[index].data.bloodWebLevel}"));

            return (Task.CompletedTask);
        }

        private string get_item(ListView list, string value)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Text == value)
                {
                    return (list.Items[i].SubItems[1].Text);
                }
            }

            return (null);
        }

        private Task save_inventory(ListView list, int index)
        {
            string item = null;
            string amount = null;
            string new_amount = null;
            string[] splitted = null;
            List<string> format = new List<string>();

            for (int i = 0; i < savefile.characterData[index].data.inventory.Count; i++)
            {
                if (savefile.characterData[index].data.inventory[i].i.Contains(',') == true)
                {
                    splitted = savefile.characterData[index].data.inventory[i].i.Split(',');
                    item = splitted[0];
                    amount = splitted[1];
                    new_amount = get_item(list, item);
                    if (new_amount != null)
                    {
                        savefile.characterData[index].data.inventory[i].i = $"{item},{new_amount}";
                    }
                }
                else
                {
                    format.Add(savefile.characterData[index].data.inventory[i].i);
                }
            }

            if (format.Count > 0)
            {
                BOX($"Some items are at the wrong format: {format.Count} items", "Error: Items format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return (Task.CompletedTask);
        }

        private Task save_prestige(ListView list, int index)
        {
            savefile.characterData[index].data.prestigeLevel = Int32.Parse(
                get_item(list, "prestige")
            );

            return (Task.CompletedTask);
        }

        private Task save_prestige_dates(ListView list, int index)
        {
            string item = null;
            List<string> data = new List<string>();

            for (int i = 0; i < savefile.characterData[index].data.prestigeLevel; i++)
            {
                item = get_item(list, $"prestige {i + 1}");
                if (item != null)
                    data.Add(item);
            }

            savefile.characterData[index].data.prestigeDates = data;

            return (Task.CompletedTask);
        }

        private Task save_level(ListView list, int index)
        {
            savefile.characterData[index].data.bloodWebLevel = Int32.Parse(
                get_item(list, "level")
            );

            return (Task.CompletedTask);
        }

        private Task load_all_inventory(ListView list, int index)
        {
            list.Items.Clear();

            load_level(list, index).Wait();
            load_prestige(list, index).Wait();
            load_prestige_dates(list, index).Wait();
            load_inventory(list, index).Wait();

            return (Task.CompletedTask);
        }

        private Task load_editor_survivor()
        {
            int key = 0;

            for (int i = 0; i < savefile.characterData.Count; i++)
            {
                key = savefile.characterData[i].key;

                if (survivors_list.SelectedItem.ToString() == get_survivor(key))
                {
                    load_all_inventory(survivors_items, i);
                }
            }

            return (Task.CompletedTask);
        }

        private Task save_all_inventory(ListView list, int index)
        {
            save_level(list, index).Wait();
            save_prestige(list, index).Wait();
            save_prestige_dates(list, index).Wait();
            save_inventory(list, index).Wait();

            return (Task.CompletedTask);
        }

        private Task save_editor_survivor()
        {
            int key = 0;

            for (int i = 0; i < savefile.characterData.Count; i++)
            {
                key = savefile.characterData[i].key;

                if (survivors_list.SelectedItem.ToString() == get_survivor(key))
                {
                    save_all_inventory(survivors_items, i);
                }
            }

            return (Task.CompletedTask);
        }

        private Task save_editor_killer()
        {
            int key = 0;

            for (int i = 0; i < savefile.characterData.Count; i++)
            {
                key = savefile.characterData[i].key;

                if (killers_list.SelectedItem.ToString() == get_killer(key))
                {
                    save_all_inventory(killers_items, i);
                }
            }

            return (Task.CompletedTask);
        }

        private Task load_editor_killer()
        {
            int key = 0;

            for (int i = 0; i < savefile.characterData.Count; i++)
            {
                key = savefile.characterData[i].key;

                if (killers_list.SelectedItem.ToString() == get_killer(key))
                {
                    load_all_inventory(killers_items, i);
                }
            }

            return (Task.CompletedTask);
        }

        private Task load_editor_add_survivor(int key)
        {
            survivors_list.Items.Add(get_survivor(key));

            return (Task.CompletedTask);
        }

        private Task load_editor_add_killer(int key)
        {
            killers_list.Items.Add(get_killer(key));

            return (Task.CompletedTask);
        }

        private Task load_ui_characters()
        {
            int key = 0;
            List<int> unknown = new List<int>();
            int unknown_count = 0;
            string result = "\n";

            for (int i = 0; i < savefile.characterData.Count; i++)
            {
                key = savefile.characterData[i].key;

                if (is_survivor(key) == true)
                {
                    load_editor_add_survivor(key).Wait();
                }
                else if (is_killer(key) == true)
                {
                    load_editor_add_killer(key).Wait();
                }
                else
                {
                    unknown.Add(key);
                    unknown_count++;
                }
            }

            if (unknown_count > 0)
            {
                for (int i = 0; i < unknown_count; i++)
                {
                    result += $"{unknown[i]}\n";
                }
                BOX($"Unknown characters:\n{result}\nMake sure that current Vlad version is the lastest", "Unknown characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (Task.CompletedTask);
        }

        private Task purge()
        {
            survivors_list.Items.Clear();
            killers_list.Items.Clear();

            return (Task.CompletedTask);
        }

        private Task brain()
        {
            save_path.ShowDialog();
            if (save_path.FileName != null)
            {
                if (File.Exists(save_path.FileName) == true)
                {
                    try
                    {
                        savefile = JsonConvert.DeserializeObject<classes.Savefile.Rootobject>(File.ReadAllText(save_path.FileName));
                        if (savefile != null)
                        {
                            update("savefile loaded", Color.LimeGreen).Wait();
                            BOX("Savefile loaded", "Savefile successfully loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_settings().Wait();
                        }
                        else
                        {
                            update("savefile not loaded", Color.Red).Wait();
                            BOX("Savefile not loaded", "Savefile not loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        update("savefile fail to load, wrong format", Color.Pink).Wait();
                        BOX($"Savefile fail to load, wrong format:\n\n{ex}", "Error: Savefile wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    BOX("Savefile not found", "Error: Savefile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return (Task.CompletedTask);
        }

        private void load_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            brain().Wait();

            Cursor = Cursors.Default;
        }

        private void survivors_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            load_editor_survivor().Wait();
            Cursor = Cursors.Default;
        }

        private void killers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            load_editor_killer().Wait();
            Cursor = Cursors.Default;
        }

        private void write_Click(object sender, EventArgs e)
        {
            string output = $"Extracted\\vlad.{save_path.FileName.Split('\\')[save_path.FileName.Split('\\').Length - 1]}";

            Cursor = Cursors.WaitCursor;
            if (Directory.Exists("Exctracted") == false)
                Directory.CreateDirectory("Extracted");
            if (File.Exists(output) == true)
                File.Delete(output);
            File.WriteAllText(output, JsonConvert.SerializeObject(savefile));
            BOX($"Savefile extracted: {output}", "Savefile extracted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor = Cursors.Default;
        }

        private void survivors_items_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (survivors_items.SelectedItems.Count > 0)
            {
                form.edit edit = new form.edit($"{survivors_items.SelectedItems[0].SubItems[0].Text}", $"{survivors_items.SelectedItems[0].SubItems[1].Text}");
                edit.ShowDialog();
                survivors_items.SelectedItems[0].SubItems[1].Text = edit.get_data();
                save_editor_survivor().Wait();
            }
        }

        private void killers_items_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (killers_items.SelectedItems.Count > 0)
            {
                form.edit edit = new form.edit($"{killers_items.SelectedItems[0].SubItems[0].Text}", $"{killers_items.SelectedItems[0].SubItems[1].Text}");
                edit.ShowDialog();
                killers_items.SelectedItems[0].SubItems[1].Text = edit.get_data();
                save_editor_killer().Wait();
            }
        }
    }
}
