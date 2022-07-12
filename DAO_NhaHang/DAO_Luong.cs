using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_Luong
    {
        DBConnection db = new DBConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];


        public DataSet ds_Luong()
        {
            try
            {
                string sql = "select * from LUONG";
                da = db.Connect_Adapter(sql);
                da.Fill(ds, "LUONG");
                key[0] = ds.Tables["LUONG"].Columns["MALUONG"];
                ds.Tables["LUONG"].PrimaryKey = key;
                return ds;
            }
            catch
            {
                return null;
            }
        }



        public DataTable dt_Luong(string manv)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from LUONG where MANV='" + manv + "'  order by  NGAY DESC";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

       public bool ktVaoLam(string manv)
        {
            DataTable dt = dt_Luong(manv);
            foreach (DataRow row in dt.Rows)
            {
                if (row["MANV"].ToString().Trim() == manv && Convert.ToDateTime(row["NGAY"]) == DateTime.Now.Date)
                {
                    if (Convert.ToInt32(row["THOIGIANRA"]) == 0 && Convert.ToInt32(row["THOIGIANVAO"]) > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public double tinhTongLuongThangHienTai(string manv)
        {
            try
            {
                double tong = 0;
                DataTable dt = new DataTable();
                string sql = "select * from LUONG where MANV='" + manv + "'  and MONTH(NGAY)=MONTH(GETDATE())";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    tong += Convert.ToDouble(row["LUONGNGAY"]);
                }
                return tong;

            }
            catch
            {
                return 0;
            }
        }


        public bool themGioVaoCa(string maluong,string manv)
        {
            try
            {

                if (ds.Tables["LUONG"].Rows.Find(maluong) == null)
                {
                    DataRow row = ds.Tables["LUONG"].NewRow();
                    row["MALUONG"] = maluong;
                    row["MANV"] = manv;
                    row["THOIGIANVAO"] = Convert.ToInt32(DateTime.Now.Hour);
                    row["PHUTVAO"]= Convert.ToInt32(DateTime.Now.Minute);
                    row["THOIGIANRA"] = 0;
                    row["PHUTRA"] = 0;
                    row["SOGIOLAM"] = 0;
                    row["NGAY"] = DateTime.Now.Date;
                    row["KHAUTRU"] =0;
                    row["LUONGNGAY"] = 0;
                    ds.Tables["LUONG"].Rows.Add(row);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds, "LUONG");
                    return true;
                }
                return false;
              
            }
            catch
            {
                return false;
            }
        }

        public bool themGioRaCa(string manv,int luongcb)
        {
            try
            {
                foreach (DataRow row in ds.Tables["LUONG"].Rows)
                {
                    if(row["MANV"].ToString().Trim()==manv && Convert.ToDateTime(row["NGAY"])== DateTime.Now.Date && Convert.ToInt32(row["LUONGNGAY"])==0)
                    {
                        row["THOIGIANRA"] = Convert.ToInt32(DateTime.Now.Hour);
                        row["PHUTRA"]= Convert.ToInt32(DateTime.Now.Minute);
                        int t = Convert.ToInt32(row["PHUTRA"]) - Convert.ToInt32(row["PHUTVAO"]);
                        double phut = (double)t / 60;
                        double gio = Convert.ToInt32(row["THOIGIANRA"]) - Convert.ToInt32(row["THOIGIANVAO"]);
                        row["SOGIOLAM"] = gio+Math.Round(phut,2);
                        row["LUONGNGAY"] =(luongcb * Convert.ToDouble(row["SOGIOLAM"])) - Convert.ToInt32(row["KHAUTRU"]);
                        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                        da.Update(ds, "LUONG");
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
        public bool xoaLuong(string maluong)
        {
            try
            {

                if (ds.Tables["LUONG"].Rows.Find(maluong) != null)
                {
                    DataRow row = ds.Tables["LUONG"].Rows.Find(maluong);
                    row.Delete();
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds, "LUONG");
                    return true;
                }
                return false;

            }
            catch
            {
                return false;
            }
        }

        public bool xoaLuongTheoMaNV(string manv)
        {
            try
            {
                foreach(DataRow row in ds.Tables["LUONG"].Rows)
                {
                    if (row["MANV"].ToString().Trim() == manv.Trim())
                    {
                        row.Delete();
                    }
                }
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "LUONG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themKhauTru(string maluong,int khautru)
        {
            try
            {

                if (ds.Tables["LUONG"].Rows.Find(maluong) != null)
                {
                    DataRow row = ds.Tables["LUONG"].Rows.Find(maluong);
                    row["KHAUTRU"]=khautru;

                    double luongngay = Convert.ToDouble(row["LUONGNGAY"]) - khautru;
                    if (luongngay > 0)
                    {
                        row["LUONGNGAY"] = luongngay;

                    }
                    else
                    {
                        row["LUONGNGAY"] = 0;
                    }
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds, "LUONG");
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
