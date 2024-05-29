namespace Project {
    partial class Manage {
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
            topPanel = new TopPanel();
            clientPanel = new Client();
            filmPanel = new Film();
            foodPanel = new Food();
            staffPanel = new Staff();
            ticketPanel = new Ticket();
            billPanel = new Bill();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topPanel.AutoSize = true;
            topPanel.BackColor = Color.AliceBlue;
            topPanel.Font = new Font("Segoe UI", 9F);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1058, 60);
            topPanel.TabIndex = 0;
            // 
            // clientPanel
            // 
            clientPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientPanel.BackColor = Color.AliceBlue;
            clientPanel.Location = new Point(0, 60);
            clientPanel.Name = "clientPanel";
            clientPanel.Size = new Size(1058, 607);
            clientPanel.TabIndex = 0;
            clientPanel.Visible = false;
            // 
            // filmPanel
            // 
            filmPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filmPanel.BackColor = Color.AliceBlue;
            filmPanel.Location = new Point(0, 60);
            filmPanel.Name = "filmPanel";
            filmPanel.Size = new Size(1058, 607);
            filmPanel.TabIndex = 0;
            filmPanel.Visible = false;
            // 
            // foodPanel
            // 
            foodPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            foodPanel.BackColor = Color.AliceBlue;
            foodPanel.Location = new Point(0, 60);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(1058, 607);
            foodPanel.TabIndex = 0;
            foodPanel.Visible = false;
            // 
            // staffPanel
            // 
            staffPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            staffPanel.BackColor = Color.AliceBlue;
            staffPanel.Location = new Point(0, 60);
            staffPanel.Name = "staffPanel";
            staffPanel.Size = new Size(1058, 607);
            staffPanel.TabIndex = 0;
            staffPanel.Visible = false;
            // 
            // ticketPanel
            // 
            ticketPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ticketPanel.BackColor = Color.AliceBlue;
            ticketPanel.Location = new Point(0, 60);
            ticketPanel.Name = "ticketPanel";
            ticketPanel.Size = new Size(1058, 607);
            ticketPanel.TabIndex = 0;
            // 
            // billPanel
            // 
            billPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            billPanel.BackColor = Color.AliceBlue;
            billPanel.Location = new Point(0, 60);
            billPanel.Name = "billPanel";
            billPanel.Size = new Size(1058, 607);
            billPanel.TabIndex = 0;
            billPanel.Visible = false;
            // 
            // Manage
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.AliceBlue;
            Controls.Add(billPanel);
            Controls.Add(ticketPanel);
            Controls.Add(staffPanel);
            Controls.Add(foodPanel);
            Controls.Add(filmPanel);
            Controls.Add(clientPanel);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            Name = "Manage";
            Size = new Size(1058, 664);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TopPanel topPanel;
        public static Bill billPanel;
        public static Ticket ticketPanel;
        public static Client clientPanel;
        public static Staff staffPanel;
        public static Film filmPanel;
        public static Food foodPanel;
    }
}
