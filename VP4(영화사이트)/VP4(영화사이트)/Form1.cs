using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP4_영화사이트_
{
    public partial class Form1 : Form
    {
        //기본 아이디, 비밀번호
        string id = "dhtpgns"; 
        string pw = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (tbId.Text == id && tbPw.Text == pw)
            {
                MessageBox.Show("확인되었습니다.", "확인", MessageBoxButtons.OK);
                영화소개 anfrm = new 영화소개();
                anfrm.ShowDialog();
            }

            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다. \n다시 입력해주세요.", "오류", MessageBoxButtons.OK);
            }

        }

    }
}
