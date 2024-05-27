namespace DemoDoAnVer02
{
    partial class UCHisBuy
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
            lblTotal = new Label();
            lblDateOrder = new Label();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(21, 23);
            lblID.Name = "lblID";
            lblID.Size = new Size(101, 20);
            lblID.TabIndex = 0;
            lblID.Text = "Mã đơn hàng";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(168, 23);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Giá trị";
            // 
            // lblDateOrder
            // 
            lblDateOrder.AutoSize = true;
            lblDateOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOrder.Location = new Point(278, 23);
            lblDateOrder.Name = "lblDateOrder";
            lblDateOrder.Size = new Size(111, 20);
            lblDateOrder.TabIndex = 2;
            lblDateOrder.Text = "Ngày đặt hàng";
            // 
            // UCHisBuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            Controls.Add(lblDateOrder);
            Controls.Add(lblTotal);
            Controls.Add(lblID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCHisBuy";
            Size = new Size(394, 65);
            Click += UCHisBuy_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblTotal;
        private Label lblDateOrder;
    }
}
