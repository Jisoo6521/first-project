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
    public partial class XoaPhong : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public XoaPhong()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaPT, TenPT, LoaiPhong, TinhTrang, MoTa " +
                "from Phong, LoaiPhong where Phong.MaLoaiPhong=LoaiPhong.MaLoaiPhong";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataXoaPhong.DataSource = dt;
        }

        private void btnCanceThemPT_Click(object sender, EventArgs e)
        {
            DSPhong dSPhong = new DSPhong();
            Hide();
            dSPhong.Show();
            this.Close();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from Phong where MaPT= '" + txtMAPT.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void XoaPhong_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ChucVuNV";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            cmbLoaiPhong.DataSource = table1;
            cmbLoaiPhong.DisplayMember = "LoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbLoaiPhong.SelectedItem = null;
            cmbLoaiPhong.Text = "";
            conn.Open();
            loaddata();
        }

        private void dataXoaPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataXoaPhong.CurrentRow.Index;
            txtMAPT.Text = dataXoaPhong.Rows[i].Cells[0].Value.ToString();
            txtTENPT.Text = dataXoaPhong.Rows[i].Cells[1].Value.ToString();
            string LoaiPhong = dataXoaPhong.CurrentRow.Cells[2].Value.ToString();
            cmbLoaiPhong.Text = LoaiPhong;
            txtTT.Text = dataXoaPhong.Rows[i].Cells[3].Value.ToString();
            txMoTaPT.Text = dataXoaPhong.Rows[i].Cells[4].Value.ToString();
        }
    }
}
