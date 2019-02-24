using QuanLyKho.DAO;
using QuanLyKho.DTO;
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
        BindingSource DanhSachLSP = new BindingSource();
        BindingSource DanhSachNSX = new BindingSource();
        public fSanPham()
        {
            InitializeComponent();
            Load();
            
        }
        //lấy tất cả dữ liệu đưa vào dataGridView
        void Load()
        {
            dtgvSanPham.DataSource = DanhSachSP;
            dtgvLSP.DataSource = DanhSachLSP;
            dtgvNSX.DataSource = DanhSachNSX;
            LayTatCaSP();
            LayTatCaLSP();
            LayTatCaNSX();
            bindingSanPham();
            bindingLoaiSP();
            bindingNSX();
        }
        void LayTatCaSP()
        {
            DanhSachSP.DataSource = SanPham_DAO.Instance.LayTatCaSanPham();
        }
        void LayTatCaLSP()
        {
            DanhSachLSP.DataSource = LoaiSanPham_DAO.Instance.LayTatCaLoaiSanPham();
        }
        void LayTatCaNSX()
        {
            DanhSachNSX.DataSource = NhaSanXuat_DAO.Instance.LayTatCaNSX();
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
        void bindingLoaiSP()
        {
            txtMaLSP.DataBindings.Add(new Binding("Text", dtgvLSP.DataSource, "MaLSP", true, DataSourceUpdateMode.Never));
            txtTenLSP.DataBindings.Add(new Binding("Text", dtgvLSP.DataSource, "TenLSP", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", dtgvLSP.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
        }
        void bindingNSX()
        {
            txtMa_NSX.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "MaNSX", true, DataSourceUpdateMode.Never));
            txtTen_NSX.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "TenNSX", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "DiaChiNSX", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "sdtNSX", true, DataSourceUpdateMode.Never));
            txtWebsite.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "WebsiteNSX", true, DataSourceUpdateMode.Never));
        }
    }
}
