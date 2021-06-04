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

namespace VP4_영화사이트_
{
    public partial class 영화소개 : Form
    {
        OpenFileDialog ofd;
        string filename = "오류";
        bool fst = true;
        List<string> movename = new List<string> { "분노의 질주: 더 얼티메이트", "기생충" };
        List<string> movedirector = new List<string> { "저스틴 린", "봉준호" };
        List<string> moveactor = new List<string> { "빈 디젤", "송강호" };
        int i = 0;
        public 영화소개()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pbPoster_Click(object sender, EventArgs e)
        {
            //픽쳐박스 클릭시 파일명 얻기
            if (!fst) //버튼으로 이미지를 선택 한 경우
            {
                filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                //MessageBox.Show(filename, "이미지 파일명");
                Int32.TryParse(filename, out i);
                lblMovieName.Text = movename[i];
                lblDir.Text = movedirector[i];
                lblActor.Text = moveactor[i];
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pbPoster.Image = image;
                if (fst)
                    fst = false;
            }
        }
    }
}
