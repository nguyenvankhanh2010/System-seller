namespace DemoDoAnVer02
{
    partial class FProductView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProductView));
            pnlControlBar = new Panel();
            nudQuantity = new NumericUpDown();
            lblUser = new Label();
            lblSeller1 = new Label();
            btnBackPic = new NewButton();
            btnNextPic = new NewButton();
            btnAddToCart = new NewButton();
            pnlHomeBar = new Panel();
            pnlLogo = new Panel();
            pnlProductView1 = new Panel();
            lblProductName = new Label();
            lblResell = new Label();
            lblRetail = new Label();
            lblTypeProduct = new Label();
            lblbrand = new Label();
            lblDeInPic = new Label();
            lblDecribe = new Label();
            lblNameProduct1 = new Label();
            lblBrandProduct1 = new Label();
            lblRetail1 = new Label();
            lblResell1 = new Label();
            lblType = new Label();
            lblDecribe1 = new Label();
            lblDeInPic1 = new Label();
            flpProduct = new FlowLayoutPanel();
            label1 = new Label();
            lblAddress = new Label();
            label3 = new Label();
            label2 = new Label();
            flbRate = new FlowLayoutPanel();
            lblNumRate = new Label();
            label5 = new Label();
            label4 = new Label();
            lblNumBuy = new Label();
            pnlControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlHomeBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlControlBar
            // 
            pnlControlBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlControlBar.BackColor = Color.Gold;
            pnlControlBar.Controls.Add(nudQuantity);
            pnlControlBar.Controls.Add(lblUser);
            pnlControlBar.Controls.Add(lblSeller1);
            pnlControlBar.Controls.Add(btnBackPic);
            pnlControlBar.Controls.Add(btnNextPic);
            pnlControlBar.Controls.Add(btnAddToCart);
            pnlControlBar.Location = new Point(205, 0);
            pnlControlBar.Name = "pnlControlBar";
            pnlControlBar.Size = new Size(570, 74);
            pnlControlBar.TabIndex = 0;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(327, 23);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(31, 23);
            nudQuantity.TabIndex = 19;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Cursor = Cursors.No;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = SystemColors.InfoText;
            lblUser.Location = new Point(123, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(56, 21);
            lblUser.TabIndex = 18;
            lblUser.Text = "user01";
            // 
            // lblSeller1
            // 
            lblSeller1.AutoSize = true;
            lblSeller1.Cursor = Cursors.No;
            lblSeller1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeller1.ForeColor = SystemColors.WindowFrame;
            lblSeller1.Location = new Point(33, 28);
            lblSeller1.Name = "lblSeller1";
            lblSeller1.Size = new Size(84, 19);
            lblSeller1.TabIndex = 17;
            lblSeller1.Text = "Người bán: ";
            // 
            // btnBackPic
            // 
            btnBackPic.Anchor = AnchorStyles.Bottom;
            btnBackPic.BackColor = Color.Gold;
            btnBackPic.BackgroundColor = Color.Gold;
            btnBackPic.BackgroundImage = (Image)resources.GetObject("btnBackPic.BackgroundImage");
            btnBackPic.BackgroundImageLayout = ImageLayout.Zoom;
            btnBackPic.BorderColor = Color.PaleVioletRed;
            btnBackPic.BorderRadius = 0;
            btnBackPic.BorderSize = 0;
            btnBackPic.Cursor = Cursors.Hand;
            btnBackPic.FlatAppearance.BorderSize = 0;
            btnBackPic.FlatStyle = FlatStyle.Flat;
            btnBackPic.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackPic.ForeColor = Color.Black;
            btnBackPic.Location = new Point(188, 11);
            btnBackPic.Name = "btnBackPic";
            btnBackPic.Size = new Size(55, 49);
            btnBackPic.TabIndex = 2;
            btnBackPic.TextColor = Color.Black;
            btnBackPic.UseVisualStyleBackColor = false;
            btnBackPic.Click += btnBackPic_Click;
            // 
            // btnNextPic
            // 
            btnNextPic.Anchor = AnchorStyles.Bottom;
            btnNextPic.BackColor = Color.Gold;
            btnNextPic.BackgroundColor = Color.Gold;
            btnNextPic.BackgroundImage = (Image)resources.GetObject("btnNextPic.BackgroundImage");
            btnNextPic.BackgroundImageLayout = ImageLayout.Zoom;
            btnNextPic.BorderColor = Color.PaleVioletRed;
            btnNextPic.BorderRadius = 0;
            btnNextPic.BorderSize = 0;
            btnNextPic.Cursor = Cursors.Hand;
            btnNextPic.FlatAppearance.BorderSize = 0;
            btnNextPic.FlatStyle = FlatStyle.Flat;
            btnNextPic.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPic.ForeColor = Color.Black;
            btnNextPic.Location = new Point(249, 11);
            btnNextPic.Name = "btnNextPic";
            btnNextPic.Size = new Size(55, 49);
            btnNextPic.TabIndex = 1;
            btnNextPic.TextColor = Color.Black;
            btnNextPic.UseVisualStyleBackColor = false;
            btnNextPic.Click += btnNextPic_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddToCart.BackColor = Color.MediumSeaGreen;
            btnAddToCart.BackgroundColor = Color.MediumSeaGreen;
            btnAddToCart.BorderColor = Color.PaleVioletRed;
            btnAddToCart.BorderRadius = 0;
            btnAddToCart.BorderSize = 0;
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.Location = new Point(384, 12);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(173, 49);
            btnAddToCart.TabIndex = 0;
            btnAddToCart.Text = "Thêm vào giỏ hàng";
            btnAddToCart.TextColor = Color.Black;
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // pnlHomeBar
            // 
            pnlHomeBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHomeBar.BackColor = Color.Gold;
            pnlHomeBar.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHomeBar.Controls.Add(pnlLogo);
            pnlHomeBar.Controls.Add(pnlControlBar);
            pnlHomeBar.Location = new Point(-2, 1);
            pnlHomeBar.Name = "pnlHomeBar";
            pnlHomeBar.Size = new Size(993, 72);
            pnlHomeBar.TabIndex = 1;
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImage = Properties.Resources.Logo_01;
            pnlLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pnlLogo.Cursor = Cursors.AppStarting;
            pnlLogo.Location = new Point(62, 9);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(52, 50);
            pnlLogo.TabIndex = 4;
            pnlLogo.Click += pnlLogo_Click;
            // 
            // pnlProductView1
            // 
            pnlProductView1.Anchor = AnchorStyles.Top;
            pnlProductView1.BackgroundImage = (Image)resources.GetObject("pnlProductView1.BackgroundImage");
            pnlProductView1.BackgroundImageLayout = ImageLayout.Zoom;
            pnlProductView1.Location = new Point(314, 96);
            pnlProductView1.Name = "pnlProductView1";
            pnlProductView1.Size = new Size(341, 235);
            pnlProductView1.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Cursor = Cursors.No;
            lblProductName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.ForeColor = SystemColors.WindowFrame;
            lblProductName.Location = new Point(53, 124);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(95, 19);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Tên sản phẩm";
            // 
            // lblResell
            // 
            lblResell.AutoSize = true;
            lblResell.Cursor = Cursors.No;
            lblResell.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblResell.ForeColor = SystemColors.WindowFrame;
            lblResell.Location = new Point(685, 160);
            lblResell.Name = "lblResell";
            lblResell.Size = new Size(57, 19);
            lblResell.TabIndex = 4;
            lblResell.Text = "Giá bán";
            // 
            // lblRetail
            // 
            lblRetail.AutoSize = true;
            lblRetail.Cursor = Cursors.No;
            lblRetail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRetail.ForeColor = SystemColors.WindowFrame;
            lblRetail.Location = new Point(685, 110);
            lblRetail.Name = "lblRetail";
            lblRetail.Size = new Size(88, 19);
            lblRetail.TabIndex = 5;
            lblRetail.Text = "Giá niêm yết";
            // 
            // lblTypeProduct
            // 
            lblTypeProduct.AutoSize = true;
            lblTypeProduct.Cursor = Cursors.No;
            lblTypeProduct.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeProduct.ForeColor = SystemColors.WindowFrame;
            lblTypeProduct.Location = new Point(78, 236);
            lblTypeProduct.Name = "lblTypeProduct";
            lblTypeProduct.Size = new Size(70, 19);
            lblTypeProduct.TabIndex = 6;
            lblTypeProduct.Text = "Loại hàng";
            // 
            // lblbrand
            // 
            lblbrand.AutoSize = true;
            lblbrand.Cursor = Cursors.No;
            lblbrand.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblbrand.ForeColor = SystemColors.WindowFrame;
            lblbrand.Location = new Point(50, 176);
            lblbrand.Name = "lblbrand";
            lblbrand.Size = new Size(98, 19);
            lblbrand.TabIndex = 7;
            lblbrand.Text = "Hãng sản xuất";
            // 
            // lblDeInPic
            // 
            lblDeInPic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDeInPic.AutoSize = true;
            lblDeInPic.Cursor = Cursors.No;
            lblDeInPic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeInPic.ForeColor = SystemColors.WindowFrame;
            lblDeInPic.Location = new Point(685, 268);
            lblDeInPic.Name = "lblDeInPic";
            lblDeInPic.Size = new Size(150, 19);
            lblDeInPic.TabIndex = 8;
            lblDeInPic.Text = "Tình trạng ( Trên ảnh )";
            // 
            // lblDecribe
            // 
            lblDecribe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDecribe.AutoSize = true;
            lblDecribe.Cursor = Cursors.No;
            lblDecribe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDecribe.ForeColor = SystemColors.WindowFrame;
            lblDecribe.Location = new Point(683, 213);
            lblDecribe.Name = "lblDecribe";
            lblDecribe.Size = new Size(46, 19);
            lblDecribe.TabIndex = 9;
            lblDecribe.Text = "Mô tả";
            // 
            // lblNameProduct1
            // 
            lblNameProduct1.AutoSize = true;
            lblNameProduct1.Cursor = Cursors.No;
            lblNameProduct1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameProduct1.ForeColor = SystemColors.InfoText;
            lblNameProduct1.Location = new Point(169, 121);
            lblNameProduct1.Name = "lblNameProduct1";
            lblNameProduct1.Size = new Size(146, 21);
            lblNameProduct1.TabIndex = 10;
            lblNameProduct1.Text = "Balenciaga Triple S";
            // 
            // lblBrandProduct1
            // 
            lblBrandProduct1.AutoSize = true;
            lblBrandProduct1.Cursor = Cursors.No;
            lblBrandProduct1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrandProduct1.ForeColor = SystemColors.InfoText;
            lblBrandProduct1.Location = new Point(169, 173);
            lblBrandProduct1.Name = "lblBrandProduct1";
            lblBrandProduct1.Size = new Size(88, 21);
            lblBrandProduct1.TabIndex = 11;
            lblBrandProduct1.Text = "Balenciaga";
            // 
            // lblRetail1
            // 
            lblRetail1.AutoSize = true;
            lblRetail1.Cursor = Cursors.No;
            lblRetail1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRetail1.ForeColor = SystemColors.InfoText;
            lblRetail1.Location = new Point(794, 107);
            lblRetail1.Name = "lblRetail1";
            lblRetail1.Size = new Size(56, 21);
            lblRetail1.TabIndex = 12;
            lblRetail1.Text = "1250 $";
            // 
            // lblResell1
            // 
            lblResell1.AutoSize = true;
            lblResell1.Cursor = Cursors.No;
            lblResell1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResell1.ForeColor = SystemColors.InfoText;
            lblResell1.Location = new Point(763, 157);
            lblResell1.Name = "lblResell1";
            lblResell1.Size = new Size(56, 21);
            lblResell1.TabIndex = 13;
            lblResell1.Text = "1000 $";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Cursor = Cursors.No;
            lblType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.ForeColor = SystemColors.InfoText;
            lblType.Location = new Point(169, 233);
            lblType.Name = "lblType";
            lblType.Size = new Size(74, 21);
            lblType.TabIndex = 14;
            lblType.Text = "Giày dép";
            // 
            // lblDecribe1
            // 
            lblDecribe1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDecribe1.AutoSize = true;
            lblDecribe1.Cursor = Cursors.No;
            lblDecribe1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDecribe1.ForeColor = SystemColors.InfoText;
            lblDecribe1.Location = new Point(756, 210);
            lblDecribe1.Name = "lblDecribe1";
            lblDecribe1.Size = new Size(123, 42);
            lblDecribe1.TabIndex = 15;
            lblDecribe1.Text = "Hàng used 90%\r\nFull box\r\n";
            // 
            // lblDeInPic1
            // 
            lblDeInPic1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDeInPic1.AutoSize = true;
            lblDeInPic1.Cursor = Cursors.No;
            lblDeInPic1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeInPic1.ForeColor = SystemColors.InfoText;
            lblDeInPic1.Location = new Point(690, 297);
            lblDeInPic1.Name = "lblDeInPic1";
            lblDeInPic1.Size = new Size(45, 21);
            lblDeInPic1.TabIndex = 16;
            lblDeInPic1.Text = "Ố đế";
            // 
            // flpProduct
            // 
            flpProduct.AutoScroll = true;
            flpProduct.BackColor = Color.WhiteSmoke;
            flpProduct.Location = new Point(2, 630);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(1000, 260);
            flpProduct.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 607);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 18;
            label1.Text = "Sản phẩm liên quan";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Cursor = Cursors.No;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = SystemColors.InfoText;
            lblAddress.Location = new Point(169, 295);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 21);
            lblAddress.TabIndex = 20;
            lblAddress.Text = "Ho Chi Minh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.No;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(95, 297);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 19;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 392);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 21;
            label2.Text = "Đánh giá sản phẩm";
            // 
            // flbRate
            // 
            flbRate.AutoScroll = true;
            flbRate.BackColor = Color.WhiteSmoke;
            flbRate.Location = new Point(2, 414);
            flbRate.Margin = new Padding(3, 2, 3, 2);
            flbRate.Name = "flbRate";
            flbRate.Size = new Size(1000, 178);
            flbRate.TabIndex = 22;
            // 
            // lblNumRate
            // 
            lblNumRate.AutoSize = true;
            lblNumRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumRate.Location = new Point(404, 351);
            lblNumRate.Name = "lblNumRate";
            lblNumRate.Size = new Size(52, 21);
            lblNumRate.TabIndex = 23;
            lblNumRate.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(327, 351);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 24;
            label5.Text = "Đánh giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(507, 353);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 25;
            label4.Text = "Lượt mua";
            // 
            // lblNumBuy
            // 
            lblNumBuy.AutoSize = true;
            lblNumBuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumBuy.Location = new Point(586, 353);
            lblNumBuy.Name = "lblNumBuy";
            lblNumBuy.Size = new Size(52, 21);
            lblNumBuy.TabIndex = 26;
            lblNumBuy.Text = "label6";
            // 
            // FProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1013, 720);
            Controls.Add(lblNumBuy);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblNumRate);
            Controls.Add(flbRate);
            Controls.Add(label2);
            Controls.Add(lblAddress);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(flpProduct);
            Controls.Add(lblDeInPic1);
            Controls.Add(lblDecribe1);
            Controls.Add(lblType);
            Controls.Add(lblResell1);
            Controls.Add(lblRetail1);
            Controls.Add(lblBrandProduct1);
            Controls.Add(lblNameProduct1);
            Controls.Add(lblDecribe);
            Controls.Add(lblDeInPic);
            Controls.Add(lblbrand);
            Controls.Add(lblTypeProduct);
            Controls.Add(lblRetail);
            Controls.Add(lblResell);
            Controls.Add(lblProductName);
            Controls.Add(pnlProductView1);
            Controls.Add(pnlHomeBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FProductView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FProductViewcs";
            Load += FProductView_Load;
            pnlControlBar.ResumeLayout(false);
            pnlControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlHomeBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlControlBar;
        private Panel pnlHomeBar;
        private Panel pnlLogo;
        private Panel pnlProductView1;
        private NewButton btnAddToCart;
        private Label lblProductName;
        private Label lblResell;
        private Label lblRetail;
        private Label lblTypeProduct;
        private Label lblbrand;
        private Label lblDeInPic;
        private Label lblDecribe;
        private Label lblNameProduct1;
        private Label lblBrandProduct1;
        private Label lblRetail1;
        private Label lblResell1;
        private Label lblType;
        private Label lblDecribe1;
        private Label lblDeInPic1;
        private NewButton btnBackPic;
        private NewButton btnNextPic;
        private Label lblUser;
        private Label lblSeller1;
        private NumericUpDown nudQuantity;
        private FlowLayoutPanel flpProduct;
        private Label label1;
        private Label lblAddress;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flbRate;
        private Label lblNumRate;
        private Label label5;
        private Label label4;
        private Label lblNumBuy;
    }
}