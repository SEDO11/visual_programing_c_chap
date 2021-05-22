using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리스트박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            lb.Items.Add(tb.Text);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if(lb.SelectedIndex != -1)
            {
                lb.Items.RemoveAt(lb.SelectedIndex);
            }
        }
    }
}
