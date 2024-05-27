namespace DemoDoAnVer02
{
    partial class FAddressInfor
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
            pnlInforOrder = new Panel();
            btnAddAddress = new NewButton();
            label1 = new Label();
            cbbTypeAddress = new ComboBox();
            label20 = new Label();
            tbAddressOrder = new CusTextBox();
            label21 = new Label();
            tbPhoneOrder = new CusTextBox();
            label22 = new Label();
            tbEmailOrder = new CusTextBox();
            tbNameOrder = new CusTextBox();
            label23 = new Label();
            lblInforBuyer = new Label();
            pnlInforOrder.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInforOrder
            // 
            pnlInforOrder.BackColor = Color.White;
            pnlInforOrder.Controls.Add(btnAddAddress);
            pnlInforOrder.Controls.Add(label1);
            pnlInforOrder.Controls.Add(cbbTypeAddress);
            pnlInforOrder.Controls.Add(label20);
            pnlInforOrder.Controls.Add(tbAddressOrder);
            pnlInforOrder.Controls.Add(label21);
            pnlInforOrder.Controls.Add(tbPhoneOrder);
            pnlInforOrder.Controls.Add(label22);
            pnlInforOrder.Controls.Add(tbEmailOrder);
            pnlInforOrder.Controls.Add(tbNameOrder);
            pnlInforOrder.Controls.Add(label23);
            pnlInforOrder.Controls.Add(lblInforBuyer);
            pnlInforOrder.Location = new Point(2, 2);
            pnlInforOrder.Name = "pnlInforOrder";
            pnlInforOrder.Size = new Size(376, 573);
            pnlInforOrder.TabIndex = 12;
            // 
            // btnAddAddress
            // 
            btnAddAddress.BackColor = Color.MediumSeaGreen;
            btnAddAddress.BackgroundColor = Color.MediumSeaGreen;
            btnAddAddress.BorderColor = Color.PaleVioletRed;
            btnAddAddress.BorderRadius = 0;
            btnAddAddress.BorderSize = 0;
            btnAddAddress.FlatAppearance.BorderSize = 0;
            btnAddAddress.FlatStyle = FlatStyle.Flat;
            btnAddAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAddress.ForeColor = Color.White;
            btnAddAddress.Location = new Point(72, 473);
            btnAddAddress.Name = "btnAddAddress";
            btnAddAddress.Size = new Size(212, 40);
            btnAddAddress.TabIndex = 38;
            btnAddAddress.Text = "Thêm địa chỉ";
            btnAddAddress.TextColor = Color.White;
            btnAddAddress.UseVisualStyleBackColor = false;
            btnAddAddress.Click += btnAddAddress_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 387);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 37;
            label1.Text = "Loại địa chỉ";
            // 
            // cbbTypeAddress
            // 
            cbbTypeAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTypeAddress.FormattingEnabled = true;
            cbbTypeAddress.Items.AddRange(new object[] { "Nhà 1", "Nhà 2", "Nhà 3", "Công ty" });
            cbbTypeAddress.Location = new Point(72, 407);
            cbbTypeAddress.Name = "cbbTypeAddress";
            cbbTypeAddress.Size = new Size(212, 29);
            cbbTypeAddress.TabIndex = 36;
            cbbTypeAddress.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(72, 316);
            label20.Name = "label20";
            label20.Size = new Size(47, 17);
            label20.TabIndex = 33;
            label20.Text = "Địa chỉ";
            // 
            // tbAddressOrder
            // 
            tbAddressOrder.BackColor = Color.AliceBlue;
            tbAddressOrder.BorderColor = Color.DodgerBlue;
            tbAddressOrder.BorderFocusColor = Color.LawnGreen;
            tbAddressOrder.BorderRadius = 0;
            tbAddressOrder.BorderSize = 1;
            tbAddressOrder.Cursor = Cursors.IBeam;
            tbAddressOrder.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbAddressOrder.ForeColor = Color.DimGray;
            tbAddressOrder.Location = new Point(72, 336);
            tbAddressOrder.MultiLine = false;
            tbAddressOrder.Name = "tbAddressOrder";
            tbAddressOrder.Padding = new Padding(10, 7, 10, 7);
            tbAddressOrder.PasswordChar = false;
            tbAddressOrder.PlaceholderColor = Color.DarkGray;
            tbAddressOrder.PlaceholderText = "";
            tbAddressOrder.Size = new Size(212, 31);
            tbAddressOrder.TabIndex = 30;
            tbAddressOrder.Texts = "";
            tbAddressOrder.UnderlinedStyle = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(72, 236);
            label21.Name = "label21";
            label21.Size = new Size(39, 17);
            label21.TabIndex = 35;
            label21.Text = "Email";
            // 
            // tbPhoneOrder
            // 
            tbPhoneOrder.BackColor = Color.AliceBlue;
            tbPhoneOrder.BorderColor = Color.DodgerBlue;
            tbPhoneOrder.BorderFocusColor = Color.LawnGreen;
            tbPhoneOrder.BorderRadius = 0;
            tbPhoneOrder.BorderSize = 1;
            tbPhoneOrder.Cursor = Cursors.IBeam;
            tbPhoneOrder.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneOrder.ForeColor = Color.DimGray;
            tbPhoneOrder.Location = new Point(72, 180);
            tbPhoneOrder.MultiLine = false;
            tbPhoneOrder.Name = "tbPhoneOrder";
            tbPhoneOrder.Padding = new Padding(10, 7, 10, 7);
            tbPhoneOrder.PasswordChar = false;
            tbPhoneOrder.PlaceholderColor = Color.DarkGray;
            tbPhoneOrder.PlaceholderText = "";
            tbPhoneOrder.Size = new Size(208, 31);
            tbPhoneOrder.TabIndex = 31;
            tbPhoneOrder.Texts = "";
            tbPhoneOrder.UnderlinedStyle = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(72, 160);
            label22.Name = "label22";
            label22.Size = new Size(85, 17);
            label22.TabIndex = 34;
            label22.Text = "Số điện thoại";
            // 
            // tbEmailOrder
            // 
            tbEmailOrder.BackColor = Color.AliceBlue;
            tbEmailOrder.BorderColor = Color.DodgerBlue;
            tbEmailOrder.BorderFocusColor = Color.LawnGreen;
            tbEmailOrder.BorderRadius = 0;
            tbEmailOrder.BorderSize = 1;
            tbEmailOrder.Cursor = Cursors.IBeam;
            tbEmailOrder.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmailOrder.ForeColor = Color.DimGray;
            tbEmailOrder.Location = new Point(72, 256);
            tbEmailOrder.MultiLine = false;
            tbEmailOrder.Name = "tbEmailOrder";
            tbEmailOrder.Padding = new Padding(10, 7, 10, 7);
            tbEmailOrder.PasswordChar = false;
            tbEmailOrder.PlaceholderColor = Color.DarkGray;
            tbEmailOrder.PlaceholderText = "";
            tbEmailOrder.Size = new Size(208, 31);
            tbEmailOrder.TabIndex = 32;
            tbEmailOrder.Texts = "";
            tbEmailOrder.UnderlinedStyle = false;
            // 
            // tbNameOrder
            // 
            tbNameOrder.BackColor = Color.AliceBlue;
            tbNameOrder.BorderColor = Color.DodgerBlue;
            tbNameOrder.BorderFocusColor = Color.LawnGreen;
            tbNameOrder.BorderRadius = 0;
            tbNameOrder.BorderSize = 1;
            tbNameOrder.Cursor = Cursors.IBeam;
            tbNameOrder.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbNameOrder.ForeColor = Color.DimGray;
            tbNameOrder.Location = new Point(72, 101);
            tbNameOrder.MultiLine = false;
            tbNameOrder.Name = "tbNameOrder";
            tbNameOrder.Padding = new Padding(10, 7, 10, 7);
            tbNameOrder.PasswordChar = false;
            tbNameOrder.PlaceholderColor = Color.DarkGray;
            tbNameOrder.PlaceholderText = "";
            tbNameOrder.Size = new Size(208, 31);
            tbNameOrder.TabIndex = 23;
            tbNameOrder.Texts = "";
            tbNameOrder.UnderlinedStyle = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(72, 81);
            label23.Name = "label23";
            label23.Size = new Size(64, 17);
            label23.TabIndex = 24;
            label23.Text = "Họ và tên";
            // 
            // lblInforBuyer
            // 
            lblInforBuyer.AutoSize = true;
            lblInforBuyer.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblInforBuyer.Location = new Point(25, 23);
            lblInforBuyer.Name = "lblInforBuyer";
            lblInforBuyer.Size = new Size(185, 25);
            lblInforBuyer.TabIndex = 2;
            lblInforBuyer.Text = "Thông tin nhận hàng";
            // 
            // FAddressInfor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 575);
            Controls.Add(pnlInforOrder);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FAddressInfor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm địa chỉ";
            pnlInforOrder.ResumeLayout(false);
            pnlInforOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInforOrder;
        private ComboBox cbbTypeAddress;
        private Label label20;
        private CusTextBox tbAddressOrder;
        private Label label21;
        private CusTextBox tbPhoneOrder;
        private Label label22;
        private CusTextBox tbEmailOrder;
        private CusTextBox tbNameOrder;
        private Label label23;
        private Label lblInforBuyer;
        private Label label1;
        private NewButton btnAddAddress;
    }
}