using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            if (tbin.Text == "바나나")
            {
                lbtextout.Text = tbin.Text;
                pb1.Image = Properties.Resources.바나나;
            }

            else if(tbin.Text == "사과")
            {
                lbtextout.Text = tbin.Text;
                pb1.Image = Properties.Resources.사과;
            }

            else if (tbin.Text == "포도")
            {
                lbtextout.Text = tbin.Text;
                pb1.Image = Properties.Resources.포도;
            }

            else
            {
                lbtextout.Text = "죄송합니다. 자료가 없습니다.";
                pb1.Image = Properties.Resources.오류;
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
