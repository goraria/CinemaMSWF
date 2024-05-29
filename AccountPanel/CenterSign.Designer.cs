namespace Project {
    partial class CenterSign {
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
            login = new Login();
            check = new Check();
            reset = new Reset();
            accountInfo = new AccountInfo();
            SuspendLayout();
            // 
            // login
            // 
            login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            login.BackColor = Color.Transparent;
            login.Location = new Point(369, 0);
            login.Name = "login";
            login.Size = new Size(310, 544);
            login.TabIndex = 0;
            // 
            // check
            // 
            check.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            check.BackColor = Color.Transparent;
            check.Location = new Point(369, 0);
            check.Name = "check";
            check.Size = new Size(310, 538);
            check.TabIndex = 0;
            check.Visible = false;
            // 
            // reset
            // 
            reset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            reset.BackColor = Color.Transparent;
            reset.Location = new Point(369, 0);
            reset.Name = "reset";
            reset.Size = new Size(310, 544);
            reset.TabIndex = 0;
            reset.Visible = false;
            // 
            // accountInfo
            // 
            accountInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accountInfo.Location = new Point(0, 0);
            accountInfo.Name = "accountInfo";
            accountInfo.Size = new Size(1048, 544);
            accountInfo.TabIndex = 0;
            accountInfo.Visible = false;
            // 
            // CenterSign
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Wheat;
            BackgroundImage = Properties.Resources._8468497;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(accountInfo);
            Controls.Add(reset);
            Controls.Add(check);
            Controls.Add(login);
            DoubleBuffered = true;
            Name = "CenterSign";
            Size = new Size(1048, 544);
            ResumeLayout(false);
        }

        #endregion

        public static AccountInfo accountInfo;
        public static Login login;
        public static Check check;
        public static Reset reset;
    }
}
