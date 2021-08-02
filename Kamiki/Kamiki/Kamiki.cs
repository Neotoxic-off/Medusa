using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;
using System.Media;

using PERKS;
using CHARACTERS;
using SAVEFILE;
using SETTINGS;
using CONFIGURATION;

namespace Kamiki
{
    public partial class Kamiki : Form
    {
        private WebClient downlaoder = new WebClient();
        private readonly Random generate = new Random();

        configuration _config_ = null;
        characters _char_ = null;

        settings.Rootobject _settings_ = null;
        configuration.Rootobject _configuration_ = null;
        characters.Rootobject _characters_ = null;
        savefile.Rootobject _save_ = null;

        SoundPlayer snd = null;

        private Items_editor editor;

        perks _perks_ = null;

        string version = null;
        string changelogs = null;

        int data = 0;

        int _killers_ = 0;
        int _survivors_ = 0;

        bool applied = false;

        bool first_click = false;

        public Kamiki()
        {
            InitializeComponent();
        }

        private Task play_sound(string file, bool theme = false)
        {
            if (sound.Checked == true)
            {
                snd = new SoundPlayer(file);
                if (theme == false)
                    snd.Play();
                else
                    snd.PlayLooping();
            }
            
            return (Task.CompletedTask);
        }

        private Task unlock(bool value)
        {
            player_settings.Enabled = value;
            savefile_settings.Enabled = value;
            edit_settings.Enabled = value;
            options_settings.Enabled = value;
            save_save.Enabled = value;
            save_save.Enabled = false;

            return (Task.CompletedTask);
        }

        private Task edit_items_R_S(int index)
        {
            int size = _save_.characterData[index].data.inventory.Length;
            string item = null;
            bool edited = false;

            for (int i = 0; i < size; i++)
            {
                item = _save_.characterData[index].data.inventory[i].i.Split(',')[0];

                // PERKS
                if (_perks_.GPS(item.ToLower()) == true && item.ToLower().Contains("teach") == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{generate.Next((int)perk_minimum.Value, (int)perk_maximum.Value)}";
                    edited = true;
                }

                if (_perks_.GPTS(item.ToLower()) == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                    edited = true;
                }

                if (_config_.GIS(item.ToLower(), _configuration_) == true)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{generate.Next((int)item_minimum.Value, (int)item_maximum.Value)}";
                    edited = true;
                }

                // OFERINGS
                if (_config_.GOS(item.ToLower(), _configuration_) == true)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{generate.Next((int)offering_minimum.Value, (int)offering_maximum.Value)}";
                    edited = true;
                }

                // OPTIMIZE SAVE
                if (options_optimize.Checked == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                }

