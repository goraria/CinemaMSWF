namespace Project {
    partial class FilmIcon {
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
            pictureBox = new PictureBox();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(5, 5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(193, 246);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.ImageLocation = ""; /**/
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(5, 256);
            label.Name = "label";
            label.Size = new Size(193, 32);
            label.TabIndex = 1;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = ""; /**/
            // 
            // FilmIcon
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(label);
            Controls.Add(pictureBox);
            Name = "FilmIcon";
            Size = new Size(203, 293);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pictureBox;
        public Label label;
    }
}
