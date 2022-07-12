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
    public partial class DangNhap : Form
    {
        DAO_DangNhap dao_dangnhap = new DAO_DangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //ChonBan menu = new ChonBan();
            //menu.Show();
            //this.Hide();

            string tk, mk;
            tk = txtTaiKhoan.Text;
            mk = txtMatKhau.Text;
            DataRow row = dao_dangnhap.loadThongTinNV(tk, mk);
            if (row != null)
            {
                //MessageBox.Show("Dang Nhap Thanh Cong");
                ChonBan menu = new ChonBan();
                menu.manv = row["MANV"].ToString();
                menu.quyen = row["QUYEN"].ToString();
                menu.tennv = row["TENNV"].ToString();

                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tai khoan or mat khau incorrect");
            }
        }

        private void DangNhap_Shown(object sender, EventArgs e)
        {
        }
    }
}
