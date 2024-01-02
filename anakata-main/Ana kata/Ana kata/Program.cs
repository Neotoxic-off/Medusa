using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ana_kata
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
                Application.Run(new Ana_kata(splash.profile));
        }
    }
}
