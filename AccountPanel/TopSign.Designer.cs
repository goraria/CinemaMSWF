namespace Project {
    partial class TopSign {
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
        private void InitializeComponent() {
            btnLogout = new Button();
            btnLogin = new Button();
            btnChange = new Button();
            btnInfo = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Enabled = false;
            btnLogout.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(863, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 50);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(5, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(200, 5);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(190, 50);
            btnChange.TabIndex = 2;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Visible = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnInfo
            // 
            btnInfo.Enabled = false;
            btnInfo.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(5, 5);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(190, 50);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Visible = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // TopSign
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(btnChange);
            Controls.Add(btnInfo);
            Controls.Add(btnLogin);
            Controls.Add(btnLogout);
            Name = "TopSign";
            Size = new Size(1058, 60);
            ResumeLayout(false);
        }

        #endregion

        public static Button btnInfo;
        public static Button btnLogout;
        public static Button btnLogin;
        public static Button btnChange;
    }
}
