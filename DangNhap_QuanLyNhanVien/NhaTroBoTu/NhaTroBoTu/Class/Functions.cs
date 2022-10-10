using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaTroBoTu.Class
{
    public class Functions
    {
        public static SqlConnection conn;
        public static void KetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=PC-NEYUGN666;
            Initial Catalog=QlyTroBoTu;Integrated Security=True";
            //conn.ConnectionString = @"Data Source=PC-NEYUGN666;AttachDbFilename=QlyTroBoTu" 
            //    + Application.StartupPath + 
            //    @"QlyTroBoTu.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            conn.Open();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Kết Nối Thành Công");
            }
            else
            {
                MessageBox.Show("Kết Nối Thất Bại");
            }
        }

        public static void NgatKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable LayDuLieu(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            //dap.SelectCommand = new SqlCommand();
            //dap.SelectCommand.Connection = Functions.conn;
            //dap.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

    }
}
