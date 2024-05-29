namespace Project {
    partial class Order {
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
            chooseFilm = new ChooseFilm();
            chooseSlot = new ChooseSlot();
            chooseTime = new ChooseTime();
            chooseFood = new ChooseFood();
            final = new Final();
            chooseClient = new ChooseClient();
            SuspendLayout();
            // 
            // chooseFilm
            // 
            chooseFilm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chooseFilm.BackColor = Color.FromArgb(213, 255, 223);
            chooseFilm.Location = new Point(0, 0);
            chooseFilm.Name = "chooseFilm";
            chooseFilm.Size = new Size(1058, 664);
            chooseFilm.TabIndex = 0;
            // 
            // chooseSlot
            // 
            chooseSlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chooseSlot.BackColor = Color.FromArgb(213, 255, 223);
            chooseSlot.Location = new Point(0, 0);
            chooseSlot.Name = "chooseSlot";
            chooseSlot.Size = new Size(1058, 664);
            chooseSlot.TabIndex = 0;
            chooseSlot.Visible = false;
            // 
            // chooseTime
            // 
            chooseTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chooseTime.BackColor = Color.FromArgb(213, 255, 223);
            chooseTime.Location = new Point(0, 0);
            chooseTime.Name = "chooseTime";
            chooseTime.Size = new Size(1058, 664);
            chooseTime.TabIndex = 0;
            chooseTime.Visible = false;
            // 
            // chooseFood
            // 
            chooseFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chooseFood.BackColor = Color.FromArgb(213, 255, 223);
            chooseFood.Location = new Point(0, 0);
            chooseFood.Name = "chooseFood";
            chooseFood.Size = new Size(1058, 664);
            chooseFood.TabIndex = 0;
            chooseFood.Visible = false;
            // 
            // final
            // 
            final.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            final.BackColor = Color.FromArgb(213, 255, 223);
            final.Location = new Point(0, 0);
            final.Name = "final";
            final.Size = new Size(1058, 664);
            final.TabIndex = 0;
            final.Visible = false;
            // 
            // chooseClient
            // 
            chooseClient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chooseClient.BackColor = Color.FromArgb(213, 255, 223);
            chooseClient.Location = new Point(0, 0);
            chooseClient.Name = "chooseClient";
            chooseClient.Size = new Size(1058, 664);
            chooseClient.TabIndex = 0;
            chooseClient.Visible = false;
            // 
            // Order
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            Controls.Add(chooseClient);
            Controls.Add(final);
            Controls.Add(chooseFood);
            Controls.Add(chooseTime);
            Controls.Add(chooseSlot);
            Controls.Add(chooseFilm);
            Font = new Font("Segoe UI", 9F);
            Name = "Order";
            Size = new Size(1058, 664);
            ResumeLayout(false);
        }

        #endregion

        public static ChooseFilm chooseFilm;
        public static ChooseClient chooseClient;
        public static ChooseTime chooseTime;
        public static ChooseSlot chooseSlot;
        public static ChooseFood chooseFood;
        public static Final final;
    }
}
