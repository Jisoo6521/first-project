namespace NhaTroBoTu
{
    partial class XoaPhong
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
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtMAPT = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txMoTaPT = new System.Windows.Forms.TextBox();
            this.txtTENPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quanLyPhongTroBoTuDataSet = new NhaTroBoTu.QuanLyPhongTroBoTuDataSet();
            this.quanLyPhongTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCanceThemPT = new System.Windows.Forms.Button();
            this.dataXoaPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataXoaPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(115, 110);
            this.cmbLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(141, 24);
            this.cmbLoaiPhong.TabIndex = 38;
            // 
            // txtMAPT
            // 
            this.txtMAPT.Location = new System.Drawing.Point(115, 23);
            this.txtMAPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMAPT.Name = "txtMAPT";
            this.txtMAPT.Size = new System.Drawing.Size(257, 22);
            this.txtMAPT.TabIndex = 37;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(115, 161);
            this.txtTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(257, 22);
            this.txtTT.TabIndex = 33;
            // 
            // txMoTaPT
            // 
            this.txMoTaPT.Location = new System.Drawing.Point(115, 199);
            this.txMoTaPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txMoTaPT.Name = "txMoTaPT";
            this.txMoTaPT.Size = new System.Drawing.Size(257, 22);
            this.txMoTaPT.TabIndex = 33;
            // 
            // txtTENPT
            // 
            this.txtTENPT.Location = new System.Drawing.Point(115, 66);
            this.txtTENPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTENPT.Name = "txtTENPT";
            this.txtTENPT.Size = new System.Drawing.Size(257, 22);
            this.txtTENPT.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tên Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(3, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
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
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(497, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 62);
            this.label6.TabIndex = 39;
            this.label6.Text = "Xoá Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Loại Phòng";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPhong.Location = new System.Drawing.Point(57, 354);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(117, 53);
            this.btnXoaPhong.TabIndex = 40;
            this.btnXoaPhong.Text = "Xoá";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(8, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mô Tả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiPhong);
            this.groupBox1.Controls.Add(this.txtMAPT);
            this.groupBox1.Controls.Add(this.txtTT);
            this.groupBox1.Controls.Add(this.txMoTaPT);
            this.groupBox1.Controls.Add(this.txtTENPT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(424, 242);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng Trọ";
            // 
            // btnCanceThemPT
            // 
            this.btnCanceThemPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCanceThemPT.Location = new System.Drawing.Point(215, 354);
            this.btnCanceThemPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCanceThemPT.Name = "btnCanceThemPT";
            this.btnCanceThemPT.Size = new System.Drawing.Size(112, 53);
            this.btnCanceThemPT.TabIndex = 41;
            this.btnCanceThemPT.Text = "Hủy";
            this.btnCanceThemPT.UseVisualStyleBackColor = true;
            this.btnCanceThemPT.Click += new System.EventHandler(this.btnCanceThemPT_Click);
            // 
            // dataXoaPhong
            // 
            this.dataXoaPhong.AllowUserToDeleteRows = false;
            this.dataXoaPhong.AllowUserToResizeColumns = false;
            this.dataXoaPhong.AllowUserToResizeRows = false;
            this.dataXoaPhong.AutoGenerateColumns = false;
            this.dataXoaPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXoaPhong.DataSource = this.quanLyPhongTroBoTuDataSet;
            this.dataXoaPhong.Location = new System.Drawing.Point(440, 89);
            this.dataXoaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataXoaPhong.Name = "dataXoaPhong";
            this.dataXoaPhong.RowHeadersWidth = 51;
            this.dataXoaPhong.RowTemplate.Height = 25;
            this.dataXoaPhong.Size = new System.Drawing.Size(899, 284);
            this.dataXoaPhong.TabIndex = 42;
            this.dataXoaPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataXoaPhong_CellContentClick);
            // 
            // XoaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 454);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCanceThemPT);
            this.Controls.Add(this.dataXoaPhong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XoaPhong";
            this.Text = "XoaPhong";
            this.Load += new System.EventHandler(this.XoaPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataXoaPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.TextBox txtMAPT;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txMoTaPT;
        private System.Windows.Forms.TextBox txtTENPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        private System.Windows.Forms.BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCanceThemPT;
        private System.Windows.Forms.DataGridView dataXoaPhong;
    }
}