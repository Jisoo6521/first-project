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
using System.Data.Entity;
using WinFormsApp1;
using System.Dynamic;

namespace NhaTroBoTu
{
    public partial class DSPhong : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string s = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tbpt = new DataTable();
        Database db;
        public DSPhong()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaPT, TenPT, LoaiPhong, MoTa, TinhTrang " +
                "from Phong, LoaiPhong where Phong.MaLoaiPhong=LoaiPhong.MaLoaiPhong";
            adapter.SelectCommand = cmd;
            tbpt.Clear();
            adapter.Fill(tbpt);
            dataDSPT.DataSource = tbpt;
        }


        private void DSPhong_Load(object sender, EventArgs e)   
        {
            //DataTable table1 = new DataTable();
            conn = new SqlConnection(s);
            //cmd = conn.CreateCommand();
            //cmd.CommandText = ("Select * from LoaiPhong");
            //adapter.SelectCommand = cmd;
            //adapter.Fill(table1);
            //cmbLoaiPhong.DataSource = table1;
            //cmbLoaiPhong.DisplayMember = "LoaiPhong";
            //cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            //cmbLoaiPhong.SelectedItem = null;
            //cmbLoaiPhong.Text = "";
            loaddata();
        }

        private void dataDSPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    if (btnThemPT.Enabled == false)
            //    {
            //        MessageBox.Show("Đang ở chế độ thêm mới!","Thông Báo",MessageBoxButtons.OK);
            //        txtMaPT.Focus();
            //        return;
            //    }
            //    if (tbpt.Rows.Count ==0)
            //    {
            //        MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
            //        return;
            //    }
            //    txtMaPT.Text = dataDSPT.CurrentRow.Cells["MaPT"].Value.ToString();
            //    txtTenPT.Text = dataDSPT.CurrentRow.Cells["TenPT"].Value.ToString();
        }

        private void btnThoatDSPT_Click(object sender, EventArgs e)
        {
            MenuQlyPhong menuQlyPhong = new MenuQlyPhong();
            Hide();
            menuQlyPhong.ShowDialog();
        }

        private void btnTimKiemPT_Click(object sender, EventArgs e)
        {
            TimPhong timPhong = new TimPhong();
            this.Hide();
            timPhong.ShowDialog();
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            ThemPT themPT = new ThemPT();
            themPT.ShowDialog();
        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        { 
            XoaPhong xoaPhong = new XoaPhong();
            Hide();
            xoaPhong.ShowDialog();
            this.Close();
            //try
            //{
            //    conn.Open();
            //    int i = dataDSPT.CurrentCell.RowIndex;
            //    string MaPT = Convert.ToString(dataDSPT.Rows[i].Cells[0].Value.ToString());
            //    string delete = "Delete from Phong where MaPT= " + MaPT + "'";
            //    SqlCommand deletecmd = new SqlCommand(delete, conn);
            //    deletecmd.CommandType = CommandType.Text;
            //    deletecmd.ExecuteNonQuery();
            //    adapter.Update(ds, "Phong");
            //    loaddata();
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnSuaPT_Click(object sender, EventArgs e)
        {

        }
    }
}
