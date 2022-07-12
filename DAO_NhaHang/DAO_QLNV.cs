using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_QLNV
    {
        DBConnection db = new DBConnection();
        DataSet ds =new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public DataSet loadNhanVien()
        {
            try
            {
                string sql = "select *from NHANVIEN";
                da = db.Connect_Adapter(sql);
                da.Fill(ds,"NV");
                key[0] = ds.Tables["NV"].Columns[0];
                ds.Tables["NV"].PrimaryKey = key;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable loadChucVu()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select CHUCVU from NHANVIEN group by CHUCVU";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable timNhanVien(string tennv)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select *from NHANVIEN where LOWER(TENNV) LIKE LOWER(N'%"+tennv+"%')";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }



        public bool  insert_NV(string manv,string hoten,string diachi,string gioitinh,string ngaysinh,string sdt,string chucvu,int luongcb)
        {
            try
            {
                if (ds.Tables["NV"].Rows.Find(manv) == null)
                {
                    DataRow newrow = ds.Tables["NV"].NewRow();
                    newrow["MANV"] = manv;
                    newrow["TENNV"] = hoten;
                    newrow["DIACHI"] = diachi;
                    newrow["GIOITINH"] = gioitinh;
                    newrow["NGAYSINH"] = ngaysinh;
                    newrow["SDT"] = sdt;
                    newrow["CHUCVU"] = chucvu;
                    newrow["LUONGCB"] = luongcb;
                    ds.Tables["NV"].Rows.Add(newrow);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds,"NV");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void luuThayDoi()
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Update(ds, "NV");
        }
       

        public bool update_NV(string manv, string hoten, string diachi, string gioitinh, string ngaysinh, string sdt, string chucvu,int luongcb)
        {
            try
            {
                if (ds.Tables["NV"].Rows.Find(manv) != null)
                {
                    DataRow newrow = ds.Tables["NV"].Rows.Find(manv);
                    newrow["TENNV"] = hoten;
                    newrow["DIACHI"] = diachi;
                    newrow["GIOITINH"] = gioitinh;
                    newrow["NGAYSINH"] = ngaysinh;
                    newrow["SDT"] = sdt;
                    newrow["CHUCVU"] = chucvu;
                    newrow["LUONGCB"] =luongcb;
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds, "NV");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
