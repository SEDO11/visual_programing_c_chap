using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 조건문
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int score = int.Parse(tbin.Text);
            if (score >= 90) 
                lbresult.Text = "A";

            else if (score >= 80)
                lbresult.Text = "B";

            else if (score >= 70)
                lbresult.Text = "C";

            else if (score >= 60)
                lbresult.Text = "D";

            else
                lbresult.Text = "F";

        }
    }
}
