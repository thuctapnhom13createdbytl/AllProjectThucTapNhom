namespace QuanLiNhanVien.GUI
{
    partial class ucMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnPhongBan = new MetroFramework.Controls.MetroTile();
            this.btnPhanCong = new MetroFramework.Controls.MetroTile();
            this.btnThanNhan = new MetroFramework.Controls.MetroTile();
            this.btnDuAn = new MetroFramework.Controls.MetroTile();
            this.btnNhanVien = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 630);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnPhongBan);
            this.metroPanel1.Controls.Add(this.btnPhanCong);
            this.metroPanel1.Controls.Add(this.btnThanNhan);
            this.metroPanel1.Controls.Add(this.btnDuAn);
            this.metroPanel1.Controls.Add(this.btnNhanVien);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(59, 36);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(654, 557);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.ActiveControl = null;
            this.btnPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(53)))), ((int)(((byte)(174)))));
            this.btnPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnPhongBan.Location = new System.Drawing.Point(348, 73);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(192, 133);
            this.btnPhongBan.TabIndex = 2;
            this.btnPhongBan.Tag = "ucPhongBan";
            this.btnPhongBan.Text = "Phòng Ban";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPhongBan.TileImage = global::QuanLiNhanVien.Properties.Resources.PhongBan;
            this.btnPhongBan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhongBan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPhongBan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPhongBan.UseCustomBackColor = true;
            this.btnPhongBan.UseCustomForeColor = true;
            this.btnPhongBan.UseSelectable = true;
            this.btnPhongBan.UseTileImage = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.ActiveControl = null;
            this.btnPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(85)))), ((int)(((byte)(45)))));
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Location = new System.Drawing.Point(120, 383);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(420, 133);
            this.btnPhanCong.TabIndex = 2;
            this.btnPhanCong.Tag = "ucPhanCong";
            this.btnPhanCong.Text = "Phân Công Dự Án";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPhanCong.TileImage = global::QuanLiNhanVien.Properties.Resources.PhanCong;
            this.btnPhanCong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhanCong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPhanCong.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPhanCong.UseCustomBackColor = true;
            this.btnPhanCong.UseCustomForeColor = true;
            this.btnPhanCong.UseSelectable = true;
            this.btnPhanCong.UseTileImage = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnThanNhan
            // 
            this.btnThanNhan.ActiveControl = null;
            this.btnThanNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnThanNhan.ForeColor = System.Drawing.Color.White;
            this.btnThanNhan.Location = new System.Drawing.Point(348, 227);
            this.btnThanNhan.Name = "btnThanNhan";
            this.btnThanNhan.Size = new System.Drawing.Size(192, 133);
            this.btnThanNhan.TabIndex = 2;
            this.btnThanNhan.Tag = "ucThanNhan";
            this.btnThanNhan.Text = "Thân Nhân";
            this.btnThanNhan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThanNhan.TileImage = global::QuanLiNhanVien.Properties.Resources.ThanNhan;
            this.btnThanNhan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanNhan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnThanNhan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnThanNhan.UseCustomBackColor = true;
            this.btnThanNhan.UseCustomForeColor = true;
            this.btnThanNhan.UseSelectable = true;
            this.btnThanNhan.UseTileImage = true;
            this.btnThanNhan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDuAn
            // 
            this.btnDuAn.ActiveControl = null;
            this.btnDuAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnDuAn.ForeColor = System.Drawing.Color.White;
            this.btnDuAn.Location = new System.Drawing.Point(120, 227);
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.Size = new System.Drawing.Size(197, 133);
            this.btnDuAn.TabIndex = 2;
            this.btnDuAn.Tag = "ucDuAn";
            this.btnDuAn.Text = "Dự Án";
            this.btnDuAn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDuAn.TileImage = global::QuanLiNhanVien.Properties.Resources.DuAn;
            this.btnDuAn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuAn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDuAn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnDuAn.UseCustomBackColor = true;
            this.btnDuAn.UseCustomForeColor = true;
            this.btnDuAn.UseSelectable = true;
            this.btnDuAn.UseTileImage = true;
            this.btnDuAn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.ActiveControl = null;
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(23)))));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(120, 73);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(197, 133);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Tag = "ucNhanVien";
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNhanVien.TileImage = global::QuanLiNhanVien.Properties.Resources.NhanVien;
            this.btnNhanVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanVien.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNhanVien.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnNhanVien.UseCustomBackColor = true;
            this.btnNhanVien.UseCustomForeColor = true;
            this.btnNhanVien.UseSelectable = true;
            this.btnNhanVien.UseTileImage = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btn_Click);
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(773, 630);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnPhongBan;
        private MetroFramework.Controls.MetroTile btnPhanCong;
        private MetroFramework.Controls.MetroTile btnThanNhan;
        private MetroFramework.Controls.MetroTile btnDuAn;
        private MetroFramework.Controls.MetroTile btnNhanVien;
    }
}
