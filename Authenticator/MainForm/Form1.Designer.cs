
namespace Authenticator
{
    partial class MainAuthenticator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAuthenticator));
            this.slideMenu = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.Panel();
            this.btn_SlideMenu = new System.Windows.Forms.Button();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.panel_Theme = new System.Windows.Forms.Panel();
            this.btn_LightTheme = new System.Windows.Forms.Button();
            this.btn_DarkTheme = new System.Windows.Forms.Button();
            this.btn_Theme = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.KeyPanelDropDown = new System.Windows.Forms.Panel();
            this.lb_SecretKey = new System.Windows.Forms.Label();
            this.btn_AddKey = new System.Windows.Forms.Button();
            this.btn_ScanQR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AuthCodeViewer = new System.Windows.Forms.FlowLayoutPanel();
            this.refresh_ScrollBar = new System.Windows.Forms.Timer(this.components);
            this.auth_ScrollBar = new Authenticator.Custom.CustomScrollBar();
            this.btn_createWithKey = new SmtpSenderMail.Classes.CustomShap.RoundButton();
            this.txt_Key = new SmtpSenderMail.Classes.CustomShap.TxtBox();
            this.txt_Account = new SmtpSenderMail.Classes.CustomShap.TxtBox();
            this.moveForm1 = new Authenticator.Custom.MoveForm();
            this.pic_Application = new System.Windows.Forms.PictureBox();
            this.pic_closeApplication = new System.Windows.Forms.PictureBox();
            this.lb_ApplicationName = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.panel_Setting.SuspendLayout();
            this.panel_Theme.SuspendLayout();
            this.KeyPanelDropDown.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.moveForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Application)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_closeApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // slideMenu
            // 
            this.slideMenu.Interval = 1;
            this.slideMenu.Tick += new System.EventHandler(this.slideMenu_Tick);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Menu.Controls.Add(this.btn_SlideMenu);
            this.Menu.Controls.Add(this.panel_Setting);
            this.Menu.Controls.Add(this.btn_Setting);
            this.Menu.Controls.Add(this.btn_Restore);
            this.Menu.Controls.Add(this.KeyPanelDropDown);
            this.Menu.Controls.Add(this.btn_AddKey);
            this.Menu.Controls.Add(this.btn_ScanQR);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 30);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(26, 425);
            this.Menu.TabIndex = 0;
            // 
            // btn_SlideMenu
            // 
            this.btn_SlideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SlideMenu.FlatAppearance.BorderSize = 0;
            this.btn_SlideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SlideMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SlideMenu.Location = new System.Drawing.Point(0, 0);
            this.btn_SlideMenu.Name = "btn_SlideMenu";
            this.btn_SlideMenu.Size = new System.Drawing.Size(26, 27);
            this.btn_SlideMenu.TabIndex = 2;
            this.btn_SlideMenu.UseVisualStyleBackColor = true;
            this.btn_SlideMenu.Click += new System.EventHandler(this.btn_SlideMenu_Click);
            // 
            // panel_Setting
            // 
            this.panel_Setting.BackColor = System.Drawing.Color.Transparent;
            this.panel_Setting.Controls.Add(this.btn_Detail);
            this.panel_Setting.Controls.Add(this.panel_Theme);
            this.panel_Setting.Controls.Add(this.btn_Theme);
            this.panel_Setting.Location = new System.Drawing.Point(-1, 285);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(248, 141);
            this.panel_Setting.TabIndex = 4;
            this.panel_Setting.Visible = false;
            // 
            // btn_Detail
            // 
            this.btn_Detail.FlatAppearance.BorderSize = 0;
            this.btn_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Detail.ForeColor = System.Drawing.Color.White;
            this.btn_Detail.Location = new System.Drawing.Point(3, 104);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(245, 27);
            this.btn_Detail.TabIndex = 3;
            this.btn_Detail.Text = "Detail";
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Privacy_Click);
            // 
            // panel_Theme
            // 
            this.panel_Theme.BackColor = System.Drawing.Color.Transparent;
            this.panel_Theme.Controls.Add(this.btn_LightTheme);
            this.panel_Theme.Controls.Add(this.btn_DarkTheme);
            this.panel_Theme.Location = new System.Drawing.Point(3, 33);
            this.panel_Theme.Name = "panel_Theme";
            this.panel_Theme.Size = new System.Drawing.Size(238, 68);
            this.panel_Theme.TabIndex = 4;
            this.panel_Theme.Visible = false;
            // 
            // btn_LightTheme
            // 
            this.btn_LightTheme.FlatAppearance.BorderSize = 0;
            this.btn_LightTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LightTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LightTheme.ForeColor = System.Drawing.Color.White;
            this.btn_LightTheme.Location = new System.Drawing.Point(-1, 38);
            this.btn_LightTheme.Name = "btn_LightTheme";
            this.btn_LightTheme.Size = new System.Drawing.Size(245, 27);
            this.btn_LightTheme.TabIndex = 3;
            this.btn_LightTheme.Text = "Light Theme";
            this.btn_LightTheme.UseVisualStyleBackColor = true;
            this.btn_LightTheme.Click += new System.EventHandler(this.btn_LightTheme_Click);
            // 
            // btn_DarkTheme
            // 
            this.btn_DarkTheme.FlatAppearance.BorderSize = 0;
            this.btn_DarkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarkTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DarkTheme.ForeColor = System.Drawing.Color.White;
            this.btn_DarkTheme.Location = new System.Drawing.Point(-2, 3);
            this.btn_DarkTheme.Name = "btn_DarkTheme";
            this.btn_DarkTheme.Size = new System.Drawing.Size(245, 27);
            this.btn_DarkTheme.TabIndex = 3;
            this.btn_DarkTheme.Text = "Dark Theme";
            this.btn_DarkTheme.UseVisualStyleBackColor = true;
            this.btn_DarkTheme.Click += new System.EventHandler(this.btn_DarkTheme_Click);
            // 
            // btn_Theme
            // 
            this.btn_Theme.FlatAppearance.BorderSize = 0;
            this.btn_Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Theme.ForeColor = System.Drawing.Color.White;
            this.btn_Theme.Location = new System.Drawing.Point(0, 0);
            this.btn_Theme.Name = "btn_Theme";
            this.btn_Theme.Size = new System.Drawing.Size(248, 27);
            this.btn_Theme.TabIndex = 3;
            this.btn_Theme.Text = "Theme";
            this.btn_Theme.UseVisualStyleBackColor = true;
            this.btn_Theme.Click += new System.EventHandler(this.btn_Theme_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Setting.Location = new System.Drawing.Point(-6, 252);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(255, 27);
            this.btn_Setting.TabIndex = 3;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.FlatAppearance.BorderSize = 0;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Restore.ForeColor = System.Drawing.Color.White;
            this.btn_Restore.Location = new System.Drawing.Point(-6, 219);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(255, 27);
            this.btn_Restore.TabIndex = 3;
            this.btn_Restore.Text = "Restore";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // KeyPanelDropDown
            // 
            this.KeyPanelDropDown.BackColor = System.Drawing.Color.Transparent;
            this.KeyPanelDropDown.Controls.Add(this.btn_createWithKey);
            this.KeyPanelDropDown.Controls.Add(this.lb_SecretKey);
            this.KeyPanelDropDown.Controls.Add(this.txt_Key);
            this.KeyPanelDropDown.Controls.Add(this.txt_Account);
            this.KeyPanelDropDown.Location = new System.Drawing.Point(0, 99);
            this.KeyPanelDropDown.Name = "KeyPanelDropDown";
            this.KeyPanelDropDown.Size = new System.Drawing.Size(246, 120);
            this.KeyPanelDropDown.TabIndex = 2;
            this.KeyPanelDropDown.Visible = false;
            // 
            // lb_SecretKey
            // 
            this.lb_SecretKey.AutoSize = true;
            this.lb_SecretKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_SecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SecretKey.ForeColor = System.Drawing.Color.White;
            this.lb_SecretKey.Location = new System.Drawing.Point(67, 6);
            this.lb_SecretKey.Name = "lb_SecretKey";
            this.lb_SecretKey.Size = new System.Drawing.Size(109, 25);
            this.lb_SecretKey.TabIndex = 1;
            this.lb_SecretKey.Text = "Secret Key";
            // 
            // btn_AddKey
            // 
            this.btn_AddKey.FlatAppearance.BorderSize = 0;
            this.btn_AddKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddKey.ForeColor = System.Drawing.Color.White;
            this.btn_AddKey.Location = new System.Drawing.Point(-6, 66);
            this.btn_AddKey.Name = "btn_AddKey";
            this.btn_AddKey.Size = new System.Drawing.Size(255, 27);
            this.btn_AddKey.TabIndex = 1;
            this.btn_AddKey.Text = "Add Key";
            this.btn_AddKey.UseVisualStyleBackColor = true;
            this.btn_AddKey.Click += new System.EventHandler(this.btn_AddKey_Click);
            // 
            // btn_ScanQR
            // 
            this.btn_ScanQR.FlatAppearance.BorderSize = 0;
            this.btn_ScanQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ScanQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScanQR.ForeColor = System.Drawing.Color.White;
            this.btn_ScanQR.Location = new System.Drawing.Point(-7, 33);
            this.btn_ScanQR.Name = "btn_ScanQR";
            this.btn_ScanQR.Size = new System.Drawing.Size(255, 27);
            this.btn_ScanQR.TabIndex = 0;
            this.btn_ScanQR.Text = "Scan QR";
            this.btn_ScanQR.UseVisualStyleBackColor = true;
            this.btn_ScanQR.Click += new System.EventHandler(this.btn_ScanQR_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.auth_ScrollBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(26, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 425);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AuthCodeViewer);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 420);
            this.panel2.TabIndex = 2;
            // 
            // AuthCodeViewer
            // 
            this.AuthCodeViewer.AutoScroll = true;
            this.AuthCodeViewer.Location = new System.Drawing.Point(1, 0);
            this.AuthCodeViewer.Name = "AuthCodeViewer";
            this.AuthCodeViewer.Size = new System.Drawing.Size(436, 422);
            this.AuthCodeViewer.TabIndex = 1;
            // 
            // refresh_ScrollBar
            // 
            this.refresh_ScrollBar.Enabled = true;
            this.refresh_ScrollBar.Tick += new System.EventHandler(this.refresh_ScrollBar_Tick);
            // 
            // auth_ScrollBar
            // 
            this.auth_ScrollBar._BorderColor = System.Drawing.Color.Gray;
            this.auth_ScrollBar._ClickThumb = System.Drawing.Color.DarkGray;
            this.auth_ScrollBar._LargeChange = 100;
            this.auth_ScrollBar._Maximum = 100;
            this.auth_ScrollBar._Minimum = 0;
            this.auth_ScrollBar._SmallChange = 1;
            this.auth_ScrollBar._ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.auth_ScrollBar._TrackColor = System.Drawing.Color.LightGray;
            this.auth_ScrollBar._Value = 0;
            this.auth_ScrollBar.Location = new System.Drawing.Point(410, -1);
            this.auth_ScrollBar.Name = "auth_ScrollBar";
            this.auth_ScrollBar.Size = new System.Drawing.Size(20, 422);
            this.auth_ScrollBar.TabIndex = 0;
            this.auth_ScrollBar.Scroll += new System.EventHandler(this.auth_ScrollBar_Scroll);
            // 
            // btn_createWithKey
            // 
            this.btn_createWithKey._ActivateBorderHover = false;
            this.btn_createWithKey._ActivateInnerHover = false;
            this.btn_createWithKey._ActivateTextHover = false;
            this.btn_createWithKey._BorderColor = System.Drawing.Color.Black;
            this.btn_createWithKey._BorderSize = 3;
            this.btn_createWithKey._InnerButtonColor = System.Drawing.Color.White;
            this.btn_createWithKey._OnHoverBorderColor = System.Drawing.Color.Green;
            this.btn_createWithKey._OnHoverInnerColor = System.Drawing.Color.Cyan;
            this.btn_createWithKey._OnHoverTextColor = System.Drawing.Color.Red;
            this.btn_createWithKey._TextColor = System.Drawing.Color.Black;
            this.btn_createWithKey.FlatAppearance.BorderSize = 0;
            this.btn_createWithKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createWithKey.ForeColor = System.Drawing.Color.White;
            this.btn_createWithKey.Location = new System.Drawing.Point(165, 91);
            this.btn_createWithKey.Name = "btn_createWithKey";
            this.btn_createWithKey.Size = new System.Drawing.Size(75, 23);
            this.btn_createWithKey.TabIndex = 2;
            this.btn_createWithKey.Text = "Create";
            this.btn_createWithKey.UseVisualStyleBackColor = true;
            this.btn_createWithKey.Click += new System.EventHandler(this.btn_createWithKey_Click);
            // 
            // txt_Key
            // 
            this.txt_Key._TextColorOnHover = System.Drawing.Color.IndianRed;
            this.txt_Key._TextOnHoverActivate = false;
            this.txt_Key._UnderLineOnHover = System.Drawing.Color.Brown;
            this.txt_Key._UnderLineOnHoverActivate = false;
            this.txt_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Key.ForceColor = System.Drawing.Color.Gray;
            this.txt_Key.ForeColor = System.Drawing.Color.Gray;
            this.txt_Key.Location = new System.Drawing.Point(3, 65);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.PlaceHolderText = "Key";
            this.txt_Key.Size = new System.Drawing.Size(240, 23);
            this.txt_Key.TabIndex = 0;
            this.txt_Key.Text = "Key";
            this.txt_Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Key.UnderlineColor = System.Drawing.Color.Black;
            // 
            // txt_Account
            // 
            this.txt_Account._TextColorOnHover = System.Drawing.Color.IndianRed;
            this.txt_Account._TextOnHoverActivate = false;
            this.txt_Account._UnderLineOnHover = System.Drawing.Color.Brown;
            this.txt_Account._UnderLineOnHoverActivate = false;
            this.txt_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account.ForceColor = System.Drawing.Color.Gray;
            this.txt_Account.ForeColor = System.Drawing.Color.Gray;
            this.txt_Account.Location = new System.Drawing.Point(3, 36);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.PlaceHolderText = "Account name";
            this.txt_Account.Size = new System.Drawing.Size(240, 23);
            this.txt_Account.TabIndex = 0;
            this.txt_Account.Text = "Account name";
            this.txt_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Account.UnderlineColor = System.Drawing.Color.Black;
            // 
            // moveForm1
            // 
            this.moveForm1._SelectForm = this;
            this.moveForm1.Controls.Add(this.pic_Application);
            this.moveForm1.Controls.Add(this.pic_closeApplication);
            this.moveForm1.Controls.Add(this.lb_ApplicationName);
            this.moveForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveForm1.Location = new System.Drawing.Point(0, 0);
            this.moveForm1.Name = "moveForm1";
            this.moveForm1.Size = new System.Drawing.Size(460, 30);
            this.moveForm1.TabIndex = 1;
            // 
            // pic_Application
            // 
            this.pic_Application.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Application.Image = ((System.Drawing.Image)(resources.GetObject("pic_Application.Image")));
            this.pic_Application.Location = new System.Drawing.Point(0, 0);
            this.pic_Application.Name = "pic_Application";
            this.pic_Application.Size = new System.Drawing.Size(27, 30);
            this.pic_Application.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Application.TabIndex = 2;
            this.pic_Application.TabStop = false;
            // 
            // pic_closeApplication
            // 
            this.pic_closeApplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_closeApplication.Image = global::Authenticator.Properties.Resources.Dark_CloseApplication;
            this.pic_closeApplication.Location = new System.Drawing.Point(430, 0);
            this.pic_closeApplication.Name = "pic_closeApplication";
            this.pic_closeApplication.Size = new System.Drawing.Size(30, 30);
            this.pic_closeApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_closeApplication.TabIndex = 1;
            this.pic_closeApplication.TabStop = false;
            this.pic_closeApplication.Click += new System.EventHandler(this.pic_closeApplication_Click);
            // 
            // lb_ApplicationName
            // 
            this.lb_ApplicationName.AutoSize = true;
            this.lb_ApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ApplicationName.ForeColor = System.Drawing.Color.White;
            this.lb_ApplicationName.Location = new System.Drawing.Point(33, 7);
            this.lb_ApplicationName.Name = "lb_ApplicationName";
            this.lb_ApplicationName.Size = new System.Drawing.Size(92, 17);
            this.lb_ApplicationName.TabIndex = 0;
            this.lb_ApplicationName.Text = "Authenticator";
            // 
            // MainAuthenticator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(460, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.moveForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAuthenticator";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainAuthenticator_Load);
            this.Menu.ResumeLayout(false);
            this.panel_Setting.ResumeLayout(false);
            this.panel_Theme.ResumeLayout(false);
            this.KeyPanelDropDown.ResumeLayout(false);
            this.KeyPanelDropDown.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.moveForm1.ResumeLayout(false);
            this.moveForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Application)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_closeApplication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer slideMenu;
        private Custom.MoveForm moveForm1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.PictureBox pic_closeApplication;
        private System.Windows.Forms.Label lb_ApplicationName;
        private System.Windows.Forms.Panel KeyPanelDropDown;
        private System.Windows.Forms.Button btn_AddKey;
        private System.Windows.Forms.Button btn_ScanQR;
        private System.Windows.Forms.Label lb_SecretKey;
        private SmtpSenderMail.Classes.CustomShap.TxtBox txt_Key;
        private SmtpSenderMail.Classes.CustomShap.TxtBox txt_Account;
        private SmtpSenderMail.Classes.CustomShap.RoundButton btn_createWithKey;
        private System.Windows.Forms.PictureBox pic_Application;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Panel panel_Theme;
        private System.Windows.Forms.Button btn_LightTheme;
        private System.Windows.Forms.Button btn_DarkTheme;
        private System.Windows.Forms.Button btn_Theme;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_SlideMenu;
        private System.Windows.Forms.Panel panel1;
        private Authenticator.Custom.CustomScrollBar auth_ScrollBar;
        private System.Windows.Forms.FlowLayoutPanel AuthCodeViewer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer refresh_ScrollBar;
    }
}

