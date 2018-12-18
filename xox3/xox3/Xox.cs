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
        static public int poleWidth = 9; //Ширина игрового поля
        static public int poleHeight = 9; //Длина игрового поля
        static public Figure[,] pole = new Figure[poleWidth, poleHeight];
        static public EnumPlayerComp playerX = EnumPlayerComp.PLAYER;
        static public EnumPlayerComp playerO = EnumPlayerComp.PLAYER;
        static public int difficultyX = 5;
        static public int difficultyO = 5;
        static public bool firstStep = true;
        static public bool Step;
        static public CreatePole gamePole = new CreatePole();

        static public void ClickPole(object sender, MouseEventArgs e)
        {
            // Определяем координаты щелчка игрока
            Panel p1 = (Panel)sender;
            int x = e.Location.X / (p1.Width/ poleWidth);
            int y = e.Location.Y / (p1.Width / poleHeight);

            // Рисуем фигуру по координатам x и y
            if (pole[x, y] == null)
            {
                if (playerX == EnumPlayerComp.PLAYER && Step == false)
                {
                    pole[x, y] = new Figure(EnumOX.X, x, y);
                    pole[x, y].DrawFigure((Panel)sender, poleWidth, poleHeight);
                    Step = !Step;
                }
                else if(playerO == EnumPlayerComp.PLAYER && Step == true)
                {
                    pole[x, y] = new Figure(EnumOX.O, x, y);
                    pole[x, y].DrawFigure((Panel)sender, poleWidth, poleHeight);
                    Step = !Step;
                }
            }
        }

        static public void Restart(Panel panel1)
        {
            gamePole = new CreatePole();   //очистка игрового поля
            gamePole.Create(panel1, poleWidth, poleHeight); //перерисовка игрового поля

            Array.Clear(pole, 0, pole.Length); //очистка игрового массива
            firstStep = !firstStep;
            Step = firstStep;
            

        }

        //Цикл игры
        static public void CircleGame()
        {
            while (true)
            {

            }
        }
    }
}
