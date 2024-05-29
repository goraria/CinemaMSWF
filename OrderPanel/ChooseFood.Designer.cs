namespace Project {
    partial class ChooseFood {
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
            btnPrevious = new Button();
            btnNext = new Button();
            label = new Label();
            btnRefresh = new Button();
            dataGridView = new DataGridView();
            panel = new Panel();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            txtQuantity = new TextBox();
            groupBox1 = new GroupBox();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrevious.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(668, 5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(190, 50);
            btnPrevious.TabIndex = 0;
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
            btnNext.TabIndex = 0;
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
            label.Size = new Size(216, 50);
            label.TabIndex = 0;
            label.Text = "Chọn đồ ăn";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(473, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(190, 50);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(5, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(693, 599);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel.Controls.Add(groupBox2);
            panel.Controls.Add(groupBox1);
            panel.Location = new Point(703, 60);
            panel.Name = "panel";
            panel.Size = new Size(350, 599);
            panel.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 68);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(340, 58);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Số lượng";
            // 
            // button2
            // 
            button2.Location = new Point(253, 25);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 1;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            // 
            // button1
            // 
            button1.Location = new Point(5, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 1;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(85, 25);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(163, 28);
            txtQuantity.TabIndex = 0;
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
            groupBox1.Text = "Đồ ăn";
            // 
            // txtName
            // 
            txtName.Location = new Point(5, 25);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 28);
            txtName.TabIndex = 0;
            // 
            // ChooseFood
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(panel);
            Controls.Add(dataGridView);
            Controls.Add(btnRefresh);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(label);
            Name = "ChooseFood";
            Size = new Size(1058, 664);
            Load += ChooseFood_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnPrevious;
        private Button btnNext;
        private Label label;
        private Panel panel;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        static public DataGridView dataGridView;
        public static TextBox txtName;
        static public TextBox txtQuantity;
    }
}
