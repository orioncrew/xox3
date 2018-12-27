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
        static public int timertic = 0;
        static public int poleWidth = 9; //Ширина игрового поля
        static public int poleHeight = 9; //Длина игрового поля
        static public int chain = 5; //Длина цепочки в ряд
        static public Figure[,] pole = new Figure[poleWidth, poleHeight];
        static public EnumPlayerComp playerX = EnumPlayerComp.PLAYER;
        static public EnumPlayerComp playerO = EnumPlayerComp.PLAYER;
        static public int difficultyX = 5;
        static public int difficultyO = 5;
        static public bool firstStep = true;
        static public bool Step;
        static public CreatePole gamePole = new CreatePole();
       // static public CompPlayercs compPlayer = new CompPlayercs();


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



        //Цикл игры
        static public void CompHod(Panel panel1)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            int value = rnd.Next(10);

            if (playerX == EnumPlayerComp.COMP && Step == false)
            {
                if (value < difficultyX)

                {
                    bool flag = true;

                    while (flag)
                    {
                        int x = rnd.Next(poleWidth);
                        int y = rnd.Next(poleHeight);

                        if (pole[x, y] == null)
                        {
                            pole[x, y] = new Figure(EnumOX.X, x, y);
                            pole[x, y].DrawFigure(panel1, poleWidth, poleHeight);
                            flag = false;
                        }
                    }

                    Step = !Step;

                }
                else
                {
                    //просчёт хода
                }
            }
            if (playerO == EnumPlayerComp.COMP && Step == true)
            {
                if (value < difficultyO)

                {
                    bool flag = true;

                    while (flag)
                    {
                        int x = rnd.Next(poleWidth);
                        int y = rnd.Next(poleHeight);

                        if (pole[x, y] == null)
                        {
                            pole[x, y] = new Figure(EnumOX.O, x, y);
                            pole[x, y].DrawFigure(panel1, poleWidth, poleHeight);
                            flag = false;
                        }
                    }

                    Step = !Step;

                }
                else
                {
                    // Просчёт хода
                }
            }
        }

        static public void Restart(Panel panel1)
        {
            gamePole = new CreatePole();   //очистка игрового поля
            gamePole.Create(panel1, poleWidth, poleHeight); //перерисовка игрового поля

            Array.Clear(pole, 0, pole.Length); //очистка игрового массива
            //firstStep = !firstStep;
            Step = firstStep;


        }

        static public EnumOX TestWin(Label lbTimer)
        {
            EnumOX temp;
            temp = WorkTestWin(1, 0, chain, poleWidth, poleHeight, pole, lbTimer);
            if (temp != EnumOX.noOne) return temp;
            temp = WorkTestWin(0, 1, chain, poleWidth, poleHeight, pole, lbTimer);
            if (temp != EnumOX.noOne) return temp;
            temp = WorkTestWin(1, 1, chain, poleWidth, poleHeight, pole, lbTimer);
            if (temp != EnumOX.noOne) return temp;
            temp = WorkTestWin(-1, 1, chain, poleWidth, poleHeight, pole, lbTimer);
            if (temp != EnumOX.noOne) return temp;
            return EnumOX.noOne;
        }

        //Проверка на выигрыш
        static public EnumOX WorkTestWin(int dx, int dy, int chain, int poleWidth, int poleHeight, Figure[,] pole, Label lbTimer)//проверка на выигрыш
        {
            int x = poleWidth; //Ширина игрового поля
            int y = poleHeight;//Высота игрового поля
            int z = chain;//длина цепочки
            int weight = 0, di = 0;
            bool s1, s2;

            if (dx == -1)
            {
                di = z - 1;//для обратной диагонали


            }
            for (int i = di; i < x - z * dx * dx + 1 * dx * dx + di; i++) //перебираем по координате X
            {


                for (int j = 0; j < y - z * dy + 1 * dy; j++)//перебираем по координате Y
                {
                    s1 = false; s2 = false; weight = 0;
                    for (int k = 0; k < z; k++)
                    {
                        Figure temp = pole[i + dx * k, j + dy * k];
                        if (temp != null)
                            if (temp.value == EnumOX.X)
                            {
                                s1 = true;
                                weight++;

                            }
                            else if (temp.value == EnumOX.O)
                            {
                                s2 = true;
                                weight++;

                            }



                    }

                    if (s1 != s2 && weight == z)
                    {
                        //рисуем победную линию
                        //Instantiate(win, new Vector3(i + dx * k - x / 2, j + dy * k - y / 2, -1), Quaternion.identity);
                        
                        if (s1)
                        {
                            
                            return EnumOX.X;
                        }
                        else
                        {
                            
                            return EnumOX.O;
                        }
                    }


                }
            }
            return (EnumOX.noOne);
        }
    }
}
