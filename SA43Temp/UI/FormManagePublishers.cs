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
    public partial class FormManagePublishers : LibraryManagementSystem.UI.FormManageItemsTemplate
    {
        public PublisherController   PublisherController { get; set; }
        public FormManagePublishers()
        {
            InitializeComponent();
        }

        public FormManagePublishers(PublisherController controller) : this(){
            PublisherController = controller;
            dgv.DataSource = controller.CategoryList;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            PublisherController.Filter(cmbSearchType.SelectedItem as string, txbKeyword.Text);
            dgv.DataSource = PublisherController.CategoryList;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PublisherController.Refresh();
            dgv.DataSource = PublisherController.CategoryList;
        }
    }
}
