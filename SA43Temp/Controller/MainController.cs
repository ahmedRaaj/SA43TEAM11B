using SA43Temp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Temp.Controller
{
    public class MainController
    {
        public FormMainWindow FormMainWindow { get; set; }

        public MainController()
        {
            FormMainWindow = new FormMainWindow();
        }



    }
}
