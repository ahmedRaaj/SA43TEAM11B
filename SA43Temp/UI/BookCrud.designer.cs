namespace LibraryManagementSystem.UI
{
    partial class BookCrud
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbBookInformation = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.gbBookStatus = new System.Windows.Forms.GroupBox();
            this.dtpCreatedate = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.tbLocationDeatail = new System.Windows.Forms.TextBox();
            this.lblLocationDetails = new System.Windows.Forms.Label();
            this.gbBookInformation.SuspendLayout();
            this.gbBookStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(682, 642);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(840, 642);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbBookInformation
            // 
            this.gbBookInformation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbBookInformation.Controls.Add(this.cbCategory);
            this.gbBookInformation.Controls.Add(this.lblISBN);
            this.gbBookInformation.Controls.Add(this.tbISBN);
            this.gbBookInformation.Controls.Add(this.lblCategory);
            this.gbBookInformation.Controls.Add(this.cbPublisher);
            this.gbBookInformation.Controls.Add(this.lblPublisher);
            this.gbBookInformation.Controls.Add(this.tbBookName);
            this.gbBookInformation.Controls.Add(this.lblAuthor);
            this.gbBookInformation.Controls.Add(this.tbAuthor);
            this.gbBookInformation.Controls.Add(this.lblBookName);
            this.gbBookInformation.Location = new System.Drawing.Point(18, 18);
            this.gbBookInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookInformation.Name = "gbBookInformation";
            this.gbBookInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookInformation.Size = new System.Drawing.Size(934, 301);
            this.gbBookInformation.TabIndex = 8;
            this.gbBookInformation.TabStop = false;
            this.gbBookInformation.Text = "Book Information";
            // 
            // cbCategory
            // 
            this.cbCategory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(243, 111);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(428, 28);
            this.cbCategory.TabIndex = 15;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(180, 254);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(51, 20);
            this.lblISBN.TabIndex = 8;
            this.lblISBN.Text = "ISBN:";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(243, 249);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(428, 26);
            this.tbISBN.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(112, 115);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(118, 20);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Book Category:";
            // 
            // cbPublisher
            // 
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(243, 158);
            this.cbPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(428, 28);
            this.cbPublisher.TabIndex = 13;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(144, 163);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(87, 20);
            this.lblPublisher.TabIndex = 12;
            this.lblPublisher.Text = "Pubulisher:";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(243, 66);
            this.tbBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(428, 26);
            this.tbBookName.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(171, 208);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 20);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(243, 203);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(428, 26);
            this.tbAuthor.TabIndex = 7;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(134, 71);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(96, 20);
            this.lblBookName.TabIndex = 4;
            this.lblBookName.Text = "Book Name:";
            // 
            // gbBookStatus
            // 
            this.gbBookStatus.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbBookStatus.Controls.Add(this.dtpCreatedate);
            this.gbBookStatus.Controls.Add(this.cbStatus);
            this.gbBookStatus.Controls.Add(this.lblStatus);
            this.gbBookStatus.Controls.Add(this.lblCreateDate);
            this.gbBookStatus.Controls.Add(this.tbLocationDeatail);
            this.gbBookStatus.Controls.Add(this.lblLocationDetails);
            this.gbBookStatus.Location = new System.Drawing.Point(18, 329);
            this.gbBookStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookStatus.Name = "gbBookStatus";
            this.gbBookStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookStatus.Size = new System.Drawing.Size(934, 278);
            this.gbBookStatus.TabIndex = 9;
            this.gbBookStatus.TabStop = false;
            this.gbBookStatus.Text = "Book Status";
            // 
            // dtpCreatedate
            // 
            this.dtpCreatedate.Location = new System.Drawing.Point(243, 85);
            this.dtpCreatedate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpCreatedate.Name = "dtpCreatedate";
            this.dtpCreatedate.Size = new System.Drawing.Size(298, 26);
            this.dtpCreatedate.TabIndex = 17;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "On-Loan"});
            this.cbStatus.Location = new System.Drawing.Point(243, 37);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(166, 28);
            this.cbStatus.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(171, 42);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(134, 94);
            this.lblCreateDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(100, 20);
            this.lblCreateDate.TabIndex = 14;
            this.lblCreateDate.Text = "Create Date:";
            // 
            // tbLocationDeatail
            // 
            this.tbLocationDeatail.Location = new System.Drawing.Point(243, 129);
            this.tbLocationDeatail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLocationDeatail.Multiline = true;
            this.tbLocationDeatail.Name = "tbLocationDeatail";
            this.tbLocationDeatail.Size = new System.Drawing.Size(428, 109);
            this.tbLocationDeatail.TabIndex = 11;
            // 
            // lblLocationDetails
            // 
            this.lblLocationDetails.AutoSize = true;
            this.lblLocationDetails.Location = new System.Drawing.Point(102, 148);
            this.lblLocationDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocationDetails.Name = "lblLocationDetails";
            this.lblLocationDetails.Size = new System.Drawing.Size(127, 20);
            this.lblLocationDetails.TabIndex = 10;
            this.lblLocationDetails.Text = "Location Details:";
            // 
            // BookCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.gbBookStatus);
            this.Controls.Add(this.gbBookInformation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookCrud";
            this.Text = "Book Management";
            this.gbBookInformation.ResumeLayout(false);
            this.gbBookInformation.PerformLayout();
            this.gbBookStatus.ResumeLayout(false);
            this.gbBookStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbBookInformation;
        private System.Windows.Forms.GroupBox gbBookStatus;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label lblLocationDetails;
        private System.Windows.Forms.TextBox tbLocationDeatail;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.DateTimePicker dtpCreatedate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreateDate;
    }
}