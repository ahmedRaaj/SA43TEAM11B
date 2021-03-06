﻿namespace LibraryManagementSystem.UI
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
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(682, 642);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Coral;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(825, 642);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbBookInformation
            // 
            this.gbBookInformation.BackColor = System.Drawing.Color.Coral;
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
            this.gbBookInformation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookInformation.Location = new System.Drawing.Point(18, 18);
            this.gbBookInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookInformation.Name = "gbBookInformation";
            this.gbBookInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookInformation.Size = new System.Drawing.Size(934, 302);
            this.gbBookInformation.TabIndex = 8;
            this.gbBookInformation.TabStop = false;
            this.gbBookInformation.Text = "Book Information";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(243, 112);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(428, 30);
            this.cbCategory.TabIndex = 15;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(178, 252);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(56, 22);
            this.lblISBN.TabIndex = 8;
            this.lblISBN.Text = "ISBN:";
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.Location = new System.Drawing.Point(243, 247);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(428, 29);
            this.tbISBN.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(98, 117);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(132, 22);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Book Category:";
            // 
            // cbPublisher
            // 
            this.cbPublisher.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(243, 157);
            this.cbPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(428, 30);
            this.cbPublisher.TabIndex = 13;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(135, 162);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(97, 22);
            this.lblPublisher.TabIndex = 12;
            this.lblPublisher.Text = "Pubulisher:";
            // 
            // tbBookName
            // 
            this.tbBookName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookName.Location = new System.Drawing.Point(243, 67);
            this.tbBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(428, 29);
            this.tbBookName.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(160, 207);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(69, 22);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.Location = new System.Drawing.Point(243, 202);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(428, 29);
            this.tbAuthor.TabIndex = 7;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(124, 72);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(107, 22);
            this.lblBookName.TabIndex = 4;
            this.lblBookName.Text = "Book Name:";
            // 
            // gbBookStatus
            // 
            this.gbBookStatus.BackColor = System.Drawing.Color.Coral;
            this.gbBookStatus.Controls.Add(this.dtpCreatedate);
            this.gbBookStatus.Controls.Add(this.cbStatus);
            this.gbBookStatus.Controls.Add(this.lblStatus);
            this.gbBookStatus.Controls.Add(this.lblCreateDate);
            this.gbBookStatus.Controls.Add(this.tbLocationDeatail);
            this.gbBookStatus.Controls.Add(this.lblLocationDetails);
            this.gbBookStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookStatus.Location = new System.Drawing.Point(18, 353);
            this.gbBookStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookStatus.Name = "gbBookStatus";
            this.gbBookStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookStatus.Size = new System.Drawing.Size(934, 253);
            this.gbBookStatus.TabIndex = 9;
            this.gbBookStatus.TabStop = false;
            this.gbBookStatus.Text = "Book Status";
            // 
            // dtpCreatedate
            // 
            this.dtpCreatedate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedate.Location = new System.Drawing.Point(243, 85);
            this.dtpCreatedate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpCreatedate.Name = "dtpCreatedate";
            this.dtpCreatedate.Size = new System.Drawing.Size(428, 29);
            this.dtpCreatedate.TabIndex = 17;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "On-Loan"});
            this.cbStatus.Location = new System.Drawing.Point(243, 37);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(166, 30);
            this.cbStatus.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(165, 42);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 22);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.Location = new System.Drawing.Point(124, 95);
            this.lblCreateDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(108, 22);
            this.lblCreateDate.TabIndex = 14;
            this.lblCreateDate.Text = "Create Date:";
            // 
            // tbLocationDeatail
            // 
            this.tbLocationDeatail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocationDeatail.Location = new System.Drawing.Point(243, 128);
            this.tbLocationDeatail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLocationDeatail.Multiline = true;
            this.tbLocationDeatail.Name = "tbLocationDeatail";
            this.tbLocationDeatail.Size = new System.Drawing.Size(428, 109);
            this.tbLocationDeatail.TabIndex = 11;
            // 
            // lblLocationDetails
            // 
            this.lblLocationDetails.AutoSize = true;
            this.lblLocationDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDetails.Location = new System.Drawing.Point(90, 133);
            this.lblLocationDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocationDetails.Name = "lblLocationDetails";
            this.lblLocationDetails.Size = new System.Drawing.Size(140, 22);
            this.lblLocationDetails.TabIndex = 10;
            this.lblLocationDetails.Text = "Location Details:";
            // 
            // BookCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(978, 743);
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