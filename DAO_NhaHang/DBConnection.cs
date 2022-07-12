using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    class DBConnection
    {
        public SqlConnection conn { get; set; }
        SqlDataAdapter da;
        public DBConnection()
        {
            conn = new SqlConnection("Data Source=LAPTOP-TH47IC1N;Initial Catalog = QUANLI_NHAHANG; User ID = sa; Password = 123");
        }

        public SqlDataAdapter Connect_Adapter(string sql)
        {
            return da = new SqlDataAdapter(sql, conn);
        }

     


    }
}
