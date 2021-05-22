using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리스트박스2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fruits 문자열 변수에 리스트박스에서 선택한 아이템을 문자열로 변환하여 넣어줌
            string fruits = lb.SelectedItem.ToString();
            switch(fruits)
            {
                case "사과":
                    lb_out.Text = "10,000";
                    break;

                case "딸기":
                    lb_out.Text = "4,000";
                    break;

                case "바나나":
                    lb_out.Text = "6,000";
                    break;

                case "포도":
                    lb_out.Text = "8,000";
                    break;

            }
        }

    }
}
