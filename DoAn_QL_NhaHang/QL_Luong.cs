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
   
    public partial class QL_Luong : Form
    {
        DAO_Luong dao = new DAO_Luong();
        public string manv{ get; set; }
        public string tennv { get; set; }

        public QL_Luong()
        {
            InitializeComponent();
        }

        private void QL_Luong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.dt_Luong(manv);
            DataSet dsLuong = dao.ds_Luong();
            this.Text= "Lương Của " + tennv;
        }



        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_NhanVien qlnv = new QL_NhanVien();
            qlnv.Show();
            this.Close();
        }

        private void xemLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double tong = dao.tinhTongLuongThangHienTai(manv);
            MessageBox.Show("Tổng Lương Tháng Này là " + String.Format("{0:0,0}", tong));
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DialogResult resp = MessageBox.Show("Bạn Có Chắc Xóa Lịch Sử Của Nhân Viên Này Không?", "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resp == DialogResult.OK)
                {
                    string maluong = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (dao.xoaLuong(maluong) == true)
                    {
                        MessageBox.Show("Xóa Thành Công !", "Thông báo");
                        dataGridView1.DataSource = dao.dt_Luong(manv);
                    }

                }
            }
        }

        private void phạtTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                if (txtPhatTien.Text.Length >0)
                {
                    dataGridView1.DataSource = dao.dt_Luong(manv);
                    int khautru = Convert.ToInt32(txtPhatTien.Text.Trim());
                    string maluong = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (dao.themKhauTru(maluong,khautru) == true)
                    {
                        MessageBox.Show("Thêm Khấu Trừ Thành Công!", "Thông báo");
                        dataGridView1.DataSource = dao.dt_Luong(manv);
                    }

                }
                else
                {
                    MessageBox.Show("vui lòng nhập tiền!", "Thông báo");
                }
            }
        }

        private void txtPhatTien_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập Số á má !");
            }
        }
    }
}
