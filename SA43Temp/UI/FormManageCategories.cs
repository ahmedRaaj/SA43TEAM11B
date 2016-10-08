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
    public partial class FormManageCategories : LibraryManagementSystem.UI.FormManageItemsTemplate
    {
        public CategoryController CategoryController { get; set; }
        public FormManageCategories()
        {
            InitializeComponent();
            this.dgv.DataSourceChanged += DgvCategorySourceChanged;
        }

        public void DgvCategorySourceChanged(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                this.dgv.Columns["CategoryID"].Visible = false;
                this.dgv.Columns["Books"].Visible = false;
                //MessageBox.Show("gd changed");
            }

        }

        public FormManageCategories(CategoryController con) : this()
        {
            CategoryController = con;
            dgv.DataSource = CategoryController.CategoryList;
        }

       

        public void btnFilter_Click(object sender, EventArgs e)
        {
            CategoryController.Filter(cmbSearchType.SelectedItem as string, txbKeyword.Text);
            dgv.DataSource = CategoryController.CategoryList;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CategoryController.Reset();
            dgv.DataSource = CategoryController.CategoryList;
        }

        public void btnDetails_Click(object sender, EventArgs e)
        {
            CategoryController.InitiateCrud(false);
            CategoryController.FormCategoryCrud.DisableItemsForView();
        }



        public void btnCreateNew_Click(object sender, EventArgs e)
        {
            CategoryController.InitiateCrud(true);
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            CategoryController.InitiateCrud(false);
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            Category b = dgv.SelectedRows[0].DataBoundItem as Category;
            if (CategoryController.DeleteCategory(b.CategoryID))
            {
                MessageBox.Show("Success");
                CategoryController.Refresh();
            }
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
