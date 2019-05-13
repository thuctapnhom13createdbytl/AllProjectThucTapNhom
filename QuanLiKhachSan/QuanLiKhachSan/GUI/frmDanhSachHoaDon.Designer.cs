namespace QuanLiKhachSan.GUI
{
    partial class frmDanhSachHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachHoaDon));
            this.lvDanhSachHoaDon = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tstbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.tstbtnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDanhSachHoaDon
            // 
            // 
            // 
            // 
            this.lvDanhSachHoaDon.Border.Class = "ListViewBorder";
            this.lvDanhSachHoaDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvDanhSachHoaDon.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachHoaDon.FullRowSelect = true;
            this.lvDanhSachHoaDon.GridLines = true;
            this.lvDanhSachHoaDon.Location = new System.Drawing.Point(0, 130);
            this.lvDanhSachHoaDon.Name = "lvDanhSachHoaDon";
            this.lvDanhSachHoaDon.Size = new System.Drawing.Size(800, 320);
            this.lvDanhSachHoaDon.TabIndex = 75;
            this.lvDanhSachHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hóa Đơn";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Phiếu Thuê";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày HĐ";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hình Thức TT";
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phụ Thu";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giảm Giá KH";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng Tiền";
            this.columnHeader7.Width = 125;
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbtnThoat,
            this.tstbtnCapNhat});
            this.toolStrip.Location = new System.Drawing.Point(0, 105);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 74;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tstbtnThoat
            // 
            this.tstbtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("tstbtnThoat.Image")));
            this.tstbtnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbtnThoat.Name = "tstbtnThoat";
            this.tstbtnThoat.Size = new System.Drawing.Size(61, 22);
            this.tstbtnThoat.Text = "Thoát";
            this.tstbtnThoat.Click += new System.EventHandler(this.tstbtnThoat_Click);
            // 
            // tstbtnCapNhat
            // 
            this.tstbtnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("tstbtnCapNhat.Image")));
            this.tstbtnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbtnCapNhat.Name = "tstbtnCapNhat";
            this.tstbtnCapNhat.Size = new System.Drawing.Size(80, 22);
            this.tstbtnCapNhat.Text = "Cập Nhật";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 105);
            this.label1.TabIndex = 73;
            this.label1.Text = "HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvDanhSachHoaDon);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmDanhSachHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.frmDanhSachHoaDon_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevComponents.DotNetBar.Controls.ListViewEx lvDanhSachHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tstbtnThoat;
        private System.Windows.Forms.ToolStripButton tstbtnCapNhat;
        private System.Windows.Forms.Label label1;
    }
}