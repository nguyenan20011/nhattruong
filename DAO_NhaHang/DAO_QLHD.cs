using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_QLHD
    {
        DBConnection db = new DBConnection();
        DataSet ds=new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        DataColumn[] pk_cthd = new DataColumn[2];

        public DataSet loadAllHoaDon()
        {
            try
            {
                string sql = "select * from HOADON order by NGAY DESC";
                da = db.Connect_Adapter(sql);
                da.Fill(ds,"HD_ALL");
                key[0] = ds.Tables["HD_ALL"].Columns["MAHD"];
                ds.Tables["HD_ALL"].PrimaryKey = key;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadDoanhThu_Ngay(string day,string month,string year)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql =" select * from HOADON where DAY(NGAY) = '"+day+ "' and MONTH(NGAY)= '" + month + "' and YEAR(NGAY)='" + year + "'";
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

        public bool add_HoaDon(string mahd,string manv,string ngay,int tongmon,int tongtien)
        {

            try
            {
                if (ds.Tables["HD_ALL"].Rows.Find(mahd) == null)
                {

                    DataRow row = ds.Tables["HD_ALL"].NewRow();
                    row["MAHD"] = mahd;
                    row["MANV"] = manv;
                    row["NGAY"] = ngay;
                    row["TONGMON"] = tongmon;
                    row["TONGTIEN"] = tongtien;
                    ds.Tables["HD_ALL"].Rows.Add(row);
                }
                else
                {
                    DataRow row = ds.Tables["HD_ALL"].Rows.Find(mahd);
                    row["NGAY"] = ngay;
                    row["TONGMON"] = tongmon;
                    row["TONGTIEN"] = tongtien;
                }
                string sql = "select * from HOADON order by NGAY DESC";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds,"HD_ALL");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataSet ds_CT_HoaDon()
        {
            try
            {
                string sql = "select * from CT_HOADON";
                da = db.Connect_Adapter(sql);
                da.Fill(ds, "CTHD_ALL");
                pk_cthd[0] = ds.Tables["CTHD_ALL"].Columns[0];
                ds.Tables["CTHD_ALL"].PrimaryKey = pk_cthd;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public bool add_CT_HoaDon(string mahd,string mamon,int sl,int gia)
        {
            try
            {
                string macthd = taoID();

                DataRow row = ds.Tables["CTHD_ALL"].NewRow();
                row["MA_CTHD"] = macthd;
                row["MAHD"] = mahd;
                row["MAMON"] = mamon;
                row["SOLUONG"] = sl;
                row["GIA"] = gia;

                ds.Tables["CTHD_ALL"].Rows.Add(row);
                string sql = "select * from CT_HOADON";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "CTHD_ALL");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteAll_CT_HoaDonByMaHD(string mahd)
        {
            try
            {
                foreach(DataRow row in ds.Tables["CTHD_ALL"].Rows)
                {
                    if (row["MAHD"].ToString() == mahd)
                            row.Delete();
                }
                string sql = "select * from CT_HOADON";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "CTHD_ALL");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable dt_CT_HoaDon(string mahd)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select *from CT_HOADON where MAHD='"+mahd+"'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable dt_CT_HoaDonCu(string mahd)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select ct.MAMON,ma.TENMON,ct.SOLUONG,ct.GIA from CT_HOADON ct,MON_AN ma where ct.MAMON=ma.MAMON and ct.MAHD='" + mahd + "'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadTennv()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select TENNV,hd.MANV from HOADON hd ,NHANVIEN nv where hd.MANV=nv.MANV group by TENNV,hd.MANV";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadHoaDonByManv(string manv)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from HOADON where MANV='"+manv+"'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }


        public DataTable loadNgay()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select DAY(NGAY) as NGAY from HOADON  group by DAY(NGAY)";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadThang()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select MONTH(NGAY) as THANG from HOADON  group by MONTH(NGAY)";

                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadNam()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select YEAR(NGAY) as NAM from HOADON  group by YEAR(NGAY)";

                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

    }
}
