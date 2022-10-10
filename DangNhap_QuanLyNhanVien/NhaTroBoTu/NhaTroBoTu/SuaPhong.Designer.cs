namespace NhaTroBoTu
{
    partial class SuaPhong
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
            this.khachThueTroTableAdapter = new NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.cmbSuaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtSuaMaPhong = new System.Windows.Forms.TextBox();
            this.txtSuaTT = new System.Windows.Forms.TextBox();
            this.txtSuaMoTa = new System.Windows.Forms.TextBox();
            this.txtSuaTenPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quanLyPhongTroBoTuDataSet = new NhaTroBoTu.QuanLyPhongTroBoTuDataSet();
            this.quanLyPhongTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCanceSuaPT = new System.Windows.Forms.Button();
            this.dataSuaPT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuaPT)).BeginInit();
            this.SuspendLayout();
            // 
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
            // 
            // cmbSuaLoaiPhong
            // 
            this.cmbSuaLoaiPhong.FormattingEnabled = true;
            this.cmbSuaLoaiPhong.Location = new System.Drawing.Point(86, 89);
            this.cmbSuaLoaiPhong.Name = "cmbSuaLoaiPhong";
            this.cmbSuaLoaiPhong.Size = new System.Drawing.Size(107, 21);
            this.cmbSuaLoaiPhong.TabIndex = 38;
            // 
            // txtSuaMaPhong
            // 
            this.txtSuaMaPhong.Location = new System.Drawing.Point(86, 19);
            this.txtSuaMaPhong.Name = "txtSuaMaPhong";
            this.txtSuaMaPhong.Size = new System.Drawing.Size(194, 20);
            this.txtSuaMaPhong.TabIndex = 37;
            // 
            // txtSuaTT
            // 
            this.txtSuaTT.Location = new System.Drawing.Point(86, 131);
            this.txtSuaTT.Name = "txtSuaTT";
            this.txtSuaTT.Size = new System.Drawing.Size(194, 20);
            this.txtSuaTT.TabIndex = 33;
            // 
            // txtSuaMoTa
            // 
            this.txtSuaMoTa.Location = new System.Drawing.Point(86, 162);
            this.txtSuaMoTa.Name = "txtSuaMoTa";
            this.txtSuaMoTa.Size = new System.Drawing.Size(194, 20);
            this.txtSuaMoTa.TabIndex = 33;
            // 
            // txtSuaTenPhong
            // 
            this.txtSuaTenPhong.Location = new System.Drawing.Point(86, 54);
            this.txtSuaTenPhong.Name = "txtSuaTenPhong";
            this.txtSuaTenPhong.Size = new System.Drawing.Size(194, 20);
            this.txtSuaTenPhong.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(2, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tên Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(2, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tình Trạng";
            // 
            // quanLyPhongTroBoTuDataSet
            // 
            this.quanLyPhongTroBoTuDataSet.DataSetName = "QuanLyPhongTroBoTuDataSet";
            this.quanLyPhongTroBoTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyPhongTroBoTuDataSetBindingSource
            // 
            this.quanLyPhongTroBoTuDataSetBindingSource.DataSource = this.quanLyPhongTroBoTuDataSet;
            this.quanLyPhongTroBoTuDataSetBindingSource.Position = 0;
            // 
            // khachThueTroBindingSource
            // 
            this.khachThueTroBindingSource.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource.DataSource = this.quanLyPhongTroBoTuDataSetBindingSource;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(387, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 39;
            this.label6.Text = "Sửa Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(2, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Loại Phòng";
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaPhong.Location = new System.Drawing.Point(43, 287);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(88, 43);
            this.btnSuaPhong.TabIndex = 40;
            this.btnSuaPhong.Text = "Thêm";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mô Tả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSuaLoaiPhong);
            this.groupBox1.Controls.Add(this.txtSuaMaPhong);
            this.groupBox1.Controls.Add(this.txtSuaTT);
            this.groupBox1.Controls.Add(this.txtSuaMoTa);
            this.groupBox1.Controls.Add(this.txtSuaTenPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 197);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng Trọ";
            // 
            // btnCanceSuaPT
            // 
            this.btnCanceSuaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCanceSuaPT.Location = new System.Drawing.Point(161, 287);
            this.btnCanceSuaPT.Name = "btnCanceSuaPT";
            this.btnCanceSuaPT.Size = new System.Drawing.Size(84, 43);
            this.btnCanceSuaPT.TabIndex = 41;
            this.btnCanceSuaPT.Text = "Hủy";
            this.btnCanceSuaPT.UseVisualStyleBackColor = true;
            this.btnCanceSuaPT.Click += new System.EventHandler(this.btnCanceSuaPT_Click);
            // 
            // dataSuaPT
            // 
            this.dataSuaPT.AllowUserToDeleteRows = false;
            this.dataSuaPT.AllowUserToResizeColumns = false;
            this.dataSuaPT.AllowUserToResizeRows = false;
            this.dataSuaPT.AutoGenerateColumns = false;
            this.dataSuaPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSuaPT.DataSource = this.quanLyPhongTroBoTuDataSet;
            this.dataSuaPT.Location = new System.Drawing.Point(330, 71);
            this.dataSuaPT.Name = "dataSuaPT";
            this.dataSuaPT.RowTemplate.Height = 25;
            this.dataSuaPT.Size = new System.Drawing.Size(674, 231);
            this.dataSuaPT.TabIndex = 42;
            this.dataSuaPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSuaPT_CellContentClick);
            // 
            // SuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCanceSuaPT);
            this.Controls.Add(this.dataSuaPT);
            this.Name = "SuaPhong";
            this.Text = "SuaPhong";
            this.Load += new System.EventHandler(this.SuaPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuaPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private System.Windows.Forms.ComboBox cmbSuaLoaiPhong;
        private System.Windows.Forms.TextBox txtSuaMaPhong;
        private System.Windows.Forms.TextBox txtSuaTT;
        private System.Windows.Forms.TextBox txtSuaMoTa;
        private System.Windows.Forms.TextBox txtSuaTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        private System.Windows.Forms.BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCanceSuaPT;
        private System.Windows.Forms.DataGridView dataSuaPT;
    }
}