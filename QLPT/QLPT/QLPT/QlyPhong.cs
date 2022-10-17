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
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

namespace QLPT
{

    public partial class QlyPhong : Form
    {
        public QlyPhong()
        {
            InitializeComponent();
        }
        string str = "Data Source=PC-NEYUGN666;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        string sql;
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter dap;
        SqlDataReader docdulieu;


        void LoadDSPhong()
        {
            listView1.Items.Clear();
            conn.Open();
            sql = "Select MaPT, TenPT, MoTa, TinhTrang, LoaiPhong from Phong a, LoaiPhong b where a.MaLoaiPhong=b.MaLoaiPhong";
            cmd = new SqlCommand(sql, conn);
            docdulieu = cmd.ExecuteReader();
            int i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            conn.Close();
        }
        void LayLoaiPhongLenComboBox()
        {
            sql = "Select * From LoaiPhong";
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(sql, conn);
            dap.Fill(dt);
            comboBox1.DisplayMember = "LoaiPhong";
            comboBox1.ValueMember = "MaLoaiPhong";
            comboBox1.DataSource = dt;
        }
        

        private void QlyPhong_Load(object sender, EventArgs e)
        {
            rdbTimKiemMa.Visible = false;
            rdbTimKiemTen.Visible = false;
            txtTim.Visible = false;
            btnTim.Visible = false;
            conn = new SqlConnection(str);
            LayLoaiPhongLenComboBox();
            LoadDSPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text ==""||txtTenPT.Text==""||txtMoTa.Text==""||txtTT.Text=="")
            {
                MessageBox.Show("Bạn vui lòng nhập đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listView1.Items.Clear();
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = @"Insert Into Phong values (N'" + txtMaPT.Text + "', N'" + txtTenPT.Text + "', N'" + txtMoTa +@"', N'" + txtTT.Text + "', N'" + comboBox1.SelectedItem + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadDSPhong();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                listView1.Items.Clear();
                conn.Open();
                cmd = new SqlCommand(str, conn);
                cmd.CommandText = "delete from Phong where MaPT = N'" + txtMaPT.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadDSPhong();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            cmd =new SqlCommand(str, conn);
            cmd.CommandText = @"Update Phong set '"+ txtMaPT.Text+"', N'"+txtTenPT.Text+"', N'"+txtMoTa.Text+"', N'"+txtTT.Text+"', N'"+comboBox1.SelectedItem+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDSPhong();
        }
        void loadtimma()
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            rdbTimKiemTen.Visible = true;
            rdbTimKiemMa.Visible = true;
            txtTim.Visible = true;
            btnTim.Visible = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            rdbTimKiemMa.Visible = false;
            rdbTimKiemTen.Visible = false;
            txtTim.Visible = false;
            btnTim.Visible = false;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtMaPT.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtTenPT.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtMoTa.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtTT.Text = listView1.SelectedItems[0].SubItems[3].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }
    }
}

