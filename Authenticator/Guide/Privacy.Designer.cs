
namespace Authenticator.Guide
{
    partial class Privacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Privacy));
            this.lb_Info = new System.Windows.Forms.Label();
            this.lk_Report = new System.Windows.Forms.LinkLabel();
            this.moveForm1 = new Authenticator.Custom.MoveForm();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Caption = new System.Windows.Forms.Label();
            this.moveForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Info
            // 
            this.lb_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info.ForeColor = System.Drawing.Color.White;
            this.lb_Info.Location = new System.Drawing.Point(0, 0);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(553, 203);
            this.lb_Info.TabIndex = 1;
            this.lb_Info.Text = resources.GetString("lb_Info.Text");
            this.lb_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lk_Report
            // 
            this.lk_Report.ActiveLinkColor = System.Drawing.Color.Red;
            this.lk_Report.AutoSize = true;
            this.lk_Report.LinkColor = System.Drawing.Color.White;
            this.lk_Report.Location = new System.Drawing.Point(8, 185);
            this.lk_Report.Name = "lk_Report";
            this.lk_Report.Size = new System.Drawing.Size(81, 13);
            this.lk_Report.TabIndex = 2;
            this.lk_Report.TabStop = true;
            this.lk_Report.Text = "Testing website";
            this.lk_Report.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_Report_LinkClicked);
            // 
            // moveForm1
            // 
            this.moveForm1._SelectForm = this;
            this.moveForm1.Controls.Add(this.pictureBox1);
            this.moveForm1.Controls.Add(this.lb_Caption);
            this.moveForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveForm1.Location = new System.Drawing.Point(0, 0);
            this.moveForm1.Name = "moveForm1";
            this.moveForm1.Size = new System.Drawing.Size(553, 30);
            this.moveForm1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Authenticator.Properties.Resources.Dark_CloseApplication;
            this.pictureBox1.Location = new System.Drawing.Point(523, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_Caption
            // 
            this.lb_Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Caption.ForeColor = System.Drawing.Color.White;
            this.lb_Caption.Location = new System.Drawing.Point(3, 6);
            this.lb_Caption.Name = "lb_Caption";
            this.lb_Caption.Size = new System.Drawing.Size(56, 20);
            this.lb_Caption.TabIndex = 0;
            this.lb_Caption.Text = "Detail\r\n";
            this.lb_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Privacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(553, 203);
            this.Controls.Add(this.lk_Report);
            this.Controls.Add(this.moveForm1);
            this.Controls.Add(this.lb_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Privacy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Privacy";
            this.moveForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.MoveForm moveForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Caption;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.LinkLabel lk_Report;
    }
}