
namespace Nysa
{
    partial class Nysa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nysa));
            this.border = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.tools = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.download = new System.Windows.Forms.Button();
            this.uncheck = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.check_update = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.dump = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.theme = new System.Windows.Forms.Button();
            this.border.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.border.Controls.Add(this.browse);
            this.border.Controls.Add(this.about);
            this.border.Controls.Add(this.label2);
            this.border.Controls.Add(this.version);
            this.border.Controls.Add(this.minimize);
            this.border.Controls.Add(this.exit);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(640, 30);
            this.border.TabIndex = 0;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
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
            this.about.Location = new System.Drawing.Point(498, 7);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(16, 16);
            this.about.TabIndex = 9;
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "version:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(62, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(57, 13);
            this.version.TabIndex = 8;
            this.version.Text = "not loaded";
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
            this.minimize.Location = new System.Drawing.Point(582, 7);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(16, 16);
            this.minimize.TabIndex = 1;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
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
            this.exit.Location = new System.Drawing.Point(612, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 16);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tools.ForeColor = System.Drawing.Color.DarkGray;
            this.tools.FormattingEnabled = true;
            this.tools.Location = new System.Drawing.Point(6, 14);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(538, 195);
            this.tools.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tools);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Location = new System.Drawing.Point(459, 13);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 3;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // uncheck
            // 
            this.uncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.uncheck.FlatAppearance.BorderSize = 0;
            this.uncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uncheck.Location = new System.Drawing.Point(87, 13);
            this.uncheck.Name = "uncheck";
            this.uncheck.Size = new System.Drawing.Size(75, 23);
            this.uncheck.TabIndex = 4;
            this.uncheck.Text = "Uncheck All";
            this.uncheck.UseVisualStyleBackColor = false;
            this.uncheck.Click += new System.EventHandler(this.uncheck_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.check.FlatAppearance.BorderSize = 0;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Location = new System.Drawing.Point(6, 13);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 5;
            this.check.Text = "Check All";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // check_update
            // 
            this.check_update.BackColor = System.Drawing.Color.Transparent;
            this.check_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_update.BackgroundImage")));
            this.check_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check_update.FlatAppearance.BorderSize = 0;
            this.check_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.check_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.check_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_update.Location = new System.Drawing.Point(10, 14);
            this.check_update.Margin = new System.Windows.Forms.Padding(10);
            this.check_update.Name = "check_update";
            this.check_update.Size = new System.Drawing.Size(32, 32);
            this.check_update.TabIndex = 6;
            this.check_update.UseVisualStyleBackColor = false;
            this.check_update.Click += new System.EventHandler(this.check_update_Click);
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.Color.Transparent;
            this.discord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discord.BackgroundImage")));
            this.discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discord.FlatAppearance.BorderSize = 0;
            this.discord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.discord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discord.Location = new System.Drawing.Point(10, 66);
            this.discord.Margin = new System.Windows.Forms.Padding(10);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(32, 32);
            this.discord.TabIndex = 7;
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(489, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(535, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Neo";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.check);
            this.groupBox4.Controls.Add(this.uncheck);
            this.groupBox4.Controls.Add(this.download);
            this.groupBox4.Location = new System.Drawing.Point(12, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 43);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.ForeColor = System.Drawing.Color.Orange;
            this.status.Location = new System.Drawing.Point(55, 18);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(57, 13);
            this.status.TabIndex = 12;
            this.status.Text = "not loaded";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.status);
            this.groupBox5.Location = new System.Drawing.Point(12, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 43);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(15, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Transparent;
            this.browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("browse.BackgroundImage")));
            this.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.browse.Location = new System.Drawing.Point(542, 7);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(16, 16);
            this.browse.TabIndex = 11;
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // dump
            // 
            this.dump.BackColor = System.Drawing.Color.Transparent;
            this.dump.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dump.BackgroundImage")));
            this.dump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dump.FlatAppearance.BorderSize = 0;
            this.dump.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dump.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dump.Location = new System.Drawing.Point(15, 275);
            this.dump.Margin = new System.Windows.Forms.Padding(10);
            this.dump.Name = "dump";
            this.dump.Size = new System.Drawing.Size(32, 32);
            this.dump.TabIndex = 6;
            this.dump.UseVisualStyleBackColor = false;
            this.dump.Click += new System.EventHandler(this.dump_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.theme);
            this.panel.Controls.Add(this.dump);
            this.panel.Controls.Add(this.check_update);
            this.panel.Controls.Add(this.discord);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(585, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(55, 330);
            this.panel.TabIndex = 12;
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.Color.Transparent;
            this.theme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theme.BackgroundImage")));
            this.theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theme.FlatAppearance.BorderSize = 0;
            this.theme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.theme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme.Location = new System.Drawing.Point(10, 118);
            this.theme.Margin = new System.Windows.Forms.Padding(10);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(32, 32);
            this.theme.TabIndex = 12;
            this.theme.UseVisualStyleBackColor = false;
            this.theme.Click += new System.EventHandler(this.theme_Click);
            // 
            // Nysa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nysa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nysa";
            this.Load += new System.EventHandler(this.Nysa_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.CheckedListBox tools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button uncheck;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button check_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button dump;
        private System.Windows.Forms.CheckBox minimalist;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button theme;
    }
}

