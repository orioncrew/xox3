using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox3
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Xox.Restart((Panel)sender);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Xox.ClickPole(sender, e);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Xox.Restart(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbTimer.Text = Xox.timertic.ToString();
            //Xox.timertic++;
            //Xox.CompHod(panel1);


            EnumOX testWin = (Xox.TestWin(lbTimer));
            if (testWin == EnumOX.X)
            {
                //Победил игрок Х
            }
            else if (testWin == EnumOX.O)
            {
                //Победил игрок О
            }
            else if (testWin == EnumOX.noOne)
            {
                //Ничья
            }
        }

        public void lbTime(string e)
        {
            lbTimer.Text = e;
        }
    }
}
