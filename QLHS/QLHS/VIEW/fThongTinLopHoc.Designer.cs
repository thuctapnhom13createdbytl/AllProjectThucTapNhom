namespace QLHS.VIEW
{
    partial class fThongTinLopHoc
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
            this.dtgvHS = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.TenHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiemMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MahocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem_MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGiuaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiem15 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemGiuaKi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiemCuoiKi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHS
            // 
            this.dtgvHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.MaLop,
            this.TenHocSinh,
            this.SDT,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.TonGiao,
            this.DanToc,
            this.TenCha,
            this.TenMe,
            this.TenLop});
            this.dtgvHS.Location = new System.Drawing.Point(12, 65);
            this.dtgvHS.Name = "dtgvHS";
            this.dtgvHS.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHS.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHS.Size = new System.Drawing.Size(646, 515);
            this.dtgvHS.TabIndex = 0;
            this.dtgvHS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHS_CellClick);
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Mã học sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "MaLop";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Visible = false;
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.DataPropertyName = "TenHocSinh";
            this.TenHocSinh.HeaderText = "Tên học sinh";
            this.TenHocSinh.Name = "TenHocSinh";
            this.TenHocSinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Visible = false;
            // 
            // TonGiao
            // 
            this.TonGiao.DataPropertyName = "TonGiao";
            this.TonGiao.HeaderText = "TonGiao";
            this.TonGiao.Name = "TonGiao";
            this.TonGiao.ReadOnly = true;
            this.TonGiao.Visible = false;
            // 
            // DanToc
            // 
            this.DanToc.DataPropertyName = "DanToc";
            this.DanToc.HeaderText = "DanToc";
            this.DanToc.Name = "DanToc";
            this.DanToc.ReadOnly = true;
            this.DanToc.Visible = false;
            // 
            // TenCha
            // 
            this.TenCha.DataPropertyName = "TenCha";
            this.TenCha.HeaderText = "TenCha";
            this.TenCha.Name = "TenCha";
            this.TenCha.ReadOnly = true;
            this.TenCha.Visible = false;
            // 
            // TenMe
            // 
            this.TenMe.DataPropertyName = "TenMe";
            this.TenMe.HeaderText = "TenMe";
            this.TenMe.Name = "TenMe";
            this.TenMe.ReadOnly = true;
            this.TenMe.Visible = false;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "TenLop";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Visible = false;
            // 
            // dtgvDiem
            // 
            this.dtgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHocKy,
            this.TenMonHoc,
            this.MaDiemMon,
            this.MaMonHoc,
            this.MahocKy,
            this.Diem_MaHocSinh,
            this.Diem15,
            this.DiemGiuaKy,
            this.DiemThi,
            this.TrungBinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDiem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDiem.Location = new System.Drawing.Point(664, 66);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.ReadOnly = true;
            this.dtgvDiem.Size = new System.Drawing.Size(645, 342);
            this.dtgvDiem.TabIndex = 1;
            this.dtgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDiem_CellClick);
            // 
            // TenHocKy
            // 
            this.TenHocKy.DataPropertyName = "TenHocKy";
            this.TenHocKy.HeaderText = "Học kì";
            this.TenHocKy.Name = "TenHocKy";
            this.TenHocKy.ReadOnly = true;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Môn";
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.ReadOnly = true;
            // 
            // MaDiemMon
            // 
            this.MaDiemMon.DataPropertyName = "MaDiemMon";
            this.MaDiemMon.HeaderText = "MaDiemMon";
            this.MaDiemMon.Name = "MaDiemMon";
            this.MaDiemMon.ReadOnly = true;
            this.MaDiemMon.Visible = false;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "MaMonHoc";
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.ReadOnly = true;
            this.MaMonHoc.Visible = false;
            // 
            // MahocKy
            // 
            this.MahocKy.DataPropertyName = "MahocKy";
            this.MahocKy.HeaderText = "MaHocKy";
            this.MahocKy.Name = "MahocKy";
            this.MahocKy.ReadOnly = true;
            this.MahocKy.Visible = false;
            // 
            // Diem_MaHocSinh
            // 
            this.Diem_MaHocSinh.DataPropertyName = "MaHocSinh";
            this.Diem_MaHocSinh.HeaderText = "MaHocSinh";
            this.Diem_MaHocSinh.Name = "Diem_MaHocSinh";
            this.Diem_MaHocSinh.ReadOnly = true;
            this.Diem_MaHocSinh.Visible = false;
            // 
            // Diem15
            // 
            this.Diem15.DataPropertyName = "Diem15";
            this.Diem15.HeaderText = "Điểm 15 phút";
            this.Diem15.Name = "Diem15";
            this.Diem15.ReadOnly = true;
            // 
            // DiemGiuaKy
            // 
            this.DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            this.DiemGiuaKy.HeaderText = "Điểm giữa kì";
            this.DiemGiuaKy.Name = "DiemGiuaKy";
            this.DiemGiuaKy.ReadOnly = true;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm cuối kì";
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.ReadOnly = true;
            // 
            // TrungBinh
            // 
            this.TrungBinh.DataPropertyName = "TrungBinh";
            this.TrungBinh.HeaderText = "Điểm trung bình";
            this.TrungBinh.Name = "TrungBinh";
            this.TrungBinh.ReadOnly = true;
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(12, 9);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(51, 25);
            this.lbTenLop.TabIndex = 2;
            this.lbTenLop.Text = "Lớp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(13, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(404, 20);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(423, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Học kì : ";
            // 
            // cbHK
            // 
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(740, 39);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(121, 21);
            this.cbHK.TabIndex = 7;
            this.cbHK.SelectedValueChanged += new System.EventHandler(this.cbHK_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Môn : ";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(771, 414);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(184, 21);
            this.cbMonHoc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Điểm 15 phút : ";
            // 
            // txtDiem15
            // 
            this.txtDiem15.Location = new System.Drawing.Point(771, 468);
            this.txtDiem15.Name = "txtDiem15";
            this.txtDiem15.Size = new System.Drawing.Size(184, 20);
            this.txtDiem15.TabIndex = 11;
            this.txtDiem15.TextChanged += new System.EventHandler(this.txtDiem15_TextChanged);
            this.txtDiem15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem15_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(988, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Điểm giữa kì : ";
            // 
            // txtDiemGiuaKi
            // 
            this.txtDiemGiuaKi.Location = new System.Drawing.Point(1105, 463);
            this.txtDiemGiuaKi.Name = "txtDiemGiuaKi";
            this.txtDiemGiuaKi.Size = new System.Drawing.Size(180, 20);
            this.txtDiemGiuaKi.TabIndex = 13;
            this.txtDiemGiuaKi.TextChanged += new System.EventHandler(this.txtDiemGiuaKi_TextChanged);
            this.txtDiemGiuaKi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemGiuaKi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điểm cuối kì : ";
            // 
            // txtDiemCuoiKi
            // 
            this.txtDiemCuoiKi.Location = new System.Drawing.Point(771, 512);
            this.txtDiemCuoiKi.Name = "txtDiemCuoiKi";
            this.txtDiemCuoiKi.Size = new System.Drawing.Size(184, 20);
            this.txtDiemCuoiKi.TabIndex = 15;
            this.txtDiemCuoiKi.TextChanged += new System.EventHandler(this.txtDiemCuoiKi_TextChanged);
            this.txtDiemCuoiKi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemCuoiKi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(989, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Điểm trung bình :  ";
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Enabled = false;
            this.txtDiemTB.Location = new System.Drawing.Point(1105, 512);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.ReadOnly = true;
            this.txtDiemTB.Size = new System.Drawing.Size(180, 20);
            this.txtDiemTB.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(771, 538);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 42);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(866, 538);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 42);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(991, 538);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 42);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1086, 538);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 42);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // fThongTinLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1310, 593);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiemCuoiKi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiemGiuaKi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiem15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbTenLop);
            this.Controls.Add(this.dtgvDiem);
            this.Controls.Add(this.dtgvHS);
            this.Name = "fThongTinLopHoc";
            this.Text = "Thông tin lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHS;
        private System.Windows.Forms.DataGridView dtgvDiem;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiemMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MahocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem_MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGiuaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiem15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemGiuaKi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemCuoiKi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
    }
}