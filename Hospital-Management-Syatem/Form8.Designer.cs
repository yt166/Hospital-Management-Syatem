namespace HospitalManagementSystem
{
    partial class FormManageAppointments
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
            btnPatient = new Button();
            btnLogout = new Button();
            btnDashboard = new Button();
            btnAppointment = new Button();
            btnStaff = new Button();
            btnPayments = new Button();
            pictureBox1 = new PictureBox();
            btnPharmacy = new Button();
            Medicare = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnPatient);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnAppointment);
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPharmacy);
            panel1.Controls.Add(Medicare);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 700);
            panel1.TabIndex = 19;
            // 
            // btnPatient
            // 
            btnPatient.Location = new Point(28, 210);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(219, 38);
            btnPatient.TabIndex = 1;
            btnPatient.Text = "Patients";
            btnPatient.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(28, 631);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(219, 39);
            btnLogout.TabIndex = 17;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(28, 138);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(219, 36);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnAppointment
            // 
            btnAppointment.BackColor = Color.CadetBlue;
            btnAppointment.Location = new Point(28, 287);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(219, 40);
            btnAppointment.TabIndex = 2;
            btnAppointment.Text = "Appointments";
            btnAppointment.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            btnStaff.Location = new Point(28, 372);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(219, 38);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.Location = new Point(28, 452);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(219, 39);
            btnPayments.TabIndex = 4;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download1;
            pictureBox1.Location = new Point(0, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnPharmacy
            // 
            btnPharmacy.Location = new Point(28, 545);
            btnPharmacy.Name = "btnPharmacy";
            btnPharmacy.Size = new Size(219, 37);
            btnPharmacy.TabIndex = 5;
            btnPharmacy.Text = "Phamacy";
            btnPharmacy.UseVisualStyleBackColor = true;
            // 
            // Medicare
            // 
            Medicare.AutoSize = true;
            Medicare.Font = new Font("Stencil", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Medicare.ForeColor = Color.LightGray;
            Medicare.Location = new Point(51, 6);
            Medicare.Name = "Medicare";
            Medicare.Size = new Size(238, 52);
            Medicare.TabIndex = 7;
            Medicare.Text = "Medicare";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 83);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 6;
            label1.Text = "Menu";
            // 
            // FormManageAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 702);
            Controls.Add(panel1);
            Name = "FormManageAppointments";
            Text = "Manage Appointments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPatient;
        private Button btnLogout;
        private Button btnDashboard;
        private Button btnAppointment;
        private Button btnStaff;
        private Button btnPayments;
        private PictureBox pictureBox1;
        private Button btnPharmacy;
        private Label Medicare;
        private Label label1;
    }
}