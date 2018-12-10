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

        public void DrawFigure(Panel panel1)
        {
            //отрисовка знака
            Graphics gPanel = panel1.CreateGraphics();
            
            if(value == EnumOX.X)
            {
                Pen p = new Pen(Color.Red, 10);
                gPanel.DrawLine(p, 150 * x + 2, 150 * y + 2, 150 * x + 148, 150 * y + 148);
                gPanel.DrawLine(p, 150 * x + 148, 150 * y + 2, 150 * x + 2, 150 * y + 148);
            }
            else
            {
                Pen p = new Pen(Color.Green, 10);
                gPanel.DrawEllipse(p, 150 * x + 10, 150 * y + 10, 130, 130);
            }          


        }
        
    }
}
