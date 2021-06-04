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

namespace _611
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        string filename = "오류";
        bool fst = true;
        string[] korean = { "바나나", "사과", "포도" };
        string[] english = { "banana", "apple", "grape" };
        string rdobtn;
        string chkbtn;
        public Form1()
        {
            InitializeComponent();
            //라디오 버튼 초기화
            rdoMale.TabStop = false;
            rdoFmale.TabStop = false;
            //언어능력 선택 그룹박스 비활성화
            gbCon.Enabled = false;
            //설문 결과 출력 버튼 비활성화
            btn_lbcheck.Enabled = false;
            //이미지 선택 버튼 비활성화
            btn_img.Enabled = false;
            //픽쳐박스 비활성화
            pb.Enabled = false;
            //이미지 선택 레이블 비활성화
            lb1.Enabled = false;
            //텍스트박스 비활성화
            tb.Enabled = false;
            //판정버튼 비활성화
            btn_tran.Enabled = false;
            //판정 표시 레이블 비활성화
            lb_tran.Enabled = false;
            ofd = new OpenFileDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pb.Image = image;
                if (fst)
                    fst = false;
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {

            //픽쳐박스 클릭시 파일명 얻기
            if (!fst) //버튼으로 이미지를 선택 한 경우
            {
                filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                //MessageBox.Show(filename, "이미지 파일명");
            }
            lb1.Text = filename;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_tran_Click(object sender, EventArgs e)
        {
            //파일 읽기
            //파일명 직접 명시
            //StreamReader rd = new StreamReader(File.OpenRead("테스트.txt"));
            //파일열기 대화상자로 경로와 파일명 둘 다 지정하기
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(File.OpenRead(ofd.FileName));
                string[] temp = new string[2];
                string[] korean = new string[3];
                string[] eng = new string[3];
                string tbAns = tb.Text;
                string record;
                int count = 0;
                //파일에서 한글 및 영문 단어 자료 불러오기
                while ((record = (rd.ReadLine())) != null) //읽을 레코드가 남아있다면
                {
                    temp = record.Split(' '); //스페이스를 구분자로 한 레코드를 한글과 영어로 분리
                    korean[count] = temp[0];
                    eng[count] = temp[1];
                    count++;
                }
                //불러온 자료를 활용하여 정답처리
                for (int i = 0; i < korean.Length; i++)
                {

                    if (filename == korean[i])
                    {
                        if (tbAns == eng[i])
                            lb_tran.Text = "정답입니다.";
                        else
                            lb_tran.Text = "다시공부하세요";


                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            gbCon.Enabled = true;
            btn_img.Enabled = true;
            pb.Enabled = true;
        }

        private void btn_lbcheck_Click(object sender, EventArgs e)
        {
            string total_str;
            if(rdoMale.Checked)
            {
                rdobtn = "남성";
                //MessageBox.Show(rdobtn);
            }

            else if (rdoFmale.Checked)
            {
                rdobtn = "여성";
                //MessageBox.Show(rdobtn);
            }
           
            string selong = "";
            if (rdoEng.Checked)
                if (selong == "")
                    selong = "영어";
                else
                    selong += "영어";

            if (rdoJap.Checked)
                if (selong == "")
                    selong = "일본어";
                else
                    selong += ", 일본어";

            if (rdoChi.Checked)
                if (selong == "")
                    selong = "중국어";
                else
                    selong += ", 중국어";
            //리스트박스에 라디오&체크박스 선택한 것 출력
            string totalStr = "";
            if (selong == "")
                lb.Items.Add(rdobtn);
            else
                lb.Items.Add(rdobtn + "." + selong);
            //이미지 선택 버튼과 픽쳐박스 해제
            btn_img.Enabled = true;
            pb.Enabled = true;
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void rdoFmale_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void gbCon_Enter(object sender, EventArgs e)
        {
            btn_lbcheck.Enabled= true;
        }
    }
}
