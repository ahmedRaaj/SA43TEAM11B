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
            this.btnSave.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSave.Location = new System.Drawing.Point(456, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCancel.Location = new System.Drawing.Point(554, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbPublisherInfo
            // 
            this.gbPublisherInfo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbPublisherInfo.Controls.Add(this.tbDetials);
            this.gbPublisherInfo.Controls.Add(this.lblPublisherDetails);
            this.gbPublisherInfo.Controls.Add(this.tbWebsite);
            this.gbPublisherInfo.Controls.Add(this.lblPublisherWeb);
            this.gbPublisherInfo.Controls.Add(this.tbPublisherName);
            this.gbPublisherInfo.Controls.Add(this.lblPublisherName);
            this.gbPublisherInfo.Location = new System.Drawing.Point(12, 12);
            this.gbPublisherInfo.Name = "gbPublisherInfo";
            this.gbPublisherInfo.Size = new System.Drawing.Size(617, 367);
            this.gbPublisherInfo.TabIndex = 10;
            this.gbPublisherInfo.TabStop = false;
            this.gbPublisherInfo.Text = "Publisher Infomation";
            // 
            // tbDetials
            // 
            this.tbDetials.Location = new System.Drawing.Point(182, 169);
            this.tbDetials.Multiline = true;
            this.tbDetials.Name = "tbDetials";
            this.tbDetials.Size = new System.Drawing.Size(287, 100);
            this.tbDetials.TabIndex = 11;
            // 
            // lblPublisherDetails
            // 
            this.lblPublisherDetails.AutoSize = true;
            this.lblPublisherDetails.Location = new System.Drawing.Point(55, 172);
            this.lblPublisherDetails.Name = "lblPublisherDetails";
            this.lblPublisherDetails.Size = new System.Drawing.Size(113, 12);
            this.lblPublisherDetails.TabIndex = 10;
            this.lblPublisherDetails.Text = "Publisher Details:";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(182, 116);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(287, 21);
            this.tbWebsite.TabIndex = 9;
            // 
            // lblPublisherWeb
            // 
            this.lblPublisherWeb.AutoSize = true;
            this.lblPublisherWeb.Location = new System.Drawing.Point(55, 119);
            this.lblPublisherWeb.Name = "lblPublisherWeb";
            this.lblPublisherWeb.Size = new System.Drawing.Size(113, 12);
            this.lblPublisherWeb.TabIndex = 8;
            this.lblPublisherWeb.Text = "Publisher Website:";
            // 
            // tbPublisherName
            // 
            this.tbPublisherName.Location = new System.Drawing.Point(182, 66);
            this.tbPublisherName.Name = "tbPublisherName";
            this.tbPublisherName.Size = new System.Drawing.Size(287, 21);
            this.tbPublisherName.TabIndex = 7;
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(73, 70);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(95, 12);
            this.lblPublisherName.TabIndex = 6;
            this.lblPublisherName.Text = "Publisher Name:";
            // 
            // FormPublisherCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(652, 446);
            this.Controls.Add(this.gbPublisherInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
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