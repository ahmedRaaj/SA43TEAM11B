namespace LibraryManagementSystem.UI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.dpkCreationDate = new System.Windows.Forms.DateTimePicker();
            this.gbBasicInformation = new System.Windows.Forms.GroupBox();
            this.gbContactInformation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbBasicInformation.SuspendLayout();
            this.gbContactInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(161, 46);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(79, 13);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Member Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(213, 75);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 92);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 59);
            this.textBox3.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(110, 95);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 20);
            this.textBox4.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(117, 24);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(165, 50);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(242, 36);
            this.textBox5.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(123, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(141, 105);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Membership Status:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(138, 348);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(75, 13);
            this.lblCreationDate.TabIndex = 12;
            this.lblCreationDate.Text = "Creation Date:";
            // 
            // dpkCreationDate
            // 
            this.dpkCreationDate.Location = new System.Drawing.Point(219, 342);
            this.dpkCreationDate.Name = "dpkCreationDate";
            this.dpkCreationDate.Size = new System.Drawing.Size(200, 20);
            this.dpkCreationDate.TabIndex = 13;
            // 
            // gbBasicInformation
            // 
            this.gbBasicInformation.Controls.Add(this.comboBox1);
            this.gbBasicInformation.Controls.Add(this.textBox1);
            this.gbBasicInformation.Controls.Add(this.lblCity);
            this.gbBasicInformation.Controls.Add(this.textBox2);
            this.gbBasicInformation.Controls.Add(this.lblStatus);
            this.gbBasicInformation.Controls.Add(this.lblMemberName);
            this.gbBasicInformation.Location = new System.Drawing.Point(12, 12);
            this.gbBasicInformation.Name = "gbBasicInformation";
            this.gbBasicInformation.Size = new System.Drawing.Size(560, 137);
            this.gbBasicInformation.TabIndex = 14;
            this.gbBasicInformation.TabStop = false;
            this.gbBasicInformation.Text = "Basic Information";
            // 
            // gbContactInformation
            // 
            this.gbContactInformation.Controls.Add(this.lblAddress);
            this.gbContactInformation.Controls.Add(this.lblPhone);
            this.gbContactInformation.Controls.Add(this.lblEmail);
            this.gbContactInformation.Controls.Add(this.textBox3);
            this.gbContactInformation.Controls.Add(this.textBox4);
            this.gbContactInformation.Controls.Add(this.textBox5);
            this.gbContactInformation.Location = new System.Drawing.Point(12, 155);
            this.gbContactInformation.Name = "gbContactInformation";
            this.gbContactInformation.Size = new System.Drawing.Size(560, 171);
            this.gbContactInformation.TabIndex = 15;
            this.gbContactInformation.TabStop = false;
            this.gbContactInformation.Text = "Contact Information";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(497, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // FormMemberCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.DateTimePicker dpkCreationDate;
        private System.Windows.Forms.GroupBox gbBasicInformation;
        private System.Windows.Forms.GroupBox gbContactInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}