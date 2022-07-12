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
    public partial class QL_CT_PhieuNhap : Form
    {
        DAO_QL_CTPN dao = new DAO_QL_CTPN();

        public string mapn { get; set; }
        public string manv { get; set; }
        public QL_CT_PhieuNhap()
        {
            InitializeComponent();
        }

        private void QL_CT_PhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.dt_CT_PhieuNhap(mapn);
            //dataGridView1.DataSource = dao.ds_CT_PhieuNhap().Tables["CTPN_ALL"];

            //fill into cbb
            cbb_NCC.DataSource = dao.dt_NhaCC();
            cbb_NCC.DisplayMember = "TENNCC";
            cbb_NCC.ValueMember = "MANCC";
            cbb_NCC.DropDownHeight = 100;
            groupBox1.Text += " " + mapn;

            cbb_NL.DataSource = dao.dt_NguyenLieu(cbb_NCC.SelectedValue.ToString().Trim());
            cbb_NL.DisplayMember = "TEN_NGUYENLIEU";
            cbb_NL.ValueMember = "MANGUYENLIEU";
            cbb_NL.DropDownHeight = 100;


        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double tong = 0;
            foreach (DataRow row in dao.load_TongTien_CTPN(mapn).Rows)
            {
                tong += Convert.ToDouble(row[0]);
            }

            MessageBox.Show("Tong Tien La: " + string.Format("{0:0,0}", tong) + "đ");
        }
        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_PhieuNhap back = new QL_PhieuNhap();
            back.manv = manv;
            back.Show();
            this.Close();
        }

        public bool ktInput()
        {
            if (txtCTPN.Text.Length >0 && txtGia.Text.Length > 0 && txtSL.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktInput() == false)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!!");
                return;
            }
            else
            {
                string mactpn = txtCTPN.Text;
                string manl = cbb_NL.SelectedValue.ToString();
                string mancc = cbb_NCC.SelectedValue.ToString();
                int gia = Convert.ToInt32(txtGia.Text);
                int sl = Convert.ToInt32(txtSL.Text);
                if(gia >0 && sl > 0)
                {
                    DataSet ds = dao.ds_CT_PhieuNhap();
                    if (dao.add_CTPN(mactpn.Trim(),mapn.Trim(), manl.Trim(), mancc.Trim(), gia, sl) == true)
                    {
                        MessageBox.Show("Thêm Thành Công !!");
                        dataGridView1.DataSource = dao.dt_CT_PhieuNhap(mapn);

                    }
                    else
                    {
                        MessageBox.Show("Mã này đã tồn tại vui lòng sử dụng đúng chức năng !");

                    }
                }
                else
                {
                    MessageBox.Show("Giá Tiền và Số Lượng Không Được Phép < 0");

                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                string manl = cbb_NL.SelectedValue.ToString();
                string mactpn = dataGridView1.CurrentRow.Cells["MA_CTPN"].Value.ToString().Trim();
                int gia = Convert.ToInt32(dataGridView1.CurrentRow.Cells["GIA"].Value.ToString().Trim());
                int sl = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SOLUONG"].Value.ToString().Trim());

                DataSet ds = dao.ds_CT_PhieuNhap();
                if (dao.del_CTPN(mactpn.Trim(),mapn.Trim(),manl.Trim(), gia,sl) == true)
                {
                    MessageBox.Show("Xóa Thành Công !!");
                    dataGridView1.DataSource = dao.dt_CT_PhieuNhap(mapn);

                }
                else
                {
                    MessageBox.Show("Nguyên Liệu Này đã được sử dụng rồi nên không thể xóa!");

                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!");

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ktInput() == false)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!!");
                return;
            }
            string mactpn = txtCTPN.Text;
            string manl = cbb_NL.SelectedValue.ToString();
            string mancc = cbb_NCC.SelectedValue.ToString();
            int gia = Convert.ToInt32(txtGia.Text);
            int slcu = Convert.ToInt32(txtSL.Text);
            int slmoi = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SOLUONG"].Value);
            if (gia > 0 && slmoi > 0)
            {
                DataSet ds = dao.ds_CT_PhieuNhap();
                if (dao.Update_CTPN(mactpn.Trim(), mapn.Trim(), manl.Trim(), mancc.Trim(), gia, slcu,slmoi) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công !!");
                    dataGridView1.DataSource = dao.dt_CT_PhieuNhap(mapn);

                }
                else
                {
                    MessageBox.Show("Mã chưa tồn tại vui lòng sử dụng đúng chức năng !");

                }
            }
            else
            {
                MessageBox.Show("Giá Tiền và Số Lượng Không Được Phép < 0");

            }
        }

        public void getInfo()
        {
            if (dataGridView1.SelectedRows!=null){
                txtCTPN.Text = dataGridView1.CurrentRow.Cells["MA_CTPN"].Value.ToString();
                txtSL.Text = dataGridView1.CurrentRow.Cells["SOLUONG"].Value.ToString();
                txtGia.Text = dataGridView1.CurrentRow.Cells["GIA"].Value.ToString();

                cbb_NCC.SelectedValue = dataGridView1.CurrentRow.Cells["MANCC"].Value.ToString().Trim();

                cbb_NL.SelectedValue= dataGridView1.CurrentRow.Cells["MANGUYENLIEU"].Value.ToString().Trim();
            }
        }

        public string taoID()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + "";
        }
        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            txtCTPN.Text = taoID().ToString();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập Số á má !");
            }
        }

        private void cbb_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_NCC.SelectedItem != null)
            {
                cbb_NL.DataSource = dao.dt_NguyenLieu(cbb_NCC.SelectedValue.ToString());
                cbb_NL.DisplayMember = "TEN_NGUYENLIEU";
                cbb_NL.ValueMember = "MANGUYENLIEU";
                cbb_NL.DropDownHeight = 100;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getInfo();
        }
    }
}
