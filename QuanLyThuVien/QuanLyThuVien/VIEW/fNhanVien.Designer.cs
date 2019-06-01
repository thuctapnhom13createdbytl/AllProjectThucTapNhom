namespace QuanLyThuVien.VIEW
{
    partial class fNhanVien
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
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.NV_MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hotenNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_dcNV = new System.Windows.Forms.TextBox();
            this.txt_sdtNV = new System.Windows.Forms.TextBox();
            this.btn_TimKiemNV = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_CapNhatNV = new System.Windows.Forms.Button();
            this.txt_timkiemNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NV_MaNhanVien,
            this.HoTen,
            this.DiaChi,
            this.SDT});
            this.dtgNhanVien.Location = new System.Drawing.Point(0, 197);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.Size = new System.Drawing.Size(797, 241);
            this.dtgNhanVien.TabIndex = 0;
            // 
            // NV_MaNhanVien
            // 
            this.NV_MaNhanVien.DataPropertyName = "MaNhanVien";
            this.NV_MaNhanVien.HeaderText = "Mã nhân viên";
            this.NV_MaNhanVien.Name = "NV_MaNhanVien";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SĐT";
            // 
            // txt_hotenNV
            // 
            this.txt_hotenNV.Location = new System.Drawing.Point(229, 35);
            this.txt_hotenNV.Name = "txt_hotenNV";
            this.txt_hotenNV.Size = new System.Drawing.Size(170, 20);
            this.txt_hotenNV.TabIndex = 2;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(229, 6);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(170, 20);
            this.txt_MaNV.TabIndex = 2;
            // 
            // txt_dcNV
            // 
            this.txt_dcNV.Location = new System.Drawing.Point(229, 64);
            this.txt_dcNV.Name = "txt_dcNV";
            this.txt_dcNV.Size = new System.Drawing.Size(170, 20);
            this.txt_dcNV.TabIndex = 2;
            // 
            // txt_sdtNV
            // 
            this.txt_sdtNV.Location = new System.Drawing.Point(229, 93);
            this.txt_sdtNV.Name = "txt_sdtNV";
            this.txt_sdtNV.Size = new System.Drawing.Size(170, 20);
            this.txt_sdtNV.TabIndex = 2;
            // 
            // btn_TimKiemNV
            // 
            this.btn_TimKiemNV.Location = new System.Drawing.Point(12, 154);
            this.btn_TimKiemNV.Name = "btn_TimKiemNV";
            this.btn_TimKiemNV.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiemNV.TabIndex = 3;
            this.btn_TimKiemNV.Text = "Tìm Kiếm";
            this.btn_TimKiemNV.UseVisualStyleBackColor = true;
            this.btn_TimKiemNV.Click += new System.EventHandler(this.btn_TimKiemNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(423, 143);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(75, 27);
            this.btn_ThemNV.TabIndex = 4;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Location = new System.Drawing.Point(620, 146);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(75, 21);
            this.btn_XoaNV.TabIndex = 4;
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_CapNhatNV
            // 
            this.btn_CapNhatNV.Location = new System.Drawing.Point(526, 143);
            this.btn_CapNhatNV.Name = "btn_CapNhatNV";
            this.btn_CapNhatNV.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhatNV.TabIndex = 4;
            this.btn_CapNhatNV.Text = "Cập Nhật";
            this.btn_CapNhatNV.UseVisualStyleBackColor = true;
            this.btn_CapNhatNV.Click += new System.EventHandler(this.btn_CapNhatNV_Click);
            // 
            // txt_timkiemNV
            // 
            this.txt_timkiemNV.Location = new System.Drawing.Point(112, 156);
            this.txt_timkiemNV.Name = "txt_timkiemNV";
            this.txt_timkiemNV.Size = new System.Drawing.Size(216, 20);
            this.txt_timkiemNV.TabIndex = 5;
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_timkiemNV);
            this.Controls.Add(this.btn_CapNhatNV);
            this.Controls.Add(this.btn_XoaNV);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.btn_TimKiemNV);
            this.Controls.Add(this.txt_sdtNV);
            this.Controls.Add(this.txt_dcNV);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.txt_hotenNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgNhanVien);
            this.Name = "fNhanVien";
            this.Text = "fNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV_MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hotenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_dcNV;
        private System.Windows.Forms.TextBox txt_sdtNV;
        private System.Windows.Forms.Button btn_TimKiemNV;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_CapNhatNV;
        private System.Windows.Forms.TextBox txt_timkiemNV;
    }
}