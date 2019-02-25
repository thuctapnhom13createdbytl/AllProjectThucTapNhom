using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.DAO;
using QuanLyKho.DTO;

namespace QuanLyKho.VIEW
{
    public partial class fXuatHang : Form
    {
        public fXuatHang()
        {
            InitializeComponent();
            LoadData();
        }

        private List<XuatHang_DTO> lstPhieuXuat;
        private List<XuatHang_DTO> lstPhieuXuatGoc;
        private List<NhanVien_DTO> lstNhanVien;
        private List<LoaiSanPham_DTO> lstLoaiSP;
        private List<NhaSanXuat_DTO> lstNSX;
        private List<SanPham_DTO> lstSanPham;
        private List<KhachHang_DTO> lstKhachHang;

        private void LoadData()
        {
            lstLoaiSP = LoaiSanPham_DAO.Instance.LoadToanBoLoaiSanPham();
            lstNSX = NhaSanXuat_DAO.Instance.LoadToanBoNSX();
            lstSanPham = SanPham_DAO.Instance.LayTatCaSanPham();
            lstNhanVien = NhanVien_DAO.Instance.LoadDanhSachNhanVien();
            lstPhieuXuat = XuatHang_DAO.Instance.LoadDanhSachPhieuXuat();
            lstPhieuXuatGoc = XuatHang_DAO.Instance.LoadDanhSachPhieuXuat();
            lstKhachHang = KhachHang_DAO.Instance.LoadToanBoKhachHang();

            cboNhanVien.DataSource = lstNhanVien;
            cboNhanVien.DisplayMember = "ThongTin";
            cboNhanVien.ValueMember = "Ma_NV";

            cboTenSP.DataSource = lstSanPham;
            cboTenSP.DisplayMember = "TenSP";
            cboTenSP.ValueMember = "MaSP";

            dgvPhieuXuat.DataSource = typeof(List<XuatHang_DTO>);
            dgvPhieuXuat.DataSource = lstPhieuXuat;
            EditDataGridView();
        }

        private void EditDataGridView()
        {
            dgvPhieuXuat.Columns["TenKH"].HeaderText = "Khách Hàng";
            dgvPhieuXuat.Columns["TenKH"].Width = dgvPhieuXuat.Width / 5;
            dgvPhieuXuat.Columns["TenSanPham"].HeaderText = "Sản Phẩm";
            dgvPhieuXuat.Columns["TenSanPham"].Width = dgvPhieuXuat.Width / 5;
            dgvPhieuXuat.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvPhieuXuat.Columns["SoLuong"].Width = dgvPhieuXuat.Width / 5;
            dgvPhieuXuat.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvPhieuXuat.Columns["DonGia"].Width = dgvPhieuXuat.Width / 5;
            dgvPhieuXuat.Columns["TenNV"].HeaderText = "Nhân Viên";
            dgvPhieuXuat.Columns["TenNV"].Width = dgvPhieuXuat.Width / 5;
            dgvPhieuXuat.Columns["Ma_CTPX"].Visible = false;
            dgvPhieuXuat.Columns["Ma_PX"].Visible = false;
            dgvPhieuXuat.Columns["Ma_Sanpham"].Visible = false;
            dgvPhieuXuat.Columns["KhachHang"].Visible = false;
            dgvPhieuXuat.Columns["LoaiSanPham"].Visible = false;
            dgvPhieuXuat.Columns["NhanVien"].Visible = false;
            dgvPhieuXuat.Columns["NhaSanXuat"].Visible = false;
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            XuatHang_DTO phieuXuat = lstPhieuXuat[idx];
            txtTenKH.Text = phieuXuat.KhachHang.Ten_KH;
            txtDiaChi.Text = phieuXuat.KhachHang.DiaChi_KH;
            txtEmail.Text = phieuXuat.KhachHang.Email_KH;
            txtSDT.Text = phieuXuat.KhachHang.SDT_KH;
            cboNhanVien.Text = phieuXuat.NhanVien.ThongTin;
            txtLoaiSP.Text = phieuXuat.LoaiSanPham.TenLoai;
            txtNSX.Text = phieuXuat.NhaSanXuat.Ten_NSX;
            cboTenSP.Text = phieuXuat.TenSanPham;
            numSoLuong.Value = (int)phieuXuat.SoLuong;
            txtDonGia.Text = phieuXuat.DonGia.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetColor();
            if (!ValidateData()) return;

            XuatHang_DTO phieuXuat = new XuatHang_DTO();
            phieuXuat.KhachHang.Ten_KH = txtTenKH.Text.Trim();
            phieuXuat.KhachHang.SDT_KH = txtSDT.Text;
            phieuXuat.KhachHang.DiaChi_KH = txtDiaChi.Text;
            phieuXuat.KhachHang.Email_KH = txtEmail.Text;

            phieuXuat.NhanVien.Ma_NV = (int)cboNhanVien.SelectedValue;
            phieuXuat.TenNV = cboNhanVien.Text.Split('-')[0];
            phieuXuat.TenKH = txtTenKH.Text.Trim();
            phieuXuat.Ma_Sanpham = (int)cboTenSP.SelectedValue;
            phieuXuat.TenSanPham = cboTenSP.Text;
            phieuXuat.SoLuong = (int)numSoLuong.Value;
            phieuXuat.DonGia = int.Parse(txtDonGia.Text);

            lstPhieuXuat.Add(phieuXuat);
            dgvPhieuXuat.DataSource = typeof(List<XuatHang_DTO>);
            dgvPhieuXuat.DataSource = lstPhieuXuat;
            EditDataGridView();
        }

