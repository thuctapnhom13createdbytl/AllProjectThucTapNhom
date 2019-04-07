namespace QuanLyThuVien.VIEW
{
    partial class fThongTinSach
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.dtpNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSoPhieuMuon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTinhTrangSach = new System.Windows.Forms.TextBox();
            this.txtMaViPham_TT = new System.Windows.Forms.TextBox();
            this.txtTenDauSach = new System.Windows.Forms.TextBox();
            this.txtSoPhieuMuon_TT = new System.Windows.Forms.TextBox();
            this.txtMaCuonSach_TT = new System.Windows.Forms.TextBox();
            this.txtNgayTra_TT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongTinMuonTra = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaViPham = new System.Windows.Forms.TextBox();
            this.txtTenViPham = new System.Windows.Forms.TextBox();
            this.txtHinhThucPhat = new System.Windows.Forms.TextBox();
            this.dgvViPham = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.radKhongTheMuon = new System.Windows.Forms.RadioButton();
            this.radCotheMuon = new System.Windows.Forms.RadioButton();
            this.txtDauSach = new System.Windows.Forms.TextBox();
            this.txtMaCuonSach = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCuonSach = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinMuonTra)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboNhanVien);
            this.tabPage1.Controls.Add(this.cboDocGia);
            this.tabPage1.Controls.Add(this.dtpNgayHenTra);
            this.tabPage1.Controls.Add(this.dtpNgayMuon);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnCapNhat);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtSoPhieuMuon);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvPhieuMuon);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu Mượn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(497, 18);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(199, 21);
            this.cboNhanVien.TabIndex = 5;
            // 
            // cboDocGia
            // 
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(497, 64);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(199, 21);
            this.cboDocGia.TabIndex = 5;
            // 
            // dtpNgayHenTra
            // 
            this.dtpNgayHenTra.Location = new System.Drawing.Point(221, 102);
            this.dtpNgayHenTra.Name = "dtpNgayHenTra";
            this.dtpNgayHenTra.Size = new System.Drawing.Size(145, 20);
            this.dtpNgayHenTra.TabIndex = 4;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(221, 64);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(145, 20);
            this.dtpNgayMuon.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(626, 169);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(514, 169);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(72, 23);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(412, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtSoPhieuMuon
            // 
            this.txtSoPhieuMuon.Location = new System.Drawing.Point(221, 18);
            this.txtSoPhieuMuon.Name = "txtSoPhieuMuon";
            this.txtSoPhieuMuon.Size = new System.Drawing.Size(145, 20);
            this.txtSoPhieuMuon.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày hẹn trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Độc giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số phiếu mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày mượn";
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(9, 216);
            this.dgvPhieuMuon.MultiSelect = false;
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(776, 198);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            this.dgvPhieuMuon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTinhTrangSach);
            this.tabPage2.Controls.Add(this.txtMaViPham_TT);
            this.tabPage2.Controls.Add(this.txtTenDauSach);
            this.tabPage2.Controls.Add(this.txtSoPhieuMuon_TT);
            this.tabPage2.Controls.Add(this.txtMaCuonSach_TT);
            this.tabPage2.Controls.Add(this.txtNgayTra_TT);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvThongTinMuonTra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin mượn trả";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTinhTrangSach
            // 
            this.txtTinhTrangSach.Location = new System.Drawing.Point(512, 28);
            this.txtTinhTrangSach.Name = "txtTinhTrangSach";
            this.txtTinhTrangSach.Size = new System.Drawing.Size(164, 20);
            this.txtTinhTrangSach.TabIndex = 3;
            // 
            // txtMaViPham_TT
            // 
            this.txtMaViPham_TT.Location = new System.Drawing.Point(512, 72);
            this.txtMaViPham_TT.Name = "txtMaViPham_TT";
            this.txtMaViPham_TT.Size = new System.Drawing.Size(164, 20);
            this.txtMaViPham_TT.TabIndex = 3;
            // 
            // txtTenDauSach
            // 
            this.txtTenDauSach.Location = new System.Drawing.Point(193, 75);
            this.txtTenDauSach.Name = "txtTenDauSach";
            this.txtTenDauSach.Size = new System.Drawing.Size(149, 20);
            this.txtTenDauSach.TabIndex = 3;
            // 
            // txtSoPhieuMuon_TT
            // 
            this.txtSoPhieuMuon_TT.Location = new System.Drawing.Point(193, 123);
            this.txtSoPhieuMuon_TT.Name = "txtSoPhieuMuon_TT";
            this.txtSoPhieuMuon_TT.Size = new System.Drawing.Size(149, 20);
            this.txtSoPhieuMuon_TT.TabIndex = 3;
            // 
            // txtMaCuonSach_TT
            // 
            this.txtMaCuonSach_TT.Location = new System.Drawing.Point(193, 28);
            this.txtMaCuonSach_TT.Name = "txtMaCuonSach_TT";
            this.txtMaCuonSach_TT.Size = new System.Drawing.Size(149, 20);
            this.txtMaCuonSach_TT.TabIndex = 3;
            // 
            // txtNgayTra_TT
            // 
            this.txtNgayTra_TT.Location = new System.Drawing.Point(193, 173);
            this.txtNgayTra_TT.Name = "txtNgayTra_TT";
            this.txtNgayTra_TT.Size = new System.Drawing.Size(149, 20);
            this.txtNgayTra_TT.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(109, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Đầu sách";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã cuốn sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số phiếu mượn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tình trạng sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngày trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã vi phạm";
            // 
            // dgvThongTinMuonTra
            // 
            this.dgvThongTinMuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinMuonTra.Location = new System.Drawing.Point(9, 237);
            this.dgvThongTinMuonTra.Name = "dgvThongTinMuonTra";
            this.dgvThongTinMuonTra.Size = new System.Drawing.Size(776, 177);
            this.dgvThongTinMuonTra.TabIndex = 0;
            this.dgvThongTinMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinMuonTra_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtMaViPham);
            this.tabPage3.Controls.Add(this.txtTenViPham);
            this.tabPage3.Controls.Add(this.txtHinhThucPhat);
            this.tabPage3.Controls.Add(this.dgvViPham);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vi phạm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(149, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Hình thức phạt";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tên vi phạm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã vi phạm";
            // 
            // txtMaViPham
            // 
            this.txtMaViPham.Location = new System.Drawing.Point(231, 41);
            this.txtMaViPham.Name = "txtMaViPham";
            this.txtMaViPham.Size = new System.Drawing.Size(66, 20);
            this.txtMaViPham.TabIndex = 3;
            // 
            // txtTenViPham
            // 
            this.txtTenViPham.Location = new System.Drawing.Point(231, 71);
            this.txtTenViPham.Multiline = true;
            this.txtTenViPham.Name = "txtTenViPham";
            this.txtTenViPham.Size = new System.Drawing.Size(321, 62);
            this.txtTenViPham.TabIndex = 3;
            // 
            // txtHinhThucPhat
            // 
            this.txtHinhThucPhat.Location = new System.Drawing.Point(232, 153);
            this.txtHinhThucPhat.Multiline = true;
            this.txtHinhThucPhat.Name = "txtHinhThucPhat";
            this.txtHinhThucPhat.Size = new System.Drawing.Size(320, 74);
            this.txtHinhThucPhat.TabIndex = 3;
            // 
            // dgvViPham
            // 
            this.dgvViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViPham.Location = new System.Drawing.Point(9, 245);
            this.dgvViPham.Name = "dgvViPham";
            this.dgvViPham.Size = new System.Drawing.Size(776, 169);
            this.dgvViPham.TabIndex = 0;
            this.dgvViPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViPham_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.radKhongTheMuon);
            this.tabPage4.Controls.Add(this.radCotheMuon);
            this.tabPage4.Controls.Add(this.txtDauSach);
            this.tabPage4.Controls.Add(this.txtMaCuonSach);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dgvCuonSach);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 426);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cuốn sách";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // radKhongTheMuon
            // 
            this.radKhongTheMuon.AutoSize = true;
            this.radKhongTheMuon.Location = new System.Drawing.Point(316, 111);
            this.radKhongTheMuon.Name = "radKhongTheMuon";
            this.radKhongTheMuon.Size = new System.Drawing.Size(103, 17);
            this.radKhongTheMuon.TabIndex = 5;
            this.radKhongTheMuon.TabStop = true;
            this.radKhongTheMuon.Text = "Không thể mượn";
            this.radKhongTheMuon.UseVisualStyleBackColor = true;
            // 
            // radCotheMuon
            // 
            this.radCotheMuon.AutoSize = true;
            this.radCotheMuon.Location = new System.Drawing.Point(213, 111);
            this.radCotheMuon.Name = "radCotheMuon";
            this.radCotheMuon.Size = new System.Drawing.Size(85, 17);
            this.radCotheMuon.TabIndex = 5;
            this.radCotheMuon.TabStop = true;
            this.radCotheMuon.Text = "Có thể mượn";
            this.radCotheMuon.UseVisualStyleBackColor = true;
            // 
            // txtDauSach
            // 
            this.txtDauSach.Location = new System.Drawing.Point(213, 69);
            this.txtDauSach.Name = "txtDauSach";
            this.txtDauSach.Size = new System.Drawing.Size(206, 20);
            this.txtDauSach.TabIndex = 4;
            // 
            // txtMaCuonSach
            // 
            this.txtMaCuonSach.Location = new System.Drawing.Point(213, 26);
            this.txtMaCuonSach.Name = "txtMaCuonSach";
            this.txtMaCuonSach.Size = new System.Drawing.Size(206, 20);
            this.txtMaCuonSach.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Mã cuốn sách";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tình trạng sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đầu sách";
            // 
            // dgvCuonSach
            // 
            this.dgvCuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuonSach.Location = new System.Drawing.Point(9, 173);
            this.dgvCuonSach.Name = "dgvCuonSach";
            this.dgvCuonSach.Size = new System.Drawing.Size(776, 241);
            this.dgvCuonSach.TabIndex = 0;
            this.dgvCuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuonSach_CellClick);
            // 
            // fThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "fThongTinSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThongTinSach";
            this.Load += new System.EventHandler(this.fThongTinSach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinMuonTra)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuonSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.DataGridView dgvThongTinMuonTra;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvViPham;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvCuonSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayTra_TT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHinhThucPhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoPhieuMuon;
        private System.Windows.Forms.TextBox txtTinhTrangSach;
        private System.Windows.Forms.TextBox txtSoPhieuMuon_TT;
        private System.Windows.Forms.TextBox txtMaCuonSach_TT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaViPham_TT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaViPham;
        private System.Windows.Forms.TextBox txtTenViPham;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDauSach;
        private System.Windows.Forms.TextBox txtMaCuonSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtpNgayHenTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.RadioButton radKhongTheMuon;
        private System.Windows.Forms.RadioButton radCotheMuon;
        private System.Windows.Forms.TextBox txtTenDauSach;
        private System.Windows.Forms.Label label17;
    }
}