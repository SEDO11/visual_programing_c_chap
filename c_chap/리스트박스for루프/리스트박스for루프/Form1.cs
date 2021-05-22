using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리스트박스for루프
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int mul = 9;
            int result = 1;
            for(int i=1; i < 10; i++)
            {
                result = mul * i;
                lb.Items.Add(mul.ToString() + "*" + i.ToString() + "=" + result.ToString());

            }
        }
    }
}
