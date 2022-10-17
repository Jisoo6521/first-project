using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyPhong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataTable dt= new DataTable();
        string str = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";

        void Loaddata()
        {
            conn.Open();
            cmd =conn.CreateCommand();
            cmd.CommandText= "Select MaPT, TenPT, MoTa, TinhTrang, LoaiPhong from Phong a, LoaiPhong b where a.MaLoaiPhong=b.MaLoaiPhong";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataPhong.DataSource = dt;
        }

        void LoadComboBox()
        {
            string sql = "Select * From LoaiPhong";
            DataTable dt1 = new DataTable();
            adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt1);
            comboBox1.DisplayMember = "LoaiPhong";
            comboBox1.ValueMember = "MaLoaiPhong";
            comboBox1.DataSource = dt1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            Loaddata();
            LoadComboBox();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            

        }
    }
}
