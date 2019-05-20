using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.VIEW
{
    public partial class fThongTinSach : Form
    {
        public fThongTinSach()
        {
            InitializeComponent();
        }

        private static string _soPhieuMuon;
        public static string SoPhieuMuon
        {
            get
            {
                return _soPhieuMuon;
            }
            private set
            {
                _soPhieuMuon = value;
            }
        }


        private List<ViPham_DTO> lstViPham;
        private List<CuonSach_DTO> lstCuonSach;
        private List<ThongTinMuonTra_DTO> lstThongTinMuonTra;
        private List<NhanVien_DTO> lstNhanVien;
        private List<DocGia_DTO> lstDocGia;
        private List<PhieuMuon_DTO> lstPhieuMuon;

        private void fThongTinSach_Load(object sender, EventArgs e)
        {
            LoadViPham();
            LoadCuonSach();
            LoadThongTinMuonTra();
            LoadComboBox();
            LoadPhieuMuon();
            EditColumnName();
        }

        private void LoadPhieuMuon()
        {
            lstPhieuMuon = PhieuMuon_DAO.Instance.LoadTatCaPhieuMuuon();
            dgvPhieuMuon.DataSource = typeof(List<PhieuMuon_DTO>);
            dgvPhieuMuon.DataSource = lstPhieuMuon;
        }

        private void LoadComboBox()
        {
            lstDocGia = DocGia_DAO.Instance.LoadDocGiaComboBox();
            cboDocGia.DataSource = lstDocGia;
            cboDocGia.DisplayMember = "TenDocGia";
            cboDocGia.ValueMember = "MaDocGia";

            lstNhanVien = NhanVien_DAO.Instance.LoadNhanVienComboBox();
            cboNhanVien.DataSource = lstNhanVien;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";
        }

        private void LoadThongTinMuonTra()
        {
            lstThongTinMuonTra = ThongTinMuonTra_DAO.Instance.LoadTatCaThongTinMuonTra();
            dgvThongTinMuonTra.DataSource = typeof(List<ThongTinMuonTra_DTO>);
            dgvThongTinMuonTra.DataSource = lstThongTinMuonTra;
        }

        private void LoadCuonSach()
        {
            lstCuonSach = CuonSach_DAO.Instance.LoadTatCaCuonSach();
            dgvCuonSach.DataSource = typeof(List<CuonSach_DTO>);
            dgvCuonSach.DataSource = lstCuonSach;
        }

        private void LoadViPham()
        {
            lstViPham = ViPham_DAO.Instance.LoadTatCaViPham();
            dgvViPham.DataSource = typeof(List<ViPham_DTO>);
            dgvViPham.DataSource = lstViPham;
        }

        private void EditColumnName()
        {
            // Vi phạm
            dgvViPham.Columns["MaViPham"].HeaderText = "Mã Vi Phạm";
            dgvViPham.Columns["TenViPham"].HeaderText = "Tên Vi Phạm";
            dgvViPham.Columns["HinhThucPhat"].HeaderText = "Hình Thức Phạt";

            // Cuốn sách
            dgvCuonSach.Columns["MaCuonSach"].HeaderText = "Mã Cuốn Sách";
            dgvCuonSach.Columns["MaDauSach"].Visible = false;
            dgvCuonSach.Columns["TinhTrangSach"].HeaderText = "Tình Trạng Sách";
            dgvCuonSach.Columns["TenDauSach"].HeaderText = "Tên Đầu Sách";

            // Thông tin mượn trả
            dgvThongTinMuonTra.Columns["SoPhieuMuon"].HeaderText = "Số Phiếu Mượn";
            dgvThongTinMuonTra.Columns["MaCuonSach"].HeaderText = "Mã Cuốn Sách";
            dgvThongTinMuonTra.Columns["TenDauSach"].HeaderText = "Tên Đầu Sách";
            dgvThongTinMuonTra.Columns["NgayTra"].HeaderText = "Ngày Trả";
            dgvThongTinMuonTra.Columns["TinhTrangSach"].HeaderText = "Tình Trạng Sách";
            dgvThongTinMuonTra.Columns["MaViPham"].HeaderText = "Mã Vi Phạm";

            // Phiếu mượn
            dgvPhieuMuon.Columns["SoPhieuMuon"].HeaderText = "Số Phiếu Mượn";
            dgvPhieuMuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dgvPhieuMuon.Columns["NgayHenTra"].HeaderText = "Ngày Hẹn Trả";
            dgvPhieuMuon.Columns["MaNhanVien"].Visible = false;
            dgvPhieuMuon.Columns["MaDocGia"].Visible = false;
            dgvPhieuMuon.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvPhieuMuon.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";

        }

        private void dgvViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow dr = dgvViPham.Rows[idx];
            txtMaViPham.Text = dr.Cells["MaViPham"].Value.ToString();
            txtTenViPham.Text = dr.Cells["TenViPham"].Value.ToString();
            txtHinhThucPhat.Text = dr.Cells["HinhThucPhat"].Value.ToString();
        }

        private void dgvCuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow dr = dgvCuonSach.Rows[idx];
            txtMaCuonSach.Text = dr.Cells["MaCuonSach"].Value.ToString();
            txtDauSach.Text = dr.Cells["TenDauSach"].Value.ToString();
            radCotheMuon.Checked = (int)dr.Cells["TinhTrangSach"].Value == 1;
            radKhongTheMuon.Checked = !radCotheMuon.Checked;
        }

        private void dgvThongTinMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow dr = dgvThongTinMuonTra.Rows[idx];
            txtSoPhieuMuon_TT.Text = dr.Cells["SoPhieuMuon"].Value.ToString();
            txtNgayTra_TT.Text = dr.Cells["NgayTra"].Value.ToString();
            txtMaCuonSach_TT.Text = dr.Cells["MaCuonSach"].Value.ToString();
            txtMaViPham_TT.Text = dr.Cells["MaViPham"].Value.ToString();
            txtTinhTrangSach.Text = dr.Cells["TinhTrangSach"].Value.ToString();
            txtTenDauSach.Text = dr.Cells["TenDauSach"].Value.ToString();
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow dr = dgvPhieuMuon.Rows[idx];
            txtSoPhieuMuon.Text = dr.Cells["SoPhieuMuon"].Value.ToString();
            dtpNgayMuon.Value = DateTime.Parse(dr.Cells["NgayMuon"].Value.ToString());
            dtpNgayHenTra.Value = DateTime.Parse(dr.Cells["NgayHenTra"].Value.ToString());
            cboDocGia.SelectedValue = dr.Cells["MaDocGia"].Value.ToString();
            cboNhanVien.SelectedValue = dr.Cells["MaNhanVien"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn 1 phiếu mượn để xóa", "Thông báo");
                return;
            }
            DataGridViewRow dr = dgvPhieuMuon.SelectedRows[0];
            string soPhieuMuon = dr.Cells["SoPhieuMuon"].Value.ToString();
            int kq = PhieuMuon_DAO.Instance.XoaPhieuMuon(soPhieuMuon);
            if (kq > 0)
            {
                MessageBox.Show("Xóa phiếu mượn thành công", "Thông báo");
                LoadPhieuMuon();
                LoadThongTinMuonTra();
            }
            else
            {
                MessageBox.Show("Xóa phiếu mượn thất bại", "Thông báo");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn 1 phiếu mượn để cập nhật", "Thông báo");
                return;
            }
            DataGridViewRow dr = dgvPhieuMuon.SelectedRows[0];
            PhieuMuon_DTO pm = new PhieuMuon_DTO();
            pm.SoPhieuMuon = txtSoPhieuMuon.Text;
            pm.NgayMuon = dtpNgayMuon.Value;
            pm.NgayHenTra = dtpNgayHenTra.Value;
            pm.MaNhanVien = cboNhanVien.SelectedValue.ToString();
            pm.MaDocGia = cboDocGia.SelectedValue.ToString();
            int kq = PhieuMuon_DAO.Instance.CapNhatPhieuMuon(pm);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật phiếu mượn thành công", "Thông báo");
                LoadPhieuMuon();
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu mượn thất bại", "Thông báo");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuMuon_DTO phieuMuon = lstPhieuMuon.SingleOrDefault(item => item.SoPhieuMuon.Trim() == txtSoPhieuMuon.Text);
            if (phieuMuon != null)
            {
                MessageBox.Show("Số phiếu mượn bạn nhập đã tồn tại. Xin kiểm tra lại");
                return;
            }
            else
            {
                PhieuMuon_DTO pm = new PhieuMuon_DTO();
                pm.SoPhieuMuon = txtSoPhieuMuon.Text;
                pm.NgayMuon = dtpNgayMuon.Value;
                pm.NgayHenTra = dtpNgayHenTra.Value;
                pm.MaNhanVien = cboNhanVien.SelectedValue.ToString();
                pm.MaDocGia = cboDocGia.SelectedValue.ToString();
                int kq = PhieuMuon_DAO.Instance.ThemPhieuMuon(pm);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo");
                    LoadPhieuMuon();
                    SoPhieuMuon = txtSoPhieuMuon.Text;
                    frmThemChiTietPhieuMuon frm = new frmThemChiTietPhieuMuon();
                    frm.ShowDialog();
                    LoadThongTinMuonTra();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu mượn thất bại", "Thông báo");
                }
            }
        }

        private void dgvPhieuMuon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            SoPhieuMuon = dgvPhieuMuon.Rows[idx].Cells["SoPhieuMuon"].Value.ToString();
            frmThemChiTietPhieuMuon frm = new frmThemChiTietPhieuMuon();
            frm.ShowDialog();
            LoadThongTinMuonTra();
        }
    }
}
