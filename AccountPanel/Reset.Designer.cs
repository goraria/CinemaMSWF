namespace Project {
    partial class Reset {
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
            txtRePassword = new TextBox();
            txtNewPassword = new TextBox();
            btnChange = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // txtRePassword
            // 
            txtRePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtRePassword.Font = new Font("Arial", 14F);
            txtRePassword.Location = new Point(5, 195);
            txtRePassword.Margin = new Padding(4);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';
            txtRePassword.PlaceholderText = "Nhập lại mật khẩu";
            txtRePassword.Size = new Size(300, 34);
            txtRePassword.TabIndex = 19;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtNewPassword.Font = new Font("Arial", 14F);
            txtNewPassword.Location = new Point(5, 150);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PlaceholderText = "Mật khẩu mới";
            txtNewPassword.Size = new Size(300, 34);
            txtNewPassword.TabIndex = 18;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.Bottom;
            btnChange.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(5, 489);
            btnChange.Margin = new Padding(4);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(300, 50);
            btnChange.TabIndex = 17;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top;
            label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(15, 30);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(280, 50);
            label.TabIndex = 16;
            label.Text = "Đổi mật khẩu";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reset
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(txtRePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(btnChange);
            Controls.Add(label);
            Name = "Reset";
            Size = new Size(310, 544);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnChange;
        private Label label;
        public static TextBox txtRePassword;
        public static TextBox txtNewPassword;
    }
}
