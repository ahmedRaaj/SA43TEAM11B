using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA43Temp.Dao
{
    public class BookDao : AbstaractDao<Book>
    {
        public override DbSet getDataSet()
        {
          return  ct.Books;
        }

        public DbSet<Book> BookList { get { return ct.Books; } }

      
    }
}
