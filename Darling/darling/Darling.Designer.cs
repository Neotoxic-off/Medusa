
namespace Playername
{
    partial class Playername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playername));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_stop = new System.Windows.Forms.Button();
            this.Dump = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.b_stop);
            this.groupBox1.Controls.Add(this.Dump);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(115, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Commands ";
            // 
            // b_stop
            // 
            this.b_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.b_stop.Enabled = false;
            this.b_stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.b_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stop.ForeColor = System.Drawing.Color.White;
            this.b_stop.Location = new System.Drawing.Point(25, 114);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(191, 23);
            this.b_stop.TabIndex = 2;
            this.b_stop.Text = "Stop";
            this.b_stop.UseVisualStyleBackColor = false;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // Dump
            // 
            this.Dump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.Dump.Enabled = false;
            this.Dump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.Dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dump.ForeColor = System.Drawing.Color.White;
            this.Dump.Location = new System.Drawing.Point(25, 73);
            this.Dump.Name = "Dump";
            this.Dump.Size = new System.Drawing.Size(191, 23);
            this.Dump.TabIndex = 1;
            this.Dump.Text = "Dump";
            this.Dump.UseVisualStyleBackColor = false;
            this.Dump.Click += new System.EventHandler(this.Dump_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(25, 32);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(189, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author: Neo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "D a r l i n g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(371, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Death is an Escape";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(399, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Version: 1.1.0";
            // 
            // Playername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Darling.Properties.Resources._909940;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Playername";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wake the fuck up cheater, we have rules to burn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Playername_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Dump;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

