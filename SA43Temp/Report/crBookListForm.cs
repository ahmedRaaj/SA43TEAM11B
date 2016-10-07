using LibraryManagementSystem.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Report
{
    public partial class crBookListForm : Form
    {
        public crBookListForm()
        {
            InitializeComponent();
        }

        private void crBookListForm_Load(object sender, EventArgs e)
        {
            crBookList crBooks = new crBookList();
            SA43TEAM11BEntities ct = new SA43TEAM11BEntities();
            crBooks.SetDataSource(ct.Books);
            crystalReportViewer1.ReportSource = crBooks;
        }
    }
}
