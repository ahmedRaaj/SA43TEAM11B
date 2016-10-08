using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Dao;

namespace LibraryManagementSystem.UI
{
    public partial class FormManageBooks : FormManageItemsTemplate
    {
        public BookController BookController { get; set; }
        public FormManageBooks(BookController controller): this()
        {
            BookController = controller;
            dgv.DataSource = controller.BookList;
        }
        public FormManageBooks()
        {
            InitializeComponent();
            this.dgv.DataSourceChanged += dgvBooksSourceChanged;
        }

        private void dgvBooksSourceChanged(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                this.dgv.Columns["CategoryID"].Visible = false;
                this.dgv.Columns["PublisherID"].Visible = false;
                this.dgv.Columns["BorrowingDetails"].Visible = false;
                this.dgv.Columns["BookCopy"].Visible = false;

            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            BookController.InitiateCrud(true); //creating new by sending create boolean true;
            BookController.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BookController.InitiateCrud(false); //editing by sending create boolean false
            BookController.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book b =  dgv.SelectedRows[0].DataBoundItem as Book;
           if(BookController.DeleteBook(b.BookID))
            {
                MessageBox.Show("Success");
                BookController.Refresh();
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BookController.Refresh();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           BookController.Filter(cmbSearchType.SelectedItem as string, txbKeyword.Text);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            BookController.InitiateCrud(false);
            BookController.FormBookCrud.DisableItemsForView();
        }
    }
}
