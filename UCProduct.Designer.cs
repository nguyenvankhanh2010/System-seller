namespace DemoDoAnVer02
{
    partial class UCProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProduct));
            lblName = new Label();
            lblPrice = new Label();
            panel1 = new Panel();
            pnlAddToCart = new Panel();
            lblOldPrice = new Label();
            lblAddress = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(3, 169);
            lblName.Name = "lblName";
            lblName.Size = new Size(139, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Balenciaga Triple S";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(3, 213);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "1000$";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 166);
            panel1.TabIndex = 3;
            panel1.Click += panel1_Click;
            // 
            // pnlAddToCart
            // 
            pnlAddToCart.BackgroundImage = (Image)resources.GetObject("pnlAddToCart.BackgroundImage");
            pnlAddToCart.BackgroundImageLayout = ImageLayout.Zoom;
            pnlAddToCart.Location = new Point(87, 191);
            pnlAddToCart.Name = "pnlAddToCart";
            pnlAddToCart.Size = new Size(55, 45);
            pnlAddToCart.TabIndex = 4;
            pnlAddToCart.Click += pnlAddToCart_Click;
            // 
            // lblOldPrice
            // 
            lblOldPrice.AutoSize = true;
            lblOldPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblOldPrice.ForeColor = Color.Gray;
            lblOldPrice.Location = new Point(3, 191);
            lblOldPrice.Name = "lblOldPrice";
            lblOldPrice.Size = new Size(47, 19);
            lblOldPrice.TabIndex = 5;
            lblOldPrice.Text = "1000$";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.DimGray;
            lblAddress.Location = new Point(27, 239);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Ho Chi Minh";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(3, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 18);
            panel2.TabIndex = 7;
            // 
            // UCProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(lblAddress);
            Controls.Add(lblOldPrice);
            Controls.Add(pnlAddToCart);
            Controls.Add(panel1);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Cursor = Cursors.Hand;
            Name = "UCProduct";
            Size = new Size(146, 257);
            Load += UCProduct_Load;
            Click += UCProduct_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        internal Label lblName;
        internal Label lblPrice;
        internal Label lblOldPrice;
        internal Label lblAddress;
        private Panel panel2;
        internal Panel pnlAddToCart;
    }
}
