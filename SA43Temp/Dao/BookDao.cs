using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dao
{
    public class BookDao : AbstaractDao<Book>
    {
        public override DbSet getDataSet()
        {
          return  ct.Books;
        }

        public DbSet<Book> BookList { get { return ct.Books; } }

        public void UpdateBookStatus(int bookID, string bookStatus)
        {
            Book book = ct.Books.Where(b => b.BookID == bookID).ToList().FirstOrDefault();
            book.Status = bookStatus;
            ct.SaveChanges();
        }
    }
}
