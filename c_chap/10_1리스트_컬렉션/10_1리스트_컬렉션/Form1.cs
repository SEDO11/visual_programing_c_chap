using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _10_1리스트_컬렉션
{
    public partial class Form1 : Form
    {
        List<string> fruits;
        public Form1()
        {
            InitializeComponent();
            InitOfUserVar();
        }

        private void InitOfUserVar()
        {
            fruits = new List<string>();
            // 리스트 컬렉션의 예를 들기 위해 파일의 레코드를 과일명 한 단어로만 구성

            StreamReader fi = File.OpenText("fruits.txt");
            string fr;
            while(!fi.EndOfStream)
            {
                fr = fi.ReadLine();
                fruits.Add(fr);
                //MessageBox.Show(fr);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            foreach (string str in fruits)
                MessageBox.Show(str);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            fruits.RemoveAt(0); //앞에서 부터 하나씩 삭제 RemoveAt
            Display();
            //fruits.Clear():모든 과일 다 삭제
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string intb = tb.Text;
            fruits.Insert(1, intb); //1번째 자리에 추가 Insert
            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string intb = tb.Text;
            int pos = fruits.IndexOf(intb); // 지정된 개채 검색 IndexOf
            if (pos != -1)
                MessageBox.Show(intb + "는" + pos + "의 위치에 있습니다.");
        }
    }
}
