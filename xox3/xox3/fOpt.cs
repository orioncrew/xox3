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
    public partial class fOpt : Form
    {
        public fOpt()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Xox.firstStep = false;
        }

        private void btOptClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void rbHumanX_CheckedChanged(object sender, EventArgs e)
        {
            Xox.playerX = EnumPlayerComp.PLAYER;
        }

        private void rbCompX_CheckedChanged(object sender, EventArgs e)
        {
            Xox.playerX = EnumPlayerComp.COMP;
        }

        private void rbHumanO_CheckedChanged(object sender, EventArgs e)
        {
            Xox.playerO = EnumPlayerComp.PLAYER;
        }

        private void rbCompO_CheckedChanged(object sender, EventArgs e)
        {
            Xox.playerO = EnumPlayerComp.COMP;
        }

        private void tbX_Scroll(object sender, EventArgs e)
        {
            Xox.difficultyX = tbX.Value;
        }

        private void tbO_Scroll(object sender, EventArgs e)
        {
            Xox.difficultyO = tbO.Value;
        }

        private void rbStartO_CheckedChanged(object sender, EventArgs e)
        {
            Xox.firstStep = true;
        }
    }
}
