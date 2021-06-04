using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGV로그인화면
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbId.Text == id && tbPw.Text == pw)
            {
                MessageBox.Show("확인되었습니다.", "확인", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다. \n다시 입력해주세요.", "오류", MessageBoxButtons.OK);
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewUser nufrm = new NewUser();
            nufrm.ShowDialog();
        }
    }
}
