namespace LibraryManagementSystem.UI
{
    partial class FormMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAdminManage = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnRetrun = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Location = new System.Drawing.Point(255, 56);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(850, 637);
            this.pnlMain.TabIndex = 1;
            // 
            // btnAdminManage
            // 
            this.btnAdminManage.AutoSize = true;
            this.btnAdminManage.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAdminManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdminManage.Location = new System.Drawing.Point(28, 212);
            this.btnAdminManage.Margin = new System.Windows.Forms.Padding(34, 3, 4, 3);
            this.btnAdminManage.Name = "btnAdminManage";
            this.btnAdminManage.Size = new System.Drawing.Size(168, 64);
            this.btnAdminManage.TabIndex = 2;
            this.btnAdminManage.Text = "Admin Manage";
            this.btnAdminManage.UseVisualStyleBackColor = false;
            this.btnAdminManage.Click += new System.EventHandler(this.btnAdminManage_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBorrow.Location = new System.Drawing.Point(28, 319);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(168, 64);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnRetrun
            // 
            this.btnRetrun.BackColor = System.Drawing.Color.BurlyWood;
            this.btnRetrun.Location = new System.Drawing.Point(28, 426);
            this.btnRetrun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRetrun.Name = "btnRetrun";
            this.btnRetrun.Size = new System.Drawing.Size(168, 64);
            this.btnRetrun.TabIndex = 4;
            this.btnRetrun.Text = "Return";
            this.btnRetrun.UseVisualStyleBackColor = false;
            this.btnRetrun.Click += new System.EventHandler(this.btnRetrun_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMain.Location = new System.Drawing.Point(28, 105);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(168, 64);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.borrowToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.bookCategoryToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.supplierToolStripMenuItem.Text = "Publisher";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click_1);
            // 
            // bookCategoryToolStripMenuItem
            // 
            this.bookCategoryToolStripMenuItem.Name = "bookCategoryToolStripMenuItem";
            this.bookCategoryToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.bookCategoryToolStripMenuItem.Text = "Book Category";
            this.bookCategoryToolStripMenuItem.Click += new System.EventHandler(this.bookCategoryToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.bookCategoriesToolStripMenuItem,
            this.publishersToolStripMenuItem,
            this.membersToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // bookCategoriesToolStripMenuItem
            // 
            this.bookCategoriesToolStripMenuItem.Name = "bookCategoriesToolStripMenuItem";
            this.bookCategoriesToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.bookCategoriesToolStripMenuItem.Text = "Book Categories";
            this.bookCategoriesToolStripMenuItem.Click += new System.EventHandler(this.bookCategoriesToolStripMenuItem_Click);
            // 
            // publishersToolStripMenuItem
            // 
            this.publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
            this.publishersToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.publishersToolStripMenuItem.Text = "Publishers";
            this.publishersToolStripMenuItem.Click += new System.EventHandler(this.publishersToolStripMenuItem_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem1,
            this.returnToolStripMenuItem});
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.borrowToolStripMenuItem.Text = "Library";
            // 
            // borrowToolStripMenuItem1
            // 
            this.borrowToolStripMenuItem1.Name = "borrowToolStripMenuItem1";
            this.borrowToolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
            this.borrowToolStripMenuItem1.Text = "Borrow";
            this.borrowToolStripMenuItem1.Click += new System.EventHandler(this.borrowToolStripMenuItem1_Click_1);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click_1);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.BurlyWood;
            this.btnReport.Location = new System.Drawing.Point(28, 533);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(168, 64);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1209, 688);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRetrun);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnAdminManage);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Library System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAdminManage;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnRetrun;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
    }
}

