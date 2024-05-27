namespace DemoDoAnVer02
{
    partial class FBank_pay
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
            label1 = new Label();
            ccbBank = new CusComboBox();
            label2 = new Label();
            label3 = new Label();
            btnAddBank_Pay = new CusButton();
            pictureBox1 = new PictureBox();
            tbName1_pay = new CusTextBox();
            tbNum_pay = new CusTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(279, 20);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN TÀI KHOẢN NGÂN HÀNG";
            // 
            // ccbBank
            // 
            ccbBank.BackColor = Color.Honeydew;
            ccbBank.BorderColor = Color.MediumSlateBlue;
            ccbBank.BorderSize = 0;
            ccbBank.DropDownStyle = ComboBoxStyle.DropDownList;
            ccbBank.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ccbBank.ForeColor = Color.Black;
            ccbBank.IconColor = Color.Black;
            ccbBank.Items.AddRange(new object[] { "BIDV", "VIETCOMBANK", "TECHCOMBANK", "TPBANK", "MBBANK", "VPBANK" });
            ccbBank.ListBackColor = Color.Beige;
            ccbBank.ListTextColor = Color.Black;
            ccbBank.Location = new Point(65, 80);
            ccbBank.MinimumSize = new Size(200, 30);
            ccbBank.Name = "ccbBank";
            ccbBank.Size = new Size(306, 36);
            ccbBank.TabIndex = 41;
            ccbBank.Texts = "Chọn ngân hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 214);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 42;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 140);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 43;
            label3.Text = "Số tài khoản";
            // 
            // btnAddBank_Pay
            // 
            btnAddBank_Pay.BackColor = Color.MediumSeaGreen;
            btnAddBank_Pay.BackgroundColor = Color.MediumSeaGreen;
            btnAddBank_Pay.BorderColor = Color.PaleVioletRed;
            btnAddBank_Pay.BorderRadius = 20;
            btnAddBank_Pay.BorderSize = 0;
            btnAddBank_Pay.FlatAppearance.BorderSize = 0;
            btnAddBank_Pay.FlatStyle = FlatStyle.Flat;
            btnAddBank_Pay.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBank_Pay.ForeColor = Color.Transparent;
            btnAddBank_Pay.Location = new Point(143, 291);
            btnAddBank_Pay.Margin = new Padding(3, 2, 3, 2);
            btnAddBank_Pay.Name = "btnAddBank_Pay";
            btnAddBank_Pay.Size = new Size(144, 38);
            btnAddBank_Pay.TabIndex = 44;
            btnAddBank_Pay.Text = "Thêm";
            btnAddBank_Pay.TextColor = Color.Transparent;
            btnAddBank_Pay.UseVisualStyleBackColor = false;
            btnAddBank_Pay.Click += btnAddBank_Pay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._6963703;
            pictureBox1.Location = new Point(331, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // tbName1_pay
            // 
            tbName1_pay.Anchor = AnchorStyles.Top;
            tbName1_pay.BackColor = SystemColors.Window;
            tbName1_pay.BorderColor = Color.MediumSeaGreen;
            tbName1_pay.BorderFocusColor = Color.MediumSeaGreen;
            tbName1_pay.BorderRadius = 18;
            tbName1_pay.BorderSize = 1;
            tbName1_pay.Cursor = Cursors.IBeam;
            tbName1_pay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbName1_pay.ForeColor = Color.Black;
            tbName1_pay.Location = new Point(65, 237);
            tbName1_pay.MultiLine = false;
            tbName1_pay.Name = "tbName1_pay";
            tbName1_pay.Padding = new Padding(10, 7, 10, 7);
            tbName1_pay.PasswordChar = false;
            tbName1_pay.PlaceholderColor = Color.Gray;
            tbName1_pay.PlaceholderText = "";
            tbName1_pay.Size = new Size(306, 36);
            tbName1_pay.TabIndex = 52;
            tbName1_pay.Texts = "";
            tbName1_pay.UnderlinedStyle = false;
            // 
            // tbNum_pay
            // 
            tbNum_pay.Anchor = AnchorStyles.Top;
            tbNum_pay.BackColor = SystemColors.Window;
            tbNum_pay.BorderColor = Color.MediumSeaGreen;
            tbNum_pay.BorderFocusColor = Color.MediumSeaGreen;
            tbNum_pay.BorderRadius = 18;
            tbNum_pay.BorderSize = 1;
            tbNum_pay.Cursor = Cursors.IBeam;
            tbNum_pay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbNum_pay.ForeColor = Color.Black;
            tbNum_pay.Location = new Point(65, 163);
            tbNum_pay.MultiLine = false;
            tbNum_pay.Name = "tbNum_pay";
            tbNum_pay.Padding = new Padding(10, 7, 10, 7);
            tbNum_pay.PasswordChar = false;
            tbNum_pay.PlaceholderColor = Color.Gray;
            tbNum_pay.PlaceholderText = "";
            tbNum_pay.Size = new Size(306, 36);
            tbNum_pay.TabIndex = 53;
            tbNum_pay.Texts = "";
            tbNum_pay.UnderlinedStyle = false;
            // 
            // FBank_pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(450, 359);
            Controls.Add(tbNum_pay);
            Controls.Add(tbName1_pay);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddBank_Pay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ccbBank);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FBank_pay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FBank_pay";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CusComboBox ccbBank;
        private Label label2;
        private Label label3;
        private CusButton btnAddBank_Pay;
        private PictureBox pictureBox1;
        private CusTextBox tbName1_pay;
        private CusTextBox tbNum_pay;
    }
}