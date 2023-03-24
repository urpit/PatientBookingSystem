namespace Assignment2_0_
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtprovince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtPurpose = new System.Windows.Forms.RichTextBox();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnResetField = new System.Windows.Forms.Button();
            this.btnPreField = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPostalCode = new System.Windows.Forms.Label();
            this.lblErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lblErrorAge = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateofBirth);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.txtprovince);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPatientName);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Controls.Add(this.lblPostalCode);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblProvince);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Location = new System.Drawing.Point(36, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofBirth.Location = new System.Drawing.Point(28, 101);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(100, 20);
            this.dtpDateofBirth.TabIndex = 16;
            this.dtpDateofBirth.ValueChanged += new System.EventHandler(this.dtpDateofBirth_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(28, 371);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(28, 319);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 14;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(28, 269);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 13;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged);
            // 
            // txtprovince
            // 
            this.txtprovince.Location = new System.Drawing.Point(28, 223);
            this.txtprovince.Name = "txtprovince";
            this.txtprovince.Size = new System.Drawing.Size(100, 20);
            this.txtprovince.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(28, 180);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(28, 140);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(28, 60);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(100, 20);
            this.txtPatientName.TabIndex = 9;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 303);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 355);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(25, 41);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(74, 13);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(25, 83);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(25, 253);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(66, 13);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "Postal code:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 124);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(25, 207);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(25, 164);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtPurpose);
            this.groupBox2.Controls.Add(this.cmbDuration);
            this.groupBox2.Controls.Add(this.dtpAppointment);
            this.groupBox2.Controls.Add(this.lblPurpose);
            this.groupBox2.Controls.Add(this.lblDuration);
            this.groupBox2.Controls.Add(this.lblAppointmentTime);
            this.groupBox2.Location = new System.Drawing.Point(455, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appoinment Information";
            // 
            // rtxtPurpose
            // 
            this.rtxtPurpose.Location = new System.Drawing.Point(33, 147);
            this.rtxtPurpose.Name = "rtxtPurpose";
            this.rtxtPurpose.Size = new System.Drawing.Size(200, 96);
            this.rtxtPurpose.TabIndex = 5;
            this.rtxtPurpose.Text = "";
            // 
            // cmbDuration
            // 
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Items.AddRange(new object[] {
            "15min",
            "30min",
            "45min",
            "1hr"});
            this.cmbDuration.Location = new System.Drawing.Point(33, 99);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(121, 21);
            this.cmbDuration.TabIndex = 4;
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointment.Location = new System.Drawing.Point(33, 59);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointment.TabIndex = 3;
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpAppointment_ValueChanged);
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(30, 124);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(122, 13);
            this.lblPurpose.TabIndex = 2;
            this.lblPurpose.Text = "Purpose of appointment:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(30, 83);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(112, 13);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Appointment Duration:";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Location = new System.Drawing.Point(30, 40);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(150, 13);
            this.lblAppointmentTime.TabIndex = 0;
            this.lblAppointmentTime.Text = "Requested Appointment Time:";
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(455, 316);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(123, 23);
            this.btnBookAppointment.TabIndex = 2;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnResetField
            // 
            this.btnResetField.Location = new System.Drawing.Point(610, 316);
            this.btnResetField.Name = "btnResetField";
            this.btnResetField.Size = new System.Drawing.Size(119, 23);
            this.btnResetField.TabIndex = 3;
            this.btnResetField.Text = "Reset Field";
            this.btnResetField.UseVisualStyleBackColor = true;
            this.btnResetField.Click += new System.EventHandler(this.btnResetField_Click);
            // 
            // btnPreField
            // 
            this.btnPreField.Location = new System.Drawing.Point(455, 346);
            this.btnPreField.Name = "btnPreField";
            this.btnPreField.Size = new System.Drawing.Size(123, 23);
            this.btnPreField.TabIndex = 4;
            this.btnPreField.Text = "Pre-Fill Field";
            this.btnPreField.UseVisualStyleBackColor = true;
            this.btnPreField.Click += new System.EventHandler(this.btnPreField_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(610, 345);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(455, 398);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(283, 13);
            this.lblErrorEmail.TabIndex = 6;
            this.lblErrorEmail.Text = "Email must be provided in Valid format(ex- test@gmail.com)";
            // 
            // lblErrorPostalCode
            // 
            this.lblErrorPostalCode.AutoSize = true;
            this.lblErrorPostalCode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPostalCode.Location = new System.Drawing.Point(455, 425);
            this.lblErrorPostalCode.Name = "lblErrorPostalCode";
            this.lblErrorPostalCode.Size = new System.Drawing.Size(239, 13);
            this.lblErrorPostalCode.TabIndex = 7;
            this.lblErrorPostalCode.Text = "Postal code must be in valid format(ex- N2M 5E7)";
            // 
            // lblErrorPhoneNumber
            // 
            this.lblErrorPhoneNumber.AutoSize = true;
            this.lblErrorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhoneNumber.Location = new System.Drawing.Point(455, 456);
            this.lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
            this.lblErrorPhoneNumber.Size = new System.Drawing.Size(264, 13);
            this.lblErrorPhoneNumber.TabIndex = 8;
            this.lblErrorPhoneNumber.Text = "Phone number must be in valid format(ex-1234567890)";
            // 
            // lblErrorAge
            // 
            this.lblErrorAge.AutoSize = true;
            this.lblErrorAge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAge.Location = new System.Drawing.Point(455, 483);
            this.lblErrorAge.Name = "lblErrorAge";
            this.lblErrorAge.Size = new System.Drawing.Size(173, 13);
            this.lblErrorAge.TabIndex = 9;
            this.lblErrorAge.Text = "Patient must be 18 years of old age";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(455, 508);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(212, 13);
            this.lblErrorName.TabIndex = 10;
            this.lblErrorName.Text = "Name is not in correct format(ex-Alan Smith)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.lblErrorAge);
            this.Controls.Add(this.lblErrorPhoneNumber);
            this.Controls.Add(this.lblErrorPostalCode);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreField);
            this.Controls.Add(this.btnResetField);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtprovince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtPurpose;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnResetField;
        private System.Windows.Forms.Button btnPreField;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPostalCode;
        private System.Windows.Forms.Label lblErrorPhoneNumber;
        private System.Windows.Forms.Label lblErrorAge;
        private System.Windows.Forms.Label lblErrorName;
    }
}

