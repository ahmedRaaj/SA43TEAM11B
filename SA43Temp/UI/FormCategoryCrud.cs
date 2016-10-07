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

namespace SA43Temp.UI
{
    public partial class FormCategoryCrud : Form
    {
        private CategoryController categoryController;
        private int catID ;
        private bool creat;
        public FormCategoryCrud()
        {
            InitializeComponent();
        }
        public FormCategoryCrud(CategoryController categoryController,bool creat):this()
        {
            this.categoryController = categoryController;
            this.creat = creat;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string details = tbCategoryDetails.Text;
            string name = tbCategoryName.Text;

            if (this.creat)
            {
                if (!categoryController.SaveCategory(name, details))
                {
                    MessageBox.Show("unsuccesful");

                }

            }
            else
            {
                if (!categoryController.UpdateCategory(this.catID, name, details))
                {

                    MessageBox.Show("unsuccesful");
                }

            }

            this.Close();
            categoryController.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateFields(int catID,string catName,string catDetails)
        {
            tbCategoryDetails.Text = catDetails;
            tbCategoryName.Text = catName;
            this.catID = catID;
        }
    }
}
