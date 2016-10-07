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
            this.btnScan = new System.Windows.Forms.Button();
            this.lblScanTpye = new System.Windows.Forms.Label();
            this.cbScanType = new System.Windows.Forms.ComboBox();
            this.lblScanWord = new System.Windows.Forms.Label();
            this.tbScanWord = new System.Windows.Forms.TextBox();
            this.gbBookDetails = new System.Windows.Forms.GroupBox();
            this.tbFine = new System.Windows.Forms.TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.tbReturnDate = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.tbBorrowDate = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.gbMemberDetails = new System.Windows.Forms.GroupBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbMemberName = new System.Windows.Forms.Label();
            this.tbMemberM = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.tbMemberID = new System.Windows.Forms.TextBox();
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
            this.gbScanDetails.Location = new System.Drawing.Point(18, 18);
            this.gbScanDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbScanDetails.Name = "gbScanDetails";
            this.gbScanDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbScanDetails.Size = new System.Drawing.Size(840, 114);
            this.gbScanDetails.TabIndex = 0;
            this.gbScanDetails.TabStop = false;
            this.gbScanDetails.Text = "Scan";
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.BurlyWood;
            this.btnScan.Location = new System.Drawing.Point(718, 38);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(112, 35);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblScanTpye
            // 
            this.lblScanTpye.AutoSize = true;
            this.lblScanTpye.BackColor = System.Drawing.Color.BurlyWood;
            this.lblScanTpye.Location = new System.Drawing.Point(384, 46);
            this.lblScanTpye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanTpye.Name = "lblScanTpye";
            this.lblScanTpye.Size = new System.Drawing.Size(84, 20);
            this.lblScanTpye.TabIndex = 3;
            this.lblScanTpye.Text = "Scan Type";
            this.lblScanTpye.Click += new System.EventHandler(this.lblScanTpye_Click);
            // 
            // cbScanType
            // 
            this.cbScanType.FormattingEnabled = true;
            this.cbScanType.Location = new System.Drawing.Point(486, 42);
            this.cbScanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbScanType.Name = "cbScanType";
            this.cbScanType.Size = new System.Drawing.Size(200, 28);
            this.cbScanType.TabIndex = 2;
            // 
            // lblScanWord
            // 
            this.lblScanWord.AutoSize = true;
            this.lblScanWord.Location = new System.Drawing.Point(33, 46);
            this.lblScanWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanWord.Name = "lblScanWord";
            this.lblScanWord.Size = new System.Drawing.Size(92, 20);
            this.lblScanWord.TabIndex = 1;
            this.lblScanWord.Text = "Scan Word:";
            // 
            // tbScanWord
            // 
            this.tbScanWord.Location = new System.Drawing.Point(138, 42);
            this.tbScanWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbScanWord.Name = "tbScanWord";
            this.tbScanWord.Size = new System.Drawing.Size(235, 26);
            this.tbScanWord.TabIndex = 0;
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
            this.gbBookDetails.Location = new System.Drawing.Point(18, 153);
            this.gbBookDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookDetails.Name = "gbBookDetails";
            this.gbBookDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookDetails.Size = new System.Drawing.Size(840, 272);
            this.gbBookDetails.TabIndex = 1;
            this.gbBookDetails.TabStop = false;
            this.gbBookDetails.Text = "Book Details";
            // 
            // tbFine
            // 
            this.tbFine.BackColor = System.Drawing.SystemColors.Window;
            this.tbFine.Location = new System.Drawing.Point(486, 168);
            this.tbFine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFine.Name = "tbFine";
            this.tbFine.ReadOnly = true;
            this.tbFine.Size = new System.Drawing.Size(154, 26);
            this.tbFine.TabIndex = 14;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(432, 172);
            this.lblFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(44, 20);
            this.lblFine.TabIndex = 13;
            this.lblFine.Text = "Fine:";
            // 
            // tbReturnDate
            // 
            this.tbReturnDate.BackColor = System.Drawing.SystemColors.Window;
            this.tbReturnDate.Location = new System.Drawing.Point(138, 208);
            this.tbReturnDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbReturnDate.Name = "tbReturnDate";
            this.tbReturnDate.ReadOnly = true;
            this.tbReturnDate.Size = new System.Drawing.Size(235, 26);
            this.tbReturnDate.TabIndex = 12;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(26, 212);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(101, 20);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // tbBorrowDate
            // 
            this.tbBorrowDate.BackColor = System.Drawing.SystemColors.Window;
            this.tbBorrowDate.Location = new System.Drawing.Point(138, 168);
            this.tbBorrowDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBorrowDate.Name = "tbBorrowDate";
            this.tbBorrowDate.ReadOnly = true;
            this.tbBorrowDate.Size = new System.Drawing.Size(235, 26);
            this.tbBorrowDate.TabIndex = 10;
            // 
            // tbISBN
            // 
            this.tbISBN.BackColor = System.Drawing.SystemColors.Window;
            this.tbISBN.Location = new System.Drawing.Point(405, 85);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.ReadOnly = true;
            this.tbISBN.Size = new System.Drawing.Size(388, 26);
            this.tbISBN.TabIndex = 9;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(26, 172);
            this.lblBorrowDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(102, 20);
            this.lblBorrowDate.TabIndex = 8;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(344, 89);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(51, 20);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(300, 49);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(96, 20);
            this.lblBookName.TabIndex = 5;
            this.lblBookName.Text = "Book Name:";
            // 
            // tbBookName
            // 
            this.tbBookName.BackColor = System.Drawing.SystemColors.Window;
            this.tbBookName.Location = new System.Drawing.Point(405, 45);
            this.tbBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.ReadOnly = true;
            this.tbBookName.Size = new System.Drawing.Size(388, 26);
            this.tbBookName.TabIndex = 4;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(56, 49);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(71, 20);
            this.lblBookID.TabIndex = 3;
            this.lblBookID.Text = "Book ID:";
            // 
            // tbBookID
            // 
            this.tbBookID.BackColor = System.Drawing.SystemColors.Window;
            this.tbBookID.Location = new System.Drawing.Point(138, 45);
            this.tbBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.ReadOnly = true;
            this.tbBookID.Size = new System.Drawing.Size(109, 26);
            this.tbBookID.TabIndex = 2;
            // 
            // gbMemberDetails
            // 
            this.gbMemberDetails.Controls.Add(this.btnReturnBook);
            this.gbMemberDetails.Controls.Add(this.btnCancel);
            this.gbMemberDetails.Controls.Add(this.lblRemark);
            this.gbMemberDetails.Controls.Add(this.tbRemark);
            this.gbMemberDetails.Controls.Add(this.tbMemberName);
            this.gbMemberDetails.Controls.Add(this.tbMemberM);
            this.gbMemberDetails.Controls.Add(this.lblMemberID);
            this.gbMemberDetails.Controls.Add(this.tbMemberID);
            this.gbMemberDetails.Location = new System.Drawing.Point(18, 435);
            this.gbMemberDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMemberDetails.Name = "gbMemberDetails";
            this.gbMemberDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMemberDetails.Size = new System.Drawing.Size(840, 213);
            this.gbMemberDetails.TabIndex = 2;
            this.gbMemberDetails.TabStop = false;
            this.gbMemberDetails.Text = "Member Detail";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(527, 156);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(113, 35);
            this.btnReturnBook.TabIndex = 13;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(664, 156);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(56, 74);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(69, 20);
            this.lblRemark.TabIndex = 11;
            this.lblRemark.Text = "Remark:";
            // 
            // tbRemark
            // 
            this.tbRemark.BackColor = System.Drawing.SystemColors.Window;
            this.tbRemark.Location = new System.Drawing.Point(138, 69);
            this.tbRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.ReadOnly = true;
            this.tbRemark.Size = new System.Drawing.Size(655, 59);
            this.tbRemark.TabIndex = 10;
            // 
            // tbMemberName
            // 
            this.tbMemberName.AutoSize = true;
            this.tbMemberName.Location = new System.Drawing.Point(278, 34);
            this.tbMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(117, 20);
            this.tbMemberName.TabIndex = 9;
            this.tbMemberName.Text = "Member Name:";
            // 
            // tbMemberM
            // 
            this.tbMemberM.BackColor = System.Drawing.SystemColors.Window;
            this.tbMemberM.Location = new System.Drawing.Point(405, 29);
            this.tbMemberM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMemberM.Name = "tbMemberM";
            this.tbMemberM.ReadOnly = true;
            this.tbMemberM.Size = new System.Drawing.Size(388, 26);
            this.tbMemberM.TabIndex = 8;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(36, 34);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(92, 20);
            this.lblMemberID.TabIndex = 7;
            this.lblMemberID.Text = "Member ID:";
            // 
            // tbMemberID
            // 
            this.tbMemberID.BackColor = System.Drawing.SystemColors.Window;
            this.tbMemberID.Location = new System.Drawing.Point(138, 29);
            this.tbMemberID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.ReadOnly = true;
            this.tbMemberID.Size = new System.Drawing.Size(109, 26);
            this.tbMemberID.TabIndex = 6;
            // 
            // FormReturnBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(934, 734);
            this.Controls.Add(this.gbMemberDetails);
            this.Controls.Add(this.gbBookDetails);
            this.Controls.Add(this.gbScanDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

        public System.Windows.Forms.GroupBox gbScanDetails;
        public System.Windows.Forms.GroupBox gbBookDetails;
        public System.Windows.Forms.GroupBox gbMemberDetails;
        public System.Windows.Forms.Button btnScan;
        public System.Windows.Forms.Label lblScanTpye;
        public System.Windows.Forms.ComboBox cbScanType;
        public System.Windows.Forms.Label lblScanWord;
        public System.Windows.Forms.TextBox tbScanWord;
        public System.Windows.Forms.TextBox tbFine;
        public System.Windows.Forms.Label lblFine;
        public System.Windows.Forms.TextBox tbReturnDate;
        public System.Windows.Forms.Label lblReturnDate;
        public System.Windows.Forms.TextBox tbBorrowDate;
        public System.Windows.Forms.TextBox tbISBN;
        public System.Windows.Forms.Label lblBorrowDate;
        public System.Windows.Forms.Label lblISBN;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.TextBox tbBookName;
        public System.Windows.Forms.Label lblBookID;
        public System.Windows.Forms.TextBox tbBookID;
        public System.Windows.Forms.Label lblRemark;
        public System.Windows.Forms.TextBox tbRemark;
        public System.Windows.Forms.Label tbMemberName;
        public System.Windows.Forms.TextBox tbMemberM;
        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.TextBox tbMemberID;
        public System.Windows.Forms.Button btnReturnBook;
        public System.Windows.Forms.Button btnCancel;
    }
}