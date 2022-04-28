using System.Windows.Forms;
using System.Drawing;

namespace SmtpSenderMail.Classes.CustomShap
{
    public partial class TxtBox : TextBox
    {
        private string _watermarkText;
        private Color _placeHolderTextColor = Color.Gray;
        private Color _forceColor = Color.Black;
        private Color _underlineColor = Color.Black;
        private Color _TextOnHover = Color.IndianRed;
        private Color _UnderlineonHover = Color.Brown;
        private bool _WantTextHover = false;
        private bool _WantUnerlineHover = false;
        private bool mouseHover;
        public TxtBox()
        {
            InitializeComponent();
            Width = 222;
            Height = 20;
            BorderStyle = BorderStyle.None;
            TextAlign = HorizontalAlignment.Center;
            MouseEnter += (sender, e) =>
            {
                mouseHover = true;
                OnHover();
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                mouseHover = false;
                OnHover();
                Invalidate();
            };
            Controls.Add(new Label
            {
                Height = 3,
                Dock = DockStyle.Bottom,
                BackColor = _underlineColor,
            });
        }
        private void OnHover()
        {
            if(this.Text == PlaceHolderText)
            {
                this.ForeColor = Color.Gray;
                if (mouseHover && _WantUnerlineHover)
                {
                    Controls[0].BackColor = _UnderLineOnHover;
                }
                else
                {
                    Controls[0].BackColor = _underlineColor;
                }
            }
            else
            {
                if (mouseHover && _WantTextHover)
                {
                    this.ForeColor = _TextOnHover;
                }
                else
                {
                    this.ForeColor = _forceColor;
                }
                if(mouseHover && _WantUnerlineHover)
                {
                    Controls[0].BackColor = _UnderLineOnHover;
                }
                else
                {
                    Controls[0].BackColor = _underlineColor;
                }
            }
        }
        public Color ForceColor
        {
            get { return _placeHolderTextColor; }
            set { _placeHolderTextColor = value; }
        }
        public Color UnderlineColor
        {
            get { return _underlineColor; }
            set { _underlineColor = value; Controls[0].BackColor = _underlineColor;
                Invalidate();
            }
        }
        //
        // OnHover
        //
        public Color _UnderLineOnHover
        {
            get { return _UnderlineonHover; }
            set { _UnderlineonHover = value; Controls[0].BackColor = _UnderlineonHover; }
        }
        public Color _TextColorOnHover
        {
            get { return _TextOnHover; }
            set { _TextOnHover = value;}
        }
        //
        // OnHover Permission
        //
        public bool _TextOnHoverActivate
        {
            get { return _WantTextHover; }
            set { _WantTextHover = value; }
        }
        public bool _UnderLineOnHoverActivate
        {
            get { return _WantUnerlineHover; }
            set { _WantUnerlineHover = value; }
        }
        //
        // PlaceHolder
        //
        public string PlaceHolderText
        {
            get { return _watermarkText; }
            set
            {
                _watermarkText = value;
                GetTextColor();
                Invalidate();
            }
        }
        private void GetTextColor()
        {
            if ((this.Text == string.Empty) || (this.Text == PlaceHolderText))
            {
                this.ForeColor = _placeHolderTextColor;
                this.Text = PlaceHolderText;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
        }

        private void TxtBox_Enter(object sender, System.EventArgs e)
        {
            if ((this.Text == PlaceHolderText) || (this.Text == string.Empty))
            {
                this.ForeColor = Color.Black;
                this.Text = string.Empty;
                
                if ((PlaceHolderText.ToLower() == "password") && PlaceHolderText != null)
                {
                    this.UseSystemPasswordChar = true;
                }
            }
        }

        private void TxtBox_Leave(object sender, System.EventArgs e)
        {
            GetTextColor();
            if ((this.Text == PlaceHolderText) || (this.Text == string.Empty))
            {
                this.UseSystemPasswordChar = false;
            }
        }
    }
}
