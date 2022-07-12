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
    public partial class QL_NhanVien : Form
    {
        DAO_QLNV dao = new DAO_QLNV();
        DAO_TaiKhoan dao_tk = new DAO_TaiKhoan();
        DAO_Luong dao_luong = new DAO_Luong();
        public QL_NhanVien()
        {
            InitializeComponent();
        }

        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            DataSet ds_luong = dao_luong.ds_Luong();
            DataSet data = dao.loadNhanVien();
            dataGridView1.DataSource = data.Tables["NV"];
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            load_SexNV();
            load_ChucVuNV();
            //thiet lap ẩn và hiện cho thg đầu tiên khi form load
            if (dao_luong.ktVaoLam(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim()) == true)
            {
                btnVaoCa.Visible = false;
                btnRaCa.Visible = true;


            }
            else
            {
                btnVaoCa.Visible = true;
                btnRaCa.Visible = false;
            }

            for (int i = 0; i< dataGridView1.Rows.Count;i++)
                if (dao_luong.ktVaoLam(dataGridView1.Rows[i].Cells[0].Value.ToString().Trim()) == true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White ;

                }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dao.timNhanVien(txtFind.Text);
        }

        private void btnClearFind_Click(object sender, EventArgs e)
        {
            QL_NhanVien_Load(sender, e);
            txtFind.Text = "";
        }

        public void load_SexNV()
        {
            cbb_gioitinh.Items.Add("Nam");
            cbb_gioitinh.Items.Add("Nữ");
        }

        public void load_ChucVuNV()
        {
            foreach(DataRow row in dao.loadChucVu().Rows)
            {
                cbb_chucvu.Items.Add(row[0]);
            }
        }

        public void layThongTinNV()
        {
            string manv = txtManv.Text;
            string hoten = txtHoten.Text;
            string diachi = txtDiaChi.Text;
            string gioitinh = cbb_gioitinh.SelectedItem.ToString();
            string ngaysinh = dtpicker_ngaysinh.Text;
            string sdt = txtSdt.Text;
            int chucvu = (int)cbb_chucvu.SelectedValue;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataSet data = dao.loadNhanVien();

            string manv = txtManv.Text;
            string hoten = txtHoten.Text;
            string diachi = txtDiaChi.Text;
            string gioitinh = cbb_gioitinh.SelectedItem.ToString();
            string ngaysinh = dtpicker_ngaysinh.Text;
            string sdt = txtSdt.Text;
            string chucvu = cbb_chucvu.SelectedItem.ToString();
            int luongcb = Convert.ToInt32(txtLuongCB.Text);
            if(manv!=null && hoten!=null && diachi!=null &&gioitinh!=null &&ngaysinh!=null && sdt != null &&luongcb>0)
            {
                if (dao.insert_NV(manv, hoten, diachi, gioitinh, ngaysinh, sdt, chucvu,luongcb) == true)
                {
                    MessageBox.Show("Thêm Thành Công !");
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên Đã Tồn Tại !");
                }
            }

        }

        private void xemLươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                QL_Luong luong = new QL_Luong();
                luong.manv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                luong.tennv= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                luong.Show();
                this.Hide();
            }
        }

        private void txtManv_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "Nhập MaNV")
            {
                txtManv.Text = "";
                txtManv.ForeColor = Color.Black;
            }
        }

        private void txtManv_Leave(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                txtManv.Text = "Nhập MaNV";
                txtManv.ForeColor = Color.DarkGray;
            }
        }

        private void txtHoten_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "Nhập Họ Tên")
            {
                txtHoten.Text = "";
                txtHoten.ForeColor = Color.Black;
            }
            
        }

        private void txtHoten_Leave(object sender, EventArgs e)
        {
            if (txtHoten.Text == "")
            {
                txtHoten.Text = "Nhập Họ Tên";
                txtHoten.ForeColor = Color.DarkGray;
            }
        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Nhập Địa Chỉ")
            {
                txtDiaChi.Text = "";
                txtDiaChi.ForeColor = Color.Black;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Text = "Nhập Địa Chỉ";
                txtDiaChi.ForeColor = Color.DarkGray;
            }
        }

        private void txtSdt_Click(object sender, EventArgs e)
        {
            if (txtSdt.Text == "Nhập Sđt")
            {
                txtSdt.Text = "";
                txtSdt.ForeColor = Color.Black;
            }
        }

        private void txtSdt_Leave(object sender, EventArgs e)
        {
            if (txtSdt.Text == "")
            {
                txtSdt.Text = "Nhập Sđt";
                txtSdt.ForeColor = Color.DarkGray;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows != null)
            {
                DialogResult resp= MessageBox.Show("Bạn Có Chắc Xóa Nhân Viên Này Không?", "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resp == DialogResult.OK)
                {
                    //xoa tai khoan truoc
                    DataSet tk = dao_tk.ds_TaiKhoan();

                    //xóa tát lương nhân viên
                    DataSet luong = dao_luong.ds_Luong();


                    string manv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (dao_tk.xoa_TK(manv) == true && dao_luong.xoaLuongTheoMaNV(manv))
                    {
                        //xoa nhan vien
                        DataSet data = dao.loadNhanVien();
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        dao.luuThayDoi();
                    }

                }
            }
        }

        private void tàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                
                TaiKhoan tk = new TaiKhoan();
                tk.manv = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                tk.chucvu = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
                tk.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                txtManv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                txtManv.ForeColor = Color.Black;
                txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                txtHoten.ForeColor = Color.Black;
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                txtDiaChi.ForeColor = Color.Black;
                txtSdt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
                txtSdt.ForeColor = Color.Black;
                cbb_gioitinh.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                dtpicker_ngaysinh.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim());
                cbb_chucvu.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
                txtLuongCB.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();
                //kt vao ca lam chua
                if (dao_luong.ktVaoLam(txtManv.Text.Trim()) == true)
                {
                    btnVaoCa.Visible = false;
                    btnRaCa.Visible = true;

                }
                else
                {
                    btnVaoCa.Visible = true;
                    btnRaCa.Visible = false;

                }
              

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataSet data = dao.loadNhanVien();

            string manv = txtManv.Text;
            string hoten = txtHoten.Text;
            string diachi = txtDiaChi.Text;
            string gioitinh = cbb_gioitinh.SelectedItem.ToString();
            string ngaysinh = dtpicker_ngaysinh.Text;
            string sdt = txtSdt.Text;
            string chucvu = cbb_chucvu.SelectedItem.ToString();
            int luongcb = Convert.ToInt32(txtLuongCB.Text);
            if (manv != null && hoten != null && diachi != null && gioitinh != null && ngaysinh != null && sdt != null &&luongcb>0)
            {
                //kt nếu như cập nhật chức vụ thì sẽ cập nhật quyền bên table tài khoản
                if(chucvu.Trim()=="QUẢN LÍ")
                {
                    DataSet taikhoan = dao_tk.ds_TaiKhoan();
                    //cap nhat quyen cho nhan vien
                    dao_tk.capNhatQuyen(manv);
                }

                if (dao.update_NV(manv, hoten, diachi, gioitinh, ngaysinh, sdt, chucvu,luongcb) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công !");
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên Chưa Tồn tại !");
                }
            }
        }


        public string taoID()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + "";
        }
        private void btnVaoCa_Click(object sender, EventArgs e)
        {
            DataSet ds_luong = dao_luong.ds_Luong();
            if (dataGridView1.SelectedRows != null)
            {
                string manv = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                string maluong = taoID();
                if (dao_luong.themGioVaoCa(maluong, manv) == true)
                {
                    btnVaoCa.Visible = false;
                    btnRaCa.Visible = true;
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor= Color.LightGreen;
                    MessageBox.Show("Đã Tính Giờ vào Làm !");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Nhân Viên Để Vào Ca Làm!");

            }
        }

        private void btnRaCa_Click(object sender, EventArgs e)
        {
            DataSet ds_luong = dao_luong.ds_Luong();
            if (dataGridView1.SelectedRows != null)
            {
                string manv = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                int luongcb = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim());

                if (dao_luong.themGioRaCa( manv,luongcb) == true)
                {
                    btnVaoCa.Visible = true;
                    btnRaCa.Visible = false;
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    string tennv = dataGridView1.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
                    MessageBox.Show("Ra Ca cho nhân viên :"+tennv);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Nhân Viên Để Ra Ca Làm!");

            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập Số á má !");
            }
        }

        private void btnDSTKhoan_Click(object sender, EventArgs e)
        {
            QL_TaiKhoan frm = new QL_TaiKhoan();
            frm.Show();
        }
    }
    
}
