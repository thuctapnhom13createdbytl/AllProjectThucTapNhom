namespace QLHS.VIEW
{
    partial class fQuanLyGiangDay
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
            this.dtgvLop = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGVCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDanhSachLop = new System.Windows.Forms.Button();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTenGiaoVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLop
            // 
            this.dtgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.SiSo,
            this.MaKhoi,
            this.TenKhoi,
            this.TenGVCN});
            this.dtgvLop.Location = new System.Drawing.Point(12, 102);
            this.dtgvLop.Name = "dtgvLop";
            this.dtgvLop.Size = new System.Drawing.Size(673, 478);
            this.dtgvLop.TabIndex = 0;
            this.dtgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLop_CellClick);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.Visible = false;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.Name = "SiSo";
            // 
            // MaKhoi
            // 
            this.MaKhoi.DataPropertyName = "MaKhoi";
            this.MaKhoi.HeaderText = "MaKhoi";
            this.MaKhoi.Name = "MaKhoi";
            this.MaKhoi.Visible = false;
            // 
            // TenKhoi
            // 
            this.TenKhoi.DataPropertyName = "TenKhoi";
            this.TenKhoi.HeaderText = "Khối ";
            this.TenKhoi.Name = "TenKhoi";
            // 
            // TenGVCN
            // 
            this.TenGVCN.DataPropertyName = "TenGVCN";
            this.TenGVCN.HeaderText = "Giáo viên chủ nhiệm";
            this.TenGVCN.Name = "TenGVCN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khối";
            // 
            // txtKhoi
            // 
            this.txtKhoi.Enabled = false;
            this.txtKhoi.Location = new System.Drawing.Point(326, 12);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.ReadOnly = true;
            this.txtKhoi.Size = new System.Drawing.Size(142, 20);
            this.txtKhoi.TabIndex = 3;
            this.txtKhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sĩ số";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Enabled = false;
            this.txtSiSo.Location = new System.Drawing.Point(578, 15);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(107, 20);
            this.txtSiSo.TabIndex = 5;
            this.txtSiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giáo viên chủ nhiệm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(13, 73);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(242, 20);
            this.txtTimKiem.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(261, 73);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDanhSachLop
            // 
            this.btnDanhSachLop.Location = new System.Drawing.Point(578, 45);
            this.btnDanhSachLop.Name = "btnDanhSachLop";
            this.btnDanhSachLop.Size = new System.Drawing.Size(107, 48);
            this.btnDanhSachLop.TabIndex = 11;
            this.btnDanhSachLop.Text = "Danh sách học sinh";
            this.btnDanhSachLop.UseVisualStyleBackColor = true;
            this.btnDanhSachLop.Click += new System.EventHandler(this.btnDanhSachLop_Click);
            // 
            // txtLop
            // 
            this.txtLop.Enabled = false;
            this.txtLop.Location = new System.Drawing.Point(119, 12);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(119, 20);
            this.txtLop.TabIndex = 1;
            this.txtLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.Enabled = false;
            this.txtTenGiaoVien.Location = new System.Drawing.Point(119, 51);
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.ReadOnly = true;
            this.txtTenGiaoVien.Size = new System.Drawing.Size(349, 20);
            this.txtTenGiaoVien.TabIndex = 12;
            this.txtTenGiaoVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fQuanLyGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 592);
            this.Controls.Add(this.txtTenGiaoVien);
            this.Controls.Add(this.btnDanhSachLop);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKhoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.dtgvLop);
            this.Name = "fQuanLyGiangDay";
            this.Text = "Thông tin giảng dạy";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDanhSachLop;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGVCN;
        private System.Windows.Forms.TextBox txtTenGiaoVien;
    }
}