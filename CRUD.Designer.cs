namespace Project {
    partial class CRUD {
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(5, 5);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(110, 5);
            btnEdit.Margin = new Padding(5, 4, 5, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 50);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(215, 5);
            btnDel.Margin = new Padding(5, 4, 5, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(100, 50);
            btnDel.TabIndex = 0;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(320, 5);
            btnUpdate.Margin = new Padding(5, 4, 5, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 50);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Load";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // CRUD
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "CRUD";
            Size = new Size(425, 60);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDel;
        private Button btnUpdate;
    }
}
