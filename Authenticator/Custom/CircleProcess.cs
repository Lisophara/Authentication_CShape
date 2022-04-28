using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Authenticator.CircleProcess
{
    public partial class CircleProcess : UserControl
    {
        int maxValue = 100, value = 0;
        Color innerColor = Color.FromArgb(64, 64, 64);
        Color outterColor = Color.Blue;
        Color textColor = Color.White;

        public CircleProcess()
        {
            InitializeComponent();
            this.Width = 50;
            this.Height = 50;
            this.MinimumSize = new Size(50,50);
        }
        private void CircleProcess_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            Pen pen = new Pen(new SolidBrush(outterColor));

            Rectangle rectangle = new Rectangle(-this.Width/2 + 5, -this.Height/2 + 5, this.Width -  10, this.Height - 10);

            // Outter circle
            graphics.RotateTransform(-90);
            graphics.DrawPie(pen, rectangle, 0,  PieceOfCircle() * 3.6f);
            graphics.FillPie(new SolidBrush(outterColor), rectangle, 0, PieceOfCircle() * 3.6f);
            pen.Dispose();

            // Inner circle
            pen = new Pen(new SolidBrush(innerColor));
            rectangle = new Rectangle(-this.Width/2 + 10, -this.Height/2 + 10, this.Width - 20, this.Height - 20);
            graphics.DrawPie(pen, rectangle, 0, 360);
            graphics.FillPie(new SolidBrush(innerColor), rectangle, 0, 360);
            pen.Dispose();

            // Draw string
            graphics.RotateTransform(90);
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Center;
            st.LineAlignment = StringAlignment.Center;
            graphics.DrawString($"{value}s",new Font("Microsoft Sans Serif",8),new SolidBrush(textColor),rectangle,st);
            
        }
        private float PieceOfCircle()
        {
            return (value * 100f) / maxValue;
        }

        public int _MaximunValue
        {
            get { return maxValue;
            }
            set { maxValue = value;
                Invalidate();
            }
        }
        public int _Value
        {
            get { return this.value;
            }
            set { this.value = value;
                Invalidate();
            }
        }
        public Color _InnerCircle
        {
            get { return innerColor;
            }
            set { innerColor = value;
                Invalidate();
            }
        }
        public Color _OutterCircle
        {
            get { return outterColor;
            }
            set { outterColor = value;
                Invalidate();
            }
        }
        public Color _TextColor
        {
            get { return textColor;
            }
            set { textColor = value;
                Invalidate();
            }
        }


    }
}
