namespace SA43Temp.UI
{
    partial class FormMemberCrud
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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.dpkCreationDate = new System.Windows.Forms.DateTimePicker();
            this.gbBasicInformation = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbContactInformation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbBasicInformation.SuspendLayout();
            this.gbContactInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(161, 42);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(77, 12);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Member Name:";
            // 
            // tbMemberName
            // 
            this.tbMemberName.Location = new System.Drawing.Point(246, 40);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(161, 21);
            this.tbMemberName.TabIndex = 1;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(246, 66);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(161, 21);
            this.tbCity.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(203, 69);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 12);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(165, 85);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(242, 55);
            this.tbAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(110, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 12);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(164, 22);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(243, 21);
            this.tbPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(117, 22);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 12);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(165, 46);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(242, 34);
            this.tbEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(123, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(125, 97);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(113, 12);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Membership Status:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(138, 321);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(89, 12);
            this.lblCreationDate.TabIndex = 12;
            this.lblCreationDate.Text = "Creation Date:";
            // 
            // dpkCreationDate
            // 
            this.dpkCreationDate.Location = new System.Drawing.Point(219, 316);
            this.dpkCreationDate.Name = "dpkCreationDate";
            this.dpkCreationDate.Size = new System.Drawing.Size(200, 21);
            this.dpkCreationDate.TabIndex = 13;
            // 
            // gbBasicInformation
            // 
            this.gbBasicInformation.Controls.Add(this.cbStatus);
            this.gbBasicInformation.Controls.Add(this.tbMemberName);
            this.gbBasicInformation.Controls.Add(this.lblCity);
            this.gbBasicInformation.Controls.Add(this.tbCity);
            this.gbBasicInformation.Controls.Add(this.lblStatus);
            this.gbBasicInformation.Controls.Add(this.lblMemberName);
            this.gbBasicInformation.Location = new System.Drawing.Point(12, 11);
            this.gbBasicInformation.Name = "gbBasicInformation";
            this.gbBasicInformation.Size = new System.Drawing.Size(560, 126);
            this.gbBasicInformation.TabIndex = 14;
            this.gbBasicInformation.TabStop = false;
            this.gbBasicInformation.Text = "Basic Information";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(246, 94);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(161, 20);
            this.cbStatus.TabIndex = 11;
            // 
            // gbContactInformation
            // 
            this.gbContactInformation.Controls.Add(this.lblAddress);
            this.gbContactInformation.Controls.Add(this.lblPhone);
            this.gbContactInformation.Controls.Add(this.lblEmail);
            this.gbContactInformation.Controls.Add(this.tbAddress);
            this.gbContactInformation.Controls.Add(this.tbPhone);
            this.gbContactInformation.Controls.Add(this.tbEmail);
            this.gbContactInformation.Location = new System.Drawing.Point(12, 143);
            this.gbContactInformation.Name = "gbContactInformation";
            this.gbContactInformation.Size = new System.Drawing.Size(560, 158);
            this.gbContactInformation.TabIndex = 15;
            this.gbContactInformation.TabStop = false;
            this.gbContactInformation.Text = "Contact Information";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(497, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMemberCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 426);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dpkCreationDate);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.gbBasicInformation);
            this.Controls.Add(this.gbContactInformation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMemberCrud";
            this.Text = "Member Management";
            this.gbBasicInformation.ResumeLayout(false);
            this.gbBasicInformation.PerformLayout();
            this.gbContactInformation.ResumeLayout(false);
            this.gbContactInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.DateTimePicker dpkCreationDate;
        private System.Windows.Forms.GroupBox gbBasicInformation;
        private System.Windows.Forms.GroupBox gbContactInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}