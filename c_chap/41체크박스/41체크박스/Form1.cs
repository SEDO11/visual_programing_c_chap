using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41체크박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            String Fruits = "";
            if (cbsb.Checked)
                if(Fruits != "")
                Fruits += "딸기";
            else
                Fruits = "딸기";

            if (cbbanana.Checked)
                if (Fruits != "")
                    Fruits += ", 바나나";
                else
                    Fruits = "바나나";

            if (cbapple.Checked)
                if (Fruits != "")
                    Fruits += ", 사과";
                else
                    Fruits = "사과";

            lbresult.Text = Fruits;


        }
    }
}
