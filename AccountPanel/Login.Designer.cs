namespace Project {
    partial class Login {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            txtAccount = new TextBox();
            btnLogin = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPassword.Font = new Font("Arial", 14F);
            txtPassword.Location = new Point(5, 195);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.Size = new Size(300, 34);
            txtPassword.TabIndex = 11;
            // 
            // txtAccount
            // 
            txtAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtAccount.Font = new Font("Arial", 14F);
            txtAccount.Location = new Point(5, 150);
            txtAccount.Margin = new Padding(4);
            txtAccount.Name = "txtAccount";
            txtAccount.PlaceholderText = "Tên tài khoản";
            txtAccount.Size = new Size(300, 34);
            txtAccount.TabIndex = 10;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(5, 489);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 50);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top;
            label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(29, 31);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(250, 50);
            label.TabIndex = 8;
            label.Text = "Đăng nhập";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(btnLogin);
            Controls.Add(label);
            Name = "Login";
            Size = new Size(310, 544);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Label label;
        public static TextBox txtAccount;
        public static TextBox txtPassword;
    }
}
