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
    public partial class QL_HoaDon : Form
    {
        DAO_QLHD dao = new DAO_QLHD();
        public QL_HoaDon()
        {
            InitializeComponent();
        }

        private void QL_HoaDon_Load(object sender, EventArgs e)
        {
            DataTable tblDoanhThu = dao.loadAllHoaDon().Tables["HD_ALL"];
            dataGridView1.DataSource = tblDoanhThu;
            txtDoanhThu.Text = String.Format("{0:0,0}", tongDoanhThu(tblDoanhThu));
            cbb_tennv.DataSource = dao.loadTennv();
            cbb_tennv.DisplayMember = "TENNV";
            cbb_tennv.ValueMember = "MANV";
            cbb_tennv.SelectedItem = null;

            //ngay
            cbbNgay.DataSource = dao.loadNgay();
            cbbNgay.DisplayMember = "NGAY";
            cbbNgay.ValueMember = "NGAY";
            //cbbNgay.SelectedItem = null;
            //thang
            cbbThang.DataSource = dao.loadThang();
            cbbThang.DisplayMember = "THANG";
            cbbThang.ValueMember = "THANG";
            //cbbThang.SelectedItem = null;
            //nam
            cbbNam.DataSource = dao.loadNam();
            cbbNam.DisplayMember = "NAM";
            cbbNam.ValueMember = "NAM";
            //cbbNam.SelectedItem = null;
        }

        

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            DataTable tblDoanhThu = dao.loadAllHoaDon().Tables["HD_ALL"];
            dataGridView1.DataSource =tblDoanhThu;
            txtDoanhThu.Text =String.Format("{0:0,0}", tongDoanhThu(tblDoanhThu));
        }

        private double tongDoanhThu(DataTable dt)
        {
            double tong = 0;
            foreach(DataRow row in dt.Rows)
            {
                tong += Convert.ToDouble(row["TONGTIEN"].ToString());
            }
            return tong;
        }

        private void xemChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                QL_CT_HoaDon ct = new QL_CT_HoaDon();
                ct._mahd = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ct.Show();
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string ngay, thang, nam;
            if (cbbNgay.SelectedItem == null)
            {
                ngay = DateTime.Now.Day.ToString();
            }
            else
            {
                ngay = cbbNgay.SelectedValue.ToString();
            }


            if (cbbThang.SelectedItem == null)
            {
                thang = DateTime.Now.Month.ToString();
            }
            else
            {
                thang=cbbThang.SelectedValue.ToString();
            }

            if (cbbNam.SelectedItem == null)
            {
                nam = DateTime.Now.Year.ToString();
            }
            else
            {
                nam = cbbNam.SelectedValue.ToString();
            }

            DataTable tblDoanhThu = dao.loadDoanhThu_Ngay(ngay, thang, nam);
            dataGridView1.DataSource = tblDoanhThu;
            txtDoanhThu.Text = string.Format("{0:0,0}", tongDoanhThu(tblDoanhThu));

        }

        private void cbb_tennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_tennv.SelectedItem != null)
            {
                string manv = cbb_tennv.SelectedValue.ToString();
                DataTable tblHD = dao.loadHoaDonByManv(manv);
                dataGridView1.DataSource = tblHD;
                txtDoanhThu.Text = string.Format("{0:0,0}", tongDoanhThu(tblHD));

            }
            else
            {
                dataGridView1.DataSource = dao.loadAllHoaDon().Tables["HD_ALL"];
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string mahd = dataGridView1.CurrentRow.Cells["MAHD"].Value.ToString().Trim();
                Report_HoaDon rpt_frm = new Report_HoaDon();
                rpt_frm.mahd = mahd;
                rpt_frm.Show();
            }
        }
    }
}
