namespace QuanLyPhong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnThoat = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.rdbTimKiemMa = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbTimKiemTen = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataPhong = new System.Windows.Forms.DataGridView();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetQuanLyPhong = new QuanLyPhong.DataSetQuanLyPhong();
            this.dataSetQuanLyPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyPhongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1137, 607);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 43);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Quay Lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(501, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 43);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(367, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 43);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(230, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(91, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(480, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 85);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(101, 143);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(318, 20);
            this.txtMoTa.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.txtMoTa);
            this.groupBox3.Controls.Add(this.txtTT);
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.txtTenPT);
            this.groupBox3.Controls.Add(this.txtMaPT);
            this.groupBox3.Controls.Add(this.rdbTimKiemMa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rdbTimKiemTen);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(42, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 332);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(101, 179);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(318, 20);
            this.txtTT.TabIndex = 2;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(117, 287);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(183, 20);
            this.txtTim.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(329, 282);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 29);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTenPT
            // 
            this.txtTenPT.Location = new System.Drawing.Point(101, 69);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(183, 20);
            this.txtTenPT.TabIndex = 2;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(101, 32);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(183, 20);
            this.txtMaPT.TabIndex = 2;
            // 
            // rdbTimKiemMa
            // 
            this.rdbTimKiemMa.AutoSize = true;
            this.rdbTimKiemMa.Location = new System.Drawing.Point(233, 245);
            this.rdbTimKiemMa.Name = "rdbTimKiemMa";
            this.rdbTimKiemMa.Size = new System.Drawing.Size(108, 17);
            this.rdbTimKiemMa.TabIndex = 1;
            this.rdbTimKiemMa.TabStop = true;
            this.rdbTimKiemMa.Text = "Tìm kiếm theo mã";
            this.rdbTimKiemMa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mô tả";
            // 
            // rdbTimKiemTen
            // 
            this.rdbTimKiemTen.AutoSize = true;
            this.rdbTimKiemTen.Location = new System.Drawing.Point(101, 245);
            this.rdbTimKiemTen.Name = "rdbTimKiemTen";
            this.rdbTimKiemTen.Size = new System.Drawing.Size(109, 17);
            this.rdbTimKiemTen.TabIndex = 1;
            this.rdbTimKiemTen.TabStop = true;
            this.rdbTimKiemTen.Text = "Tìm kiếm theo tên";
            this.rdbTimKiemTen.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(14, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataPhong);
            this.groupBox1.Location = new System.Drawing.Point(480, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 403);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // dataPhong
            // 
            this.dataPhong.AutoGenerateColumns = false;
            this.dataPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhong.DataSource = this.dataSetQuanLyPhongBindingSource;
            this.dataPhong.Location = new System.Drawing.Point(7, 20);
            this.dataPhong.Name = "dataPhong";
            this.dataPhong.Size = new System.Drawing.Size(747, 377);
            this.dataPhong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(460, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý phòng ";
            // 
            // dataSetQuanLyPhong
            // 
            this.dataSetQuanLyPhong.DataSetName = "DataSetQuanLyPhong";
            this.dataSetQuanLyPhong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetQuanLyPhongBindingSource
            // 
            this.dataSetQuanLyPhongBindingSource.DataSource = this.dataSetQuanLyPhong;
            this.dataSetQuanLyPhongBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyPhongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.RadioButton rdbTimKiemMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbTimKiemTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataSetQuanLyPhongBindingSource;
        private DataSetQuanLyPhong dataSetQuanLyPhong;
    }
}

