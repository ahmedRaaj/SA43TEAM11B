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
    public partial class FormManageMembers : FormManageItemsTemplate
    {
        public MemberContoller MemberController { get; set; }
        public FormManageMembers()
        {
            InitializeComponent();
            this.dgv.DataSourceChanged += dgvMemberSourceChange;
        }

        private void dgvMemberSourceChange(object sender, EventArgs e)
        {
 
            //  throw new NotImplementedException(); todo
            if (this.dgv.DataSource != null)
            {
                 this.dgv.Columns["MemberID"].Visible=false;
                this.dgv.Columns["BorrowingDetails"].Visible = false;
                //this.dgv.Columns["MemberID"].Visible = false;
            }
        }

        public FormManageMembers(MemberContoller controller) : this()
        {
            MemberController = controller;
            dgv.DataSource = MemberController.Members;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            MemberController.Filter(cmbSearchType.SelectedItem as string, txbKeyword.Text);
            dgv.DataSource = MemberController.Members;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MemberController.Reset();
            dgv.DataSource = MemberController.Members;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            MemberController.InitialCrud(true);
            MemberController.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MemberController.InitialCrud(false);
            MemberController.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Member m = dgv.SelectedRows[0].DataBoundItem as Member;
            if (MemberController.DaleteMember(m.MemberID))
            {
                MessageBox.Show("Delete Success");
                MemberController.Refresh();

            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            MemberController.InitialCrud(false);
            MemberController.FormMemerCrud.DisableItemsForView();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
          Member m =  dgv.SelectedRows[0].DataBoundItem as Member;
          MemberController.SetMemberForBorrowing(m.MemberID);
            this.Close();
        }
    }
}
