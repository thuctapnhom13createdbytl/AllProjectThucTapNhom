namespace QuanLyKho.VIEW
{
    partial class fDSPhieuXuat
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
            this.dtgvDSPhieuXuat = new System.Windows.Forms.DataGridView();
            this.DS_MaPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCTPhieuXuat = new System.Windows.Forms.DataGridView();
            this.CT_MaCTPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_MaPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemPX = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSPhieuXuat
            // 
            this.dtgvDSPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSPhieuXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDSPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DS_MaPX,
            this.DS_MaNV,
            this.DS_TenNV,
            this.DS_MaKH,
            this.DS_TenKH,
            this.DS_NgayXuat});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSPhieuXuat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSPhieuXuat.Location = new System.Drawing.Point(11, 83);
            this.dtgvDSPhieuXuat.Name = "dtgvDSPhieuXuat";
            this.dtgvDSPhieuXuat.ReadOnly = true;
            this.dtgvDSPhieuXuat.Size = new System.Drawing.Size(526, 451);
            this.dtgvDSPhieuXuat.TabIndex = 0;
            this.dtgvDSPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSPhieuXuat_CellClick);
            // 
            // DS_MaPX
            // 
            this.DS_MaPX.DataPropertyName = "Ma_PX";
            this.DS_MaPX.HeaderText = "Mã phiếu xuất";
            this.DS_MaPX.Name = "DS_MaPX";
            this.DS_MaPX.ReadOnly = true;
            // 
            // DS_MaNV
            // 
            this.DS_MaNV.DataPropertyName = "Ma_NV";
            this.DS_MaNV.HeaderText = "Mã nhân viên";
            this.DS_MaNV.Name = "DS_MaNV";
            this.DS_MaNV.ReadOnly = true;
            this.DS_MaNV.Visible = false;
            // 
            // DS_TenNV
            // 
            this.DS_TenNV.DataPropertyName = "Ten_NV";
            this.DS_TenNV.HeaderText = "Nhân viên";
            this.DS_TenNV.Name = "DS_TenNV";
            this.DS_TenNV.ReadOnly = true;
            // 
            // DS_MaKH
            // 
            this.DS_MaKH.DataPropertyName = "Ma_KH";
            this.DS_MaKH.HeaderText = "Mã khách hàng";
            this.DS_MaKH.Name = "DS_MaKH";
            this.DS_MaKH.ReadOnly = true;
            this.DS_MaKH.Visible = false;
            // 
            // DS_TenKH
            // 
            this.DS_TenKH.DataPropertyName = "Ten_KH";
            this.DS_TenKH.HeaderText = "Khách hàng";
            this.DS_TenKH.Name = "DS_TenKH";
            this.DS_TenKH.ReadOnly = true;
            // 
            // DS_NgayXuat
            // 
            this.DS_NgayXuat.DataPropertyName = "Ngayxuat";
            this.DS_NgayXuat.HeaderText = "Ngày xuất";
            this.DS_NgayXuat.Name = "DS_NgayXuat";
            this.DS_NgayXuat.ReadOnly = true;
            // 
            // dtgvCTPhieuXuat
            // 
            this.dtgvCTPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCTPhieuXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCTPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CT_MaCTPX,
            this.CT_MaPX,
            this.CT_MaSP,
            this.CT_TenSP,
            this.CT_SoLuong,
            this.CT_DonGia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCTPhieuXuat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCTPhieuXuat.Location = new System.Drawing.Point(554, 83);
            this.dtgvCTPhieuXuat.Name = "dtgvCTPhieuXuat";
            this.dtgvCTPhieuXuat.ReadOnly = true;
            this.dtgvCTPhieuXuat.Size = new System.Drawing.Size(539, 451);
            this.dtgvCTPhieuXuat.TabIndex = 1;
            // 
            // CT_MaCTPX
            // 
            this.CT_MaCTPX.DataPropertyName = "Ma_CTPX";
            this.CT_MaCTPX.HeaderText = "Mã chi tiết";
            this.CT_MaCTPX.Name = "CT_MaCTPX";
            this.CT_MaCTPX.ReadOnly = true;
            this.CT_MaCTPX.Visible = false;
            // 
            // CT_MaPX
            // 
            this.CT_MaPX.DataPropertyName = "Ma_PX";
            this.CT_MaPX.HeaderText = "Mã phiếu xuất";
            this.CT_MaPX.Name = "CT_MaPX";
            this.CT_MaPX.ReadOnly = true;
            this.CT_MaPX.Visible = false;
            // 
            // CT_MaSP
            // 
            this.CT_MaSP.DataPropertyName = "Ma_Sanpham";
            this.CT_MaSP.HeaderText = "Mã sản phẩm";
            this.CT_MaSP.Name = "CT_MaSP";
            this.CT_MaSP.ReadOnly = true;
            // 
            // CT_TenSP
            // 
            this.CT_TenSP.DataPropertyName = "TenSanPham";
            this.CT_TenSP.HeaderText = "Tên sản phẩm";
            this.CT_TenSP.Name = "CT_TenSP";
            this.CT_TenSP.ReadOnly = true;
            // 
            // CT_SoLuong
            // 
            this.CT_SoLuong.DataPropertyName = "Soluong";
            this.CT_SoLuong.HeaderText = "Số lượng";
            this.CT_SoLuong.Name = "CT_SoLuong";
            this.CT_SoLuong.ReadOnly = true;
            // 
            // CT_DonGia
            // 
            this.CT_DonGia.DataPropertyName = "Dongia";
            this.CT_DonGia.HeaderText = "Đơn giá";
            this.CT_DonGia.Name = "CT_DonGia";
            this.CT_DonGia.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách phiếu xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chi tiết phiếu xuất";
            // 
            // btnThemPX
            // 
            this.btnThemPX.Location = new System.Drawing.Point(1018, 41);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(75, 39);
            this.btnThemPX.TabIndex = 4;
            this.btnThemPX.Text = "Thêm phiếu xuất";
            this.btnThemPX.UseVisualStyleBackColor = true;
            this.btnThemPX.Click += new System.EventHandler(this.btnThemPX_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(937, 41);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 39);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "In phiếu xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // fDSPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 549);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnThemPX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCTPhieuXuat);
            this.Controls.Add(this.dtgvDSPhieuXuat);
            this.Name = "fDSPhieuXuat";
            this.Text = "Danh sách phiếu xuất";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSPhieuXuat;
        private System.Windows.Forms.DataGridView dtgvCTPhieuXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_MaCTPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_MaPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT_DonGia;
        private System.Windows.Forms.Button btnThemPX;
        private System.Windows.Forms.Button btnXuat;
    }
}