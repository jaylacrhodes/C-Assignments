using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHeads_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Heads1;
        }

        private void btnTails_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Tails1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources._50cents;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources._50cents;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RandomNum = rnd.Next(1, 3);
            if (RandomNum == 1) {

                picCoins.Image=Properties.Resources.Heads1;
            }
            else
            {
                picCoins.Image = Properties.Resources.Tails1;
            }
        }
    }
}
