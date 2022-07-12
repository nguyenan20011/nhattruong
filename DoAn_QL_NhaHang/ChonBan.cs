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
    public partial class ChonBan : Form
    {
        DAO_ChonBan dao = new DAO_ChonBan();
        public string manv { get; set; }
        public string quyen { get; set; }
        public string tennv { get; set; }

        
        public ChonBan()
        {
            InitializeComponent();
            //manv = ma;
        }
    
        void createSoBan()
        {
            int x = 120;
            int y = 60;
            int dem = 1;
            for (int i= 1;i<= 20;i++)
            {
                if ((dem-1) % 5 == 0)
                {
                    y += 70;
                    x = 120;
                }
                Button btn;
                if (dao.ktSoBan(i.ToString()) == true)
                {
                    btn = new Button() { Text = i.ToString(), Location = new Point(x, y), Height = 50, Width = 100, BackColor = Color.DarkGoldenrod, ForeColor = Color.White, Font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point) };
                }
                else
                {
                    btn = new Button() { Text = i.ToString(), Location = new Point(x, y), Height = 50 ,Width=100 ,BackColor=Color.White,ForeColor=Color.Black,Font=new Font("Arial",14, FontStyle.Bold, GraphicsUnit.Point) };

                }
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
                x += 120;
                dem++;

            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if ( dao.ktSoBan(btn.Text)==true)
            {
                DatBan ban = new DatBan();
                ban.soban = btn.Text;
                ban.manv = manv;
                ban.tennv = tennv;
                ban.quyen = quyen;
                ban.Show();
                this.Close();
            }
            else
            {
               
                Menu menu = new Menu();
                menu._laysoban = btn.Text;
                menu._layManv = manv;
                menu._layTemnv = tennv;
                menu._layquyen = quyen;
                menu.Show();
                this.Close();

            }
        }

        private void ChonBan_Load(object sender, EventArgs e)
        {
            DataTable dt_tam = dao.dsTam().Tables["TAM"];
            createSoBan();
            btnNameNV.Text = tennv;

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

        private void quảnLíNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen=="ADMIN")
            {
                QL_NhanVien ql = new QL_NhanVien();
                ql.Show();
            }
            else
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Close();
            }
        }

        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "ADMIN")
            {
                QL_HoaDon ql = new QL_HoaDon();
                ql.Show();
            }
            else
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Close();
            }
        }

        private void quảnLíHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "ADMIN")
            {
                QL_PhieuNhap ql = new QL_PhieuNhap();
                ql.manv = manv;
                ql.Show();
            }
            else
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Close();
            }
        }


        private void thôngTinNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNhom formInfo = new ThongTinNhom();
            formInfo.Show();
        }

        private void khoNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "ADMIN")
            {

                NguyenLieu ql = new NguyenLieu();
                ql.manv = manv;
                ql.Show();
            }
            else
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Close();
            }
        }

        private void côngThứcMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "ADMIN")
            {

                CongThucCheBien ql = new CongThucCheBien();
                ql.Show();
            }
            else
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Close();
            }
        }
    }
}
