namespace DemoDoAnVer02
{
    partial class SelectDate
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
            DateStart = new DateTimePicker();
            DateEnd = new DateTimePicker();
            label2 = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(75, 11);
            label1.Name = "label1";
            label1.Size = new Size(381, 33);
            label1.TabIndex = 0;
            label1.Text = "Chọn ngày tháng năm để hiển thị";
            // 
            // DateStart
            // 
            DateStart.Location = new Point(29, 48);
            DateStart.Margin = new Padding(3, 2, 3, 2);
            DateStart.Name = "DateStart";
            DateStart.Size = new Size(219, 23);
            DateStart.TabIndex = 1;
            // 
            // DateEnd
            // 
            DateEnd.Location = new Point(315, 48);
            DateEnd.Margin = new Padding(3, 2, 3, 2);
            DateEnd.Name = "DateEnd";
            DateEnd.Size = new Size(219, 23);
            DateEnd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 48);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 3;
            label2.Text = "To";
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.SkyBlue;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(223, 80);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(108, 33);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // SelectDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(560, 127);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(DateEnd);
            Controls.Add(DateStart);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SelectDate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectDate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker DateStart;
        private DateTimePicker DateEnd;
        private Label label2;
        private Button btnOK;
    }
}