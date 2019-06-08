namespace QuanLyKho.VIEW
{
    partial class fHoaDonNhap
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpNhapHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.XuatHoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetHoaDonNhap = new QuanLyKho.VIEW.DataSetHoaDonNhap();
            this.XuatHoaDonNhapTableAdapter = new QuanLyKho.VIEW.DataSetHoaDonNhapTableAdapters.XuatHoaDonNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XuatHoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // rpNhapHang
            // 
            this.rpNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetNhapHang";
            reportDataSource1.Value = this.XuatHoaDonNhapBindingSource;
            this.rpNhapHang.LocalReport.DataSources.Add(reportDataSource1);
            this.rpNhapHang.LocalReport.ReportEmbeddedResource = "QuanLyKho.VIEW.rpNhapHang.rdlc";
            this.rpNhapHang.Location = new System.Drawing.Point(12, 55);
            this.rpNhapHang.Name = "rpNhapHang";
            this.rpNhapHang.ServerReport.BearerToken = null;
            this.rpNhapHang.Size = new System.Drawing.Size(666, 500);
            this.rpNhapHang.TabIndex = 0;
            this.rpNhapHang.Load += new System.EventHandler(this.rpNhapHang_Load);
            // 
            // XuatHoaDonNhapBindingSource
            // 
            this.XuatHoaDonNhapBindingSource.DataMember = "XuatHoaDonNhap";
            this.XuatHoaDonNhapBindingSource.DataSource = this.DataSetHoaDonNhap;
            // 
            // DataSetHoaDonNhap
            // 
            this.DataSetHoaDonNhap.DataSetName = "DataSetHoaDonNhap";
            this.DataSetHoaDonNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XuatHoaDonNhapTableAdapter
            // 
            this.XuatHoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // fXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 567);
            this.Controls.Add(this.rpNhapHang);
            this.Name = "fXuatHoaDon";
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.fXuatHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XuatHoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHoaDonNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpNhapHang;
        private System.Windows.Forms.BindingSource XuatHoaDonNhapBindingSource;
        private DataSetHoaDonNhap DataSetHoaDonNhap;
        private DataSetHoaDonNhapTableAdapters.XuatHoaDonNhapTableAdapter XuatHoaDonNhapTableAdapter;
    }
}