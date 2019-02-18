using QuanLyKho.DAO;
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
    public partial class fSanPham : Form
    {
        BindingSource DanhSachSP = new BindingSource();
        public fSanPham()
        {
            InitializeComponent();
            Load();
            
        }
        void Load()
        {
            dtgvSanPham.DataSource = DanhSachSP;
            LayTatCaSP();
            bindingSanPham();
        }
        void LayTatCaSP()
        {
            DanhSachSP.DataSource = SanPham_DAO.Instance.LayTatCaSanPham();
        }
        void bindingSanPham()
        {
            txtDonGia.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            txtMaSanPham.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            txtTenSanPham.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtThongSoKyThuat.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "ThongSoKyThuat", true, DataSourceUpdateMode.Never));
            nrudSoLuong.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            cbLoaiSanPham.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "tenLoaiSP", true, DataSourceUpdateMode.Never));
            cbTenNhaSanXuat.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "TenNSX", true, DataSourceUpdateMode.Never));
        }
    }
}
