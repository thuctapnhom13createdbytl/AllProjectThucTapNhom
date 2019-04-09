namespace QuanLyThuVien.VIEW
{
    partial class fSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtTimKiemTG = new System.Windows.Forms.TextBox();
            this.btnTimKiemTG = new System.Windows.Forms.Button();
            this.dtgvTG = new System.Windows.Forms.DataGridView();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTimKiemNXB = new System.Windows.Forms.Button();
            this.txtTimKiemNXB = new System.Windows.Forms.TextBox();
            this.dtgvNXB = new System.Windows.Forms.DataGridView();
            this.NXB_MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTimKiemTheLoai = new System.Windows.Forms.Button();
            this.txtTimKiemTheLoai = new System.Windows.Forms.TextBox();
            this.dtgvTheLoai = new System.Windows.Forms.DataGridView();
            this.TL_MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL_TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnHuyDauSach = new System.Windows.Forms.Button();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.cbMaTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTimKiemDauSach = new System.Windows.Forms.TextBox();
            this.txt_TenDauSach = new System.Windows.Forms.TextBox();
            this.txt_MaDauSach = new System.Windows.Forms.TextBox();
            this.btnXoaDauSach = new System.Windows.Forms.Button();
            this.btnCapNhatDauSach = new System.Windows.Forms.Button();
            this.btnThemDauSach = new System.Windows.Forms.Button();
            this.btnTimKiemDauSach = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvDauSach = new System.Windows.Forms.DataGridView();
            this.DS_MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNXB)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheLoai)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtTimKiemTG);
            this.tabPage5.Controls.Add(this.btnTimKiemTG);
            this.tabPage5.Controls.Add(this.dtgvTG);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(955, 597);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tác Giả";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemTG
            // 
            this.txtTimKiemTG.Location = new System.Drawing.Point(6, 6);
            this.txtTimKiemTG.Name = "txtTimKiemTG";
            this.txtTimKiemTG.Size = new System.Drawing.Size(268, 20);
            this.txtTimKiemTG.TabIndex = 2;
            // 
            // btnTimKiemTG
            // 
            this.btnTimKiemTG.Location = new System.Drawing.Point(280, 4);
            this.btnTimKiemTG.Name = "btnTimKiemTG";
            this.btnTimKiemTG.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemTG.TabIndex = 1;
            this.btnTimKiemTG.Text = "Tìm kiếm";
            this.btnTimKiemTG.UseVisualStyleBackColor = true;
            this.btnTimKiemTG.Click += new System.EventHandler(this.btnTimKiemTG_Click);
            // 
            // dtgvTG
            // 
            this.dtgvTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.TenTacGia,
            this.DiaChi,
            this.SDT});
            this.dtgvTG.Location = new System.Drawing.Point(6, 32);
            this.dtgvTG.Name = "dtgvTG";
            this.dtgvTG.ReadOnly = true;
            this.dtgvTG.Size = new System.Drawing.Size(943, 559);
            this.dtgvTG.TabIndex = 0;
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "Mã Tác Giả";
            this.MaTacGia.Name = "MaTacGia";
            this.MaTacGia.ReadOnly = true;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTimKiemNXB);
            this.tabPage2.Controls.Add(this.txtTimKiemNXB);
            this.tabPage2.Controls.Add(this.dtgvNXB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhà Xuất Bản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemNXB
            // 
            this.btnTimKiemNXB.Location = new System.Drawing.Point(352, 9);
            this.btnTimKiemNXB.Name = "btnTimKiemNXB";
            this.btnTimKiemNXB.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemNXB.TabIndex = 2;
            this.btnTimKiemNXB.Text = "Tìm kiếm";
            this.btnTimKiemNXB.UseVisualStyleBackColor = true;
            this.btnTimKiemNXB.Click += new System.EventHandler(this.btnTimKiemNXB_Click);
            // 
            // txtTimKiemNXB
            // 
            this.txtTimKiemNXB.Location = new System.Drawing.Point(6, 11);
            this.txtTimKiemNXB.Name = "txtTimKiemNXB";
            this.txtTimKiemNXB.Size = new System.Drawing.Size(340, 20);
            this.txtTimKiemNXB.TabIndex = 1;
            // 
            // dtgvNXB
            // 
            this.dtgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNXB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NXB_MaNXB,
            this.TenNXB,
            this.NXB_DiaChi});
            this.dtgvNXB.Location = new System.Drawing.Point(6, 41);
            this.dtgvNXB.Name = "dtgvNXB";
            this.dtgvNXB.ReadOnly = true;
            this.dtgvNXB.Size = new System.Drawing.Size(943, 550);
            this.dtgvNXB.TabIndex = 0;
            // 
            // NXB_MaNXB
            // 
            this.NXB_MaNXB.DataPropertyName = "MaNXB";
            this.NXB_MaNXB.HeaderText = "Mã nhà xuất bản";
            this.NXB_MaNXB.Name = "NXB_MaNXB";
            this.NXB_MaNXB.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên nhà xuất bản";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // NXB_DiaChi
            // 
            this.NXB_DiaChi.DataPropertyName = "DiaChi";
            this.NXB_DiaChi.HeaderText = "Địa chỉ";
            this.NXB_DiaChi.Name = "NXB_DiaChi";
            this.NXB_DiaChi.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTimKiemTheLoai);
            this.tabPage1.Controls.Add(this.txtTimKiemTheLoai);
            this.tabPage1.Controls.Add(this.dtgvTheLoai);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thể Loại";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemTheLoai
            // 
            this.btnTimKiemTheLoai.Location = new System.Drawing.Point(502, 6);
            this.btnTimKiemTheLoai.Name = "btnTimKiemTheLoai";
            this.btnTimKiemTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemTheLoai.TabIndex = 2;
            this.btnTimKiemTheLoai.Text = "Tìm kiếm";
            this.btnTimKiemTheLoai.UseVisualStyleBackColor = true;
            this.btnTimKiemTheLoai.Click += new System.EventHandler(this.btnTimKiemTheLoai_Click);
            // 
            // txtTimKiemTheLoai
            // 
            this.txtTimKiemTheLoai.Location = new System.Drawing.Point(3, 6);
            this.txtTimKiemTheLoai.Name = "txtTimKiemTheLoai";
            this.txtTimKiemTheLoai.Size = new System.Drawing.Size(493, 20);
            this.txtTimKiemTheLoai.TabIndex = 1;
            // 
            // dtgvTheLoai
            // 
            this.dtgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTheLoai.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TL_MaTheLoai,
            this.TL_TenTheLoai});
            this.dtgvTheLoai.Location = new System.Drawing.Point(3, 33);
            this.dtgvTheLoai.Name = "dtgvTheLoai";
            this.dtgvTheLoai.ReadOnly = true;
            this.dtgvTheLoai.Size = new System.Drawing.Size(946, 558);
            this.dtgvTheLoai.TabIndex = 0;
            // 
            // TL_MaTheLoai
            // 
            this.TL_MaTheLoai.DataPropertyName = "MaTheLoai";
            this.TL_MaTheLoai.HeaderText = "Mã thể loại";
            this.TL_MaTheLoai.Name = "TL_MaTheLoai";
            this.TL_MaTheLoai.ReadOnly = true;
            // 
            // TL_TenTheLoai
            // 
            this.TL_TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TL_TenTheLoai.HeaderText = "Tên thể loại";
            this.TL_TenTheLoai.Name = "TL_TenTheLoai";
            this.TL_TenTheLoai.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnHuyDauSach);
            this.tabPage4.Controls.Add(this.cbMaNXB);
            this.tabPage4.Controls.Add(this.cbMaTheLoai);
            this.tabPage4.Controls.Add(this.txtTimKiemDauSach);
            this.tabPage4.Controls.Add(this.txt_TenDauSach);
            this.tabPage4.Controls.Add(this.txt_MaDauSach);
            this.tabPage4.Controls.Add(this.btnXoaDauSach);
            this.tabPage4.Controls.Add(this.btnCapNhatDauSach);
            this.tabPage4.Controls.Add(this.btnThemDauSach);
            this.tabPage4.Controls.Add(this.btnTimKiemDauSach);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dtgvDauSach);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(955, 597);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Đầu Sách";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnHuyDauSach
            // 
            this.btnHuyDauSach.Location = new System.Drawing.Point(763, 68);
            this.btnHuyDauSach.Name = "btnHuyDauSach";
            this.btnHuyDauSach.Size = new System.Drawing.Size(75, 23);
            this.btnHuyDauSach.TabIndex = 16;
            this.btnHuyDauSach.Text = "Hủy";
            this.btnHuyDauSach.UseVisualStyleBackColor = true;
            this.btnHuyDauSach.Click += new System.EventHandler(this.btnHuyDauSach_Click);
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.Location = new System.Drawing.Point(570, 33);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(174, 21);
            this.cbMaNXB.TabIndex = 15;
            // 
            // cbMaTheLoai
            // 
            this.cbMaTheLoai.FormattingEnabled = true;
            this.cbMaTheLoai.Location = new System.Drawing.Point(106, 37);
            this.cbMaTheLoai.Name = "cbMaTheLoai";
            this.cbMaTheLoai.Size = new System.Drawing.Size(127, 21);
            this.cbMaTheLoai.TabIndex = 14;
            // 
            // txtTimKiemDauSach
            // 
            this.txtTimKiemDauSach.Location = new System.Drawing.Point(106, 71);
            this.txtTimKiemDauSach.Name = "txtTimKiemDauSach";
            this.txtTimKiemDauSach.Size = new System.Drawing.Size(243, 20);
            this.txtTimKiemDauSach.TabIndex = 13;
            // 
            // txt_TenDauSach
            // 
            this.txt_TenDauSach.Location = new System.Drawing.Point(570, 3);
            this.txt_TenDauSach.Name = "txt_TenDauSach";
            this.txt_TenDauSach.Size = new System.Drawing.Size(382, 20);
            this.txt_TenDauSach.TabIndex = 6;
            // 
            // txt_MaDauSach
            // 
            this.txt_MaDauSach.Location = new System.Drawing.Point(106, 7);
            this.txt_MaDauSach.Name = "txt_MaDauSach";
            this.txt_MaDauSach.ReadOnly = true;
            this.txt_MaDauSach.Size = new System.Drawing.Size(243, 20);
            this.txt_MaDauSach.TabIndex = 5;
            // 
            // btnXoaDauSach
            // 
            this.btnXoaDauSach.Location = new System.Drawing.Point(669, 68);
            this.btnXoaDauSach.Name = "btnXoaDauSach";
            this.btnXoaDauSach.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDauSach.TabIndex = 12;
            this.btnXoaDauSach.Text = "Xóa";
            this.btnXoaDauSach.UseVisualStyleBackColor = true;
            this.btnXoaDauSach.Click += new System.EventHandler(this.btnXoaDauSach_Click);
            // 
            // btnCapNhatDauSach
            // 
            this.btnCapNhatDauSach.Location = new System.Drawing.Point(570, 68);
            this.btnCapNhatDauSach.Name = "btnCapNhatDauSach";
            this.btnCapNhatDauSach.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatDauSach.TabIndex = 11;
            this.btnCapNhatDauSach.Text = "Cập Nhật";
            this.btnCapNhatDauSach.UseVisualStyleBackColor = true;
            this.btnCapNhatDauSach.Click += new System.EventHandler(this.btnCapNhatDauSach_Click);
            // 
            // btnThemDauSach
            // 
            this.btnThemDauSach.Location = new System.Drawing.Point(473, 68);
            this.btnThemDauSach.Name = "btnThemDauSach";
            this.btnThemDauSach.Size = new System.Drawing.Size(75, 23);
            this.btnThemDauSach.TabIndex = 10;
            this.btnThemDauSach.Text = "Thêm";
            this.btnThemDauSach.UseVisualStyleBackColor = true;
            this.btnThemDauSach.Click += new System.EventHandler(this.btnThemDauSach_Click);
            // 
            // btnTimKiemDauSach
            // 
            this.btnTimKiemDauSach.Location = new System.Drawing.Point(11, 69);
            this.btnTimKiemDauSach.Name = "btnTimKiemDauSach";
            this.btnTimKiemDauSach.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemDauSach.TabIndex = 9;
            this.btnTimKiemDauSach.Text = "Tìm Kiếm";
            this.btnTimKiemDauSach.UseVisualStyleBackColor = true;
            this.btnTimKiemDauSach.Click += new System.EventHandler(this.btnTimKiemDauSach_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Thể loại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nhà xuất bản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên đầu sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã đầu sách";
            // 
            // dtgvDauSach
            // 
            this.dtgvDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDauSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DS_MaDauSach,
            this.TenDauSach,
            this.DS_MaTheLoai,
            this.DS_MaNXB,
            this.TheLoai,
            this.NXB});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDauSach.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvDauSach.Location = new System.Drawing.Point(11, 98);
            this.dtgvDauSach.Name = "dtgvDauSach";
            this.dtgvDauSach.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDauSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvDauSach.Size = new System.Drawing.Size(941, 496);
            this.dtgvDauSach.TabIndex = 0;
            // 
            // DS_MaDauSach
            // 
            this.DS_MaDauSach.DataPropertyName = "MaDauSach";
            this.DS_MaDauSach.HeaderText = "Mã đầu sách";
            this.DS_MaDauSach.Name = "DS_MaDauSach";
            this.DS_MaDauSach.ReadOnly = true;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            // 
            // DS_MaTheLoai
            // 
            this.DS_MaTheLoai.DataPropertyName = "MaTheLoai";
            this.DS_MaTheLoai.HeaderText = "Mã thể loại";
            this.DS_MaTheLoai.Name = "DS_MaTheLoai";
            this.DS_MaTheLoai.ReadOnly = true;
            this.DS_MaTheLoai.Visible = false;
            // 
            // DS_MaNXB
            // 
            this.DS_MaNXB.DataPropertyName = "MaNXB";
            this.DS_MaNXB.HeaderText = "Mã nhà xuất bản";
            this.DS_MaNXB.Name = "DS_MaNXB";
            this.DS_MaNXB.ReadOnly = true;
            this.DS_MaNXB.Visible = false;
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TenTheLoai";
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // NXB
            // 
            this.NXB.DataPropertyName = "TenNXB";
            this.NXB.HeaderText = "Nhà xuất bản";
            this.NXB.Name = "NXB";
            this.NXB.ReadOnly = true;
            // 
            // fSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 631);
            this.Controls.Add(this.tabControl1);
            this.Name = "fSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sách";
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNXB)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheLoai)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtTimKiemTG;
        private System.Windows.Forms.Button btnTimKiemTG;
        private System.Windows.Forms.DataGridView dtgvTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTimKiemNXB;
        private System.Windows.Forms.TextBox txtTimKiemNXB;
        private System.Windows.Forms.DataGridView dtgvNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB_MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB_DiaChi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTimKiemTheLoai;
        private System.Windows.Forms.TextBox txtTimKiemTheLoai;
        private System.Windows.Forms.DataGridView dtgvTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL_MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL_TenTheLoai;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtTimKiemDauSach;
        private System.Windows.Forms.TextBox txt_TenDauSach;
        private System.Windows.Forms.TextBox txt_MaDauSach;
        private System.Windows.Forms.Button btnXoaDauSach;
        private System.Windows.Forms.Button btnCapNhatDauSach;
        private System.Windows.Forms.Button btnThemDauSach;
        private System.Windows.Forms.Button btnTimKiemDauSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvDauSach;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private System.Windows.Forms.ComboBox cbMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.Button btnHuyDauSach;
    }
}