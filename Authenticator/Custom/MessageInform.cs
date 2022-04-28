using System;
using System.Drawing;
using System.Windows.Forms;

namespace Authenticator.Custom
{
    public partial class MessageInform : Form
    {
        
        private static MessageButton button;
        public MessageInform()
        {
            InitializeComponent();
            pic_MessagePicture.Visible = false;
            lb_messageInform.Visible = false;
            btn_Okay.Visible = false;
            btn_Yes.Visible = false;
            btn_No.Visible = false;
        }
        private MessageInform(string Message)
        {
            InitializeComponent();
            Theme();
            lb_messageInform.Location = new Point(pic_MessagePicture.Location.X,lb_messageInform.Location.Y);
            lb_messageInform.Text = Message;

        }
        private  MessageInform(string Message, string Caption)
        {
            InitializeComponent();
            Theme();
            lb_messageInform.Location = new Point(pic_MessagePicture.Location.X, 55);
            lb_messageInform.Text = Message;
            lb_Caption.Text = Caption;
        }
        private MessageInform(string Message, string Caption, MessageButton messageButton)
        {
            InitializeComponent();
            Theme();
            lb_messageInform.Text = Message;
            lb_messageInform.Location = new Point(pic_MessagePicture.Location.X, lb_messageInform.Location.Y);
            lb_Caption.Text = Caption;
            if (messageButton == MessageButton.Okay)
            {
                btn_Okay.Visible = true;
                btn_Okay.Location = new Point(150, 164);
            }
            else if (messageButton == MessageButton.YesNo)
            {
                btn_Yes.Visible = true;
                btn_No.Visible = true;
                btn_Yes.Location = new Point(99, 164);
                btn_No.Location = new Point(205, 164);
            }
        }
        private MessageInform(string Message, string Caption, MessageButton messageButton, Image image)
        {
            InitializeComponent();
            Theme();
            lb_messageInform.Text = Message;
            lb_Caption.Text = Caption;
            pic_MessagePicture.Image = image;
            if (messageButton == MessageButton.Okay)
            {
                btn_Okay.Visible = true;
                btn_Okay.Location = new Point(150, 164);
            }
            else if(messageButton == MessageButton.YesNo)
            {
                btn_Yes.Visible = true;
                btn_No.Visible = true;
                btn_Yes.Location = new Point(99, 164);
                btn_No.Location = new Point(205, 164);
            }else if(messageButton == MessageButton.Yes)
            {
                btn_Yes.Location = new Point(150, 164);
            }
        }
        public static void ShowMessage(string Message)
        {
            new MessageInform(Message).ShowDialog();
        }
        public static void ShowMessage(string Message,string Caption)
        {
            new MessageInform(Message,Caption).ShowDialog();
        }
        public static MessageButton ShowMessage(string Message,string Caption, MessageButton messageButton)
        {
            new MessageInform(Message,Caption,messageButton).ShowDialog();
            return ButtonMessage;
        }
        public static MessageButton ShowMessage(string Message, string Caption, MessageButton messageButton, Image image)
        {
            new MessageInform(Message,Caption,messageButton,image).ShowDialog();
            return ButtonMessage;
        }
        private void pic_CloseApplication_Click(object sender, EventArgs e)
        {
            ButtonMessage = MessageButton.No;
            this.Dispose();
        }
        private void btn_Okay_Click(object sender, EventArgs e)
        {
            ButtonMessage = MessageButton.Okay;
            this.Dispose();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            ButtonMessage = MessageButton.Yes;
            this.Dispose();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            ButtonMessage = MessageButton.No;
            this.Dispose();
        }
        private void Theme()
        {
            if(Properties.Settings.Default.Theme != ThemeColor.LightTheme.ToString())
            {
                this.BackColor = Color.FromArgb(65, 65, 65);
                pic_CloseApplication.Image = Properties.Resources.Dark_CloseApplication;
                lb_Caption.ForeColor = Color.White;
                lb_messageInform.ForeColor = Color.White;
                // Button
                btn_Okay._BorderColor = Color.Gray;
                btn_Okay._InnerButtonColor = Color.White;
                btn_Okay._TextColor = Color.Black;

                btn_Yes._BorderColor = Color.Gray;
                btn_Yes._InnerButtonColor = Color.White;
                btn_Yes._TextColor = Color.Black;

                btn_No._BorderColor = Color.Gray;
                btn_No._InnerButtonColor = Color.White;
                btn_No._TextColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
                pic_CloseApplication.Image = Properties.Resources.Light_CloseApplication;
                lb_Caption.ForeColor = Color.Black;
                lb_messageInform.ForeColor = Color.Black;
                // Button
                btn_Okay._BorderColor = Color.Silver;
                btn_Okay._InnerButtonColor = Color.Black;
                btn_Okay._TextColor = Color.White;

                btn_Yes._BorderColor = Color.Silver;
                btn_Yes._InnerButtonColor = Color.Black;
                btn_Yes._TextColor = Color.White;

                btn_No._BorderColor = Color.Silver;
                btn_No._InnerButtonColor = Color.Black;
                btn_No._TextColor = Color.White;
            }
        }
        private static MessageButton ButtonMessage
        {
            get { return button; }
            set { button = value;}
        }
    }
}
