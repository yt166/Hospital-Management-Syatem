namespace HospitalManagementSystem
{
    partial class Form2
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
            txtUserName = new TextBox();
            txtPw = new TextBox();
            cmdUserRoll = new ComboBox();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(226, 278);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(246, 27);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(226, 362);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(246, 27);
            txtPw.TabIndex = 1;
            // 
            // cmdUserRoll
            // 
            cmdUserRoll.FormattingEnabled = true;
            cmdUserRoll.Location = new Point(226, 201);
            cmdUserRoll.Name = "cmdUserRoll";
            cmdUserRoll.Size = new Size(246, 28);
            cmdUserRoll.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.MediumPurple;
            btnSubmit.Location = new Point(291, 427);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(226, 245);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(226, 329);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(226, 165);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 6;
            label3.Text = "Select you User Roll";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(775, 521);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(cmdUserRoll);
            Controls.Add(txtPw);
            Controls.Add(txtUserName);
            Name = "Form2";
            Text = " Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPw;
        private ComboBox cmdUserRoll;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}