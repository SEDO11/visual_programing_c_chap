using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41라디오버튼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsb_CheckedChanged(object sender, EventArgs e)
        { 

        }

        private void btn_Click(object sender, EventArgs e)
        {

        //과일 선택 출력
        String selectFruit = "";
        if (btnsb.Checked)
            selectFruit = "딸기";
        else if (btnba.Checked)
            selectFruit = "바나나";
        else if (btnap.Checked)
            selectFruit = "사과";

            //견과류 선택 출력
            String selectNuts = "";
            if (btnpn.Checked)
                selectNuts = "땅콩";
            else if (btnwn.Checked)
                selectNuts = "호두";
            else if (btnam.Checked)
                selectNuts = "아몬드";

            MessageBox.Show(selectFruit + ", " + selectNuts, "선택결과");
            


        }
    }
}
