namespace QuanLyKho.VIEW
{
    partial class fDSPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.DS_MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.CT_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_MaCTPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_Ma_SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSPhieuNhap
            // 
            this.dtgvDSPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DS_MaPN,
            this.DS_MaNV,
            this.DS_MaNSX,
            this.DS_NgayNhap,
            this.DS_TenNV,
            this.DS_TenNSX});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSPhieuNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSPhieuNhap.Location = new System.Drawing.Point(14, 92);
            this.dtgvDSPhieuNhap.Name = "dtgvDSPhieuNhap";
            this.dtgvDSPhieuNhap.ReadOnly = true;
            this.dtgvDSPhieuNhap.Size = new System.Drawing.Size(521, 461);
            this.dtgvDSPhieuNhap.TabIndex = 0;
            this.dtgvDSPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSPhieuNhap_CellClick);
            // 
            // DS_MaPN
            // 
            this.DS_MaPN.DataPropertyName = "Ma_PN";
            this.DS_MaPN.HeaderText = "Mã phiếu nhập";
            this.DS_MaPN.Name = "DS_MaPN";
            this.DS_MaPN.ReadOnly = true;
            // 
            // DS_MaNV
            // 
            this.DS_MaNV.DataPropertyName = "Ma_NV";
            this.DS_MaNV.HeaderText = "Mã nhân Viên";
            this.DS_MaNV.Name = "DS_MaNV";
            this.DS_MaNV.ReadOnly = true;
            this.DS_MaNV.Visible = false;
            // 
            // DS_MaNSX
            // 
            this.DS_MaNSX.DataPropertyName = "Ma_NSX";
            this.DS_MaNSX.HeaderText = "Mã nhà sản xuất";
            this.DS_MaNSX.Name = "DS_MaNSX";
            this.DS_MaNSX.ReadOnly = true;
            this.DS_MaNSX.Visible = false;
            // 
            // DS_NgayNhap
            // 
            this.DS_NgayNhap.DataPropertyName = "Ngaynhap";
            this.DS_NgayNhap.HeaderText = "Ngày nhập";
            this.DS_NgayNhap.Name = "DS_NgayNhap";
            this.DS_NgayNhap.ReadOnly = true;
            // 
            // DS_TenNV
            // 
            this.DS_TenNV.DataPropertyName = "Ten_NV";
            this.DS_TenNV.HeaderText = "Tên nhân viên";
            this.DS_TenNV.Name = "DS_TenNV";
            this.DS_TenNV.ReadOnly = true;
            // 
            // DS_TenNSX
            // 
            this.DS_TenNSX.DataPropertyName = "Ten_NSX";
            this.DS_TenNSX.HeaderText = "Tên nhà sản xuất";
            this.DS_TenNSX.Name = "DS_TenNSX";
            this.DS_TenNSX.ReadOnly = true;
            // 
            // dtgvCTPhieuNhap
            // 
            this.dtgvCTPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCTPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CT_TenSanPham,
            this.CT_MaCTPN,
            this.CT_MaPN,
            this.CT_Ma_SanPham,
            this.CT_SoLuong,
            this.CT_DonGia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCTPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCTPhieuNhap.Location = new System.Drawing.Point(554, 92);
            this.dtgvCTPhieuNhap.Name = "dtgvCTPhieuNhap";
            this.dtgvCTPhieuNhap.ReadOnly = true;
            this.dtgvCTPhieuNhap.Size = new System.Drawing.Size(499, 461);
            this.dtgvCTPhieuNhap.TabIndex = 1;
            // 
            // CT_TenSanPham
            // 
            this.CT_TenSanPham.DataPropertyName = "TenSanPham";
            this.CT_TenSanPham.HeaderText = "Tên sản phẩm";
            this.CT_TenSanPham.Name = "CT_TenSanPham";
            this.CT_TenSanPham.ReadOnly = true;
            // 
            // CT_MaCTPN
            // 
            this.CT_MaCTPN.DataPropertyName = "Ma_CTPN";
            this.CT_MaCTPN.HeaderText = "Mã chi tiết phiếu nhập";
            this.CT_MaCTPN.Name = "CT_MaCTPN";
            this.CT_MaCTPN.ReadOnly = true;
            this.CT_MaCTPN.Visible = false;
            // 
            // CT_MaPN
            // 
            this.CT_MaPN.DataPropertyName = "Ma_PN";
            this.CT_MaPN.HeaderText = "Mã phiếu nhập";
            this.CT_MaPN.Name = "CT_MaPN";
            this.CT_MaPN.ReadOnly = true;
            this.CT_MaPN.Visible = false;
            // 
            // CT_Ma_SanPham
            // 
            this.CT_Ma_SanPham.DataPropertyName = "Ma_SanPham";
            this.CT_Ma_SanPham.HeaderText = "Mã sản phẩm";
            this.CT_Ma_SanPham.Name = "CT_Ma_SanPham";
            this.CT_Ma_SanPham.ReadOnly = true;
            this.CT_Ma_SanPham.Visible = false;
            // 
            // CT_SoLuong
            // 
            this.CT_SoLuong.DataPropertyName = "SoLuong";
            this.CT_SoLuong.HeaderText = "Số lượng";
            this.CT_SoLuong.Name = "CT_SoLuong";
            this.CT_SoLuong.ReadOnly = true;
            // 
            // CT_DonGia
            // 
            this.CT_DonGia.DataPropertyName = "DonGia";
            this.CT_DonGia.HeaderText = "Đơn giá";
            this.CT_DonGia.Name = "CT_DonGia";
            this.CT_DonGia.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chi tiết phiếu nhập";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(978, 52);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(75, 37);
            this.btnNhapHang.TabIndex = 4;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(897, 52);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(75, 37);
            this.btnXuatHoaDon.TabIndex = 5;
            this.btnXuatHoaDon.Text = "In hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // fDSPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 570);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCTPhieuNhap);
            this.Controls.Add(this.dtgvDSPhieuNhap);
            this.Name = "fDSPhieuNhap";
            this.Text = "Danh sách phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSPhieuNhap;
        private System.Windows.Forms.DataGridView dtgvCTPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_MaCTPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_Ma_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_DonGia;
        private System.Windows.Forms.Button btnXuatHoaDon;
    }
}