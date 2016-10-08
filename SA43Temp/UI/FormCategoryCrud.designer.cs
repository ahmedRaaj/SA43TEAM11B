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
            this.gbCategoryInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(57, 102);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(137, 22);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoryName.Location = new System.Drawing.Point(252, 158);
            this.tbCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(457, 29);
            this.tbCategoryName.TabIndex = 1;
            // 
            // tbCategoryDetails
            // 
            this.tbCategoryDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoryDetails.Location = new System.Drawing.Point(252, 222);
            this.tbCategoryDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategoryDetails.Multiline = true;
            this.tbCategoryDetails.Name = "tbCategoryDetails";
            this.tbCategoryDetails.Size = new System.Drawing.Size(457, 179);
            this.tbCategoryDetails.TabIndex = 3;
            // 
            // lblCategoryDetails
            // 
            this.lblCategoryDetails.AutoSize = true;
            this.lblCategoryDetails.Location = new System.Drawing.Point(39, 165);
            this.lblCategoryDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryDetails.Name = "lblCategoryDetails";
            this.lblCategoryDetails.Size = new System.Drawing.Size(144, 22);
            this.lblCategoryDetails.TabIndex = 2;
            this.lblCategoryDetails.Text = "Category Details:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Coral;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(670, 645);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 47);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(542, 645);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbCategoryInformation
            // 
            this.gbCategoryInformation.BackColor = System.Drawing.Color.Coral;
            this.gbCategoryInformation.Controls.Add(this.lblCategoryDetails);
            this.gbCategoryInformation.Controls.Add(this.lblCategoryName);
            this.gbCategoryInformation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoryInformation.Location = new System.Drawing.Point(52, 62);
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
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(876, 712);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCategoryDetails);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.gbCategoryInformation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategoryCrud";
            this.Text = "Category Management";
            this.gbCategoryInformation.ResumeLayout(false);
            this.gbCategoryInformation.PerformLayout();
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