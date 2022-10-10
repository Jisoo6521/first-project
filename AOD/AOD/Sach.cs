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

namespace AOD
{
    public partial class Sach : Form
    {
        SqlConnection conn = new SqlConnection();
        DataTable dt;
        string s = "Data Source=LAPTOP-1R2HA659;Initial Catalog=QLTHUVIEN;Integrated Security=True";

        public bool KetNoi(string server, string database)
        {
            try
            {
                conn = new SqlConnection(s);
                conn.Open();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public Sach()
        {
            InitializeComponent();
        }

        DataTable TruyVan(string s)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                dap = new SqlDataAdapter(s, conn);
                dap.Fill(ds,"KQ");
                conn.Close();
                return ds.Tables["KQ"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Truy Vấn", "Lỗi");
                return new DataTable();
            }
        }

        bool ThemXoaSua(string s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Cập Nhập CSDL");
                return false;
            }
        }

        void LayDuLieuLenListView()
        {
            string s = "Select * From Sach ";
            dt = new DataTable();
            dt = TruyVan(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvSach.Items.Add(dt.Rows[i]["MaSach"].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        void Xoa()
        {
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXB.Clear();
            txtNXB.Clear();
            txtGia.Clear();
            dtpNgayNhap.Value = DateTime.Now;

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            Xoa();
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtNamXB.Enabled = true;
            txtNXB.Enabled = true;
            txtGia.Enabled = true;
            btnHuyLuuSach.Enabled = true;
            btnLuuSach.Enabled = true;
            btnThemSach.Enabled = false;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            btnLuuSach.Enabled = false;
            btnHuyLuuSach.Enabled = false;
            if (KetNoi("LAPTOP-1R2HA659", "QLTHUVIEN"))
            {
                LayDuLieuLenListView();
            }
            else
            {
                MessageBox.Show(" Kết Nỗi Không Thành Công, Nhấn OK Để Thoát", "Lỗi", MessageBoxButtons.OK);
                Application.Exit();
            }
            lsvSach.View = View.Details;
            lsvSach.GridLines = true;
            lsvSach.FullRowSelect = true;
        }

        private void lsvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSach.SelectedItems.Count>0)
            {
                txtTenSach.Text = lsvSach.SelectedItems[0].SubItems[1].Text;
                txtTacGia.Text = lsvSach.SelectedItems[0].SubItems[2].Text;
                txtNamXB.Text= lsvSach.SelectedItems[0].SubItems[3].Text;
                txtNXB.Text= lsvSach.SelectedItems[0].SubItems[4].Text;
                txtGia.Text= lsvSach.SelectedItems[0].SubItems[5].Text;
                dtpNgayNhap.Text= lsvSach.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (lsvSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("hãy chọn một dòng để xóa");
                return;

            }
            if (KetNoi("LAPTOP-1R2HA659", "QLTHUVIEN") == false)
            {
                MessageBox.Show("Nhấn OK để thoát", "Kết nối không thành công", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            foreach (ListViewItem i in lsvSach.SelectedItems)
            {
                string s = "delete from SACH where MaSach = N'" + i.SubItems[0].Text + "'";
                SqlCommand command = new SqlCommand(s, conn);
                ThemXoaSua(s);

            }
            conn.Close();
            lsvSach.Items.Clear();
            LayDuLieuLenListView();
        }

        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            if (KetNoi("LAPTOP-1R2HA659", "QLTHUVIEN") == false)
            {
                MessageBox.Show("Nhan OK de thoat", "Ket noi thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string ts = txtTenSach.Text;
            string ttg = txtTacGia.Text;
            string nxb = txtNamXB.Text;
            string Nxb = txtNXB.Text;
            string tg = txtGia.Text;
            string nn = dtpNgayNhap.Value.ToShortDateString();

            string s = " Insert into SACH values(N'" + ts + "','" + ttg + "',N'" + nxb + "','" + Nxb + "','" + tg + "','" + nn + "')";
            if (ThemXoaSua(s) == true)
            {
                lsvSach.Items.Clear();
                LayDuLieuLenListView();

                MessageBox.Show("Thêm mới thành công");
            }
        }

        private void btnThoatDSSach_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (KetNoi("LAPTOP-1R2HA659", "QLTHUVIEN") == false)
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối CSDL được!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (lsvSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("chưa chọn dòng dữ liệu");
                return;
            }

            string ts = txtTenSach.Text;
            string ttg = txtTacGia.Text;
            string nxb = txtNamXB.Text;
            string Nxb = txtNXB.Text;
            string tg = txtGia.Text;
            string nn = dtpNgayNhap.Value.ToShortDateString();
            string s = "update SACH set TenSach = N'" + ts + "',TacGia='" + ttg + "',NamXuatBan = N'" + nxb + "',NhaXuatBan= '" + Nxb + "',TriGia= '" + tg + "',NgayNhap= '" + nn + "'";
            if (ThemXoaSua(s) == true)
            {

                lsvSach.Items.Clear();
                LayDuLieuLenListView();
            }
        }

        private void btnHuyLuuSach_Click(object sender, EventArgs e)
        {
            btnThemSach.Enabled = true;
            btnXoaSach.Enabled = true;
            btnSuaSach.Enabled = true;
            btnLuuSach.Enabled = true;
            btnHuyLuuSach.Enabled = true;
        }
    }
}

