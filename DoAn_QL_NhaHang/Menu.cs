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
    public partial class Menu : Form
    {
        private string soban;
        private string manv;
        private string tennv;
        private string quyen;
        private string mahd;
        public List<cls_CTHD> list_ChiTietHoaDon { get; set; }

        DAO_NguyenLieu dao_nl = new DAO_NguyenLieu();
        DAO_Menu dao_menu = new DAO_Menu();
        DAO_ChonBan dao_chonban = new DAO_ChonBan();
        public Menu()
        {
            InitializeComponent();
        }
        public string _layManv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string _layTemnv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public string _laysoban
        {
            get { return soban; }
            set { soban = value; }
        }

        public string _layquyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public string _layMahd
        {
            get { return mahd; }
            set { mahd = value; }
        }





        void createMenu(int vitri)
        {
            DataTable dsMon = dao_menu.loadMenu(vitri);
            int x = 50;
            int y = 50;
            int dem = 1;

            for(int i = 0; i <dsMon.Rows.Count; i++)
            {

                
                Button btn = new Button() { Text = dsMon.Rows[i]["TENMON"].ToString(), Location = new Point(x, y), Height = 50, Width = 100 ,ForeColor=Color.Yellow };
                Label lbl = new Label() { Text = string.Format("{0:0,0}", dsMon.Rows[i]["GIA"]), Location = new Point(x+15, y+55), Height = 20, Width = 100 };
               
                btn.Click += Btn_Click;
                switch (vitri)
                {
                    case 1: 
                        {
                            tabItem_Chinh.Controls.Add(btn);
                            tabItem_Chinh.Controls.Add(lbl);
                        }break;
                    case 2:
                        {
                            tabItem_Chinh2.Controls.Add(btn);
                            tabItem_Chinh2.Controls.Add(lbl);
                        }
                        break;
                    case 3:
                        {
                            tabItem_NuocUong.Controls.Add(btn);
                            tabItem_NuocUong.Controls.Add(lbl);
                        }
                        break;
                    case 4:
                        {
                            tabItem_Phu.Controls.Add(btn);
                            tabItem_Phu.Controls.Add(lbl);
                        }
                        break;
                }
                if (dem % 5 == 0)
                {
                    y += 100;
                    x = 50;
                }
                else x += 140;
                dem++;
            }
        }

        private int tongSoMon()
        {
            int tong = 0;
            if (listView_MonAn.Items.Count>0)
            {
                for (int i = 0; i < listView_MonAn.Items.Count; i++)
                {
                    tong += Convert.ToInt32(listView_MonAn.Items[i].SubItems[2].Text);
                }
            }
            return tong;
        }

        private int tongTien()
        {
            int tong = 0;
            if (listView_MonAn.Items.Count > 0)
            {
                for (int i = 0; i < listView_MonAn.Items.Count; i++)
                {
                    tong += Convert.ToInt32(listView_MonAn.Items[i].SubItems[3].Text);
                }
            }
            return tong;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataRow row = dao_menu.queryBy_TENMON(btn.Text);
            string ma_mon = row["MAMON"].ToString();
            string tenmon = row["TENMON"].ToString();
            int giatien = (int)row["GIA"];
            int soluong = 1;
            ListViewItem item;
            if (listView_MonAn.FindItemWithText(tenmon) != null)
            {
                item = listView_MonAn.FindItemWithText(tenmon);
                //lay ra
                soluong=Convert.ToInt32(item.SubItems[2].Text)+1;
                //gan lai vao
                item.SubItems[2].Text = (soluong).ToString();
                item.SubItems[3].Text = (giatien*(soluong)).ToString();
            }
            else
            {
                item =new ListViewItem(new[] { ma_mon,tenmon,soluong.ToString(),giatien.ToString() });
                listView_MonAn.Items.Add(item);
            }
            txtTongMon.Text = tongSoMon().ToString();
            txtTogTien.Text = tongTien().ToString();
        }


        private void Menu_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 4; i++)
            {
                createMenu(i);
            }

            if (list_ChiTietHoaDon !=null)
            {
                for (int i= 0;i < list_ChiTietHoaDon.Count; i++){
                    ListViewItem item = new ListViewItem(new[] { list_ChiTietHoaDon[i].sMamon.ToString(), list_ChiTietHoaDon[i].stenmon.ToString(), list_ChiTietHoaDon[i].soluong.ToString(), list_ChiTietHoaDon[i].gia.ToString() });
                    listView_MonAn.Items.Add(item);
                }
                txtTongMon.Text = tongSoMon().ToString();
                txtTogTien.Text = tongTien().ToString();

            }
            else
            {
                txtTongMon.Text = "0";
                txtTogTien.Text = "0";

            }

        

            txtTenNV.Text = tennv;
            button1.Text += " " + "[" + soban + "]";
            txtMask.Text = String.Format("{0:dd-MM-yyyy}", DateTime.Now.ToShortDateString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView_MonAn.SelectedItems.Count > 0)
            {
                    listView_MonAn.Items.Remove(listView_MonAn.SelectedItems[0]);
            }
            else 
                MessageBox.Show("Xóa lỗi");
            txtTongMon.Text = tongSoMon().ToString();
            txtTogTien.Text =tongTien().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChonBan ban = new ChonBan();
            ban.manv = manv;
            ban.tennv = tennv;
            ban.quyen = quyen;
            ban.Show();
            this.Hide();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc xóa hết không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                listView_MonAn.Items.Clear();
                txtTogTien.Text = "0";
                txtTongMon.Text = "0";
            }
           
        }

        public string taoID()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + "";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (listView_MonAn.Items.Count > 0)
            {
                string mahd = taoID();
                ThanhToan frm = new ThanhToan();
                frm.manv = manv;
                frm.tennv = tennv;
                frm.soban = soban;
                frm.quyen = quyen;
                frm.mahd = mahd;
                frm.tongmon = tongSoMon();
                frm.tongtien = tongTien();



                List<cls_CTHD> dsCTHD = new List<cls_CTHD>();
                foreach (ListViewItem item in listView_MonAn.Items)
                {
                    cls_CTHD ct = new cls_CTHD();
                    ct.sId = taoID();
                    ct.sMahd = mahd;
                    ct.sMamon = item.SubItems[0].Text;
                    ct.stenmon = item.SubItems[1].Text;
                    ct.soluong = Convert.ToInt32(item.SubItems[2].Text);
                    ct.gia = Convert.ToInt32(item.SubItems[3].Text) / Convert.ToInt32(item.SubItems[2].Text);
                    dsCTHD.Add(ct);
                }
                frm.list_ChiTietHoaDon = dsCTHD;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chưa Có Món j kìa cha !");
            }
        }

        public string ktNguyenLieuConKo()
        {
            DataSet call_dsNguyenLieu = dao_nl.ds_NguyenLieu();
            foreach (ListViewItem item in listView_MonAn.Items)
            {
                string response = dao_nl.capNhat_KhoiLuongConLai(item.SubItems[0].Text, Convert.ToInt32(item.SubItems[2].Text));
                if (response != "OK")
                {
                    return response;
                }
                
            }
            return null;
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (listView_MonAn.Items.Count > 0)
            {
                DataSet call_nguyenlieu = dao_nl.ds_NguyenLieu();
                string response = ktNguyenLieuConKo();
                if (response == null)
                {
                    DataTable dt_tam = dao_chonban.dsTam().Tables["TAM"];
                    dao_chonban.add_TAM(Convert.ToInt32(soban), manv, "", DateTime.Now.ToString(), tongSoMon(), tongTien());
                    DataTable dt_cttam = dao_chonban.dsCT_Tam().Tables["CT_TAM"];

                    foreach (ListViewItem item in listView_MonAn.Items)
                    {
                        cls_CT_TAM ct = new cls_CT_TAM();
                        ct.id = taoID();
                        ct.soban = Convert.ToInt32(soban);
                        ct.mamon = item.SubItems[0].Text;
                        ct.sl = Convert.ToInt32(item.SubItems[2].Text);
                        ct.gia = Convert.ToInt32(item.SubItems[3].Text);
                        dao_chonban.add_CT_TAM(ct.id, ct.soban, ct.mamon, ct.sl, ct.gia);
                    }
                    ChonBan ban = new ChonBan();
                    ban.manv = manv;
                    ban.quyen = quyen;
                    ban.tennv = tennv;
                    ban.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response);
                }

                
            }
            else
            {
                MessageBox.Show("Chưa Có Món j kìa cha !");
            }
        }
    }
}
