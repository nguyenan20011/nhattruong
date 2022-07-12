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
    public partial class QL_PhieuNhap : Form
    {
        DAO_QLPN dao = new DAO_QLPN();
        DAO_QL_CTPN dao_ctpn = new DAO_QL_CTPN();

        public string manv{ get; set; }

        public QL_PhieuNhap()
        {
            InitializeComponent();
        }

        private void loadCbb_Ngay()
        {
            cbb_ngay.DropDownHeight= 70;
            for(int i = 1; i <= 31; i++)
            {
                cbb_ngay.Items.Add(i);
            }
        }

        private void loadCbb_Thang()
        {
            cbb_thang.DropDownHeight = 70;
            for (int i = 1; i <= 12; i++)
            {
                cbb_thang.Items.Add(i);
            }
        }

        private void loadCbb_Nam()
        {
            cbb_nam.DropDownHeight = 70;
            foreach (DataRow row in dao.loadPhieuNhap_Year().Rows)
            {
                cbb_nam.Items.Add(row[0]);
            }
        }

        private void QL_PhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.dt_PhieuNhap_NhanVien();
            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            loadCbb_Ngay();
            loadCbb_Thang();
            loadCbb_Nam();

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string day;
            string mon = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            if (cbb_thang.SelectedItem!=null)
            {
                mon = cbb_thang.SelectedItem.ToString();
            }

            if (cbb_nam.SelectedItem != null)
            {
                year =cbb_nam.SelectedItem.ToString();
            }

            if (cbb_ngay.SelectedItem!=null)
            {
                day = cbb_ngay.SelectedItem.ToString();
                MessageBox.Show("Ngày bạn tìm là:" + day + "/" + mon + "/" + year);
                dataGridView1.DataSource = dao.loadPhieuNhap_Ngay(day, mon, year);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Vui long chon thong tin ngay");
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.dt_PhieuNhap_NhanVien();
            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }


        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                QL_CT_PhieuNhap next = new QL_CT_PhieuNhap();
                next.mapn = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                next.manv = manv;
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui long chon Phieu Nhap");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                txtNoiDung.Text= dataGridView1.CurrentRow.Cells["NOIDUNG"].Value.ToString().Trim();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            DataSet dtset = dao.ds_PhieuNhap();
            string mota = txtNoiDung.Text;
            if (mota.Length <= 0)
            {
                mota = "Không có";
            }

            if (dao.add_PhieuNhap(manv.Trim(), mota) == true)
            {
                MessageBox.Show("Them Thanh Cong");
                dataGridView1.DataSource = dao.dt_PhieuNhap_NhanVien();
                dataGridView1.Refresh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DataSet dtset = dao.ds_PhieuNhap();
                string mapn = dataGridView1.CurrentRow.Cells["MAPN"].Value.ToString().Trim();
                if (dao.xoa_PhieuNhap(mapn) == true)
                {
                    MessageBox.Show("Xóa Thành Công " + mapn);
                    dataGridView1.DataSource = dao.dt_PhieuNhap_NhanVien();
                }
                else
                {
                    DataSet ds_ctpn = dao_ctpn.ds_CT_PhieuNhap();
                    DialogResult response = MessageBox.Show("Phiếu Nhập Này Có chi tiết Phiếu Nhập ,Bạn Có Muốn Xóa Toàn Bộ Không ?", "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (response == DialogResult.OK)
                    {
                        if (dao_ctpn.del_All_CTPN(mapn) == true)
                        {
                            MessageBox.Show("Xóa Thành Công Toàn Bộ " + mapn);
                            dataGridView1.DataSource = dao.dt_PhieuNhap_NhanVien();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Xóa Cái nào ?");
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DataSet dtset = dao.ds_PhieuNhap();
                string mapn = dataGridView1.CurrentRow.Cells["MAPN"].Value.ToString().Trim();
                string mota = txtNoiDung.Text;
                if (mota.Length <= 0)
                {
                    mota = "Không có";
                }
                if (dao.sua_PhieuNhap(mapn, manv, mota) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công !");
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = dao.dt_PhieuNhap_NhanVien();
                }
            }
            else
            {
                MessageBox.Show("Sửa Cái nào má ?");
            }
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
