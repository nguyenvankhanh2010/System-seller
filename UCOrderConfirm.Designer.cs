namespace DemoDoAnVer02
{
    partial class UCOrderConfirm
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
            lblID = new Label();
            btnConfirm = new NewButton();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(32, 16);
            lblID.Name = "lblID";
            lblID.Size = new Size(78, 15);
            lblID.TabIndex = 1;
            lblID.Text = "Mã đơn hàng";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.MediumSlateBlue;
            btnConfirm.BackgroundColor = Color.MediumSlateBlue;
            btnConfirm.BorderColor = Color.PaleVioletRed;
            btnConfirm.BorderRadius = 0;
            btnConfirm.BorderSize = 0;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(201, 10);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(117, 27);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Đã nhận hàng";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // UCOrderConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnConfirm);
            Controls.Add(lblID);
            Name = "UCOrderConfirm";
            Size = new Size(345, 49);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private NewButton btnConfirm;
    }
}
