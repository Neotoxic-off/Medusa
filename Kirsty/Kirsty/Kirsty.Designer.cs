
namespace Kirsty
{
    partial class Kirsty
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kirsty));
            this.border = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.display_activate_market = new System.Windows.Forms.Label();
            this.activate_market = new System.Windows.Forms.Label();
            this.display_discord_rpc = new System.Windows.Forms.Label();
            this.discord_rpc = new System.Windows.Forms.Label();
            this.display_market_path = new System.Windows.Forms.Label();
            this.market_path = new System.Windows.Forms.Label();
            this.display_autorun_status = new System.Windows.Forms.Label();
            this.autorun_status = new System.Windows.Forms.Label();
            this.display_streammer_status = new System.Windows.Forms.Label();
            this.streammer_status = new System.Windows.Forms.Label();
            this.display_streammer_username = new System.Windows.Forms.Label();
            this.streammer_username = new System.Windows.Forms.Label();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.display_remove_penality = new System.Windows.Forms.Label();
            this.remove_penality = new System.Windows.Forms.Label();
            this.display_friend_tag = new System.Windows.Forms.Label();
            this.friend_tag = new System.Windows.Forms.Label();
            this.display_player_devotion = new System.Windows.Forms.Label();
            this.player_devotion = new System.Windows.Forms.Label();
            this.display_player_level = new System.Windows.Forms.Label();
            this.player_level = new System.Windows.Forms.Label();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folder_path = new System.Windows.Forms.OpenFileDialog();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.display_killer_rank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.display_queue_position = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.display_cookie_value = new System.Windows.Forms.Label();
            this.cookie_label = new System.Windows.Forms.Label();
            this.display_player_cells = new System.Windows.Forms.Label();
            this.player_cells = new System.Windows.Forms.Label();
            this.card_currencies = new Bunifu.Framework.UI.BunifuCards();
            this.display_player_bloodpoints = new System.Windows.Forms.Label();
            this.player_bloodpoints = new System.Windows.Forms.Label();
            this.display_player_shards = new System.Windows.Forms.Label();
            this.player_shards = new System.Windows.Forms.Label();
            this.card_level = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.display_pips_killers = new System.Windows.Forms.Label();
            this.pips_survivors = new System.Windows.Forms.Label();
            this.pips_killers = new System.Windows.Forms.Label();
            this.display_pips_survivors = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards5.SuspendLayout();
            this.bunifuCards6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            this.card_currencies.SuspendLayout();
            this.card_level.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.border.Controls.Add(this.panel1);
            this.border.Controls.Add(this.label2);
            this.border.Controls.Add(this.version);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(450, 30);
            this.border.TabIndex = 2;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.about);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 30);
            this.panel1.TabIndex = 12;
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about.BackgroundImage")));
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.about.Location = new System.Drawing.Point(38, 7);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(16, 16);
            this.about.TabIndex = 9;
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.exit.Location = new System.Drawing.Point(128, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 16);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.minimize.Location = new System.Drawing.Point(98, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(16, 16);
            this.minimize.TabIndex = 1;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "version:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.Color.DimGray;
            this.version.Location = new System.Drawing.Point(62, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(31, 13);
            this.version.TabIndex = 8;
            this.version.Text = "1.1.0";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Transparent;
            this.bunifuCards3.Controls.Add(this.stop);
            this.bunifuCards3.Controls.Add(this.start);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(15, 383);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(210, 53);
            this.bunifuCards3.TabIndex = 29;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.stop.Enabled = false;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.DimGray;
            this.stop.Location = new System.Drawing.Point(115, 16);
            this.stop.Margin = new System.Windows.Forms.Padding(20);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 19;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.DimGray;
            this.start.Location = new System.Drawing.Point(20, 16);
            this.start.Margin = new System.Windows.Forms.Padding(20);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 18;
            this.start.Text = "Run";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.display_activate_market);
            this.bunifuCards2.Controls.Add(this.activate_market);
            this.bunifuCards2.Controls.Add(this.display_discord_rpc);
            this.bunifuCards2.Controls.Add(this.discord_rpc);
            this.bunifuCards2.Controls.Add(this.display_market_path);
            this.bunifuCards2.Controls.Add(this.market_path);
            this.bunifuCards2.Controls.Add(this.display_autorun_status);
            this.bunifuCards2.Controls.Add(this.autorun_status);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 163);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(210, 82);
            this.bunifuCards2.TabIndex = 28;
            // 
            // display_activate_market
            // 
            this.display_activate_market.AutoSize = true;
            this.display_activate_market.ForeColor = System.Drawing.Color.HotPink;
            this.display_activate_market.Location = new System.Drawing.Point(98, 40);
            this.display_activate_market.Name = "display_activate_market";
            this.display_activate_market.Size = new System.Drawing.Size(29, 13);
            this.display_activate_market.TabIndex = 8;
            this.display_activate_market.Text = "false";
            this.display_activate_market.Click += new System.EventHandler(this.display_activate_market_Click);
            // 
            // activate_market
            // 
            this.activate_market.AutoSize = true;
            this.activate_market.Location = new System.Drawing.Point(7, 40);
            this.activate_market.Margin = new System.Windows.Forms.Padding(3);
            this.activate_market.Name = "activate_market";
            this.activate_market.Size = new System.Drawing.Size(85, 13);
            this.activate_market.TabIndex = 7;
            this.activate_market.Text = "Activate Market:";
            this.activate_market.Click += new System.EventHandler(this.activate_market_Click);
            // 
            // display_discord_rpc
            // 
            this.display_discord_rpc.AutoSize = true;
            this.display_discord_rpc.ForeColor = System.Drawing.Color.HotPink;
            this.display_discord_rpc.Location = new System.Drawing.Point(98, 55);
            this.display_discord_rpc.Name = "display_discord_rpc";
            this.display_discord_rpc.Size = new System.Drawing.Size(29, 13);
            this.display_discord_rpc.TabIndex = 6;
            this.display_discord_rpc.Text = "false";
            this.display_discord_rpc.Click += new System.EventHandler(this.display_discord_rpc_Click);
            // 
            // discord_rpc
            // 
            this.discord_rpc.AutoSize = true;
            this.discord_rpc.Location = new System.Drawing.Point(7, 55);
            this.discord_rpc.Margin = new System.Windows.Forms.Padding(3);
            this.discord_rpc.Name = "discord_rpc";
            this.discord_rpc.Size = new System.Drawing.Size(77, 13);
            this.discord_rpc.TabIndex = 5;
            this.discord_rpc.Text = "Discord status:";
            this.discord_rpc.Click += new System.EventHandler(this.discord_rpc_Click);
            // 
            // display_market_path
            // 
            this.display_market_path.ForeColor = System.Drawing.Color.HotPink;
            this.display_market_path.Location = new System.Drawing.Point(98, 25);
            this.display_market_path.Name = "display_market_path";
            this.display_market_path.Size = new System.Drawing.Size(102, 13);
            this.display_market_path.TabIndex = 4;
            this.display_market_path.Text = "unknown";
            this.display_market_path.Click += new System.EventHandler(this.display_market_path_Click);
            // 
            // market_path
            // 
            this.market_path.AutoSize = true;
            this.market_path.Location = new System.Drawing.Point(7, 25);
            this.market_path.Margin = new System.Windows.Forms.Padding(3);
            this.market_path.Name = "market_path";
            this.market_path.Size = new System.Drawing.Size(67, 13);
            this.market_path.TabIndex = 3;
            this.market_path.Text = "Market path:";
            this.market_path.Click += new System.EventHandler(this.market_path_Click);
            // 
            // display_autorun_status
            // 
            this.display_autorun_status.AutoSize = true;
            this.display_autorun_status.ForeColor = System.Drawing.Color.HotPink;
            this.display_autorun_status.Location = new System.Drawing.Point(98, 12);
            this.display_autorun_status.Name = "display_autorun_status";
            this.display_autorun_status.Size = new System.Drawing.Size(29, 13);
            this.display_autorun_status.TabIndex = 2;
            this.display_autorun_status.Text = "false";
            this.display_autorun_status.Click += new System.EventHandler(this.display_autorun_status_Click);
            // 
            // autorun_status
            // 
            this.autorun_status.AutoSize = true;
            this.autorun_status.Location = new System.Drawing.Point(7, 10);
            this.autorun_status.Margin = new System.Windows.Forms.Padding(3);
            this.autorun_status.Name = "autorun_status";
            this.autorun_status.Size = new System.Drawing.Size(47, 13);
            this.autorun_status.TabIndex = 1;
            this.autorun_status.Text = "Autorun:";
            this.autorun_status.Click += new System.EventHandler(this.autorun_status_Click);
            // 
            // display_streammer_status
            // 
            this.display_streammer_status.AutoSize = true;
            this.display_streammer_status.ForeColor = System.Drawing.Color.HotPink;
            this.display_streammer_status.Location = new System.Drawing.Point(99, 10);
            this.display_streammer_status.Margin = new System.Windows.Forms.Padding(10);
            this.display_streammer_status.Name = "display_streammer_status";
            this.display_streammer_status.Size = new System.Drawing.Size(29, 13);
            this.display_streammer_status.TabIndex = 6;
            this.display_streammer_status.Text = "false";
            this.display_streammer_status.Click += new System.EventHandler(this.display_streammer_status_Click);
            // 
            // streammer_status
            // 
            this.streammer_status.AutoSize = true;
            this.streammer_status.Location = new System.Drawing.Point(10, 10);
            this.streammer_status.Margin = new System.Windows.Forms.Padding(3);
            this.streammer_status.Name = "streammer_status";
            this.streammer_status.Size = new System.Drawing.Size(83, 13);
            this.streammer_status.TabIndex = 5;
            this.streammer_status.Text = "Streammer mod:";
            this.streammer_status.Click += new System.EventHandler(this.streammer_status_Click);
            // 
            // display_streammer_username
            // 
            this.display_streammer_username.ForeColor = System.Drawing.Color.HotPink;
            this.display_streammer_username.Location = new System.Drawing.Point(99, 25);
            this.display_streammer_username.Margin = new System.Windows.Forms.Padding(10);
            this.display_streammer_username.Name = "display_streammer_username";
            this.display_streammer_username.Size = new System.Drawing.Size(98, 13);
            this.display_streammer_username.TabIndex = 8;
            this.display_streammer_username.Text = "unknown";
            this.display_streammer_username.Click += new System.EventHandler(this.display_streammer_username_Click);
            // 
            // streammer_username
            // 
            this.streammer_username.AutoSize = true;
            this.streammer_username.Location = new System.Drawing.Point(10, 25);
            this.streammer_username.Margin = new System.Windows.Forms.Padding(3);
            this.streammer_username.Name = "streammer_username";
            this.streammer_username.Size = new System.Drawing.Size(58, 13);
            this.streammer_username.TabIndex = 7;
            this.streammer_username.Text = "Username:";
            this.streammer_username.Click += new System.EventHandler(this.streammer_username_Click);
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.Transparent;
            this.bunifuCards5.Controls.Add(this.display_remove_penality);
            this.bunifuCards5.Controls.Add(this.remove_penality);
            this.bunifuCards5.Controls.Add(this.display_friend_tag);
            this.bunifuCards5.Controls.Add(this.friend_tag);
            this.bunifuCards5.Controls.Add(this.display_streammer_username);
            this.bunifuCards5.Controls.Add(this.streammer_username);
            this.bunifuCards5.Controls.Add(this.display_streammer_status);
            this.bunifuCards5.Controls.Add(this.streammer_status);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(228, 163);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(210, 82);
            this.bunifuCards5.TabIndex = 29;
            // 
            // display_remove_penality
            // 
            this.display_remove_penality.AutoSize = true;
            this.display_remove_penality.ForeColor = System.Drawing.Color.HotPink;
            this.display_remove_penality.Location = new System.Drawing.Point(99, 55);
            this.display_remove_penality.Margin = new System.Windows.Forms.Padding(10);
            this.display_remove_penality.Name = "display_remove_penality";
            this.display_remove_penality.Size = new System.Drawing.Size(29, 13);
            this.display_remove_penality.TabIndex = 12;
            this.display_remove_penality.Text = "false";
            this.display_remove_penality.Click += new System.EventHandler(this.display_remove_penality_Click);
            // 
            // remove_penality
            // 
            this.remove_penality.AutoSize = true;
            this.remove_penality.Location = new System.Drawing.Point(10, 55);
            this.remove_penality.Margin = new System.Windows.Forms.Padding(3);
            this.remove_penality.Name = "remove_penality";
            this.remove_penality.Size = new System.Drawing.Size(89, 13);
            this.remove_penality.TabIndex = 11;
            this.remove_penality.Text = "Remove penality:";
            this.remove_penality.Click += new System.EventHandler(this.remove_penality_Click);
            // 
            // display_friend_tag
            // 
            this.display_friend_tag.ForeColor = System.Drawing.Color.HotPink;
            this.display_friend_tag.Location = new System.Drawing.Point(99, 40);
            this.display_friend_tag.Margin = new System.Windows.Forms.Padding(10);
            this.display_friend_tag.Name = "display_friend_tag";
            this.display_friend_tag.Size = new System.Drawing.Size(98, 13);
            this.display_friend_tag.TabIndex = 10;
            this.display_friend_tag.Text = "unknown";
            this.display_friend_tag.Click += new System.EventHandler(this.display_friend_tag_Click);
            // 
            // friend_tag
            // 
            this.friend_tag.AutoSize = true;
            this.friend_tag.Location = new System.Drawing.Point(10, 40);
            this.friend_tag.Margin = new System.Windows.Forms.Padding(3);
            this.friend_tag.Name = "friend_tag";
            this.friend_tag.Size = new System.Drawing.Size(57, 13);
            this.friend_tag.TabIndex = 9;
            this.friend_tag.Text = "Friend tag:";
            this.friend_tag.Click += new System.EventHandler(this.friend_tag_Click);
            // 
            // display_player_devotion
            // 
            this.display_player_devotion.ForeColor = System.Drawing.Color.HotPink;
            this.display_player_devotion.Location = new System.Drawing.Point(88, 25);
            this.display_player_devotion.Margin = new System.Windows.Forms.Padding(10);
            this.display_player_devotion.Name = "display_player_devotion";
            this.display_player_devotion.Size = new System.Drawing.Size(109, 13);
            this.display_player_devotion.TabIndex = 14;
            this.display_player_devotion.Text = "unknown";
            this.display_player_devotion.Click += new System.EventHandler(this.display_player_devotion_Click);
            // 
            // player_devotion
            // 
            this.player_devotion.AutoSize = true;
            this.player_devotion.Location = new System.Drawing.Point(12, 25);
            this.player_devotion.Margin = new System.Windows.Forms.Padding(3);
            this.player_devotion.Name = "player_devotion";
            this.player_devotion.Size = new System.Drawing.Size(53, 13);
            this.player_devotion.TabIndex = 13;
            this.player_devotion.Text = "Devotion:";
            this.player_devotion.Click += new System.EventHandler(this.player_devotion_Click);
            // 
            // display_player_level
            // 
            this.display_player_level.ForeColor = System.Drawing.Color.HotPink;
            this.display_player_level.Location = new System.Drawing.Point(88, 10);
            this.display_player_level.Margin = new System.Windows.Forms.Padding(10);
            this.display_player_level.Name = "display_player_level";
            this.display_player_level.Size = new System.Drawing.Size(109, 13);
            this.display_player_level.TabIndex = 12;
            this.display_player_level.Text = "unknown";
            this.display_player_level.Click += new System.EventHandler(this.display_player_level_Click);
            // 
            // player_level
            // 
            this.player_level.AutoSize = true;
            this.player_level.Location = new System.Drawing.Point(12, 10);
            this.player_level.Margin = new System.Windows.Forms.Padding(3);
            this.player_level.Name = "player_level";
            this.player_level.Size = new System.Drawing.Size(36, 13);
            this.player_level.TabIndex = 11;
            this.player_level.Text = "Level:";
            this.player_level.Click += new System.EventHandler(this.player_level_Click);
            // 
            // bunifuCards6
            // 
            this.bunifuCards6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards6.BorderRadius = 5;
            this.bunifuCards6.BottomSahddow = true;
            this.bunifuCards6.color = System.Drawing.Color.Transparent;
            this.bunifuCards6.Controls.Add(this.status);
            this.bunifuCards6.Controls.Add(this.label3);
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(12, 324);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(210, 34);
            this.bunifuCards6.TabIndex = 30;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.HotPink;
            this.status.Location = new System.Drawing.Point(53, 10);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(45, 13);
            this.status.TabIndex = 2;
            this.status.Text = "stopped";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(113, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 121);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // folder_path
            // 
            this.folder_path.Filter = "Market format(*.txt *.json)|*.txt;*.json";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.Transparent;
            this.bunifuCards4.Controls.Add(this.display_killer_rank);
            this.bunifuCards4.Controls.Add(this.label5);
            this.bunifuCards4.Controls.Add(this.display_queue_position);
            this.bunifuCards4.Controls.Add(this.label4);
            this.bunifuCards4.Controls.Add(this.display_cookie_value);
            this.bunifuCards4.Controls.Add(this.cookie_label);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(12, 251);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(210, 67);
            this.bunifuCards4.TabIndex = 31;
            // 
            // display_killer_rank
            // 
            this.display_killer_rank.ForeColor = System.Drawing.Color.HotPink;
            this.display_killer_rank.Location = new System.Drawing.Point(66, 40);
            this.display_killer_rank.Name = "display_killer_rank";
            this.display_killer_rank.Size = new System.Drawing.Size(134, 13);
            this.display_killer_rank.TabIndex = 6;
            this.display_killer_rank.Text = "not found";
            this.display_killer_rank.Click += new System.EventHandler(this.display_killer_rank_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Killer rank:";
            // 
            // display_queue_position
            // 
            this.display_queue_position.ForeColor = System.Drawing.Color.HotPink;
            this.display_queue_position.Location = new System.Drawing.Point(66, 25);
            this.display_queue_position.Name = "display_queue_position";
            this.display_queue_position.Size = new System.Drawing.Size(134, 13);
            this.display_queue_position.TabIndex = 4;
            this.display_queue_position.Text = "not found";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Queue:";
            // 
            // display_cookie_value
            // 
            this.display_cookie_value.ForeColor = System.Drawing.Color.HotPink;
            this.display_cookie_value.Location = new System.Drawing.Point(66, 10);
            this.display_cookie_value.Name = "display_cookie_value";
            this.display_cookie_value.Size = new System.Drawing.Size(134, 13);
            this.display_cookie_value.TabIndex = 2;
            this.display_cookie_value.Text = "not found";
            this.display_cookie_value.Click += new System.EventHandler(this.display_cookie_value_Click);
            // 
            // cookie_label
            // 
            this.cookie_label.AutoSize = true;
            this.cookie_label.Location = new System.Drawing.Point(7, 10);
            this.cookie_label.Margin = new System.Windows.Forms.Padding(3);
            this.cookie_label.Name = "cookie_label";
            this.cookie_label.Size = new System.Drawing.Size(43, 13);
            this.cookie_label.TabIndex = 1;
            this.cookie_label.Text = "Cookie:";
            this.cookie_label.Click += new System.EventHandler(this.cookie_label_Click);
            // 
            // display_player_cells
            // 
            this.display_player_cells.ForeColor = System.Drawing.Color.HotPink;
            this.display_player_cells.Location = new System.Drawing.Point(88, 10);
            this.display_player_cells.Margin = new System.Windows.Forms.Padding(10);
            this.display_player_cells.Name = "display_player_cells";
            this.display_player_cells.Size = new System.Drawing.Size(109, 13);
            this.display_player_cells.TabIndex = 16;
            this.display_player_cells.Text = "unknown";
            this.display_player_cells.Click += new System.EventHandler(this.display_player_cells_Click);
            // 
            // player_cells
            // 
            this.player_cells.AutoSize = true;
            this.player_cells.Location = new System.Drawing.Point(10, 10);
            this.player_cells.Margin = new System.Windows.Forms.Padding(3);
            this.player_cells.Name = "player_cells";
            this.player_cells.Size = new System.Drawing.Size(32, 13);
            this.player_cells.TabIndex = 15;
            this.player_cells.Text = "Cells:";
            this.player_cells.Click += new System.EventHandler(this.player_cells_Click);
            // 
            // card_currencies
            // 
            this.card_currencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.card_currencies.BorderRadius = 5;
            this.card_currencies.BottomSahddow = true;
            this.card_currencies.color = System.Drawing.Color.Transparent;
            this.card_currencies.Controls.Add(this.display_player_bloodpoints);
            this.card_currencies.Controls.Add(this.player_bloodpoints);
            this.card_currencies.Controls.Add(this.display_player_shards);
            this.card_currencies.Controls.Add(this.player_shards);
            this.card_currencies.Controls.Add(this.display_player_cells);
            this.card_currencies.Controls.Add(this.player_cells);
            this.card_currencies.LeftSahddow = false;
            this.card_currencies.Location = new System.Drawing.Point(228, 251);
            this.card_currencies.Name = "card_currencies";
            this.card_currencies.RightSahddow = true;
            this.card_currencies.ShadowDepth = 20;
            this.card_currencies.Size = new System.Drawing.Size(210, 67);
            this.card_currencies.TabIndex = 32;
            // 
            // display_player_bloodpoints
            // 
            this.display_player_bloodpoints.ForeColor = System.Drawing.Color.HotPink;
            this.display_player_bloodpoints.Location = new System.Drawing.Point(88, 40);
            this.display_player_bloodpoints.Margin = new System.Windows.Forms.Padding(10);
            this.display_player_bloodpoints.Name = "display_player_bloodpoints";
            this.display_player_bloodpoints.Size = new System.Drawing.Size(109, 13);
            this.display_player_bloodpoints.TabIndex = 20;
            this.display_player_bloodpoints.Text = "unknown";
            this.display_player_bloodpoints.Click += new System.EventHandler(this.display_player_bloodpoints_Click);
            // 
            // player_bloodpoints
            // 
            this.player_bloodpoints.AutoSize = true;
            this.player_bloodpoints.Location = new System.Drawing.Point(10, 40);
            this.player_bloodpoints.Margin = new System.Windows.Forms.Padding(3);
            this.player_bloodpoints.Name = "player_bloodpoints";
            this.player_bloodpoints.Size = new System.Drawing.Size(65, 13);
            this.player_bloodpoints.TabIndex = 19;
            this.player_bloodpoints.Text = "Bloodpoints:";
            this.player_bloodpoints.Click += new System.EventHandler(this.player_bloodpoints_Click);
            // 
            // display_player_shards
            // 
            this.display_player_shards.ForeColor = System.Drawing.Color.HotPink;
            this.display_player_shards.Location = new System.Drawing.Point(88, 25);
            this.display_player_shards.Margin = new System.Windows.Forms.Padding(10);
            this.display_player_shards.Name = "display_player_shards";
            this.display_player_shards.Size = new System.Drawing.Size(109, 13);
            this.display_player_shards.TabIndex = 18;
            this.display_player_shards.Text = "unknown";
            this.display_player_shards.Click += new System.EventHandler(this.display_player_shards_Click);
            // 
            // player_shards
            // 
            this.player_shards.AutoSize = true;
            this.player_shards.Location = new System.Drawing.Point(10, 25);
            this.player_shards.Margin = new System.Windows.Forms.Padding(3);
            this.player_shards.Name = "player_shards";
            this.player_shards.Size = new System.Drawing.Size(43, 13);
            this.player_shards.TabIndex = 17;
            this.player_shards.Text = "Shards:";
            this.player_shards.Click += new System.EventHandler(this.player_shards_Click);
            // 
            // card_level
            // 
            this.card_level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.card_level.BorderRadius = 5;
            this.card_level.BottomSahddow = true;
            this.card_level.color = System.Drawing.Color.Transparent;
            this.card_level.Controls.Add(this.display_player_devotion);
            this.card_level.Controls.Add(this.player_level);
            this.card_level.Controls.Add(this.player_devotion);
            this.card_level.Controls.Add(this.display_player_level);
            this.card_level.LeftSahddow = false;
            this.card_level.Location = new System.Drawing.Point(228, 324);
            this.card_level.Name = "card_level";
            this.card_level.RightSahddow = true;
            this.card_level.ShadowDepth = 20;
            this.card_level.Size = new System.Drawing.Size(210, 53);
            this.card_level.TabIndex = 33;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.display_pips_killers);
            this.bunifuCards1.Controls.Add(this.pips_survivors);
            this.bunifuCards1.Controls.Add(this.pips_killers);
            this.bunifuCards1.Controls.Add(this.display_pips_survivors);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(228, 383);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(210, 53);
            this.bunifuCards1.TabIndex = 34;
            // 
            // display_pips_killers
            // 
            this.display_pips_killers.ForeColor = System.Drawing.Color.HotPink;
            this.display_pips_killers.Location = new System.Drawing.Point(88, 25);
            this.display_pips_killers.Margin = new System.Windows.Forms.Padding(10);
            this.display_pips_killers.Name = "display_pips_killers";
            this.display_pips_killers.Size = new System.Drawing.Size(109, 13);
            this.display_pips_killers.TabIndex = 14;
            this.display_pips_killers.Text = "unknown";
            this.display_pips_killers.Click += new System.EventHandler(this.display_pips_killers_Click);
            // 
            // pips_survivors
            // 
            this.pips_survivors.AutoSize = true;
            this.pips_survivors.Location = new System.Drawing.Point(12, 10);
            this.pips_survivors.Margin = new System.Windows.Forms.Padding(3);
            this.pips_survivors.Name = "pips_survivors";
            this.pips_survivors.Size = new System.Drawing.Size(70, 13);
            this.pips_survivors.TabIndex = 11;
            this.pips_survivors.Text = "Pips survivor:";
            this.pips_survivors.Click += new System.EventHandler(this.pips_survivors_Click);
            // 
            // pips_killers
            // 
            this.pips_killers.AutoSize = true;
            this.pips_killers.Location = new System.Drawing.Point(12, 25);
            this.pips_killers.Margin = new System.Windows.Forms.Padding(3);
            this.pips_killers.Name = "pips_killers";
            this.pips_killers.Size = new System.Drawing.Size(59, 13);
            this.pips_killers.TabIndex = 13;
            this.pips_killers.Text = "Pips killers:";
            this.pips_killers.Click += new System.EventHandler(this.pips_killers_Click);
            // 
            // display_pips_survivors
            // 
            this.display_pips_survivors.ForeColor = System.Drawing.Color.HotPink;
            this.display_pips_survivors.Location = new System.Drawing.Point(88, 10);
            this.display_pips_survivors.Margin = new System.Windows.Forms.Padding(10);
            this.display_pips_survivors.Name = "display_pips_survivors";
            this.display_pips_survivors.Size = new System.Drawing.Size(109, 13);
            this.display_pips_survivors.TabIndex = 12;
            this.display_pips_survivors.Text = "unknown";
            this.display_pips_survivors.Click += new System.EventHandler(this.display_pips_survivors_Click);
            // 
            // Kirsty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(450, 454);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.card_level);
            this.Controls.Add(this.card_currencies);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCards6);
            this.Controls.Add(this.bunifuCards5);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kirsty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirsty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kirsty_FormClosing);
            this.Load += new System.EventHandler(this.Kirsty_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            this.bunifuCards6.ResumeLayout(false);
            this.bunifuCards6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.card_currencies.ResumeLayout(false);
            this.card_currencies.PerformLayout();
            this.card_level.ResumeLayout(false);
            this.card_level.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label version;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label autorun_status;
        private System.Windows.Forms.Label display_autorun_status;
        private System.Windows.Forms.Label display_market_path;
        private System.Windows.Forms.Label market_path;
        private System.Windows.Forms.Label display_streammer_status;
        private System.Windows.Forms.Label streammer_status;
        private System.Windows.Forms.Label display_streammer_username;
        private System.Windows.Forms.Label streammer_username;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog folder_path;
        private System.Windows.Forms.Label display_discord_rpc;
        private System.Windows.Forms.Label discord_rpc;
        private System.Windows.Forms.Label display_friend_tag;
        private System.Windows.Forms.Label friend_tag;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.Label display_cookie_value;
        private System.Windows.Forms.Label cookie_label;
        private System.Windows.Forms.Label display_queue_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label display_activate_market;
        private System.Windows.Forms.Label activate_market;
        private System.Windows.Forms.Label display_killer_rank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label display_player_level;
        private System.Windows.Forms.Label player_level;
        private System.Windows.Forms.Label display_player_devotion;
        private System.Windows.Forms.Label player_devotion;
        private System.Windows.Forms.Label display_player_cells;
        private System.Windows.Forms.Label player_cells;
        private Bunifu.Framework.UI.BunifuCards card_currencies;
        private System.Windows.Forms.Label display_player_bloodpoints;
        private System.Windows.Forms.Label player_bloodpoints;
        private System.Windows.Forms.Label display_player_shards;
        private System.Windows.Forms.Label player_shards;
        private Bunifu.Framework.UI.BunifuCards card_level;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label display_pips_killers;
        private System.Windows.Forms.Label pips_survivors;
        private System.Windows.Forms.Label pips_killers;
        private System.Windows.Forms.Label display_pips_survivors;
        private System.Windows.Forms.Label display_remove_penality;
        private System.Windows.Forms.Label remove_penality;
    }
}

