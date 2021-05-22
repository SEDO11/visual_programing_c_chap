using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 배열_리스트
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            string strFirst = tbFirst.Text;
            string strSecond = tbSecond.Text;
            //자료 교환전 우선 인쇄
            lblBefore.Text = strFirst + ". " + strSecond;
            //자료 교환 메소드 호출
            Swap(strFirst, strSecond);
            //교환 메소드 호출 후 교환 검증
            lblOut.Text = strFirst + ". " + strSecond;
        }

        //두 자료의 교환 메소드
        void Swap(ref string s1,ref string s2)
        {
            //두 자료를 맞바꾸기 위해 temp라는 임시변수 도입
            string temp = s1;
            s1 = s2;
            s2 = temp;
            //교환 메소드 내의 교환 검증
            lblAfter.Text = s1 + ". " + s2;
        }
    }
}
