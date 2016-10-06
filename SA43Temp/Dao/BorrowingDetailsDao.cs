using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dao
{
    public class BorrowingDetailsDao : AbstaractDao<BorrowingDetail>
    {
        public override DbSet getDataSet()
        {
            return ct.BorrowingDetails;
        }

        public DbSet<BorrowingDetail> BorrowingDetails { get { return ct.BorrowingDetails; } }


        public void BorrowBooks(Member borrower, HashSet<Book> books)
        {
            BorrowingDetail newBorrow;
            if (books != null && books.Count > 0)
            {
                foreach( Book b in books)
                {
                    newBorrow = new BorrowingDetail();
                    newBorrow.MemberID = borrower.MemberID;
                    newBorrow.BorrowDate = DateTime.Now.Date;
                    newBorrow.BorrowingStatus = "borrowed";
                    newBorrow.Fine = 0;
                    newBorrow.ReturnDate = DateTime.Now.Date.AddDays(7).Date;
                    newBorrow.Remarks = "ok";
                    newBorrow.BookID = b.BookID;
                    ct.BorrowingDetails.Add(newBorrow);
                }
                ct.SaveChanges();
                
            }
            

        }
    }
}
