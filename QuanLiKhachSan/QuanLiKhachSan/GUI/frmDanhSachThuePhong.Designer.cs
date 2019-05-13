namespace QuanLiKhachSan.GUI
{
    partial class frmDanhSachThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachThuePhong));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tstbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.tstbtnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.lvPhieuThue = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1230, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHIẾU THUÊ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbtnThoat,
            this.tstbtnCapNhat});
            this.toolStrip.Location = new System.Drawing.Point(0, 105);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1230, 25);
            this.toolStrip.TabIndex = 71;
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
            // lvPhieuThue
            // 
            // 
            // 
            // 
            this.lvPhieuThue.Border.Class = "ListViewBorder";
            this.lvPhieuThue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvPhieuThue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPhieuThue.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhieuThue.FullRowSelect = true;
            this.lvPhieuThue.GridLines = true;
            this.lvPhieuThue.Location = new System.Drawing.Point(0, 130);
            this.lvPhieuThue.Name = "lvPhieuThue";
            this.lvPhieuThue.Size = new System.Drawing.Size(1230, 467);
            this.lvPhieuThue.TabIndex = 72;
            this.lvPhieuThue.UseCompatibleStateImageBehavior = false;
            this.lvPhieuThue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Thuê Phòng";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khách Hàng";
            this.columnHeader2.Width = 237;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nhân Viên";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Phòng";
            this.columnHeader4.Width = 174;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Thuê Phòng";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Trả Phòng";
            this.columnHeader6.Width = 242;
            // 
            // frmDanhSachThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 597);
            this.Controls.Add(this.lvPhieuThue);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmDanhSachThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Thuê Phòng";
            this.Load += new System.EventHandler(this.frmDanhSachThuePhong_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tstbtnThoat;
        private System.Windows.Forms.ToolStripButton tstbtnCapNhat;
        public DevComponents.DotNetBar.Controls.ListViewEx lvPhieuThue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}