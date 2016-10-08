using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dao
{
    public class EmployeeDao : AbstaractDao<Employee>
    {
        public override DbSet getDataSet()
        {
           return ct.Employees;
        }

        public DbSet<Employee> Employees { get { return ct.Employees; }  }


    }
}
