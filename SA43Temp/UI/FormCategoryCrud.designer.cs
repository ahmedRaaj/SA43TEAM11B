namespace LibraryManagementSystem.UI
{
    partial class FormCategoryCrud
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
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbCategoryDetails = new System.Windows.Forms.TextBox();
            this.lblCategoryDetails = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCategoryInformation = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(114, 146);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(123, 20);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(248, 142);
            this.tbCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(426, 26);
            this.tbCategoryName.TabIndex = 1;
            // 
            // tbCategoryDetails
            // 
            this.tbCategoryDetails.Location = new System.Drawing.Point(248, 205);
            this.tbCategoryDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategoryDetails.Multiline = true;
            this.tbCategoryDetails.Name = "tbCategoryDetails";
            this.tbCategoryDetails.Size = new System.Drawing.Size(426, 281);
            this.tbCategoryDetails.TabIndex = 3;
            // 
            // lblCategoryDetails
            // 
            this.lblCategoryDetails.AutoSize = true;
            this.lblCategoryDetails.Location = new System.Drawing.Point(114, 209);
            this.lblCategoryDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryDetails.Name = "lblCategoryDetails";
            this.lblCategoryDetails.Size = new System.Drawing.Size(130, 20);
            this.lblCategoryDetails.TabIndex = 2;
            this.lblCategoryDetails.Text = "Category Details:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(746, 642);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(624, 642);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbCategoryInformation
            // 
            this.gbCategoryInformation.Location = new System.Drawing.Point(48, 45);
            this.gbCategoryInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCategoryInformation.Name = "gbCategoryInformation";
            this.gbCategoryInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCategoryInformation.Size = new System.Drawing.Size(730, 535);
            this.gbCategoryInformation.TabIndex = 6;
            this.gbCategoryInformation.TabStop = false;
            this.gbCategoryInformation.Text = "Category Information";
            // 
            // FormCategoryCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 711);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCategoryDetails);
            this.Controls.Add(this.lblCategoryDetails);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.gbCategoryInformation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategoryCrud";
            this.Text = "Category Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.TextBox tbCategoryDetails;
        private System.Windows.Forms.Label lblCategoryDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbCategoryInformation;
    }
}