using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace Ana_kata.dev_mod
{
    public partial class dev_mod : KryptonForm
    {
        public bool running = false;

        public components.Manager manager = new components.Manager();

        public class Log
        {
            public string type = null;
            public string content = null;
        }

        public dev_mod()
        {
            InitializeComponent();
        }

        public void send(string sender, string message)
        {
            manager.set_richtextbox(logs, $"[{DateTime.Now.ToString("h:mm:ss")}]    {sender} {message}\n");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dev_mod_Shown(object sender, EventArgs e)
        {
            running = true;
        }

        private void dev_mod_Load(object sender, EventArgs e)
        {

        }
    }
}
