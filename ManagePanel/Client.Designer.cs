namespace Project {
    partial class Client {
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
            label = new Label();
            clientInfo = new ClientInfo();
            crud = new ClientCRUD();
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
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(425, 544);
            label.Name = "label";
            label.Size = new Size(280, 60);
            label.TabIndex = 4;
            label.Text = "Khách hàng";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clientInfo
            // 
            clientInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            clientInfo.Location = new Point(705, 0);
            clientInfo.Name = "clientInfo";
            clientInfo.Size = new Size(353, 604);
            clientInfo.TabIndex = 0;
            // 
            // crud
            // 
            crud.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            crud.Location = new Point(0, 544);
            crud.Name = "crud";
            crud.Size = new Size(425, 60);
            crud.TabIndex = 5;
            // 
            // Client
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(crud);
            Controls.Add(clientInfo);
            Controls.Add(label);
            Controls.Add(dataGridView);
            Name = "Client";
            Size = new Size(1058, 604);
            Load += Client_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label;
        private ClientInfo clientInfo;
        private ClientCRUD crud;
        public static DataGridView dataGridView;
    }
}
