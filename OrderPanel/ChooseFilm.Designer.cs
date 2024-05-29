namespace Project {
    partial class ChooseFilm {
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
            label = new Label();
            btnNext = new Button();
            dataGridView = new DataGridView();
            tableLayoutPanel = new TableLayoutPanel();
            pictureBox = new PictureBox();
            panel = new Panel();
            lblDate = new Label();
            lblTime = new Label();
            lblStudio = new Label();
            lblGenre = new Label();
            lblCountry = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.BackColor = SystemColors.Control;
            label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(5, 5);
            label.Name = "label";
            label.Size = new Size(190, 50);
            label.TabIndex = 0;
            label.Text = "Chọn phim";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(863, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(190, 50);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(5, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(350, 599);
            dataGridView.TabIndex = 2;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(panel, 1, 0);
            tableLayoutPanel.Location = new Point(360, 60);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(690, 599);
            tableLayoutPanel.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(408, 593);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.BackColor = Color.White;
            panel.Controls.Add(lblDate);
            panel.Controls.Add(lblTime);
            panel.Controls.Add(lblStudio);
            panel.Controls.Add(lblGenre);
            panel.Controls.Add(lblCountry);
            panel.Controls.Add(lblName);
            panel.Location = new Point(417, 3);
            panel.Name = "panel";
            panel.Size = new Size(270, 593);
            panel.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(5, 280);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(260, 50);
            lblDate.TabIndex = 0;
            lblDate.Text = "Unknown";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(5, 225);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(260, 50);
            lblTime.TabIndex = 0;
            lblTime.Text = "Unknown";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudio
            // 
            lblStudio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStudio.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudio.Location = new Point(5, 170);
            lblStudio.Name = "lblStudio";
            lblStudio.Size = new Size(260, 50);
            lblStudio.TabIndex = 0;
            lblStudio.Text = "Unknown";
            lblStudio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGenre
            // 
            lblGenre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGenre.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(5, 115);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(260, 50);
            lblGenre.TabIndex = 0;
            lblGenre.Text = "Unknown";
            lblGenre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            lblCountry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCountry.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountry.Location = new Point(5, 60);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(260, 50);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Unknown";
            lblCountry.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(5, 5);
            lblName.Name = "lblName";
            lblName.Size = new Size(260, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Unknown";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChooseFilm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(213, 255, 223);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridView);
            Controls.Add(btnNext);
            Controls.Add(label);
            Name = "ChooseFilm";
            Size = new Size(1058, 664);
            Load += ChooseFilm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        private Button btnNext;
        private DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel;
        private PictureBox pictureBox;
        private Panel panel;
        private Label lblName;
        private Label lblDate;
        private Label lblTime;
        private Label lblStudio;
        private Label lblGenre;
        private Label lblCountry;
    }
}
