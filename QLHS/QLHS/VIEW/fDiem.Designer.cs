namespace QLHS
{
    partial class fDiem
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
            this.qLDiemHocSinhDataSet2 = new QLHS.QLDiemHocSinhDataSet2();
            this.timKiemHocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timKiemHocSinhTableAdapter = new QLHS.QLDiemHocSinhDataSet2TableAdapters.TimKiemHocSinhTableAdapter();
            this.DiemHocSinh = new System.Windows.Forms.TabPage();
            this.dtgDiem = new System.Windows.Forms.DataGridView();
            this.maDiemMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHocKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHocKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHocSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHocSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGiuaKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trungBinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTenHocKy = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.txtDiem15 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtMaDiem = new System.Windows.Forms.TextBox();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemHocSinhDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemHocSinhBindingSource)).BeginInit();
            this.DiemHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLDiemHocSinhDataSet2
            // 
            this.qLDiemHocSinhDataSet2.DataSetName = "QLDiemHocSinhDataSet2";
            this.qLDiemHocSinhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timKiemHocSinhBindingSource
            // 
            this.timKiemHocSinhBindingSource.DataMember = "TimKiemHocSinh";
            this.timKiemHocSinhBindingSource.DataSource = this.qLDiemHocSinhDataSet2;
            // 
            // timKiemHocSinhTableAdapter
            // 
            this.timKiemHocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // DiemHocSinh
            // 
            this.DiemHocSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DiemHocSinh.Controls.Add(this.dtgDiem);
            this.DiemHocSinh.Controls.Add(this.cbTenHocKy);
            this.DiemHocSinh.Controls.Add(this.comboBox1);
            this.DiemHocSinh.Controls.Add(this.cbTenMonHoc);
            this.DiemHocSinh.Controls.Add(this.txtDiemTB);
            this.DiemHocSinh.Controls.Add(this.txtDiem15);
            this.DiemHocSinh.Controls.Add(this.textBox9);
            this.DiemHocSinh.Controls.Add(this.txtMaDiem);
            this.DiemHocSinh.Controls.Add(this.txtMaHocSinh);
            this.DiemHocSinh.Controls.Add(this.txtTenHocSinh);
            this.DiemHocSinh.Controls.Add(this.txtDiemThi);
            this.DiemHocSinh.Controls.Add(this.txtDiemGK);
            this.DiemHocSinh.Controls.Add(this.label7);
            this.DiemHocSinh.Controls.Add(this.label6);
            this.DiemHocSinh.Controls.Add(this.label9);
            this.DiemHocSinh.Controls.Add(this.btnXoa);
            this.DiemHocSinh.Controls.Add(this.btnSua);
            this.DiemHocSinh.Controls.Add(this.btnTimKiem);
            this.DiemHocSinh.Controls.Add(this.btnThem);
            this.DiemHocSinh.Controls.Add(this.label8);
            this.DiemHocSinh.Controls.Add(this.label5);
            this.DiemHocSinh.Controls.Add(this.label4);
            this.DiemHocSinh.Controls.Add(this.label3);
            this.DiemHocSinh.Controls.Add(this.label10);
            this.DiemHocSinh.Controls.Add(this.label2);
            this.DiemHocSinh.Controls.Add(this.label1);
            this.DiemHocSinh.Location = new System.Drawing.Point(4, 22);
            this.DiemHocSinh.Name = "DiemHocSinh";
            this.DiemHocSinh.Padding = new System.Windows.Forms.Padding(3);
            this.DiemHocSinh.Size = new System.Drawing.Size(1255, 665);
            this.DiemHocSinh.TabIndex = 0;
            this.DiemHocSinh.Text = "Điểm Học Sinh";
            // 
            // dtgDiem
            // 
            this.dtgDiem.AutoGenerateColumns = false;
            this.dtgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiemMonDataGridViewTextBoxColumn,
            this.maMonHocDataGridViewTextBoxColumn,
            this.maHocKyDataGridViewTextBoxColumn,
            this.tenHocKyDataGridViewTextBoxColumn,
            this.maHocSinhDataGridViewTextBoxColumn,
            this.tenHocSinhDataGridViewTextBoxColumn,
            this.tenMonHocDataGridViewTextBoxColumn,
            this.diem15DataGridViewTextBoxColumn,
            this.diemGiuaKyDataGridViewTextBoxColumn,
            this.diemThiDataGridViewTextBoxColumn,
            this.trungBinhDataGridViewTextBoxColumn});
            this.dtgDiem.DataSource = this.timKiemHocSinhBindingSource;
            this.dtgDiem.Location = new System.Drawing.Point(0, 321);
            this.dtgDiem.Name = "dtgDiem";
            this.dtgDiem.Size = new System.Drawing.Size(1255, 348);
            this.dtgDiem.TabIndex = 34;
            // 
            // maDiemMonDataGridViewTextBoxColumn
            // 
            this.maDiemMonDataGridViewTextBoxColumn.DataPropertyName = "MaDiemMon";
            this.maDiemMonDataGridViewTextBoxColumn.HeaderText = "MaDiemMon";
            this.maDiemMonDataGridViewTextBoxColumn.Name = "maDiemMonDataGridViewTextBoxColumn";
            this.maDiemMonDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDiemMonDataGridViewTextBoxColumn.Visible = false;
            // 
            // maMonHocDataGridViewTextBoxColumn
            // 
            this.maMonHocDataGridViewTextBoxColumn.DataPropertyName = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.HeaderText = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.Name = "maMonHocDataGridViewTextBoxColumn";
            this.maMonHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.maMonHocDataGridViewTextBoxColumn.Visible = false;
            // 
            // maHocKyDataGridViewTextBoxColumn
            // 
            this.maHocKyDataGridViewTextBoxColumn.DataPropertyName = "MaHocKy";
            this.maHocKyDataGridViewTextBoxColumn.HeaderText = "MaHocKy";
            this.maHocKyDataGridViewTextBoxColumn.Name = "maHocKyDataGridViewTextBoxColumn";
            this.maHocKyDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHocKyDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenHocKyDataGridViewTextBoxColumn
            // 
            this.tenHocKyDataGridViewTextBoxColumn.DataPropertyName = "TenHocKy";
            this.tenHocKyDataGridViewTextBoxColumn.HeaderText = "Học Kỳ";
            this.tenHocKyDataGridViewTextBoxColumn.Name = "tenHocKyDataGridViewTextBoxColumn";
            // 
            // maHocSinhDataGridViewTextBoxColumn
            // 
            this.maHocSinhDataGridViewTextBoxColumn.DataPropertyName = "MaHocSinh";
            this.maHocSinhDataGridViewTextBoxColumn.HeaderText = "Mã Học Sinh";
            this.maHocSinhDataGridViewTextBoxColumn.Name = "maHocSinhDataGridViewTextBoxColumn";
            this.maHocSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHocSinhDataGridViewTextBoxColumn
            // 
            this.tenHocSinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHocSinhDataGridViewTextBoxColumn.DataPropertyName = "TenHocSinh";
            this.tenHocSinhDataGridViewTextBoxColumn.HeaderText = "Học Sinh";
            this.tenHocSinhDataGridViewTextBoxColumn.Name = "tenHocSinhDataGridViewTextBoxColumn";
            // 
            // tenMonHocDataGridViewTextBoxColumn
            // 
            this.tenMonHocDataGridViewTextBoxColumn.DataPropertyName = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.HeaderText = "Tên Môn Học";
            this.tenMonHocDataGridViewTextBoxColumn.Name = "tenMonHocDataGridViewTextBoxColumn";
            this.tenMonHocDataGridViewTextBoxColumn.Width = 150;
            // 
            // diem15DataGridViewTextBoxColumn
            // 
            this.diem15DataGridViewTextBoxColumn.DataPropertyName = "Diem15";
            this.diem15DataGridViewTextBoxColumn.HeaderText = "Điểm 15 phút";
            this.diem15DataGridViewTextBoxColumn.Name = "diem15DataGridViewTextBoxColumn";
            this.diem15DataGridViewTextBoxColumn.Width = 120;
            // 
            // diemGiuaKyDataGridViewTextBoxColumn
            // 
            this.diemGiuaKyDataGridViewTextBoxColumn.DataPropertyName = "DiemGiuaKy";
            this.diemGiuaKyDataGridViewTextBoxColumn.HeaderText = "Điểm Giữa Kỳ";
            this.diemGiuaKyDataGridViewTextBoxColumn.Name = "diemGiuaKyDataGridViewTextBoxColumn";
            this.diemGiuaKyDataGridViewTextBoxColumn.Width = 120;
            // 
            // diemThiDataGridViewTextBoxColumn
            // 
            this.diemThiDataGridViewTextBoxColumn.DataPropertyName = "DiemThi";
            this.diemThiDataGridViewTextBoxColumn.HeaderText = "Điểm Thi";
            this.diemThiDataGridViewTextBoxColumn.Name = "diemThiDataGridViewTextBoxColumn";
            this.diemThiDataGridViewTextBoxColumn.Width = 120;
            // 
            // trungBinhDataGridViewTextBoxColumn
            // 
            this.trungBinhDataGridViewTextBoxColumn.DataPropertyName = "TrungBinh";
            this.trungBinhDataGridViewTextBoxColumn.HeaderText = "Điểm Trung Bình";
            this.trungBinhDataGridViewTextBoxColumn.Name = "trungBinhDataGridViewTextBoxColumn";
            this.trungBinhDataGridViewTextBoxColumn.Width = 120;
            // 
            // cbTenHocKy
            // 
            this.cbTenHocKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenHocKy.FormattingEnabled = true;
            this.cbTenHocKy.Location = new System.Drawing.Point(1038, 146);
            this.cbTenHocKy.Name = "cbTenHocKy";
            this.cbTenHocKy.Size = new System.Drawing.Size(205, 29);
            this.cbTenHocKy.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1038, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // cbTenMonHoc
            // 
            this.cbTenMonHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenMonHoc.FormattingEnabled = true;
            this.cbTenMonHoc.Location = new System.Drawing.Point(616, 69);
            this.cbTenMonHoc.Name = "cbTenMonHoc";
            this.cbTenMonHoc.Size = new System.Drawing.Size(205, 29);
            this.cbTenMonHoc.TabIndex = 33;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiemTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTB.Location = new System.Drawing.Point(1035, 69);
            this.txtDiemTB.Multiline = true;
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(205, 32);
            this.txtDiemTB.TabIndex = 32;
            // 
            // txtDiem15
            // 
            this.txtDiem15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiem15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem15.Location = new System.Drawing.Point(616, 208);
            this.txtDiem15.Multiline = true;
            this.txtDiem15.Name = "txtDiem15";
            this.txtDiem15.Size = new System.Drawing.Size(205, 32);
            this.txtDiem15.TabIndex = 30;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(335, 263);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(305, 40);
            this.textBox9.TabIndex = 27;
            // 
            // txtMaDiem
            // 
            this.txtMaDiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaDiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDiem.Location = new System.Drawing.Point(150, 69);
            this.txtMaDiem.Multiline = true;
            this.txtMaDiem.Name = "txtMaDiem";
            this.txtMaDiem.Size = new System.Drawing.Size(205, 32);
            this.txtMaDiem.TabIndex = 21;
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaHocSinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocSinh.Location = new System.Drawing.Point(150, 146);
            this.txtMaHocSinh.Multiline = true;
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.ReadOnly = true;
            this.txtMaHocSinh.Size = new System.Drawing.Size(205, 32);
            this.txtMaHocSinh.TabIndex = 20;
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenHocSinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHocSinh.Location = new System.Drawing.Point(150, 208);
            this.txtTenHocSinh.Multiline = true;
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.ReadOnly = true;
            this.txtTenHocSinh.Size = new System.Drawing.Size(205, 32);
            this.txtTenHocSinh.TabIndex = 20;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiemThi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi.Location = new System.Drawing.Point(1038, 208);
            this.txtDiemThi.Multiline = true;
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(205, 32);
            this.txtDiemThi.TabIndex = 17;
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiemGK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemGK.Location = new System.Drawing.Point(616, 133);
            this.txtDiemGK.Multiline = true;
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(205, 32);
            this.txtDiemGK.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(868, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Điểm Trung Bình:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Điểm 15 Phút:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(443, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "QUẢN LÝ ĐIỂM HỌC SINH";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1082, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(914, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(192, 263);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 40);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(746, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(896, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Học Kỳ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(871, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Điểm Thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điểm Giữa Kỳ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Môn Học:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Học Và Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Điểm:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DiemHocSinh);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // fDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 688);
            this.Controls.Add(this.tabControl1);
            this.Name = "fDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDiem";
            this.Load += new System.EventHandler(this.fDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemHocSinhDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemHocSinhBindingSource)).EndInit();
            this.DiemHocSinh.ResumeLayout(false);
            this.DiemHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource timKiemHocSinhBindingSource;
        private QLDiemHocSinhDataSet2 qLDiemHocSinhDataSet2;
        private QLDiemHocSinhDataSet2TableAdapters.TimKiemHocSinhTableAdapter timKiemHocSinhTableAdapter;
        private System.Windows.Forms.TabPage DiemHocSinh;
        private System.Windows.Forms.DataGridView dtgDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiemMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHocKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHocKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHocSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHocSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGiuaKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trungBinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbTenHocKy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbTenMonHoc;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.TextBox txtDiem15;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtMaDiem;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiemGK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}