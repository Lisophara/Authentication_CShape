
namespace Authenticator.AuthenticatorDetail
{
    partial class RestoreAuth
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
            this.panel_Restore = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh_ScrollBar = new System.Windows.Forms.Timer(this.components);
            this.restore_ScrollBar = new Authenticator.Custom.CustomScrollBar();
            this.moveForm1 = new Authenticator.Custom.MoveForm();
            this.lb_FormName = new System.Windows.Forms.Label();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.pic_Form = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.moveForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Form)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Restore
            // 
            this.panel_Restore.AutoScroll = true;
            this.panel_Restore.Location = new System.Drawing.Point(0, 3);
            this.panel_Restore.Name = "panel_Restore";
            this.panel_Restore.Size = new System.Drawing.Size(437, 321);
            this.panel_Restore.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Restore);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 324);
            this.panel1.TabIndex = 1;
            // 
            // refresh_ScrollBar
            // 
            this.refresh_ScrollBar.Enabled = true;
            this.refresh_ScrollBar.Tick += new System.EventHandler(this.refresh_ScrollBar_Tick);
            // 
            // restore_ScrollBar
            // 
            this.restore_ScrollBar._BorderColor = System.Drawing.Color.Gray;
            this.restore_ScrollBar._ClickThumb = System.Drawing.Color.DarkGray;
            this.restore_ScrollBar._LargeChange = 100;
            this.restore_ScrollBar._Maximum = 100;
            this.restore_ScrollBar._Minimum = 0;
            this.restore_ScrollBar._SmallChange = 1;
            this.restore_ScrollBar._ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restore_ScrollBar._TrackColor = System.Drawing.Color.LightGray;
            this.restore_ScrollBar._Value = 0;
            this.restore_ScrollBar.Location = new System.Drawing.Point(406, 28);
            this.restore_ScrollBar.Name = "restore_ScrollBar";
            this.restore_ScrollBar.Size = new System.Drawing.Size(20, 324);
            this.restore_ScrollBar.TabIndex = 2;
            this.restore_ScrollBar.Scroll += new System.EventHandler(this.restore_ScrollBar_Scroll);
            // 
            // moveForm1
            // 
            this.moveForm1._SelectForm = this;
            this.moveForm1.Controls.Add(this.lb_FormName);
            this.moveForm1.Controls.Add(this.pic_Close);
            this.moveForm1.Controls.Add(this.pic_Form);
            this.moveForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveForm1.Location = new System.Drawing.Point(0, 0);
            this.moveForm1.Name = "moveForm1";
            this.moveForm1.Size = new System.Drawing.Size(430, 30);
            this.moveForm1.TabIndex = 0;
            // 
            // lb_FormName
            // 
            this.lb_FormName.AutoSize = true;
            this.lb_FormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_FormName.Location = new System.Drawing.Point(36, 8);
            this.lb_FormName.Name = "lb_FormName";
            this.lb_FormName.Size = new System.Drawing.Size(92, 17);
            this.lb_FormName.TabIndex = 2;
            this.lb_FormName.Text = "Restore Data";
            // 
            // pic_Close
            // 
            this.pic_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_Close.Location = new System.Drawing.Point(400, 0);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(30, 30);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Close.TabIndex = 1;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            // 
            // pic_Form
            // 
            this.pic_Form.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Form.Location = new System.Drawing.Point(0, 0);
            this.pic_Form.Name = "pic_Form";
            this.pic_Form.Size = new System.Drawing.Size(30, 30);
            this.pic_Form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Form.TabIndex = 0;
            this.pic_Form.TabStop = false;
            // 
            // RestoreAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 357);
            this.Controls.Add(this.restore_ScrollBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moveForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestoreAuth";
            this.Text = "RestoreAuth";
            this.panel1.ResumeLayout(false);
            this.moveForm1.ResumeLayout(false);
            this.moveForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Form)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.MoveForm moveForm1;
        private System.Windows.Forms.PictureBox pic_Form;
        private System.Windows.Forms.PictureBox pic_Close;
        private System.Windows.Forms.Label lb_FormName;
        private Authenticator.Custom.CustomScrollBar restore_ScrollBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panel_Restore;
        private System.Windows.Forms.Timer refresh_ScrollBar;
    }
}