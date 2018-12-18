using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox3
{
    class CompPlayercs
    {
        //Обработка хода компьютера
        public void Hod(Figure[,] pole, bool Step, int difficulty, Panel sender, int poleWidth, int poleHeight)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            int value = rnd.Next(10);

            if (Step)
            {
                if (value < difficulty)

                {
                    bool flag = true;

                    while (flag)
                    {
                        int x = rnd.Next(poleWidth);
                        int y = rnd.Next(poleHeight);

                        if (pole[x, y] == null)
                        {
                            pole[x, y] = new Figure(EnumOX.O, x, y);
                            pole[x, y].DrawFigure((Panel)sender, poleWidth, poleHeight);
                            flag = false;
                        }
                    }



                }
            }
            else
            {

            }




        }
    }
}
