namespace DemoDoAnVer02
{
    partial class FAddImage
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
            btnAddImage = new CusButton();
            tbDecribeforImage = new CusTextBox();
            btnSaveImage = new NewButton();
            tbProductID = new CusTextBox();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = SystemColors.ActiveBorder;
            btnAddImage.BackgroundColor = SystemColors.ActiveBorder;
            btnAddImage.BackgroundImage = Properties.Resources.images_Photoroom_png_Photoroom__1_;
            btnAddImage.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddImage.BorderColor = Color.PaleVioletRed;
            btnAddImage.BorderRadius = 15;
            btnAddImage.BorderSize = 0;
            btnAddImage.FlatAppearance.BorderSize = 0;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddImage.ForeColor = Color.White;
            btnAddImage.Location = new Point(38, 160);
            btnAddImage.Margin = new Padding(3, 2, 3, 2);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(171, 29);
            btnAddImage.TabIndex = 12;
            btnAddImage.Text = "Thêm ảnh sản phẩm";
            btnAddImage.TextAlign = ContentAlignment.BottomCenter;
            btnAddImage.TextColor = Color.White;
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // tbDecribeforImage
            // 
            tbDecribeforImage.BackColor = SystemColors.Window;
            tbDecribeforImage.BorderColor = Color.DeepSkyBlue;
            tbDecribeforImage.BorderFocusColor = Color.LimeGreen;
            tbDecribeforImage.BorderRadius = 12;
            tbDecribeforImage.BorderSize = 1;
            tbDecribeforImage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbDecribeforImage.ForeColor = Color.DimGray;
            tbDecribeforImage.Location = new Point(256, 64);
            tbDecribeforImage.MultiLine = true;
            tbDecribeforImage.Name = "tbDecribeforImage";
            tbDecribeforImage.Padding = new Padding(10, 7, 10, 7);
            tbDecribeforImage.PasswordChar = false;
            tbDecribeforImage.PlaceholderColor = Color.DimGray;
            tbDecribeforImage.PlaceholderText = "Mô tả theo ảnh....";
            tbDecribeforImage.Size = new Size(413, 69);
            tbDecribeforImage.TabIndex = 13;
            tbDecribeforImage.Texts = "Mô tả theo ảnh....";
            tbDecribeforImage.UnderlinedStyle = false;
            // 
            // btnSaveImage
            // 
            btnSaveImage.BackColor = Color.Lime;
            btnSaveImage.BackgroundColor = Color.Lime;
            btnSaveImage.BorderColor = Color.PaleVioletRed;
            btnSaveImage.BorderRadius = 38;
            btnSaveImage.BorderSize = 0;
            btnSaveImage.FlatAppearance.BorderSize = 0;
            btnSaveImage.FlatStyle = FlatStyle.Flat;
            btnSaveImage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveImage.ForeColor = Color.Black;
            btnSaveImage.Location = new Point(256, 156);
            btnSaveImage.Margin = new Padding(3, 2, 3, 2);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(164, 38);
            btnSaveImage.TabIndex = 14;
            btnSaveImage.Text = "Lưu ảnh";
            btnSaveImage.TextColor = Color.Black;
            btnSaveImage.UseVisualStyleBackColor = false;
            btnSaveImage.Click += newButton1_Click;
            // 
            // tbProductID
            // 
            tbProductID.BackColor = SystemColors.Window;
            tbProductID.BorderColor = Color.DeepSkyBlue;
            tbProductID.BorderFocusColor = Color.LimeGreen;
            tbProductID.BorderRadius = 12;
            tbProductID.BorderSize = 1;
            tbProductID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductID.ForeColor = Color.DimGray;
            tbProductID.Location = new Point(256, 22);
            tbProductID.MultiLine = false;
            tbProductID.Name = "tbProductID";
            tbProductID.Padding = new Padding(10, 7, 10, 7);
            tbProductID.PasswordChar = false;
            tbProductID.PlaceholderColor = Color.DimGray;
            tbProductID.PlaceholderText = "Mã sản phẩm";
            tbProductID.Size = new Size(413, 30);
            tbProductID.TabIndex = 15;
            tbProductID.Texts = "Mã sản phẩm";
            tbProductID.UnderlinedStyle = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(38, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FAddImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(700, 209);
            Controls.Add(pictureBox1);
            Controls.Add(tbProductID);
            Controls.Add(btnSaveImage);
            Controls.Add(tbDecribeforImage);
            Controls.Add(btnAddImage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FAddImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAddImage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CusButton btnAddImage;
        private CusTextBox tbDecribeforImage;
        private NewButton btnSaveImage;
        private CusTextBox tbProductID;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
    }
}