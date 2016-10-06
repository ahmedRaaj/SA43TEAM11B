using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryManagementSystem.Controller;

namespace LibraryManagementSystem.UI
{
    public partial class FormManageMembers : LibraryManagementSystem.UI.FormManageItemsTemplate
    {
      public MemberContoller MemberController { get; set; }
        public FormManageMembers()
        {
            InitializeComponent();
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
    }
}
