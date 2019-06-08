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
    public partial class fThemPhieuNhap : MetroFramework.Forms.MetroForm
    {
        List<SanPham_DTO> DSSP = new List<SanPham_DTO>();
        BindingSource SP_NSX = new BindingSource();
        public fThemPhieuNhap()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
        }
        void KhoiTaoDuLieu()
        {
            dtgvThemPhieuNhap.DataSource = DSSP;
            LoadCBNhanVien(cbNhanVien);
            LoadCBNSX(cbNSX);

        }

        void LoadCBNhanVien(ComboBox cb)
        {
            cb.DataSource = NhanVien_DAO.Instance.LoadDanhSachNhanVien();
            cb.DisplayMember = "Ten_NV";
            cb.ValueMember = "Ma_NV";
        }
        
        void LoadCBNSX(ComboBox cb)
        {
            cb.DataSource = NhaSanXuat_DAO.Instance.LayTatCaNSX();
            cb.DisplayMember = "tenNSX";
            cb.ValueMember = "maNSX";
        }
        
        void LoadSanPham(ComboBox cb, int maNSX)
        {
            cb.DataSource = SanPham_DAO.Instance.LayTatCaSanPhamTheoNSX(maNSX);
            cb.DisplayMember = "tenSP";
            cb.ValueMember = "maSP";
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if(nmSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SanPham_DTO sanPham = cbSanPham.SelectedItem as SanPham_DTO;
            SanPham_DTO sp = new SanPham_DTO((int)nmSoLuong.Value, sanPham.TenNSX, sanPham.DonGia, sanPham.MaSP, sanPham.TenSP, sanPham.ThongSoKyThuat, sanPham.TenLoaiSP, sanPham.MaLoaiSP, sanPham.MaNSX);
            sp.TongTien = sp.SoLuong * sp.DonGia;
            SP_NSX.Add(sp);
            DSSP.Add(sp);
            dtgvThemPhieuNhap.DataSource = SP_NSX;
        }


        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham_DTO sanPham = cbSanPham.SelectedItem as SanPham_DTO;
            if(cbSanPham.SelectedItem != null)
            {
                txtLoaiSanPham.Text = sanPham.TenLoaiSP;
                nmDonGia.Value = sanPham.DonGia;
            }

        }

        void resetForm()
        {
            DSSP = new List<SanPham_DTO>();
            cbNSX.Enabled = true;
            btnTimSP.Enabled = true;
            if (dtgvThemPhieuNhap.RowCount > 0)
            {
                dtgvThemPhieuNhap.Rows.Clear();
            }
            if(cbSanPham.Items.Count > 0)
            {
                cbSanPham.DataSource = null;
            }
        }
        private void dtgvThemPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvThemPhieuNhap.CurrentRow.Index;
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa sản phẩm thứ: " + (index+1), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(xacnhan == DialogResult.Yes)
                {
                    SP_NSX.RemoveAt(index);
                    DSSP.RemoveAt(index);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvThemPhieuNhap.RowCount > 0)
                {
                    bool themPhieuNhap = PhieuNhap_DAO.Instance.ThemPhieuNhap(Convert.ToInt32(cbNhanVien.SelectedValue), Convert.ToInt32(cbNSX.SelectedValue), dtpkNgayNhap.Value);
                    if (themPhieuNhap)
                    {
                        int MaPN = PhieuNhap_DAO.Instance.LayMaPNMoi();
                        foreach (SanPham_DTO sp in DSSP)
                        {
                            CTPhieuNhap_DAO.Instance.ThemCTPhieuNhap(MaPN, sp.MaSP, sp.SoLuong, sp.DonGia);
                            SanPham_DAO.Instance.CapNhatSoLuong(sp.MaSP, sp.SoLuong);
                        }
                        MessageBox.Show("thêm thành công");
                        var HD = MessageBox.Show("bạn có muốn in phiếu nhập ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(HD == DialogResult.Yes)
                        {
                            fHoaDonNhap f = new fHoaDonNhap(MaPN);
                            f.Show();
                        }
                        resetForm();
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            LoadSanPham(cbSanPham, Convert.ToInt32(cbNSX.SelectedValue));
            if(cbSanPham.Items.Count > 0)
            {
                cbNSX.Enabled = false;
                btnTimSP.Enabled = false;
            }
        }

        private void fThemPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
