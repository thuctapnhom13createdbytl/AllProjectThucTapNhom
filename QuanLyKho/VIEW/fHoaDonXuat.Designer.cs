namespace QuanLyKho.VIEW
{
    partial class fHoaDonXuat
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
            this.LayHoaDonXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetHoaDonXuat = new QuanLyKho.VIEW.DataSetHoaDonXuat();
            this.rpXuatHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LayHoaDonXuatTableAdapter = new QuanLyKho.VIEW.DataSetHoaDonXuatTableAdapters.LayHoaDonXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LayHoaDonXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHoaDonXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // LayHoaDonXuatBindingSource
            // 
            this.LayHoaDonXuatBindingSource.DataMember = "LayHoaDonXuat";
            this.LayHoaDonXuatBindingSource.DataSource = this.DataSetHoaDonXuat;
            // 
            // DataSetHoaDonXuat
            // 
            this.DataSetHoaDonXuat.DataSetName = "DataSetHoaDonXuat";
            this.DataSetHoaDonXuat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpXuatHang
            // 
            reportDataSource1.Name = "DataSetXuatHang";
            reportDataSource1.Value = this.LayHoaDonXuatBindingSource;
            this.rpXuatHang.LocalReport.DataSources.Add(reportDataSource1);
            this.rpXuatHang.LocalReport.ReportEmbeddedResource = "QuanLyKho.VIEW.rpXuatHang.rdlc";
            this.rpXuatHang.Location = new System.Drawing.Point(3, 12);
            this.rpXuatHang.Name = "rpXuatHang";
            this.rpXuatHang.ServerReport.BearerToken = null;
            this.rpXuatHang.Size = new System.Drawing.Size(632, 513);
            this.rpXuatHang.TabIndex = 0;
            // 
            // LayHoaDonXuatTableAdapter
            // 
            this.LayHoaDonXuatTableAdapter.ClearBeforeFill = true;
            // 
            // fHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 528);
            this.Controls.Add(this.rpXuatHang);
            this.Name = "fHoaDonXuat";
            this.Text = "Hóa đơn xuất hàng";
            this.Load += new System.EventHandler(this.fHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayHoaDonXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHoaDonXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpXuatHang;
        private System.Windows.Forms.BindingSource LayHoaDonXuatBindingSource;
        private DataSetHoaDonXuat DataSetHoaDonXuat;
        private DataSetHoaDonXuatTableAdapters.LayHoaDonXuatTableAdapter LayHoaDonXuatTableAdapter;
    }
}