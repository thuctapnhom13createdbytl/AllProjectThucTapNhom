namespace QuanLyThuVien.VIEW
{
    partial class fDocGia
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.tbSDTDG = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tbDiaChiDG = new System.Windows.Forms.TextBox();
            this.tbTenDG = new System.Windows.Forms.TextBox();
            this.tbMaDG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgDocGia = new System.Windows.Forms.DataGridView();
            this.DG_MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbTenDocGia = new System.Windows.Forms.ComboBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.tbTimKiemTTV = new System.Windows.Forms.TextBox();
            this.btnXoaTTV = new System.Windows.Forms.Button();
            this.btnCapNhatTheTTV = new System.Windows.Forms.Button();
            this.btnThemTTV = new System.Windows.Forms.Button();
            this.btnTimKiemTTV = new System.Windows.Forms.Button();
            this.tbSoThe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTheThuVien = new System.Windows.Forms.DataGridView();
            this.SoThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THV_MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocGia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnCapNhat);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.tbTimKiem);
            this.tabPage1.Controls.Add(this.tbSDTDG);
            this.tabPage1.Controls.Add(this.btnTimkiem);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.tbDiaChiDG);
            this.tabPage1.Controls.Add(this.tbTenDG);
            this.tabPage1.Controls.Add(this.tbMaDG);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtgDocGia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Độc Giả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(655, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(551, 142);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(450, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(87, 142);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(258, 20);
            this.tbTimKiem.TabIndex = 2;
            // 
            // tbSDTDG
            // 
            this.tbSDTDG.Location = new System.Drawing.Point(214, 92);
            this.tbSDTDG.Name = "tbSDTDG";
            this.tbSDTDG.Size = new System.Drawing.Size(179, 20);
            this.tbSDTDG.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(6, 142);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(214, 92);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(179, 20);
            this.textBox8.TabIndex = 2;
            // 
            // tbDiaChiDG
            // 
            this.tbDiaChiDG.Location = new System.Drawing.Point(214, 59);
            this.tbDiaChiDG.Name = "tbDiaChiDG";
            this.tbDiaChiDG.Size = new System.Drawing.Size(179, 20);
            this.tbDiaChiDG.TabIndex = 2;
            // 
            // tbTenDG
            // 
            this.tbTenDG.Location = new System.Drawing.Point(214, 29);
            this.tbTenDG.Name = "tbTenDG";
            this.tbTenDG.Size = new System.Drawing.Size(153, 20);
            this.tbTenDG.TabIndex = 2;
            // 
            // tbMaDG
            // 
            this.tbMaDG.Location = new System.Drawing.Point(214, 3);
            this.tbMaDG.Name = "tbMaDG";
            this.tbMaDG.Size = new System.Drawing.Size(153, 20);
            this.tbMaDG.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên độc giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã độc giả";
            // 
            // dtgDocGia
            // 
            this.dtgDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_MaDocGia,
            this.TenDocGia,
            this.DiaChi,
            this.SDT});
            this.dtgDocGia.Location = new System.Drawing.Point(6, 181);
            this.dtgDocGia.Name = "dtgDocGia";
            this.dtgDocGia.Size = new System.Drawing.Size(766, 228);
            this.dtgDocGia.TabIndex = 0;
            // 
            // DG_MaDocGia
            // 
            this.DG_MaDocGia.DataPropertyName = "MaDocGia";
            this.DG_MaDocGia.HeaderText = "Mã độc giả";
            this.DG_MaDocGia.Name = "DG_MaDocGia";
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.Name = "TenDocGia";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbTenDocGia);
            this.tabPage2.Controls.Add(this.dtpNgayKetThuc);
            this.tabPage2.Controls.Add(this.dtpNgayBatDau);
            this.tabPage2.Controls.Add(this.tbTimKiemTTV);
            this.tabPage2.Controls.Add(this.btnXoaTTV);
            this.tabPage2.Controls.Add(this.btnCapNhatTheTTV);
            this.tabPage2.Controls.Add(this.btnThemTTV);
            this.tabPage2.Controls.Add(this.btnTimKiemTTV);
            this.tabPage2.Controls.Add(this.tbSoThe);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtgTheThuVien);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thẻ Thư Viện";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbTenDocGia
            // 
            this.cbTenDocGia.FormattingEnabled = true;
            this.cbTenDocGia.Location = new System.Drawing.Point(180, 119);
            this.cbTenDocGia.Name = "cbTenDocGia";
            this.cbTenDocGia.Size = new System.Drawing.Size(185, 21);
            this.cbTenDocGia.TabIndex = 12;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(180, 88);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(185, 20);
            this.dtpNgayKetThuc.TabIndex = 11;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(180, 59);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(185, 20);
            this.dtpNgayBatDau.TabIndex = 10;
            // 
            // tbTimKiemTTV
            // 
            this.tbTimKiemTTV.Location = new System.Drawing.Point(575, 70);
            this.tbTimKiemTTV.Name = "tbTimKiemTTV";
            this.tbTimKiemTTV.Size = new System.Drawing.Size(185, 20);
            this.tbTimKiemTTV.TabIndex = 9;
            this.tbTimKiemTTV.TextChanged += new System.EventHandler(this.tbTimKiemTTV_TextChanged);
            // 
            // btnXoaTTV
            // 
            this.btnXoaTTV.Location = new System.Drawing.Point(685, 149);
            this.btnXoaTTV.Name = "btnXoaTTV";
            this.btnXoaTTV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTTV.TabIndex = 8;
            this.btnXoaTTV.Text = "Xóa";
            this.btnXoaTTV.UseVisualStyleBackColor = true;
            this.btnXoaTTV.Click += new System.EventHandler(this.btnXoaTTV_Click);
            // 
            // btnCapNhatTheTTV
            // 
            this.btnCapNhatTheTTV.Location = new System.Drawing.Point(575, 149);
            this.btnCapNhatTheTTV.Name = "btnCapNhatTheTTV";
            this.btnCapNhatTheTTV.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatTheTTV.TabIndex = 7;
            this.btnCapNhatTheTTV.Text = "Cập Nhật";
            this.btnCapNhatTheTTV.UseVisualStyleBackColor = true;
            this.btnCapNhatTheTTV.Click += new System.EventHandler(this.btnCapNhatTheTTV_Click);
            // 
            // btnThemTTV
            // 
            this.btnThemTTV.Location = new System.Drawing.Point(469, 149);
            this.btnThemTTV.Name = "btnThemTTV";
            this.btnThemTTV.Size = new System.Drawing.Size(75, 23);
            this.btnThemTTV.TabIndex = 6;
            this.btnThemTTV.Text = "Thêm";
            this.btnThemTTV.UseVisualStyleBackColor = true;
            this.btnThemTTV.Click += new System.EventHandler(this.btnThemTTV_Click);
            // 
            // btnTimKiemTTV
            // 
            this.btnTimKiemTTV.Location = new System.Drawing.Point(469, 70);
            this.btnTimKiemTTV.Name = "btnTimKiemTTV";
            this.btnTimKiemTTV.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemTTV.TabIndex = 5;
            this.btnTimKiemTTV.Text = "Tìm Kiếm";
            this.btnTimKiemTTV.UseVisualStyleBackColor = true;
            this.btnTimKiemTTV.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSoThe
            // 
            this.tbSoThe.Location = new System.Drawing.Point(180, 26);
            this.tbSoThe.Name = "tbSoThe";
            this.tbSoThe.Size = new System.Drawing.Size(185, 20);
            this.tbSoThe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên độc giả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thẻ";
            // 
            // dtgTheThuVien
            // 
            this.dtgTheThuVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTheThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTheThuVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThe,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.THV_MaDocGia});
            this.dtgTheThuVien.Location = new System.Drawing.Point(0, 188);
            this.dtgTheThuVien.Name = "dtgTheThuVien";
            this.dtgTheThuVien.Size = new System.Drawing.Size(769, 221);
            this.dtgTheThuVien.TabIndex = 0;
            // 
            // SoThe
            // 
            this.SoThe.DataPropertyName = "SoThe";
            this.SoThe.HeaderText = "Số thẻ";
            this.SoThe.Name = "SoThe";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // THV_MaDocGia
            // 
            this.THV_MaDocGia.DataPropertyName = "MaDocGia";
            this.THV_MaDocGia.HeaderText = "Tên độc giả";
            this.THV_MaDocGia.Name = "THV_MaDocGia";
            // 
            // fDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "fDocGia";
            this.Text = "fDocGia";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocGia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheThuVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridView dtgTheThuVien;
        private System.Windows.Forms.TextBox tbSoThe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tbDiaChiDG;
        private System.Windows.Forms.TextBox tbTenDG;
        private System.Windows.Forms.TextBox tbMaDG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.TextBox tbSDTDG;
        private System.Windows.Forms.TextBox tbTimKiemTTV;
        private System.Windows.Forms.Button btnXoaTTV;
        private System.Windows.Forms.Button btnCapNhatTheTTV;
        private System.Windows.Forms.Button btnThemTTV;
        private System.Windows.Forms.Button btnTimKiemTTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn THV_MaDocGia;
        private System.Windows.Forms.ComboBox cbTenDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
    }
}