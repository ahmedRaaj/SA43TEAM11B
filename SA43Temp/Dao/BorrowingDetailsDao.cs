using LibraryManagementSystem.Util;
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
                    newBorrow.BorrowingID = Guid.NewGuid();
                    newBorrow.MemberID = borrower.MemberID;
                    newBorrow.BorrowDate = DateTime.Now.Date;
                    newBorrow.BorrowingStatus = BookStatus.OnRent.ToString();
                    newBorrow.Fine = 0;
                    newBorrow.ReturnDate = DateTime.Now.Date.AddDays(7).Date;
                    newBorrow.Remarks = "ok";
                    newBorrow.BookID = b.BookID;
                    ct.BorrowingDetails.Add(newBorrow);

                    Book temp = ct.Books.Where(x => x.BookID == b.BookID).ToList().FirstOrDefault();
                    temp.Status = BookStatus.OnRent.ToString();
                    ct.SaveChanges();
                }
              

                
            }
            

        }

        public void UpdateBorrowingStatus(Guid borrowingID, string status)
        {
            BorrowingDetail d = ct.BorrowingDetails.Where(bd => bd.BorrowingID == borrowingID).ToList().FirstOrDefault();
            d.BorrowingStatus = status;
            ct.SaveChanges();
        }
    }
}
