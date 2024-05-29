namespace Project {
    partial class BillCRUD {
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
            btnUpdate = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(320, 5);
            btnUpdate.Margin = new Padding(5, 4, 5, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 50);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Load";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Enabled = false;
            btnDel.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(215, 5);
            btnDel.Margin = new Padding(5, 4, 5, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(100, 50);
            btnDel.TabIndex = 2;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(110, 5);
            btnEdit.Margin = new Padding(5, 4, 5, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 50);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(5, 5);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // BillCRUD
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "BillCRUD";
            Size = new Size(425, 60);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdate;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
    }
}
