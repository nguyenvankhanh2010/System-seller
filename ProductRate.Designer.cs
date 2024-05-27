namespace DemoDoAnVer02
{
    partial class ProductRate
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
            pictureBox1 = new PictureBox();
            lbldateRate = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4762707_removebg_preview;
            pictureBox1.Location = new Point(18, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbldateRate
            // 
            lbldateRate.AutoSize = true;
            lbldateRate.Location = new Point(189, 17);
            lbldateRate.Name = "lbldateRate";
            lbldateRate.Size = new Size(50, 20);
            lbldateRate.TabIndex = 1;
            lbldateRate.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(189, 56);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(65, 28);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "label1";
            // 
            // ProductRate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescription);
            Controls.Add(lbldateRate);
            Controls.Add(pictureBox1);
            Name = "ProductRate";
            Size = new Size(649, 120);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbldateRate;
        private Label lblDescription;
    }
}
