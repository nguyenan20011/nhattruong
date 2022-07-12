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
    public partial class ThanhToan : Form
    {
        DAO_QLHD dao = new DAO_QLHD();
        DAO_NguyenLieu dao_nl = new DAO_NguyenLieu();
        // thuộc tính để trả về form Menu sau đó thêm chi tiết hoa don
        public string soban { get; set; }
        public string tennv { get; set; }
        public string quyen { get; set; }

        //thuộc tính để thêm hóa đơn
        public string mahd { get; set; }
        public string manv { get; set; }
        public int tongmon { get; set; }
        public int tongtien { get; set; }
        //chi tiet hoa don
        public List<cls_CTHD> list_ChiTietHoaDon { get; set; }
       
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm._layManv = manv;
            frm._layTemnv = tennv;
            frm._laysoban = soban;
            frm._layquyen = quyen;
            frm.list_ChiTietHoaDon = list_ChiTietHoaDon;
            frm.Show();
            this.Close();
        }
        
        public string ktNguyenLieuConKo()
        {
            DataSet call_dsNguyenLieu = dao_nl.ds_NguyenLieu();
            foreach (cls_CTHD ct in list_ChiTietHoaDon)
            {
                string response = dao_nl.capNhat_KhoiLuongConLai(ct.sMamon.Trim(), ct.soluong);
                if (response != "OK")
                {
                    return response;
                }
            }
            return null;
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DataSet dataset_hd = dao.loadAllHoaDon();
            DataSet dataset_cthd = dao.ds_CT_HoaDon();
            int kq=0;
            if(txtNhapTien.Text.Length >0)
            {
                int input = Convert.ToInt32(txtNhapTien.Text);
                kq = input - tongtien;
            }
            else
            {
                return;
            }

            if (kq>=0)
            {
                string response = ktNguyenLieuConKo();
                if (response == null)
                {
                    if (dao.add_HoaDon(mahd, manv, DateTime.Now.ToString(), tongmon, tongtien) == true)
                    {
                        foreach(cls_CTHD ct in list_ChiTietHoaDon)
                        {
                            //them tung mon vao chi tiet hoa don
                            if (dao.add_CT_HoaDon(ct.sMahd, ct.sMamon, ct.soluong, ct.gia) == true)
                            {
                            
                            }
                        
                        }
                        MessageBox.Show("Thanh Toán Thành Công, Số tiền phải thối là : " + kq);
                        ChonBan ban = new ChonBan();
                        ban.manv = manv;
                        ban.quyen = quyen;
                        ban.tennv = tennv;
                        ban.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("đách ổn ở chổ thêm hóa đơn rồi !!!");

                    }
                }
                else
                {
                    MessageBox.Show(response);
                    Menu frm = new Menu();
                    frm._layManv = manv;
                    frm._layTemnv = tennv;
                    frm._laysoban = soban;
                    frm._layquyen = quyen;
                    frm.list_ChiTietHoaDon = list_ChiTietHoaDon;
                    frm.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Nhập Số Tiền Lớn Hơn"+tongtien+" giùm cái !!! khổ !");
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            label2.Text += " " + string.Format("{0:0,0}",tongtien)+"Đ";
        }

        private void txtNhapTien_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập Số á má !");
            }
        }


    }
}
