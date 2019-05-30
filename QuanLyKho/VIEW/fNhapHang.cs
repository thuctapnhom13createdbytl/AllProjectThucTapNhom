using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.DTO;
using QuanLyKho.DAO;

namespace QuanLyKho.VIEW
{
    public partial class fNhapHang : MetroFramework.Forms.MetroForm
    {
        private List<NhapHang_DTO> lstPhieuNhap;
        private List<NhapHang_DTO> lstPhieuNhapGoc;
        private List<NhanVien_DTO> lstNhanVien;
        private List<LoaiSanPham_DTO> lstLoaiSP;
        private List<NhaSanXuat_DTO> lstNSX;
        private List<SanPham_DTO> lstSanPham;

        public fNhapHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lstNhanVien = NhanVien_DAO.Instance.LoadDanhSachNhanVien();
            lstLoaiSP = LoaiSanPham_DAO.Instance.LoadToanBoLoaiSanPham();
            lstNSX = NhaSanXuat_DAO.Instance.LoadToanBoNSX();
            lstPhieuNhap = NhapHang_DAO.Instance.LoadDanhSachPhieuNhap();
            lstSanPham = SanPham_DAO.Instance.LayTatCaSanPham();
            lstPhieuNhapGoc = NhapHang_DAO.Instance.LoadDanhSachPhieuNhap();

            cboNhanVien.DataSource = lstNhanVien;
            cboNhanVien.DisplayMember = "ThongTin";
            cboNhanVien.ValueMember = "Ma_NV";

            cboNSX.DataSource = lstNSX;
            cboNSX.DisplayMember = "TenNSX";
            cboNSX.ValueMember = "MaNSX";

            cboLoaiSP.DataSource = lstLoaiSP;
            cboLoaiSP.DisplayMember = "TenLSP";
            cboLoaiSP.ValueMember = "MaLSP";

            dgvPhieuNhap.DataSource = typeof(List<NhapHang_DTO>);
            dgvPhieuNhap.DataSource = lstPhieuNhap;
            EditDataGridView();
        }

        private void EditDataGridView()
        {
            dgvPhieuNhap.Columns["Ma_CTPN"].Visible = false;
            dgvPhieuNhap.Columns["TenSanPham"].Width = dgvPhieuNhap.Width / 6;
            dgvPhieuNhap.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvPhieuNhap.Columns["TenLoai"].Width = dgvPhieuNhap.Width / 6;
            dgvPhieuNhap.Columns["TenLoai"].HeaderText = "Loại Sản Phẩm";
            dgvPhieuNhap.Columns["SoLuong"].Width = dgvPhieuNhap.Width / 6;
            dgvPhieuNhap.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvPhieuNhap.Columns["DonGia"].Width = dgvPhieuNhap.Width / 6;
            dgvPhieuNhap.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvPhieuNhap.Columns["Ten_NSX"].Width = dgvPhieuNhap.Width / 6;
            dgvPhieuNhap.Columns["Ten_NSX"].HeaderText = "Tên NSX";
            dgvPhieuNhap.Columns["Ten_NV"].Width = dgvPhieuNhap.Width / 6;
            dgvPhieuNhap.Columns["Ten_NV"].HeaderText = "Tên Nhân Viên";
            dgvPhieuNhap.Columns["Ma_PN"].Visible = false;
            dgvPhieuNhap.Columns["Ma_Sanpham"].Visible = false;
            dgvPhieuNhap.Columns["Ma_LoaiSP"].Visible = false;
            dgvPhieuNhap.Columns["Ma_NSX"].Visible = false;
            dgvPhieuNhap.Columns["Ma_NV"].Visible = false;
            //dgvPhieuNhap.Rows[0].Selected = false;
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow dr = dgvPhieuNhap.Rows[idx];
            txtTenSP.Text = dr.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = dr.Cells["DonGia"].Value.ToString();
            cboLoaiSP.Text = dr.Cells["TenLoai"].Value.ToString();
            cboNhanVien.Text = dr.Cells["Ten_NV"].Value.ToString();
            cboNSX.Text = dr.Cells["Ten_NSX"].Value.ToString();
            numSoLuong.Value = (int)dr.Cells["SoLuong"].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetColor();
            if (!ValidateData()) return;

            SanPham_DTO sanPhamDaCo = lstSanPham.SingleOrDefault(item => item.TenSP == txtTenSP.Text.Trim());
            NhapHang_DTO phieuNhap = new NhapHang_DTO();
            phieuNhap.TenSanPham = txtTenSP.Text.Trim();
            phieuNhap.Ma_SanPham = sanPhamDaCo == null ? 0 : sanPhamDaCo.MaSP;
            phieuNhap.Ma_NSX = (int)cboNSX.SelectedValue;
            phieuNhap.Ma_NV = (int)cboNhanVien.SelectedValue;
            phieuNhap.Ma_LoaiSP = (int)cboLoaiSP.SelectedValue;
            phieuNhap.DonGia = decimal.Parse(txtDonGia.Text);
            phieuNhap.SoLuong = (int)numSoLuong.Value;
            phieuNhap.TenLoai = cboLoaiSP.Text;
            phieuNhap.Ten_NV = cboNhanVien.Text.Split('-')[0];
            phieuNhap.Ten_NSX = cboNSX.Text;

            lstPhieuNhap.Add(phieuNhap);
            dgvPhieuNhap.DataSource = typeof(List<NhapHang_DTO>);
            dgvPhieuNhap.DataSource = lstPhieuNhap;
            EditDataGridView();
        }

        private bool ValidateData()
        {
            decimal donGia;
            int err = 0;
            if (!decimal.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá");
                txtDonGia.BackColor = Color.Coral;
                ++err;
            }
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm");
                txtTenSP.BackColor = Color.Coral;
                ++err;
            }
            return err == 0;
        }

        private void ResetColor()
        {
            txtDonGia.BackColor = txtTenSP.BackColor = Color.White;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            List<NhapHang_DTO> lstPhieuNhapThemMoi = lstPhieuNhap.Where(item => item.Ma_CTPN == 0).ToList();
            int ketQua = NhapHang_DAO.Instance.ThemPhieuNhap(lstPhieuNhapThemMoi);
            if (ketQua > 0)
            {
                MessageBox.Show("Đã thêm phiếu nhập thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đã thêm phiếu nhập thất bại", "Thông báo");
                lstPhieuNhap = lstPhieuNhapGoc;
                dgvPhieuNhap.DataSource = typeof(List<NhapHang_DTO>);
                dgvPhieuNhap.DataSource = lstPhieuNhap;
                EditDataGridView();
            }
        }
    }
}
