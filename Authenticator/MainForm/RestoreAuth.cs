using System;
using System.Windows.Forms;
using Authenticator.Custom;
using Authenticator.AuthStringFile;
using System.Drawing;
namespace Authenticator.AuthenticatorDetail
{
    public partial class RestoreAuth : Form
    {
        MainAuthenticator AuthOutput = new MainAuthenticator();
        AuthFileSecret file = new AuthFileSecret();
        int count = 0;
        public RestoreAuth()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = new MainAuthenticator().BackColor;
            new MainAuthenticator().ScrollBarTheme(restore_ScrollBar);
            if (Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                pic_Form.Image = Properties.Resources.Dark_Restore;
                pic_Close.Image = Properties.Resources.Dark_CloseApplication;
                lb_FormName.ForeColor = Color.White;
            }
            else
            {
                pic_Form.Image = Properties.Resources.Light_Restore;
                pic_Close.Image = Properties.Resources.Light_CloseApplication;
                lb_FormName.ForeColor = Color.Black;
            }
            AuthOutput.ReadAccountFromFile(file.restorePath, panel_Restore, restore_ScrollBar, Auth_Mode.Restore);
            count = panel_Restore.Controls.Count;
        }
        private void restore_ScrollBar_Scroll(object sender, EventArgs e)
        {
            panel_Restore.AutoScrollPosition = new Point(0, restore_ScrollBar._Value);
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            Application.Restart();
           
        }

        private void refresh_ScrollBar_Tick(object sender, EventArgs e)
        {
            if (panel_Restore.Controls.Count < count && count != 0)
            {
                AuthOutput.ReadAccountFromFile(file.restorePath, panel_Restore, restore_ScrollBar, Auth_Mode.Restore);
                count = panel_Restore.Controls.Count;
            }
        }
    }
}
