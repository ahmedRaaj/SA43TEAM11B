using LibraryManagementSystem.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            CRBookListForm crfrom = new CRBookListForm();
            crfrom.Show();
        }
    }
}
