namespace Project {
    partial class Check {
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
            txtID = new TextBox();
            txtAccount = new TextBox();
            btnCheck = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtID.Font = new Font("Arial", 14F);
            txtID.Location = new Point(5, 195);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID Nhân viên";
            txtID.Size = new Size(300, 34);
            txtID.TabIndex = 15;
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
            txtAccount.TabIndex = 14;
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Bottom;
            btnCheck.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(5, 489);
            btnCheck.Margin = new Padding(4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(300, 50);
            btnCheck.TabIndex = 13;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top;
            label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(30, 30);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(250, 50);
            label.TabIndex = 12;
            label.Text = "Kiểm tra";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Check
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(txtID);
            Controls.Add(txtAccount);
            Controls.Add(btnCheck);
            Controls.Add(label);
            Name = "Check";
            Size = new Size(310, 544);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCheck;
        private Label label;
        public static TextBox txtID;
        public static TextBox txtAccount;
    }
}
