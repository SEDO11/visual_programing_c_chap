using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2weeks212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnanswer_Click(object sender, EventArgs e)
        {
            labelanswer.Text = "서울";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label4.Text = "컵";
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            pbtcard.Image = Properties.Resources._16972134_playing_card_back_side_62x90_mm;
        }

        private void buttonfront_Click(object sender, EventArgs e)
        {
            pbtcard.Image = Properties.Resources._5fdb48a0e626d53a76e2dd81c28a8b860d71a226;
        }
    }
}
