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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAdminManage = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnRetrun = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Location = new System.Drawing.Point(212, 84);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(803, 588);
            this.pnlMain.TabIndex = 1;
            // 
            // btnAdminManage
            // 
            this.btnAdminManage.AutoSize = true;
            this.btnAdminManage.Location = new System.Drawing.Point(25, 217);
            this.btnAdminManage.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnAdminManage.Name = "btnAdminManage";
            this.btnAdminManage.Size = new System.Drawing.Size(152, 56);
            this.btnAdminManage.TabIndex = 2;
            this.btnAdminManage.Text = "Admin Manage";
            this.btnAdminManage.UseVisualStyleBackColor = true;
            this.btnAdminManage.Click += new System.EventHandler(this.btnAdminManage_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(25, 331);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(152, 67);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnRetrun
            // 
            this.btnRetrun.Location = new System.Drawing.Point(25, 453);
            this.btnRetrun.Name = "btnRetrun";
            this.btnRetrun.Size = new System.Drawing.Size(152, 71);
            this.btnRetrun.TabIndex = 4;
            this.btnRetrun.Text = "Return";
            this.btnRetrun.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(25, 112);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(152, 58);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 709);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRetrun);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnAdminManage);
            this.Controls.Add(this.pnlMain);
            this.Name = "FormMainWindow";
            this.Text = "Library System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAdminManage;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnRetrun;
        private System.Windows.Forms.Button btnMain;
    }
}

