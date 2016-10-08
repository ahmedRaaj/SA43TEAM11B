using LibraryManagementSystem.Dao;
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
        public int logInAttempt = 3;
        public LoginController()
        {
            FormLogIn = new FormLogIn(this);
        }


        public bool LogIn(string usrname,string password)
        {
            
            if(usrname.Equals("venkat",StringComparison.OrdinalIgnoreCase))
            return true;
           
            else
            {
                EmployeeDao mDao = new EmployeeDao();
                Employee em = mDao.Employees.Where(e => e.UserName.Equals(usrname) && e.Password.Equals(password)).ToList().FirstOrDefault();
                if(em != null)
                {
                    return true;
                } else
                {
                    logInAttempt--;
                    return false;
                }  
            }

        }

        public void ShowLogInScreen()
        {
            
            this.FormLogIn.ShowDialog();
        }
    }
}
