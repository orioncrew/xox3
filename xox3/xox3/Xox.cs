using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace xox3
{
    static class Xox
    {
        static public Figure[,] pole = new Figure[3, 3];
        static public EnumPlayerComp playerX = EnumPlayerComp.PLAYER;
        static public EnumPlayerComp playerO = EnumPlayerComp.PLAYER;
        static public int difficultyX = 5;
        static public int difficultyO = 5;
        static public bool firstStep = true;
        static public bool Step;

        static public void ClickPole(object sender, MouseEventArgs e)
        {
            // Определяем координаты щелчка игрока
            int x = e.Location.X / 150;
            int y = e.Location.Y / 150;

            // Рисуем фигуру по координатам x и y
            if (pole[x, y] == null)
            {
                if (playerX == EnumPlayerComp.PLAYER && Step == false)
                {
                    pole[x, y] = new Figure(EnumOX.X, x, y);
                    pole[x, y].DrawFigure((Panel)sender);
                    Step = !Step;
                }
                else if(playerO == EnumPlayerComp.PLAYER && Step == true)
                {
                    pole[x, y] = new Figure(EnumOX.O, x, y);
                    pole[x, y].DrawFigure((Panel)sender);
                    Step = !Step;
                }
            }
        }

        static public void Restart(Panel panel1)
        {
            Graphics gPanel = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 1);
            Pen p1 = new Pen(Color.Blue, 2);
            gPanel.Clear(Color.White);
            gPanel.DrawLine(p, new Point(0, 0), new Point(450, 0));
            gPanel.DrawLine(p, new Point(450, 0), new Point(450, 450));
            gPanel.DrawLine(p, new Point(0, 0), new Point(0, 450));
            gPanel.DrawLine(p, new Point(0, 450), new Point(450, 450));
            gPanel.DrawLine(p1, new Point(150, 0), new Point(150, 450));
            gPanel.DrawLine(p1, new Point(300, 0), new Point(300, 450));
            gPanel.DrawLine(p1, new Point(0, 150), new Point(450, 150));
            gPanel.DrawLine(p1, new Point(0, 300), new Point(450, 300));

            Array.Clear(pole, 0, 9);
            firstStep = !firstStep;
            Step = firstStep;
            
        }
    }
}
