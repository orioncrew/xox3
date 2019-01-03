using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace xox3
{
    class Figure
    {
        public EnumOX value = EnumOX.space;
        public int x;
        public int y;

        public Figure(EnumOX e, int _x, int _y)
        {
            value = e;
            x = _x;
            y = _y;
        }

        public void DrawFigure(Panel panel1, int poleWidth, int poleHeight)
        {
            double k = (double)panel1.Width / (double)poleWidth;
            double l = (double)panel1.Height / (double)poleHeight;
            //отрисовка знака
            Graphics gPanel = panel1.CreateGraphics();
            
            if(value == EnumOX.X)
            {
                Pen p = new Pen(Color.Red, 10); //поработать над шириной пера
                gPanel.DrawLine(p, (int)(k * x + 5), (int)(l * y + 5), (int)(k * x + k-5), (int)(l * y + l-5));
                gPanel.DrawLine(p, (int)(k * x + k-5), (int)(l * y + 5), (int)(k * x + 5), (int)(l * y + l-5));
            }
            else
            {
                Pen p = new Pen(Color.Green, 10); //поработать над шириной пера
                gPanel.DrawEllipse(p, (int)(k * x + 10), (int)(l * y + 10), (int)(k -20), (int)(l -20));
            }          


        }
        
    }
}
