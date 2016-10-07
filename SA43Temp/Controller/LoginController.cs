using LibraryManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controller
{
    
    class LoginController
    {
        public FormLogIn FormLogIn { get; set; }

        public LoginController()
        {
            FormLogIn = new FormLogIn();
        }


    }
}
