using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Controller;

namespace LibraryManagementSystem.UI
{
    public partial class FormLogIn : Form
    {
    
        public LoginController LoginController { get; set; }

        public FormLogIn()
        {
            InitializeComponent();
        }

        public FormLogIn(LoginController loginController):this()
        {
            LoginController = loginController;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(LoginController.LogIn(this.tbUserName.Text, this.tbPassword.Text))
            {
                MainController mainController = new MainController();
                mainController.ShowMainWindow();
                this.Hide();
            }else if (LoginController.logInAttempt < 1)
            {
                this.ShowMessage("You Have Entered Maximum Time");
                this.Dispose();
            }
            else
            {
                this.ShowMessage("Wrong User Id and Password Incorrect!  You can try:  "+ LoginController.logInAttempt+" more time.");
            }
          
            
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
