namespace DemoDoAnVer02
{
    partial class FCOD_Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCOD_Pay));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnAddOCD_Pay = new CusButton();
            tbName2_pay = new CusTextBox();
            tbPhone = new CusTextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN TÀI KHOẢN MOMO\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 80);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 43;
            label2.Text = "Tên người nhận";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 167);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 45;
            label4.Text = "Số điện thoại";
            // 
            // btnAddOCD_Pay
            // 
            btnAddOCD_Pay.BackColor = Color.LightCoral;
            btnAddOCD_Pay.BackgroundColor = Color.LightCoral;
            btnAddOCD_Pay.BorderColor = Color.PaleVioletRed;
            btnAddOCD_Pay.BorderRadius = 20;
            btnAddOCD_Pay.BorderSize = 0;
            btnAddOCD_Pay.FlatAppearance.BorderSize = 0;
            btnAddOCD_Pay.FlatStyle = FlatStyle.Flat;
            btnAddOCD_Pay.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddOCD_Pay.ForeColor = Color.Black;
            btnAddOCD_Pay.Location = new Point(122, 249);
            btnAddOCD_Pay.Margin = new Padding(3, 2, 3, 2);
            btnAddOCD_Pay.Name = "btnAddOCD_Pay";
            btnAddOCD_Pay.Size = new Size(144, 38);
            btnAddOCD_Pay.TabIndex = 47;
            btnAddOCD_Pay.Text = "Thêm";
            btnAddOCD_Pay.TextColor = Color.Black;
            btnAddOCD_Pay.UseVisualStyleBackColor = false;
            btnAddOCD_Pay.Click += btnAddOCD_Pay_Click;
            // 
            // tbName2_pay
            // 
            tbName2_pay.Anchor = AnchorStyles.Top;
            tbName2_pay.BackColor = SystemColors.Window;
            tbName2_pay.BorderColor = Color.LightCoral;
            tbName2_pay.BorderFocusColor = Color.MediumSeaGreen;
            tbName2_pay.BorderRadius = 18;
            tbName2_pay.BorderSize = 1;
            tbName2_pay.Cursor = Cursors.IBeam;
            tbName2_pay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbName2_pay.ForeColor = Color.Black;
            tbName2_pay.Location = new Point(49, 103);
            tbName2_pay.MultiLine = false;
            tbName2_pay.Name = "tbName2_pay";
            tbName2_pay.Padding = new Padding(10, 7, 10, 7);
            tbName2_pay.PasswordChar = false;
            tbName2_pay.PlaceholderColor = Color.Gray;
            tbName2_pay.PlaceholderText = "";
            tbName2_pay.Size = new Size(306, 36);
            tbName2_pay.TabIndex = 51;
            tbName2_pay.Texts = "";
            tbName2_pay.UnderlinedStyle = false;
            // 
            // tbPhone
            // 
            tbPhone.Anchor = AnchorStyles.Top;
            tbPhone.BackColor = SystemColors.Window;
            tbPhone.BorderColor = Color.LightCoral;
            tbPhone.BorderFocusColor = Color.MediumSeaGreen;
            tbPhone.BorderRadius = 18;
            tbPhone.BorderSize = 1;
            tbPhone.Cursor = Cursors.IBeam;
            tbPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbPhone.ForeColor = Color.Black;
            tbPhone.Location = new Point(49, 190);
            tbPhone.MultiLine = false;
            tbPhone.Name = "tbPhone";
            tbPhone.Padding = new Padding(10, 7, 10, 7);
            tbPhone.PasswordChar = false;
            tbPhone.PlaceholderColor = Color.Gray;
            tbPhone.PlaceholderText = "";
            tbPhone.Size = new Size(306, 36);
            tbPhone.TabIndex = 53;
            tbPhone.Texts = "";
            tbPhone.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(286, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 80);
            panel1.TabIndex = 54;
            // 
            // FCOD_Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(410, 314);
            Controls.Add(panel1);
            Controls.Add(tbPhone);
            Controls.Add(tbName2_pay);
            Controls.Add(label1);
            Controls.Add(btnAddOCD_Pay);
            Controls.Add(label4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCOD_Pay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCOD_Pay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private CusButton btnAddOCD_Pay;
        private CusTextBox tbName2_pay;
        private CusTextBox tbPhone;
        private Panel panel1;
    }
}