using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3week_C_F
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

        private void btn_Click(object sender, EventArgs e)
        {
            float i = float.Parse(tb.Text);

            double fah = i * 1.8 + 32;
            lbCtoF.Text = "섭씨" + tb.Text + "도는 화씨" + fah.ToString() + "도입니다.";
            

            double cel = (i - 32) / 1.8;
            lbFtoC.Text = "화씨" + tb.Text + "도는 섭씨" + cel.ToString() + "도입니다.";
            
        }
    }
}
