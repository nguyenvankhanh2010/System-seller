using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DemoDoAnVer02
{
    internal class CusRadioButton : RadioButton
    {
        //Fields
        private Color checkedColor = Color.MediumSlateBlue;
        private Color uncheckedColor = Color.Gray;

        //Properties
        public Color CheckedColor 
        { 
            get { return checkedColor; }
            set { checkedColor = value;  this.Invalidate(); } 
        }
        public Color UncheckedColor 
        { 
            get { return uncheckedColor; }
            set { uncheckedColor = value; this.Invalidate(); } 
        }

        //Constructor
        public CusRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
        }

        //Method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2,
                Width = rbCheckSize,
                Height = rbCheckSize,
            };
            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X +((rectRbBorder.Width - rbCheckSize)/2),
                Y = (this.Height - rbBorderSize) / 2,
                Width = rbCheckSize,
                Height = rbCheckSize,
            };

            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                g.Clear(this.BackColor);

                if(this.Checked)
                {
                    g.DrawEllipse(penBorder, rectRbBorder);
                    g.FillEllipse(brushRbCheck, rectRbCheck);
                }
                else
                {
                    penBorder.Color = uncheckedColor;
                    g.DrawEllipse(penBorder, rectRbBorder);
                }

                g.DrawString(this.Text, this.Font, brushText, rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);
            }
        }

        protected override void OnResize (EventArgs e)
        {
            base.OnResize (e);
            this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        }

    }
}
