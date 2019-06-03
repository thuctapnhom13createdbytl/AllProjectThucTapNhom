namespace QLHS.VIEW
{
    partial class fGVCN
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
            this.dtgvGVCN = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.MGV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGVCN)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvGVCN
            // 
            this.dtgvGVCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGVCN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvGVCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGVCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.TenGiaoVien,
            this.SDT,
            this.email,
            this.MaMonHoc,
            this.TenMonHoc});
            this.dtgvGVCN.Location = new System.Drawing.Point(12, 61);
            this.dtgvGVCN.Name = "dtgvGVCN";
            this.dtgvGVCN.Size = new System.Drawing.Size(690, 389);
            this.dtgvGVCN.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(234, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(252, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(627, 7);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 48);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(471, 9);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(150, 20);
            this.txtMaGV.TabIndex = 4;
            // 
            // MGV
            // 
            this.MGV.AutoSize = true;
            this.MGV.Location = new System.Drawing.Point(391, 7);
            this.MGV.Name = "MGV";
            this.MGV.Size = new System.Drawing.Size(68, 13);
            this.MGV.TabIndex = 5;
            this.MGV.Text = "Mã giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Giáo viên";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Location = new System.Drawing.Point(471, 35);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(150, 20);
            this.txtTenGV.TabIndex = 6;
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.HeaderText = "Mã giáo viên";
            this.MaGiaoVien.Name = "MaGiaoVien";
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.DataPropertyName = "TenGiaoVien";
            this.TenGiaoVien.HeaderText = "Tên giáo viên";
            this.TenGiaoVien.Name = "TenGiaoVien";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số ĐT";
            this.SDT.Name = "SDT";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "MaMH";
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Visible = false;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "TenMonHoc";
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.Visible = false;
            // 
            // fGVCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.MGV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dtgvGVCN);
            this.Name = "fGVCN";
            this.Text = "Giáo viên chủ nhiệm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGVCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGVCN;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label MGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
    }
}