namespace Project {
    partial class TicketReview {
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
            label0 = new Label();
            lblDate = new Label();
            lblSlot = new Label();
            lblRoom = new Label();
            lblTime = new Label();
            lblFilm = new Label();
            SuspendLayout();
            // 
            // label0
            // 
            label0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label0.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label0.Location = new Point(5, 5);
            label0.Name = "label0";
            label0.Size = new Size(1038, 90);
            label0.TabIndex = 8;
            label0.Text = "Thông tin Vé";
            label0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(5, 320);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(1038, 50);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSlot
            // 
            lblSlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSlot.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlot.Location = new Point(5, 265);
            lblSlot.Name = "lblSlot";
            lblSlot.Size = new Size(1038, 50);
            lblSlot.TabIndex = 10;
            lblSlot.Text = "Slot";
            lblSlot.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoom
            // 
            lblRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRoom.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(5, 210);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(1038, 50);
            lblRoom.TabIndex = 11;
            lblRoom.Text = "Room";
            lblRoom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(5, 155);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(1038, 50);
            lblTime.TabIndex = 12;
            lblTime.Text = "Time";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFilm
            // 
            lblFilm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFilm.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilm.Location = new Point(5, 100);
            lblFilm.Name = "lblFilm";
            lblFilm.Size = new Size(1038, 50);
            lblFilm.TabIndex = 13;
            lblFilm.Text = "Film";
            lblFilm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TicketReview
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(label0);
            Controls.Add(lblDate);
            Controls.Add(lblSlot);
            Controls.Add(lblRoom);
            Controls.Add(lblTime);
            Controls.Add(lblFilm);
            Name = "TicketReview";
            Size = new Size(1048, 544);
            ResumeLayout(false);
        }

        #endregion

        private Label label0;
        public static Label lblDate;
        public static Label lblSlot;
        public static Label lblRoom;
        public static Label lblTime;
        public static Label lblFilm;
    }
}
