using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gladiator_2_Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGladiator2Launcher());
        }
    }
}
