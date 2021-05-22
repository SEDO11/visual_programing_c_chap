using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2week222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //float
            float f = 0.12345678f;
            string fs = f.ToString();
            lbflo.Text = fs;

            //double
            double d = 0.123456789123456789d;
            string ds = d.ToString();
            lbdou.Text = ds;


        }
    }
}
