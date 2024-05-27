namespace DemoDoAnVer02
{
    partial class FRateProduct
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
            txtRateBuyer = new CusTextBox();
            label1 = new Label();
            btnOK = new NewButton();
            SuspendLayout();
            // 
            // txtRateBuyer
            // 
            txtRateBuyer.BackColor = SystemColors.Window;
            txtRateBuyer.BorderColor = Color.DeepSkyBlue;
            txtRateBuyer.BorderFocusColor = Color.SpringGreen;
            txtRateBuyer.BorderRadius = 0;
            txtRateBuyer.BorderSize = 2;
            txtRateBuyer.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtRateBuyer.ForeColor = Color.DimGray;
            txtRateBuyer.Location = new Point(39, 68);
            txtRateBuyer.Margin = new Padding(3, 2, 3, 2);
            txtRateBuyer.MultiLine = false;
            txtRateBuyer.Name = "txtRateBuyer";
            txtRateBuyer.Padding = new Padding(9, 5, 9, 5);
            txtRateBuyer.PasswordChar = false;
            txtRateBuyer.PlaceholderColor = Color.DarkGray;
            txtRateBuyer.PlaceholderText = "";
            txtRateBuyer.Size = new Size(336, 27);
            txtRateBuyer.TabIndex = 0;
            txtRateBuyer.Texts = "";
            txtRateBuyer.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 33);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 1;
            label1.Text = "Đánh giá sản phẩm";
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.MediumSeaGreen;
            btnOK.BackgroundColor = Color.MediumSeaGreen;
            btnOK.BorderColor = Color.PaleVioletRed;
            btnOK.BorderRadius = 38;
            btnOK.BorderSize = 0;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(137, 119);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(143, 38);
            btnOK.TabIndex = 2;
            btnOK.Text = "Gửi";
            btnOK.TextColor = Color.White;
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // FRateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(418, 196);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Controls.Add(txtRateBuyer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FRateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đánh giá";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CusTextBox txtRateBuyer;
        private Label label1;
        private NewButton btnOK;
    }
}