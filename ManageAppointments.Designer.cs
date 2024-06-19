namespace HMSystem
{
    partial class ManageAppointments
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
            addnewAppointment = new Label();
            patientId = new Label();
            doctorName = new Label();
            dateandtime = new Label();
            appointmentdate = new DateTimePicker();
            cmbDoctors = new ComboBox();
            txtPatient = new TextBox();
            allAppointments = new DataGridView();
            status = new Label();
            txtStatus = new TextBox();
            btnAdd = new Button();
            label3 = new Label();
            all = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allAppointments).BeginInit();
            SuspendLayout();
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
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 673);
            panel1.TabIndex = 1;
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
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPayments
            // 
            btnPayments.Location = new Point(39, 526);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(237, 29);
            btnPayments.TabIndex = 5;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnPharmacy
            // 
            btnPharmacy.Location = new Point(39, 447);
            btnPharmacy.Name = "btnPharmacy";
            btnPharmacy.Size = new Size(237, 29);
            btnPharmacy.TabIndex = 4;
            btnPharmacy.Text = "Pharmacy";
            btnPharmacy.UseVisualStyleBackColor = true;
            btnPharmacy.Click += btnPharmacy_Click;
            // 
            // btnMedicalStaff
            // 
            btnMedicalStaff.Location = new Point(39, 370);
            btnMedicalStaff.Name = "btnMedicalStaff";
            btnMedicalStaff.Size = new Size(237, 29);
            btnMedicalStaff.TabIndex = 3;
            btnMedicalStaff.Text = "Medical Staff";
            btnMedicalStaff.UseVisualStyleBackColor = true;
            btnMedicalStaff.Click += btnMedicalStaff_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = Color.CadetBlue;
            btnAppointments.Location = new Point(39, 293);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(237, 29);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
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
            btnDashboard.BackColor = Color.White;
            btnDashboard.Location = new Point(39, 155);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(237, 29);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // addnewAppointment
            // 
            addnewAppointment.AutoSize = true;
            addnewAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addnewAppointment.Location = new Point(342, 9);
            addnewAppointment.Name = "addnewAppointment";
            addnewAppointment.Size = new Size(208, 28);
            addnewAppointment.TabIndex = 2;
            addnewAppointment.Text = "Add new appointment";
            // 
            // patientId
            // 
            patientId.AutoSize = true;
            patientId.Location = new Point(342, 65);
            patientId.Name = "patientId";
            patientId.Size = new Size(71, 20);
            patientId.TabIndex = 3;
            patientId.Text = "Patient id";
            // 
            // doctorName
            // 
            doctorName.AutoSize = true;
            doctorName.Location = new Point(587, 65);
            doctorName.Name = "doctorName";
            doctorName.Size = new Size(55, 20);
            doctorName.TabIndex = 4;
            doctorName.Text = "Doctor";
            // 
            // dateandtime
            // 
            dateandtime.AutoSize = true;
            dateandtime.Location = new Point(907, 65);
            dateandtime.Name = "dateandtime";
            dateandtime.Size = new Size(107, 20);
            dateandtime.TabIndex = 5;
            dateandtime.Text = "Date and Time";
            // 
            // appointmentdate
            // 
            appointmentdate.Format = DateTimePickerFormat.Short;
            appointmentdate.Location = new Point(831, 88);
            appointmentdate.Name = "appointmentdate";
            appointmentdate.Size = new Size(250, 27);
            appointmentdate.TabIndex = 6;
            appointmentdate.KeyDown += dateTimePicker1_KeyDown;
            // 
            // cmbDoctors
            // 
            cmbDoctors.FormattingEnabled = true;
            cmbDoctors.Location = new Point(587, 91);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(201, 28);
            cmbDoctors.TabIndex = 7;
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(342, 91);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(208, 27);
            txtPatient.TabIndex = 8;
            // 
            // allAppointments
            // 
            allAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allAppointments.Location = new Point(346, 224);
            allAppointments.Name = "allAppointments";
            allAppointments.RowHeadersWidth = 51;
            allAppointments.RowTemplate.Height = 29;
            allAppointments.Size = new Size(725, 427);
            allAppointments.TabIndex = 10;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(351, 147);
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.TabIndex = 11;
            status.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(406, 144);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(382, 27);
            txtStatus.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CadetBlue;
            btnAdd.Location = new Point(820, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1050, 9);
            label3.Name = "label3";
            label3.Size = new Size(36, 43);
            label3.TabIndex = 14;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // all
            // 
            all.AutoSize = true;
            all.Location = new Point(346, 186);
            all.Name = "all";
            all.Size = new Size(125, 20);
            all.TabIndex = 15;
            all.Text = "All Appointments";
            // 
            // ManageAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1098, 675);
            Controls.Add(all);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(txtStatus);
            Controls.Add(status);
            Controls.Add(allAppointments);
            Controls.Add(txtPatient);
            Controls.Add(cmbDoctors);
            Controls.Add(appointmentdate);
            Controls.Add(dateandtime);
            Controls.Add(doctorName);
            Controls.Add(patientId);
            Controls.Add(addnewAppointment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageAppointments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)allAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label addnewAppointment;
        private Label patientId;
        private Label doctorName;
        private Label dateandtime;
        private DateTimePicker appointmentdate;
        private ComboBox cmbDoctors;
        private TextBox txtPatient;
        private DataGridView allAppointments;
        private Label status;
        private TextBox txtStatus;
        private Button btnAdd;
        private Label label3;
        private Label all;
    }
}