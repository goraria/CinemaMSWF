namespace Project {
    partial class Cinema {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            sideBar = new SideBar();
            contentBar = new ContentBar();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sideBar.BackColor = Color.Thistle;
            sideBar.Font = new Font("Segoe UI", 9F);
            sideBar.Location = new Point(0, 0);
            sideBar.Margin = new Padding(5, 4, 5, 4);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(200, 664);
            sideBar.TabIndex = 0;
            // 
            // contentBar
            // 
            contentBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentBar.BackColor = SystemColors.Control;
            contentBar.Font = new Font("Segoe UI", 9F);
            contentBar.Location = new Point(200, 0);
            contentBar.Margin = new Padding(5, 4, 5, 4);
            contentBar.Name = "contentBar";
            contentBar.Size = new Size(1058, 664);
            contentBar.TabIndex = 1;
            // 
            // Cinema
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1258, 664);
            Controls.Add(contentBar);
            Controls.Add(sideBar);
            MinimumSize = new Size(1280, 720);
            Name = "Cinema";
            Text = "Cinema";
            ResumeLayout(false);
        }

        #endregion

        private SideBar sideBar;
        private ContentBar contentBar;
    }
}
