namespace WebSurge
{
    partial class unlocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unlocker));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            this.rules_menu = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r_stop = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.rules_menu);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Rules ";
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::Duality.Properties.Resources.refresh_logo;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Location = new System.Drawing.Point(189, 30);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(23, 23);
            this.refresh.TabIndex = 1;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // rules_menu
            // 
            this.rules_menu.CausesValidation = false;
            this.rules_menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rules_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rules_menu.FormattingEnabled = true;
            this.rules_menu.Location = new System.Drawing.Point(22, 31);
            this.rules_menu.Name = "rules_menu";
            this.rules_menu.Size = new System.Drawing.Size(161, 23);
            this.rules_menu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.r_stop);
            this.groupBox2.Controls.Add(this.run);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(247, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Run ";
            // 
            // r_stop
            // 
            this.r_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.r_stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.r_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r_stop.ForeColor = System.Drawing.Color.White;
            this.r_stop.Location = new System.Drawing.Point(21, 69);
            this.r_stop.Name = "r_stop";
            this.r_stop.Size = new System.Drawing.Size(181, 23);
            this.r_stop.TabIndex = 4;
            this.r_stop.Text = "Exit";
            this.r_stop.UseVisualStyleBackColor = false;
            this.r_stop.Click += new System.EventHandler(this.r_stop_Click);
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.run.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.ForeColor = System.Drawing.Color.White;
            this.run.Location = new System.Drawing.Point(21, 31);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(181, 23);
            this.run.TabIndex = 3;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author: Neo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "R-Unlocker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 27);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(6, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(213, 15);
            this.status.TabIndex = 6;
            this.status.Text = "Ready";
            // 
            // unlocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::Duality.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "unlocker";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wake the fuck up cheater, we have rules to burn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FiddlerCapture_FormClosing);
            this.Load += new System.EventHandler(this.unlocker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.ComboBox rules_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button r_stop;
    }
}