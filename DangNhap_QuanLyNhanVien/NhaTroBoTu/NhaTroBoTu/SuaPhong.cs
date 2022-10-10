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
    public partial class SuaPhong : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string s = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter dap = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public SuaPhong()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaPT, TenPT, LoaiPhong, TinhTrang, MoTa " +
                "from Phong, LoaiPhong where Phong.MaLoaiPhong=LoaiPhong.MaLoaiPhong";
            dap.SelectCommand = cmd;
            dt.Clear();
            dap.Fill(dt);
            dataSuaPT.DataSource = dt;
        }

        private void SuaPhong_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(s);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from LoaiPhong";
            dap.SelectCommand = cmd;
            dap.Fill(table1);
            cmbSuaLoaiPhong.DataSource = table1;
            //cmbSuaLoaiPhong.DisplayMember = "LoaiPhong";
            //cmbSuaLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbSuaLoaiPhong.Text = "";
            conn.Open();
            loaddata();
        }

        private void dataSuaPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataSuaPT.CurrentRow.Index;
            txtSuaMaPhong.Text = dataSuaPT.Rows[i].Cells[0].ToString();
            txtSuaTenPhong.Text = dataSuaPT.Rows[i].Cells[1].ToString();
            txtSuaTT.Text = dataSuaPT.Rows[i].Cells[2].ToString();
            txtSuaMoTa.Text = dataSuaPT.Rows[i].Cells[3].ToString();
            string LoaiPhong = dataSuaPT.CurrentRow.Cells[4].ToString();
            cmbSuaLoaiPhong.Text = LoaiPhong;
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update into Phong values('" + txtSuaMaPhong.Text + "' , N'" + txtSuaTenPhong.Text + "' ,N'" + txtSuaMoTa.Text + "',N'" + cmbSuaLoaiPhong.SelectedValue.ToString() + "',)";
            cmd.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnCanceSuaPT_Click(object sender, EventArgs e)
        {
            DSPhong dSPhong = new DSPhong();
            Hide();
            dSPhong.ShowDialog();
            this.Close();
        }
    }
}
