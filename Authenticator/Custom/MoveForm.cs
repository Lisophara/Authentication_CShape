using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authenticator.Custom
{
    public partial class MoveForm : Panel
    {
        int coordinateX = 0,coordinateY = 0;
        Form frm = null;
        public MoveForm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            coordinateX = e.X;
            coordinateY = e.Y;
        }

        private void MoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left) { return; }
            int x = frm.Location.X - (coordinateX - e.X);
            int y = frm.Location.Y - (coordinateY - e.Y);
            frm.Location = new Point(x, y);
        }

        public Form _SelectForm
        {
            get { return frm; }
            set { frm = value;
                Invalidate();
            }
        }

    }
}
