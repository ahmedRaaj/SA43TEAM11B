namespace SA43Temp.UI
{
    partial class FormAdmin
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
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManagePulishers = new System.Windows.Forms.Button();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(30, 57);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(283, 71);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnManagePulishers
            // 
            this.btnManagePulishers.Location = new System.Drawing.Point(668, 57);
            this.btnManagePulishers.Name = "btnManagePulishers";
            this.btnManagePulishers.Size = new System.Drawing.Size(283, 71);
            this.btnManagePulishers.TabIndex = 1;
            this.btnManagePulishers.Text = "Manage Publishers";
            this.btnManagePulishers.UseVisualStyleBackColor = true;
            this.btnManagePulishers.Click += new System.EventHandler(this.btnManagePulishers_Click);
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.Location = new System.Drawing.Point(338, 57);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Size = new System.Drawing.Size(283, 71);
            this.btnManageCategories.TabIndex = 2;
            this.btnManageCategories.Text = "Manage Categories";
            this.btnManageCategories.UseVisualStyleBackColor = true;
            this.btnManageCategories.Click += new System.EventHandler(this.btnManageCategories_Click);
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.Location = new System.Drawing.Point(161, 75);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(283, 71);
            this.btnManageMembers.TabIndex = 3;
            this.btnManageMembers.Text = "Mange Members";
            this.btnManageMembers.UseVisualStyleBackColor = true;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.Location = new System.Drawing.Point(491, 75);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(283, 71);
            this.btnManageEmployee.TabIndex = 4;
            this.btnManageEmployee.Text = "Manage Employee";
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnManageEmployee);
            this.groupBox1.Controls.Add(this.btnManageMembers);
            this.groupBox1.Location = new System.Drawing.Point(42, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members or Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnManageBooks);
            this.groupBox2.Controls.Add(this.btnManageCategories);
            this.groupBox2.Controls.Add(this.btnManagePulishers);
            this.groupBox2.Location = new System.Drawing.Point(42, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1081, 187);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books";
            // 
            // FormAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1158, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdmin";
            this.Text = "Managing Items";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManagePulishers;
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}