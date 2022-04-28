using System;
using System.Drawing;
using System.Windows.Forms;
//using IronBarCode;
using ZXing;
using Authenticator.AuthStringFile;
using Authenticator.Custom;

namespace Authenticator
{
    public partial class ScanQR : Form
    {
        int coordinateX = 0, coordinateY = 0, formOrigin = 0;
        AuthFileSecret file = new AuthFileSecret();
        string path;
        Image image;
        public ScanQR()
        {
            InitializeComponent();
            btn_Scan.BackColor = Color.FromArgb(0, 0, 0, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            if(Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                image = Properties.Resources.Dark_ScanQR;
            }
            else
            {
                image = Properties.Resources.Light_ScanQR;
            }
            path = $"{file.dir}/{file.authPath}";
        }

        // Resize form
        private void panel_Right_MouseDown(object sender, MouseEventArgs e)
        {
            coordinateX = e.X;
        }

        private void panel_bottom_MouseDown(object sender, MouseEventArgs e)
        {
            coordinateY = e.Y;
        }

        private void panel_Left_MouseDown(object sender, MouseEventArgs e)
        {
            coordinateX = e.X;
            formOrigin = this.Width;
        }

        private void panel_Right_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            
            int temp = this.Width - (coordinateX - e.X);
            this.Width = temp;
        }
        private void panel_bottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            int temp = this.Height - (coordinateY - e.Y);
            this.Height = temp;
        }

        private void panel_Left_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            int temp = this.Location.X - (coordinateX - e.X);
            int tempWidth = this.Width + (coordinateX - e.X);
            this.Location = new Point(temp, this.Location.Y);
            this.Width = tempWidth;
        }

        // Go to MainForm
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new MainAuthenticator().ShowDialog();
        }

        // Scan image in range of form on screen
        private void btn_Scan_Click(object sender, EventArgs e)
        {
            int x = this.Location.X + 10;
            int y = this.Location.Y + 30;
            Bitmap bitmap = new Bitmap(panel_ScanArea.Width, panel_ScanArea.Height);
            Graphics g = Graphics.FromImage(bitmap as Image);
            g.CopyFromScreen(x, y, 0, 0, bitmap.Size);
            try
            {
                BarcodeReader barcodereader = new BarcodeReader();
                string result = barcodereader.Decode(bitmap).Text;
                //MessageInform.ShowMessage(result);
                int index = file.GetLine(path);
                if (result != null)
                {
                    if (result.Contains("totp") || result.Contains("otpauth"))
                    {
                        if (MessageInform.ShowMessage("Scan success !!!\nDo you know to get code ???", "Success", MessageButton.YesNo, image) == MessageButton.Yes)
                        {
                            this.Dispose();
                            file.WriteToFile(file.GetDataString(new Uri(result)), path);
                            new MainAuthenticator().ShowDialog();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageInform.ShowMessage("QR code not found !!!!","404 Not Found");
            }
        }
    }
}
