using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_QLPN
    {
        DBConnection db = new DBConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public DataSet ds_PhieuNhap()
        {
            try
            {
                string sql = "select * from PHIEUNHAP";
                da = db.Connect_Adapter(sql);
                da.Fill(ds, "PN");
                key[0] = ds.Tables["PN"].Columns["MAPN"];
                ds.Tables["PN"].PrimaryKey = key;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable dt_PhieuNhap_NhanVien()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select nv.TENNV,pn.* from PHIEUNHAP pn,NHANVIEN nv where pn.MANV=nv.MANV order by NGAYNHAP DESC";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadPhieuNhap_Ngay(string day, string month, string year)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = " select * from PHIEUNHAP where DAY(NGAYNHAP) = '" + day + "' and MONTH(NGAYNHAP)= '" + month + "' and YEAR(NGAYNHAP)='" + year + "'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadPhieuNhap_Year()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select YEAR(NGAYNHAP) from PHIEUNHAP group by YEAR(NGAYNHAP) order by YEAR(NGAYNHAP) DESC ";
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

        public bool add_PhieuNhap(string manv,string noidung)
        {
            try
            {
                DataRow row= ds.Tables["PN"].NewRow();
                row["MAPN"] = taoID();
                row["NGAYNHAP"] = DateTime.Now.ToString();
                row["MANV"] = manv;
                row["TONGTIEN"] = 0;
                row["TONGSL"] = 0;
                row["NOIDUNG"] = noidung;
                ds.Tables["PN"].Rows.Add(row);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds,"PN");
                return true;    
            }
            catch
            {
                return false;
            }
        }

        public bool xoa_PhieuNhap(string mapn)
        {
            try
            {
                if (ds.Tables["PN"].Rows.Find(mapn) != null)
                {
                    DataRow row = ds.Tables["PN"].Rows.Find(mapn);
                    row.Delete();
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds,"PN");
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool sua_PhieuNhap(string mapn, string manv, string noidung)
        {
            try
            {
                if (ds.Tables["PN"].Rows.Find(mapn) != null)
                {
                    DataRow row = ds.Tables["PN"].Rows.Find(mapn);
                    row["NGAYNHAP"] = DateTime.Now.ToString();
                    row["MANV"] = manv;
                    row["NOIDUNG"] = noidung;
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds,"PN");
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
