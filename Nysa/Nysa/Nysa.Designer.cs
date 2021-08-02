
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_update = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.Black;
            this.border.Controls.Add(this.about);
            this.border.Controls.Add(this.label2);
            this.border.Controls.Add(this.version);
            this.border.Controls.Add(this.minimize);
            this.border.Controls.Add(this.exit);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(660, 30);
            this.border.TabIndex = 0;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about.BackgroundImage")));
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.about.Location = new System.Drawing.Point(542, 3);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(24, 24);
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
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.minimize.Location = new System.Drawing.Point(603, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(24, 24);
            this.minimize.TabIndex = 1;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.exit.Location = new System.Drawing.Point(633, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 24);
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
            this.tools.Size = new System.Drawing.Size(436, 255);
            this.tools.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tools);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(200, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.download.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Location = new System.Drawing.Point(367, 13);
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
            this.uncheck.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
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
            this.check.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Location = new System.Drawing.Point(6, 13);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 5;
            this.check.Text = "Check All";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.check_update);
            this.groupBox2.Controls.Add(this.discord);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // check_update
            // 
            this.check_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.check_update.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.check_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_update.Location = new System.Drawing.Point(101, 19);
            this.check_update.Name = "check_update";
            this.check_update.Size = new System.Drawing.Size(75, 23);
            this.check_update.TabIndex = 6;
            this.check_update.Text = "Update";
            this.check_update.UseVisualStyleBackColor = false;
            this.check_update.Click += new System.EventHandler(this.check_update_Click);
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.discord.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discord.Location = new System.Drawing.Point(6, 19);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(75, 23);
            this.discord.TabIndex = 7;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Neo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.logs);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Location = new System.Drawing.Point(12, 59);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 213);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Logs ";
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logs.ForeColor = System.Drawing.Color.DarkGray;
            this.logs.Location = new System.Drawing.Point(6, 19);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(170, 184);
            this.logs.TabIndex = 0;
            this.logs.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.check);
            this.groupBox4.Controls.Add(this.uncheck);
            this.groupBox4.Controls.Add(this.download);
            this.groupBox4.Location = new System.Drawing.Point(200, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 43);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 18);
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
            this.status.Location = new System.Drawing.Point(87, 18);
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
            this.groupBox5.Location = new System.Drawing.Point(12, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 43);
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
            // Nysa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button check_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label label4;
    }
}

