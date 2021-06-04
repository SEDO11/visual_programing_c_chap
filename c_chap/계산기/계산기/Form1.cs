using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 계산기
{
    public partial class Form1 : Form
    {
        double result = 0;
        String op = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Clear();
            Button btn = (Button)sender;
            display.Text = display.Text + btn.Text;

        }

        private void op_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // (1) 처음 입력된 수 -> 수치 자료 변환
            // (2) (1)이 아닌 경우 -> 중간 연산을 수행
            // 365 + 48 = 
            result = Double.Parse(display.Text);
            op = btn.Text;

        }
    }
}
