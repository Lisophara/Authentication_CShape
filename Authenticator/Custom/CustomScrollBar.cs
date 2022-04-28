using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Authenticator.Custom
{
    [Designer(typeof(ScrollbarControlDesigner))]
    public partial class CustomScrollBar : UserControl
    {
        // Element color nad style
        private Color thumbColor = Color.DarkGray;
        private Color trackBarColor = Color.Red;
        private Color trackBorderColor = Color.Gray;
        private Color thumbOnClick = Color.DarkSlateGray;
        private int border = 2;
        
        // ScrollBar Element
        private int minThumbHeight = 56;
        private int smallChange = 1;
        private int largeChange = 10;
        private int maximum = 100;
        private int minimum = 0;
        private int value = 0;
        private int thumbTop = 0;

        // mouse
        private int clickPoint;
        private bool thumbDown = false;
        private bool thumbDragging = false;

        // Event for ScrollBar
        public new event EventHandler Scroll = null;
        public event EventHandler ValueChanged = null;
        public CustomScrollBar()
        {
            _InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            //largeChange = this.Height;
        }
        private void _InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "CustomHScrollBar";
            this.Width = 20;
            this.Height = 100;
            this.MouseMove += CustomScrollBar_MouseMove;
            this.MouseDown += CustomScrollBar_MouseDown;
            this.MouseUp += CustomScrollBar_MouseUp;
            this.ResumeLayout(false);
        }

        [Description("This method use to get (Int ThumbHeight) (float ThumbHeight) and TrackHeight")]
        private void GetElement(ref int iThumbHeight, ref float fThumbHeight, ref int trackHeight)
        {
            trackHeight = this.Height;
            fThumbHeight = ((float)_LargeChange / (float)_Maximum)* trackHeight;
            iThumbHeight = (int)fThumbHeight;
            if(iThumbHeight > trackHeight)
            {
                iThumbHeight = trackHeight;
                fThumbHeight = trackHeight;
            }
            if (iThumbHeight < minThumbHeight)
            {
                iThumbHeight = minThumbHeight;
                fThumbHeight = minThumbHeight;
            }
            
        }

        [Description("Get int thumb height")]
        protected virtual int GetIntThumbHeight()
        {
            int iThumbHeight = 0, trackHeight = 0;
            float fThumbHeight = 0; 
            GetElement(ref iThumbHeight, ref fThumbHeight, ref trackHeight);
            return iThumbHeight;
        }

        [Description("Get float thumb height")]
        protected virtual float GetFloatThumbHeight()
        {
            int iThumbHeight = 0, trackHeight = 0;
            float fThumbHeight = 0;
            GetElement(ref iThumbHeight, ref fThumbHeight, ref trackHeight);
            return fThumbHeight;
        }

        [Description("Get track height")]
        protected virtual int GetTrackHeight()
        {
            int iThumbHeight = 0, trackHeight = 0;
            float fThumbHeight = 0;
            GetElement(ref iThumbHeight, ref fThumbHeight, ref trackHeight);
            return trackHeight;
        }

        [Description("Method use to move thumb")]
        protected void MoveThumb(int y)
        {
            int realRange = _Maximum - _Minimum;
            int spot = clickPoint;
            int thumb = GetIntThumbHeight();
            int track = GetTrackHeight();
            int pixelRange = track - thumb;
            if(thumbDown && realRange > 0)
            {
                if(pixelRange > 0)
                {
                    int nThumbTop = y - spot;
                    if(nThumbTop < 0)
                    {
                        thumbTop = nThumbTop = 0;
                    }else if (nThumbTop > pixelRange)
                    {
                        thumbTop = nThumbTop = pixelRange;
                    }
                    else
                    {
                        thumbTop = y - spot;
                    }
                    float perc = (float)thumbTop / (float)pixelRange;
                    float fValue = perc * (_Maximum - _LargeChange);
                    this.value = (int)fValue;

                    Debug.WriteLine(this.value.ToString());
                    Application.DoEvents();
                    Invalidate();
                }
            }

        }
        [Description("Draw ScrollBar"), Category("Style")]
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw Border
            // -- Draw Outer border
            g.FillEllipse(new SolidBrush(trackBorderColor), new Rectangle(0, 0, this.Width, this.Width));
            g.FillRectangle(new SolidBrush(trackBorderColor), new Rectangle(0, this.Width/2, this.Width, this.Height - this.Width));
            g.FillEllipse(new SolidBrush(trackBorderColor), new Rectangle(0, this.Height - this.Width, this.Width, this.Width));

            // -- Draw Inner border
            g.FillEllipse(new SolidBrush(trackBarColor), new Rectangle(border, border, this.Width - (border * 2), this.Width - (border * 2)));
            g.FillRectangle(new SolidBrush(trackBarColor), new Rectangle(border, this.Width / 2, this.Width - (border * 2), this.Height - this.Width));
            g.FillEllipse(new SolidBrush(trackBarColor), new Rectangle(border, this.Height - this.Width, this.Width - border * 2, this.Width - border));

            // Draw Thumb
            float fSpanHeight = GetFloatThumbHeight() / 2.0f;
            int nSpanHeight = (int)fSpanHeight;
            int rThumpWidth = this.Width > nSpanHeight ? nSpanHeight : this.Width;
            Rectangle thumbRec = new Rectangle(new Point(0, thumbTop), new Size(this.Width, GetIntThumbHeight()));

            g.FillEllipse(new SolidBrush(thumbDown || thumbDragging ? thumbOnClick : thumbColor), new Rectangle(border, border + thumbRec.Y, this.Width - (border * 2), rThumpWidth - (border * 2)));
            g.FillRectangle(new SolidBrush(thumbDown || thumbDragging ? thumbOnClick : thumbColor), new Rectangle(border,(rThumpWidth / 2) + border + thumbRec.Y, this.Width - (border * 2), thumbRec.Height - rThumpWidth));
            g.FillEllipse(new SolidBrush(thumbDown || thumbDragging ? thumbOnClick : thumbColor), new Rectangle(border, thumbRec.Height - rThumpWidth + thumbRec.Y, this.Width - (border * 2), rThumpWidth - border));
        }

        // Event mouse Handler 
        private void CustomScrollBar_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = this.PointToClient(Cursor.Position);
            int thumb = GetIntThumbHeight();
            int top = thumbTop;
            Rectangle thumbRec = new Rectangle(new Point(1, top), new Size(this.Width, thumb));
            
            if (thumbRec.Contains(pt))
            {
                clickPoint = pt.Y - top;
                thumbDown = true;
                Invalidate();
            }
        }
        private void CustomScrollBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.thumbDown = false;
            this.thumbDragging = false;
            Invalidate();
        }
        private void CustomScrollBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(thumbDown == true)
            {
                this.thumbDragging = true;
            }

            if (this.thumbDragging)
            {

                MoveThumb(e.Y);
            }

            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());

            if (Scroll != null)
                Scroll(this, new EventArgs());

        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("Property")]
        [DisplayName("Value"),Description("Get Set ScrollBar Value")]
        public virtual int _Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                int iThumb = GetIntThumbHeight();
                int pixelRang = GetTrackHeight() - iThumb;
                int realPixelRange = (_Maximum - _Minimum) - _LargeChange;
                float perc = 0.0f;

                if (realPixelRange != 0)
                {
                    perc = (float)this.value / (float)realPixelRange;

                }
                float fTop = perc * pixelRang;
                thumbTop = (int)fTop;
                Invalidate();
            }
        }
   


        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Get Set Maximum value of scrollBar"), DisplayName("Maximum"), Category("Property")]
        public virtual int _Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                maximum = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Get Set Maximum value of scrollBar"), DisplayName("Minimum"), Category("Property")]
        public virtual int _Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                minimum = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Set Get Large change value of scrollBar"), DisplayName("Large Change"), Category("Property")]
        public virtual int _LargeChange
        {
            get
            {
                return largeChange;
            }
            set
            {
                largeChange = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Set Get Maximum value of scrollBar"), DisplayName("Small Change"), Category("Property")]
        public virtual int _SmallChange
        {
            get
            {
                return smallChange;
            }
            set
            {
                smallChange = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Properties set get Border of the track bar Color"), DisplayName("Border Color"), Category("Property")]
        public Color _BorderColor
        {
            get
            {
                return trackBorderColor;
            }
            set
            {
                trackBorderColor = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Properties set get track bar Color"), DisplayName("TrackBar Color"), Category("Property")]
        public Color _TrackColor
        {
            get
            {
                return trackBarColor;
            }
            set
            {
                trackBarColor = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Properties set get Thumb Color"), DisplayName("Thumb Color"), Category("Property")]
        public Color _ThumbColor
        {
            get
            {
                return thumbColor;
            }
            set
            {
                thumbColor = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Description("Properties set get Thumb on click Color"), DisplayName("Click thumb Color"), Category("Property")]
        public Color _ClickThumb
        {
            get
            {
                return thumbOnClick;
            }
            set
            {
                thumbOnClick = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Invisible Property
        /// </summary>
        [Browsable(false)]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        [Browsable(false)]
        public override bool AutoScroll { get => base.AutoScroll; set => base.AutoScroll = value; }
        [Browsable(false)]
        public override bool AllowDrop { get => base.AllowDrop; set => base.AllowDrop = value; }
        [Browsable(false)]
        public override string Text { get => base.Text; set => base.Text = value; }
        [Browsable(false)]
        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout { get => base.BackgroundImageLayout; set => base.BackgroundImageLayout = value; }
        [Browsable(false)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        [Browsable(false)]
        public override ContextMenuStrip ContextMenuStrip { get => base.ContextMenuStrip; set => base.ContextMenuStrip = value; }
        [Browsable(false)]
        public override Font Font { get => base.Font; set => base.Font = value; }
        [Browsable(false)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }
        [Browsable(false)]
        public override Point AutoScrollOffset { get => base.AutoScrollOffset; set => base.AutoScrollOffset = value; }
    }
    internal class ScrollbarControlDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                SelectionRules selectionRules = base.SelectionRules;
                PropertyDescriptor propDescriptor = TypeDescriptor.GetProperties(this.Component)["AutoSize"];
                if (propDescriptor != null)
                {
                    bool autoSize = (bool)propDescriptor.GetValue(this.Component);
                    if (autoSize)
                    {
                        selectionRules = SelectionRules.Visible | SelectionRules.Moveable | SelectionRules.BottomSizeable | SelectionRules.TopSizeable;
                    }
                    else
                    {
                        selectionRules = SelectionRules.Visible | SelectionRules.AllSizeable | SelectionRules.Moveable;
                    }
                }
                return selectionRules;
            }
        }
    }
}
