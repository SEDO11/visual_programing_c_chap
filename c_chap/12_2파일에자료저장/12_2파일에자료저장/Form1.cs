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

namespace _12_2파일에자료저장
{
    public partial class Form1 : Form
    {
        string cont = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student = "";
            student = tbNum.Text + " " + tbName.Text + " " + tbGender.Text;
            lb.Items.Add(student);
            // 입력 자료 누적
            cont += student + "\n";

        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 자료 저장 파일을 선택하는 대화상자 준비
            SaveFileDialog sfd = new SaveFileDialog();
            StreamWriter sw;
            // 열기 대화상자에서 저장할 파일 선택 또는 생성
            if (sfd.ShowDialog() == DialogResult.OK) ;
            {
                sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(cont);
                sw.Close();
            }
        }
    }
}
