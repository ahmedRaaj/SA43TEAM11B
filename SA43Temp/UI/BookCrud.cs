using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Dao;
using LibraryManagementSystem.Util;

namespace LibraryManagementSystem.UI
{
    public partial class BookCrud : Form
    {
        private BookController bookController;
        private bool create;
        private CategoryDao catDao = new CategoryDao();
        private PublisherDao pubDao = new PublisherDao();
        private int bookId;

        public BookCrud()
        {
            InitializeComponent();
        }

        public BookCrud(BookController bookController,bool create):this()
        {
            this.bookController = bookController;
            this.create = create;
            this.cbCategory.DataSource = catDao.Categories.ToList();
            this.cbPublisher.DataSource = pubDao.Publishers.ToList();
            this.cbStatus.DataSource = new string[] { BookStatus.OnRent.ToString(),BookStatus.Available.ToString(),BookStatus.NotAvailable.ToString() };
        }

        public void UpdateFields(int bookId,string bookName,string author,string isbn,string locationDetails,string catString,string pubString,string bookStatus)
        {
            this.bookId = bookId;
            tbBookName.Text = bookName;
            tbAuthor.Text = author;
            tbISBN.Text = isbn;
            tbLocationDeatail.Text = locationDetails;
            cbCategory.SelectedItem = catString;
            cbPublisher.SelectedItem = pubString;
            cbStatus.SelectedItem = bookStatus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string author = tbAuthor.Text;
            string bName = tbBookName.Text;
            string isbn = tbISBN.Text;
            string details = tbLocationDeatail.Text;
            Publisher pub = cbPublisher.SelectedItem as Publisher;
            Category cat =  cbCategory.SelectedItem as Category;
          string status =  cbStatus.SelectedItem as string;

            if (create) //creating new Entity
            {
              if(  bookController.SaveBook(bName, cat.CategoryID, pub.PublisherID, author, isbn, details))
                {
                    this.Close();
                    bookController.Refresh();
                    MessageBox.Show("Success");
                   
                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }
            else
            {
                if (bookController.UpdateBook(this.bookId,bName, cat.CategoryID, pub.PublisherID, author, isbn, details,status))
                {
                    this.Close();
                    bookController.Refresh();
                    MessageBox.Show("Success");

                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisableItemsForView()
        {
            this.tbAuthor.Enabled = false;
            this.tbBookName.Enabled = false;
            this.tbISBN.Enabled = false;
            this.tbLocationDeatail.Enabled = false;
            this.cbCategory.Enabled = false;
            this.cbPublisher.Enabled = false;
            this.cbStatus.Enabled = false;
            this.dtpCreatedate.Enabled = false;
            


            this.btnSave.Visible = false;
        }
    }
}
