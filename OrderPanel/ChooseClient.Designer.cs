namespace Project {
    partial class ChooseClient {
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
            panel = new Panel();
            groupBox5 = new GroupBox();
            txtPhone = new TextBox();
            groupBox4 = new GroupBox();
            txtGender = new TextBox();
            groupBox3 = new GroupBox();
            txtAddress = new TextBox();
            groupBox2 = new GroupBox();
            txtBirthday = new TextBox();
            groupBox1 = new GroupBox();
            txtName = new TextBox();
            dataGridView = new DataGridView();
            btnPrevious = new Button();
            btnNext = new Button();
            label = new Label();
            panel.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel.Controls.Add(groupBox5);
            panel.Controls.Add(groupBox4);
            panel.Controls.Add(groupBox3);
            panel.Controls.Add(groupBox2);
            panel.Controls.Add(groupBox1);
            panel.Location = new Point(703, 60);
            panel.Name = "panel";
            panel.Size = new Size(350, 599);
            panel.TabIndex = 10;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtPhone);
            groupBox5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(5, 257);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(340, 58);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Số điện thoại";
            // 
            // txtPhone
            // 
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(5, 25);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(333, 25);
            txtPhone.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtGender);
            groupBox4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(5, 194);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(340, 58);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Giới tính";
            // 
            // txtGender
            // 
            txtGender.Enabled = false;
            txtGender.Location = new Point(5, 25);
            txtGender.Margin = new Padding(2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(333, 25);
            txtGender.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(5, 131);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(340, 58);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            txtAddress.Enabled = false;
            txtAddress.Location = new Point(5, 25);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(333, 25);
            txtAddress.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBirthday);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 68);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(340, 58);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ngày sinh";
            // 
            // txtBirthday
            // 
            txtBirthday.Enabled = false;
            txtBirthday.Location = new Point(5, 25);
            txtBirthday.Margin = new Padding(2);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(333, 25);
            txtBirthday.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(340, 58);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Họ tên";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(5, 25);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 25);
            txtName.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(5, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(693, 599);
            dataGridView.TabIndex = 9;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrevious.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(668, 5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(190, 50);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(863, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(190, 50);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label
            // 
            label.BackColor = SystemColors.Control;
            label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(5, 5);
            label.Name = "label";
            label.Size = new Size(253, 50);
            label.TabIndex = 8;
            label.Text = "Chọn khách hàng";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChooseClient
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(panel);
            Controls.Add(dataGridView);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(label);
            Name = "ChooseClient";
            Size = new Size(1058, 664);
            Load += ChooseClient_Load;
            panel.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private GroupBox groupBox1;
        public static DataGridView dataGridView;
        private Button btnPrevious;
        private Button btnNext;
        private Label label;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        public static TextBox txtName;
        public static TextBox txtBirthday;
        public static TextBox txtAddress;
        public static TextBox txtGender;
        public static TextBox txtPhone;
    }
}
