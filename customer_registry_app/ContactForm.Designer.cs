namespace Assignment5
{
    partial class ContactForm
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
            this.grpBoxName = new System.Windows.Forms.GroupBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpBoxEmailAndPhone = new System.Windows.Forms.GroupBox();
            this.txtBoxEmailPrivate = new System.Windows.Forms.TextBox();
            this.txtBoxEmailBusiness = new System.Windows.Forms.TextBox();
            this.txtBoxOfficePhone = new System.Windows.Forms.TextBox();
            this.txtBoxHomePhone = new System.Windows.Forms.TextBox();
            this.lblEmailPrivate = new System.Windows.Forms.Label();
            this.lblEmailBusiness = new System.Windows.Forms.Label();
            this.lblOfficePhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.grpBoxAddress = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBoxName.SuspendLayout();
            this.grpBoxEmailAndPhone.SuspendLayout();
            this.grpBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxName
            // 
            this.grpBoxName.Controls.Add(this.txtBoxLastName);
            this.grpBoxName.Controls.Add(this.txtBoxFirstName);
            this.grpBoxName.Controls.Add(this.lblLastName);
            this.grpBoxName.Controls.Add(this.lblFirstName);
            this.grpBoxName.Location = new System.Drawing.Point(32, 30);
            this.grpBoxName.Name = "grpBoxName";
            this.grpBoxName.Size = new System.Drawing.Size(419, 102);
            this.grpBoxName.TabIndex = 0;
            this.grpBoxName.TabStop = false;
            this.grpBoxName.Text = "Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(102, 55);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(302, 20);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(102, 26);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(302, 20);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(22, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(22, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // grpBoxEmailAndPhone
            // 
            this.grpBoxEmailAndPhone.Controls.Add(this.txtBoxEmailPrivate);
            this.grpBoxEmailAndPhone.Controls.Add(this.txtBoxEmailBusiness);
            this.grpBoxEmailAndPhone.Controls.Add(this.txtBoxOfficePhone);
            this.grpBoxEmailAndPhone.Controls.Add(this.txtBoxHomePhone);
            this.grpBoxEmailAndPhone.Controls.Add(this.lblEmailPrivate);
            this.grpBoxEmailAndPhone.Controls.Add(this.lblEmailBusiness);
            this.grpBoxEmailAndPhone.Controls.Add(this.lblOfficePhone);
            this.grpBoxEmailAndPhone.Controls.Add(this.lblHomePhone);
            this.grpBoxEmailAndPhone.Location = new System.Drawing.Point(32, 161);
            this.grpBoxEmailAndPhone.Name = "grpBoxEmailAndPhone";
            this.grpBoxEmailAndPhone.Size = new System.Drawing.Size(419, 193);
            this.grpBoxEmailAndPhone.TabIndex = 1;
            this.grpBoxEmailAndPhone.TabStop = false;
            this.grpBoxEmailAndPhone.Text = "Email and phone";
            // 
            // txtBoxEmailPrivate
            // 
            this.txtBoxEmailPrivate.Location = new System.Drawing.Point(102, 136);
            this.txtBoxEmailPrivate.Name = "txtBoxEmailPrivate";
            this.txtBoxEmailPrivate.Size = new System.Drawing.Size(302, 20);
            this.txtBoxEmailPrivate.TabIndex = 9;
            // 
            // txtBoxEmailBusiness
            // 
            this.txtBoxEmailBusiness.Location = new System.Drawing.Point(102, 103);
            this.txtBoxEmailBusiness.Name = "txtBoxEmailBusiness";
            this.txtBoxEmailBusiness.Size = new System.Drawing.Size(302, 20);
            this.txtBoxEmailBusiness.TabIndex = 8;
            // 
            // txtBoxOfficePhone
            // 
            this.txtBoxOfficePhone.Location = new System.Drawing.Point(102, 66);
            this.txtBoxOfficePhone.Name = "txtBoxOfficePhone";
            this.txtBoxOfficePhone.Size = new System.Drawing.Size(302, 20);
            this.txtBoxOfficePhone.TabIndex = 7;
            // 
            // txtBoxHomePhone
            // 
            this.txtBoxHomePhone.Location = new System.Drawing.Point(102, 30);
            this.txtBoxHomePhone.Name = "txtBoxHomePhone";
            this.txtBoxHomePhone.Size = new System.Drawing.Size(302, 20);
            this.txtBoxHomePhone.TabIndex = 6;
            // 
            // lblEmailPrivate
            // 
            this.lblEmailPrivate.AutoSize = true;
            this.lblEmailPrivate.Location = new System.Drawing.Point(20, 139);
            this.lblEmailPrivate.Name = "lblEmailPrivate";
            this.lblEmailPrivate.Size = new System.Drawing.Size(70, 13);
            this.lblEmailPrivate.TabIndex = 4;
            this.lblEmailPrivate.Text = "Email, private";
            // 
            // lblEmailBusiness
            // 
            this.lblEmailBusiness.AutoSize = true;
            this.lblEmailBusiness.Location = new System.Drawing.Point(17, 106);
            this.lblEmailBusiness.Name = "lblEmailBusiness";
            this.lblEmailBusiness.Size = new System.Drawing.Size(79, 13);
            this.lblEmailBusiness.TabIndex = 3;
            this.lblEmailBusiness.Text = "Email, business";
            // 
            // lblOfficePhone
            // 
            this.lblOfficePhone.AutoSize = true;
            this.lblOfficePhone.Location = new System.Drawing.Point(17, 69);
            this.lblOfficePhone.Name = "lblOfficePhone";
            this.lblOfficePhone.Size = new System.Drawing.Size(68, 13);
            this.lblOfficePhone.TabIndex = 2;
            this.lblOfficePhone.Text = "Office phone";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(17, 33);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(68, 13);
            this.lblHomePhone.TabIndex = 1;
            this.lblHomePhone.Text = "Home phone";
            // 
            // grpBoxAddress
            // 
            this.grpBoxAddress.Controls.Add(this.cmbCountry);
            this.grpBoxAddress.Controls.Add(this.lblCountry);
            this.grpBoxAddress.Controls.Add(this.txtBoxZipCode);
            this.grpBoxAddress.Controls.Add(this.txtBoxCity);
            this.grpBoxAddress.Controls.Add(this.txtBoxStreet);
            this.grpBoxAddress.Controls.Add(this.lblZipCode);
            this.grpBoxAddress.Controls.Add(this.lblCity);
            this.grpBoxAddress.Controls.Add(this.lblStreet);
            this.grpBoxAddress.Location = new System.Drawing.Point(32, 380);
            this.grpBoxAddress.Name = "grpBoxAddress";
            this.grpBoxAddress.Size = new System.Drawing.Size(419, 153);
            this.grpBoxAddress.TabIndex = 2;
            this.grpBoxAddress.TabStop = false;
            this.grpBoxAddress.Text = "Address";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(92, 120);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(302, 21);
            this.cmbCountry.TabIndex = 14;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(17, 123);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "Country";
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Location = new System.Drawing.Point(92, 86);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(302, 20);
            this.txtBoxZipCode.TabIndex = 12;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(92, 57);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(302, 20);
            this.txtBoxCity.TabIndex = 11;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(92, 19);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(302, 20);
            this.txtBoxStreet.TabIndex = 10;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(17, 86);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblZipCode.TabIndex = 7;
            this.lblZipCode.Text = "Zip code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(22, 57);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(17, 26);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(91, 557);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(312, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 621);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpBoxAddress);
            this.Controls.Add(this.grpBoxEmailAndPhone);
            this.Controls.Add(this.grpBoxName);
            this.Name = "ContactForm";
            this.grpBoxName.ResumeLayout(false);
            this.grpBoxName.PerformLayout();
            this.grpBoxEmailAndPhone.ResumeLayout(false);
            this.grpBoxEmailAndPhone.PerformLayout();
            this.grpBoxAddress.ResumeLayout(false);
            this.grpBoxAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpBoxEmailAndPhone;
        private System.Windows.Forms.Label lblOfficePhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.GroupBox grpBoxAddress;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxEmailPrivate;
        private System.Windows.Forms.TextBox txtBoxEmailBusiness;
        private System.Windows.Forms.TextBox txtBoxOfficePhone;
        private System.Windows.Forms.TextBox txtBoxHomePhone;
        private System.Windows.Forms.Label lblEmailPrivate;
        private System.Windows.Forms.Label lblEmailBusiness;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.ComboBox cmbCountry;
    }
}