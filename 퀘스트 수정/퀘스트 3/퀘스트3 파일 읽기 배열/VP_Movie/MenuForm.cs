using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Movie
{
    public partial class MenuForm : Form
    {
        public string username { get; set; }

        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnUserSelct_Click(object sender, EventArgs e)//버튼을 누를시 로그인 했던 아이디를 환영한다는 문구 출력
        {
            lblUser.Text = "환영합니다 " + username + " 님";
        }

        private void btnRv_Click(object sender, EventArgs e)
        {
            MovieForm msfrm = new MovieForm();
            msfrm.ShowDialog();
        }
    }
}
