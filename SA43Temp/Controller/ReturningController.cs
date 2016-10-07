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
  public  class ReturningController
    {
        public Book Book { get; private set; }
        public Member Member { get; set; }
        public BorrowingDetail BorrowingDetail { get; set; }
        public FormReturnBook FormRetrunBook { get; set; }

        private BookDao bookDao = new BookDao();
        private MemberDao memberDao;
        private BorrowingDetailsDao borrdDao = new BorrowingDetailsDao();


        public ReturningController()
        {
            FormRetrunBook = new FormReturnBook(this);

        }

        public void ShowReturningForm()
        {
            FormRetrunBook.gbBookDetails.Visible = false;
            FormRetrunBook.gbMemberDetails.Visible = false;
            FormRetrunBook.Show();
        }

        public bool setBook(int bookID)
        {
           Book b =  bookDao.BookList.Where(book => book.BookID == bookID && book.Status.Equals(BookStatus.OnRent.ToString()) ).ToList().FirstOrDefault();
            if(b != null)
            {
                Book = b;
                BorrowingDetail = Book.BorrowingDetails.Where(bd => bd.BookID == Book.BookID && bd.BorrowingStatus == BookStatus.OnRent.ToString()).ToList().FirstOrDefault();
                if (BorrowingDetail == null) return false;
                else
                {
                    Member = BorrowingDetail.Member;
                  //  FormRetrunBook.ShowMessag(Book.BookID + " " + BorrowingDetail.BorrowingID + " " + Member.MemberID);
                    return true;
                }
                   
            }
            return false;
        }

        public void UpdateBookDetails()
        {
            
            FormRetrunBook.tbBookName.Text = Book.BookName;
            FormRetrunBook.tbBorrowDate.Text = BorrowingDetail.BorrowDate.ToShortDateString();
            FormRetrunBook.tbISBN.Text = Book.ISBN;
            FormRetrunBook.tbReturnDate.Text = DateTime.Now.Date.ToShortDateString();
            FormRetrunBook.tbFine.Text = "555";
            FormRetrunBook.tbBookID.Text = Book.BookID.ToString();

            FormRetrunBook.tbMemberID.Text = Member.MemberID.ToString();
            FormRetrunBook.tbMemberM.Text = Member.MemberName;
            FormRetrunBook.tbRemark.Text = BorrowingDetail.Remarks;

            FormRetrunBook.gbBookDetails.Visible = true;
            FormRetrunBook.gbMemberDetails.Visible = true;
          
        }

        public void ReturnBook()
        {
            if(Member != null && Book != null && BorrowingDetail != null)
            {
                bookDao.UpdateBookStatus(Book.BookID,BookStatus.Available.ToString());
                borrdDao.UpdateBorrowingStatus(BorrowingDetail.BorrowingID, BorrowingStatus.Returned.ToString());
                FormRetrunBook.ShowMessag("Returned");
               
            }
            Reset();
        }

        public void Reset()
        {
            Member = null;
            Book = null;
            BorrowingDetail = null;
            FormRetrunBook.gbBookDetails.Visible = false;
            FormRetrunBook.gbMemberDetails.Visible = false;
            FormRetrunBook.tbScanWord.Text = "";
        }
    }



}
