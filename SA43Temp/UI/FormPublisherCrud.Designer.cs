namespace LibraryManagementSystem.UI
{
    partial class FormPublisherCrud
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
            this.gbPublisherInfo = new System.Windows.Forms.GroupBox();
            this.tbDetials = new System.Windows.Forms.TextBox();
            this.lblPublisherDetails = new System.Windows.Forms.Label();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.lblPublisherWeb = new System.Windows.Forms.Label();
            this.tbPublisherName = new System.Windows.Forms.TextBox();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.gbPublisherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(684, 642);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(831, 642);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbPublisherInfo
            // 
            this.gbPublisherInfo.BackColor = System.Drawing.Color.FloralWhite;
            this.gbPublisherInfo.Controls.Add(this.tbDetials);
            this.gbPublisherInfo.Controls.Add(this.lblPublisherDetails);
            this.gbPublisherInfo.Controls.Add(this.tbWebsite);
            this.gbPublisherInfo.Controls.Add(this.lblPublisherWeb);
            this.gbPublisherInfo.Controls.Add(this.tbPublisherName);
            this.gbPublisherInfo.Controls.Add(this.lblPublisherName);
            this.gbPublisherInfo.Location = new System.Drawing.Point(18, 20);
            this.gbPublisherInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPublisherInfo.Name = "gbPublisherInfo";
            this.gbPublisherInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPublisherInfo.Size = new System.Drawing.Size(925, 612);
            this.gbPublisherInfo.TabIndex = 10;
            this.gbPublisherInfo.TabStop = false;
            this.gbPublisherInfo.Text = "Publisher Infomation";
            // 
            // tbDetials
            // 
            this.tbDetials.Location = new System.Drawing.Point(273, 282);
            this.tbDetials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDetials.Multiline = true;
            this.tbDetials.Name = "tbDetials";
            this.tbDetials.Size = new System.Drawing.Size(428, 164);
            this.tbDetials.TabIndex = 11;
            // 
            // lblPublisherDetails
            // 
            this.lblPublisherDetails.AutoSize = true;
            this.lblPublisherDetails.Location = new System.Drawing.Point(103, 285);
            this.lblPublisherDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisherDetails.Name = "lblPublisherDetails";
            this.lblPublisherDetails.Size = new System.Drawing.Size(131, 20);
            this.lblPublisherDetails.TabIndex = 10;
            this.lblPublisherDetails.Text = "Publisher Details:";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(273, 193);
            this.tbWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(428, 26);
            this.tbWebsite.TabIndex = 9;
            // 
            // lblPublisherWeb
            // 
            this.lblPublisherWeb.AutoSize = true;
            this.lblPublisherWeb.Location = new System.Drawing.Point(94, 201);
            this.lblPublisherWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisherWeb.Name = "lblPublisherWeb";
            this.lblPublisherWeb.Size = new System.Drawing.Size(140, 20);
            this.lblPublisherWeb.TabIndex = 8;
            this.lblPublisherWeb.Text = "Publisher Website:";
            // 
            // tbPublisherName
            // 
            this.tbPublisherName.Location = new System.Drawing.Point(273, 110);
            this.tbPublisherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPublisherName.Name = "tbPublisherName";
            this.tbPublisherName.Size = new System.Drawing.Size(428, 26);
            this.tbPublisherName.TabIndex = 7;
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(110, 116);
            this.lblPublisherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(124, 20);
            this.lblPublisherName.TabIndex = 6;
            this.lblPublisherName.Text = "Publisher Name:";
            // 
            // FormPublisherCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.gbPublisherInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPublisherCrud";
            this.Text = "Publisher Management";
            this.gbPublisherInfo.ResumeLayout(false);
            this.gbPublisherInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbPublisherInfo;
        private System.Windows.Forms.TextBox tbDetials;
        private System.Windows.Forms.Label lblPublisherDetails;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label lblPublisherWeb;
        private System.Windows.Forms.TextBox tbPublisherName;
        private System.Windows.Forms.Label lblPublisherName;
    }
}