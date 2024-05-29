namespace Project {
    partial class SideBar {
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
            buttonHome = new Button();
            buttonOrder = new Button();
            buttonManage = new Button();
            buttonAccount = new Button();
            SuspendLayout();
            // 
            // buttonHome
            // 
            buttonHome.Enabled = false;
            buttonHome.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(5, 200);
            buttonHome.Margin = new Padding(2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(190, 50);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonOrder.Location = new Point(5, 310);
            buttonOrder.Margin = new Padding(2);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(190, 50);
            buttonOrder.TabIndex = 0;
            buttonOrder.Text = "Order";
            buttonOrder.TextAlign = ContentAlignment.MiddleLeft;
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Visible = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // buttonManage
            // 
            buttonManage.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonManage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonManage.Location = new Point(5, 365);
            buttonManage.Margin = new Padding(2);
            buttonManage.Name = "buttonManage";
            buttonManage.Size = new Size(190, 50);
            buttonManage.TabIndex = 0;
            buttonManage.Text = "Manage";
            buttonManage.TextAlign = ContentAlignment.MiddleLeft;
            buttonManage.UseVisualStyleBackColor = true;
            buttonManage.Visible = false;
            buttonManage.Click += buttonManage_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonAccount.Location = new Point(5, 255);
            buttonAccount.Margin = new Padding(2);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(190, 50);
            buttonAccount.TabIndex = 0;
            buttonAccount.Text = "Account";
            buttonAccount.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccount.UseVisualStyleBackColor = true;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // SideBar
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Pink;
            Controls.Add(buttonAccount);
            Controls.Add(buttonManage);
            Controls.Add(buttonOrder);
            Controls.Add(buttonHome);
            Font = new Font("Segoe UI", 9F);
            Name = "SideBar";
            Size = new Size(200, 664);
            ResumeLayout(false);
        }

        #endregion

        public static Button buttonHome;
        public static Button buttonOrder;
        public static Button buttonManage;
        public static Button buttonAccount;
    }
}
