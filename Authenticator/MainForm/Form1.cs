using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Authenticator.AuthStringFile;
using Authenticator.Custom;
using Authenticator.Guide;
using Authenticator.AuthenticatorDetail;

namespace Authenticator
{

    public partial class MainAuthenticator : Form
    {
        bool hidePanel = true;
        bool hideDropDownKeyPanel = true, hideDropDownSettingPanel = true, hideDropDownThemePanel = true;
        AuthFileSecret file = new AuthFileSecret();
        AuthView authView;
        string authenSecretFile = $"{new AuthFileSecret().dir}/{new AuthFileSecret().authPath}";
        int count = 0;

        public MainAuthenticator()
        {
            InitializeComponent();

            // Default Theme
            if (Properties.Settings.Default.Theme == string.Empty)
            {
                Properties.Settings.Default.Theme = ThemeColor.LightTheme.ToString();
                Properties.Settings.Default.Save();
            }
            Theme();
            // Set Default location
            DefaultLocationKey(KeyPanelDropDown);
            DefaultLocationSetting();
            // delete account after 30 days
            file.DeleteRestoreAccount(file.restorePath);

            // Read user secret key
            ReadAccountFromFile(authenSecretFile, AuthCodeViewer, auth_ScrollBar, Auth_Mode.Normal);
            count = AuthCodeViewer.Controls.Count;
            ScrollBarTheme(auth_ScrollBar);
            this.MouseWheel += MainAuthenticator_MouseWheel;
        }

        private void MainAuthenticator_MouseWheel(object sender, MouseEventArgs e)
        {
            auth_ScrollBar._Value = AuthCodeViewer.AutoScrollPosition.Y;
        }

