namespace Project {
    partial class Bill {
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
            dataGridView = new DataGridView();
            billcrud = new BillCRUD();
            billInfo = new BillInfo();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(5, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(700, 544);
            dataGridView.TabIndex = 2;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // billcrud
            // 
            billcrud.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            billcrud.Location = new Point(0, 544);
            billcrud.Name = "billcrud";
            billcrud.Size = new Size(425, 60);
            billcrud.TabIndex = 3;
            // 
            // billInfo
            // 
            billInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            billInfo.Location = new Point(705, 0);
            billInfo.Name = "billInfo";
            billInfo.Size = new Size(353, 604);
            billInfo.TabIndex = 4;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(425, 544);
            label.Name = "label";
            label.Size = new Size(280, 60);
            label.TabIndex = 6;
            label.Text = "Hóa đơn";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bill
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(label);
            Controls.Add(billInfo);
            Controls.Add(billcrud);
            Controls.Add(dataGridView);
            Name = "Bill";
            Size = new Size(1058, 604);
            Load += Bill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BillCRUD billcrud;
        private BillInfo billInfo;
        private Label label;
        public static DataGridView dataGridView;
    }
}
