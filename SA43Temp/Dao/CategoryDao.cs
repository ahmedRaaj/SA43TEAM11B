using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dao
{
    public class CategoryDao : AbstaractDao<Category>
    {

        public override DbSet getDataSet()
        {
           return ct.Categories;
        }

        public DbSet<Category> Categories
        {
            get
            {
                return ct.Categories;
            }
        }
    }
}
