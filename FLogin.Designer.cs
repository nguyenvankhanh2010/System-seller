namespace DemoDoAnVer02
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            pnlLogin = new Panel();
            chbShow = new CusCheckBox();
            pbLogo = new PictureBox();
            tbUsername = new CusTextBox();
            lblToSignUp = new Label();
            tbPassword = new CusTextBox();
            btnLogin = new NewButton();
            pictureBox1 = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.BackColor = SystemColors.Window;
            pnlLogin.Controls.Add(chbShow);
            pnlLogin.Controls.Add(pbLogo);
            pnlLogin.Controls.Add(tbUsername);
            pnlLogin.Controls.Add(lblToSignUp);
            pnlLogin.Controls.Add(tbPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Location = new Point(303, 93);
            pnlLogin.Margin = new Padding(3, 4, 3, 4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(377, 667);
            pnlLogin.TabIndex = 0;
            // 
            // chbShow
            // 
            chbShow.Anchor = AnchorStyles.None;
            chbShow.AutoSize = true;
            chbShow.CheckedColor = Color.LimeGreen;
            chbShow.Cursor = Cursors.Hand;
            chbShow.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chbShow.Location = new Point(83, 421);
            chbShow.Margin = new Padding(3, 4, 3, 4);
            chbShow.Name = "chbShow";
            chbShow.Size = new Size(141, 25);
            chbShow.TabIndex = 8;
            chbShow.Text = "Hiện mật khẩu";
            chbShow.UncheckedColor = Color.Black;
            chbShow.UseVisualStyleBackColor = true;
            chbShow.CheckedChanged += chbShow_CheckedChanged;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = Properties.Resources.Thiết_kế_chưa_có_tên__2_;
            pbLogo.Cursor = Cursors.No;
            pbLogo.Location = new Point(128, 65);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(126, 147);
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.Window;
            tbUsername.BorderColor = Color.DeepSkyBlue;
            tbUsername.BorderFocusColor = Color.LimeGreen;
            tbUsername.BorderRadius = 0;
            tbUsername.BorderSize = 5;
            tbUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = SystemColors.WindowText;
            tbUsername.Location = new Point(83, 285);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.MultiLine = false;
            tbUsername.Name = "tbUsername";
            tbUsername.Padding = new Padding(8, 9, 8, 9);
            tbUsername.PasswordChar = false;
            tbUsername.PlaceholderColor = Color.DimGray;
            tbUsername.PlaceholderText = "Tài khoản";
            tbUsername.Size = new Size(225, 42);
            tbUsername.TabIndex = 3;
            tbUsername.Texts = "Tài khoản";
            tbUsername.UnderlinedStyle = true;
            // 
            // lblToSignUp
            // 
            lblToSignUp.AutoSize = true;
            lblToSignUp.Cursor = Cursors.Hand;
            lblToSignUp.Location = new Point(94, 576);
            lblToSignUp.Name = "lblToSignUp";
            lblToSignUp.Size = new Size(225, 20);
            lblToSignUp.TabIndex = 5;
            lblToSignUp.Text = " Bạn chưa có tài khoản | Đăng ký\r\n";
            lblToSignUp.Click += lblToSignUp_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Window;
            tbPassword.BorderColor = Color.DeepSkyBlue;
            tbPassword.BorderFocusColor = Color.LimeGreen;
            tbPassword.BorderRadius = 0;
            tbPassword.BorderSize = 5;
            tbPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = SystemColors.WindowText;
            tbPassword.Location = new Point(83, 355);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.MultiLine = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(8, 9, 8, 9);
            tbPassword.PasswordChar = true;
            tbPassword.PlaceholderColor = Color.DimGray;
            tbPassword.PlaceholderText = "Mật khẩu";
            tbPassword.Size = new Size(225, 42);
            tbPassword.TabIndex = 4;
            tbPassword.Texts = "Mật khẩu";
            tbPassword.UnderlinedStyle = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gold;
            btnLogin.BackgroundColor = Color.Gold;
            btnLogin.BorderColor = SystemColors.ActiveCaptionText;
            btnLogin.BorderRadius = 31;
            btnLogin.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(83, 491);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(225, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextColor = Color.Black;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 559);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 13);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.Thiết_kế_chưa_có_tên__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 855);
            Controls.Add(pnlLogin);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private NewButton btnLogin;
        private CusTextBox tbPassword;
        private CusTextBox tbUsername;
        private Label lblToSignUp;
        private PictureBox pbLogo;
        private CusCheckBox chbShow;
        private PictureBox pictureBox1;
    }
}
