using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO_NhaHang
{
    public class DAO_ChonBan
    {
        DBConnection db = new DBConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] pk_tam = new DataColumn[1];
        DataColumn[] pk_ct = new DataColumn[1];

        public DataSet dsTam()
        {
            try
            {
                string sql = "select *from TAM";
                da = db.Connect_Adapter(sql);
                da.Fill(ds,"TAM");
                pk_tam[0] = ds.Tables["TAM"].Columns[0];
                ds.Tables["TAM"].PrimaryKey = pk_tam;
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public DataSet dsCT_Tam()
        {
            try
            {
                string sql = "select *from CT_TAM";
                da = db.Connect_Adapter(sql);
                da.Fill(ds,"CT_TAM");
                pk_ct[0] = ds.Tables["CT_TAM"].Columns[0];
                ds.Tables["CT_TAM"].PrimaryKey = pk_ct;
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool add_TAM(int soban,string manv,string makh,string ngay,int tongmon,int tongtien)
        {
            DataTable dsTAM = ds.Tables["TAM"];
            try
            {
                DataRow row = dsTAM.NewRow();
                row["SOBAN"] = soban;
                row["MANV"] = manv;
                row["NGAY"] = ngay;
                row["TONGMON"] = tongmon;
                row["TONGTIEN"] = tongtien;
                dsTAM.Rows.Add(row);
                string sql = "select *from TAM";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dsTAM);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool add_CT_TAM(string id, int soban, string mamon,int sl, int gia)
        {
            DataTable dsCTTAM = ds.Tables["CT_TAM"];
            try
            {
                DataRow row = dsCTTAM.NewRow();
                row["id"] = id;
                row["SOBAN"] = soban;
                row["MAMON"] = mamon;
                row["SOLUONG"] = sl;
                row["GIA"] = gia;
                dsCTTAM.Rows.Add(row);
                string sql = "select *from CT_TAM";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dsCTTAM);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktSoBan(string soban)
        {
            DataTable TAM = ds.Tables["TAM"];
            try
            {
                if (TAM.Rows.Find(soban) != null)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public DataTable load_CTTAM_By_Soban(string soban)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select *from CT_TAM where SOBAN='"+soban+"'";
                da = db.Connect_Adapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataRow load_TAM_By_Soban(string soban)
        {
            try
            {
                DataRow row = ds.Tables["TAM"].Rows.Find(soban);
                if (row != null)
                    return row;
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool delete_TAM(string soban)
        {
            try
            {
                DataRow row = ds.Tables["TAM"].Rows.Find(soban);
                row.Delete();
                //foreach (DataRow row in ds.Tables["CTHD_ALL"].Rows)
                //{
                //    if (row["MAHD"].ToString() == mahd)
                //        row.Delete();
                //}
                string sql = "select * from TAM";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "TAM");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete_CT_TAM(string soban)
        {
            try
            {
                foreach (DataRow row in ds.Tables["CT_TAM"].Rows)
                {
                    if (row["SOBAN"].ToString() == soban)
                        row.Delete();
                }
                string sql = "select * from CT_TAM";
                da = db.Connect_Adapter(sql);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "CT_TAM");
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
