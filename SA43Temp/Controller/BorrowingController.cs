using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.UI;
using LibraryManagementSystem.Dao;
using System.Windows.Forms;
using LibraryManagementSystem.Util;

namespace LibraryManagementSystem.Controller
{
   public class BorrowingController
    {
        private HashSet<Book> _borrowBookList;
        public Member Member { get; private set; }
        public HashSet<Book> BorrowBookList
        {
            get
            { if (_borrowBookList == null) _borrowBookList = new HashSet<Book>();
                return _borrowBookList;
            }
           
        }
        public FormBorrow FormBorrow { get; private set; }

        private MemberDao memberDao = new MemberDao();
        private BookDao bookDao = new BookDao();
        private BorrowingDetailsDao brrDetailsDao = new BorrowingDetailsDao();

        public BorrowingController()
        {
          
            FormBorrow = new FormBorrow(this);
            
        }

        public void ShowBorrowForm()
        {
            FormBorrow.Show();
        }

        public bool SetMember(int memberID)
        {
            Member member = memberDao.ct.Members.Where(m => m.MemberID == memberID).ToList().FirstOrDefault();
           
            if (member != null)
            {
                Member = member;
                return true;
            }
            else
            {
                Member = null;
                return false;
            }

           
        }

        public bool SetMember(string name)
        {
            Member member = memberDao.ct.Members.Where(m => m.MemberName.Equals(name)).ToList().FirstOrDefault();
            if (member != null)
            {
                Member = member;
                return true;
            }
            else
            {
                Member = null;
                return false;
            }
        }

        internal void GetMemberForMemberListForm()
        {
            MemberContoller memControl = new MemberContoller(this);
            memControl.FormManageMember.btnSelect.Visible = true;
            
            memControl.FormManageMember.gbCrud.Dispose();
           
            memControl.ShowManageMeberForm();

        }

        public void AddForBorrow(Book b)
        {
            if(this.Member != null)
            {
                BorrowBookList.Add(b);
            }
        }
        public void AddForBorrow(int id)
        {
           if( bookDao.ct.Books.Find(id) == null)
            {
                FormBorrow.ShowMessage("This book is not belongs to Our System");
                return;
            }

            Book book  =  bookDao.ct.Books.Where(b => b.BookID == id && b.Status.Equals(BookStatus.Available.ToString())).ToList().FirstOrDefault();
          if(book != null)
            {
                if (book.Status.Equals(BookStatus.Available.ToString()))
                {
                    BorrowBookList.Add(book);
                    FormBorrow.dgBorrowBooks.DataSource = null;
                    FormBorrow.dgBorrowBooks.DataSource = BorrowBookList.ToList();
                }
                else
                {
                    FormBorrow.ShowMessage("This Book is Already OnRent, Return The Book First");
                }
               
           
            }
            else
            {
                FormBorrow.ShowMessage("This Book is Already OnRent, Return The Book First");
            }
          
        }

        internal void SetMemberFromList(int memberID)
        {
             Member = memberDao.ct.Members.Where(m => m.MemberID == memberID).ToList().FirstOrDefault();
             if(Member != null)
            {
                FormBorrow.tbMemberName.Text = Member.MemberName;
                FormBorrow.gbBooksInformation.Visible = true;
            }
          
        }

        internal void GetBooksFromBookListForm()
        {
            BookController con = new BookController(this);
            con.ShowManageBookForm();
        }

        public void Reset()
        {
            this.Member = null;
            this._borrowBookList = null;
           
            FormBorrow.gbBooksInformation.Visible = false;
            FormBorrow.dgBorrowBooks.DataSource = null;
            FormBorrow.tbMemberScan.Text = "";
            FormBorrow.tbBookScan.Text = "";
        }

        public void AddForBorrow(HashSet<Book> blist)
        {
            if (this.Member != null)
            {
                _borrowBookList = blist;
            }
        }

        public void ConfirmBorrowing()
        {
            if (this.Member != null && this.BorrowBookList.Count > 0)
            {
                brrDetailsDao.BorrowBooks(this.Member, this.BorrowBookList);
               
            }
            else
            {
                FormBorrow.ShowMessage("Please chose the books to borrow ");
            }
        }

        public void ResetBookList()
        {
            _borrowBookList = null;
        }


    }
}
