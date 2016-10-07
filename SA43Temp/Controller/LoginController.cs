using LibraryManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controller
{
    
   public class LoginController
    {
        public FormLogIn FormLogIn { get; set; }
        public int logInAttempt = 0;
        public LoginController()
        {
            FormLogIn = new FormLogIn(this);
        }


        public bool LogIn(string usrname,string password)
        {
            
            if(usrname.Equals("Sharmila"))
            return true;
            else if (usrname.Equals("Venkat") )
            {
                return true;
            }
            else
            {
                logInAttempt++;
               
                FormLogIn.ShowMessage("Please Input Correct username and password");
                return false;
            }

        }

        public void ShowLogInScreen()
        {
            
            this.FormLogIn.ShowDialog();
        }
    }
}
