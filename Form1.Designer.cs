namespace HMSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            register = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            cmdUserRole = new ComboBox();
            label1 = new Label();
            password = new Label();
            userName = new Label();
            label2 = new Label();
            userRole = new Label();
            login = new Label();
            label3 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(register);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(cmdUserRole);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(userName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userRole);
            panel1.Controls.Add(login);
            panel1.Location = new Point(27, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 507);
            panel1.TabIndex = 0;
            // 
            // register
            // 
            register.AutoSize = true;
            register.ForeColor = Color.MidnightBlue;
            register.Location = new Point(214, 428);
            register.Name = "register";
            register.Size = new Size(63, 20);
            register.TabIndex = 10;
            register.Text = "Register";
            register.Click += register_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(37, 379);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(267, 40);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 329);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(265, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(39, 248);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(265, 27);
            txtUserName.TabIndex = 7;
            // 
            // cmdUserRole
            // 
            cmdUserRole.FormattingEnabled = true;
            cmdUserRole.Location = new Point(39, 170);
            cmdUserRole.Name = "cmdUserRole";
            cmdUserRole.Size = new Size(265, 28);
            cmdUserRole.TabIndex = 6;
            cmdUserRole.SelectionChangeCommitted += cmdUserRole_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 428);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 5;
            label1.Text = "Don't have an account ?";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(39, 293);
            password.Name = "password";
            password.Size = new Size(70, 20);
            password.TabIndex = 4;
            password.Text = "Password";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(37, 213);
            userName.Name = "userName";
            userName.Size = new Size(82, 20);
            userName.TabIndex = 3;
            userName.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 141);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "User Role";
            // 
            // userRole
            // 
            userRole.AutoSize = true;
            userRole.Location = new Point(33, 141);
            userRole.Name = "userRole";
            userRole.Size = new Size(0, 20);
            userRole.TabIndex = 1;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(59, 12);
            login.Name = "login";
            login.Size = new Size(206, 71);
            login.TabIndex = 0;
            login.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(830, 9);
            label3.Name = "label3";
            label3.Size = new Size(36, 43);
            label3.TabIndex = 1;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(745, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 579);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label password;
        private Label userName;
        private Label label2;
        private Label userRole;
        private Label login;
        private Label label1;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private ComboBox cmdUserRole;
        private Label register;
        private Label label3;
        private Button btnBack;
    }
}