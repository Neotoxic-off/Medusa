
namespace Kamiki
{
    partial class Items_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items_editor));
            this.background = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.UOK = new System.Windows.Forms.Button();
            this.UAK = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.UOS = new System.Windows.Forms.Button();
            this.UAS = new System.Windows.Forms.Button();
            this.UIS = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.apply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.kill_offerings = new System.Windows.Forms.CheckedListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.kill_addons = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.surv_items = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.surv_addons = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.surv_offerings = new System.Windows.Forms.CheckedListBox();
            this.background.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Controls.Add(this.groupBox3);
            this.background.Controls.Add(this.groupBox2);
            this.background.Controls.Add(this.groupBox1);
            this.background.Location = new System.Drawing.Point(12, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(940, 497);
            this.background.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(736, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 491);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Settings ";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.UOK);
            this.groupBox11.Controls.Add(this.UAK);
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(6, 160);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(189, 101);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = " Killers ";
            // 
            // UOK
            // 
            this.UOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UOK.ForeColor = System.Drawing.Color.White;
            this.UOK.Location = new System.Drawing.Point(17, 57);
            this.UOK.Name = "UOK";
            this.UOK.Size = new System.Drawing.Size(156, 23);
            this.UOK.TabIndex = 2;
            this.UOK.Text = "Uncheck all Offerings";
            this.UOK.UseVisualStyleBackColor = false;
            this.UOK.Click += new System.EventHandler(this.UOK_Click);
            // 
            // UAK
            // 
            this.UAK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UAK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UAK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UAK.ForeColor = System.Drawing.Color.White;
            this.UAK.Location = new System.Drawing.Point(17, 28);
            this.UAK.Name = "UAK";
            this.UAK.Size = new System.Drawing.Size(156, 23);
            this.UAK.TabIndex = 1;
            this.UAK.Text = "Uncheck all Addons";
            this.UAK.UseVisualStyleBackColor = false;
            this.UAK.Click += new System.EventHandler(this.UAK_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Transparent;
            this.groupBox10.Controls.Add(this.UOS);
            this.groupBox10.Controls.Add(this.UAS);
            this.groupBox10.Controls.Add(this.UIS);
            this.groupBox10.ForeColor = System.Drawing.Color.White;
            this.groupBox10.Location = new System.Drawing.Point(6, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(189, 135);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = " Survivors ";
            // 
            // UOS
            // 
            this.UOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UOS.ForeColor = System.Drawing.Color.White;
            this.UOS.Location = new System.Drawing.Point(17, 87);
            this.UOS.Name = "UOS";
            this.UOS.Size = new System.Drawing.Size(156, 23);
            this.UOS.TabIndex = 2;
            this.UOS.Text = "Uncheck all Offerings";
            this.UOS.UseVisualStyleBackColor = false;
            this.UOS.Click += new System.EventHandler(this.UOS_Click);
            // 
            // UAS
            // 
            this.UAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UAS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UAS.ForeColor = System.Drawing.Color.White;
            this.UAS.Location = new System.Drawing.Point(17, 58);
            this.UAS.Name = "UAS";
            this.UAS.Size = new System.Drawing.Size(156, 23);
            this.UAS.TabIndex = 1;
            this.UAS.Text = "Uncheck all Addons";
            this.UAS.UseVisualStyleBackColor = false;
            this.UAS.Click += new System.EventHandler(this.UAS_Click);
            // 
            // UIS
            // 
            this.UIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UIS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.UIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UIS.ForeColor = System.Drawing.Color.White;
            this.UIS.Location = new System.Drawing.Point(17, 29);
            this.UIS.Name = "UIS";
            this.UIS.Size = new System.Drawing.Size(156, 23);
            this.UIS.TabIndex = 0;
            this.UIS.Text = "Uncheck all Items";
            this.UIS.UseVisualStyleBackColor = false;
            this.UIS.Click += new System.EventHandler(this.UIS_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.apply);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(6, 412);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(189, 73);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = " Configuration ";
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(17, 29);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(156, 23);
            this.apply.TabIndex = 0;
            this.apply.Text = "Save";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(370, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 491);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Killers ";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.kill_offerings);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(6, 255);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(348, 230);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = " Offerings ";
            // 
            // kill_offerings
            // 
            this.kill_offerings.BackColor = System.Drawing.Color.Black;
            this.kill_offerings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kill_offerings.ForeColor = System.Drawing.Color.White;
            this.kill_offerings.FormattingEnabled = true;
            this.kill_offerings.Location = new System.Drawing.Point(6, 19);
            this.kill_offerings.Name = "kill_offerings";
            this.kill_offerings.Size = new System.Drawing.Size(336, 195);
            this.kill_offerings.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.kill_addons);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(6, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(348, 230);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = " Items ";
            // 
            // kill_addons
            // 
            this.kill_addons.BackColor = System.Drawing.Color.Black;
            this.kill_addons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kill_addons.ForeColor = System.Drawing.Color.White;
            this.kill_addons.FormattingEnabled = true;
            this.kill_addons.Location = new System.Drawing.Point(6, 19);
            this.kill_addons.Name = "kill_addons";
            this.kill_addons.Size = new System.Drawing.Size(336, 195);
            this.kill_addons.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Survivors ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.surv_items);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(349, 151);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Items ";
            // 
            // surv_items
            // 
            this.surv_items.BackColor = System.Drawing.Color.Black;
            this.surv_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surv_items.ForeColor = System.Drawing.Color.White;
            this.surv_items.FormattingEnabled = true;
            this.surv_items.Location = new System.Drawing.Point(6, 19);
            this.surv_items.Name = "surv_items";
            this.surv_items.Size = new System.Drawing.Size(337, 120);
            this.surv_items.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.surv_addons);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(6, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 151);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Addons ";
            // 
            // surv_addons
            // 
            this.surv_addons.BackColor = System.Drawing.Color.Black;
            this.surv_addons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surv_addons.ForeColor = System.Drawing.Color.White;
            this.surv_addons.FormattingEnabled = true;
            this.surv_addons.Location = new System.Drawing.Point(6, 19);
            this.surv_addons.Name = "surv_addons";
            this.surv_addons.Size = new System.Drawing.Size(337, 120);
            this.surv_addons.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.surv_offerings);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(6, 333);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(349, 151);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " Offerings ";
            // 
            // surv_offerings
            // 
            this.surv_offerings.BackColor = System.Drawing.Color.Black;
            this.surv_offerings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surv_offerings.ForeColor = System.Drawing.Color.White;
            this.surv_offerings.FormattingEnabled = true;
            this.surv_offerings.Location = new System.Drawing.Point(6, 19);
            this.surv_offerings.Name = "surv_offerings";
            this.surv_offerings.Size = new System.Drawing.Size(337, 120);
            this.surv_offerings.TabIndex = 2;
            // 
            // Items_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kamiki.Properties.Resources.téléchargé;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 521);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Items_editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit the desired items / addons / offerings";
            this.Load += new System.EventHandler(this.Items_editor_Load);
            this.background.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox surv_items;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox surv_addons;
        private System.Windows.Forms.CheckedListBox surv_offerings;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckedListBox kill_addons;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckedListBox kill_offerings;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button UIS;
        private System.Windows.Forms.Button UOS;
        private System.Windows.Forms.Button UAS;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button UOK;
        private System.Windows.Forms.Button UAK;
    }
}