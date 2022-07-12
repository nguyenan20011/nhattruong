using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_Menu
    {
        DBConnection db = new DBConnection();
        SqlDataAdapter da;

        public DataTable loadMenu(int vitri)
        {
            try
            {
                string sql = "select *from MON_AN ma,LOAI_MON lm where ma.MALOAI_MON=lm.MALOAI_MON and VITRI="+vitri;
                DataTable dt = new DataTable();
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }


        public DataTable dt_Mon_An()
        {
            try
            {
                string sql = "select MAMON,TENMON,GIA from MON_AN ";
                DataTable dt = new DataTable();
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable dt_CongThuc(string mamon)
        {
            try
            {
                string sql = "select ct.ID,nl.TEN_NGUYENLIEU,ct.KHOILUONG,ct.DVT from CONGTHUC ct,NGUYENLIEU nl where ct.MANGUYENLIEU=nl.MANGUYENLIEU and MAMON='"+mamon+"'";
                DataTable dt = new DataTable();
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }


        public DataRow queryBy_TENMON(string tenmon)
        {
            try
            {
                string sql = "select * from MON_AN where TENMON=N'" + tenmon+"'";
                DataTable dt = new DataTable();
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                DataRow row = dt.Rows[0] ;
                return row;
            }
            catch
            {
                return null;
            }
        }

    }
}
