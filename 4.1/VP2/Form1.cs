using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP2
{
    public partial class Form1 : Form
    {
        double sum_of_cal = 0.0;
        List<string> fruits = new List<string> { "바나나", "사과", "포도", "수박", "에러" };
        List<string> englishFruits = new List<string> { "banana", "apple", "grape", "watermelon", "error" };

        public Form1()
        {
            InitializeComponent();

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            if (tbin.Text == fruits[0])
            {
                lbtextout.Text = tbin.Text;
                lbengout.Text = englishFruits[0];
                pb1.Image = Properties.Resources.바나나;
            }

            else if (tbin.Text == fruits[1])
            {
                lbtextout.Text = tbin.Text;
                lbengout.Text = "apple";
                pb1.Image = Properties.Resources.사과;
            }

            else if (tbin.Text == fruits[2])
            {
                lbtextout.Text = tbin.Text;
                lbengout.Text = "grape";
                pb1.Image = Properties.Resources.포도;
            }

            else
            {
                lbtextout.Text = "죄송합니다. 자료가 없습니다.";
                lbengout.Text = "error";
                pb1.Image = Properties.Resources.오류;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void barbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            if(apcheckbox.Checked)
                sum_of_cal = sum_of_cal + 52.1;
            lb_cal.Text = sum_of_cal.ToString();

            if (bacheckbox.Checked)
                sum_of_cal = sum_of_cal + 79;
            lb_cal.Text = sum_of_cal.ToString();

            if (gacheckbox.Checked)
                sum_of_cal = sum_of_cal + 66.9;
            lb_cal.Text = sum_of_cal.ToString();




        }

        private void gacheckbox_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
