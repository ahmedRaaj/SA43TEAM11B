using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Dao;

namespace LibraryManagementSystem.UI
{
    public partial class FormManageEmployee : LibraryManagementSystem.UI.FormManageItemsTemplate
    {
        public EmployeeController EmployeeController { get; private set; }

        public FormManageEmployee()
        {
            InitializeComponent();
        }

        public FormManageEmployee(EmployeeController employeeController) : this()
        {
            this.EmployeeController = employeeController;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            EmployeeController.InitiateCrud(true);
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeController.InitiateCrud(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee em = dgv.SelectedRows[0].DataBoundItem as Employee;
            EmployeeController.DeleteEmployee(em.EmployeeID);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            EmployeeController.InitiateCrud(false);
            EmployeeController.FormCrud.DisableItemsForView();
        }
    }
}
