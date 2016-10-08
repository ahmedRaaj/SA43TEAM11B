using LibraryManagementSystem.Util;
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
using LibraryManagementSystem.Util;
using LibraryManagementSystem.Dao;

namespace LibraryManagementSystem.UI
{
    public partial class FormEmployeeCrud : Form
    {
        private int empployeeID;
        public EmployeeController EmployeeController { get; set; }
        private bool create;

        public FormEmployeeCrud()
        {
            InitializeComponent();
            cmbRole.DataSource = new string[] { EmployeeRole.Manager.ToString(), EmployeeRole.Staff.ToString() };
        }
        public FormEmployeeCrud(EmployeeController empController,bool creat):this()
        {
            EmployeeController = empController;
            this.create = creat;
        }

        public void UpdateFields(int employeeID, string employeeName, string email, string role, string userName, string password)
        {
            tbEmail.Text = email;
            tbEmployeeName.Text = employeeName;
            tbPassword.Text = password;
            tbUserName.Text = userName;
            cmbRole.SelectedItem = role;
            this.empployeeID = employeeID;
            
        }

        internal void ShowMessage(string v)
        {
            MessageBox.Show(v);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string empName = tbEmployeeName.Text;
            string passwrod = tbPassword.Text;
            string userName = tbUserName.Text;
            string role = cmbRole.SelectedItem as string;
            if (create)
            {
                EmployeeController.CreateNewEmployee(empName, email, role, userName, passwrod);

            }
            else
            {
                EmployeeController.UpdateEmployee(empployeeID, empName, email, role, userName, passwrod);

                
            }
          
        }

        public void DisableItemsForView()
        {
            this.tbEmail.Enabled = false;
            this.tbEmployeeName.Enabled = false;
            this.tbPassword.Enabled = false;
            this.tbUserName.Enabled = false;
            this.cmbRole.Enabled = false;
            this.btnSave.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
