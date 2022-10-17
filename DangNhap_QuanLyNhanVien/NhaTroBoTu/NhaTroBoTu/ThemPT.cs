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
    public partial class ThemPT : Form
    {
        public ThemPT()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        string s = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter dap = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void btnCancelKH_Click(object sender, EventArgs e)
        {
            DSPhong dSPhong = new DSPhong();
            this.Hide();
            dSPhong.ShowDialog();
        }

        void loaddata()
        {
            cmd=conn.CreateCommand();
            cmd.CommandText= "Select MaPT, TenPT, LoaiPhong, TinhTrang, MoTa " +
                "from Phong, LoaiPhong where Phong.MaLoaiPhong=LoaiPhong.MaLoaiPhong";
            dap.SelectCommand = cmd;
            dt.Clear();
            dap.Fill(dt);
            dataThemPT.DataSource = dt;
        }

        private void ThemPT_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(s);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from LoaiPhong";
            dap.SelectCommand = cmd;
            dap.Fill(table1);
            cmbLoaiPhong.DataSource = table1;
            cmbLoaiPhong.DisplayMember = "LoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbLoaiPhong.Text = "MaLoaiPhong";
            conn.Open();
            loaddata();
        }

        private void dataThemPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataThemPT.CurrentRow.Index;
            txtThemMAPT.Text = dataThemPT.Rows[i].Cells[0].ToString();
            txtThemTENPT.Text = dataThemPT.Rows[i].Cells[1].ToString();
            txtThemTT.Text= dataThemPT.Rows[i].Cells[2].ToString();
            txtThemMoTaPT.Text = dataThemPT.Rows[i].Cells[3].ToString();
            string LoaiPhong = dataThemPT.CurrentRow.Cells[4].ToString();
            cmbLoaiPhong.Text = LoaiPhong;
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into Phong values('" + txtThemMAPT.Text + "' , N'" + txtThemTENPT.Text + "' ,N'" + txtThemMoTaPT.Text + "',N'" + cmbLoaiPhong.SelectedValue.ToString()+ "',)";
            cmd.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm thành công","Thông báo", MessageBoxButtons.OK);
        }
    }
}
