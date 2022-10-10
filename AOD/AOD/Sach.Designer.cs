namespace AOD
{
    partial class Sach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.colNXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNamXuatBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvSach = new System.Windows.Forms.ListView();
            this.colGIa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoatDSSach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnHuyLuuSach = new System.Windows.Forms.Button();
            this.btnLuuSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.lable100 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Mục Sách";
            // 
            // colNXB
            // 
            this.colNXB.Text = "Nhà xuất bản";
            this.colNXB.Width = 127;
            // 
            // colNamXuatBan
            // 
            this.colNamXuatBan.Text = "Năm Xuất Bản";
            this.colNamXuatBan.Width = 130;
            // 
            // colTacGia
            // 
            this.colTacGia.Text = "Tác Giả";
            this.colTacGia.Width = 191;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên Sách";
            this.colTenSach.Width = 233;
            // 
            // colMaSach
            // 
            this.colMaSach.Text = "Mã Sách";
            this.colMaSach.Width = 71;
            // 
            // lsvSach
            // 
            this.lsvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSach,
            this.colTenSach,
            this.colTacGia,
            this.colNamXuatBan,
            this.colNXB,
            this.colGIa,
            this.colNgayNhap});
            this.lsvSach.FullRowSelect = true;
            this.lsvSach.GridLines = true;
            this.lsvSach.HideSelection = false;
            this.lsvSach.Location = new System.Drawing.Point(11, 23);
            this.lsvSach.Margin = new System.Windows.Forms.Padding(4);
            this.lsvSach.Name = "lsvSach";
            this.lsvSach.Size = new System.Drawing.Size(1050, 258);
            this.lsvSach.TabIndex = 0;
            this.lsvSach.UseCompatibleStateImageBehavior = false;
            this.lsvSach.View = System.Windows.Forms.View.Details;
            this.lsvSach.SelectedIndexChanged += new System.EventHandler(this.lsvSach_SelectedIndexChanged);
            // 
            // colGIa
            // 
            this.colGIa.Text = "Trị Giá";
            this.colGIa.Width = 129;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.Text = "Ngày Nhập";
            this.colNgayNhap.Width = 176;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsvSach);
            this.groupBox3.Location = new System.Drawing.Point(9, 382);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1068, 295);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chung";
            // 
            // btnThoatDSSach
            // 
            this.btnThoatDSSach.Location = new System.Drawing.Point(549, 23);
            this.btnThoatDSSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatDSSach.Name = "btnThoatDSSach";
            this.btnThoatDSSach.Size = new System.Drawing.Size(97, 58);
            this.btnThoatDSSach.TabIndex = 0;
            this.btnThoatDSSach.Text = "Thoát";
            this.btnThoatDSSach.UseVisualStyleBackColor = true;
            this.btnThoatDSSach.Click += new System.EventHandler(this.btnThoatDSSach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoatDSSach);
            this.groupBox2.Controls.Add(this.btnSuaSach);
            this.groupBox2.Controls.Add(this.btnHuyLuuSach);
            this.groupBox2.Controls.Add(this.btnLuuSach);
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Location = new System.Drawing.Point(424, 293);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(653, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(235, 23);
            this.btnSuaSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(97, 58);
            this.btnSuaSach.TabIndex = 0;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnHuyLuuSach
            // 
            this.btnHuyLuuSach.Location = new System.Drawing.Point(444, 23);
            this.btnHuyLuuSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyLuuSach.Name = "btnHuyLuuSach";
            this.btnHuyLuuSach.Size = new System.Drawing.Size(97, 58);
            this.btnHuyLuuSach.TabIndex = 0;
            this.btnHuyLuuSach.Text = "Hủy";
            this.btnHuyLuuSach.UseVisualStyleBackColor = true;
            this.btnHuyLuuSach.Click += new System.EventHandler(this.btnHuyLuuSach_Click);
            // 
            // btnLuuSach
            // 
            this.btnLuuSach.Location = new System.Drawing.Point(339, 23);
            this.btnLuuSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuSach.Name = "btnLuuSach";
            this.btnLuuSach.Size = new System.Drawing.Size(97, 58);
            this.btnLuuSach.TabIndex = 0;
            this.btnLuuSach.Text = "Lưu";
            this.btnLuuSach.UseVisualStyleBackColor = true;
            this.btnLuuSach.Click += new System.EventHandler(this.btnLuuSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(129, 23);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(97, 58);
            this.btnXoaSach.TabIndex = 0;
            this.btnXoaSach.Text = "Xóa ";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(24, 23);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(97, 58);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Thêm ";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // lable100
            // 
            this.lable100.AutoSize = true;
            this.lable100.Location = new System.Drawing.Point(39, 165);
            this.lable100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable100.Name = "lable100";
            this.lable100.Size = new System.Drawing.Size(92, 16);
            this.lable100.TabIndex = 1;
            this.lable100.Text = "Năm Xuất Bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(711, 163);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(356, 22);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(149, 161);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(392, 22);
            this.txtNamXB.TabIndex = 2;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(711, 55);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(356, 22);
            this.txtNXB.TabIndex = 2;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(149, 52);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(392, 22);
            this.txtTenSach.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trị Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà Xuất Bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtNamXB);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lable100);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-4, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1081, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(149, 104);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(392, 22);
            this.txtTacGia.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(711, 105);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(356, 22);
            this.txtGia.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tác Giả";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sach";
            this.Text = "N";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colNXB;
        private System.Windows.Forms.ColumnHeader colNamXuatBan;
        private System.Windows.Forms.ColumnHeader colTacGia;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.ColumnHeader colMaSach;
        private System.Windows.Forms.ListView lsvSach;
        private System.Windows.Forms.ColumnHeader colGIa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoatDSSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnHuyLuuSach;
        private System.Windows.Forms.Button btnLuuSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Label lable100;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader colNgayNhap;
        private System.Windows.Forms.TextBox txtGia;
    }
}