
namespace Nysa.form
{
    partial class editor
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minimalist = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.blur = new System.Windows.Forms.TextBox();
            this.background = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.bunifuCards1.SuspendLayout();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.color);
            this.bunifuCards1.Controls.Add(this.blur);
            this.bunifuCards1.Controls.Add(this.label12);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.Controls.Add(this.minimalist);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.background);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(15, 36);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(349, 266);
            this.bunifuCards1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "blur is an ARGB color placed just above the background image to change the blur o" +
    "r the background image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "background has to be a path from your background image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "color:";
            // 
            // minimalist
            // 
            this.minimalist.AutoSize = true;
            this.minimalist.ForeColor = System.Drawing.Color.Orange;
            this.minimalist.Location = new System.Drawing.Point(85, 172);
            this.minimalist.Name = "minimalist";
            this.minimalist.Size = new System.Drawing.Size(57, 13);
            this.minimalist.TabIndex = 8;
            this.minimalist.Text = "not loaded";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "minimalist:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "blur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "background:";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(234, 347);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 16;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(72, 347);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 18;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // abort
            // 
            this.abort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.abort.FlatAppearance.BorderSize = 0;
            this.abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abort.Location = new System.Drawing.Point(153, 347);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 17;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = false;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.Color.Orange;
            this.version.Location = new System.Drawing.Point(62, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(57, 13);
            this.version.TabIndex = 2;
            this.version.Text = "not loaded";
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.border.Controls.Add(this.label11);
            this.border.Controls.Add(this.version);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(376, 30);
            this.border.TabIndex = 19;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "minimalist is a boolean to hide or display the background image";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(302, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "color is an ARGB color, it represents the color of the top border";
            // 
            // blur
            // 
            this.blur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.blur.ForeColor = System.Drawing.Color.Orange;
            this.blur.Location = new System.Drawing.Point(88, 111);
            this.blur.Name = "blur";
            this.blur.Size = new System.Drawing.Size(226, 20);
            this.blur.TabIndex = 15;
            // 
            // background
            // 
            this.background.AutoSize = true;
            this.background.ForeColor = System.Drawing.Color.Orange;
            this.background.Location = new System.Drawing.Point(85, 34);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(57, 13);
            this.background.TabIndex = 4;
            this.background.Text = "not loaded";
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.color.ForeColor = System.Drawing.Color.Orange;
            this.color.Location = new System.Drawing.Point(88, 230);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(226, 20);
            this.color.TabIndex = 16;
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(376, 382);
            this.Controls.Add(this.border);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.bunifuCards1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minimalist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blur;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.TextBox color;
    }
}