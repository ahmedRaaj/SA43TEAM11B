using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SA43Temp.Controller;
using SA43Temp.Dao;

namespace SA43Temp.UI
{
    public partial class FormManageMembers : SA43Temp.UI.FormManageItemsTemplate
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
    }
}
