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
        static public int[,] pole = new int[3, 3];
        static public EnumPlayerComp playerX = EnumPlayerComp.PLAYER;
        static public EnumPlayerComp playerO = EnumPlayerComp.COMP;
        static public int difficultyX = 5;
        static public int difficultyO = 5;
        static public bool firstStep = false;

        static public void ClickPole(object sender, MouseEventArgs e)
        {

        }
    }
}
