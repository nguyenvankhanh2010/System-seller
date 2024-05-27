namespace DemoDoAnVer02
{
    partial class UCProductInCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductInCart));
            panel1 = new Panel();
            lblName = new Label();
            lblPrice = new Label();
            nudQuantity = new NumericUpDown();
            lblTotalPrice = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 62);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Cursor = Cursors.No;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(78, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(146, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Balenciaga Triple S";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Cursor = Cursors.No;
            lblPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(300, 26);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 17);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "$1000";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(411, 23);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(31, 23);
            nudQuantity.TabIndex = 5;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Cursor = Cursors.No;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(522, 26);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(41, 17);
            lblTotalPrice.TabIndex = 6;
            lblTotalPrice.Text = "$1000";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(600, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(44, 37);
            panel2.TabIndex = 7;
            panel2.Click += panel2_Click;
            // 
            // UCProductInCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Controls.Add(lblTotalPrice);
            Controls.Add(nudQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "UCProductInCart";
            Size = new Size(709, 68);
            Load += UCProductInCart_Load;
            Click += UCProduct_Click;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private Label lblPrice;
        private NumericUpDown nudQuantity;
        private Label lblTotalPrice;
        private Panel panel2;
    }
}
