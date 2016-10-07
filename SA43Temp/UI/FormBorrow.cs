using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA43Temp.Controller;
using SA43Temp.Dao;

namespace SA43Temp.UI
{
    public partial class FormBorrow : Form
    {
        public BorrowingController BorrowingController { get; set; }

        public FormBorrow()
        {
            InitializeComponent();
            this.gbBooksInformation.Visible = false;
            this.cmbMemberScanType.DataSource = new string[] { "MemberID", "MemberName"};
        }

        public FormBorrow(BorrowingController controler) : this()
        {
            BorrowingController = controler;
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (tbMemberScan.Text == null || tbMemberScan.Text.Equals(""))
            {
                MessageBox.Show("Enter the member information");
                return;
            }
            string type = cmbMemberScanType.SelectedValue as string;
          

            if (type.Equals("MemberID"))
            {
                int id = Convert.ToInt32(tbMemberScan.Text);
                BorrowingController.SetMember(id);
            }
            else if (type.Equals("MemberName"))
            {
                BorrowingController.SetMember(tbMemberScan.Text);
            }
            

           if(BorrowingController.Member != null)
            {
                gbBooksInformation.Visible = true;
                tbMemberName.Text = BorrowingController.Member.MemberName;
            }
            else
            {
                gbBooksInformation.Visible = false;
                tbMemberName.Text = "";
                MessageBox.Show("Member Not Found");
            }

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32( tbBookScan.Text);
            BorrowingController.AddForBorrow(id);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BorrowingController.ConfirmBorrowing();
        }
    }
}
