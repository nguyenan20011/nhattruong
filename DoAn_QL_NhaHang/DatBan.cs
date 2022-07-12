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
    public partial class DatBan : Form
    {
        DAO_ChonBan dao = new DAO_ChonBan();
        DAO_QLHD dao_hd = new DAO_QLHD();
        public string soban { get; set; }
        public string manv { get; set; }
        public string tennv { get; set; }
        public string quyen { get; set; }

        int tongtien = 0;


        DAO_NguyenLieu dao_nl = new DAO_NguyenLieu();

        public DatBan()
        {
            InitializeComponent();
        }

        private void DatBan_Load(object sender, EventArgs e)
        {
            DataTable dataset_TAM = dao.dsTam().Tables["TAM"];
            DataTable dataset_CTTAM = dao.dsCT_Tam().Tables["CT_TAM"];
            DataRow TAM = dao.load_TAM_By_Soban(soban);
            tongtien = Convert.ToInt32(TAM["TONGTIEN"].ToString());
            dataGridView1.DataSource = dao.load_CTTAM_By_Soban(soban);
            this.Text += "Chi Tiết Bàn Số  ( "+soban+" )";
            btnTongTien.Text +=" "+ String.Format("{0:0,0}", tongtien);
        }
        public string taoID()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + "";
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            DataSet dataset_hd = dao_hd.loadAllHoaDon();
            DataSet dataset_cthd = dao_hd.ds_CT_HoaDon();
            DataRow TAM = dao.load_TAM_By_Soban(soban);
            tongtien = Convert.ToInt32(TAM["TONGTIEN"].ToString());
            int kq = 0;
            if (txtNhapTien.Text.Length > 0)
            {
                int input = Convert.ToInt32(txtNhapTien.Text);
                kq = input - tongtien;
            }
            else
            {
                MessageBox.Show("Vui long nhap so tien!!!");
                return;
            }

            if (kq >= 0)
            {
                string mahd = taoID();
                if (dao_hd.add_HoaDon(mahd,manv, DateTime.Now.ToString(), Convert.ToInt32(TAM["TONGMON"].ToString()), Convert.ToInt32(TAM["TONGTIEN"].ToString())) == true)
                {
                    for (int i=0;i <dataGridView1.Rows.Count;i++)
                    {
                        cls_CTHD ct = new cls_CTHD();
                        ct.sMahd = mahd;
                        ct.sMamon = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ct.soluong = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        ct.gia = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());

                        dao_hd.add_CT_HoaDon(ct.sMahd, ct.sMamon, ct.soluong, ct.gia);

                    }
                    //xoa bang tam
                    dao.delete_CT_TAM(soban);
                    dao.delete_TAM(soban);
                    if(MessageBox.Show("Thanh Toán Thành Công, Số tiền phải thối là : " + kq)==DialogResult.OK)
                    {
                        ChonBan ban = new ChonBan();
                        ban.manv = manv;
                        ban.tennv = tennv;
                        ban.quyen = quyen;
                        ban.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("đách ổn ở chổ thêm hóa đơn rồi !!!");

                }

            }
            else
            {
                MessageBox.Show("Nhập Số Tiền Lớn Hơn" + tongtien + " giùm cái !!! khổ !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChonBan huy = new ChonBan();
            huy.manv = manv;
            huy.tennv = tennv;
            huy.quyen = quyen;
            huy.Show();
            this.Close();
        }

        private void txtNhapTien_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập Số á má !");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