        private bool ValidateData()
        {
            int err = 0;
            int donGia;
            if (txtTenKH.Text.Trim() == "")
            {
                txtTenKH.BackColor = Color.Coral;
                err++;
            }
            if (!int.TryParse(txtDonGia.Text, out donGia))
            {
                txtDonGia.BackColor = Color.Coral;
                err++;
            }
            SanPham_DTO sanPham = lstSanPham.Single(item => item.MaSP == (int)cboTenSP.SelectedValue);
            if (numSoLuong.Value > sanPham.SoLuong)
            {
                numSoLuong.BackColor = Color.Coral;
                err++;
            }
            if (err > 0)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng. Xin kiểm tra lại!");
            }
            return err == 0;
        }

        private void ResetColor()
        {
            txtTenKH.BackColor = txtDonGia.BackColor = numSoLuong.BackColor = Color.White;
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham_DTO sanPham = cboTenSP.SelectedItem as SanPham_DTO; 
            txtNSX.Text = sanPham.TenNSX;
            txtLoaiSP.Text = sanPham.TenLoaiSP;
        }

        private void CheckTonTaiKhachHang(List<KhachHang_DTO> lstKH, KhachHang_DTO kh)
        {
            foreach(KhachHang_DTO item in lstKH)
            {
                if (kh.Ten_KH == item.Ten_KH && kh.SDT_KH == item.SDT_KH && kh.DiaChi_KH == item.DiaChi_KH && kh.Email_KH == item.Email_KH)
                {
                    kh.Ma_KH = item.Ma_KH;
                    return;
                }
            }
            kh.Ma_KH = 0;
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            List<XuatHang_DTO> lstPhieuXuatThemMoi = lstPhieuXuat.Where(item => item.Ma_CTPX == 0).ToList();
            for(int i = 0; i < lstPhieuXuatThemMoi.Count; i++)
            {
                CheckTonTaiKhachHang(lstKhachHang, lstPhieuXuatThemMoi[i].KhachHang);
            }

            int ketQua = XuatHang_DAO.Instance.ThemPhieuXuat(lstPhieuXuatThemMoi);
            if (ketQua > 0)
            {
                MessageBox.Show("Đã thêm phiếu xuất thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đã thêm phiếu xuất thất bại", "Thông báo");
                lstPhieuXuat = lstPhieuXuatGoc;
                dgvPhieuXuat.DataSource = typeof(List<XuatHang_DTO>);
                dgvPhieuXuat.DataSource = lstPhieuXuat;
                EditDataGridView();
            }
        }
    }
}
