using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaTroBoTu
{
    public partial class TimPhong : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string s = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public TimPhong()
        {
            InitializeComponent();
        }

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText= "Select MaPT, TenPT, LoaiPhong, MoTa, TinhTrang " +
                "from Phong, LoaiPhong where Phong.MaLoaiPhong=LoaiPhong.MaLoaiPhong";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimPT.DataSource = dt;
        }

        private void TimPhong_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnTimKiemPT_Click(object sender, EventArgs e)
        {
            if (txtTimPT.Text == "")
            {
                MessageBox.Show("Mời nhập thông tin bạn tìm", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (rdMaPT.Checked)
                {
                    loadData();
                }
                if (rdTenPT.Checked)
                {
                    loadData();
                }
            }
        }
    }
}
