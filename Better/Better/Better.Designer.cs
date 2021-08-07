
namespace Better
{
    partial class Better
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Better));
            this.border = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coffee = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.logo_rank_survivor = new System.Windows.Forms.PictureBox();
            this.logo_rank_killer = new System.Windows.Forms.PictureBox();
            this.rank_killer_wanted = new System.Windows.Forms.NumericUpDown();
            this.rank_survivor_wanted = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_rank_survivor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_rank_killer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rank_killer_wanted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rank_survivor_wanted)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.border.Controls.Add(this.about);
            this.border.Controls.Add(this.label2);
            this.border.Controls.Add(this.version);
            this.border.Controls.Add(this.minimize);
            this.border.Controls.Add(this.exit);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(386, 30);
            this.border.TabIndex = 3;
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
            this.about.Location = new System.Drawing.Point(282, 7);
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
            this.minimize.Location = new System.Drawing.Point(334, 7);
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
            this.exit.Location = new System.Drawing.Point(358, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 16);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Neo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Author:";
            // 
            // coffee
            // 
            this.coffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.coffee.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.coffee.FlatAppearance.BorderSize = 0;
            this.coffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coffee.ForeColor = System.Drawing.Color.DimGray;
            this.coffee.Location = new System.Drawing.Point(195, 227);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(75, 23);
            this.coffee.TabIndex = 20;
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
            this.discord.ForeColor = System.Drawing.Color.DimGray;
            this.discord.Location = new System.Drawing.Point(114, 227);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(75, 23);
            this.discord.TabIndex = 21;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // logo_rank_survivor
            // 
            this.logo_rank_survivor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo_rank_survivor.Location = new System.Drawing.Point(114, 81);
            this.logo_rank_survivor.Name = "logo_rank_survivor";
            this.logo_rank_survivor.Size = new System.Drawing.Size(64, 76);
            this.logo_rank_survivor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo_rank_survivor.TabIndex = 24;
            this.logo_rank_survivor.TabStop = false;
            // 
            // logo_rank_killer
            // 
            this.logo_rank_killer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo_rank_killer.Location = new System.Drawing.Point(209, 81);
            this.logo_rank_killer.Name = "logo_rank_killer";
            this.logo_rank_killer.Size = new System.Drawing.Size(64, 76);
            this.logo_rank_killer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo_rank_killer.TabIndex = 25;
            this.logo_rank_killer.TabStop = false;
            // 
            // rank_killer_wanted
            // 
            this.rank_killer_wanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.rank_killer_wanted.ForeColor = System.Drawing.Color.DimGray;
            this.rank_killer_wanted.Location = new System.Drawing.Point(209, 163);
            this.rank_killer_wanted.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rank_killer_wanted.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rank_killer_wanted.Name = "rank_killer_wanted";
            this.rank_killer_wanted.Size = new System.Drawing.Size(64, 20);
            this.rank_killer_wanted.TabIndex = 26;
            this.rank_killer_wanted.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rank_killer_wanted.ValueChanged += new System.EventHandler(this.rank_killer_wanted_ValueChanged);
            // 
            // rank_survivor_wanted
            // 
            this.rank_survivor_wanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.rank_survivor_wanted.ForeColor = System.Drawing.Color.DimGray;
            this.rank_survivor_wanted.Location = new System.Drawing.Point(114, 163);
            this.rank_survivor_wanted.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rank_survivor_wanted.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rank_survivor_wanted.Name = "rank_survivor_wanted";
            this.rank_survivor_wanted.Size = new System.Drawing.Size(64, 20);
            this.rank_survivor_wanted.TabIndex = 27;
            this.rank_survivor_wanted.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rank_survivor_wanted.ValueChanged += new System.EventHandler(this.rank_survivor_wanted_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(157, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Orange;
            this.status.Location = new System.Drawing.Point(62, 44);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(41, 13);
            this.status.TabIndex = 30;
            this.status.Text = "loading";
            // 
            // Better
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(386, 264);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rank_survivor_wanted);
            this.Controls.Add(this.rank_killer_wanted);
            this.Controls.Add(this.logo_rank_killer);
            this.Controls.Add(this.logo_rank_survivor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coffee);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.border);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Better";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better";
            this.Load += new System.EventHandler(this.Better_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_rank_survivor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_rank_killer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rank_killer_wanted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rank_survivor_wanted)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button coffee;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.PictureBox logo_rank_survivor;
        private System.Windows.Forms.PictureBox logo_rank_killer;
        private System.Windows.Forms.NumericUpDown rank_killer_wanted;
        private System.Windows.Forms.NumericUpDown rank_survivor_wanted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
    }
}

