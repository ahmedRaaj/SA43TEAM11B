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

namespace LibraryManagementSystem.UI
{
    public partial class FormReturnBook : Form
    {
        private ReturningController returningController;

        public FormReturnBook()
        {
            InitializeComponent();
            cbScanType.DataSource = new string[] { "BookID", "BorrowingCode" };
        }

        public FormReturnBook(ReturningController returningController) : this()
        {
            this.returningController = returningController;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string type = cbScanType.SelectedItem as string;
            if (type == null || tbScanWord.Equals("") || tbScanWord.Equals(" "))
            {
                returningController.Reset();
                MessageBox.Show("Please Enter value");
                return;
            }
            else if (type.Equals("BookID"))
            {
                try
                {
                    int bookID = Convert.ToInt32(tbScanWord.Text);
                    if (!returningController.setBook(bookID))
                    {
                        returningController.Reset();
                        MessageBox.Show("Book Not Borrowed");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Enter Correct Value");
                    return;
                }



            }
            //else if (type.Equals("BorrowingCode"))
            //{
            //    //todo
            //}
            returningController.UpdateBookDetails();
           


        }

        internal void ShowMessag(string message)
        {
            MessageBox.Show(message);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReturnBook_Click_1(object sender, EventArgs e)
        {
            returningController.ReturnBook();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
