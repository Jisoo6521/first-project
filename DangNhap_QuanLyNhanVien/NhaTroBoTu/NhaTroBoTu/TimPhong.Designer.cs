namespace NhaTroBoTu
{
    partial class TimPhong
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTenPT = new System.Windows.Forms.RadioButton();
            this.rdMaPT = new System.Windows.Forms.RadioButton();
            this.btnTimKiemPT = new System.Windows.Forms.Button();
            this.txtTimPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTimPT = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimPT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(881, 352);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(78, 61);
            this.btnQuayLai.TabIndex = 42;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.rdTenPT);
            this.groupBox1.Controls.Add(this.rdMaPT);
            this.groupBox1.Controls.Add(this.btnTimKiemPT);
            this.groupBox1.Controls.Add(this.txtTimPT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(138, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 63);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Phòng";
            // 
            // rdTenPT
            // 
            this.rdTenPT.AutoSize = true;
            this.rdTenPT.Location = new System.Drawing.Point(162, 26);
            this.rdTenPT.Name = "rdTenPT";
            this.rdTenPT.Size = new System.Drawing.Size(44, 17);
            this.rdTenPT.TabIndex = 5;
            this.rdTenPT.TabStop = true;
            this.rdTenPT.Text = "Tên";
            this.rdTenPT.UseVisualStyleBackColor = true;
            // 
            // rdMaPT
            // 
            this.rdMaPT.AutoSize = true;
            this.rdMaPT.Location = new System.Drawing.Point(108, 26);
            this.rdMaPT.Name = "rdMaPT";
            this.rdMaPT.Size = new System.Drawing.Size(40, 17);
            this.rdMaPT.TabIndex = 4;
            this.rdMaPT.TabStop = true;
            this.rdMaPT.Text = "Mã";
            this.rdMaPT.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemPT
            // 
            this.btnTimKiemPT.Location = new System.Drawing.Point(534, 23);
            this.btnTimKiemPT.Name = "btnTimKiemPT";
            this.btnTimKiemPT.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemPT.TabIndex = 3;
            this.btnTimKiemPT.Text = "Tìm Kiếm ";
            this.btnTimKiemPT.UseVisualStyleBackColor = true;
            this.btnTimKiemPT.Click += new System.EventHandler(this.btnTimKiemPT_Click);
            // 
            // txtTimPT
            // 
            this.txtTimPT.Location = new System.Drawing.Point(356, 25);
            this.txtTimPT.Name = "txtTimPT";
            this.txtTimPT.Size = new System.Drawing.Size(172, 20);
            this.txtTimPT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // dataTimPT
            // 
            this.dataTimPT.AllowUserToAddRows = false;
            this.dataTimPT.AllowUserToDeleteRows = false;
            this.dataTimPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimPT.Location = new System.Drawing.Point(32, 131);
            this.dataTimPT.Name = "dataTimPT";
            this.dataTimPT.ReadOnly = true;
            this.dataTimPT.Size = new System.Drawing.Size(843, 267);
            this.dataTimPT.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(366, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tìm Phòng";
            // 
            // TimPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataTimPT);
            this.Controls.Add(this.label6);
            this.Name = "TimPhong";
            this.Text = "Tìm_Phòng";
            this.Load += new System.EventHandler(this.TimPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTenPT;
        private System.Windows.Forms.RadioButton rdMaPT;
        private System.Windows.Forms.Button btnTimKiemPT;
        private System.Windows.Forms.TextBox txtTimPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTimPT;
        private System.Windows.Forms.Label label6;
    }
}