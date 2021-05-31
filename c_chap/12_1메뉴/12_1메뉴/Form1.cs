using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_1메뉴
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 자르기MenuItem_Click(object sender, EventArgs e)
        {
            if (tbSrc.SelectedText != "") // 선택된 텍스트가 있는가?
                tbSrc.Cut(); // 자르기
        }

        private void 복사MenuItem_Click(object sender, EventArgs e)
        {
            if (tbSrc.SelectionLength > 0) //  if (tbSrc.SelectedText != "") 이거랑 같은의미
                tbSrc.Copy(); // 복사하기
        }

        private void 붙이기MenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) ;
            {
                tbDesc.Paste();
                Clipboard.Clear();
            }
        }
    }
}
