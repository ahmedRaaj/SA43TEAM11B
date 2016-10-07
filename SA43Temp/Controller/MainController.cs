using LibraryManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Controller
{
    public class MainController
    {
        public FormMainWindow FormMainWindow { get; set; }

        public MainController()
        {
            FormMainWindow = new FormMainWindow();
        }

        public void ShowMainWindow()
        {
            FormMainWindow.Show();
        }

    }
}
