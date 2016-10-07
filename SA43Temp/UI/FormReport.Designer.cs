namespace LibraryManagementSystem.UI
{
    partial class FormReport
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
            this.btnBookList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnManagementReport = new System.Windows.Forms.Button();
            this.btnBooksRented = new System.Windows.Forms.Button();
            this.btnFineReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBookList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.Location = new System.Drawing.Point(82, 27);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(300, 100);
            this.btnBookList.TabIndex = 1;
            this.btnBookList.Text = "Book List";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 475);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // btnManagementReport
            // 
            this.btnManagementReport.BackColor = System.Drawing.Color.BurlyWood;
            this.btnManagementReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementReport.Location = new System.Drawing.Point(82, 137);
            this.btnManagementReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManagementReport.Name = "btnManagementReport";
            this.btnManagementReport.Size = new System.Drawing.Size(300, 100);
            this.btnManagementReport.TabIndex = 6;
            this.btnManagementReport.Text = "Management Report";
            this.btnManagementReport.UseVisualStyleBackColor = false;
            // 
            // btnBooksRented
            // 
            this.btnBooksRented.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBooksRented.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksRented.Location = new System.Drawing.Point(82, 247);
            this.btnBooksRented.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBooksRented.Name = "btnBooksRented";
            this.btnBooksRented.Size = new System.Drawing.Size(300, 100);
            this.btnBooksRented.TabIndex = 7;
            this.btnBooksRented.Text = "Books Rented Report";
            this.btnBooksRented.UseVisualStyleBackColor = false;
            // 
            // btnFineReport
            // 
            this.btnFineReport.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFineReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFineReport.Location = new System.Drawing.Point(82, 357);
            this.btnFineReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFineReport.Name = "btnFineReport";
            this.btnFineReport.Size = new System.Drawing.Size(300, 100);
            this.btnFineReport.TabIndex = 8;
            this.btnFineReport.Text = "Fine Collected Report";
            this.btnFineReport.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(-5, -7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reports";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBookList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnManagementReport);
            this.groupBox1.Controls.Add(this.btnFineReport);
            this.groupBox1.Controls.Add(this.btnBooksRented);
            this.groupBox1.Location = new System.Drawing.Point(77, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 494);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1308, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReport";
            this.Text = "Report List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnManagementReport;
        private System.Windows.Forms.Button btnBooksRented;
        private System.Windows.Forms.Button btnFineReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}