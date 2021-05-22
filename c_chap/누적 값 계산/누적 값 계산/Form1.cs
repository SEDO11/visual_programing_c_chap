using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 누적_값_계산
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_col_Click(object sender, EventArgs e)
        {
            int start = int.Parse(tbstart.Text);
            int end = int.Parse(tbend.Text);
            int cursor = start;
            int sum = 0;
            //만일 시작값이 종료값보다 클 경우 교환하는 두 로직 추가필요
            while(cursor != end)
            {
                sum += cursor;
                cursor++;
            }
            lb_out.Text = sum.ToString();
        }
    }
}
