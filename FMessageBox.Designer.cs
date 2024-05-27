namespace DemoDoAnVer02
{
    partial class FMessageBox
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMessageBox));
            lblNotifi = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNotifi
            // 
            lblNotifi.AutoSize = true;
            lblNotifi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotifi.Location = new Point(82, 112);
            lblNotifi.Name = "lblNotifi";
            lblNotifi.Size = new Size(132, 20);
            lblNotifi.TabIndex = 3;
            lblNotifi.Text = "Thêm thành công";
            lblNotifi.Click += FMessageBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy__2_;
            pictureBox1.Location = new Point(62, 25);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += FMessageBox_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1300;
            timer1.Tick += timer1_Tick;
            // 
            // FMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(291, 152);
            Controls.Add(lblNotifi);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thành công";
            Click += FMessageBox_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        internal Label lblNotifi;
        private System.Windows.Forms.Timer timer1;
    }
}