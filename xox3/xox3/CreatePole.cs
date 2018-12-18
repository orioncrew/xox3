using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace xox3
{
    class CreatePole
    {
        public void Create(Panel panel1, int x, int y)
        {
            int k = panel1.Width/x;
            int l = panel1.Height/y;
            Graphics gPanel = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 1);
            Pen p1 = new Pen(Color.Blue, 2);
            gPanel.Clear(Color.White);
            //рамка
            gPanel.DrawLine(p, new Point(0, 0), new Point(panel1.Width, 0));
            gPanel.DrawLine(p, new Point(panel1.Width, 0), new Point(panel1.Width, panel1.Height));
            gPanel.DrawLine(p, new Point(0, 0), new Point(0, panel1.Height));
            gPanel.DrawLine(p, new Point(0, panel1.Height), new Point(panel1.Width, panel1.Height));
            //решетка
            /*
            gPanel.DrawLine(p1, new Point(150, 0), new Point(150, 450));
            gPanel.DrawLine(p1, new Point(300, 0), new Point(300, 450));
            gPanel.DrawLine(p1, new Point(0, 150), new Point(450, 150));
            gPanel.DrawLine(p1, new Point(0, 300), new Point(450, 300));*/
            for (int i = 0; i < x; i++) //Вертикальные линии
            {
                gPanel.DrawLine(p1, new Point(panel1.Width - i * k, 0), new Point(panel1.Width - i * k, panel1.Height));
            }

            for (int i = 0; i < y; i++)//Горизонтальные линии
            {
                gPanel.DrawLine(p1, new Point(0, panel1.Height - i * l), new Point(panel1.Width, panel1.Height - i * l));
            }
        }
    }
}
