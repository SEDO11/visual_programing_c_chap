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
        //리스트 자료구조를 통한 파일 읽기
        List<string> moviename = new List<string>();
        List<string> moviedirector = new List<string>();
        List<string> movieactor = new List<string>();
        List<string> moviegenre = new List<string>();
        List<string> movieinfo = new List<string>();
        int i; //텍스트파일을 통해 저장된 리스트에서 영화 정보를 불러오기 위한 변수

        List<Plist> mvList = new List<Plist>(); //클래스 프로퍼티를 이용해 listbox에 순서대로 저장할 리스트 변수 설정
        //MovieStory ms = new MovieStory(); //영화 정보 들어있는 클래스 가져오기
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

        public void btnCheck_Click(object sender, EventArgs e)
        {
            if (!fst) //버튼으로 이미지를 선택 한 경우
            {
                 //텍스트파일을 통해 정보를 저장한 리스트
                 MovieName(); //영화 제목 출력
                 MovieDirector();//영화 감독 출력
                 MovieActor(); //영화 배우 출력
                 MovieGenre();// 영화 장르 출력
                 MovieInfo(); //영화 줄거리 출력

                filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                Int32.TryParse(filename, out i); //파일 이름을 출력해서 해당하는 정보들 출력

                if (filename != "7") //이미지 파일 명이 cgv가 아닐 때 해당 영화들의 정보를 출력
                {
                    lblMovieName.Text = moviename[i - 1]; //리스트에서 영화이름 출력
                    lblDir.Text = moviedirector[i - 1];  //리스트에서 영화 감독 출력
                    lblActor.Text = movieactor[i - 1]; // 리스트에서 영화 배우 출력
                    lblGenre.Text = moviegenre[i - 1]; // 리스트에서 영화 장르 출력
                    lblExp.Text = movieinfo[i - 1]; // 리스트에서 영화 줄거리 출력

                    tbAdult.Enabled = true; //인원 입력창 open
                    tbTeen.Enabled = true; //인원 입력창 open
                    tbDp.Enabled = true; //인원 입력창 open
                }

                else //초기상태
                {
                    lblMovieName.Text = "초기화면";
                    lblDir.Text = " ";
                    lblActor.Text = " ";
                    lblGenre.Text = " ";
                    lblExp.Text = "영화를 선택해 주세요.";
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

        private void MovieName() //영화제목을 파일에서 불러옴
        {
            StreamReader mn = File.OpenText("C:\\Users\\donha\\OneDrive\\바탕 화면\\퀘스트 수정\\퀘스트4 파일 읽기 리스트\\VP_Movie\\Resources\\영화제목.txt");
            while (!mn.EndOfStream)
            {
                moviename.Add(mn.ReadLine());
            }
        }

        private void MovieDirector() //영화감독을 파일에서 불러옴
        {
            StreamReader md = File.OpenText("C:\\Users\\donha\\OneDrive\\바탕 화면\\퀘스트 수정\\퀘스트4 파일 읽기 리스트\\VP_Movie\\Resources\\영화제목.txt");
            while (!md.EndOfStream)
            {
                moviedirector.Add(md.ReadLine());
            }
        }

        private void MovieActor() //영화배우를 파일에서 불러옴
        {
            StreamReader ma = File.OpenText("C:\\Users\\donha\\OneDrive\\바탕 화면\\퀘스트 수정\\퀘스트4 파일 읽기 리스트\\VP_Movie\\Resources\\영화배우.txt");
            while (!ma.EndOfStream)
            {
                movieactor.Add(ma.ReadLine());
            }
        }

        private void MovieGenre() //영화장르를 파일에서 불러옴
        {
            StreamReader mg = File.OpenText("C:\\Users\\donha\\OneDrive\\바탕 화면\\퀘스트 수정\\퀘스트4 파일 읽기 리스트\\VP_Movie\\Resources\\영화장르.txt");
            while (!mg.EndOfStream)
            {
                moviegenre.Add(mg.ReadLine());
            }
        }

        private void MovieInfo() //영화정보를 파일에서 불러옴
        {
            StreamReader mi = File.OpenText("C:\\Users\\donha\\OneDrive\\바탕 화면\\퀘스트 수정\\퀘스트4 파일 읽기 리스트\\VP_Movie\\Resources\\영화줄거리.txt");
            while (!mi.EndOfStream)
            {
                movieinfo.Add(mi.ReadLine());
            }
        }
    }
}

