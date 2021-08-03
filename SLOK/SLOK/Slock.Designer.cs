
namespace SLOK
{
    partial class Slock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slock));
            this.border = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.coffee = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.market_path = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.folder_path = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.border.Size = new System.Drawing.Size(400, 30);
            this.border.TabIndex = 1;
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
            this.about.Location = new System.Drawing.Point(284, 6);
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
            this.version.Size = new System.Drawing.Size(31, 13);
            this.version.TabIndex = 8;
            this.version.Text = "1.0.0";
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
            this.minimize.Location = new System.Drawing.Point(350, 7);
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
            this.exit.Location = new System.Drawing.Point(372, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 16);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.run.FlatAppearance.BorderSize = 0;
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.Location = new System.Drawing.Point(162, 105);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 10;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.coffee);
            this.groupBox2.Controls.Add(this.discord);
            this.groupBox2.Location = new System.Drawing.Point(100, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 54);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // coffee
            // 
            this.coffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.coffee.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.coffee.FlatAppearance.BorderSize = 0;
            this.coffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coffee.Location = new System.Drawing.Point(119, 19);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(75, 23);
            this.coffee.TabIndex = 6;
            this.coffee.Text = "Coffee";
            this.coffee.UseVisualStyleBackColor = false;
            this.coffee.Click += new System.EventHandler(this.coffee_Click);
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.discord.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.discord.FlatAppearance.BorderSize = 0;
            this.discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discord.Location = new System.Drawing.Point(6, 19);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(75, 23);
            this.discord.TabIndex = 7;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // market_path
            // 
            this.market_path.AutoSize = true;
            this.market_path.ForeColor = System.Drawing.Color.Orange;
            this.market_path.Location = new System.Drawing.Point(59, 45);
            this.market_path.Name = "market_path";
            this.market_path.Size = new System.Drawing.Size(57, 13);
            this.market_path.TabIndex = 15;
            this.market_path.Text = "not loaded";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Neo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Author:";
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
            this.browse.Location = new System.Drawing.Point(317, 6);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(16, 16);
            this.browse.TabIndex = 10;
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // folder_path
            // 
            this.folder_path.DefaultExt = "*.json";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Market:";
            // 
            // Slock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.market_path);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Slock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Slock_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button coffee;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Label market_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog folder_path;
        private System.Windows.Forms.Label label1;
    }
}

