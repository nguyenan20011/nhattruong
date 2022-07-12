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
    public partial class QL_TaiKhoan : Form
    {
        DAO_TaiKhoan dao = new DAO_TaiKhoan();
        public QL_TaiKhoan()
        {
            InitializeComponent();
        }

        private void QL_TaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.ds_TaiKhoan().Tables["TK"];
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
        }
    }
}
