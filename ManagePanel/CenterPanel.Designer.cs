namespace Project {
    partial class CenterPanel {
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
            crud = new CRUD();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // crud
            // 
            crud.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            crud.AutoSize = true;
            crud.BackColor = SystemColors.Control;
            crud.Font = new Font("Segoe UI", 9F);
            crud.Location = new Point(0, 544);
            crud.Margin = new Padding(4);
            crud.Name = "crud";
            crud.Size = new Size(708, 60);
            crud.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(700, 544);
            dataGridView1.TabIndex = 2;
            // 
            // CenterPanel
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(dataGridView1);
            Controls.Add(crud);
            Name = "CenterPanel";
            Size = new Size(708, 604);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CRUD crud;
        private DataGridView dataGridView1;
    }
}
