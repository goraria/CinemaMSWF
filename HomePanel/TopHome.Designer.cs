namespace Project {
    partial class TopHome {
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
            btnHot = new Button();
            btnNew = new Button();
            SuspendLayout();
            // 
            // btnHot
            // 
            btnHot.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnHot.Location = new Point(200, 5);
            btnHot.Name = "btnHot";
            btnHot.Size = new Size(190, 50);
            btnHot.TabIndex = 0;
            btnHot.Text = "Hotest";
            btnHot.UseVisualStyleBackColor = true;
            btnHot.Click += btnHot_Click;
            // 
            // btnNew
            // 
            btnNew.Enabled = false;
            btnNew.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnNew.Location = new Point(5, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(190, 50);
            btnNew.TabIndex = 1;
            btnNew.Text = "Newest";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // TopHome
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(btnNew);
            Controls.Add(btnHot);
            Name = "TopHome";
            Size = new Size(1058, 60);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHot;
        private Button btnNew;
    }
}
