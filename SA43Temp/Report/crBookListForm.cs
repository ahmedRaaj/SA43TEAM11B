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
using LibraryManagementSystem.Util;

namespace LibraryManagementSystem.Report
{
    public partial class CRBookListForm : Form
    {
        public CRBookListForm()
        {
            InitializeComponent();
        }

        private void CRBookListForm_Load(object sender, EventArgs e)
        {
            BookDao dao = new BookDao();
            crBookList bReport = new crBookList();
            bReport.SetDataSource( dao.BookList);
            crystalReportViewer1.ReportSource = bReport;
        }
    }
}
