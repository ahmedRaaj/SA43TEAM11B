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
using System.Windows;

namespace LibraryManagementSystem.UI
{
    public partial class FormMainWindow : Form
    {
        private MainController mainController;
        SystemInformation p;
        public FormMainWindow()
        {
            InitializeComponent();
            // this.pnlMain.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.SuspendLayout();
            this.Size = new System.Drawing.Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
            this.pnlMain.MinimumSize = new System.Drawing.Size(this.Bounds.Width - 200, this.Bounds.Height-100);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        public FormMainWindow(MainController controller): this()
        {
            this.mainController = controller;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //FormLogIn lgf = new FormLogIn();
            //lgf.TopLevel = false;
            //lgf.FormBorderStyle = FormBorderStyle.None;
            //panel1.Controls.Add(lgf);
            //MessageBox.Show(panel1.Controls.Count.ToString());

            //lgf.Show();


            //SA43TEAM11BEntities ct = new SA43TEAM11BEntities();
            //Category cat = new Category();
            //cat.CategoryName = "Insane";
            //cat.Details = "No Idea";
            //CategoryController con = new CategoryController();
            //con.Add(cat);

            //MessageBox.Show(cat.CategoryID.ToString());


            //CategoryController cat = new CategoryController();
            //cat.ShowManageCategoryForm();
        }

        private void btnAdminManage_Click(object sender, EventArgs e)
        {
            if (pnlMain.Controls.Count == 1)
            {
                pnlMain.Controls.Remove(pnlMain.Controls[0]);
                //pnlMain.Controls[0].Dispose();
            }
            
            FormAdmin lgf = new FormAdmin();
            lgf.TopLevel = false;
            lgf.FormBorderStyle = FormBorderStyle.None;
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
          
            pnlMain.SuspendLayout();

            lgf.Dock = DockStyle.Fill;
            lgf.AutoSize = true;
            pnlMain.Controls.Add(lgf);

            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();

            lgf.Show();

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

            if (pnlMain.Controls.Count == 1)
            {
                pnlMain.Controls.Remove(pnlMain.Controls[0]);
                //pnlMain.Controls[0].Dispose();
            }
            BorrowingController brrControl = new BorrowingController();
            brrControl.FormBorrow.TopLevel = false;
            brrControl.FormBorrow.FormBorderStyle = FormBorderStyle.None;


            pnlMain.SuspendLayout();

            brrControl.FormBorrow.Dock = DockStyle.Fill;
            brrControl.FormBorrow.AutoSize = true;
            pnlMain.Controls.Add(brrControl.FormBorrow);

            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            brrControl.ShowBorrowForm();



        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (pnlMain.Controls.Count == 1)
            {
                pnlMain.Controls.Remove(pnlMain.Controls[0]);
                //pnlMain.Controls[0].Dispose();
            }
        }
    }
}
