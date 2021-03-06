﻿using System;
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
    public partial class FormManagePublishers :FormManageItemsTemplate
    {
        public PublisherController   PublisherController { get; set; }
        public FormManagePublishers()
        {
            InitializeComponent();
            this.dgv.DataSourceChanged += DgvPublisherSourceChanged;
        }

        private void DgvPublisherSourceChanged(object sender, EventArgs e)
        {
            /// throw new NotImplementedException();

            if (dgv.DataSource != null)
            {
                this.dgv.Columns["PublisherID"].Visible = false;
                this.dgv.Columns["Books"].Visible = false;
            }
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

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            //PublisherController
            PublisherController.InitialCrud(true);
            PublisherController.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PublisherController.InitialCrud(false);
            PublisherController.Refresh();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Publisher p = dgv.SelectedRows[0].DataBoundItem as Publisher;
            if (PublisherController.DeletePublisher(p.PublisherID))
            {
                MessageBox.Show("Delete Success");
                PublisherController.Refresh();
            }
        }

        private void FormManagePublishers_Load(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PublisherController.InitialCrud(false);
            PublisherController.FormPublisherCrud.DisableItemsForView();
        }
    }
}
