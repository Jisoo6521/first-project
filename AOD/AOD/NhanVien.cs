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
    public partial class NhanVien : Form
    {
        SqlConnection con;
        DataTable dt;
        public NhanVien()
        {
            InitializeComponent();
        }
        
        public bool KetNoi(String server, String database)
        {
            try
            {
                String s = "Data Source=LAPTOP-1R2HA659;Initial Catalog=QLTHUVIEN;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        DataTable truyVan(String s)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter(s, con);
                da.Fill(ds, "KQ");
                con.Close();
                return ds.Tables["KQ"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Truy Vấn");
                return new DataTable();
            }
        }

        bool ThemXoaSua (String s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void LayDuLieu_Len_ListView()
        {
            string s = "Select * From NhanVien a, BangCap b Where a.MaBangCap = b.MaBangCap";
            dt = new DataTable();
            dt = truyVan(s);
            for(int i=0; i<dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNhanVien.Items.Add(dt.Rows[i]["MaNhanVien"].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TenBangCap"].ToString());
            }
        }

        void NapBangCapVaoComboBox()
        {
            string s = "Select TenBangCap from BangCap";
            dt = new DataTable();
            dt = truyVan(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbBangCap.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        void Xoa()
        {
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            cbBangCap.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xoa();
            txtHoTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            cbBangCap.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    MessageBox.Show("Bạn Muốn Thoát Chương Trình", "Thông Báo", MessageBoxButtons.OK);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbBangCap.Enabled = false;
            if (KetNoi("pc266\\sqlexpress", " QLTHUVIEN"))
            {
                LayDuLieu_Len_ListView();
                NapBangCapVaoComboBox();
            }
            else
            {
                MessageBox.Show("Nhấn OK để thoát", "Kết Nối Không Thành Công", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KetNoi("PC266\\SQLEXPRESS", "QLTHUVIEN")==false)
            {
                MessageBox.Show("Nhấn OK để thoát", "Kết Nối Không Thành Công", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            string ht = txtHoTen.Text;
            string ns = dtpNgaySinh.Value.ToShortDateString();
            string dc = txtDiaChi.Text;
            string dt = txtDienThoai.Text;
            string bc = cbBangCap.SelectedIndex.ToString();
            string s = "insert into NHANVIEN values(N'" + ht + "','" + ns + "','" + dc + "','" + dt + "','" + bc + "')";
            if (ThemXoaSua(s)==true)
            {
                lsvNhanVien.Items.Clear();
                LayDuLieu_Len_ListView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count ==0)
            {
                MessageBox.Show("Hãy Chọn 1 Dòng Để Xóa");
                return;
            }

            if (KetNoi("PC266\\SQLEXPRESS", "QLTHUVIEN")==false)
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            foreach (ListViewItem i in lsvNhanVien.SelectedItems)
            {
                string s = "delete from NHANVIEN where MaNhanVien = N'" /*+ i.SubItems[0].Text + "'"*/;
                SqlCommand cmd = new SqlCommand();
                ThemXoaSua(s);
            }
            con.Close();
            lsvNhanVien.Items.Clear();
            LayDuLieu_Len_ListView();
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                cbBangCap.SelectedIndex = cbBangCap.FindString(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KetNoi("pc266//sqlexpress", "QLTHUVIEN") == false)
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không thể kết nối CSDL!",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (lsvNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
                return;
            }

            string ht = txtHoTen.Text;
            string ns = dtpNgaySinh.Value.ToLongDateString();
            string dc = txtDiaChi.Text;
            string dt = txtDienThoai.Text;
            string bc = cbBangCap.SelectedIndex.ToString();
            string s = "update NHANVIEN set HoTenNhanVien= N'" + ht + "',ngay sinh='" + ns + "',dia chi='" + dc + "',so dien thoai='" + dt + "',bang cap='" + bc + "' where manhanvien = N'";
            if (ThemXoaSua(s) == true)
            {
                con.Close();
                lsvNhanVien.Items.Clear();
                LayDuLieu_Len_ListView();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Xoa();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            this.Hide();
            sach.ShowDialog();
        }
    }
}
