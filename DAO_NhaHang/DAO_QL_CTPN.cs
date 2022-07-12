using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_QL_CTPN
    {
        DBConnection db = new DBConnection();
        DataSet ds=new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        DataColumn[] key1 = new DataColumn[1];
        DAO_NguyenLieu dao_nl = new DAO_NguyenLieu();
        public DataTable dt_CT_PhieuNhap(string mapn)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select ct.MA_CTPN,nl.TEN_NGUYENLIEU,ct.GIA,ct.SOLUONG, nl.MANGUYENLIEU,ncc.MANCC from CT_PHIEUNHAP ct, NGUYENLIEU nl ,NHACC ncc where ct.MANGUYENLIEU = nl.MANGUYENLIEU and ct.MANCC = ncc.MANCC and ct.MAPN = '"+mapn+"'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataSet ds_CT_PhieuNhap()
        {
            try
            {
                string sql = "select * from CT_PHIEUNHAP ";
                da = db.Connect_Adapter(sql);
                da.Fill(ds, "CTPN_ALL");
                key[0] = ds.Tables["CTPN_ALL"].Columns[0];
                ds.Tables["CTPN_ALL"].PrimaryKey = key;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataSet ds_PhieuNhap()
        {
            try
            {
                string sql = "select * from PHIEUNHAP ";
                da = db.Connect_Adapter(sql);
                da.Fill(ds, "PN");
                key1[0] = ds.Tables["PN"].Columns[0];
                ds.Tables["PN"].PrimaryKey = key1;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable load_TongTien_CTPN(string mapn)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select (ct.GIA*ct.SOLUONG) as tong from CT_PHIEUNHAP ct,PHIEUNHAP pn where ct.MAPN=pn.MAPN  and pn.MAPN='"+ mapn + "'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable dt_NguyenLieu(string mancc)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from NGUYENLIEU where  MANCC='" + mancc + "'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable dt_NhaCC()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from NHACC";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string taoID()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + "";
        }

        public double TongThanhTien(string mapn)
        {
            double tong = 0;
            foreach(DataRow row in ds.Tables["CTPN_ALL"].Rows)
            {
                if (row["MAPN"].ToString().Trim() == mapn)
                {
                    double sl = Convert.ToDouble(row["SOLUONG"]) / 1000;
                    tong = tong +(sl * Convert.ToInt32(row["GIA"]));

                }
            }
            return tong;
        }

        public int TongSoLuong(string mapn)
        {
            int tong = 0;
            foreach (DataRow row in ds.Tables["CTPN_ALL"].Rows)
            {
                if (row["MAPN"].ToString().Trim() == mapn)
                {
                    tong = tong + Convert.ToInt32(row["SOLUONG"]);

                }
            }
            return tong;
        }



        public bool add_CTPN(string mactpn,string mapn,string manl,string mancc, int gia,int sl)
        {
            try
            {
                DataSet call_nguyenlieu = dao_nl.ds_NguyenLieu();
                if (dao_nl.capNhat_NL_KhiThemPhieuNhap(manl, sl) == true)
                {
                    if (ds.Tables["CTPN_ALL"].Rows.Find(mactpn) == null)
                    {
                        //thêm chi tiết 
                        DataRow row = ds.Tables["CTPN_ALL"].NewRow();
                        row["MA_CTPN"] = mactpn;
                        row["MAPN"] = mapn;
                        row["MANGUYENLIEU"] = manl;
                        row["MANCC"] = mancc;
                        row["GIA"] = gia;
                        row["SOLUONG"] = sl;
                        ds.Tables["CTPN_ALL"].Rows.Add(row);
                        string sql = "select * from CT_PHIEUNHAP ";
                        da = db.Connect_Adapter(sql);
                        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                        da.Update(ds, "CTPN_ALL");
                        //cập nhật phiếu nhập
                        DataSet dsPN = ds_PhieuNhap();
                        if (ds.Tables["PN"].Rows.Find(mapn) != null)
                        {
                            DataRow pn = ds.Tables["PN"].Rows.Find(mapn);
                            pn["TONGTIEN"] = Convert.ToDouble(TongThanhTien(mapn));
                            pn["TONGSL"] = TongSoLuong(mapn);
                            string sql1 = "select * from PHIEUNHAP ";
                            da = db.Connect_Adapter(sql1);
                            SqlCommandBuilder cmd1 = new SqlCommandBuilder(da);
                            da.Update(ds, "PN");
                        }

                        return true;
                    }
                }
                
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_CTPN(string mactpn, string mapn, string manl, string mancc, int gia, int slcu,int slmoi)
        {
            try
            {
                DataSet call_nguyenlieu = dao_nl.ds_NguyenLieu();
                if (dao_nl.capNhat_NL_KhiSuaPhieuNhap(manl, slcu,slmoi) == true)
                {
                    if (ds.Tables["CTPN_ALL"].Rows.Find(mactpn) != null)
                    {
                        //cap nhat 
                        DataRow row = ds.Tables["CTPN_ALL"].Rows.Find(mactpn);
                        row["MANGUYENLIEU"] = manl;
                        row["MANCC"] = mancc;
                        row["GIA"] = gia;
                        row["SOLUONG"] = (Convert.ToInt32(row["SOLUONG"]) - slcu) + slmoi;
                        string sql = "select * from CT_PHIEUNHAP ";
                        da = db.Connect_Adapter(sql);
                        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                        da.Update(ds, "CTPN_ALL");
                        DataSet dsPN = ds_PhieuNhap();
                        if (ds.Tables["PN"].Rows.Find(mapn) != null)
                        {
                            DataRow pn = ds.Tables["PN"].Rows.Find(mapn);
                            pn["TONGTIEN"] = TongThanhTien(mapn);
                            pn["TONGSL"] = TongSoLuong(mapn);
                            string sql1 = "select * from PHIEUNHAP ";
                            da = db.Connect_Adapter(sql1);
                            SqlCommandBuilder cmd1 = new SqlCommandBuilder(da);
                            da.Update(ds, "PN");
                        }
                        return true;
                    }
                }
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool del_CTPN(string mactpn,string mapn,string manl,int gia, int sl)
        {
            try
            {
                DataSet call_nguyenlieu = dao_nl.ds_NguyenLieu();
                if (dao_nl.capNhat_NL_KhiXoaPhieuNhap(manl, sl) == true)
                {
                    if (ds.Tables["CTPN_ALL"].Rows.Find(mactpn) != null)
                    {

                        DataRow row = ds.Tables["CTPN_ALL"].Rows.Find(mactpn);
                        row.Delete();
                        string sql = "select * from CT_PHIEUNHAP ";
                        da = db.Connect_Adapter(sql);
                        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                        da.Update(ds, "CTPN_ALL");
                        DataSet dsPN = ds_PhieuNhap();
                        if (ds.Tables["PN"].Rows.Find(mapn) != null)
                        {
                            DataRow pn = ds.Tables["PN"].Rows.Find(mapn);
                            pn["TONGTIEN"] = TongThanhTien(mapn);
                            pn["TONGSL"] = TongSoLuong(mapn);
                            string sql1 = "select * from PHIEUNHAP ";
                            da = db.Connect_Adapter(sql1);
                            SqlCommandBuilder cmd1 = new SqlCommandBuilder(da);
                            da.Update(ds, "PN");
                        }

                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool del_All_CTPN(string mapn)
        {
            try
            {
                foreach(DataRow row in ds.Tables["CTPN_ALL"].Rows)
                {
                    if (row["MAPN"].ToString().Trim() == mapn)
                    {
                        row.Delete();
                    }
                }
                string sql = "select * from CT_PHIEUNHAP ";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "CTPN_ALL");


                //xoa phiếu nhập đó
                DataSet dsPN = ds_PhieuNhap();
                DataRow pn = ds.Tables["PN"].Rows.Find(mapn);
                pn.Delete();
                string sql1 = "select * from PHIEUNHAP ";
                da = db.Connect_Adapter(sql1);
                SqlCommandBuilder cmd1 = new SqlCommandBuilder(da);
                da.Update(ds, "PN");

                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
