using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_1프로퍼티
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            /*
            //프로퍼티
            //////////////////////////////////////////////////////////////////////////////////
            People p = new People();
            //p.setName(tbName.Text);
            p.Name = tbName.Text;
            // p.setAge(int.Parse(tbAge.Text));
            p.Age = int.Parse(tbAge.Text);
            // MessageBox.Show(p.getName() + p.getAge());
            MessageBox.Show("이름은 " + p.Name + "이고 나이는 " + p.Age + "살 입니다.");
            ////////////////////////////////////////////////////////////////////////////////
            */
            People p = new People();
            p.name = tbName.Text;
            p.age = int.Parse(tbAge.Text);
            MessageBox.Show("이름은 " + p.name + "이고 나이는 " + p.age + "살 입니다.");
        }
    }
}
