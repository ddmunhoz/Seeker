using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Seeker
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
            frmLogin login = new frmLogin();          
            if (login.ShowDialog() == DialogResult.OK)
            {
                frmMain frmMainData = new frmMain();                
                Application.Run(frmMainData);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
