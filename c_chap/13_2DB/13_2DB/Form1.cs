using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_2DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.성적DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 '성적DataSet.Table' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tableTableAdapter.Fill(this.성적DataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = tableDataGridView.SelectedRows[0].DataBoundItem as Student;
            tbNumber.Text = selectedRow.Name;
            tbScore.Text = selectedRow.Sc.ToString();
            
        }

        private void tableDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowldx = tableDataGridView.CurrentRow.Index;
            tbNumber.Text = tableDataGridView.Rows[rowldx].Cells[0].Value.ToString();
            tbName.Text = tableDataGridView.Rows[rowldx].Cells[1].Value.ToString();
            tbScore.Text = tableDataGridView.Rows[rowldx].Cells[2].Value.ToString();
        }
    }
}
