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
    public partial class TaiKhoan : Form
    {
        DAO_TaiKhoan dao = new DAO_TaiKhoan();
        public string manv { get; set; }
        public string quyen { get; set; }
        public string chucvu { get; set; }

        public TaiKhoan()
        {
            InitializeComponent();
        }

       
        private void btnTao_Click(object sender, EventArgs e)
        {
            DataSet ds = dao.ds_TaiKhoan();
            if (txtTK.Text.Length>0 && txtMK.Text.Length > 0)
            {
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                if (chucvu == "Quản Lí")
                    quyen = "ADMIN";
                else
                    quyen = "USER";

                if (dao.add_TK(tk, mk, manv, quyen) == true)
                {
                    MessageBox.Show("Thiết Lập Tài Khoản Mới Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên Đăng Nhập Đã Tồn Tại");
                }

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ !");
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {

            this.Text ="Tài Khoản Của Nhân Viên Có Mã là :  "+ manv;
            //lblManv.Text = manv;
            if (dao.dt_TaiKhoan(manv) == null)
            {
                return;
            }
            else
            {
                txtTK.Enabled = false;
                lblDoi.Visible = true;
                txtMkMoi.Visible = true;
                btnDoi.Visible = true;
                btnTao.Visible = false;
                DataRow row = dao.dt_TaiKhoan(manv);
                txtTK.Text = row["TAIKHOAN"].ToString().Trim();
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            DataSet ds = dao.ds_TaiKhoan();
            if (txtTK.Text.Length > 0 && txtMK.Text.Length > 0 && txtMkMoi.Text.Length>0)
            {
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string mkmoi = txtMkMoi.Text;
                if(mk==mkmoi)
                {
                    MessageBox.Show("Mật Khẩu Mới Phải Khác Mật Khẩu Cũ Chứ !");
                    return;

                }

                if (dao.doi_TK(tk, mkmoi) == true)
                {
                    MessageBox.Show("Đổi Thành Công ,Đừng Quên Nhé!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có Lỗi Đã Xảy Ra");
                }

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ !");
            }
        }
    }
}
