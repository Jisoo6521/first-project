namespace NhaTroBoTu
{
    partial class ThemPT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtThemMAPT = new System.Windows.Forms.TextBox();
            this.txtThemTT = new System.Windows.Forms.TextBox();
            this.txtThemMoTaPT = new System.Windows.Forms.TextBox();
            this.txtThemTENPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.btnCanceThemPT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.khachThueTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSet = new NhaTroBoTu.QuanLyPhongTroBoTuDataSet();
            this.dataThemPT = new System.Windows.Forms.DataGridView();
            this.khachThueTroTableAdapter = new NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataThemPT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiPhong);
            this.groupBox1.Controls.Add(this.txtThemMAPT);
            this.groupBox1.Controls.Add(this.txtThemTT);
            this.groupBox1.Controls.Add(this.txtThemMoTaPT);
            this.groupBox1.Controls.Add(this.txtThemTENPT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 197);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng Trọ";
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(86, 89);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(107, 21);
            this.cmbLoaiPhong.TabIndex = 38;
            // 
            // txtThemMAPT
            // 
            this.txtThemMAPT.Location = new System.Drawing.Point(86, 19);
            this.txtThemMAPT.Name = "txtThemMAPT";
            this.txtThemMAPT.Size = new System.Drawing.Size(194, 20);
            this.txtThemMAPT.TabIndex = 37;
            // 
            // txtThemTT
            // 
            this.txtThemTT.Location = new System.Drawing.Point(86, 131);
            this.txtThemTT.Name = "txtThemTT";
            this.txtThemTT.Size = new System.Drawing.Size(194, 20);
            this.txtThemTT.TabIndex = 33;
            // 
            // txtThemMoTaPT
            // 
            this.txtThemMoTaPT.Location = new System.Drawing.Point(86, 162);
            this.txtThemMoTaPT.Name = "txtThemMoTaPT";
            this.txtThemMoTaPT.Size = new System.Drawing.Size(194, 20);
            this.txtThemMoTaPT.TabIndex = 33;
            // 
            // txtThemTENPT
            // 
            this.txtThemTENPT.Location = new System.Drawing.Point(86, 54);
            this.txtThemTENPT.Name = "txtThemTENPT";
            this.txtThemTENPT.Size = new System.Drawing.Size(194, 20);
            this.txtThemTENPT.TabIndex = 32;
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
            // btnThemPT
            // 
            this.btnThemPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemPT.Location = new System.Drawing.Point(64, 278);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(88, 43);
            this.btnThemPT.TabIndex = 35;
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // btnCanceThemPT
            // 
            this.btnCanceThemPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCanceThemPT.Location = new System.Drawing.Point(182, 278);
            this.btnCanceThemPT.Name = "btnCanceThemPT";
            this.btnCanceThemPT.Size = new System.Drawing.Size(84, 43);
            this.btnCanceThemPT.TabIndex = 36;
            this.btnCanceThemPT.Text = "Hủy";
            this.btnCanceThemPT.UseVisualStyleBackColor = true;
            this.btnCanceThemPT.Click += new System.EventHandler(this.btnCancelKH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(383, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 50);
            this.label6.TabIndex = 34;
            this.label6.Text = "Thêm Phòng";
            // 
            // khachThueTroBindingSource
            // 
            this.khachThueTroBindingSource.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource.DataSource = this.quanLyPhongTroBoTuDataSetBindingSource;
            // 
            // quanLyPhongTroBoTuDataSetBindingSource
            // 
            this.quanLyPhongTroBoTuDataSetBindingSource.DataSource = this.quanLyPhongTroBoTuDataSet;
            this.quanLyPhongTroBoTuDataSetBindingSource.Position = 0;
            // 
            // quanLyPhongTroBoTuDataSet
            // 
            this.quanLyPhongTroBoTuDataSet.DataSetName = "QuanLyPhongTroBoTuDataSet";
            this.quanLyPhongTroBoTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataThemPT
            // 
            this.dataThemPT.AllowUserToDeleteRows = false;
            this.dataThemPT.AllowUserToResizeColumns = false;
            this.dataThemPT.AllowUserToResizeRows = false;
            this.dataThemPT.AutoGenerateColumns = false;
            this.dataThemPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThemPT.DataSource = this.quanLyPhongTroBoTuDataSet;
            this.dataThemPT.Location = new System.Drawing.Point(351, 62);
            this.dataThemPT.Name = "dataThemPT";
            this.dataThemPT.RowTemplate.Height = 25;
            this.dataThemPT.Size = new System.Drawing.Size(674, 231);
            this.dataThemPT.TabIndex = 37;
            this.dataThemPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThemPT_CellContentClick);
            // 
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
            // 
            // ThemPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.btnCanceThemPT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataThemPT);
            this.Name = "ThemPT";
            this.Text = "ThemPT";
            this.Load += new System.EventHandler(this.ThemPT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataThemPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThemMAPT;
        private System.Windows.Forms.TextBox txtThemMoTaPT;
        private System.Windows.Forms.TextBox txtThemTENPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Button btnCanceThemPT;
        private System.Windows.Forms.Label label6;
        private QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        private System.Windows.Forms.BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource;
        private System.Windows.Forms.DataGridView dataThemPT;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThemTT;
        private System.Windows.Forms.Label label4;
    }
}