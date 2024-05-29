namespace Project {
    partial class Home {
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
            filmHot = new FilmHot();
            filmNew = new FilmNew();
            topHome = new TopHome();
            SuspendLayout();
            // 
            // filmHot
            // 
            filmHot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filmHot.BackColor = Color.LightPink;
            filmHot.Location = new Point(0, 60);
            filmHot.Name = "filmHot";
            filmHot.Size = new Size(1058, 604);
            filmHot.TabIndex = 0;
            filmHot.Visible = false;
            // 
            // filmNew
            // 
            filmNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filmNew.BackColor = Color.LightPink;
            filmNew.Location = new Point(0, 60);
            filmNew.Margin = new Padding(0);
            filmNew.Name = "filmNew";
            filmNew.Size = new Size(1058, 604);
            filmNew.TabIndex = 0;
            // 
            // topHome
            // 
            topHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topHome.BackColor = Color.LightPink;
            topHome.Location = new Point(0, 0);
            topHome.Name = "topHome";
            topHome.Size = new Size(1058, 60);
            topHome.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.MistyRose;
            Controls.Add(topHome);
            Controls.Add(filmNew);
            Controls.Add(filmHot);
            Name = "Home";
            Size = new Size(1058, 664);
            ResumeLayout(false);
        }

        #endregion

        private TopHome topHome;
        public static FilmHot filmHot;
        public static FilmNew filmNew;
    }
}
