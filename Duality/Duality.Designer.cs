namespace WebSurge
{
    partial class Duality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duality));
            this.MainToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSslDropDown = new System.Windows.Forms.ToolStripSplitButton();
            this.btnInstallSslCert = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUninstallSslCert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.capture_start = new System.Windows.Forms.ToolStripMenuItem();
            this.capture_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCapture = new System.Windows.Forms.TextBox();
            this.MainToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolbar
            // 
            this.MainToolbar.BackColor = System.Drawing.Color.Transparent;
            this.MainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnSslDropDown,
            this.toolStripSeparator1,
            this.tbClear,
            this.toolStripSeparator4,
            this.tbSave,
            this.toolStripSeparator3,
            this.toolStripSplitButton1});
            this.MainToolbar.Location = new System.Drawing.Point(0, 0);
            this.MainToolbar.Name = "MainToolbar";
            this.MainToolbar.Size = new System.Drawing.Size(869, 25);
            this.MainToolbar.TabIndex = 5;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Author: Neo";
            // 
            // btnSslDropDown
            // 
            this.btnSslDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSslDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSslDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInstallSslCert,
            this.btnUninstallSslCert});
            this.btnSslDropDown.ForeColor = System.Drawing.Color.White;
            this.btnSslDropDown.Image = ((System.Drawing.Image)(resources.GetObject("btnSslDropDown.Image")));
            this.btnSslDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSslDropDown.Name = "btnSslDropDown";
            this.btnSslDropDown.Size = new System.Drawing.Size(82, 22);
            this.btnSslDropDown.Text = "Certificates";
            this.btnSslDropDown.ToolTipText = "Certificates";
            // 
            // btnInstallSslCert
            // 
            this.btnInstallSslCert.Name = "btnInstallSslCert";
            this.btnInstallSslCert.Size = new System.Drawing.Size(237, 22);
            this.btnInstallSslCert.Text = "Install SSL Fiddler Certificate";
            this.btnInstallSslCert.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnUninstallSslCert
            // 
            this.btnUninstallSslCert.Name = "btnUninstallSslCert";
            this.btnUninstallSslCert.Size = new System.Drawing.Size(237, 22);
            this.btnUninstallSslCert.Text = "Uninstall SSL Fiddler Certificate";
            this.btnUninstallSslCert.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbClear
            // 
            this.tbClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbClear.ForeColor = System.Drawing.Color.White;
            this.tbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(38, 22);
            this.tbClear.Text = "Clear";
            this.tbClear.ToolTipText = "Clears the captured Urls";
            this.tbClear.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSave
            // 
            this.tbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbSave.ForeColor = System.Drawing.Color.White;
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(35, 22);
            this.tbSave.Text = "Save";
            this.tbSave.ToolTipText = "Saves captured URLs to a file";
            this.tbSave.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capture_start,
            this.capture_stop});
            this.toolStripSplitButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripSplitButton1.Text = "Capture";
            // 
            // capture_start
            // 
            this.capture_start.Name = "capture_start";
            this.capture_start.Size = new System.Drawing.Size(180, 22);
            this.capture_start.Text = "Start capture";
            this.capture_start.Click += new System.EventHandler(this.capture_start_Click);
            // 
            // capture_stop
            // 
            this.capture_stop.Name = "capture_stop";
            this.capture_stop.Size = new System.Drawing.Size(180, 22);
            this.capture_stop.Text = "Stop capture";
            this.capture_stop.Click += new System.EventHandler(this.capture_stop_Click);
            // 
            // txtCapture
            // 
            this.txtCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapture.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapture.ForeColor = System.Drawing.Color.White;
            this.txtCapture.Location = new System.Drawing.Point(-1, 32);
            this.txtCapture.Multiline = true;
            this.txtCapture.Name = "txtCapture";
            this.txtCapture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCapture.Size = new System.Drawing.Size(871, 627);
            this.txtCapture.TabIndex = 1;
            // 
            // Duality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(869, 659);
            this.Controls.Add(this.MainToolbar);
            this.Controls.Add(this.txtCapture);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Duality";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wake the fuck up cheater, we have rules to burn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FiddlerCapture_FormClosing);
            this.Load += new System.EventHandler(this.Duality_Load);
            this.MainToolbar.ResumeLayout(false);
            this.MainToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip MainToolbar;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbClear;
        private System.Windows.Forms.ToolStripSplitButton btnSslDropDown;
        private System.Windows.Forms.ToolStripMenuItem btnInstallSslCert;
        private System.Windows.Forms.ToolStripMenuItem btnUninstallSslCert;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem capture_start;
        private System.Windows.Forms.ToolStripMenuItem capture_stop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txtCapture;
    }
}