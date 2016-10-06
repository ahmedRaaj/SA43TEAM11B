using LibraryManagementSystem.Controller;
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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            CategoryController catCon = new CategoryController();
            catCon.ShowManageCategoryForm();
        }

        private void btnManagePulishers_Click(object sender, EventArgs e)
        {
            PublisherController pubCon = new PublisherController();
            pubCon.ShowManagePublisherForm();
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            MemberContoller memCon = new MemberContoller();
            memCon.ShowManageMeberForm();
           
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            BookController bookController = new BookController();
            bookController.ShowManageBookForm();
        }
    }
}
