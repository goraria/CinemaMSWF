namespace Project {
    partial class AccountInfo {
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
            lblID = new Label();
            label = new Label();
            lblName = new Label();
            lblBirth = new Label();
            lblAddress = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblID.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(5, 100);
            lblID.Name = "lblID";
            lblID.Size = new Size(1038, 50);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(5, 5);
            label.Name = "label";
            label.Size = new Size(1038, 90);
            label.TabIndex = 0;
            label.Text = "Thông tin";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(5, 155);
            lblName.Name = "lblName";
            lblName.Size = new Size(1038, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBirth
            // 
            lblBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBirth.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirth.Location = new Point(5, 210);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(1038, 50);
            lblBirth.TabIndex = 0;
            lblBirth.Text = "Bỉthday";
            lblBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddress.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(5, 265);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(1038, 50);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGender.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(5, 320);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(1038, 50);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(5, 375);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(1038, 50);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AccountInfo
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(label);
            Controls.Add(lblPhone);
            Controls.Add(lblGender);
            Controls.Add(lblAddress);
            Controls.Add(lblBirth);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Name = "AccountInfo";
            Size = new Size(1048, 544);
            Load += AccountInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        public static Label lblID;
        public static Label lblName;
        public static Label lblBirth;
        public static Label lblAddress;
        public static Label lblGender;
        public static Label lblPhone;
    }
}
