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
    public partial class fMain : Form
    {
        fOpt fO = new fOpt();
        public fGame fG = new fGame();

        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            fO.ShowDialog();
            this.Show();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            fG.ShowDialog();
            this.Show();
        }
    }
}
