namespace LibraryManagementSystem.UI
{
    partial class FormReturnBook
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
            this.gbScanDetails = new System.Windows.Forms.GroupBox();
            this.gbBookDetails = new System.Windows.Forms.GroupBox();
            this.gbMemberDetails = new System.Windows.Forms.GroupBox();
            this.tbScanWord = new System.Windows.Forms.TextBox();
            this.lblScanWord = new System.Windows.Forms.Label();
            this.cbScanType = new System.Windows.Forms.ComboBox();
            this.lblScanTpye = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblBookID = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbBorrowDate = new System.Windows.Forms.TextBox();
            this.tbReturnDate = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.tbFine = new System.Windows.Forms.TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.Label();
            this.tbMemberM = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbScanDetails.SuspendLayout();
            this.gbBookDetails.SuspendLayout();
            this.gbMemberDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScanDetails
            // 
            this.gbScanDetails.Controls.Add(this.btnScan);
            this.gbScanDetails.Controls.Add(this.lblScanTpye);
            this.gbScanDetails.Controls.Add(this.cbScanType);
            this.gbScanDetails.Controls.Add(this.lblScanWord);
            this.gbScanDetails.Controls.Add(this.tbScanWord);
            this.gbScanDetails.Location = new System.Drawing.Point(12, 12);
            this.gbScanDetails.Name = "gbScanDetails";
            this.gbScanDetails.Size = new System.Drawing.Size(560, 74);
            this.gbScanDetails.TabIndex = 0;
            this.gbScanDetails.TabStop = false;
            this.gbScanDetails.Text = "Scan";
            // 
            // gbBookDetails
            // 
            this.gbBookDetails.Controls.Add(this.tbFine);
            this.gbBookDetails.Controls.Add(this.lblFine);
            this.gbBookDetails.Controls.Add(this.tbReturnDate);
            this.gbBookDetails.Controls.Add(this.lblReturnDate);
            this.gbBookDetails.Controls.Add(this.tbBorrowDate);
            this.gbBookDetails.Controls.Add(this.tbISBN);
            this.gbBookDetails.Controls.Add(this.lblBorrowDate);
            this.gbBookDetails.Controls.Add(this.lblISBN);
            this.gbBookDetails.Controls.Add(this.lblBookName);
            this.gbBookDetails.Controls.Add(this.tbBookName);
            this.gbBookDetails.Controls.Add(this.lblBookID);
            this.gbBookDetails.Controls.Add(this.tbBookID);
            this.gbBookDetails.Location = new System.Drawing.Point(12, 118);
            this.gbBookDetails.Name = "gbBookDetails";
            this.gbBookDetails.Size = new System.Drawing.Size(560, 177);
            this.gbBookDetails.TabIndex = 1;
            this.gbBookDetails.TabStop = false;
            this.gbBookDetails.Text = "Book Details";
            // 
            // gbMemberDetails
            // 
            this.gbMemberDetails.Controls.Add(this.lblRemark);
            this.gbMemberDetails.Controls.Add(this.tbRemark);
            this.gbMemberDetails.Controls.Add(this.tbMemberName);
            this.gbMemberDetails.Controls.Add(this.tbMemberM);
            this.gbMemberDetails.Controls.Add(this.lblMemberID);
            this.gbMemberDetails.Controls.Add(this.tbMemberID);
            this.gbMemberDetails.Location = new System.Drawing.Point(12, 301);
            this.gbMemberDetails.Name = "gbMemberDetails";
            this.gbMemberDetails.Size = new System.Drawing.Size(560, 94);
            this.gbMemberDetails.TabIndex = 2;
            this.gbMemberDetails.TabStop = false;
            this.gbMemberDetails.Text = "Member Detail";
            // 
            // tbScanWord
            // 
            this.tbScanWord.Location = new System.Drawing.Point(92, 27);
            this.tbScanWord.Name = "tbScanWord";
            this.tbScanWord.Size = new System.Drawing.Size(158, 20);
            this.tbScanWord.TabIndex = 0;
            // 
            // lblScanWord
            // 
            this.lblScanWord.AutoSize = true;
            this.lblScanWord.Location = new System.Drawing.Point(22, 30);
            this.lblScanWord.Name = "lblScanWord";
            this.lblScanWord.Size = new System.Drawing.Size(64, 13);
            this.lblScanWord.TabIndex = 1;
            this.lblScanWord.Text = "Scan Word:";
            // 
            // cbScanType
            // 
            this.cbScanType.FormattingEnabled = true;
            this.cbScanType.Location = new System.Drawing.Point(324, 27);
            this.cbScanType.Name = "cbScanType";
            this.cbScanType.Size = new System.Drawing.Size(135, 21);
            this.cbScanType.TabIndex = 2;
            // 
            // lblScanTpye
            // 
            this.lblScanTpye.AutoSize = true;
            this.lblScanTpye.Location = new System.Drawing.Point(256, 30);
            this.lblScanTpye.Name = "lblScanTpye";
            this.lblScanTpye.Size = new System.Drawing.Size(62, 13);
            this.lblScanTpye.TabIndex = 3;
            this.lblScanTpye.Text = "Scan Tpye:";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(479, 25);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(37, 32);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(49, 13);
            this.lblBookID.TabIndex = 3;
            this.lblBookID.Text = "Book ID:";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(92, 29);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.ReadOnly = true;
            this.tbBookID.Size = new System.Drawing.Size(74, 20);
            this.tbBookID.TabIndex = 2;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(200, 32);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(66, 13);
            this.lblBookName.TabIndex = 5;
            this.lblBookName.Text = "Book Name:";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(270, 29);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.ReadOnly = true;
            this.tbBookName.Size = new System.Drawing.Size(260, 20);
            this.tbBookName.TabIndex = 4;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(229, 58);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(17, 112);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(69, 13);
            this.lblBorrowDate.TabIndex = 8;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(270, 55);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.ReadOnly = true;
            this.tbISBN.Size = new System.Drawing.Size(260, 20);
            this.tbISBN.TabIndex = 9;
            // 
            // tbBorrowDate
            // 
            this.tbBorrowDate.Location = new System.Drawing.Point(92, 109);
            this.tbBorrowDate.Name = "tbBorrowDate";
            this.tbBorrowDate.ReadOnly = true;
            this.tbBorrowDate.Size = new System.Drawing.Size(158, 20);
            this.tbBorrowDate.TabIndex = 10;
            // 
            // tbReturnDate
            // 
            this.tbReturnDate.Location = new System.Drawing.Point(92, 135);
            this.tbReturnDate.Name = "tbReturnDate";
            this.tbReturnDate.ReadOnly = true;
            this.tbReturnDate.Size = new System.Drawing.Size(158, 20);
            this.tbReturnDate.TabIndex = 12;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(17, 138);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(68, 13);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // tbFine
            // 
            this.tbFine.Location = new System.Drawing.Point(324, 109);
            this.tbFine.Name = "tbFine";
            this.tbFine.ReadOnly = true;
            this.tbFine.Size = new System.Drawing.Size(104, 20);
            this.tbFine.TabIndex = 14;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(288, 112);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(30, 13);
            this.lblFine.TabIndex = 13;
            this.lblFine.Text = "Fine:";
            // 
            // tbMemberName
            // 
            this.tbMemberName.AutoSize = true;
            this.tbMemberName.Location = new System.Drawing.Point(185, 22);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(79, 13);
            this.tbMemberName.TabIndex = 9;
            this.tbMemberName.Text = "Member Name:";
            // 
            // tbMemberM
            // 
            this.tbMemberM.Location = new System.Drawing.Point(270, 19);
            this.tbMemberM.Name = "tbMemberM";
            this.tbMemberM.ReadOnly = true;
            this.tbMemberM.Size = new System.Drawing.Size(260, 20);
            this.tbMemberM.TabIndex = 8;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(24, 22);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 7;
            this.lblMemberID.Text = "Member ID:";
            // 
            // tbMemberID
            // 
            this.tbMemberID.Location = new System.Drawing.Point(92, 19);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.ReadOnly = true;
            this.tbMemberID.Size = new System.Drawing.Size(74, 20);
            this.tbMemberID.TabIndex = 6;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(37, 48);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(47, 13);
            this.lblRemark.TabIndex = 11;
            this.lblRemark.Text = "Remark:";
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(92, 45);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.ReadOnly = true;
            this.tbRemark.Size = new System.Drawing.Size(438, 40);
            this.tbRemark.TabIndex = 10;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(416, 417);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 9;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(497, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbMemberDetails);
            this.Controls.Add(this.gbBookDetails);
            this.Controls.Add(this.gbScanDetails);
            this.Name = "FormReturnBook";
            this.Text = "Return Book";
            this.gbScanDetails.ResumeLayout(false);
            this.gbScanDetails.PerformLayout();
            this.gbBookDetails.ResumeLayout(false);
            this.gbBookDetails.PerformLayout();
            this.gbMemberDetails.ResumeLayout(false);
            this.gbMemberDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScanDetails;
        private System.Windows.Forms.GroupBox gbBookDetails;
        private System.Windows.Forms.GroupBox gbMemberDetails;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblScanTpye;
        private System.Windows.Forms.ComboBox cbScanType;
        private System.Windows.Forms.Label lblScanWord;
        private System.Windows.Forms.TextBox tbScanWord;
        private System.Windows.Forms.TextBox tbFine;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox tbReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.TextBox tbBorrowDate;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label tbMemberName;
        private System.Windows.Forms.TextBox tbMemberM;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnCancel;
    }
}