using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_DangNhap
    {
        DBConnection db = new DBConnection();
        DataSet ds;
        SqlDataAdapter da;

        public DataRow loadThongTinNV(string tk,string mk)
        {
            try
            {
                string sql = "select * from DOI_TUONG dt,NHANVIEN nv where dt.MANV=nv.MANV and TAIKHOAN='" + tk+"' AND MATKHAU='"+mk+"'";
                ds = new DataSet();
                da = db.Connect_Adapter(sql);
                da.Fill(ds);
                DataRow row = ds.Tables[0].Rows[0];
                return row;
            }
            catch
            {
                return null;
            }
        }
        public DataTable checkuser(string tk)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from DOI_TUONG where TAIKHOAN='" + tk + "'";
                ds = new DataSet();
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
