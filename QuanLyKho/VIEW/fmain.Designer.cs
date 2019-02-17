namespace QuanLyKho.VIEW
{
    partial class fmain
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
            this.btnXuatSanPham = new System.Windows.Forms.Button();
            this.btnNhapSanPham = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXuatSanPham
            // 
            this.btnXuatSanPham.Image = global::QuanLyKho.Properties.Resources.forward_f2;
            this.btnXuatSanPham.Location = new System.Drawing.Point(133, 210);
            this.btnXuatSanPham.Name = "btnXuatSanPham";
            this.btnXuatSanPham.Size = new System.Drawing.Size(113, 90);
            this.btnXuatSanPham.TabIndex = 5;
            this.btnXuatSanPham.Text = "Xuất sản phẩm";
            this.btnXuatSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatSanPham.UseVisualStyleBackColor = true;
            this.btnXuatSanPham.Click += new System.EventHandler(this.btnXuatSanPham_Click);
            // 
            // btnNhapSanPham
            // 
            this.btnNhapSanPham.Image = global::QuanLyKho.Properties.Resources.add_48_hot;
            this.btnNhapSanPham.Location = new System.Drawing.Point(252, 127);
            this.btnNhapSanPham.Name = "btnNhapSanPham";
            this.btnNhapSanPham.Size = new System.Drawing.Size(113, 90);
            this.btnNhapSanPham.TabIndex = 4;
            this.btnNhapSanPham.Text = "Nhập sản phẩm";
            this.btnNhapSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhapSanPham.UseVisualStyleBackColor = true;
            this.btnNhapSanPham.Click += new System.EventHandler(this.btnNhapSanPham_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Image = global::QuanLyKho.Properties.Resources.businessmen;
            this.btnKhachHang.Location = new System.Drawing.Point(371, 210);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(112, 90);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = global::QuanLyKho.Properties.Resources.suport_F_online;
            this.btnNhanVien.Location = new System.Drawing.Point(371, 38);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(112, 90);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Image = global::QuanLyKho.Properties.Resources.data_view;
            this.btnSanPham.Location = new System.Drawing.Point(133, 38);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(113, 90);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Quản lý sản phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 370);
            this.Controls.Add(this.btnXuatSanPham);
            this.Controls.Add(this.btnNhapSanPham);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnSanPham);
            this.Name = "fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhapSanPham;
        private System.Windows.Forms.Button btnXuatSanPham;
    }
}