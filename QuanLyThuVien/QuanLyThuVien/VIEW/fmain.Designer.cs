namespace QuanLyThuVien.VIEW
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
            this.btnSachMuon = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSachMuon
            // 
            this.btnSachMuon.BackgroundImage = global::QuanLyThuVien.Properties.Resources.addedit;
            this.btnSachMuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSachMuon.Location = new System.Drawing.Point(410, 195);
            this.btnSachMuon.Name = "btnSachMuon";
            this.btnSachMuon.Size = new System.Drawing.Size(97, 103);
            this.btnSachMuon.TabIndex = 3;
            this.btnSachMuon.Text = "Thông Tin Sách Mượn";
            this.btnSachMuon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSachMuon.UseVisualStyleBackColor = true;
            this.btnSachMuon.Click += new System.EventHandler(this.btnSachMuon_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackgroundImage = global::QuanLyThuVien.Properties.Resources.user1;
            this.btnDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDocGia.Location = new System.Drawing.Point(239, 195);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(96, 103);
            this.btnDocGia.TabIndex = 2;
            this.btnDocGia.Text = "Độc Giả";
            this.btnDocGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackgroundImage = global::QuanLyThuVien.Properties.Resources.suport_M_online;
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNhanVien.Location = new System.Drawing.Point(410, 45);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(97, 97);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackgroundImage = global::QuanLyThuVien.Properties.Resources.books;
            this.btnSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSach.Location = new System.Drawing.Point(239, 45);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(96, 97);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSachMuon);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnSach);
            this.Name = "fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnSachMuon;
    }
}