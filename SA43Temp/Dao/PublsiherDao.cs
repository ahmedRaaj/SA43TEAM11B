using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dao
{
    public class PublisherDao : AbstaractDao<Publisher>
    {

        public override DbSet getDataSet()
        {
            return ct.Publishers;
        }

        public DbSet<Publisher> Publishers
        {
            get
            {
                return ct.Publishers;
            }
        }
    }
}
