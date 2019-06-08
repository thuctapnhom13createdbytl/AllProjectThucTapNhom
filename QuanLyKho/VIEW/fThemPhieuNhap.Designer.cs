namespace QuanLyKho.VIEW
{
    partial class fThemPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvThemPhieuNhap = new System.Windows.Forms.DataGridView();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongSoKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmDonGia = new System.Windows.Forms.NumericUpDown();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.txtLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvThemPhieuNhap
            // 
            this.dtgvThemPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThemPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvThemPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThemPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSanPham,
            this.TenLoaiSP,
            this.TenNSX,
            this.MaSanPham,
            this.Gia,
            this.SoLuong,
            this.MaNSX,
            this.ThongSoKT,
            this.MaLoaiSP,
            this.TongTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThemPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvThemPhieuNhap.Location = new System.Drawing.Point(8, 193);
            this.dtgvThemPhieuNhap.Name = "dtgvThemPhieuNhap";
            this.dtgvThemPhieuNhap.Size = new System.Drawing.Size(1000, 420);
            this.dtgvThemPhieuNhap.TabIndex = 0;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "tenSP";
            this.TenSanPham.HeaderText = "Sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // TenLoaiSP
            // 
            this.TenLoaiSP.DataPropertyName = "tenLoaiSP";
            this.TenLoaiSP.HeaderText = "Loại sản phẩm";
            this.TenLoaiSP.Name = "TenLoaiSP";
            // 
            // TenNSX
            // 
            this.TenNSX.DataPropertyName = "TenNSX";
            this.TenNSX.HeaderText = "Nhà sản xuất";
            this.TenNSX.Name = "TenNSX";
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "maSP";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Visible = false;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "donGia";
            this.Gia.HeaderText = "Đơn giá";
            this.Gia.Name = "Gia";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "maNSX";
            this.MaNSX.HeaderText = "Mã nhà sản xuất";
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.Visible = false;
            // 
            // ThongSoKT
            // 
            this.ThongSoKT.DataPropertyName = "thongSoKyThuat";
            this.ThongSoKT.HeaderText = "Thông số KT";
            this.ThongSoKT.Name = "ThongSoKT";
            this.ThongSoKT.Visible = false;
            // 
            // MaLoaiSP
            // 
            this.MaLoaiSP.DataPropertyName = "maLoaiSP";
            this.MaLoaiSP.HeaderText = "MaLoaiSP";
            this.MaLoaiSP.Name = "MaLoaiSP";
            this.MaLoaiSP.Visible = false;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(110, 82);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(162, 21);
            this.cbNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sản phẩm";
            // 
            // cbSanPham
            // 
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(733, 80);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(194, 21);
            this.cbSanPham.TabIndex = 5;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Lượng";
            // 
            // nmDonGia
            // 
            this.nmDonGia.Location = new System.Drawing.Point(363, 115);
            this.nmDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmDonGia.Name = "nmDonGia";
            this.nmDonGia.Size = new System.Drawing.Size(120, 20);
            this.nmDonGia.TabIndex = 9;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(630, 115);
            this.nmSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(97, 20);
            this.nmSoLuong.TabIndex = 10;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(23, 157);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(98, 30);
            this.btnThemSP.TabIndex = 11;
            this.btnThemSP.Text = "Thêm vào phiếu";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Location = new System.Drawing.Point(933, 75);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(75, 58);
            this.btnThemPhieu.TabIndex = 12;
            this.btnThemPhieu.Text = "Thêm vào kho";
            this.btnThemPhieu.UseVisualStyleBackColor = true;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // txtLoaiSanPham
            // 
            this.txtLoaiSanPham.Enabled = false;
            this.txtLoaiSanPham.Location = new System.Drawing.Point(110, 120);
            this.txtLoaiSanPham.Name = "txtLoaiSanPham";
            this.txtLoaiSanPham.ReadOnly = true;
            this.txtLoaiSanPham.Size = new System.Drawing.Size(162, 20);
            this.txtLoaiSanPham.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loại sản phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(139, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 30);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa khỏi phiếu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhà sản xuất";
            // 
            // cbNSX
            // 
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Location = new System.Drawing.Point(363, 82);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(183, 21);
            this.cbNSX.TabIndex = 17;
            // 
            // btnTimSP
            // 
            this.btnTimSP.Location = new System.Drawing.Point(570, 82);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(84, 23);
            this.btnTimSP.TabIndex = 19;
            this.btnTimSP.Text = "Tìm sản phẩm";
            this.btnTimSP.UseVisualStyleBackColor = true;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Location = new System.Drawing.Point(733, 115);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(194, 20);
            this.dtpkNgayNhap.TabIndex = 20;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(255, 157);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 30);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy thông tin ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // fThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 622);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dtpkNgayNhap);
            this.Controls.Add(this.btnTimSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNSX);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoaiSanPham);
            this.Controls.Add(this.btnThemPhieu);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.nmDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.dtgvThemPhieuNhap);
            this.Name = "fThemPhieuNhap";
            this.Text = "Thêm phiếu nhập";
            this.Load += new System.EventHandler(this.fThemPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvThemPhieuNhap;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmDonGia;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.TextBox txtLoaiSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongSoKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}