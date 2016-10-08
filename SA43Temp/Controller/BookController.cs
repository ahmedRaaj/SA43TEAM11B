using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.UI;
using LibraryManagementSystem.Dao;
namespace LibraryManagementSystem.Controller
{
    public class BookController
    {

        public FormManageBooks FormManageBook { get; private set; }
        public BookCrud FormBookCrud { get; private set; }

        private BookDao bookDao = new BookDao();

        private List<Book> _bookList;
        private BorrowingController borrowingController;

        public List<Book> BookList
        {
            get
            {
                if (_bookList == null) _bookList = bookDao.BookList.ToList();
                return _bookList;
            }
        }

        public List<Book> BookSelectedFromList { get; internal set; }

        public BookController()
        {
            FormManageBook = new FormManageBooks(this);
            FormManageBook.cmbSearchType.DataSource = new string[] { "ID", "BookName", "Details" };

        }

        public BookController(BorrowingController borrowingController):this()
        {
            this.borrowingController = borrowingController;
            FormManageBook.gbCrud.Dispose();
            FormManageBook.btnSelect.Visible = true;
            FormManageBook.dgv.MultiSelect = true;
        }

        public void InitiateCrud(bool create)
        {
            FormBookCrud = new BookCrud(this,create);
            if (!create) // called for editing
            {
                Book b = FormManageBook.dgv.SelectedRows[0].DataBoundItem as Book;
                if (b != null)
                    FormBookCrud.UpdateFields(b.BookID, b.BookName, b.Authors, b.ISBN, b.LocationDetails, b.Category.ToString(), b.Publisher.ToString(), b.Status);
                else
                    return;
                
            }

            FormBookCrud.Show();
        }

        public void ShowManageBookForm()
        {

            FormManageBook.ShowDialog();
        }

        public void Filter(string searchType, string keywords)
        {
            if (keywords == null || keywords == "" || keywords == " ")
            {
                FormManageBook.ShowMessage("Please input the keyword");
                return;
            }

            if (searchType.Equals("ID"))
            {
                int ID = Convert.ToInt32(keywords);
                _bookList = _bookList.Where(b => b.BookID == ID).ToList();
                
            }
            else if (searchType.Equals("BookName"))
            {
                _bookList = _bookList.Where(b => b.BookName.Contains(keywords)).ToList();
            }
            FormManageBook.dgv.DataSource = null;
            FormManageBook.dgv.DataSource = _bookList;


        }
        public void Refresh()
        {
            this._bookList = null;
            FormManageBook.dgv.DataSource = null;
            FormManageBook.dgv.DataSource = BookList;
        }

        public bool SaveBook(string bookName,int categoryID,int publisherID,string authors,string isbn,string locationDetails)
        {
            Book book = new Book();
            book.BookName = bookName;
            book.CategoryID = categoryID;
            book.PublisherID = publisherID;
            book.Authors = authors;
            book.ISBN = isbn;
            book.LocationDetails = locationDetails;

            book.Status = "Available";
            book.CreatedDate = DateTime.Now.Date;
            bookDao.Add(book);
            if (book.BookID != null)
                return true;
            else
                return false;
        }

        internal void SetBooksForBorrowing()
        {
            if(BookSelectedFromList.Count > 0)
            {
                foreach (Book b in BookSelectedFromList)
                {
                    borrowingController.AddForBorrow(b.BookID);
                   // borrowingController.BorrowBookList.Add(b);
                }
               
            }
        }

        public bool UpdateBook(int bookID, string bookName, int categoryID, int publisherID, string authors, string isbn, string locationDetails,string status)
        {
            Book b = bookDao.BookList.Where(book => book.BookID == bookID).ToList().FirstOrDefault();
            if(b != null)
            {
                b.BookName = bookName;
                b.CategoryID = categoryID;
                b.PublisherID = publisherID;
                b.Authors = authors;
                b.ISBN = isbn;
                b.LocationDetails = locationDetails;

                b.Status = status;
                bookDao.ct.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteBook(int bookID)
        {
            Book b = bookDao.BookList.Where(book => book.BookID == bookID).ToList().FirstOrDefault();
            if (b != null)
            {
                
                bookDao.ct.Books.Remove(b);
                bookDao.ct.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
