﻿using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class FormManageCategories : FormManageItemsTemplate
    {
       public CategoryController CategoryController { get; set; }
        public FormManageCategories()
        {
            InitializeComponent();
            this.dgv.DataSourceChanged += DgvCategorySourceChanged;
        }

        private void DgvCategorySourceChanged(object sender, EventArgs e)
        {
            if(dgv.DataSource != null)
            {
                this.dgv.Columns["CategoryID"].Visible = false;
                this.dgv.Columns["Books"].Visible = false;
                this.dgv.Columns["CategoryName"].Width = 150;
            }
             
        }

        public FormManageCategories(CategoryController con) : this()
        {
            CategoryController = con;
          
        }

        private void FormManageCategories_Load(object sender, EventArgs e)
        {
            dgv.DataSource = CategoryController.CategoryList;
            dgv.Columns["Books"].Visible = false;
           
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            CategoryController.Filter(cmbSearchType.SelectedItem as string, txbKeyword.Text);
            dgv.DataSource = CategoryController.CategoryList;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CategoryController.Reset();
            dgv.DataSource = CategoryController.CategoryList;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Category cat = dgv.SelectedRows[0].DataBoundItem as Category;
            MessageBox.Show(cat.CategoryID.ToString());
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            CategoryController.InitiateCrud(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CategoryController.InitiateCrud(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Category b = dgv.SelectedRows[0].DataBoundItem as Category;
            if (CategoryController.DeleteCategory(b.CategoryID))
            {
                MessageBox.Show("Success");
                CategoryController.Refresh();
            }
        }
    }
}
