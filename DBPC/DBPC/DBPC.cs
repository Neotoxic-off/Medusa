using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPC
{
    public partial class DBPC : Form
    {
        bool mouse_down = false;
        private Point offset;

        classes.permissions data = new classes.permissions();
        long permission_code = 0;
        string link_base = "https://discord.com/oauth2/authorize";
        string link_permission = "&permissions=";
        string link_redirect = "&redirect_uri=";
        string link_grant = "&response_type=code";
        string link_scope = "&scope=";
        string link_client = "?client_id=";
        string id = "INSERT_CLIENT_ID_HERE";

        public DBPC()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void border_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;

            mouse_down = true;
        }

        private void border_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down == true)
            {
                Point pos = PointToScreen(e.Location);
                Location = new Point(pos.X - offset.X, pos.Y - offset.Y);
            }
        }

        private void border_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private Task update_link()
        {
            string display_id = id;
            string display_grant = "";
            string redirect = "";
            string display_scope = $"{link_scope}bot";

            if (copy.Enabled == false)
                copy.Enabled = true;
            permissions_code_ui.Text = $"{permission_code}";
            if (client_id.Text.Length > 0)
                display_id = client_id.Text;
            if (require_code_grant.Checked == true)
                display_grant = link_grant;
            if (redirect_url.Text.Length > 0)
                redirect = $"{link_redirect}{redirect_url.Text}";
            if (scope.Text.Length > 0)
                display_scope = $"{link_scope}{scope.Text}";

            link.Text = $"{link_base}{link_client}{display_id}{display_scope}{link_permission}{permission_code}{redirect}{display_grant}";

            return (Task.CompletedTask);
        }

        private void permissions_MouseUp(object sender, MouseEventArgs e)
        {
            permission_code = 0;

            for (int i = 0; i < permissions.Items.Count; i++)
            {
                if (permissions.GetItemChecked(i) == true)
                    permission_code += data.get_value(permissions.Items[i].ToString());
            }
            update_link().Wait();
        }

        private void client_id_TextChanged(object sender, EventArgs e)
        {
            update_link().Wait();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (link.Text.Length > 0)
            {
                Clipboard.SetText(link.Text);
                MessageBox.Show($"Link copied into your clipboard: {Clipboard.GetText()}", "Link copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Link not copied into your clipboard, no information provided", "No link to copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void require_code_grant_CheckedChanged(object sender, EventArgs e)
        {
            update_link().Wait();
        }

        private void redirect_url_TextChanged(object sender, EventArgs e)
        {
            update_link().Wait();
        }

        private void scope_TextChanged(object sender, EventArgs e)
        {
            update_link().Wait();
        }

        private void DBPC_Load(object sender, EventArgs e)
        {
            update_link().Wait();
        }
    }
}
