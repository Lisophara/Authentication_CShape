using System;
using System.Windows.Forms;
using System.Drawing;
using OtpNet;
using Authenticator.AuthStringFile;
using Authenticator.Custom;
using System.IO;
using Authenticator.AuthenticatorDetail;
using System.Globalization;

namespace Authenticator
{
    public partial class AuthView : Form
    {
        string issuer, userData, url, key = null;
        int index;
        AuthFileSecret file = new AuthFileSecret();
        UrlQueryParam authInfo;
        public Auth_Mode defaultMode = Auth_Mode.Normal;
        
        public AuthView(){}

        // Use to get info from MainForm
        public AuthView(string key,string userName,int index)
        {
            InitializeComponent();
            Theme();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.TopMost = true;
            this.Dock = DockStyle.Top;
            this.Height = 100;
            this.Opacity = 95;
            authInfo = new UrlQueryParam(key);
            this.key = authInfo.Getkey();
            this.index = index;
            showInfo.Text = $"{userName}";
        }
        public AuthView(Uri url, int index)
        {
            InitializeComponent();
            Theme();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.TopMost = true;
            this.Dock = DockStyle.Top;
            this.Height = 100;
            this.Opacity = 95;
            this.url = url.ToString();
            this.index = index;
            authInfo = new UrlQueryParam(url);
            
            try
            {
                issuer = authInfo.GetQueryString(QueryType.Issuer);
                userData = authInfo.GetQueryString(QueryType.UserData);
            }
            catch {
            }
            
            showInfo.Text = $"{issuer} ( {userData} )";
        }

        private void OTPcode_Click(object sender, EventArgs e)
        {
            Image image;
            if (defaultMode != Auth_Mode.Normal) return;
            if (Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                image = Properties.Resources.Dark_FinishClipboard;
            }
            else
            {
                image = Properties.Resources.Light_FinishClipboard;
            }
            Clipboard.SetText(OTPcode.Text);
            MessageInform.ShowMessage($"Copied code {OTPcode.Text} !!!", "Copy code", MessageButton.Okay,image);
        }

        // Load Cursor icon
        private void AuthView_Load(object sender, EventArgs e)
        {
            OnMode();
            if(Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                lb_DeleteAccount.Cursor = new Cursor($"Cursor//Dark_TrashBin_Cursor.ico");
                if (defaultMode != Auth_Mode.Normal) return;
                OTPcode.Cursor = new Cursor($"Cursor//Dark_Clipboard_Cursor.ico");
            }
            else
            {
                lb_DeleteAccount.Cursor = new Cursor($"Cursor//Light_TrashBin_Cursor.ico");
                if (defaultMode != Auth_Mode.Normal) return;
                OTPcode.Cursor = new Cursor($"Cursor//Light_Clipboard_Cursor.ico");
            }
            
        }

        // This use to get code from key
        private void GetAuthCode(string key,Label code,CircleProcess.CircleProcess process)
        {
            try
            {
                string temp = null;
                var byteKey = Base32Encoding.ToBytes(key);
                var encode = new Totp(byteKey);
                temp = encode.ComputeTotp();
                code.Text = temp.Insert(3, " ");
                process._MaximunValue = 30;
                process._Value = 30 - encode.RemainingSeconds();
            }
            catch (Exception e)
            {
                RefreshOTP.Enabled = false;
                MessageInform.ShowMessage($"This key is Invalid ", "Invalid");
                this.Dispose();
            }
        }

        // Refresh OTP code every 30s
        private void RefreshOTP_Tick(object sender, EventArgs e)
        {
            if(key == null)
            {
                GetAuthCode(authInfo.GetQueryString(QueryType.Secret), OTPcode, RemainSecond);
            }
            else
            {
                GetAuthCode(key, OTPcode, RemainSecond);
            }
        }

