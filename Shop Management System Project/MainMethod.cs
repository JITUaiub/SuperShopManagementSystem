using System;
using System.Windows.Forms;
using Shop_Management_System_Project.Login_Authentication;

namespace Shop_Management_System_Project
{
    static class MainMethod
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogOn());
        }
    }
}
