namespace Project {
    partial class TopPanel {
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
            btnTicket = new Button();
            btnClient = new Button();
            btnStaff = new Button();
            btnFilm = new Button();
            btnFood = new Button();
            btnBill = new Button();
            SuspendLayout();
            // 
            // btnTicket
            // 
            btnTicket.Enabled = false;
            btnTicket.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicket.Location = new Point(5, 5);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(150, 50);
            btnTicket.TabIndex = 0;
            btnTicket.Text = "Vé";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnClient
            // 
            btnClient.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnClient.Location = new Point(315, 5);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(190, 50);
            btnClient.TabIndex = 0;
            btnClient.Text = "Khách hàng";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(510, 5);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(190, 50);
            btnStaff.TabIndex = 0;
            btnStaff.Text = "Nhân viên";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnFilm
            // 
            btnFilm.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnFilm.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilm.Location = new Point(705, 5);
            btnFilm.Name = "btnFilm";
            btnFilm.Size = new Size(150, 50);
            btnFilm.TabIndex = 0;
            btnFilm.Text = "Phim";
            btnFilm.UseVisualStyleBackColor = true;
            btnFilm.Click += btnFilm_Click;
            // 
            // btnFood
            // 
            btnFood.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnFood.Location = new Point(860, 5);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(150, 50);
            btnFood.TabIndex = 0;
            btnFood.Text = "Đồ ăn";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // btnBill
            // 
            btnBill.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnBill.Location = new Point(160, 5);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(150, 50);
            btnBill.TabIndex = 0;
            btnBill.Text = "Hóa đơn";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // TopPanel
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            Controls.Add(btnBill);
            Controls.Add(btnTicket);
            Controls.Add(btnFilm);
            Controls.Add(btnFood);
            Controls.Add(btnStaff);
            Controls.Add(btnClient);
            Font = new Font("Segoe UI", 9F);
            Name = "TopPanel";
            Size = new Size(1058, 60);
            ResumeLayout(false);
        }

        #endregion

        public static Button btnBill;
        public static Button btnTicket;
        public static Button btnClient;
        public static Button btnStaff;
        public static Button btnFilm;
        public static Button btnFood;
    }
}
