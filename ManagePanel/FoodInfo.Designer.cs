namespace Project {
    partial class FoodInfo {
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
            groupBox2 = new GroupBox();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            txtID = new TextBox();
            groupBox4 = new GroupBox();
            txtQuantity = new TextBox();
            groupBox3 = new GroupBox();
            txtType = new TextBox();
            txtPrice = new TextBox();
            groupBox5 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtName);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 68);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(343, 58);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(5, 24);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 25);
            txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtID);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(343, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID Đồ ăn";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(5, 24);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(333, 25);
            txtID.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtQuantity);
            groupBox4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(5, 194);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(343, 58);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(5, 24);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(333, 25);
            txtQuantity.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtType);
            groupBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(5, 131);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(343, 58);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại";
            // 
            // txtType
            // 
            txtType.Location = new Point(5, 24);
            txtType.Margin = new Padding(2);
            txtType.Name = "txtType";
            txtType.Size = new Size(333, 25);
            txtType.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(5, 24);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(333, 25);
            txtPrice.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtPrice);
            groupBox5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(5, 257);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(343, 58);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Giá";
            // 
            // FoodInfo
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Name = "FoodInfo";
            Size = new Size(353, 604);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        static public TextBox txtID;
        static public TextBox txtName;
        static public TextBox txtPrice;
        static public TextBox txtQuantity;
        static public TextBox txtType;
    }
}
