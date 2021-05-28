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
/*
1.라디오버튼 윈도우를 메인 윈도우로 해서 실행하는 경우 언어선택 윈도우의 선택결과를 메인에 넘겨줌
2. 언어선택 윈도우에서 또 다른 윈도우를 호출하여 결과 출력
*/
namespace _11_2성별_언어_응용코딩
{
    public partial class Form1 : Form
    {
        string gender;
        public Form1()
        {
            InitializeComponent();
            //라디오버튼 모두 해제
            rdoMale.TabStop = false;
            rdoFemale.TabStop = false;
        }
        public string Gender
        {
            get { return Gender; }
            set { gender = value; }
        }

        private void btnGender_Click(object sender, EventArgs e)
        {
            if(rdoMale.Checked)
                gender = "남성";
            else if (rdoFemale.Checked)
                gender = "여성";
            //언어선택 폼 호출
            lngFrm Lf = new lngFrm(gender);
            Lf.ShowDialog();
            

        }
    }
}
