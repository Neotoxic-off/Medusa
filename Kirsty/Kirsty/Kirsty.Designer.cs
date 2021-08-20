
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
            this.label2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.display_market_path = new System.Windows.Forms.Label();
            this.market_path = new System.Windows.Forms.Label();
            this.display_autorun_status = new System.Windows.Forms.Label();
            this.autorun_status = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.display_streammer_status = new System.Windows.Forms.Label();
            this.streammer_status = new System.Windows.Forms.Label();
            this.display_streammer_username = new System.Windows.Forms.Label();
            this.streammer_username = new System.Windows.Forms.Label();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.display_cookie_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.folder_path = new System.Windows.Forms.OpenFileDialog();
            this.cookie = new System.Windows.Forms.TextBox();
            this.border.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards5.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
            this.bunifuCards6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.version.Text = "1.0.0";
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
            this.bunifuCards3.Location = new System.Drawing.Point(120, 372);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(210, 59);
            this.bunifuCards3.TabIndex = 29;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.stop.Enabled = false;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.DimGray;
            this.stop.Location = new System.Drawing.Point(115, 20);
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
            this.start.Location = new System.Drawing.Point(20, 20);
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
            this.bunifuCards2.Controls.Add(this.display_market_path);
            this.bunifuCards2.Controls.Add(this.market_path);
            this.bunifuCards2.Controls.Add(this.display_autorun_status);
            this.bunifuCards2.Controls.Add(this.autorun_status);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 163);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(210, 48);
            this.bunifuCards2.TabIndex = 28;
            // 
            // display_market_path
            // 
            this.display_market_path.ForeColor = System.Drawing.Color.HotPink;
            this.display_market_path.Location = new System.Drawing.Point(80, 25);
            this.display_market_path.Name = "display_market_path";
            this.display_market_path.Size = new System.Drawing.Size(123, 13);
            this.display_market_path.TabIndex = 4;
            this.display_market_path.Text = "unknown";
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
            this.display_autorun_status.Location = new System.Drawing.Point(60, 10);
            this.display_autorun_status.Name = "display_autorun_status";
            this.display_autorun_status.Size = new System.Drawing.Size(29, 13);
            this.display_autorun_status.TabIndex = 2;
            this.display_autorun_status.Text = "false";
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
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.cookie);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 257);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(426, 83);
            this.bunifuCards1.TabIndex = 29;
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
            this.display_streammer_username.Location = new System.Drawing.Point(77, 25);
            this.display_streammer_username.Margin = new System.Windows.Forms.Padding(10);
            this.display_streammer_username.Name = "display_streammer_username";
            this.display_streammer_username.Size = new System.Drawing.Size(123, 13);
            this.display_streammer_username.TabIndex = 8;
            this.display_streammer_username.Text = "unknown";
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
            this.bunifuCards5.Controls.Add(this.display_streammer_username);
            this.bunifuCards5.Controls.Add(this.streammer_username);
            this.bunifuCards5.Controls.Add(this.display_streammer_status);
            this.bunifuCards5.Controls.Add(this.streammer_status);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(228, 163);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(210, 48);
            this.bunifuCards5.TabIndex = 29;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.Transparent;
            this.bunifuCards4.Controls.Add(this.display_cookie_status);
            this.bunifuCards4.Controls.Add(this.label5);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(228, 217);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(210, 34);
            this.bunifuCards4.TabIndex = 29;
            // 
            // display_cookie_status
            // 
            this.display_cookie_status.AutoSize = true;
            this.display_cookie_status.ForeColor = System.Drawing.Color.HotPink;
            this.display_cookie_status.Location = new System.Drawing.Point(56, 10);
            this.display_cookie_status.Name = "display_cookie_status";
            this.display_cookie_status.Size = new System.Drawing.Size(29, 13);
            this.display_cookie_status.TabIndex = 2;
            this.display_cookie_status.Text = "false";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cookie:";
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
            this.bunifuCards6.Location = new System.Drawing.Point(12, 217);
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
            // folder_path
            // 
            this.folder_path.Filter = "Market format(*.txt *.json)|*.txt;*.json";
            // 
            // cookie
            // 
            this.cookie.Location = new System.Drawing.Point(17, 17);
            this.cookie.Margin = new System.Windows.Forms.Padding(20);
            this.cookie.Multiline = true;
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(389, 46);
            this.cookie.TabIndex = 32;
            // 
            // Kirsty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCards6);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.bunifuCards5);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kirsty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirsty";
            this.Load += new System.EventHandler(this.Kirsty_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.bunifuCards6.ResumeLayout(false);
            this.bunifuCards6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label display_market_path;
        private System.Windows.Forms.Label market_path;
        private System.Windows.Forms.Label display_streammer_status;
        private System.Windows.Forms.Label streammer_status;
        private System.Windows.Forms.Label display_streammer_username;
        private System.Windows.Forms.Label streammer_username;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.Label display_cookie_status;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog folder_path;
        private System.Windows.Forms.TextBox cookie;
    }
}

