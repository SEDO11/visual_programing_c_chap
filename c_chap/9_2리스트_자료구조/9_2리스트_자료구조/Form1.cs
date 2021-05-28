using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_2리스트_자료구조 
{
    public partial class Form1 : Form
    {
        //리스트 변수 선언 및 초기화
        List<int> number = new List<int>(); // 리스트 만들기
        List<int> inumber = new List<int>() { 1, 2, 3, 4, 5 }; //리스트를 만들고 초기값 설정
        List<string> fruits = new List<string> { "딸기", "바나나", "사과", }; 
        public Form1()
        {
            InitializeComponent();
            //리스트에 아이템 추가
            number.Add(10);
            number.Add(20);
            number.Add(30);        
            for(int i = 0; i <3; i++)
            {
                /*
                if(lbl.Text != "")
                {
                    lbl.Text += number[0].ToString();
                }
                */
                for(i=0; i<3; i++)
                {
                    lbl.Text += number[i].ToString() + ' ';
                }
                for (i=0; i < inumber.Count; i++)
                    lbl.Text += inumber[i].ToString() + ' ';
                for (i=0; i < fruits.Count; i++)
                    lbl.Text += fruits[i] + ' ';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
