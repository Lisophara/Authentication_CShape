using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SmtpSenderMail.Classes.CustomShap
{ 
    public class RoundButton : Button
    {
        // OnHover
        private Color textOnHover = Color.Red;
        private Color borderOnHover = Color.Green;
        private Color innerOnHover = Color.Cyan;
        private bool mouseOnHover;
        private bool wantBorderHover = false;
        private bool wantTextHover = false;
        private bool wantInnerHove = false;
        // normal
        private Color borderColor = Color.Black;
        private Color innerColor = Color.White;
        private Color textColor = Color.Black;
        public int border = 6;
        public int borderBy2 = 3;
        public RoundButton()
        {
            MouseHover += (sender, e) =>
            {
                mouseOnHover = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                mouseOnHover = false;
                Invalidate();
            };
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            //FlatStyle = FlatStyle.Flat;
            //FlatAppearance.BorderSize = 0;
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(mouseOnHover && wantBorderHover ? borderOnHover : borderColor);
            // Left   border
            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            // Inner
            brush.Dispose();
            brush = new SolidBrush(mouseOnHover && wantInnerHove ? innerOnHover : innerColor);
            g.FillEllipse(brush, borderBy2, borderBy2, Height - border, Height - border);
            g.FillEllipse(brush,(Width - Height) + borderBy2, borderBy2, (Height - border),(Height- border) );
            g.FillRectangle(brush, (Height / 2) - borderBy2, borderBy2, (Width - Height) + border, Height - border);

            // draw string 
            brush.Dispose();
            brush = new SolidBrush(mouseOnHover && wantTextHover ? textOnHover : textColor);
            SizeF st = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, new PointF((Width - st.Width) / 2, (Height - st.Height) / 2) ) ;
        }

        public int _BorderSize
        {
            get { return borderBy2; }
            set { borderBy2 = value;
                border = borderBy2 * 2;
                Invalidate();
            }
        }
        public Color _BorderColor
        {
            get { return borderColor; }
            set { borderColor = value;
                Invalidate();
            }
        }
        public Color _InnerButtonColor
        {
            get { return innerColor; }
            set { innerColor = value;
                Invalidate();
            }
        }
        public Color _TextColor
        {
            get { return textColor; }
            set { textColor = value;
                Invalidate();
            }
        }
        // Button OnHover
        public Color _OnHoverInnerColor
        {
            get { return innerOnHover; }
            set { innerOnHover = value;
                Invalidate();
            }
        }
        public Color _OnHoverBorderColor
        {
            get { return borderOnHover; }
            set { borderOnHover = value;
                Invalidate();
            }
        }
        public Color _OnHoverTextColor
        {
            get { return textOnHover; }
            set { textOnHover = value;
                Invalidate();
            }
        }
        // Activate OnHover
        public bool _ActivateBorderHover
        {
            get { return wantBorderHover; }
            set { wantBorderHover = value;
                Invalidate();
            }
        }
        public bool _ActivateInnerHover
        {
            get { return wantInnerHove; }
            set
            {
                wantInnerHove = value;
                Invalidate();
            }
        }
        public bool _ActivateTextHover
        {
            get { return wantTextHover; }
            set { wantTextHover = value;
                Invalidate();
                }
        }
    }
}
