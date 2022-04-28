
namespace Authenticator
{
    partial class AuthView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showInfo = new System.Windows.Forms.Label();
            this.OTPcode = new System.Windows.Forms.Label();
            this.lb_DeleteAccount = new System.Windows.Forms.Label();
            this.RefreshOTP = new System.Windows.Forms.Timer(this.components);
            this.lb_EndLine = new System.Windows.Forms.Label();
            this.lb_Deleted_Date = new System.Windows.Forms.Label();
            this.lb_Remove = new System.Windows.Forms.Label();
            this.lb_Restore = new System.Windows.Forms.Label();
            this.RemainSecond = new Authenticator.CircleProcess.CircleProcess();
            this.SuspendLayout();
            // 
            // showInfo
            // 
            this.showInfo.AutoSize = true;
            this.showInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showInfo.Location = new System.Drawing.Point(12, 9);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(109, 20);
            this.showInfo.TabIndex = 0;
            this.showInfo.Text = "Issuer ( User )";
            // 
            // OTPcode
            // 
            this.OTPcode.AutoSize = true;
            this.OTPcode.Cursor = System.Windows.Forms.Cursors.Default;
            this.OTPcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OTPcode.Location = new System.Drawing.Point(8, 38);
            this.OTPcode.Name = "OTPcode";
            this.OTPcode.Size = new System.Drawing.Size(163, 46);
            this.OTPcode.TabIndex = 1;
            this.OTPcode.Text = "123 456";
            this.OTPcode.Click += new System.EventHandler(this.OTPcode_Click);
            // 
            // lb_DeleteAccount
            // 
            this.lb_DeleteAccount.AutoSize = true;
            this.lb_DeleteAccount.ForeColor = System.Drawing.Color.White;
            this.lb_DeleteAccount.Location = new System.Drawing.Point(307, 78);
            this.lb_DeleteAccount.Name = "lb_DeleteAccount";
            this.lb_DeleteAccount.Size = new System.Drawing.Size(81, 13);
            this.lb_DeleteAccount.TabIndex = 3;
            this.lb_DeleteAccount.Text = "Delete Account";
            this.lb_DeleteAccount.Click += new System.EventHandler(this.lb_DeleteAccount_Click);
            // 
            // RefreshOTP
            // 
            this.RefreshOTP.Enabled = true;
            this.RefreshOTP.Interval = 1000;
            this.RefreshOTP.Tick += new System.EventHandler(this.RefreshOTP_Tick);
            // 
            // lb_EndLine
            // 
            this.lb_EndLine.BackColor = System.Drawing.Color.White;
            this.lb_EndLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_EndLine.Location = new System.Drawing.Point(0, 97);
            this.lb_EndLine.Name = "lb_EndLine";
            this.lb_EndLine.Size = new System.Drawing.Size(400, 3);
            this.lb_EndLine.TabIndex = 4;
            // 
            // lb_Deleted_Date
            // 
            this.lb_Deleted_Date.AutoSize = true;
            this.lb_Deleted_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Deleted_Date.ForeColor = System.Drawing.Color.White;
            this.lb_Deleted_Date.Location = new System.Drawing.Point(261, 10);
            this.lb_Deleted_Date.Name = "lb_Deleted_Date";
            this.lb_Deleted_Date.Size = new System.Drawing.Size(131, 15);
            this.lb_Deleted_Date.TabIndex = 5;
            this.lb_Deleted_Date.Text = "Deleted at: 29/12/2022";
            // 
            // lb_Remove
            // 
            this.lb_Remove.AutoSize = true;
            this.lb_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Remove.ForeColor = System.Drawing.Color.White;
            this.lb_Remove.Location = new System.Drawing.Point(258, 33);
            this.lb_Remove.Name = "lb_Remove";
            this.lb_Remove.Size = new System.Drawing.Size(139, 15);
            this.lb_Remove.TabIndex = 5;
            this.lb_Remove.Text = "Will remove: 29/12/2022";
            // 
            // lb_Restore
            // 
            this.lb_Restore.AutoSize = true;
            this.lb_Restore.ForeColor = System.Drawing.Color.White;
            this.lb_Restore.Location = new System.Drawing.Point(228, 78);
            this.lb_Restore.Name = "lb_Restore";
            this.lb_Restore.Size = new System.Drawing.Size(44, 13);
            this.lb_Restore.TabIndex = 3;
            this.lb_Restore.Text = "Restore";
            this.lb_Restore.Click += new System.EventHandler(this.lb_Restore_Click);
            // 
            // RemainSecond
            // 
            this.RemainSecond._InnerCircle = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RemainSecond._MaximunValue = 100;
            this.RemainSecond._OutterCircle = System.Drawing.Color.Blue;
            this.RemainSecond._TextColor = System.Drawing.Color.White;
            this.RemainSecond._Value = 0;
            this.RemainSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainSecond.Location = new System.Drawing.Point(211, 38);
            this.RemainSecond.MinimumSize = new System.Drawing.Size(50, 50);
            this.RemainSecond.Name = "RemainSecond";
            this.RemainSecond.Size = new System.Drawing.Size(50, 50);
            this.RemainSecond.TabIndex = 2;
            // 
            // AuthView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.lb_Remove);
            this.Controls.Add(this.lb_Deleted_Date);
            this.Controls.Add(this.lb_EndLine);
            this.Controls.Add(this.lb_Restore);
            this.Controls.Add(this.lb_DeleteAccount);
            this.Controls.Add(this.RemainSecond);
            this.Controls.Add(this.OTPcode);
            this.Controls.Add(this.showInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthView";
            this.Load += new System.EventHandler(this.AuthView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showInfo;
        private System.Windows.Forms.Label OTPcode;
        private CircleProcess.CircleProcess RemainSecond;
        private System.Windows.Forms.Label lb_DeleteAccount;
        private System.Windows.Forms.Timer RefreshOTP;
        private System.Windows.Forms.Label lb_EndLine;
        private System.Windows.Forms.Label lb_Deleted_Date;
        private System.Windows.Forms.Label lb_Remove;
        private System.Windows.Forms.Label lb_Restore;
    }
}
