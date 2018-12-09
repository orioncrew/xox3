using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox3
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gPanel = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 1);
            Pen p1 = new Pen(Color.Blue, 2);
            gPanel.DrawLine(p, new Point(0, 0), new Point(450, 0));
            gPanel.DrawLine(p, new Point(450, 0), new Point(450, 450));
            gPanel.DrawLine(p, new Point(0, 0), new Point(0, 450));
            gPanel.DrawLine(p, new Point(0, 450), new Point(450, 450));
            gPanel.DrawLine(p1, new Point(150, 0), new Point(150, 450));
            gPanel.DrawLine(p1, new Point(300, 0), new Point(300, 450));
            gPanel.DrawLine(p1, new Point(0, 150), new Point(450, 150));
            gPanel.DrawLine(p1, new Point(0, 300), new Point(450, 300));
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Xox.ClickPole(sender, e);
        }
    }
}
