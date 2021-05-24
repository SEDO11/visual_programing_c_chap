using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_1사용자클래스
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int start = int.Parse(tbS.Text);
            int end = int.Parse(tbE.Text);
            UserAcc ua = new UserAcc(start, end);
            int result = ua.Accumulate();
            lblSum.Text = result.ToString(); 
        }
    }
}
