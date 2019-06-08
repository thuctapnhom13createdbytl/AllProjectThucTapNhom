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
    public partial class fHoaDonXuat : Form
    {
        public int MaPX;
        public fHoaDonXuat(int id)
        {
            InitializeComponent();
            MaPX = id;
        }

        private void fHoaDonXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetHoaDonXuat.LayHoaDonXuat' table. You can move, or remove it, as needed.
            ReportParameterCollection reportParam = new ReportParameterCollection();
            reportParam.Add(new ReportParameter("NgayLap", DateTime.Now.ToShortDateString()));
            reportParam.Add(new ReportParameter("MaPX", MaPX.ToString()));
            this.LayHoaDonXuatTableAdapter.Fill(this.DataSetHoaDonXuat.LayHoaDonXuat, MaPX);
            this.rpXuatHang.LocalReport.SetParameters(reportParam);
            this.rpXuatHang.RefreshReport();
        }
    }
}
