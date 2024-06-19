namespace HospitalManagementSystem
{
    partial class FormRegister
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
            lblRegistration = new Label();
            lblPatientInformation = new Label();
            lblFName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDOB = new TextBox();
            txtContactNumber = new TextBox();
            txtEmail = new TextBox();
            lblDOB = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            txtGender = new TextBox();
            lblGender = new Label();
            lblContactPerson = new Label();
            lblPerson1 = new Label();
            lblPerson2 = new Label();
            lblP1FirstName = new Label();
            lblP2LName = new Label();
            txtP1FName = new TextBox();
            txtP2LName = new TextBox();
            txtP1Relationship = new TextBox();
            txtP1Contact = new TextBox();
            lblP1Relationship = new Label();
            lblP1Contact = new Label();
            lblP2FName = new Label();
            lblLNameP2 = new Label();
            lblP2Relation = new Label();
            lblP2Contact = new Label();
            txtP2FName = new TextBox();
            txtLNameP2 = new TextBox();
            txtP2Relation = new TextBox();
            txtP2Contact = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistration.Location = new Point(183, 25);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(358, 40);
            lblRegistration.TabIndex = 0;
            lblRegistration.Text = "Registration Form";
            lblRegistration.Click += lblRegistration_Click;
            // 
            // lblPatientInformation
            // 
            lblPatientInformation.AutoSize = true;
            lblPatientInformation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatientInformation.Location = new Point(12, 88);
            lblPatientInformation.Name = "lblPatientInformation";
            lblPatientInformation.Size = new Size(210, 31);
            lblPatientInformation.TabIndex = 1;
            lblPatientInformation.Text = "Patient Information";
            lblPatientInformation.Click += lblPatientInformation_Click;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFName.Location = new Point(21, 132);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(92, 23);
            lblFName.TabIndex = 2;
            lblFName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(424, 132);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(91, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(21, 158);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(266, 27);
            txtFirstName.TabIndex = 4;
            txtFirstName.Validating += txtFIrstName_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(424, 158);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(21, 235);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(265, 27);
            txtDOB.TabIndex = 6;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(21, 314);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(266, 27);
            txtContactNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(424, 314);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 8;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDOB.Location = new Point(21, 209);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(107, 23);
            lblDOB.TabIndex = 9;
            lblDOB.Text = "Date of Birth";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblContact.Location = new Point(21, 288);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(138, 23);
            lblContact.TabIndex = 10;
            lblContact.Text = "Contact Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(424, 291);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(21, 372);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 23);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(21, 398);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(449, 27);
            txtAddress.TabIndex = 13;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(424, 235);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(252, 27);
            txtGender.TabIndex = 14;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(426, 209);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(66, 23);
            lblGender.TabIndex = 15;
            lblGender.Text = "Gender";
            // 
            // lblContactPerson
            // 
            lblContactPerson.AutoSize = true;
            lblContactPerson.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactPerson.Location = new Point(21, 459);
            lblContactPerson.Name = "lblContactPerson";
            lblContactPerson.Size = new Size(342, 31);
            lblContactPerson.TabIndex = 16;
            lblContactPerson.Text = "Contact Person in an emergency";
            // 
            // lblPerson1
            // 
            lblPerson1.AutoSize = true;
            lblPerson1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson1.Location = new Point(21, 502);
            lblPerson1.Name = "lblPerson1";
            lblPerson1.Size = new Size(86, 28);
            lblPerson1.TabIndex = 17;
            lblPerson1.Text = "Person 1";
            // 
            // lblPerson2
            // 
            lblPerson2.AutoSize = true;
            lblPerson2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson2.Location = new Point(21, 705);
            lblPerson2.Name = "lblPerson2";
            lblPerson2.Size = new Size(86, 28);
            lblPerson2.TabIndex = 18;
            lblPerson2.Text = "Person 2";
            // 
            // lblP1FirstName
            // 
            lblP1FirstName.AutoSize = true;
            lblP1FirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblP1FirstName.Location = new Point(21, 543);
            lblP1FirstName.Name = "lblP1FirstName";
            lblP1FirstName.Size = new Size(92, 23);
            lblP1FirstName.TabIndex = 19;
            lblP1FirstName.Text = "First Name";
            // 
            // lblP2LName
            // 
            lblP2LName.AutoSize = true;
            lblP2LName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblP2LName.Location = new Point(424, 540);
            lblP2LName.Name = "lblP2LName";
            lblP2LName.Size = new Size(91, 23);
            lblP2LName.TabIndex = 20;
            lblP2LName.Text = "Last Name";
            // 
            // txtP1FName
            // 
            txtP1FName.Location = new Point(23, 566);
            txtP1FName.Name = "txtP1FName";
            txtP1FName.Size = new Size(263, 27);
            txtP1FName.TabIndex = 21;
            // 
            // txtP2LName
            // 
            txtP2LName.Location = new Point(426, 566);
            txtP2LName.Name = "txtP2LName";
            txtP2LName.Size = new Size(252, 27);
            txtP2LName.TabIndex = 22;
            // 
            // txtP1Relationship
            // 
            txtP1Relationship.Location = new Point(21, 652);
            txtP1Relationship.Name = "txtP1Relationship";
            txtP1Relationship.Size = new Size(263, 27);
            txtP1Relationship.TabIndex = 23;
            // 
            // txtP1Contact
            // 
            txtP1Contact.Location = new Point(424, 652);
            txtP1Contact.Name = "txtP1Contact";
            txtP1Contact.Size = new Size(252, 27);
            txtP1Contact.TabIndex = 24;
            // 
            // lblP1Relationship
            // 
            lblP1Relationship.AutoSize = true;
            lblP1Relationship.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblP1Relationship.Location = new Point(23, 626);
            lblP1Relationship.Name = "lblP1Relationship";
            lblP1Relationship.Size = new Size(212, 23);
            lblP1Relationship.TabIndex = 25;
            lblP1Relationship.Text = "Relationship to the Patient";
            // 
            // lblP1Contact
            // 
            lblP1Contact.AutoSize = true;
            lblP1Contact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblP1Contact.Location = new Point(424, 626);
            lblP1Contact.Name = "lblP1Contact";
            lblP1Contact.Size = new Size(138, 23);
            lblP1Contact.TabIndex = 26;
            lblP1Contact.Text = "Contact Number";
            // 
            // lblP2FName
            // 
            lblP2FName.AutoSize = true;
            lblP2FName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblP2FName.Location = new Point(23, 764);
            lblP2FName.Name = "lblP2FName";
            lblP2FName.Size = new Size(92, 23);
            lblP2FName.TabIndex = 27;
            lblP2FName.Text = "First Name";
            // 
            // lblLNameP2
            // 
            lblLNameP2.AutoSize = true;
            lblLNameP2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLNameP2.Location = new Point(426, 764);
            lblLNameP2.Name = "lblLNameP2";
            lblLNameP2.Size = new Size(91, 23);
            lblLNameP2.TabIndex = 28;
            lblLNameP2.Text = "Last Name";
            // 
            // lblP2Relation
            // 
            lblP2Relation.AutoSize = true;
            lblP2Relation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblP2Relation.Location = new Point(23, 834);
            lblP2Relation.Name = "lblP2Relation";
            lblP2Relation.Size = new Size(212, 23);
            lblP2Relation.TabIndex = 29;
            lblP2Relation.Text = "Relationship to the Patient";
            // 
            // lblP2Contact
            // 
            lblP2Contact.AutoSize = true;
            lblP2Contact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblP2Contact.Location = new Point(424, 834);
            lblP2Contact.Name = "lblP2Contact";
            lblP2Contact.Size = new Size(138, 23);
            lblP2Contact.TabIndex = 30;
            lblP2Contact.Text = "Contact Number";
            // 
            // txtP2FName
            // 
            txtP2FName.Location = new Point(21, 790);
            txtP2FName.Name = "txtP2FName";
            txtP2FName.Size = new Size(263, 27);
            txtP2FName.TabIndex = 31;
            // 
            // txtLNameP2
            // 
            txtLNameP2.Location = new Point(424, 790);
            txtLNameP2.Name = "txtLNameP2";
            txtLNameP2.Size = new Size(254, 27);
            txtLNameP2.TabIndex = 32;
            // 
            // txtP2Relation
            // 
            txtP2Relation.Location = new Point(21, 876);
            txtP2Relation.Name = "txtP2Relation";
            txtP2Relation.Size = new Size(263, 27);
            txtP2Relation.TabIndex = 33;
            // 
            // txtP2Contact
            // 
            txtP2Contact.Location = new Point(424, 872);
            txtP2Contact.Name = "txtP2Contact";
            txtP2Contact.Size = new Size(254, 27);
            txtP2Contact.TabIndex = 34;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaptionText;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(104, 918);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(487, 37);
            btnSubmit.TabIndex = 35;
            btnSubmit.Text = "Register";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(736, 967);
            Controls.Add(btnSubmit);
            Controls.Add(txtP2Contact);
            Controls.Add(txtP2Relation);
            Controls.Add(txtLNameP2);
            Controls.Add(txtP2FName);
            Controls.Add(lblP2Contact);
            Controls.Add(lblP2Relation);
            Controls.Add(lblLNameP2);
            Controls.Add(lblP2FName);
            Controls.Add(lblP1Contact);
            Controls.Add(lblP1Relationship);
            Controls.Add(txtP1Contact);
            Controls.Add(txtP1Relationship);
            Controls.Add(txtP2LName);
            Controls.Add(txtP1FName);
            Controls.Add(lblP2LName);
            Controls.Add(lblP1FirstName);
            Controls.Add(lblPerson2);
            Controls.Add(lblPerson1);
            Controls.Add(lblContactPerson);
            Controls.Add(lblGender);
            Controls.Add(txtGender);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblContact);
            Controls.Add(lblDOB);
            Controls.Add(txtEmail);
            Controls.Add(txtContactNumber);
            Controls.Add(txtDOB);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFName);
            Controls.Add(lblPatientInformation);
            Controls.Add(lblRegistration);
            Name = "FormRegister";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistration;
        private Label lblPatientInformation;
        private Label lblFName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDOB;
        private TextBox txtContactNumber;
        private TextBox txtEmail;
        private Label lblDOB;
        private Label lblContact;
        private Label lblEmail;
        private Label lblAddress;
        private TextBox txtAddress;
        private TextBox txtGender;
        private Label lblGender;
        private Label lblContactPerson;
        private Label lblPerson1;
        private Label lblPerson2;
        private Label lblP1FirstName;
        private Label lblP2LName;
        private TextBox txtP1FName;
        private TextBox txtP2LName;
        private TextBox txtP1Relationship;
        private TextBox txtP1Contact;
        private Label lblP1Relationship;
        private Label lblP1Contact;
        private Label lblP2FName;
        private Label lblLNameP2;
        private Label lblP2Relation;
        private Label lblP2Contact;
        private TextBox txtP2FName;
        private TextBox txtLNameP2;
        private TextBox txtP2Relation;
        private TextBox txtP2Contact;
        private Button btnSubmit;
    }
}