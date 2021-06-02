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
    public partial class NewUser : Form
    {
        public static NewUser newuser;
        public NewUser()
        {
            newuser = this;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUserMake_Click(object sender, EventArgs e)
        {
            UserID.IDInsert();

            /*
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다. \n다시 입력해주세요.", "오류", MessageBoxButtons.OK);
            }
            */
        }
    }
}
