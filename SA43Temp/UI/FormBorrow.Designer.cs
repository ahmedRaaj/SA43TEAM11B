namespace SA43Temp.UI
{
    partial class FormBorrow
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
            this.gbMemberInformation = new System.Windows.Forms.GroupBox();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMemberScan = new System.Windows.Forms.TextBox();
            this.cmbMemberScanType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBooksInformation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgBorrowBooks = new System.Windows.Forms.DataGridView();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBookScan = new System.Windows.Forms.TextBox();
            this.cmbBooksScanType = new System.Windows.Forms.ComboBox();
            this.gbMemberInformation.SuspendLayout();
            this.gbBooksInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMemberInformation
            // 
            this.gbMemberInformation.Controls.Add(this.tbMemberName);
            this.gbMemberInformation.Controls.Add(this.btnStart);
            this.gbMemberInformation.Controls.Add(this.btnSearchMembers);
            this.gbMemberInformation.Controls.Add(this.label3);
            this.gbMemberInformation.Controls.Add(this.label2);
            this.gbMemberInformation.Controls.Add(this.tbMemberScan);
            this.gbMemberInformation.Controls.Add(this.cmbMemberScanType);
            this.gbMemberInformation.Controls.Add(this.label1);
            this.gbMemberInformation.Location = new System.Drawing.Point(12, 29);
            this.gbMemberInformation.Name = "gbMemberInformation";
            this.gbMemberInformation.Size = new System.Drawing.Size(1064, 174);
            this.gbMemberInformation.TabIndex = 0;
            this.gbMemberInformation.TabStop = false;
            this.gbMemberInformation.Text = "Member Information";
            // 
            // tbMemberName
            // 
            this.tbMemberName.Enabled = false;
            this.tbMemberName.Location = new System.Drawing.Point(108, 106);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(435, 26);
            this.tbMemberName.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(950, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 30);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.Location = new System.Drawing.Point(480, 31);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(63, 26);
            this.btnSearchMembers.TabIndex = 5;
            this.btnSearchMembers.Text = "...";
            this.btnSearchMembers.UseVisualStyleBackColor = true;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbMemberScan
            // 
            this.tbMemberScan.Location = new System.Drawing.Point(108, 34);
            this.tbMemberScan.Name = "tbMemberScan";
            this.tbMemberScan.Size = new System.Drawing.Size(353, 26);
            this.tbMemberScan.TabIndex = 3;
            // 
            // cmbMemberScanType
            // 
            this.cmbMemberScanType.FormattingEnabled = true;
            this.cmbMemberScanType.Location = new System.Drawing.Point(657, 37);
            this.cmbMemberScanType.Name = "cmbMemberScanType";
            this.cmbMemberScanType.Size = new System.Drawing.Size(272, 28);
            this.cmbMemberScanType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan Type: ";
            // 
            // gbBooksInformation
            // 
            this.gbBooksInformation.Controls.Add(this.btnCancel);
            this.gbBooksInformation.Controls.Add(this.btnSubmit);
            this.gbBooksInformation.Controls.Add(this.dgBorrowBooks);
            this.gbBooksInformation.Controls.Add(this.btnBorrow);
            this.gbBooksInformation.Controls.Add(this.btnSearchBooks);
            this.gbBooksInformation.Controls.Add(this.label4);
            this.gbBooksInformation.Controls.Add(this.label5);
            this.gbBooksInformation.Controls.Add(this.tbBookScan);
            this.gbBooksInformation.Controls.Add(this.cmbBooksScanType);
            this.gbBooksInformation.Location = new System.Drawing.Point(12, 231);
            this.gbBooksInformation.Name = "gbBooksInformation";
            this.gbBooksInformation.Size = new System.Drawing.Size(1064, 327);
            this.gbBooksInformation.TabIndex = 1;
            this.gbBooksInformation.TabStop = false;
            this.gbBooksInformation.Text = "Books Information To Borrow";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(902, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(741, 264);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 41);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgBorrowBooks
            // 
            this.dgBorrowBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrowBooks.Location = new System.Drawing.Point(17, 88);
            this.dgBorrowBooks.Name = "dgBorrowBooks";
            this.dgBorrowBooks.RowTemplate.Height = 28;
            this.dgBorrowBooks.Size = new System.Drawing.Size(1027, 154);
            this.dgBorrowBooks.TabIndex = 12;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(950, 37);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(94, 28);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(480, 38);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(63, 27);
            this.btnSearchBooks.TabIndex = 11;
            this.btnSearchBooks.Text = "...";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Scan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Scan Type: ";
            // 
            // tbBookScan
            // 
            this.tbBookScan.Location = new System.Drawing.Point(108, 37);
            this.tbBookScan.Name = "tbBookScan";
            this.tbBookScan.Size = new System.Drawing.Size(353, 26);
            this.tbBookScan.TabIndex = 9;
            // 
            // cmbBooksScanType
            // 
            this.cmbBooksScanType.FormattingEnabled = true;
            this.cmbBooksScanType.Location = new System.Drawing.Point(667, 37);
            this.cmbBooksScanType.Name = "cmbBooksScanType";
            this.cmbBooksScanType.Size = new System.Drawing.Size(262, 28);
            this.cmbBooksScanType.TabIndex = 8;
            // 
            // FormBorrow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1107, 580);
            this.Controls.Add(this.gbBooksInformation);
            this.Controls.Add(this.gbMemberInformation);
            this.Name = "FormBorrow";
            this.Text = "FormBorrow";
            this.gbMemberInformation.ResumeLayout(false);
            this.gbMemberInformation.PerformLayout();
            this.gbBooksInformation.ResumeLayout(false);
            this.gbBooksInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbMemberInformation;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnSearchMembers;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbMemberScan;
        public System.Windows.Forms.ComboBox cmbMemberScanType;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbBooksInformation;
        public System.Windows.Forms.DataGridView dgBorrowBooks;
        public System.Windows.Forms.Button btnBorrow;
        public System.Windows.Forms.Button btnSearchBooks;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbBookScan;
        public System.Windows.Forms.ComboBox cmbBooksScanType;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbMemberName;
    }
}