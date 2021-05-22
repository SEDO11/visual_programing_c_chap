using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2week2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "")
                lbout.Text = tb1.Text;
            else
                MessageBox.Show("학번을 입력하세요. : ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
