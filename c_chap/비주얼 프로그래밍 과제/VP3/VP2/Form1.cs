using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VP2
{
    public partial class Form1 : Form
    {
        double sum_of_cal = 0.0;
        OpenFileDialog ofd;
        string filename = "오류";
        bool fst = true;
        string[] korean = { "바나나", "사과", "포도" };
        string[] english = { "banana", "apple", "grape" };
        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(File.OpenRead("과일자료.txt"));
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rd = new StreamReader(File.OpenRead(ofd.FileName));
                string[] temp = new string[2];
                string[] korean = new string[3];
                string[] eng = new string[3];
                string tbAns = tbin.Text;
                string record;
                int count = 0;
                //파일에서 한글 및 영문 단어 자료 불러오기
                while ((record = (rd.ReadLine())) != null) //읽을 레코드가 남아있다면
                {
                    temp = record.Split(' '); //스페이스를 구분자로 한 레코드를 한글과 영어로 분리
                    korean[count] = temp[0];
                    eng[count] = temp[1];
                    count++;
                }
            }
            /*
                if (tbin.Text == "바나나")
            {
                lbtextout.Text = tbin.Text;
                lbengout.Text = "banana";
                pb1.Image = Properties.Resources.바나나;
            }

            else if (tbin.Text == "사과")
            {
                lbtextout.Text = tbin.Text;
                lbengout.Text = "apple";
                pb1.Image = Properties.Resources.사과;
            }

            else if (tbin.Text == "포도")
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
            */
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
