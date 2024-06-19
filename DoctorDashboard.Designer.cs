namespace HMSystem
{
    partial class DoctorDashboard
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
            label1 = new Label();
            name = new Label();
            label2 = new Label();
            doctorAppointments = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)doctorAppointments).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(649, 4);
            label3.Name = "label3";
            label3.Size = new Size(36, 43);
            label3.TabIndex = 3;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 31);
            label1.TabIndex = 4;
            label1.Text = "Doctor";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(106, 15);
            name.Name = "name";
            name.Size = new Size(64, 28);
            name.TabIndex = 5;
            name.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(218, 25);
            label2.TabIndex = 6;
            label2.Text = "Today Appointments";
            // 
            // doctorAppointments
            // 
            doctorAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorAppointments.Location = new Point(20, 95);
            doctorAppointments.Name = "doctorAppointments";
            doctorAppointments.RowHeadersWidth = 51;
            doctorAppointments.RowTemplate.Height = 29;
            doctorAppointments.Size = new Size(665, 431);
            doctorAppointments.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(564, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 40);
            btnBack.TabIndex = 48;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(709, 564);
            Controls.Add(btnBack);
            Controls.Add(doctorAppointments);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            ((System.ComponentModel.ISupportInitialize)doctorAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label name;
        private Label label2;
        private DataGridView doctorAppointments;
        private Button btnBack;
    }
}