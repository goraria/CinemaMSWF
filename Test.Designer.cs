namespace Project {
    partial class Test {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            order1 = new Order();
            SuspendLayout();
            // 
            // order1
            // 
            order1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            order1.BackColor = SystemColors.Control;
            order1.Font = new Font("Segoe UI", 9F);
            order1.Location = new Point(0, 0);
            order1.Name = "order1";
            order1.Size = new Size(1058, 664);
            order1.TabIndex = 0;
            // 
            // Test
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1258, 664);
            Controls.Add(order1);
            Name = "Test";
            Text = "Test";
            ResumeLayout(false);
        }

        #endregion

        private Order order1;
    }
}