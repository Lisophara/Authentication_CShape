
namespace Authenticator
{
    partial class ScanQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanQR));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_ScanArea = new System.Windows.Forms.Panel();
            this.moveForm1 = new Authenticator.Custom.MoveForm();
            this.btn_Scan = new SmtpSenderMail.Classes.CustomShap.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moveForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Left.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 30);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(5, 390);
            this.panel_Left.TabIndex = 1;
            this.panel_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Left_MouseDown);
            this.panel_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Left_MouseMove);
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(538, 30);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(5, 390);
            this.panel_Right.TabIndex = 1;
            this.panel_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(5, 415);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(533, 5);
            this.panel_bottom.TabIndex = 1;
            this.panel_bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_bottom_MouseDown);
            this.panel_bottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_bottom_MouseMove);
            // 
            // panel_ScanArea
            // 
            this.panel_ScanArea.BackColor = System.Drawing.Color.Transparent;
            this.panel_ScanArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ScanArea.Location = new System.Drawing.Point(5, 30);
            this.panel_ScanArea.Name = "panel_ScanArea";
            this.panel_ScanArea.Size = new System.Drawing.Size(533, 385);
            this.panel_ScanArea.TabIndex = 2;
            // 
            // moveForm1
            // 
            this.moveForm1._SelectForm = this;
            this.moveForm1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.moveForm1.Controls.Add(this.btn_Scan);
            this.moveForm1.Controls.Add(this.label1);
            this.moveForm1.Controls.Add(this.pictureBox1);
            this.moveForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveForm1.Location = new System.Drawing.Point(0, 0);
            this.moveForm1.Name = "moveForm1";
            this.moveForm1.Size = new System.Drawing.Size(543, 30);
            this.moveForm1.TabIndex = 0;
            // 
            // btn_Scan
            // 
            this.btn_Scan._ActivateBorderHover = false;
            this.btn_Scan._ActivateInnerHover = false;
            this.btn_Scan._ActivateTextHover = false;
            this.btn_Scan._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_Scan._BorderSize = 3;
            this.btn_Scan._InnerButtonColor = System.Drawing.Color.White;
            this.btn_Scan._OnHoverBorderColor = System.Drawing.Color.Red;
            this.btn_Scan._OnHoverInnerColor = System.Drawing.Color.Cyan;
            this.btn_Scan._OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Scan._TextColor = System.Drawing.Color.Black;
            this.btn_Scan.BackColor = System.Drawing.Color.Transparent;
            this.btn_Scan.FlatAppearance.BorderSize = 0;
            this.btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scan.Location = new System.Drawing.Point(95, 3);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(75, 23);
            this.btn_Scan.TabIndex = 2;
            this.btn_Scan.Text = "Scan";
            this.btn_Scan.UseVisualStyleBackColor = false;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR Scanner";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Authenticator.Properties.Resources.Dark_CloseApplication;
            this.pictureBox1.Location = new System.Drawing.Point(513, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ScanQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(543, 420);
            this.Controls.Add(this.panel_ScanArea);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.moveForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(255, 212);
            this.Name = "ScanQR";
            this.Opacity = 0.8D;
            this.Text = "ScanQR";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.moveForm1.ResumeLayout(false);
            this.moveForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.MoveForm moveForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_ScanArea;
        private System.Windows.Forms.Label label1;
        private SmtpSenderMail.Classes.CustomShap.RoundButton btn_Scan;
    }
}