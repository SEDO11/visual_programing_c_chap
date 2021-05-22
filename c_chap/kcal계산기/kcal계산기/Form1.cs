using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kcal계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double d = double.Parse(lbresult.Text) + 30.4;
            lbresult.Text = d.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            double d = double.Parse(lbresult.Text) + 93;
            lbresult.Text = d.ToString();
        }

        private void pbAP_Click(object sender, EventArgs e)
        {
            double d = double.Parse(lbresult.Text) + 52.1;
            lbresult.Text = d.ToString();
        }

        private void pbGP_Click(object sender, EventArgs e)
        {
            double d = double.Parse(lbresult.Text) + 66.9;
            lbresult.Text = d.ToString();
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            lbresult.Text = "0"; //초기값으로 설정
        }
    }
}
