namespace LibraryManagementSystem.UI
{
    partial class FormManagePublishers
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
            this.gbCrud.SuspendLayout();
            this.gbCreateEditDel.SuspendLayout();
            this.gbCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txbKeyword
            // 
            this.txbKeyword.Location = new System.Drawing.Point(117, 35);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(508, 35);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // FormManagePublishers
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(2026, 1036);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormManagePublishers";
            this.Load += new System.EventHandler(this.FormManagePublishers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCreateEditDel.ResumeLayout(false);
            this.gbCrud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
