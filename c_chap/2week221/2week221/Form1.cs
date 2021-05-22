using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2week221
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //정수의 최소값과 최대값 출력
            String intMin = int.MinValue.ToString("n0");
            minout.Text = intMin;

            String intMax = int.MaxValue.ToString("n0");
            maxout.Text = intMax;


        }
    }
}
