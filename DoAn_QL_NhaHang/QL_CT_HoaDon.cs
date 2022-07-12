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
    public partial class QL_CT_HoaDon : Form
    {
        DAO_QLHD dao = new DAO_QLHD();
        private string mahd;
        public string _mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public QL_CT_HoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QL_CT_HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.dt_CT_HoaDon(mahd);
            this.Text= "Chi Tiết Hóa Đơn ( " + mahd+" )";
        }
    }
}