                edited = false;
            }
            return (Task.CompletedTask);
        }

        private Task edit_items_R_K(int index)
        {
            int size = _save_.characterData[index].data.inventory.Length;
            string item = null;
            bool edited = false;

            for (int i = 0; i < size; i++)
            {
                item = _save_.characterData[index].data.inventory[i].i.Split(',')[0];

                // PERKS
                if (_perks_.GPK(item.ToLower()) == true && item.ToLower().Contains("teach") == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{generate.Next((int)perk_minimum.Value, (int)perk_maximum.Value)}";
                    edited = true;
                }

                if (_perks_.GPTK(item.ToLower()) == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                    edited = true;
                }

                // OFERINGS
                if (_config_.GOK(item.ToLower(), _configuration_) == true)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{generate.Next((int)offering_minimum.Value, (int)offering_maximum.Value)}";
                    edited = true;
                }

                // OPTIMIZE SAVE
                if (options_optimize.Checked == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                }

                edited = false;
            }
            return (Task.CompletedTask);
        }

        private Task edit_items_S(int index)
        {
            int size = _save_.characterData[index].data.inventory.Length;
            string item = null;
            bool only = false;
            bool edited = false;

            if (flash.Checked == true || medkit.Checked == true ||
                toolbox.Checked == true || firecracker.Checked == true ||
                key.Checked == true || map.Checked == true)
                only = true;

            for (int i = 0; i < size; i++)
            {
                item = _save_.characterData[index].data.inventory[i].i.Split(',')[0];
                
                // PERKS
                if (_perks_.GPS(item.ToLower()) == true && item.ToLower().Contains("teach") == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{surv_perks.Value}";
                    edited = true;
                }

                if (_perks_.GPTS(item.ToLower()) == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                    edited = true;
                }

                // OFERINGS
                if (_config_.GOS(item.ToLower(), _configuration_) == true)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{offerings_S.Value}";
                    edited = true;
                }

                // ITEMS
                if (item.ToLower().Contains("flashlight") == true && flash.Checked == true)
                {
                    if (_config_.GIS(item.ToLower(), _configuration_) == true || _config_.GAS(item.ToLower(), _configuration_) == true)
                    {
                        _save_.characterData[index].data.inventory[i].i = $"{item},{surv_amount.Value}";
                        edited = true;
                    }
                }

                if (item.ToLower().Contains("toolbox") == true && toolbox.Checked == true)
                {
                    if (_config_.GIS(item.ToLower(), _configuration_) == true || _config_.GAS(item.ToLower(), _configuration_) == true)
                    {
                        _save_.characterData[index].data.inventory[i].i = $"{item},{surv_amount.Value}";
                        edited = true;
                    }
                }

                if (item.ToLower().Contains("key") == true && key.Checked == true)
                {
                    if (_config_.GIS(item.ToLower(), _configuration_) == true || _config_.GAS(item.ToLower(), _configuration_) == true)
                    {
                        _save_.characterData[index].data.inventory[i].i = $"{item},{surv_amount.Value}";
                        edited = true;
                    }
                }

                if (item.ToLower().Contains("map") == true && map.Checked == true)
                {
                    if (_config_.GIS(item.ToLower(), _configuration_) == true || _config_.GAS(item.ToLower(), _configuration_) == true)
                    {
                        _save_.characterData[index].data.inventory[i].i = $"{item},{surv_amount.Value}";
                        edited = true;
                    }
                }

                if (item.ToLower().Contains("firecracker") == true && firecracker.Checked == true)
                {
                    if (_config_.GIS(item.ToLower(), _configuration_) == true || _config_.GAS(item.ToLower(), _configuration_) == true)
                    {
                        _save_.characterData[index].data.inventory[i].i = $"{item},{surv_amount.Value}";
                        edited = true;
                    }
                }

                if (item.ToLower().Contains("medkit") == true && medkit.Checked == true)
                {
                    if (_config_.GIS(item.ToLower(), _configuration_) == true || _config_.GAS(item.ToLower(), _configuration_) == true)
                    {
                        _save_.characterData[index].data.inventory[i].i = $"{item},{surv_amount.Value}";
                        edited = true;
                    }
                }

                if (only == false)
                {
                    if (_config_.GIS(item.ToLower(), _configuration_) == true)
                    {
                        _save_.characterData[index].data.inventory[i].i = $"{item},{surv_amount.Value}";
                        edited = true;
                    }
                }

                // OPTIMIZE SAVE
                if (options_optimize.Checked == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                }

                edited = false;
            }
            return (Task.CompletedTask);
        }
        
        private Task edit_items_K(int index)
        {
            int size = _save_.characterData[index].data.inventory.Length;
            string item = null;
            bool edited = false;

            for (int i = 0; i < size; i++)
            {
                item = _save_.characterData[index].data.inventory[i].i.Split(',')[0];

                // PERKS
                if (_perks_.GPK(item.ToLower()) == true && item.ToLower().Contains("teach") == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{kill_perks.Value}";
                    edited = true;
                }

                if (_perks_.GPTK(item.ToLower()) == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                    edited = true;
                }

                // ITEMS
                if (_config_.GAK(item.ToLower(), _configuration_) == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{kill_amount.Value}";
                    edited = true;
                }

                // OFERINGS
                if (_config_.GOK(item.ToLower(), _configuration_) == true)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},{offerings_K.Value}";
                    edited = true;
                }

                // OPTIMIZE SAVE
                if (options_optimize.Checked == true && edited == false)
                {
                    _save_.characterData[index].data.inventory[i].i = $"{item},1";
                }

                edited = false;
            }
            return (Task.CompletedTask);
        }

        private Task settings()
        {
            UID.Text = _save_.playerUId;
            matches.Value = _save_.cumulativeMatches;

            for (int i = 0; i < data; i++)
            {
                if (_char_.GNK($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                {
                    _killers_++;
                }

                if (_char_.GNS($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                {
                    _survivors_++;
                }
            }

            nb_surv.Text = $"{_survivors_}";
            nb_kill.Text = $"{_killers_}";

            return (Task.CompletedTask);
        }

        private Task player()
        {
            settings().Wait();

            return (Task.CompletedTask);
        }

        private Task survivors()
        {
            string result = null;

            for (int i = 0; i < data; i++)
            {
                result = _char_.GNS($"{_save_.characterData[i].key}", _characters_);
                if (result != "_NOTFOUND_")
                {
                    survivors_combo.Items.Add(result);
                }
            }

            survivors_combo.SelectedIndex = 0;

            return (Task.CompletedTask);
        }

        private Task killers()
        {
            string result = null;

            for (int i = 0; i < data; i++)
            {
                result = _char_.GNK($"{_save_.characterData[i].key}", _characters_);
                if (result != "_NOTFOUND_")
                {
                    killers_combo.Items.Add(result);
                }
            }

            killers_combo.SelectedIndex = 0;

            return (Task.CompletedTask);
        }

        private Task init()
        {
            _perks_ = new perks();
            _config_ = new configuration();
            _char_ = new characters();

            _killers_ = 0;
            _survivors_ = 0;

            if (survivors_combo.Items.Count > 0)
                survivors_combo.Items.Clear();
            if (killers_combo.Items.Count > 0)
                killers_combo.Items.Clear();
            data = _save_.characterData.Length;
            player().Wait();
            survivors().Wait();
            killers().Wait();

            return (Task.CompletedTask);
        }

        private void save_load_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            OpenFileDialog savefile_load = new OpenFileDialog
            {
                Title = "Savefile to edit",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Savefile (*.txt)|*.txt|All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (savefile_load.ShowDialog() == DialogResult.OK)
            {
                savefile_path.Text = crop(savefile_load.FileName);
                savefile_path.Refresh();
                try
                {
                    _save_ = JsonConvert.DeserializeObject<savefile.Rootobject>(
                        File.ReadAllText($"{savefile_load.FileName}")
                    );
                    init().Wait();
                    unlock(true).Wait();

                    survivors_box.Enabled = false;
                    killers_box.Enabled = false;

                    editor_box.Enabled = true;

                    background.BackColor = Color.FromArgb(75, 0, 0, 0);
                    MessageBox.Show("Savefile loaded");
                } catch
                {
                    MessageBox.Show("Your Savefile is corrupted or not in the correct format");
                }
            }

            Cursor = Cursors.Default;
        }

        private int count_char(string str, char c)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    count++;
            }

            return (count);
        }

        private string crop(string to_crop)
        {
            int count = count_char(to_crop, '\\');
            return ($"{to_crop.Split('\\')[count]}");
        }

        private Task load_configuration()
        {
            if (File.Exists("Settings\\Configuration.json"))
            {
                _configuration_ = JsonConvert.DeserializeObject<configuration.Rootobject>(File.ReadAllText("Settings\\Configuration.json"));
            }
            else
            {
                MessageBox.Show("'Settings\\Configuration.json' not found");
                Application.Exit();
            }

            return (Task.CompletedTask);
        }

        private Task load_characters()
        {
            if (File.Exists("Settings\\Characters.json"))
            {
                _characters_ = JsonConvert.DeserializeObject<characters.Rootobject>(File.ReadAllText("Settings\\Characters.json"));
            }
            else
            {
                MessageBox.Show("'Settings\\Characters.json' not found");
                Application.Exit();
            }

            return (Task.CompletedTask);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            _killers_ = 0;
            _survivors_ = 0;

            if (Directory.Exists("Settings"))
            {
                if (File.Exists("Settings\\Settings.json"))
                {
                    _settings_ = JsonConvert.DeserializeObject<settings.Rootobject>(File.ReadAllText("Settings\\Settings.json"));

                    background.BackColor = Color.FromArgb(200, 0, 0, 0);

                    if (Directory.Exists("Themes"))
                    {
                        string[] all_themes = Directory.GetFiles("Themes", "*.*", SearchOption.AllDirectories);

                        for (int i = 0; i < all_themes.Length; i++)
                        {
                            if (all_themes[i].EndsWith(".png") || all_themes[i].EndsWith(".jpg"))
                                theme.Items.Add(all_themes[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Directory 'Themes' not found");
                        Application.Exit();
                    }

                    if (Directory.Exists("Sounds"))
                    {
                        string[] sounds = Directory.GetFiles("Sounds", "*.wav", SearchOption.AllDirectories);

                        for (int i = 0; i < sounds.Length; i++)
                        {
                            sound_start.Items.Add(sounds[i]);
                            sound_save.Items.Add(sounds[i]);
                            sound_theme.Items.Add(sounds[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Directory 'Sounds' not found");
                        Application.Exit();
                    }

                    sound.Checked = _settings_.sound.enabled;
                    sound_start.SelectedItem = _settings_.sound.launch;
                    sound_save.SelectedItem = _settings_.sound.save;
                    sound_theme.SelectedItem = _settings_.sound.theme;
                    music_background.Checked = _settings_.sound.play_theme;

                    play_sound(_settings_.sound.launch).Wait();
                    if (music_background.Checked == true)
                        play_sound(_settings_.sound.theme, true).Wait();

                    if (theme.Items.Contains(_settings_.theme))
                    {
                        BackgroundImage = Image.FromFile(_settings_.theme);
                    }

                    theme.SelectedItem = _settings_.theme;

                    if (_settings_.update.check == true)
                    {
                        version = downlaoder.DownloadString("https://raw.githubusercontent.com/Neotoxic-off/SaveEditor/main/version.txt");

                        if (version.Contains(current_version.Text) == false)
                        {
                            MessageBox.Show("New Update available !");
                            Process.Start("https://discord.gg/QWSZmNq4YQ");
                            if (_settings_.update.display == true)
                            {
                                changelogs = downlaoder.DownloadString("https://raw.githubusercontent.com/Neotoxic-off/SaveEditor/main/changelog.txt");
                                MessageBox.Show(changelogs, "Changelog by Neo");
                            }
                        }
                    }
                    update.Checked = _settings_.update.check;
                    display.Checked = _settings_.update.display;

                    load_configuration().Wait();
                    load_characters().Wait();

                    unlock(false).Wait();
                }
                else
                {
                    MessageBox.Show("'Settings\\Settings.json' not found");
                    Application.Exit();
                }
            } else
            {
                MessageBox.Show("Directory 'Settings' not found");
                Application.Exit();
            }

            Cursor = Cursors.Default;
        }

        private void survivors_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = _char_.GIDS(survivors_combo.GetItemText(survivors_combo.SelectedItem), _characters_);
            int index = 0;

            for (; id == $"{_save_.characterData[index].key}" && index < data; index++);

            surv_level.Value = _save_.characterData[index].data.bloodWebLevel;
            surv_prestige.Value = _save_.characterData[index].data.prestigeLevel;
        }

        private void killers_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = _char_.GIDK(killers_combo.GetItemText(survivors_combo.SelectedItem), _characters_);
            int index = 0;

            for (; id == $"{_save_.characterData[index].key}" && index < data; index++);

            kill_level.Value = _save_.characterData[index].data.bloodWebLevel;
            kill_prestige.Value = _save_.characterData[index].data.prestigeLevel;
        }

        private void surv_level_ValueChanged(object sender, EventArgs e)
        {
            string id = _char_.GIDS(survivors_combo.GetItemText(survivors_combo.SelectedItem), _characters_);
            int index = 0;

            for (; id == $"{_save_.characterData[index].key}" && index < data; index++);

            _save_.characterData[index].data.bloodWebLevel = (int)surv_level.Value;

            if (apply_S.Checked)
                edit_surv().Wait();
        }

        private void surv_prestige_ValueChanged(object sender, EventArgs e)
        {
            string id = _char_.GIDS(survivors_combo.GetItemText(survivors_combo.SelectedItem), _characters_);
            int index = 0;

            for (; id == $"{_save_.characterData[index].key}" && index < data; index++);

            _save_.characterData[index].data.prestigeLevel = (int)surv_prestige.Value;

            if (apply_S.Checked)
                edit_surv().Wait();
        }

        private Task edit_surv()
        {
            for (int i = 0; i < data; i++)
            {
                if (_char_.GNS($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                {
                    _save_.characterData[i].data.bloodWebLevel = (int)surv_level.Value;
                    _save_.characterData[i].data.prestigeLevel = (int)surv_prestige.Value;
                }
            }

            return (Task.CompletedTask);
        }

        private Task edit_kill()
        {
            for (int i = 0; i < data; i++)
            {
                if (_char_.GNK($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                {
                    _save_.characterData[i].data.bloodWebLevel = (int)kill_level.Value;
                    _save_.characterData[i].data.prestigeLevel = (int)kill_prestige.Value;
                }
            }

            return (Task.CompletedTask);
        }

        private void kill_level_ValueChanged(object sender, EventArgs e)
        {
            string id = _char_.GIDK(killers_combo.GetItemText(killers_combo.SelectedItem), _characters_);
            int index = 0;

            for (; id == $"{_save_.characterData[index].key}" && index < data; index++);

            _save_.characterData[index].data.bloodWebLevel = (int)kill_level.Value;

            if (apply_K.Checked)
                edit_kill().Wait();
        }

        private void kill_prestige_ValueChanged(object sender, EventArgs e)
        {
            string id = _char_.GIDK(killers_combo.GetItemText(killers_combo.SelectedItem), _characters_);
            int index = 0;

            for (; id == $"{_save_.characterData[index].key}" && index < data; index++);

            _save_.characterData[index].data.prestigeLevel = (int)kill_prestige.Value;

            if (apply_K.Checked)
                edit_kill().Wait();
        }

        private void save_save_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            SaveFileDialog diag = new SaveFileDialog()
            {
                AutoUpgradeEnabled = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*",
                OverwritePrompt = false,
                Title = "Save savefile",
                RestoreDirectory = true
            };
            var res = diag.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(diag.FileName))
                        File.Delete(diag.FileName);
                    File.WriteAllText(diag.FileName, JsonConvert.SerializeObject(_save_));
                    play_sound(_settings_.sound.save).Wait();
                    MessageBox.Show("Savefile saved");
                } catch
                {
                    MessageBox.Show("Savefile failed to be saved");
                }
            }

            Cursor = Cursors.Default;
        }

        private void UID_TextChanged(object sender, EventArgs e)
        {
            _save_.playerUId = UID.Text;
        }

        private void matches_ValueChanged(object sender, EventArgs e)
        {
            _save_.cumulativeMatches = (int)matches.Value;
        }

        private void unlock_surv_Click(object sender, EventArgs e)
        {
            if (survivors_box.Enabled == true)
            {
                survivors_box.Enabled = false;
                unlock_surv.Text = "Unlock Survivors";
                unlock_surv.Refresh();
            } else if (survivors_box.Enabled == false)
            {
                survivors_box.Enabled = true;
                unlock_surv.Text = "Lock Survivors";
                unlock_surv.Refresh();
            }
        }

        private void unlock_kill_Click(object sender, EventArgs e)
        {
            if (killers_box.Enabled == true)
            {
                killers_box.Enabled = false;
                unlock_kill.Text = "Unlock Killers";
                unlock_kill.Refresh();
            } else if (killers_box.Enabled == false)
            {
                killers_box.Enabled = true;
                unlock_kill.Text = "Lock Killers";
                unlock_kill.Refresh();
            }
        }

        private void save_settings_Click(object sender, EventArgs e)
        {
            // THEME
            _settings_.theme = theme.GetItemText(theme.SelectedItem);

            // SOUNDS
            _settings_.sound.launch = sound_start.GetItemText(sound_start.SelectedItem);
            _settings_.sound.save = sound_save.GetItemText(sound_save.SelectedItem);
            _settings_.sound.theme = sound_theme.GetItemText(sound_theme.SelectedItem);
            _settings_.sound.enabled = sound.Checked;
            _settings_.sound.play_theme = music_background.Checked;

            try
            {
                if (File.Exists("Settings\\Settings.json"))
                    File.Delete("Settings\\Settings.json");
                File.WriteAllText("Settings\\Settings.json", JsonConvert.SerializeObject(_settings_));
                MessageBox.Show("Settings saved");
            }
            catch
            {
                MessageBox.Show("Settings failed to be saved");
            }
        }

        private void update_CheckedChanged(object sender, EventArgs e)
        {
            _settings_.update.check = update.Checked;
        }

        private void display_CheckedChanged(object sender, EventArgs e)
        {
            _settings_.update.display = display.Checked;
        }

        private void theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (theme.Items.Contains(theme.GetItemText(theme.SelectedItem)))
            {
                BackgroundImage = Image.FromFile(theme.GetItemText(theme.SelectedItem));
            } else
            {
                MessageBox.Show($"Can't find: {theme.GetItemText(theme.SelectedItem)}");
            }
        }

        private void sound_CheckedChanged(object sender, EventArgs e)
        {
            _settings_.sound.enabled = sound.Checked;
        }

        private void set_surv_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < data; i++)
            {
                if ($"{_save_.characterData[i].key}" == _char_.GIDS(survivors_combo.GetItemText(survivors_combo.SelectedItem), _characters_))
                {
                    _save_.characterData[i].data.bloodWebLevel = (int)surv_level.Value;
                    _save_.characterData[i].data.prestigeLevel = (int)surv_prestige.Value;
                    edit_items_S(i).Wait();
                    MessageBox.Show($"Survivor {survivors_combo.GetItemText(survivors_combo.SelectedItem)} edited");
                    Cursor = Cursors.Default;
                    return;
                }
            }
            MessageBox.Show($"Can't find {survivors_combo.GetItemText(survivors_combo.SelectedItem)}");
            Cursor = Cursors.Default;
        }

        private void set_kill_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            for (int i = 0; i < data; i++)
            {
                if ($"{_save_.characterData[i].key}" == _char_.GIDK(killers_combo.GetItemText(killers_combo.SelectedItem), _characters_))
                {
                    _save_.characterData[i].data.bloodWebLevel = (int)kill_level.Value;
                    _save_.characterData[i].data.prestigeLevel = (int)kill_prestige.Value;
                    edit_items_K(i).Wait();
                    MessageBox.Show($"Killer {killers_combo.GetItemText(killers_combo.SelectedItem)} edited");
                    Cursor = Cursors.Default;

                    return;
                }
            }
            MessageBox.Show($"Can't find {killers_combo.GetItemText(killers_combo.SelectedItem)}");

            Cursor = Cursors.Default;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (save_save.Enabled == false)
            {
                applied = true;
                save_save.Enabled = applied;
            }

            int offerings = (int)offerings_S.Value + (int)offerings_K.Value;
            int items_surv = (int)surv_amount.Value;
            int items_kill = (int)kill_amount.Value;

            int random_ite = (int)item_maximum.Value - (int)item_minimum.Value;
            int random_off = (int)offering_maximum.Value - (int)offering_minimum.Value;

            int total = offerings + items_surv + items_kill;

            if (random_check.Checked == true && options_optimize.Checked == false)
            {
                total += random_ite + random_off;
            }

            if (total >= 9999)
            {
                DialogResult force = MessageBox.Show("Injecting this amout of items may break your game.\n" +
                    "Try using optimisation option to optimize your savefile\n\n" +
                    "Do you want to continue and build the savefile ?", "Dead by Daylight may crash", MessageBoxButtons.YesNo);
                if (force == DialogResult.Yes)
                {
                    for (int i = 0; i < _save_.characterData.Length; i++)
                    {
                        if (random_check.Checked == true)
                        {
                            if (survivors_box.Enabled || killers_box.Enabled)
                            {
                                if (survivors_box.Enabled)
                                {
                                    if (apply_S.Checked == true)
                                        edit_surv().Wait();

                                    if (survivors_box.Enabled == true && _char_.GNS($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                        edit_items_R_S(i).Wait();
                                }

                                if (killers_box.Enabled)
                                {
                                    if (apply_K.Checked == true)
                                        edit_kill().Wait();

                                    if (killers_box.Enabled == true && _char_.GNS($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                        edit_items_R_K(i).Wait();
                                }
                            }
                            else
                            {
                                MessageBox.Show("You need to unlock at least one type of character to use randomize");
                                Cursor = Cursors.Default;
                                return;
                            }
                        }
                        else
                        {
                            if (apply_S.Checked == true)
                            {
                                edit_surv().Wait();

                                if (survivors_box.Enabled == true && _char_.GNS($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                    edit_items_S(i).Wait();
                            }
                            if (apply_K.Checked == true)
                            {
                                edit_kill().Wait();

                                if (killers_box.Enabled == true && _char_.GNK($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                    edit_items_K(i).Wait();
                            }
                        }
                    }
                    MessageBox.Show("Savefile edited");
                } else
                {
                    MessageBox.Show("Savefile not edited");
                }
            } else
            {
                for (int i = 0; i < _save_.characterData.Length; i++)
                {
                    if (random_check.Checked == true)
                    {
                        if (survivors_box.Enabled || killers_box.Enabled)
                        {
                            if (survivors_box.Enabled)
                            {
                                edit_surv().Wait();
                                if (survivors_box.Enabled == true && _char_.GNS($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                    edit_items_R_S(i).Wait();
                            }

                            if (killers_box.Enabled)
                            {
                                edit_kill().Wait();
                                if (killers_box.Enabled == true && _char_.GNK($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                    edit_items_R_K(i).Wait();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You need to unlock at least one type of character to use randomize");
                            Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else
                    {
                        if (apply_S.Checked == true)
                        {
                            edit_surv().Wait();
                            if (survivors_box.Enabled == true && _char_.GNS($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                edit_items_S(i).Wait();
                        }
                        if (apply_K.Checked == true)
                        {
                            edit_kill().Wait();
                            if (killers_box.Enabled == true && _char_.GNK($"{_save_.characterData[i].key}", _characters_) != "_NOTFOUND_")
                                edit_items_K(i).Wait();
                        }
                    }
                }
                MessageBox.Show("Savefile edited");
            }
            
            Cursor = Cursors.Default;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            set_kill.Enabled = !apply_K.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            set_surv.Enabled = !apply_S.Checked;
        }

        private void random_check_CheckedChanged(object sender, EventArgs e)
        {
            R_items.Enabled = random_check.Checked;
            R_perks.Enabled = random_check.Checked;
            R_offering.Enabled = random_check.Checked;
        }

        private void options_optimize_CheckedChanged(object sender, EventArgs e)
        {
            if (options_optimize.Checked == true && first_click == false)
            {
                MessageBox.Show("Using this option, unnecessary items, offerings and addons\n" +
                "will be purged so that only one of them remains");

                first_click = true;
            }
        }

        private void editor_launch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                editor = new Items_editor();
                Cursor = Cursors.Default;
                editor.ShowDialog();
                load_configuration().Wait();

                MessageBox.Show("Configuration updated");
            } catch
            {
                MessageBox.Show("Can't update the configuration");
            }
            editor.Close();
        }

        private void music_background_CheckedChanged(object sender, EventArgs e)
        {
            _settings_.sound.play_theme = music_background.Checked;
            if (music_background.Checked == false)
            {
                if (snd != null)
                    snd.Stop();
            }
            else
            {
                snd = new SoundPlayer(_settings_.sound.theme);
                snd.PlayLooping();
            }
        }
    }
}
