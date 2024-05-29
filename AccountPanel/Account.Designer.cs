namespace Project {
    partial class Account {
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
            topSign = new TopSign();
            bottomSign = new BottomSign();
            centerSign = new CenterSign();
            SuspendLayout();
            // 
            // topSign
            // 
            topSign.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topSign.Location = new Point(0, 0);
            topSign.Name = "topSign";
            topSign.Size = new Size(1058, 60);
            topSign.TabIndex = 0;
            // 
            // bottomSign
            // 
            bottomSign.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bottomSign.Location = new Point(0, 604);
            bottomSign.Name = "bottomSign";
            bottomSign.Size = new Size(1058, 60);
            bottomSign.TabIndex = 0;
            // 
            // centerSign
            // 
            centerSign.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            centerSign.BackColor = Color.MistyRose;
            centerSign.BackgroundImageLayout = ImageLayout.Stretch;
            centerSign.Location = new Point(5, 60);
            centerSign.Name = "centerSign";
            centerSign.Size = new Size(1048, 544);
            centerSign.TabIndex = 0;
            // 
            // Account
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(centerSign);
            Controls.Add(bottomSign);
            Controls.Add(topSign);
            Font = new Font("Segoe UI", 9F);
            Name = "Account";
            Size = new Size(1058, 664);
            ResumeLayout(false);
        }

        #endregion

        private TopSign topSign;
        private BottomSign bottomSign;
        private CenterSign centerSign;
    }
}
