
namespace Trinity
{
    partial class Trinity
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trinity));
            this.label1 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.shards_value = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resume_shards = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.user_total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.user_shards = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.user_experience = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.user_prestige = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_level = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shards_value)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(160, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "T R I N I T Y";
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.run.FlatAppearance.BorderSize = 0;
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.ForeColor = System.Drawing.Color.White;
            this.run.Location = new System.Drawing.Point(347, 209);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 1;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(435, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Author: Neo";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel2.Text = "My cheat your rules";
            // 
            // shards_value
            // 
            this.shards_value.Location = new System.Drawing.Point(6, 22);
            this.shards_value.Maximum = 1000000;
            this.shards_value.Minimum = 1000;
            this.shards_value.Name = "shards_value";
            this.shards_value.Size = new System.Drawing.Size(187, 45);
            this.shards_value.TabIndex = 3;
            this.shards_value.TickFrequency = 100000;
            this.shards_value.Value = 1000;
            this.shards_value.Scroll += new System.EventHandler(this._value_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resume_shards);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shards_value);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Settings ";
            // 
            // resume_shards
            // 
            this.resume_shards.AutoSize = true;
            this.resume_shards.Location = new System.Drawing.Point(100, 70);
            this.resume_shards.Name = "resume_shards";
            this.resume_shards.Size = new System.Drawing.Size(13, 15);
            this.resume_shards.TabIndex = 8;
            this.resume_shards.Tag = "";
            this.resume_shards.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shards to add:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.user_total);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.user_shards);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.user_experience);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.user_prestige);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.user_level);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(223, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Resume ";
            // 
            // user_total
            // 
            this.user_total.Location = new System.Drawing.Point(88, 92);
            this.user_total.Name = "user_total";
            this.user_total.Size = new System.Drawing.Size(105, 18);
            this.user_total.TabIndex = 9;
            this.user_total.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Shards:";
            // 
            // user_shards
            // 
            this.user_shards.Location = new System.Drawing.Point(88, 68);
            this.user_shards.Name = "user_shards";
            this.user_shards.Size = new System.Drawing.Size(105, 15);
            this.user_shards.TabIndex = 7;
            this.user_shards.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Shards added:";
            // 
            // user_experience
            // 
            this.user_experience.Location = new System.Drawing.Point(88, 52);
            this.user_experience.Name = "user_experience";
            this.user_experience.Size = new System.Drawing.Size(106, 16);
            this.user_experience.TabIndex = 5;
            this.user_experience.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Experience:";
            // 
            // user_prestige
            // 
            this.user_prestige.Location = new System.Drawing.Point(88, 38);
            this.user_prestige.Name = "user_prestige";
            this.user_prestige.Size = new System.Drawing.Size(105, 15);
            this.user_prestige.TabIndex = 3;
            this.user_prestige.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prestige:";
            // 
            // user_level
            // 
            this.user_level.Location = new System.Drawing.Point(88, 22);
            this.user_level.Name = "user_level";
            this.user_level.Size = new System.Drawing.Size(105, 15);
            this.user_level.TabIndex = 1;
            this.user_level.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Level:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 30);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(6, 10);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(39, 15);
            this.status.TabIndex = 0;
            this.status.Text = "Ready";
            // 
            // Trinity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(435, 243);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.run);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Trinity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wake the fuck up cheater, we have rules to burn";
            this.Load += new System.EventHandler(this.Trinity_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shards_value)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TrackBar _value;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar shards_value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label user_level;
        private System.Windows.Forms.Label user_experience;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label user_prestige;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label user_shards;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label user_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resume_shards;
    }
}

