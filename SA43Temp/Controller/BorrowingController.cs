﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.UI;
using LibraryManagementSystem.Dao;
using System.Windows.Forms;

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

        public void AddForBorrow(Book b)
        {
            if(this.Member != null)
            {
                BorrowBookList.Add(b);
            }
        }
        public void AddForBorrow(int id)
        {

          Book book  =  bookDao.BookList.Where(b => b.BookID == id).ToList().FirstOrDefault();
          if(book != null)
            {
                BorrowBookList.Add(book);
                FormBorrow.dgBorrowBooks.DataSource = null;
                FormBorrow.dgBorrowBooks.DataSource = BorrowBookList.ToList();
           
            }
            else
            {
                FormBorrow.ShowMessage("No Book found");
            }
          
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
                this.Member = null;
                this._borrowBookList = null;
                this.FormBorrow.Close();
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
