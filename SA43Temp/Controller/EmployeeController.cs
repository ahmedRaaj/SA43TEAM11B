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


        public void ShowManageEmpForm()
        {
            FormManageEmp.ShowDialog();
        }

    }
}
