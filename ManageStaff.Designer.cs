namespace HMSystem
{
    partial class ManageStaff
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
            menu = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnLogout = new Button();
            btnPayments = new Button();
            btnPharmacy = new Button();
            btnMedicalStaff = new Button();
            btnAppointments = new Button();
            btnPatients = new Button();
            btnDashboard = new Button();
            viewStaff = new DataGridView();
            addnew = new Label();
            name = new Label();
            jobRole = new Label();
            address = new Label();
            email = new Label();
            contact = new Label();
            cmbRole = new ComboBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewStaff).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1190, 9);
            label3.Name = "label3";
            label3.Size = new Size(36, 43);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(menu);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnPharmacy);
            panel1.Controls.Add(btnMedicalStaff);
            panel1.Controls.Add(btnAppointments);
            panel1.Controls.Add(btnPatients);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 673);
            panel1.TabIndex = 3;
            // 
            // menu
            // 
            menu.AutoSize = true;
            menu.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menu.ForeColor = SystemColors.Control;
            menu.Location = new Point(12, 108);
            menu.Name = "menu";
            menu.Size = new Size(71, 26);
            menu.TabIndex = 8;
            menu.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(6, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(68, 20);
            label1.Name = "label1";
            label1.Size = new Size(246, 52);
            label1.TabIndex = 7;
            label1.Text = "Medicare";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(39, 598);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(237, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.Location = new Point(39, 526);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(237, 29);
            btnPayments.TabIndex = 5;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnPharmacy
            // 
            btnPharmacy.Location = new Point(39, 447);
            btnPharmacy.Name = "btnPharmacy";
            btnPharmacy.Size = new Size(237, 29);
            btnPharmacy.TabIndex = 4;
            btnPharmacy.Text = "Pharmacy";
            btnPharmacy.UseVisualStyleBackColor = true;
            // 
            // btnMedicalStaff
            // 
            btnMedicalStaff.BackColor = Color.CadetBlue;
            btnMedicalStaff.Location = new Point(39, 370);
            btnMedicalStaff.Name = "btnMedicalStaff";
            btnMedicalStaff.Size = new Size(237, 29);
            btnMedicalStaff.TabIndex = 3;
            btnMedicalStaff.Text = "Medical Staff";
            btnMedicalStaff.UseVisualStyleBackColor = false;
            // 
            // btnAppointments
            // 
            btnAppointments.Location = new Point(39, 293);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(237, 29);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            // 
            // btnPatients
            // 
            btnPatients.Location = new Point(39, 222);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(237, 29);
            btnPatients.TabIndex = 1;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(39, 155);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(237, 29);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // viewStaff
            // 
            viewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewStaff.Location = new Point(349, 178);
            viewStaff.Name = "viewStaff";
            viewStaff.RowHeadersWidth = 51;
            viewStaff.RowTemplate.Height = 29;
            viewStaff.Size = new Size(865, 458);
            viewStaff.TabIndex = 4;
            // 
            // addnew
            // 
            addnew.AutoSize = true;
            addnew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addnew.Location = new Point(363, 21);
            addnew.Name = "addnew";
            addnew.Size = new Size(167, 28);
            addnew.TabIndex = 5;
            addnew.Text = "Add new member";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(349, 65);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 6;
            name.Text = "Name";
            // 
            // jobRole
            // 
            jobRole.AutoSize = true;
            jobRole.Location = new Point(605, 68);
            jobRole.Name = "jobRole";
            jobRole.Size = new Size(66, 20);
            jobRole.TabIndex = 7;
            jobRole.Text = "Job Role";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(923, 68);
            address.Name = "address";
            address.Size = new Size(62, 20);
            address.TabIndex = 8;
            address.Text = "Address";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(368, 124);
            email.Name = "email";
            email.Size = new Size(52, 20);
            email.TabIndex = 9;
            email.Text = "E-mail";
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Location = new Point(806, 128);
            contact.Name = "contact";
            contact.Size = new Size(60, 20);
            contact.TabIndex = 10;
            contact.Text = "Contact";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(677, 65);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(202, 28);
            cmbRole.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(404, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 27);
            txtName.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(991, 65);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(194, 27);
            txtAddress.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(429, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(878, 126);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(202, 27);
            txtContact.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1109, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1109, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 40);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1238, 666);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(cmbRole);
            Controls.Add(contact);
            Controls.Add(email);
            Controls.Add(address);
            Controls.Add(jobRole);
            Controls.Add(name);
            Controls.Add(addnew);
            Controls.Add(viewStaff);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStaff";
            Text = "ManageStaff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Label menu;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLogout;
        private Button btnPayments;
        private Button btnPharmacy;
        private Button btnMedicalStaff;
        private Button btnAppointments;
        private Button btnPatients;
        private Button btnDashboard;
        private DataGridView viewStaff;
        private Label addnew;
        private Label name;
        private Label jobRole;
        private Label address;
        private Label email;
        private Label contact;
        private ComboBox cmbRole;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Button btnAdd;
        private Button btnBack;
    }
}