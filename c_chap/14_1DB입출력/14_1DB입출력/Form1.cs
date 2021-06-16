using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_1DB입출력
{
    public partial class Form1 : Form
    {
        StdInfo si = new StdInfo();
        public Form1()
        {
            InitializeComponent();
            si.InitializeDB();
        }

        private void DBLoad()
        {
            //DB 자료를 리스트뷰에 수록하기
            List<StdInfo> std = si.GetInfo();
            lv.Items.Clear();
            foreach(StdInfo s in std)
            {
                ListViewItem item = new ListViewItem(new string[] {s.No.ToString(), s.Name, s.Gender, s.HP}); //익명의 개체로 생성자 호출
                item.Tag = s;
                lv.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DBLoad();
        }
    }
}
