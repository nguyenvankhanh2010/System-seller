namespace DemoDoAnVer02
{
    partial class FSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignUp));
            pnlSignUp = new Panel();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            lblSex = new Label();
            rbFemale = new CusRadioButton();
            rbMale = new CusRadioButton();
            tbEnterPass = new CusTextBox();
            lblEnterPass = new Label();
            lblPass = new Label();
            label5 = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblUsername = new Label();
            lblName = new Label();
            tbPassword = new CusTextBox();
            tbEmail = new CusTextBox();
            tbPhone = new CusTextBox();
            tbAddress = new CusTextBox();
            tbUserName = new CusTextBox();
            tbName = new CusTextBox();
            lblTitleSignUp = new Label();
            pbSignUp = new PictureBox();
            btnSignUp = new NewButton();
            pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSignUp).BeginInit();
            SuspendLayout();
            // 
            // pnlSignUp
            // 
            pnlSignUp.Anchor = AnchorStyles.None;
            pnlSignUp.BackColor = SystemColors.Window;
            pnlSignUp.Controls.Add(dtpDOB);
            pnlSignUp.Controls.Add(lblDOB);
            pnlSignUp.Controls.Add(lblSex);
            pnlSignUp.Controls.Add(rbFemale);
            pnlSignUp.Controls.Add(rbMale);
            pnlSignUp.Controls.Add(tbEnterPass);
            pnlSignUp.Controls.Add(lblEnterPass);
            pnlSignUp.Controls.Add(lblPass);
            pnlSignUp.Controls.Add(label5);
            pnlSignUp.Controls.Add(lblPhone);
            pnlSignUp.Controls.Add(lblAddress);
            pnlSignUp.Controls.Add(lblUsername);
            pnlSignUp.Controls.Add(lblName);
            pnlSignUp.Controls.Add(tbPassword);
            pnlSignUp.Controls.Add(tbEmail);
            pnlSignUp.Controls.Add(tbPhone);
            pnlSignUp.Controls.Add(tbAddress);
            pnlSignUp.Controls.Add(tbUserName);
            pnlSignUp.Controls.Add(tbName);
            pnlSignUp.Controls.Add(lblTitleSignUp);
            pnlSignUp.Controls.Add(pbSignUp);
            pnlSignUp.Controls.Add(btnSignUp);
            pnlSignUp.Location = new Point(137, 42);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(584, 584);
            pnlSignUp.TabIndex = 0;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(31, 353);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(242, 23);
            dtpDOB.TabIndex = 35;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDOB.Location = new Point(31, 333);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(66, 17);
            lblDOB.TabIndex = 34;
            lblDOB.Text = "Ngày sinh";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSex.Location = new Point(26, 270);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(56, 17);
            lblSex.TabIndex = 33;
            lblSex.Text = "Giới tính";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.CheckedColor = Color.LimeGreen;
            rbFemale.Cursor = Cursors.Hand;
            rbFemale.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbFemale.Location = new Point(183, 290);
            rbFemale.MinimumSize = new Size(0, 21);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(56, 21);
            rbFemale.TabIndex = 20;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UncheckedColor = Color.DodgerBlue;
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.CheckedColor = Color.LimeGreen;
            rbMale.Cursor = Cursors.Hand;
            rbMale.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbMale.Location = new Point(88, 290);
            rbMale.MinimumSize = new Size(0, 21);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(66, 21);
            rbMale.TabIndex = 19;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UncheckedColor = Color.DodgerBlue;
            rbMale.UseVisualStyleBackColor = true;
            // 
            // tbEnterPass
            // 
            tbEnterPass.BackColor = SystemColors.Window;
            tbEnterPass.BorderColor = Color.DodgerBlue;
            tbEnterPass.BorderFocusColor = Color.LawnGreen;
            tbEnterPass.BorderRadius = 10;
            tbEnterPass.BorderSize = 2;
            tbEnterPass.Cursor = Cursors.IBeam;
            tbEnterPass.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbEnterPass.ForeColor = Color.DimGray;
            tbEnterPass.Location = new Point(311, 420);
            tbEnterPass.MultiLine = false;
            tbEnterPass.Name = "tbEnterPass";
            tbEnterPass.Padding = new Padding(10, 7, 10, 7);
            tbEnterPass.PasswordChar = false;
            tbEnterPass.PlaceholderColor = Color.DarkGray;
            tbEnterPass.PlaceholderText = "";
            tbEnterPass.Size = new Size(250, 31);
            tbEnterPass.TabIndex = 30;
            tbEnterPass.Texts = "";
            tbEnterPass.UnderlinedStyle = false;
            // 
            // lblEnterPass
            // 
            lblEnterPass.AutoSize = true;
            lblEnterPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnterPass.Location = new Point(312, 400);
            lblEnterPass.Name = "lblEnterPass";
            lblEnterPass.Size = new Size(114, 17);
            lblEnterPass.TabIndex = 32;
            lblEnterPass.Text = "Nhập lại mật khẩu";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(311, 333);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(62, 17);
            lblPass.TabIndex = 31;
            lblPass.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(311, 270);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 29;
            label5.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(312, 203);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(85, 17);
            lblPhone.TabIndex = 28;
            lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(312, 134);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(47, 17);
            lblAddress.TabIndex = 26;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(23, 203);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 17);
            lblUsername.TabIndex = 24;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(23, 134);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 17);
            lblName.TabIndex = 22;
            lblName.Text = "Họ và tên";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Window;
            tbPassword.BorderColor = Color.DodgerBlue;
            tbPassword.BorderFocusColor = Color.LawnGreen;
            tbPassword.BorderRadius = 10;
            tbPassword.BorderSize = 2;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.DimGray;
            tbPassword.Location = new Point(312, 353);
            tbPassword.MultiLine = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(10, 7, 10, 7);
            tbPassword.PasswordChar = false;
            tbPassword.PlaceholderColor = Color.DarkGray;
            tbPassword.PlaceholderText = "";
            tbPassword.Size = new Size(250, 31);
            tbPassword.TabIndex = 27;
            tbPassword.Texts = "";
            tbPassword.UnderlinedStyle = false;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.Window;
            tbEmail.BorderColor = Color.DodgerBlue;
            tbEmail.BorderFocusColor = Color.LawnGreen;
            tbEmail.BorderRadius = 10;
            tbEmail.BorderSize = 2;
            tbEmail.Cursor = Cursors.IBeam;
            tbEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.DimGray;
            tbEmail.Location = new Point(312, 290);
            tbEmail.MultiLine = false;
            tbEmail.Name = "tbEmail";
            tbEmail.Padding = new Padding(10, 7, 10, 7);
            tbEmail.PasswordChar = false;
            tbEmail.PlaceholderColor = Color.DarkGray;
            tbEmail.PlaceholderText = "";
            tbEmail.Size = new Size(250, 31);
            tbEmail.TabIndex = 25;
            tbEmail.Texts = "";
            tbEmail.UnderlinedStyle = false;
            // 
            // tbPhone
            // 
            tbPhone.BackColor = SystemColors.Window;
            tbPhone.BorderColor = Color.DodgerBlue;
            tbPhone.BorderFocusColor = Color.LawnGreen;
            tbPhone.BorderRadius = 10;
            tbPhone.BorderSize = 2;
            tbPhone.Cursor = Cursors.IBeam;
            tbPhone.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhone.ForeColor = Color.DimGray;
            tbPhone.Location = new Point(312, 223);
            tbPhone.MultiLine = false;
            tbPhone.Name = "tbPhone";
            tbPhone.Padding = new Padding(10, 7, 10, 7);
            tbPhone.PasswordChar = false;
            tbPhone.PlaceholderColor = Color.DarkGray;
            tbPhone.PlaceholderText = "";
            tbPhone.Size = new Size(250, 31);
            tbPhone.TabIndex = 23;
            tbPhone.Texts = "";
            tbPhone.UnderlinedStyle = false;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = SystemColors.Window;
            tbAddress.BorderColor = Color.DodgerBlue;
            tbAddress.BorderFocusColor = Color.LawnGreen;
            tbAddress.BorderRadius = 10;
            tbAddress.BorderSize = 2;
            tbAddress.Cursor = Cursors.IBeam;
            tbAddress.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbAddress.ForeColor = Color.DimGray;
            tbAddress.Location = new Point(312, 154);
            tbAddress.MultiLine = false;
            tbAddress.Name = "tbAddress";
            tbAddress.Padding = new Padding(10, 7, 10, 7);
            tbAddress.PasswordChar = false;
            tbAddress.PlaceholderColor = Color.DarkGray;
            tbAddress.PlaceholderText = "";
            tbAddress.Size = new Size(250, 31);
            tbAddress.TabIndex = 21;
            tbAddress.Texts = "";
            tbAddress.UnderlinedStyle = false;
            // 
            // tbUserName
            // 
            tbUserName.BackColor = SystemColors.Window;
            tbUserName.BorderColor = Color.DodgerBlue;
            tbUserName.BorderFocusColor = Color.LawnGreen;
            tbUserName.BorderRadius = 10;
            tbUserName.BorderSize = 2;
            tbUserName.Cursor = Cursors.IBeam;
            tbUserName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserName.ForeColor = Color.DimGray;
            tbUserName.Location = new Point(23, 223);
            tbUserName.MultiLine = false;
            tbUserName.Name = "tbUserName";
            tbUserName.Padding = new Padding(10, 7, 10, 7);
            tbUserName.PasswordChar = false;
            tbUserName.PlaceholderColor = Color.DarkGray;
            tbUserName.PlaceholderText = "";
            tbUserName.Size = new Size(250, 31);
            tbUserName.TabIndex = 18;
            tbUserName.Texts = "";
            tbUserName.UnderlinedStyle = false;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.Window;
            tbName.BorderColor = Color.DodgerBlue;
            tbName.BorderFocusColor = Color.LawnGreen;
            tbName.BorderRadius = 10;
            tbName.BorderSize = 2;
            tbName.Cursor = Cursors.IBeam;
            tbName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.ForeColor = Color.DimGray;
            tbName.Location = new Point(23, 154);
            tbName.MultiLine = false;
            tbName.Name = "tbName";
            tbName.Padding = new Padding(10, 7, 10, 7);
            tbName.PasswordChar = false;
            tbName.PlaceholderColor = Color.DarkGray;
            tbName.PlaceholderText = "";
            tbName.Size = new Size(250, 31);
            tbName.TabIndex = 17;
            tbName.Texts = "";
            tbName.UnderlinedStyle = false;
            // 
            // lblTitleSignUp
            // 
            lblTitleSignUp.Anchor = AnchorStyles.None;
            lblTitleSignUp.AutoSize = true;
            lblTitleSignUp.BackColor = Color.White;
            lblTitleSignUp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleSignUp.ForeColor = Color.DodgerBlue;
            lblTitleSignUp.Location = new Point(150, 27);
            lblTitleSignUp.Name = "lblTitleSignUp";
            lblTitleSignUp.Size = new Size(140, 74);
            lblTitleSignUp.TabIndex = 4;
            lblTitleSignUp.Text = "Tạo\r\nTài khoản\r\n";
            lblTitleSignUp.TextAlign = ContentAlignment.TopRight;
            // 
            // pbSignUp
            // 
            pbSignUp.BackgroundImage = (Image)resources.GetObject("pbSignUp.BackgroundImage");
            pbSignUp.Cursor = Cursors.No;
            pbSignUp.Location = new Point(296, 29);
            pbSignUp.Name = "pbSignUp";
            pbSignUp.Size = new Size(79, 72);
            pbSignUp.TabIndex = 2;
            pbSignUp.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Gold;
            btnSignUp.BackgroundColor = Color.Gold;
            btnSignUp.BorderColor = Color.PaleVioletRed;
            btnSignUp.BorderRadius = 40;
            btnSignUp.BorderSize = 0;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(168, 478);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(250, 40);
            btnSignUp.TabIndex = 1;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.TextColor = Color.Black;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // FSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Thiết_kế_chưa_có_tên__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 675);
            Controls.Add(pnlSignUp);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSignUp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSignUp;
        private NewButton btnSignUp;
        private PictureBox pbSignUp;
        private Label lblTitleSignUp;
        private Label lblSex;
        private CusRadioButton rbFemale;
        private CusRadioButton rbMale;
        private CusTextBox tbEnterPass;
        private Label lblEnterPass;
        private Label lblPass;
        private Label label5;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblUsername;
        private Label lblName;
        private CusTextBox tbPassword;
        private CusTextBox tbEmail;
        private CusTextBox tbPhone;
        private CusTextBox tbAddress;
        private CusTextBox tbUserName;
        private CusTextBox tbName;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
    }
}