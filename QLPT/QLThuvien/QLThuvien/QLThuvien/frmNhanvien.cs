using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLThuvien
{
    public partial class frmNhanvien : Form
    {
        Nhanvien nv = new Nhanvien();
        Boolean themmoi;
        public frmNhanvien()
        {
            InitializeComponent();
        }
        void HienthiNhanvien()
        {
            DataTable dt = nv.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNhanVien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void setNull()
        {
            txtHoten.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void setKhoa(bool val)
        {
            txtHoten.ReadOnly = val;
            txtDiaChi.ReadOnly = val;
            txtDienThoai.ReadOnly = val;
            dtpNgaySinh.Enabled = !val;
            cboBangCap.Enabled = !val;
        }
        void HienthiBangcap()
        {
            DataTable dt = nv.LayBangcap();
            cboBangCap.DataSource = dt;
            cboBangCap.DisplayMember = "TenBangcap";
            cboBangCap.ValueMember = "MaBangcap";
        }


        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            HienthiNhanvien();
            setNull();
            setKhoa(true);
            setButton(true);
            HienthiBangcap();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setNull();
            themmoi = true;
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                txtHoten.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dtpNgaySinh.Value = DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[2].Text);
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox
                cboBangCap.SelectedIndex = cboBangCap.FindString(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull();
            setKhoa(true);
            setButton(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text);
                    lsvNhanVien.Items.RemoveAt(lsvNhanVien.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver 
            if (themmoi == true)
                nv.ThemNhanVien(txtHoten.Text, ngay, txtDiaChi.Text, txtDienThoai.Text, cboBangCap.SelectedValue.ToString());
            else
                nv.CapNhatNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text, txtHoten.Text, ngay, txtDiaChi.Text, txtDienThoai.Text, cboBangCap.SelectedValue.ToString());
            lsvNhanVien.Items.Clear();
            HienthiNhanvien();
            setNull();
            setButton(true);
            setKhoa(true);
        }
    }
}
