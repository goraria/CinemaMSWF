namespace Project {
    partial class Final {
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
            btnDiscard = new Button();
            btnPrevious = new Button();
            btnOrder = new Button();
            label = new Label();
            btnTicket = new Button();
            btnFood = new Button();
            foodReview = new FoodReview();
            ticketReview = new TicketReview();
            labelPrice = new Label();
            SuspendLayout();
            // 
            // btnDiscard
            // 
            btnDiscard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDiscard.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiscard.Location = new Point(668, 609);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(190, 50);
            btnDiscard.TabIndex = 0;
            btnDiscard.Text = "Discard";
            btnDiscard.UseVisualStyleBackColor = true;
            btnDiscard.Click += btnDiscard_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrevious.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(473, 5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(190, 50);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnOrder
            // 
            btnOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOrder.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(863, 609);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(190, 50);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // label
            // 
            label.BackColor = SystemColors.Control;
            label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(5, 5);
            label.Name = "label";
            label.Size = new Size(216, 50);
            label.TabIndex = 1;
            label.Text = "Đặt vé";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTicket
            // 
            btnTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTicket.Enabled = false;
            btnTicket.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTicket.Location = new Point(668, 5);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(190, 50);
            btnTicket.TabIndex = 3;
            btnTicket.Text = "Vé";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnFood
            // 
            btnFood.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFood.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFood.Location = new Point(863, 5);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(190, 50);
            btnFood.TabIndex = 3;
            btnFood.Text = "Đồ ăn";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // foodReview
            // 
            foodReview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            foodReview.Location = new Point(5, 60);
            foodReview.Name = "foodReview";
            foodReview.Size = new Size(1048, 544);
            foodReview.TabIndex = 4;
            foodReview.Visible = false;
            // 
            // ticketReview
            // 
            ticketReview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ticketReview.BackColor = Color.Honeydew;
            ticketReview.Location = new Point(5, 60);
            ticketReview.Name = "ticketReview";
            ticketReview.Size = new Size(1048, 544);
            ticketReview.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.BackColor = SystemColors.Control;
            labelPrice.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = SystemColors.ControlText;
            labelPrice.Location = new Point(5, 609);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(216, 50);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Đặt vé";
            labelPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Final
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(ticketReview);
            Controls.Add(foodReview);
            Controls.Add(btnFood);
            Controls.Add(btnTicket);
            Controls.Add(labelPrice);
            Controls.Add(label);
            Controls.Add(btnOrder);
            Controls.Add(btnPrevious);
            Controls.Add(btnDiscard);
            Name = "Final";
            Size = new Size(1058, 664);
            Load += Final_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDiscard;
        private Button btnPrevious;
        private Button btnOrder;
        private Label label;
        private Button btnTicket;
        private Button btnFood;
        public FoodReview foodReview;
        public TicketReview ticketReview;
        public static Label labelPrice;
    }
}
