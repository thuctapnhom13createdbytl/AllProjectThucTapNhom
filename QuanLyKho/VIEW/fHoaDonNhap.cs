using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.VIEW
{
    public partial class fHoaDonNhap : Form
    {
        public int MaHD;
        public fHoaDonNhap(int id)
        {
            InitializeComponent();
            MaHD = id;
        }

        private void fXuatHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetHoaDonNhap.XuatHoaDonNhap' table. You can move, or remove it, as needed.
            ReportParameterCollection reportParam = new ReportParameterCollection();
            reportParam.Add(new ReportParameter("NgayLap", DateTime.Now.ToShortDateString()));
            reportParam.Add(new ReportParameter("MaPN", MaHD.ToString()));
            this.XuatHoaDonNhapTableAdapter.Fill(this.DataSetHoaDonNhap.XuatHoaDonNhap, MaHD);
            this.rpNhapHang.LocalReport.SetParameters(reportParam);
            this.rpNhapHang.RefreshReport();
        }

        private void rpNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
