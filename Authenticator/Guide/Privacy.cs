using System;
using System.Windows.Forms;
using Authenticator.Custom;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Authenticator.Guide
{
    public partial class Privacy : Form
    {
        private int internetConnection = 0;
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int connection, int value);
        public Privacy()
        {
            InitializeComponent();
            author.Text = "Leam Lisophara" + (char)169;
            //Theme();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //new MainAuthenticator().Visible = true;
        }

        //private void Theme()
        //{
        //    Color color = new Color();
        //    if(Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
        //    {
        //        this.BackColor = Color.FromArgb(65, 65, 65);
        //        pictureBox1.Image = Properties.Resources.Dark_CloseApplication;
        //        color = Color.White;
        //    }
        //    else
        //    {
        //        this.BackColor = Color.White;
        //        pictureBox1.Image = Properties.Resources.Light_CloseApplication;
        //        color = Color.Black;
        //    }
        //    lb_Caption.ForeColor = color;
        //    lb_Info.ForeColor = color;
        //}
        private const string ChromeAppKey = @"\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";
        private void lk_Report_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Image image;
            if(Properties.Settings.Default.Theme == ThemeColor.DarkTheme.ToString())
            {
                image = Properties.Resources.Dark_Internet;
            }
            else
            {
                image = Properties.Resources.Light_Internet;
            }
            if( InternetGetConnectedState(out internetConnection, 0) != true )
            {
                MessageInform.ShowMessage("Please connect to internet first !!!", "Connection error", MessageButton.Okay, image);
                return;
            }
            //string chrome = chrome = (string)(Registry.GetValue("HKEY_LOCAL_MACHINE" + ChromeAppKey, "", null)); ;
            //if (string.IsNullOrEmpty(chrome))
            //{
            //    try
            //    {
            //        Process.Start("Start chrome\"https://rootprojects.org/authenticator/ \"");

            //    }
            //    catch
            //    {
            //        MessageInform.ShowMessage("Not found Chrome.exe");
            //        return;
            //    }
            //}
            //Process.Start(chrome, @"https://rootprojects.org/authenticator/");
            
            Process.Start("Chrome.exe","https://rootprojects.org/authenticator/");
            
        }
    }
}
