
namespace DBPC
{
    partial class DBPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBPC));
            this.border = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.permissions = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.client_id = new System.Windows.Forms.TextBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.require_code_grant = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.scope = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.redirect_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.label8 = new System.Windows.Forms.Label();
            this.permissions_code_ui = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.TextBox();
            this.border.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.border.Controls.Add(this.label2);
            this.border.Controls.Add(this.version);
            this.border.Controls.Add(this.minimize);
            this.border.Controls.Add(this.exit);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(400, 30);
            this.border.TabIndex = 3;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "version:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.Color.DimGray;
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
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.permissions);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 51);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(376, 207);
            this.bunifuCards1.TabIndex = 34;
            // 
            // permissions
            // 
            this.permissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.permissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.permissions.ForeColor = System.Drawing.Color.DimGray;
            this.permissions.FormattingEnabled = true;
            this.permissions.Items.AddRange(new object[] {
            "Administrator",
            "Manage Channels",
            "Manage Roles",
            "Manage Emojis",
            "View Audit Log",
            "View Server Insights",
            "Manage Webhooks",
            "Manage Server",
            "Create Invite",
            "Change Nickname",
            "Manage Nicknames",
            "Kick Members",
            "Ban Members",
            "Read Messages",
            "Send Messages",
            "Embed Links",
            "Attach Files",
            "Add Reactions",
            "Use External Emojis",
            "Mention @everyone, @here, and All Roles",
            "Manage Messages",
            "Read Message History",
            "Send TTS Messages",
            "Use Slash Commands",
            "View Channel",
            "Connect",
            "Speak",
            "Video",
            "Use Voice Activity",
            "Priority Speaker",
            "Mute Members",
            "Deafen Members",
            "Move Members",
            "Request to Speak"});
            this.permissions.Location = new System.Drawing.Point(10, 10);
            this.permissions.Margin = new System.Windows.Forms.Padding(10);
            this.permissions.Name = "permissions";
            this.permissions.Size = new System.Drawing.Size(356, 180);
            this.permissions.TabIndex = 20;
            this.permissions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.permissions_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Neo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Author:";
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.copy.Enabled = false;
            this.copy.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.ForeColor = System.Drawing.Color.DimGray;
            this.copy.Location = new System.Drawing.Point(160, 518);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 35;
            this.copy.Text = "Copy Link";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // client_id
            // 
            this.client_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.client_id.ForeColor = System.Drawing.Color.Orange;
            this.client_id.Location = new System.Drawing.Point(85, 14);
            this.client_id.Name = "client_id";
            this.client_id.Size = new System.Drawing.Size(281, 20);
            this.client_id.TabIndex = 21;
            this.client_id.TextChanged += new System.EventHandler(this.client_id_TextChanged);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.require_code_grant);
            this.bunifuCards2.Controls.Add(this.label6);
            this.bunifuCards2.Controls.Add(this.scope);
            this.bunifuCards2.Controls.Add(this.label5);
            this.bunifuCards2.Controls.Add(this.redirect_url);
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.client_id);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 264);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(376, 138);
            this.bunifuCards2.TabIndex = 35;
            // 
            // require_code_grant
            // 
            this.require_code_grant.AutoSize = true;
            this.require_code_grant.Location = new System.Drawing.Point(246, 104);
            this.require_code_grant.Name = "require_code_grant";
            this.require_code_grant.Size = new System.Drawing.Size(120, 17);
            this.require_code_grant.TabIndex = 27;
            this.require_code_grant.Text = "Require Code Grant";
            this.require_code_grant.UseVisualStyleBackColor = true;
            this.require_code_grant.CheckedChanged += new System.EventHandler(this.require_code_grant_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Scope:";
            // 
            // scope
            // 
            this.scope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.scope.ForeColor = System.Drawing.Color.Orange;
            this.scope.Location = new System.Drawing.Point(85, 66);
            this.scope.Name = "scope";
            this.scope.Size = new System.Drawing.Size(281, 20);
            this.scope.TabIndex = 25;
            this.scope.TextChanged += new System.EventHandler(this.scope_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Redirect URI:";
            // 
            // redirect_url
            // 
            this.redirect_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.redirect_url.ForeColor = System.Drawing.Color.Orange;
            this.redirect_url.Location = new System.Drawing.Point(85, 40);
            this.redirect_url.Name = "redirect_url";
            this.redirect_url.Size = new System.Drawing.Size(281, 20);
            this.redirect_url.TabIndex = 23;
            this.redirect_url.TextChanged += new System.EventHandler(this.redirect_url_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Client ID:";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Transparent;
            this.bunifuCards3.Controls.Add(this.label8);
            this.bunifuCards3.Controls.Add(this.permissions_code_ui);
            this.bunifuCards3.Controls.Add(this.label7);
            this.bunifuCards3.Controls.Add(this.link);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(12, 408);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(376, 82);
            this.bunifuCards3.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Permissions Code:";
            // 
            // permissions_code_ui
            // 
            this.permissions_code_ui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.permissions_code_ui.ForeColor = System.Drawing.Color.Orange;
            this.permissions_code_ui.Location = new System.Drawing.Point(109, 15);
            this.permissions_code_ui.Name = "permissions_code_ui";
            this.permissions_code_ui.ReadOnly = true;
            this.permissions_code_ui.Size = new System.Drawing.Size(257, 20);
            this.permissions_code_ui.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Link:";
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.link.ForeColor = System.Drawing.Color.Orange;
            this.link.Location = new System.Drawing.Point(109, 41);
            this.link.Name = "link";
            this.link.ReadOnly = true;
            this.link.Size = new System.Drawing.Size(257, 20);
            this.link.TabIndex = 25;
            // 
            // DBPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(400, 553);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.border);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBPC";
            this.Load += new System.EventHandler(this.DBPC_Load);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox permissions;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.TextBox client_id;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox redirect_url;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox scope;
        private System.Windows.Forms.CheckBox require_code_grant;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox permissions_code_ui;
    }
}