        private void lb_Restore_Click(object sender, EventArgs e)
        {
            // read Restore file
            Image image;
            if (Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                image = Properties.Resources.Dark_Restore;
            }
            else
            {
                image = Properties.Resources.Light_Restore;
            }
            if (File.Exists(file.restorePath))
            {
                if (MessageInform.ShowMessage("Do you want to restore ???", "Restore account", MessageButton.YesNo, image) == MessageButton.Yes)
                {
                    if(file.RestoreAccount(file.restorePath, index))
                    {
                        this.Dispose();
                        MessageInform.ShowMessage("Have been restore an account !!!", "Restore account", MessageButton.Okay);
                    }
                    else
                    {
                        MessageInform.ShowMessage("Restore fail please try again !!!", "Restore account", MessageButton.Okay);
                    }
                    
                }
            }
            
        }

        // Use to delete account
        public void lb_DeleteAccount_Click(object sender, EventArgs e)
        {
            bool success = false;
            string path = $"{file.dir}/{file.authPath}";
            if (MessageInform.ShowMessage("Do you want to delete this account ???", "Delete Account", MessageButton.YesNo) == MessageButton.Yes)
            {
                try
                {
                    if (defaultMode == Auth_Mode.Normal)
                    {
                        // use for delete data in Normal file
                        success = file.DeleteAuthAccount(index, path);
                    }
                    else
                    {
                        // use for delete account in Restore file
                        success = file.DeleteAuthAccount(index);
                    }
                    if (success)
                    {
                        MessageInform.ShowMessage("Success !!!", "Delete Account", MessageButton.Okay);
                        this.Dispose();
                    }
                    else
                    {
                        MessageInform.ShowMessage("Fail !!!", "Delete Account", MessageButton.Okay);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        // Get Current day of delete
        public string[] Date()
        {
            string[] str = file.Resource(file.restorePath);
            string[] split = file.Decode(str[index]).Split('*');
            string[] temp = split[split.Length - 1].Split('/');
            string dTemp = $"{temp[1]}/{temp[0]}/{temp[2]}";
            string Dday = Convert.ToDateTime(dTemp, CultureInfo.InvariantCulture).AddDays(-30).ToString("dd/MM/yyyy");
            string[] result = { $"{split[split.Length - 1]}", $"{Dday}" };
            
            return result;
        }
        private void OnMode()
        {
            if(defaultMode == Auth_Mode.Restore)
            {
                string[] date = Date();
                lb_Deleted_Date.Visible = true;
                lb_Remove.Visible = true;
                lb_Restore.Visible = true;
                RefreshOTP.Enabled = false;
                RemainSecond.Visible = false;
                OTPcode.Text = "*** ***";
                lb_Deleted_Date.Text = $"Deleted at: {date[1]}";
                lb_Remove.Text = $"Will remove: {date[0]}";
            }
            else
            {
                lb_Deleted_Date.Visible = false;
                lb_Remove.Visible = false;
                lb_Restore.Visible = false;
            }
            
        }

        public Auth_Mode _ViewMode
        {
            get { return defaultMode; }
            set
            {
                defaultMode = value;
                Invalidate();
            }
        }
        // Theme
        private void Theme()
        {
            Color color = new Color();
            if(Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                this.BackColor = Color.FromArgb(65, 65, 65);
                RemainSecond._InnerCircle = Color.FromArgb(65, 65, 65);
                color = Color.Silver;
            }
            else if (Properties.Settings.Default.Theme == ThemeColor.LightTheme.ToString())
            {
                this.BackColor = Color.White;
                RemainSecond._InnerCircle = Color.White;
                color = Color.Black;
            }
            showInfo.ForeColor = color;
            OTPcode.ForeColor = color;
            lb_Deleted_Date.ForeColor = color;
            lb_Remove.ForeColor = color;
            RemainSecond._TextColor = color;
            lb_Restore.ForeColor = color;
            lb_DeleteAccount.ForeColor = color;
            lb_EndLine.BackColor = color;

        }
    }
}
