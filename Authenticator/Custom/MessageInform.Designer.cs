
namespace Authenticator.Custom
{
    partial class MessageInform
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
            this.moveForm1 = new Authenticator.Custom.MoveForm();
            this.lb_Caption = new System.Windows.Forms.Label();
            this.lb_messageInform = new System.Windows.Forms.Label();
            this.btn_Okay = new SmtpSenderMail.Classes.CustomShap.RoundButton();
            this.btn_No = new SmtpSenderMail.Classes.CustomShap.RoundButton();
            this.btn_Yes = new SmtpSenderMail.Classes.CustomShap.RoundButton();
            this.pic_MessagePicture = new System.Windows.Forms.PictureBox();
            this.pic_CloseApplication = new System.Windows.Forms.PictureBox();
            this.moveForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MessagePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CloseApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // moveForm1
            // 
            this.moveForm1._SelectForm = this;
            this.moveForm1.Controls.Add(this.pic_CloseApplication);
            this.moveForm1.Controls.Add(this.lb_Caption);
            this.moveForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveForm1.Location = new System.Drawing.Point(0, 0);
            this.moveForm1.Name = "moveForm1";
            this.moveForm1.Size = new System.Drawing.Size(400, 30);
            this.moveForm1.TabIndex = 0;
            // 
            // lb_Caption
            // 
            this.lb_Caption.AutoSize = true;
            this.lb_Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Caption.ForeColor = System.Drawing.Color.White;
            this.lb_Caption.Location = new System.Drawing.Point(12, 9);
            this.lb_Caption.Name = "lb_Caption";
            this.lb_Caption.Size = new System.Drawing.Size(58, 15);
            this.lb_Caption.TabIndex = 1;
            this.lb_Caption.Text = "Message";
            // 
            // lb_messageInform
            // 
            this.lb_messageInform.AutoSize = true;
            this.lb_messageInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_messageInform.ForeColor = System.Drawing.Color.White;
            this.lb_messageInform.Location = new System.Drawing.Point(72, 55);
            this.lb_messageInform.Name = "lb_messageInform";
            this.lb_messageInform.Size = new System.Drawing.Size(51, 20);
            this.lb_messageInform.TabIndex = 2;
            this.lb_messageInform.Text = "label1";
            // 
            // btn_Okay
            // 
            this.btn_Okay._ActivateBorderHover = false;
            this.btn_Okay._ActivateInnerHover = false;
            this.btn_Okay._ActivateTextHover = false;
            this.btn_Okay._BorderColor = System.Drawing.Color.Gray;
            this.btn_Okay._BorderSize = 3;
            this.btn_Okay._InnerButtonColor = System.Drawing.Color.White;
            this.btn_Okay._OnHoverBorderColor = System.Drawing.Color.Green;
            this.btn_Okay._OnHoverInnerColor = System.Drawing.Color.Cyan;
            this.btn_Okay._OnHoverTextColor = System.Drawing.Color.Red;
            this.btn_Okay._TextColor = System.Drawing.Color.Black;
            this.btn_Okay.FlatAppearance.BorderSize = 0;
            this.btn_Okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Okay.Location = new System.Drawing.Point(150, 130);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(100, 28);
            this.btn_Okay.TabIndex = 3;
            this.btn_Okay.Text = "Okay";
            this.btn_Okay.UseVisualStyleBackColor = true;
            this.btn_Okay.Visible = false;
            this.btn_Okay.Click += new System.EventHandler(this.btn_Okay_Click);
            // 
            // btn_No
            // 
            this.btn_No._ActivateBorderHover = false;
            this.btn_No._ActivateInnerHover = false;
            this.btn_No._ActivateTextHover = false;
            this.btn_No._BorderColor = System.Drawing.Color.Gray;
            this.btn_No._BorderSize = 3;
            this.btn_No._InnerButtonColor = System.Drawing.Color.White;
            this.btn_No._OnHoverBorderColor = System.Drawing.Color.Green;
            this.btn_No._OnHoverInnerColor = System.Drawing.Color.Cyan;
            this.btn_No._OnHoverTextColor = System.Drawing.Color.Red;
            this.btn_No._TextColor = System.Drawing.Color.Black;
            this.btn_No.FlatAppearance.BorderSize = 0;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Location = new System.Drawing.Point(205, 164);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(100, 28);
            this.btn_No.TabIndex = 3;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Visible = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes._ActivateBorderHover = false;
            this.btn_Yes._ActivateInnerHover = false;
            this.btn_Yes._ActivateTextHover = false;
            this.btn_Yes._BorderColor = System.Drawing.Color.Gray;
            this.btn_Yes._BorderSize = 3;
            this.btn_Yes._InnerButtonColor = System.Drawing.Color.White;
            this.btn_Yes._OnHoverBorderColor = System.Drawing.Color.Green;
            this.btn_Yes._OnHoverInnerColor = System.Drawing.Color.Cyan;
            this.btn_Yes._OnHoverTextColor = System.Drawing.Color.Red;
            this.btn_Yes._TextColor = System.Drawing.Color.Black;
            this.btn_Yes.FlatAppearance.BorderSize = 0;
            this.btn_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yes.Location = new System.Drawing.Point(99, 164);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(100, 28);
            this.btn_Yes.TabIndex = 3;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Visible = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // pic_MessagePicture
            // 
            this.pic_MessagePicture.Location = new System.Drawing.Point(15, 36);
            this.pic_MessagePicture.Name = "pic_MessagePicture";
            this.pic_MessagePicture.Size = new System.Drawing.Size(51, 51);
            this.pic_MessagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_MessagePicture.TabIndex = 1;
            this.pic_MessagePicture.TabStop = false;
            // 
            // pic_CloseApplication
            // 
            this.pic_CloseApplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_CloseApplication.Image = global::Authenticator.Properties.Resources.Dark_CloseApplication;
            this.pic_CloseApplication.Location = new System.Drawing.Point(367, 0);
            this.pic_CloseApplication.Name = "pic_CloseApplication";
            this.pic_CloseApplication.Size = new System.Drawing.Size(33, 30);
            this.pic_CloseApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_CloseApplication.TabIndex = 2;
            this.pic_CloseApplication.TabStop = false;
            this.pic_CloseApplication.Click += new System.EventHandler(this.pic_CloseApplication_Click);
            // 
            // MessageInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(400, 194);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.lb_messageInform);
            this.Controls.Add(this.pic_MessagePicture);
            this.Controls.Add(this.moveForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageInform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageInform";
            this.moveForm1.ResumeLayout(false);
            this.moveForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MessagePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CloseApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MoveForm moveForm1;
        private System.Windows.Forms.Label lb_Caption;
        private System.Windows.Forms.PictureBox pic_MessagePicture;
        private System.Windows.Forms.Label lb_messageInform;
        private SmtpSenderMail.Classes.CustomShap.RoundButton btn_Okay;
        private SmtpSenderMail.Classes.CustomShap.RoundButton btn_No;
        private SmtpSenderMail.Classes.CustomShap.RoundButton btn_Yes;
        private System.Windows.Forms.PictureBox pic_CloseApplication;
    }
}