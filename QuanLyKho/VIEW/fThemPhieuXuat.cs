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
    public partial class fThemPhieuXuat : MetroFramework.Forms.MetroForm
    {
        List<SanPham_DTO> DSSP = new List<SanPham_DTO>();
        BindingSource SPbinding = new BindingSource();
        public fThemPhieuXuat()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtgvThemPhieuXuat.DataSource = DSSP;
            cbKhachHang.DataSource = KhachHang_DAO.Instance.LoadToanBoKhachHang();
            cbKhachHang.DisplayMember = "Ten_KH";
            cbKhachHang.ValueMember = "Ma_KH";

            cbNhanVien.DataSource = NhanVien_DAO.Instance.LoadDanhSachNhanVien();
            cbNhanVien.DisplayMember = "Ten_NV";
            cbNhanVien.ValueMember = "Ma_NV";

            cbSanPham.DataSource = SanPham_DAO.Instance.LayTatCaSanPham();
            cbSanPham.ValueMember = "MaSP";
            cbSanPham.DisplayMember = "TenSP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nmSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SanPham_DTO sanPham = cbSanPham.SelectedItem as SanPham_DTO;
            SanPham_DTO sp = new SanPham_DTO((int)nmSoLuong.Value, sanPham.TenNSX, sanPham.DonGia, sanPham.MaSP, sanPham.TenSP, sanPham.ThongSoKyThuat, sanPham.TenLoaiSP, sanPham.MaLoaiSP, sanPham.MaNSX);
            sp.TongTien = sp.SoLuong * sp.DonGia;
            SPbinding.Add(sp);
            DSSP.Add(sp);
            dtgvThemPhieuXuat.DataSource = SPbinding;
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham_DTO sanPham = cbSanPham.SelectedItem as SanPham_DTO;
            if (cbSanPham.SelectedItem != null)
            {
                nmDonGia.Value = sanPham.DonGia;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvThemPhieuXuat.CurrentRow.Index;
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa sản phẩm thứ: " + (index + 1), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.Yes)
                {
                    SPbinding.RemoveAt(index);
                    DSSP.RemoveAt(index);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        void resetForm()
        {
            DSSP = new List<SanPham_DTO>();
            if (dtgvThemPhieuXuat.RowCount > 0)
            {
                dtgvThemPhieuXuat.Rows.Clear();
            }
            if(nmSoLuong.Value > 0)
            {
                nmSoLuong.Value = 0;
            }
            cbKhachHang.DataSource = KhachHang_DAO.Instance.LoadToanBoKhachHang();
            cbKhachHang.DisplayMember = "Ten_KH";
            cbKhachHang.ValueMember = "Ma_KH";

            cbNhanVien.DataSource = NhanVien_DAO.Instance.LoadDanhSachNhanVien();
            cbNhanVien.DisplayMember = "Ten_NV";
            cbNhanVien.ValueMember = "Ma_NV";

            cbSanPham.DataSource = SanPham_DAO.Instance.LayTatCaSanPham();
            cbSanPham.ValueMember = "MaSP";
            cbSanPham.DisplayMember = "TenSP";
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvThemPhieuXuat.RowCount > 0)
                {
                    bool ThemPX = PhieuXuat_DAO.Instance.ThemPhieuXuat(Convert.ToInt32(cbNhanVien.SelectedValue), Convert.ToInt32(cbKhachHang.SelectedValue),dtpkNgayXuat.Value);
                    if (ThemPX)
                    {
                        int MaPX = PhieuXuat_DAO.Instance.LayMaPXMoi();
                        foreach (SanPham_DTO sp in DSSP)
                        {
                            CTPhieuXuat_DAO.Instance.ThemCTPhieuXuat(MaPX, sp.MaSP, sp.SoLuong, sp.DonGia);
                            SanPham_DAO.Instance.CapNhatSoLuong(sp.MaSP, -sp.SoLuong);
                        }
                        MessageBox.Show("Xuất thành công");
                        var XH = MessageBox.Show("bạn có muốn in hóa đơn ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(XH == DialogResult.Yes)
                        {
                            fHoaDonXuat f = new fHoaDonXuat(MaPX);
                            f.Show();
                        }
                        resetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
