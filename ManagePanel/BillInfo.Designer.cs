namespace Project {
    partial class BillInfo {
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
            txtQuantity = new TextBox();
            txtIDBill = new TextBox();
            txtIDFood = new TextBox();
            txtIDClient = new TextBox();
            txtIDStaff = new TextBox();
            groupBox8 = new GroupBox();
            txtDate = new TextBox();
            txtPrice = new TextBox();
            groupBox6 = new GroupBox();
            groupBox9 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox8.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(5, 25);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(333, 25);
            txtQuantity.TabIndex = 0;
            // 
            // txtIDBill
            // 
            txtIDBill.Enabled = false;
            txtIDBill.Location = new Point(5, 25);
            txtIDBill.Margin = new Padding(2);
            txtIDBill.Name = "txtIDBill";
            txtIDBill.Size = new Size(333, 25);
            txtIDBill.TabIndex = 0;
            // 
            // txtIDFood
            // 
            txtIDFood.Location = new Point(5, 25);
            txtIDFood.Margin = new Padding(2);
            txtIDFood.Name = "txtIDFood";
            txtIDFood.Size = new Size(333, 25);
            txtIDFood.TabIndex = 0;
            // 
            // txtIDClient
            // 
            txtIDClient.Location = new Point(5, 25);
            txtIDClient.Margin = new Padding(2);
            txtIDClient.Name = "txtIDClient";
            txtIDClient.Size = new Size(333, 25);
            txtIDClient.TabIndex = 0;
            // 
            // txtIDStaff
            // 
            txtIDStaff.Location = new Point(5, 25);
            txtIDStaff.Margin = new Padding(2);
            txtIDStaff.Name = "txtIDStaff";
            txtIDStaff.Size = new Size(333, 25);
            txtIDStaff.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtDate);
            groupBox8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox8.Location = new Point(5, 383);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(343, 58);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Ngày bán";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(5, 25);
            txtDate.Margin = new Padding(2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(333, 25);
            txtDate.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(5, 25);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(333, 25);
            txtPrice.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtPrice);
            groupBox6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(5, 320);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(343, 58);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tổng giá";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtQuantity);
            groupBox9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox9.Location = new Point(5, 257);
            groupBox9.Margin = new Padding(2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(2);
            groupBox9.Size = new Size(343, 58);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "Số lượng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIDFood);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 68);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(343, 58);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "ID Đồ ăn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIDBill);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(343, 58);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "ID Hóa đơn";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtIDStaff);
            groupBox5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(5, 194);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(343, 58);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "ID Nhân viên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtIDClient);
            groupBox4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(5, 131);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(343, 58);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "ID Khách hàng";
            // 
            // BillInfo
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(groupBox8);
            Controls.Add(groupBox6);
            Controls.Add(groupBox9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Name = "BillInfo";
            Size = new Size(353, 604);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox8;
        private GroupBox groupBox6;
        private GroupBox groupBox9;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        static public TextBox txtIDBill;
        static public TextBox txtIDFood;
        static public TextBox txtIDClient;
        static public TextBox txtIDStaff;
        static public TextBox txtQuantity;
        static public TextBox txtPrice;
        static public TextBox txtDate;
    }
}
