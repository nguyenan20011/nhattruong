using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO_NhaHang;

namespace DoAn_QL_NhaHang
{
    public partial class NguyenLieu : Form
    {
        DAO_NguyenLieu dao = new DAO_NguyenLieu();
        public string manv { get; set; }
        public NguyenLieu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.ds_NguyenLieu().Tables["NL"];
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int sl = Convert.ToInt32(dataGridView1.Rows[i].Cells["KL_CONLAI"].Value);
                if(sl<=200 && sl >= 100)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }

                if (sl < 100)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

                if (sl > 200 && sl <= 500)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                }
            }
        }

        private void điĐếnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                QL_PhieuNhap open = new QL_PhieuNhap();
                open.manv = manv;
                open.Show();
                this.Hide();
            }
        }
    }
}
