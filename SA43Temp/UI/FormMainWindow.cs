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
using LibraryManagementSystem.Report;

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
            ShowInMainPanel(lgf);

            lgf.Show();

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

           
            BorrowingController brrControl = new BorrowingController();
            ShowInMainPanel(brrControl.FormBorrow);
            brrControl.ShowBorrowForm();



        }

        private void ShowInMainPanel(Form fromToPut)
        {
            fromToPut.TopLevel = false;
            fromToPut.FormBorderStyle = FormBorderStyle.None;

            if (pnlMain.Controls.Count == 1)
            {
                pnlMain.Controls.Remove(pnlMain.Controls[0]);
            }

            pnlMain.SuspendLayout();

            fromToPut.Dock = DockStyle.Fill;
            fromToPut.AutoSize = true;
            pnlMain.Controls.Add(fromToPut);

            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (pnlMain.Controls.Count == 1)
            {
                pnlMain.Controls.Remove(pnlMain.Controls[0]);

            }


        }

        private void btnRetrun_Click(object sender, EventArgs e)
        {
            if (pnlMain.Controls.Count == 1)
            {
                pnlMain.Controls.Remove(pnlMain.Controls[0]);
            }
            ReturningController rControll = new ReturningController();
            rControll.FormRetrunBook.TopLevel = false;
            rControll.FormRetrunBook.FormBorderStyle = FormBorderStyle.None;

            pnlMain.SuspendLayout();

            rControll.FormRetrunBook.Dock = DockStyle.Fill;
           // rControll.FormRetrunBook.AutoSize = true;
            pnlMain.Controls.Add(rControll.FormRetrunBook);

            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();

            rControll.ShowReturningForm();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookController controler = new BookController();
            controler.InitiateCrud(true);
        }

        private void bookCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryController controler = new CategoryController();
            controler.InitiateCrud(true);
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookController controler = new BookController();
            controler.ShowManageBookForm();
        }

        private void bookCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryController controler = new CategoryController();
            controler.ShowManageCategoryForm();
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherController controller = new PublisherController();
            controller.ShowManagePublisherForm();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherController control = new PublisherController();
           control.InitialCrud(true);        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberContoller control = new MemberContoller();
            control.InitialCrud(true); 
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberContoller control = new MemberContoller();
            control.ShowManageMeberForm();
        }

        private void borrowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrowingController control = new BorrowingController();
            control.ShowBorrowForm();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturningController control = new ReturningController();
            control.ShowReturningForm();
        }

        private void supplierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PublisherController control = new PublisherController();
            control.InitialCrud(true);
        }

        private void borrowToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            BorrowingController con = new BorrowingController();
            ShowInMainPanel(con.FormBorrow);
            con.FormBorrow.Show();
        }

        private void returnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ReturningController con = new ReturningController();
            ShowInMainPanel(con.FormRetrunBook);
            con.ShowReturningForm();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport formRpt = new FormReport();
            ShowInMainPanel(formRpt);
            formRpt.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

    }
}
