using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLPT
{
    class Database
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;

        public Database()
        {
            string str = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";
            conn = new SqlConnection(str);
            conn.Open();
            //return;
        }

        public DataTable Execute(string str)
        {
            adapter = new SqlDataAdapter(str, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string str)
        {
            SqlCommand cmd = new SqlCommand(str, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
