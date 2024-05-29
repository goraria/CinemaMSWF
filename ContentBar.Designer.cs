namespace Project {
    partial class ContentBar {
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
            homePanel = new Home();
            orderPanel = new Order();
            managePanel = new Manage();
            accountPanel = new Account();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homePanel.BackColor = SystemColors.Control;
            homePanel.Font = new Font("Segoe UI", 9F);
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1058, 664);
            homePanel.TabIndex = 0;
            // 
            // orderPanel
            // 
            orderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderPanel.BackColor = SystemColors.Control;
            orderPanel.Font = new Font("Segoe UI", 9F);
            orderPanel.Location = new Point(0, 0);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(1058, 664);
            orderPanel.TabIndex = 0;
            orderPanel.Visible = false;
            // 
            // managePanel
            // 
            managePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            managePanel.BackColor = SystemColors.Control;
            managePanel.Font = new Font("Segoe UI", 9F);
            managePanel.Location = new Point(0, 0);
            managePanel.Name = "managePanel";
            managePanel.Size = new Size(1058, 664);
            managePanel.TabIndex = 0;
            managePanel.Visible = false;
            // 
            // accountPanel
            // 
            accountPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accountPanel.BackColor = Color.PeachPuff;
            accountPanel.Font = new Font("Segoe UI", 9F);
            accountPanel.Location = new Point(0, 0);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(1058, 664);
            accountPanel.TabIndex = 0;
            accountPanel.Visible = false;
            // 
            // ContentBar
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            Controls.Add(orderPanel);
            Controls.Add(managePanel);
            Controls.Add(homePanel);
            Controls.Add(accountPanel);
            Font = new Font("Segoe UI", 9F);
            Name = "ContentBar";
            Size = new Size(1058, 664);
            ResumeLayout(false);
        }

        #endregion

        public static Home homePanel;
        public static Order orderPanel;
        public static Manage managePanel;
        public static Account accountPanel;
    }
}
