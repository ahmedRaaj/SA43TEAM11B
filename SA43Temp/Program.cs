using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryManagementSystem.Controller;

namespace SA43Temp
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
          

            LoginController logIn = new LoginController();
           // logIn.ShowLogInScreen();
            
            Application.Run(logIn.FormLogIn);
        }
    }
}
