using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_2성별_언어_응용코딩
{
    public partial class lngFrm : Form
    {
        string lang, gen;
        public lngFrm(string g)
        {
            InitializeComponent();
            gen = g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkEng.Checked)
                if (lang != "")
                    lang += " 영어";
                else
                    lang = "영어";
            if (chkJpn.Checked)
                if (lang != "")
                    lang += " 일본어";
                else
                    lang = "일본어";
            if (chkChin.Checked)
                if (lang != "")
                    lang += " 중국어";
                else
                    lang = "중국어";
            MessageBox.Show(gen + " " + lang, "선택결과");
            ImgFrm imgform = new ImgFrm();
            imgform.Show();

        }
    }
}
