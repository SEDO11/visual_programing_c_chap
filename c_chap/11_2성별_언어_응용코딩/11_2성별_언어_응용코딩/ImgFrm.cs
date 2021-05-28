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
    public partial class ImgFrm : Form
    {
        public ImgFrm()
        {
            InitializeComponent();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pbx.Image = img;
            }
        }
    }
}
