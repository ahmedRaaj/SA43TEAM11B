using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Dao;
using LibraryManagementSystem.UI;
using LibraryManagementSystem.Util;

namespace LibraryManagementSystem.Controller
{
    public class EmployeeController
    {
        public FormManageEmployee FormManageEmp { get; set; }
        private EmployeeDao empDao = new EmployeeDao();
        private List<Employee> _empList;
        public FormEmployeeCrud FormCrud { get; private set; }
        public List<Employee> Employees {
            get
            {
                if (_empList == null) _empList = empDao.Employees.ToList();
                return _empList;
            }
        }

        public EmployeeController()
        {
            FormManageEmp = new FormManageEmployee(this);
            FormManageEmp.dgv.DataSource = Employees;
        }

        public void InitiateCrud(bool creat)
        {
             FormCrud = new FormEmployeeCrud(this,creat);
            if (!creat)
            {
              Employee e =  FormManageEmp.dgv.SelectedRows[0].DataBoundItem as Employee;
              FormCrud.UpdateFields(e.EmployeeID, e.EmployeeName, e.Email, e.Role, e.UserName, e.Password);
            }
            FormCrud.Show();
        }

        public void DeleteEmployee(int employeeID)
        {
            try
            {
              Employee em =     empDao.Employees.Where(e=>e.EmployeeID == employeeID).ToList().FirstOrDefault();
              if(em != null)
                {
                    empDao.ct.Employees.Remove(em);
                    empDao.ct.SaveChanges();
                    FormManageEmp.ShowMessage("Delteted");
                    Refresh();
                }
                else
                {
                    FormManageEmp.ShowMessage("Employee not found");

                }
            }
            catch (Exception)
            {
                FormManageEmp.ShowMessage("Can not Delete");

            }
        }

        public void ShowManageEmpForm()
        {
            FormManageEmp.ShowDialog();
        }

        public void CreateNewEmployee(string empName, string email, string role, string userName, string passwrod)
        {
            try
            {
                Employee em = new Employee();
                em.EmployeeName = empName;
                em.Email = email;
                em.Role = role;
                em.UserName = userName;
                em.Password = passwrod;
                empDao.Add(em);
                Refresh();

            }
            catch (Exception ex)
            {
                FormCrud.ShowMessage("Unable to Create");
            }
            finally
            {
                FormCrud.Dispose();
            }
        }

        public void UpdateEmployee(int empployeeID, string empName, string email, string role, string userName, string passwrod)
        {
            try
            {
                Employee em = empDao.ct.Employees.Where(e => e.EmployeeID == empployeeID).ToList().FirstOrDefault();
                if(em != null)
                {
                    em.EmployeeName = empName;
                    em.Email = email;
                    em.Role = role;
                    em.UserName = userName;
                    em.Password = passwrod;
                    empDao.ct.SaveChanges();
                    Refresh();
                }
                else
                {
                    FormCrud.ShowMessage("Employee not Found");
                }

            }
            catch (Exception ex)
            {

                FormCrud.ShowMessage("Unable to Update");
            }
            finally
            {
                FormCrud.Dispose();
            }

        }

        public void Refresh()
        {
            this._empList = null;
            FormManageEmp.dgv.DataSource = null;
            FormManageEmp.dgv.DataSource = Employees;

        }
    }
}
