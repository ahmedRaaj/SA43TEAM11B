using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Controller;

namespace LibraryManagementSystem.UI
{
    public partial class FormManageEmployee : LibraryManagementSystem.UI.FormManageItemsTemplate
    {
        public EmployeeController EmployeeController { get; private set; }

        public FormManageEmployee()
        {
            InitializeComponent();
        }

        public FormManageEmployee(EmployeeController employeeController)
        {
            this.EmployeeController = employeeController;
        }
    }
}