        private void MainAuthenticator_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                BtnImage(ThemeColor.DarkTheme);
            }
            else
            {
                BtnImage(ThemeColor.LightTheme);
            }   
        }

        public void ReadAccountFromFile(string path, FlowLayoutPanel panel, CustomScrollBar scrollBar, Auth_Mode mode)
        {
            int totalAccount = 0;
            // Read user secret key
            if (File.Exists(path))
            {
                string[] str = file.Resource(path);
                totalAccount = str.Length;
                panel.Controls.Clear();
                for (int i = 0; i < totalAccount; i++)
                {
                    string item = str[i];
                    if (item != "")
                    {
                        try
                        {
                            string[] split = file.Decode(item).Split('*');
                            if (split[2].ToLower() == "url" && item != null)
                            {
                                DisplayAuthCode(new Uri(split[0]), i, panel, mode);
                            }
                            else
                            {
                                DisplayAuthCode(split[0], split[1], i, panel, mode);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageInform.ShowMessage(ex.Message);
                            break;
                        }
                    }
                }
                scrollBar._Minimum = 0;
                scrollBar._LargeChange = scrollBar._Maximum / scrollBar.Height + panel.Height;
                scrollBar._Maximum = panel.DisplayRectangle.Height;
                //auth_ScrollBar._SmallChange = 10;

            }
        }

        private void DisplayAuthCode(string key, string userName, int index, FlowLayoutPanel panel, Auth_Mode mode)
        {
            try
            {
                authView = new AuthView(key, userName, index) { _ViewMode = mode };
                panel.Controls.Add(authView);
                authView.Show();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void DisplayAuthCode(Uri url, int index, FlowLayoutPanel panel, Auth_Mode mode)
        {
            try
            {
                authView = new AuthView(url, index) { _ViewMode = mode};
                panel.Controls.Add(authView);
                authView.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        // Animation
        private void slideMenu_Tick(object sender, EventArgs e)
        {
            // Animate
            if (hidePanel)
            {
                if (Menu.Width >= 240)
                {
                    hidePanel = false;
                    slideMenu.Enabled = false;
                }
                Menu.Width += 4;
                btn_SlideMenu.ImageAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                Menu.Width -= 4;
                if (Menu.Width <= 40) { btn_SlideMenu.ImageAlign = ContentAlignment.MiddleCenter; }
                if (Menu.Width <= 27)
                {

                    // Hide and set add key panel
                    // Panel key
                    KeyPanelDropDown.Visible = false;
                    KeyPanelDropDown.Height = 120;
                    hideDropDownKeyPanel = true;
                    // Panel setting
                    panel_Setting.Visible = false;
                    panel_Setting.Height = 140;
                    hideDropDownSettingPanel = true;
                    // Slide in out
                    hidePanel = true;

                    // stop animation
                    slideMenu.Enabled = false;
                }
            }
        }

        private void refresh_ScrollBar_Tick(object sender, EventArgs e)
        {
            if (AuthCodeViewer.Controls.Count > count && count != 0)
            {
                ReadAccountFromFile(authenSecretFile, AuthCodeViewer, auth_ScrollBar, Auth_Mode.Normal);
                count = AuthCodeViewer.Controls.Count;
            }
            else if(AuthCodeViewer.Controls.Count < count && count != 0)
            {
                ReadAccountFromFile(authenSecretFile, AuthCodeViewer, auth_ScrollBar, Auth_Mode.Normal);
                count = AuthCodeViewer.Controls.Count;
            }
        }

        // Close application
        private void pic_closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Start Animation
        private void btn_SlideMenu_Click(object sender, EventArgs e)
        {
            slideMenu.Enabled = true;
            panel_Theme.Visible = false;
            KeyPanelDropDown.Height = 0;
            AnimationAll(KeyPanelDropDown);
            panel_Setting.Visible = false;
            hideDropDownSettingPanel = true;
            hideDropDownThemePanel = true;
            DefaultLocationSetting();
        }

        // Hide and Show Menu panel
        private void HideDropDownKeyPanel(Panel panel)
        {
            if (hideDropDownKeyPanel)
            {
                panel.Visible = true;
                AnimationAll(KeyPanelDropDown);
                hideDropDownKeyPanel = false;
                Invalidate();
            }
            else
            {
                panel.Visible = false;
                DefaultLocationKey(KeyPanelDropDown);
                DefaultLocationSetting();
                hideDropDownKeyPanel = true;
                Invalidate();
            }
        }
        private void HideDropDownSettingPanel(Panel panel)
        {
            if (hideDropDownSettingPanel)
            {
                panel.Visible = true;
                AnimationAll(KeyPanelDropDown);
                panel_Theme.Visible = false;
                hideDropDownSettingPanel = false;
                Invalidate();
            }
            else
            {
                panel.Visible = false;
                DefaultLocationSetting();
                hideDropDownSettingPanel = true;
                Invalidate();
            }
        }
        private void HideDropDownThemePanel(Panel panel)
        {
            if (hideDropDownThemePanel)
            {
                panel.Visible = true;
                AnimationAll(KeyPanelDropDown);
                btn_Detail.Location = new Point(this.btn_Detail.Location.X, 104);
                hideDropDownThemePanel = false;
                Invalidate();
            }
            else
            {
                panel.Visible = false;
                DefaultLocationSetting();
                hideDropDownThemePanel = true;
                Invalidate();
            }
        }

        // Go to Scan QR code form
        private void btn_ScanQR_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ScanQR().ShowDialog();
        }

        // Show Key panel
        private void btn_AddKey_Click(object sender, EventArgs e)
        {
            if(Menu.Width <= 240)
            {
                Menu.Size = new Size(240, Menu.Height);
                slideMenu.Enabled = false;
                panel1.Location = new Point(240, AuthCodeViewer.Location.Y);
            }
            
            btn_SlideMenu.ImageAlign = ContentAlignment.MiddleRight;
            KeyPanelDropDown.Height = 120;
            hidePanel = false;
            HideDropDownKeyPanel(KeyPanelDropDown);
        }

        // Create account
        private void btn_createWithKey_Click(object sender, EventArgs e)
        {
            string username = "Unknown";
            int index = file.GetLine(authenSecretFile);
            HideDropDownKeyPanel(KeyPanelDropDown);

            if (txt_Key.Text.Trim() == txt_Key.PlaceHolderText || new UrlQueryParam(txt_Key.Text.Trim()).Getkey().Length != 32)
            {
                MessageInform.ShowMessage($"This is Invalid");
                txt_Account.Text = txt_Account.PlaceHolderText;
                txt_Key.Text = txt_Key.PlaceHolderText;
                return;
            }
            else if (txt_Account.Text.Trim() != txt_Account.PlaceHolderText)
            {
                username = txt_Account.Text.Trim();
            }
            
            file.WriteToFile(file.GetDataString(txt_Key.Text.Trim(), username), $"{file.dir}/{file.authPath}");

            //DisplayAuthCode(new UrlQueryParam(txt_Key.Text.Trim()).Getkey(), username, index, AuthCodeViewer, Auth_Mode.Normal);
            AuthCodeViewer.Controls.Clear();
            ReadAccountFromFile(authenSecretFile, AuthCodeViewer, auth_ScrollBar, Auth_Mode.Normal);
            
            txt_Account.Text = txt_Account.PlaceHolderText;
            txt_Key.Text = txt_Key.PlaceHolderText;
        }

        // Restore account
        private void btn_Restore_Click(object sender, EventArgs e)
        {
            Image image;
            if (Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                image = Properties.Resources.Dark_Restore;
            }
            else
            {
                image = Properties.Resources.Light_Restore;
            }
            this.Visible = false;
            new RestoreAuth().ShowDialog();
            
        }
        // Setting
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            if (Menu.Width <= 240)
            {
                Menu.Size = new Size(240, Menu.Height);
                slideMenu.Enabled = false;
                panel1.Location = new Point(240, AuthCodeViewer.Location.Y);
            }
            hidePanel = false;
            btn_SlideMenu.ImageAlign = ContentAlignment.MiddleRight;
            HideDropDownSettingPanel(panel_Setting);

        }

        private void btn_Theme_Click(object sender, EventArgs e)
        {
            HideDropDownThemePanel(panel_Theme);
        }
        private void btn_DarkTheme_Click(object sender, EventArgs e)
        {
            ThemeChanger(ThemeColor.DarkTheme);
        }
        private void btn_LightTheme_Click(object sender, EventArgs e)
        {
            ThemeChanger(ThemeColor.LightTheme);
        }
        private void btn_Privacy_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new Privacy().ShowDialog();
        }

        // Use for change templet theme
        private void Theme(ThemeColor themeColor)
        {
            if (themeColor == ThemeColor.DarkTheme)
            {
                Properties.Settings.Default.Theme = ThemeColor.DarkTheme.ToString();
            }
            else if (themeColor == ThemeColor.LightTheme)
            {
                Properties.Settings.Default.Theme = ThemeColor.LightTheme.ToString();
            }
            Properties.Settings.Default.Save();
            Application.Restart();
        }
        private void ThemeChanger(ThemeColor themeColor)
        {
            if (Properties.Settings.Default.Theme != themeColor.ToString())
            {
                Theme(themeColor);
            }
        }

        // Use Animation Object under DropDownPanel 
        // Default location
        private void DefaultLocationKey(Panel panel)
        {
            btn_Restore.Location = new Point(btn_Restore.Location.X, panel.Location.Y);

        }

        private void DefaultLocationSetting()
        {
            btn_Setting.Location = new Point(btn_Setting.Location.X, btn_Restore.Location.Y + btn_Restore.Height + 5);
            panel_Setting.Location = new Point(panel_Setting.Location.X, btn_Setting.Location.Y + btn_Setting.Height);
            btn_Detail.Location = new Point(btn_Detail.Location.X, panel_Theme.Location.Y);
            
        }

        private void AnimationAll(Panel panel)
        {
            if (panel.Visible == true)
            {
                btn_Restore.Location = new Point(btn_Restore.Location.X, panel.Location.Y + panel.Height);
                btn_Setting.Location = new Point(btn_Setting.Location.X, btn_Restore.Location.Y + btn_Restore.Height + 5);
                panel_Setting.Location = new Point(panel_Setting.Location.X, btn_Setting.Location.Y + btn_Setting.Height);
            }
        }

        // Theme 
        private void Theme()
        {
            Color color = new Color();
            if (Properties.Settings.Default.Theme == ThemeColor.LightTheme.ToString())
            {
                pic_closeApplication.Image = Properties.Resources.Light_CloseApplication;
                this.BackColor = Color.White;
                Menu.BackColor = Color.Gray;
                // Button and Label
                color = Color.White;
                // Label
                lb_ApplicationName.ForeColor = Color.Black;
                lb_SecretKey.ForeColor = Color.Black;
                // Create Button only
                btn_createWithKey._TextColor = Color.White;
                btn_createWithKey._InnerButtonColor = Color.Black;
                btn_createWithKey._BorderColor = Color.DarkGray;


            }
            else if (Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                pic_closeApplication.Image = Properties.Resources.Dark_CloseApplication;
                this.BackColor = Color.FromArgb(65, 65, 65);
                Menu.BackColor = Color.FromArgb(80, 80, 80);
                // Button and Label
                color = Color.Black;
                // Label
                lb_ApplicationName.ForeColor = Color.White;
                lb_SecretKey.ForeColor = Color.White;
                // Create Button only
                btn_createWithKey._TextColor = Color.Black;
                btn_createWithKey._InnerButtonColor = Color.White;
                btn_createWithKey._BorderColor = Color.Silver;
            }
            // Button
            btn_ScanQR.ForeColor = Color.White;
            btn_AddKey.ForeColor = Color.White;
            btn_Restore.ForeColor = Color.White;
            btn_Setting.ForeColor = Color.White;
            btn_Theme.ForeColor = Color.White;
            btn_DarkTheme.ForeColor = Color.White;
            btn_LightTheme.ForeColor = Color.White;
            btn_Detail.ForeColor = Color.White;
        }

        private void auth_ScrollBar_Scroll(object sender, EventArgs e)
        {
            AuthCodeViewer.AutoScrollPosition = new Point(AuthCodeViewer.Location.X, auth_ScrollBar._Value);
        }

        public void ScrollBarTheme(CustomScrollBar scrollBar)
        {
            if(Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                scrollBar._ClickThumb = Color.DarkGray;
                scrollBar._ThumbColor = Color.FromArgb(65, 65, 65);
                scrollBar._BorderColor = Color.Gray;
                scrollBar._TrackColor = Color.LightGray;
            }
            else
            {
                scrollBar._ClickThumb = Color.Gray;
                scrollBar._BorderColor = Color.Black;
                scrollBar._TrackColor = Color.FromArgb(65, 65, 65);
                scrollBar._ThumbColor = Color.LightGray;
            }
        }

        private void BtnImage(ThemeColor theme)
        {
            if(ThemeColor.DarkTheme.ToString() == Properties.Settings.Default.Theme)
            {
                btn(btn_ScanQR, Properties.Resources.Dark_ScanQR);
                btn(btn_AddKey, Properties.Resources.Dark_AddKey);
                btn(btn_Restore, Properties.Resources.Dark_Restore);
                btn(btn_Setting, Properties.Resources.Dark_Setting);
                btn_SlideMenu.Image = new Bitmap(Properties.Resources.Dark_ThreeLine, new Size(27, 27));

            }
            else
            {
                btn(btn_ScanQR, Properties.Resources.Light_ScanQR);
                btn(btn_AddKey, Properties.Resources.Light_AddKey);
                btn(btn_Restore, Properties.Resources.Light_Restore);
                btn(btn_Setting, Properties.Resources.Light_Setting);
                btn_SlideMenu.Image = new Bitmap(Properties.Resources.Light_ThreeLine, new Size(27, 27));
            }
        }

        private void btn(Button button,Image image)
        {
            var size = new Size(27, 27);
            Bitmap bitmap = new Bitmap(image, size);

            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Image = bitmap;
        }
    }
    
}
