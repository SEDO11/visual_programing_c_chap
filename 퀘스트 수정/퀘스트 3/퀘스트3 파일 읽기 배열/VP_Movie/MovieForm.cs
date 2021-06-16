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

namespace VP_Movie
{
    public partial class MovieForm : Form
    {
        List<Plist> mvList = new List<Plist>(); //클래스 프로퍼티를 이용해 listbox에 순서대로 저장할 리스트 변수 설정
        OpenFileDialog ofd;
        string filename = " "; //이미지 파일 이름 값 받을 변수 설정
        bool fst = true; //버튼 행동 값 받을 논리 변수 설정
        int adultmoney = 10000; //어른 영화표 가격
        int teenmoney = 7000; //청소년 영화표 가격
        int dpmoney = 4000; //장애인 우대 영화표 가격

        public MovieForm()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            //라디오 버튼 초기화
            tbAdult.Enabled = false; //연령 선택 그룹박스 비활성화
            tbTeen.Enabled = false; //영화 입력창 비활성
            tbDp.Enabled = false; //인원 입력창 비활성
            pbPoster.Image = Properties.Resources.CGV; //프로그램 초기화면 설정
            lblMovieName.Text = "초기화면";
            lblExp.Text = "영화를 선택해 주세요.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //픽쳐박스 클릭시 파일명 얻기
            if (!fst) //버튼으로 이미지를 선택 한 경우
            {
                filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                //MessageBox.Show(filename, "이미지 파일명");
            }
            lblMovieName.Text = filename;
        }

        private void btnSelct_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK) //영화 선택 버튼을 누르면 이미지를 선택한다.
            {
                Image image = Image.FromFile(ofd.FileName);
                pbPoster.Image = image;
                if (fst)
                    fst = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //파일 읽기
            //파일명 직접 명시
            //StreamReader rd = new StreamReader(File.OpenRead("테스트.txt"));
            //파일열기 대화상자로 경로와 파일명 둘 다 지정하기
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(File.OpenRead(ofd.FileName));
                string[] temp = new string[4];
                string[] koreamoviename = new string[7];
                string[] moviedirector = new string[7];
                string[] movieactor = new string[7];
                string[] moviegenre = new string[7];
                string[] moviestory = new string[7];
                string record;
                int count = 0;

                //텍스트 파일에서 영화 자료 불러오기
                while ((record = (rd.ReadLine())) != null) //읽을 레코드가 남아있다면
                {
                    temp = record.Split(' '); //스페이스를 구분자로 한 레코드를 한글과 영어로 분리
                    koreamoviename[count] = temp[0];
                    moviedirector[count] = temp[1];
                    movieactor[count] = temp[2];
                    moviegenre[count] = temp[3];
                    moviestory[count] = temp[4];
                    count++;
                }

                for (int i = 0; i < koreamoviename.Length; i++)
                {

                    if (filename == koreamoviename[i])
                    {
                        lblMovieName.Text = koreamoviename[i];
                        lblDir.Text = moviedirector[i];
                        lblActor.Text = movieactor[i];
                        lblGenre.Text = moviegenre[i];
                        lblExp.Text = moviestory[i];
                        tbAdult.Enabled = true; 
                        tbTeen.Enabled = true; 
                        tbDp.Enabled = true; 
                    }
                }
            }
        }

        private void btnMovieSelct_Click(object sender, EventArgs e)
        {
            Plist memo = new Plist(); //입력받을 프로퍼티 클래스 사용
            GetMemoData(memo);
            mvList.Add(memo);
            string moviename = lblMovieName.Text;
            lbmemo.Items.Add(moviename);//영화이름 저장
            //텍스트박스 초기화
            tbAdult.Clear();
            tbTeen.Clear();
            tbDp.Clear();
        }

        private void GetMemoData(Plist fr) //textbox에 있던 값들을 저장
        {
            fr.adult = int.Parse(tbAdult.Text);
            fr.teen = int.Parse(tbTeen.Text);
            fr.dp = int.Parse(tbDp.Text);
        }

        private void lbmemo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbmemo.SelectedIndex;
            MessageBox.Show("어른 " + mvList[index].adult.ToString() + " 명\n" +
               "청소년 " + mvList[index].teen.ToString() + " 명\n" +
               "장애인(우대) " + mvList[index].dp.ToString() + " 명\n" +
               "총 가격 " + ((adultmoney * mvList[index].adult) + (teenmoney * mvList[index].teen) + (dpmoney * mvList[index].dp)) + " 원", ("예매내역 상세"));
        }
    }
}
