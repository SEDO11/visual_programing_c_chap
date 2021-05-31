using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_1파일에쓰기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rnd = r.Next(4); // 0부터 2사이의 난수 값 출력

            switch(rnd)
            {
                case 0:
                    pbx.Image = Properties.Resources.사과;
                    break;
                case 1:
                    pbx.Image = Properties.Resources.수박;
                    break;
                case 2:
                    pbx.Image = Properties.Resources.포도;
                    break;
                case 3:
                    pbx.Image = Properties.Resources.바나나;
                    break;
            }
        }
    }
}
