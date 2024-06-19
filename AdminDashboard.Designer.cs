namespace HMSystem
{
    partial class AdminDashboard
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
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 673);
            panel1.TabIndex = 0;
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
            btnAppointments.Location = new Point(39, 293);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(237, 29);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
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
            btnDashboard.BackColor = Color.CadetBlue;
            btnDashboard.Location = new Point(39, 155);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(237, 29);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(764, 2);
            label3.Name = "label3";
            label3.Size = new Size(36, 43);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 669);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button btnLogout;
        private Button btnPayments;
        private Button btnPharmacy;
        private Button btnMedicalStaff;
        private Button btnAppointments;
        private Button btnPatients;
        private Button btnDashboard;
        private Label label1;
        private Label menu;
        private PictureBox pictureBox1;
    }
}