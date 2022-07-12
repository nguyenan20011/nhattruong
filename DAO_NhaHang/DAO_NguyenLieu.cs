using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public class DAO_NguyenLieu
    {
        DBConnection db = new DBConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        public DataSet ds_NguyenLieu()
        {
            try
            {
                string sql = "select * from NGUYENLIEU";
                da = db.Connect_Adapter(sql);
                da.Fill(ds, "NL");
                key[0] = ds.Tables["NL"].Columns["MANGUYENLIEU"];
                ds.Tables["NL"].PrimaryKey = key;
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataTable layCongThucTheoMaMon(string mamon)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from CONGTHUC where MAMON='"+mamon+"'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataRow layTenMonTheoMaMon(string mamon)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from MON_AN where MAMON='" + mamon + "'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                DataRow row = dt.Rows[0];
                return row;
            }
            catch
            {
                return null;
            }
        }

        public string ktKhoiLuongKho(string mamon, int soluong)
        {
            try
            {
                DataTable tbl_congthuc = layCongThucTheoMaMon(mamon);
                foreach (DataRow row_ct in tbl_congthuc.Rows)
                {
                    foreach (DataRow row_nl in ds.Tables["NL"].Rows)
                    {
                        if (row_ct["MANGUYENLIEU"].ToString() == row_nl["MANGUYENLIEU"].ToString())
                        {
                            int kl_conlai = Convert.ToInt32(row_nl["KL_CONLAI"]) - (Convert.ToInt32(row_ct["KHOILUONG"]) * soluong);
                            if (kl_conlai >= 0)
                            {
                                break;
                            }
                            else
                            {
                                DataRow row_monAn = layTenMonTheoMaMon(row_ct["MAMON"].ToString().Trim());
                                return row_nl["TEN_NGUYENLIEU"] + " không đủ khối lượng cho món " + row_monAn["TENMON"];
                            }
                        }
                    }
                }
                return null;
            }
            catch
            {
                return "error";
            }
        }

        public string capNhat_KhoiLuongConLai(string mamon,int soluong)
        {
            try
            {
                string responseFromktKhoiLuong = ktKhoiLuongKho(mamon, soluong);
                if (responseFromktKhoiLuong == null)
                {

                    DataTable tbl_congthuc = layCongThucTheoMaMon(mamon);
                    foreach(DataRow row_ct in tbl_congthuc.Rows)
                    {
                        foreach(DataRow row_nl in ds.Tables["NL"].Rows)
                        {
                            if (row_ct["MANGUYENLIEU"].ToString() == row_nl["MANGUYENLIEU"].ToString())
                            {
                                int kl_conlai = Convert.ToInt32(row_nl["KL_CONLAI"]) - (Convert.ToInt32(row_ct["KHOILUONG"]) * soluong);
                                if(kl_conlai >= 0)
                                {
                                    row_nl["KL_CONLAI"] = kl_conlai;
                                    string sql = "select * from NGUYENLIEU";
                                    da = db.Connect_Adapter(sql);
                                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                                    da.Update(ds, "NL");
                                    break;
                                }
                            }
                        }
                    }
                    return "OK";
                }
                return responseFromktKhoiLuong;
            }
            catch
            {
                return "lỗi";
            }
        }

        public bool capNhat_NL_KhiThemPhieuNhap(string manl ,int khoiluong)
        {
            try
            {
                if (ds.Tables["NL"].Rows.Find(manl) != null)
                {
                    DataRow row = ds.Tables["NL"].Rows.Find(manl);
                    row["KL_CONLAI"] = Convert.ToInt32(row["KL_CONLAI"]) + khoiluong;
                    string sql = "select * from NGUYENLIEU";
                    da = db.Connect_Adapter(sql);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds, "NL");
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool capNhat_NL_KhiXoaPhieuNhap(string manl, int khoiluong)
        {
            try
            {
                if (ds.Tables["NL"].Rows.Find(manl) != null)
                {
                    DataRow row = ds.Tables["NL"].Rows.Find(manl);

                    int kl_conlai = Convert.ToInt32(row["KL_CONLAI"]) - khoiluong;
                    if (kl_conlai >= 0)
                    {
                        row["KL_CONLAI"] = Convert.ToInt32(row["KL_CONLAI"]) - khoiluong;
                        string sql = "select * from NGUYENLIEU";
                        da = db.Connect_Adapter(sql);
                        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                        da.Update(ds, "NL");
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

        public bool capNhat_NL_KhiSuaPhieuNhap(string manl, int kl_cu,int kl_moi)
        {
            try
            {
                if (ds.Tables["NL"].Rows.Find(manl) != null)
                {
                    DataRow row = ds.Tables["NL"].Rows.Find(manl);
                    row["KL_CONLAI"] = (Convert.ToInt32(row["KL_CONLAI"]) - kl_cu) + kl_moi;
                    string sql = "select * from NGUYENLIEU";
                    da = db.Connect_Adapter(sql);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds, "NL");
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
