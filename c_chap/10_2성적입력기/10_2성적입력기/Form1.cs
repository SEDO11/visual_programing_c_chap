using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2성적입력기
{
    public partial class Form1 : Form
    {
        struct Score //구조체
        {
            public string name;
            public int csharp;
            public int python;
        }
        List<Score> scoreList = new List<Score>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btn_Click(object sender, EventArgs e)
        {
            Score sc = new Score();
            getData(ref sc);

            // 리스트 scoreList에 읽은 구조체 자료 추가
            scoreList.Add(sc);

            //텍스트박스 초기화
            tbName.Clear();
            tbCsharp.Clear();
            tbPython.Clear();

            //리스트박스에 리스트 자료 출력
            lb.Items.Clear();

            foreach (Score scr in scoreList)
            {
                string record = scr.name + " " + scr.csharp + " " + scr.python;
                lb.Items.Add(record);
            }


        }
        private void getData(ref Score s)
        {
            s.name = tbName.Text;
            s.csharp = int.Parse(tbCsharp.Text);
            s.python = int.Parse(tbPython.Text);
        }
    }
}
