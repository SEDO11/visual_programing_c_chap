using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // 이게 있어야 StreamReader 사용가능

namespace _9_1사용자클래스_성적계산
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string line, result;
            string[] temp = new string[4];
            string[] name = new string[3];
            int[] kor, eng, math;
            kor = new int[3];
            eng = new int[3];
            math = new int[3];
            int count = 0;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(ofd.FileName); 
                while((line = rd.ReadLine()) != null)
                {
                    temp = line.Split(' ');
                    name[count] = temp[0];
                    kor[count] = int.Parse(temp[1]);
                    eng[count] = int.Parse(temp[2]);
                    math[count] = int.Parse(temp[3]);
                    result = name[count] + ' ' + kor[count].ToString() + ' ' + eng[count].ToString() + ' ' + math[count].ToString() + "\r\n";
                    tb.Text += result;
                    count++;
                }
                rd.Dispose();

            }
        }
    }
}
