using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class FormMemberCrud : Form
    {
        private MemberContoller MemberController = new MemberContoller();
        private bool create;
        private CategoryDao catDao = new CategoryDao();
        private PublisherDao pubDao = new PublisherDao();
        private MemberDao memDao = new MemberDao();
        int MemberID;
        public FormMemberCrud()
        {
            InitializeComponent();
        }

        public FormMemberCrud(MemberContoller memberContorller, bool create):this()
        {
            this.MemberController = memberContorller;
            this.create = create;
            this.cbStatus.DataSource = memDao.Members.ToList() ;

        }

        public void UpdateFields(int memberID, string memberName, string city, string address, string phone, string eMail, string membershipStatus,DateTime date)
        {
            this.MemberID = memberID;
            tbMemberName.Text = memberName;
            tbCity.Text = city;
            tbAddress.Text = address;
            tbPhone.Text = phone;
            tbEmail.Text = eMail;
            cbStatus.Text = membershipStatus;
            dpkCreationDate.Text = date.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name=tbMemberName.Text;
            string city=tbCity.Text;
            string address=tbAddress.Text;
            string email=tbEmail.Text;
            string phone=tbPhone.Text;
            string status =cbStatus.Text;
           // string date=dpkCreationDate.Text.ToString();


            if (create)
            {
                if (MemberController.SaveMember(name,city,address,phone,email ))
                {
                    this.Close();
                    MemberController.Refresh();
                    MessageBox.Show("Save success");
                }
                else
                { MessageBox.Show("Save failed"); }

            }
            else
            {
                if (MemberController.UpdateMember(MemberID, name, city, address, phone, email, status))
                {
                    this.Close();
                    MemberController.Refresh();
                    MessageBox.Show("Update success");
                }
                else
                { MessageBox.Show("Update failed"); }

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();

         }
    }
}
