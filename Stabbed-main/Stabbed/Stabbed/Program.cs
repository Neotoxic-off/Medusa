using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stabbed
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            splash.Splash splash = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splash = new splash.Splash();
            Application.Run(splash);
            if (splash.success == true)
                Application.Run(new Stabbed(splash.list_configs));
        }
    }
}
