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
            int x = (int)((double)e.Location.X / ((double)p1.Width/ (double)poleWidth));
            int y = (int)((double)e.Location.Y / ((double)p1.Width / (double)poleHeight));

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
                    ClickAI();
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
                    ClickAI();
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
            if (temp != EnumOX.space) return temp;
            temp = WorkTestWin(0, 1, chain, poleWidth, poleHeight, pole, lbTimer);
            if (temp != EnumOX.space) return temp;
            temp = WorkTestWin(1, 1, chain, poleWidth, poleHeight, pole, lbTimer);
            if (temp != EnumOX.space) return temp;
            temp = WorkTestWin(-1, 1, chain, poleWidth, poleHeight, pole, lbTimer);
            if (temp != EnumOX.space) return temp;
            return EnumOX.space;
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
            return (EnumOX.space);
        }

        ////////////////////////////

        static void ClickAI()
        {

            int[,] poleObscheta = new int[poleWidth, poleHeight];//обнуляем все ячейки расчётного поля


            // Вызов процедур определения веса групп
            WeightGroupOnPole(1, 0, poleObscheta);//Горизонтальные группы слева направо
            WeightGroupOnPole(0, 1, poleObscheta);//Вертикальные группы снизу вверх
            WeightGroupOnPole(1, 1, poleObscheta);//Диагональные группы снизу слева направо вверх
            WeightGroupOnPole(-1, 1, poleObscheta);//Диагональные обратные группы снизу справа налево вверх



            WeightCell(poleObscheta);//Определение самой тяжелой ячейки



            //if (pl1 == 1 || pl2 == 1) time = Time.time + 0.3f;
        }

        static void WeightGroupOnPole(int dx, int dy, int[,] poleObscheta) // подсчитываем веса всех групп
        {
            //Определяем веса групп
            int weight = 0, di = 0;
            bool s1, s2;
            int difficulty;
            if (Step) difficulty = difficultyX; else difficulty = difficultyO;

            if (dx == -1)
            {
                di = chain - 1;//для обратной диагонали


            }




            for (int i = di; i < poleWidth - chain * dx * dx + 1 * dx * dx + di; i++) //перебираем по координате X
            {


                for (int j = 0; j < poleHeight - chain * dy + 1 * dy; j++)//перебираем по координате Y
                {

                    //Destroy(cub[i, j]);//уничтожаем пустую ячейку на экране
                    // cub[i, j] = Instantiate(p3, new Vector3(i - x / 2, j - y / 2, 0), Quaternion.identity); //создаём фишку противника
                    //cub[i, j].name = "player_" + i + "_" + j;//Даём фишке название
                    //cub[i, j].transform.parent = transform;
                    //enable = true;//Переключаем на ход игрока
                    // Debug.Log("i=" + i + ", j=" + j);




                    s1 = false; s2 = false; int bonus = 1;
                    //перебираем ячейки группы
                    for (int k = 0; k < chain; k++)
                    {

                        //Debug.Log("i=" + (i + dx * k) + " j=" + (j + dy * k));
                        switch (poleObscheta[i + dx * k, j + dy * k])
                        {

                            case 1:
                                s1 = true;
                                weight += bonus;
                                bonus *= (difficulty * bonus);

                                break;
                            case 2:
                                s2 = true;
                                weight += bonus;
                                bonus *= (difficulty * bonus);

                                break;
                        }

                    }



                    if (s1 != s2)
                    {


                        // if (hod && s1 == true)
                        //  {
                        //      if (weight == z - 1) weight += 100;
                        // weight++;
                        //   }
                        //   if (!hod && s2 == true)
                        //  {
                        //      if (weight == z - 1) weight += 100;
                        //weight++;
                        //   };
                        //если ячейки наши, повышаем вес

                        //Запись весов в ячейки расчётов

                        //перебираем ячейки группы
                        for (int k = 0; k < chain; k++)
                        {
                            if (pole[i + dx * k, j + dy * k] == null)
                            {
                                poleObscheta[i + dx * k, j + dy * k] += weight;
                            }
                            else poleObscheta[i + dx * k, j + dy * k] = 0;

                        }

                        weight = 0;

                    }

                    weight = 0;
                }
                weight = 0;
            }
        }

        static void WeightCell(int[,] poleObscheta)
        {
            // Определяем самую тяжелую ячейку
            bool shod = false; //был ли ход
            //GameObject pg;
            int tmp;
            if (Step)
            {
                //pg = pg1;
                tmp = 1;
            }

            else
            {
                //pg = pg2;
                tmp = 2;
            }

            Random rnd = new Random();


            int weight = 0;
            int tmpx = rnd.Next(poleWidth);
            int tmpy = rnd.Next(poleHeight);


            poleObscheta[tmpx, tmpy] = 1;
            // string s = "";

            //обнуляем расчётные занятые ячейки
            for (int i = 0; i < poleWidth; i++)
            {
                for (int j = 0; j < poleHeight; j++)
                {

                    if (pole[i, j] != null) poleObscheta[i, j] = 0;//обнуляем все занятые ячейки расчётного поля


                }
            }

            //выбираем самую тяжелую
            for (int j = poleHeight - 1; j >= 0; j--)
            {
                for (int i = 0; i < poleWidth; i++)
                {
                    if (poleObscheta[i, j] > weight)
                    {
                        weight = poleObscheta[i, j];
                        tmpx = i;
                        tmpy = j;
                        shod = true;

                    }
                    // s += ("!" + pole[i, j, 1] + "!");
                }
                // Debug.Log("i=" + j + "! " +s);
                // s = "";
            }


            //  (byte)Random.Range(0.0f, x);
            //  (byte)Random.Range(0.0f, y);

            if (shod)//проверка был ли ход
            {
                pole[tmpx, tmpy] = new Figure(EnumOX.X, tmpx, tmpy); ;//заносим в массив ход
                //if (show)
                //{
                //    Destroy(cub[tmpx, tmpy]);//уничтожаем колайдер в клетке
                //    cub[tmpx, tmpy] = Instantiate(pg, new Vector3(tmpx - x / 2, tmpy - y / 2, -2), Quaternion.identity); //создаём фишку противника
                //    cub[tmpx, tmpy].name = "player_" + tmpx + "_" + tmpy;//Даём фишке название
                //    cub[tmpx, tmpy].transform.parent = transform;
                //}

                // Debug.Log("Противник " + tmpx + " " + tmpy);
            }
            else
            {
                //Debug.Log("Ходы закончились");
                //enable = false;
            }
            if (Step) Step = false; else Step = true;//Переключаем ход
                                                  //проверка на выигрыш

        }
    }
}
