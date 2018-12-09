using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox3
{
    static class Xox
    {
        //static public int[,] pole = new int[3, 3];
        static public Figure[,] pole = new Figure[3, 3];
        static public EnumPlayerComp playerX = EnumPlayerComp.PLAYER;
        static public EnumPlayerComp playerO = EnumPlayerComp.PLAYER;
        static public int difficultyX = 5;
        static public int difficultyO = 5;
        static public bool firstStep = false;

        static public void ClickPole(object sender, MouseEventArgs e)
        {
            // Определяем координаты щелчка
            int x = e.Location.X / 150+1;
            int y = e.Location.Y / 150+1;

            if (playerX == EnumPlayerComp.PLAYER && firstStep == false && pole[x,y].value == EnumOX.space)
            {
                // Рисуем крест по координатам x и y
                pole[x, y].value = EnumOX.X;
                pole[x, y].DrawFigure();
            }
        }
    }
}
