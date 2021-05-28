using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruitsBox
{
    public partial class Form1 : Form
    {
        List<Fruits> frList = new List<Fruits>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Fruits myFruit = new Fruits();
            GetFruitsData(myFruit);
            //리스트 자료구조에 Frutis 객체 추가
            frList.Add(myFruit);
            //리스트박스에 항목 추가(과일명)
            lbFruits.Items.Add(myFruit.name);
            //텍스트박스 초기화
            tbFruits.Clear();
            tbPrice.Clear();
            //포커스 이동
            tbFruits.Focus();
            
        }
        private void GetFruitsData(Fruits fr)
        {
            fr.name = tbFruits.Text;
            fr.price = int.Parse(tbPrice.Text);
        }

        private void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbFruits.SelectedIndex;
            //리스트 박스의 색인으로 리스트 자료를 검색하여 가격 정보를 들고 옴
            MessageBox.Show(frList[index].price.ToString());
        }
    }
}
