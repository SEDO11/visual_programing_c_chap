using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 배열
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] i = { 111, 222, 333 }; //초기값이 있는 배열
            int[] j = new int[10]; //초기값이 없는 배열
            string first = "";
            for (int k = 0; k < 10; k++)
                j[k] = k +1;
            for (int k = 0; k < 3; k++)
                first += i[k].ToString() + " ";
            for (int k = 0; k < 10; k++)
                first += j[k].ToString() + " ";
            lbl.Text = first;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
