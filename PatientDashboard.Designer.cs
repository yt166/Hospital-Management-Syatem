namespace HMSystem
{
    partial class PatientDashboard
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
            label3 = new Label();
            panel1 = new Panel();
            txtStatus = new TextBox();
            status = new Label();
            btnSubmit = new Button();
            appointmentsDate = new DateTimePicker();
            cmbDoctor = new ComboBox();
            Date = new Label();
            doctor = new Label();
            appointment = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            patientid = new Label();
            id = new Label();
            fname = new Label();
            lastName = new Label();
            dob = new Label();
            address = new Label();
            contact = new Label();
            email = new Label();
            txtFirstName = new TextBox();
            txtLName = new TextBox();
            txtdob = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            person1 = new Label();
            person2 = new Label();
            name = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtPerson1Name = new TextBox();
            txtContactP2Name = new TextBox();
            txtContactP1 = new TextBox();
            txtContactP2 = new TextBox();
            txtP1Relationship = new TextBox();
            txtP2Relationship = new TextBox();
            btnUpdate = new Button();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(769, 9);
            label3.Name = "label3";
            label3.Size = new Size(36, 43);
            label3.TabIndex = 15;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(txtStatus);
            panel1.Controls.Add(status);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(appointmentsDate);
            panel1.Controls.Add(cmbDoctor);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(doctor);
            panel1.Controls.Add(appointment);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 678);
            panel1.TabIndex = 16;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(12, 319);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(265, 27);
            txtStatus.TabIndex = 16;
            // 
            // status
            // 
            status.AutoSize = true;
            status.ForeColor = SystemColors.ButtonHighlight;
            status.Location = new Point(12, 284);
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.TabIndex = 15;
            status.Text = "Status";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SteelBlue;
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(126, 374);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(176, 29);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // appointmentsDate
            // 
            appointmentsDate.Format = DateTimePickerFormat.Short;
            appointmentsDate.Location = new Point(12, 227);
            appointmentsDate.Name = "appointmentsDate";
            appointmentsDate.Size = new Size(265, 27);
            appointmentsDate.TabIndex = 14;
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(12, 146);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(265, 28);
            cmbDoctor.TabIndex = 13;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.ForeColor = SystemColors.ButtonHighlight;
            Date.Location = new Point(12, 193);
            Date.Name = "Date";
            Date.Size = new Size(41, 20);
            Date.TabIndex = 12;
            Date.Text = "Date";
            // 
            // doctor
            // 
            doctor.AutoSize = true;
            doctor.ForeColor = SystemColors.ButtonHighlight;
            doctor.Location = new Point(10, 123);
            doctor.Name = "doctor";
            doctor.Size = new Size(55, 20);
            doctor.TabIndex = 11;
            doctor.Text = "Doctor";
            // 
            // appointment
            // 
            appointment.AutoSize = true;
            appointment.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appointment.ForeColor = SystemColors.Control;
            appointment.Location = new Point(3, 84);
            appointment.Name = "appointment";
            appointment.Size = new Size(205, 28);
            appointment.TabIndex = 10;
            appointment.Text = "Make an appointment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(66, 3);
            label1.Name = "label1";
            label1.Size = new Size(246, 52);
            label1.TabIndex = 8;
            label1.Text = "Medicare";
            // 
            // patientid
            // 
            patientid.AutoSize = true;
            patientid.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            patientid.Location = new Point(332, 12);
            patientid.Name = "patientid";
            patientid.Size = new Size(117, 39);
            patientid.TabIndex = 17;
            patientid.Text = "Patient ID";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(464, 18);
            id.Name = "id";
            id.Size = new Size(44, 33);
            id.TabIndex = 18;
            id.Text = "id";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Location = new Point(342, 69);
            fname.Name = "fname";
            fname.Size = new Size(80, 20);
            fname.TabIndex = 19;
            fname.Text = "First Name";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(343, 110);
            lastName.Name = "lastName";
            lastName.Size = new Size(79, 20);
            lastName.TabIndex = 20;
            lastName.Text = "Last Name";
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Location = new Point(343, 154);
            dob.Name = "dob";
            dob.Size = new Size(94, 20);
            dob.TabIndex = 21;
            dob.Text = "Date of Birth";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(343, 197);
            address.Name = "address";
            address.Size = new Size(62, 20);
            address.TabIndex = 22;
            address.Text = "Address";
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Location = new Point(343, 239);
            contact.Name = "contact";
            contact.Size = new Size(60, 20);
            contact.TabIndex = 23;
            contact.Text = "Contact";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(343, 286);
            email.Name = "email";
            email.Size = new Size(52, 20);
            email.TabIndex = 24;
            email.Text = "E-mail";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(475, 67);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 27);
            txtFirstName.TabIndex = 25;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(475, 105);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(173, 27);
            txtLName.TabIndex = 26;
            // 
            // txtdob
            // 
            txtdob.Location = new Point(475, 146);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(173, 27);
            txtdob.TabIndex = 27;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(475, 190);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(173, 27);
            txtAddress.TabIndex = 28;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(475, 232);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(173, 27);
            txtContact.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(475, 285);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 27);
            txtEmail.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 331);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 31;
            label2.Text = "Contact Person";
            // 
            // person1
            // 
            person1.AutoSize = true;
            person1.Location = new Point(343, 380);
            person1.Name = "person1";
            person1.Size = new Size(64, 20);
            person1.TabIndex = 32;
            person1.Text = "Person 1";
            // 
            // person2
            // 
            person2.AutoSize = true;
            person2.Location = new Point(610, 386);
            person2.Name = "person2";
            person2.Size = new Size(64, 20);
            person2.TabIndex = 33;
            person2.Text = "Person 2";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(343, 426);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 34;
            name.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(602, 426);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 35;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 497);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 36;
            label5.Text = "Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(602, 497);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 37;
            label6.Text = "Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 573);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 38;
            label7.Text = "Relationship";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(602, 573);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 39;
            label8.Text = "Relationship";
            // 
            // txtPerson1Name
            // 
            txtPerson1Name.Location = new Point(347, 450);
            txtPerson1Name.Name = "txtPerson1Name";
            txtPerson1Name.Size = new Size(196, 27);
            txtPerson1Name.TabIndex = 40;
            // 
            // txtContactP2Name
            // 
            txtContactP2Name.Location = new Point(602, 450);
            txtContactP2Name.Name = "txtContactP2Name";
            txtContactP2Name.Size = new Size(203, 27);
            txtContactP2Name.TabIndex = 41;
            // 
            // txtContactP1
            // 
            txtContactP1.Location = new Point(347, 528);
            txtContactP1.Name = "txtContactP1";
            txtContactP1.Size = new Size(196, 27);
            txtContactP1.TabIndex = 42;
            // 
            // txtContactP2
            // 
            txtContactP2.Location = new Point(602, 528);
            txtContactP2.Name = "txtContactP2";
            txtContactP2.Size = new Size(203, 27);
            txtContactP2.TabIndex = 43;
            // 
            // txtP1Relationship
            // 
            txtP1Relationship.Location = new Point(346, 603);
            txtP1Relationship.Name = "txtP1Relationship";
            txtP1Relationship.Size = new Size(197, 27);
            txtP1Relationship.TabIndex = 44;
            // 
            // txtP2Relationship
            // 
            txtP2Relationship.Location = new Point(602, 606);
            txtP2Relationship.Name = "txtP2Relationship";
            txtP2Relationship.Size = new Size(203, 27);
            txtP2Relationship.TabIndex = 45;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Location = new Point(643, 645);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 29);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(684, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 40);
            btnBack.TabIndex = 47;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(817, 680);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(txtP2Relationship);
            Controls.Add(txtP1Relationship);
            Controls.Add(txtContactP2);
            Controls.Add(txtContactP1);
            Controls.Add(txtContactP2Name);
            Controls.Add(txtPerson1Name);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(name);
            Controls.Add(person2);
            Controls.Add(person1);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtdob);
            Controls.Add(txtLName);
            Controls.Add(txtFirstName);
            Controls.Add(email);
            Controls.Add(contact);
            Controls.Add(address);
            Controls.Add(dob);
            Controls.Add(lastName);
            Controls.Add(fname);
            Controls.Add(id);
            Controls.Add(patientid);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSubmit;
        private Label appointment;
        private ComboBox cmbDoctor;
        private Label Date;
        private Label doctor;
        private DateTimePicker appointmentsDate;
        private Label status;
        private TextBox txtStatus;
        private Label patientid;
        private Label id;
        private Label fname;
        private Label lastName;
        private Label dob;
        private Label address;
        private Label contact;
        private Label email;
        private TextBox txtFirstName;
        private TextBox txtLName;
        private TextBox txtdob;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Label label2;
        private Label person1;
        private Label person2;
        private Label name;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtPerson1Name;
        private TextBox txtContactP2Name;
        private TextBox txtContactP1;
        private TextBox txtContactP2;
        private TextBox txtP1Relationship;
        private TextBox txtP2Relationship;
        private Button btnUpdate;
        private Button btnBack;
    }
}