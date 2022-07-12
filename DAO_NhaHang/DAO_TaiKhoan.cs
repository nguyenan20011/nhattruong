using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_TaiKhoan
    {
        DBConnection db = new DBConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public DataSet ds_TaiKhoan()
        {
            try
            {
                string sql = "select * from DOI_TUONG";
                da = db.Connect_Adapter(sql);
                da.Fill(ds, "TK");
                key[0] = ds.Tables["TK"].Columns["TAIKHOAN"];
                ds.Tables["TK"].PrimaryKey = key;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataRow dt_TaiKhoan(string manv)
        {
            try
            {
                if (manv != null)
                {
                    DataTable dt = new DataTable();
                    string sql = "select * from DOI_TUONG where MANV='"+manv+"'";
                    da = db.Connect_Adapter(sql);
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    return row;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool add_TK(string tk, string mk, string manv,string quyen)
        {
            try
            {
                if (ds.Tables["TK"].Rows.Find(tk) == null)
                {
                    DataRow row = ds.Tables["TK"].NewRow();
                    row["TAIKHOAN"] =tk;
                    row["MATKHAU"] = mk;
                    row["MANV"] = manv;
                    row["QUYEN"] = quyen;
                    ds.Tables["TK"].Rows.Add(row);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds,"TK");
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool doi_TK(string tk, string mk)
        {
            try
            {
                if (ds.Tables["TK"].Rows.Find(tk) != null)
                {
                    DataRow row = ds.Tables["TK"].Rows.Find(tk);
                    row["MATKHAU"] = mk;
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds,"TK");
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool capNhatQuyen(string manv)
        {
            try
            {
                foreach (DataRow row in ds.Tables["TK"].Rows)
                {
                    if (row["MANV"].ToString().Trim() == manv.Trim())
                    {
                        row["QUYEN"] = "ADMIN";
                        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                        da.Update(ds, "TK");
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

        public bool xoa_TK(string manv)
        {
            try
            {
               foreach(DataRow row in ds.Tables["TK"].Rows)
                {
                    if (row["MANV"].ToString().Trim() == manv.Trim())
                    {
                        row.Delete();
                    }
                }
               
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "TK");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
