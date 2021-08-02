
namespace Nysa
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.border = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.discord = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pure = new System.Windows.Forms.CheckBox();
            this.Check_update = new System.Windows.Forms.Button();
            this.border.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.Black;
            this.border.Controls.Add(this.exit);
            this.border.Controls.Add(this.label1);
            this.border.Controls.Add(this.version);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(660, 30);
            this.border.TabIndex = 1;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.exit.Location = new System.Drawing.Point(633, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 24);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "version:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(62, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(31, 13);
            this.version.TabIndex = 5;
            this.version.Text = "0.0.1";
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.discord.Location = new System.Drawing.Point(168, 36);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(75, 23);
            this.discord.TabIndex = 2;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // github
            // 
            this.github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.github.Location = new System.Drawing.Point(282, 36);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(75, 23);
            this.github.TabIndex = 3;
            this.github.Text = "Github";
            this.github.UseVisualStyleBackColor = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.discord);
            this.groupBox1.Controls.Add(this.github);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(59, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Join the navy ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(59, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 184);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Informations ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Neo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Check_update);
            this.groupBox3.Controls.Add(this.pure);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Location = new System.Drawing.Point(59, 235);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Settings ";
            // 
            // pure
            // 
            this.pure.AutoSize = true;
            this.pure.Checked = true;
            this.pure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pure.Location = new System.Drawing.Point(282, 31);
            this.pure.Name = "pure";
            this.pure.Size = new System.Drawing.Size(71, 17);
            this.pure.TabIndex = 8;
            this.pure.Text = "Pure mod";
            this.pure.UseVisualStyleBackColor = true;
            this.pure.CheckedChanged += new System.EventHandler(this.simp_CheckedChanged);
            // 
            // Check_update
            // 
            this.Check_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.Check_update.Location = new System.Drawing.Point(168, 27);
            this.Check_update.Name = "Check_update";
            this.Check_update.Size = new System.Drawing.Size(75, 23);
            this.Check_update.TabIndex = 4;
            this.Check_update.Text = "Update";
            this.Check_update.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(660, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox pure;
        private System.Windows.Forms.Button Check_update;
    }
}