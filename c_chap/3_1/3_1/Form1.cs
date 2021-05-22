using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //텍스트박스의 정수 문자열과 실수 문자열을 각각의 정수와 실수로 변환
            int i = int.Parse(tbint.Text);
            float f = float.Parse(tbfloat.Text);

            //정수와 실수로 읽은 자료 처리 생략
            //처리된 정수와 실수를 각각의 라벨이 출력
            label4.Text = i.ToString();
            label3.Text = f.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
