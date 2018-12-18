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
            int k = panel1.Width / poleWidth;
            int l = panel1.Height / poleHeight;
            //отрисовка знака
            Graphics gPanel = panel1.CreateGraphics();
            
            if(value == EnumOX.X)
            {
                Pen p = new Pen(Color.Red, 10); //поработать над шириной пера
                gPanel.DrawLine(p, k * x + 5, l * y + 5, k * x + k-5, l * y + l-5);
                gPanel.DrawLine(p, k * x + l-5, l * y + 5, k * x + 5, l * y + l-5);
            }
            else
            {
                Pen p = new Pen(Color.Green, 10); //поработать над шириной пера
                gPanel.DrawEllipse(p, k * x + 10, l * y + 10, k-20, l-20);
            }          


        }
        
    }
}
