using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2이름_나이입력
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

        private void btn_Click(object sender, EventArgs e)
        {
            People p = new People();
            //People 전용필드에 이름과 나이 입력
            p.setName(tbName.Text);
            p.setAge(int.Parse(tbAge.Text));
            string name = p.getName();
            int age = p.getAge();
            MessageBox.Show("이름은 " + name + "이고 나이는 " + age + "살 입니다.");
        }
    }
}
