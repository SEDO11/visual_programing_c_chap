using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //파일 열기 대화상자 호출
            OpenFileDialog ofd = new OpenFileDialog();
            //열기 대화상자에서 원하는 파일을 고르고 싶다면
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //선택한 이미지 파일 가져오기
                Image img = Image.FromFile(ofd.FileName);
                pictureBox1.Image = img;
            }
        }
    }
}
