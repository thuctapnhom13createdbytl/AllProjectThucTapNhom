using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using QuanLiKhachSan.DAO;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.GUI
{
    public partial class frmChiTietHoaDon : Office2007Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private PHONG phongThue;
        private CHITIETPHIEUTHUE chiTietPhieuThue;
        private List<DICHVU> listDichVu;
        private List<LOAIPHONG> listLoaiPhong;

        private bool isLoading = true;
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadDuLieuHoaDon();
        }

        private void LoadDuLieuHoaDon()
        {
            phongThue = PhongDAO.Instance.LoadChiTietPhong(Common.phongThue.MaPhong);
            chiTietPhieuThue = ThuePhongDAO.Instance.LoadChiTietPhongThue(phongThue.MaPhong);
            listDichVu = DichVuDAO.Instance.LoadAllDichVu();
            listLoaiPhong = LoaiPhongDAO.Instance.LoadAllLoaiPhong();
            LoadDataLenControl();
        }

        private void LoadDataLenControl()
        {
            LoadDataComboBoxQuocTich();
            LoadDataComboBoxHTTT();

            txtMaPhieuThue.Text = chiTietPhieuThue.PHIEUTHUEPHONG.MaPhieuThue.ToString();
            txtMaPhong.Text = chiTietPhieuThue.PHONG.MaPhong.ToString();
            cboLoaiPhong.DataSource = listLoaiPhong;
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";
            dtpNgayThuePhong.Value = chiTietPhieuThue.NgayThuePhong.Value;
            dtpNgayHenTra.Value = chiTietPhieuThue.NgayTraPhong.Value;

            txtTenKH.Text = chiTietPhieuThue.PHIEUTHUEPHONG.KHACHHANG.TenKhachHang;
            radNam.Checked = chiTietPhieuThue.PHIEUTHUEPHONG.KHACHHANG.GioiTinh.Value ? false : true;
            radNu.Checked = !radNam.Checked;
            txtCMND.Text = chiTietPhieuThue.PHIEUTHUEPHONG.KHACHHANG.CMND;
            txtSDT.Text = chiTietPhieuThue.PHIEUTHUEPHONG.KHACHHANG.DienThoai;
            txtDiaChi.Text = chiTietPhieuThue.PHIEUTHUEPHONG.KHACHHANG.DiaChi;
            cboQuocTich.Text = chiTietPhieuThue.PHIEUTHUEPHONG.KHACHHANG.QuocTich;

            chklstDichVu.DataSource = listDichVu;
            chklstDichVu.DisplayMember = "TenHienThi";
            chklstDichVu.ValueMember = "MaDichVu";
            txtNhanVien.Text = chiTietPhieuThue.PHIEUTHUEPHONG.NHANVIEN.TenNhanVien;

            txtTongTien.Text = txtTongTienDV.Text = txtPhuThu.Text = txtGiamGiaKH.Text = "0";
            isLoading = false;
        }

        private void LoadDataComboBoxHTTT()
        {
            cboHinhThucThanhToan.Items.Clear();
            cboHinhThucThanhToan.Items.Add("Tiền mặt");
            cboHinhThucThanhToan.Items.Add("Quẹt thẻ");
            cboHinhThucThanhToan.Items.Add("Ghi nợ");
        }

        private void LoadDataComboBoxQuocTich()
        {
            cboQuocTich.Items.Clear();
            cboQuocTich.Items.Add("Việt Nam");
            cboQuocTich.Items.Add("Cam-pu-chia");
            cboQuocTich.Items.Add("Lào");
            cboQuocTich.Items.Add("Thái Lan");
            cboQuocTich.Items.Add("Bru-nây");
            cboQuocTich.Items.Add("Ma-lai-si-a");
            cboQuocTich.Items.Add("My-an-ma");
            cboQuocTich.Items.Add("Đông Ti-mo");
            cboQuocTich.Items.Add("In-đô-nê-xi-a");
            cboQuocTich.Items.Add("Phi-lip-pin");
            cboQuocTich.Items.Add("Sin-ga-po");
            cboQuocTich.Items.Add("Trung Quốc");
            cboQuocTich.Items.Add("Nhật Bản");
            cboQuocTich.Items.Add("Ấn Độ");
            cboQuocTich.Items.Add("Hàn Quốc");
            cboQuocTich.Items.Add("Triều Tiên");
            cboQuocTich.Items.Add("Pa-ki-xtan");
            cboQuocTich.Items.Add("Nga");
            cboQuocTich.Items.Add("I-ran");
            cboQuocTich.Items.Add("I-rắc");
            cboQuocTich.Items.Add("Qatar");
        }

        private void chklstDichVu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DICHVU dichVu = chklstDichVu.Items[e.Index] as DICHVU;
            double tongTienDV = double.Parse(txtTongTienDV.Text);
            double tongTien = double.Parse(txtTongTien.Text);
            if (e.NewValue == CheckState.Checked)
            {
                tongTienDV += dichVu.DonGia.Value;
                tongTien += dichVu.DonGia.Value;
            }
            else
            {
                tongTienDV -= dichVu.DonGia.Value;
                tongTien -= dichVu.DonGia.Value;
            }
            txtTongTienDV.Text = tongTienDV.ToString();
            txtTongTien.Text = tongTien.ToString();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBoxX).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBoxX txt = sender as TextBoxX;
            double tongTien = double.Parse(txtTongTien.Text);
            double phi = double.Parse(txt.Text);
            if (txt.Name == "txtPhuThu")
            {
                tongTien += phi;
            }
            else
            {
                tongTien -= phi;
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<CHITIETHOADON> listChiTiet = new List<CHITIETHOADON>();
            for (int i = 0; i < chklstDichVu.Items.Count; i++)
            {
                if (chklstDichVu.GetItemChecked(i))
                {
                    DICHVU dichVu = chklstDichVu.Items[i] as DICHVU;
                    CHITIETHOADON ct = new CHITIETHOADON();
                    ct.MaDichVu = dichVu.MaDichVu;

                    listChiTiet.Add(ct);
                }
            }

            double tongTien = 0;

            TimeSpan time = DateTime.Now - dtpNgayHenTra.Value;
            int soNgay = time.Days > 0 ? time.Days : -time.Days;

            tongTien = double.Parse(txtTongTien.Text) + soNgay * chiTietPhieuThue.PHONG.LOAIPHONG.DonGia.Value;
            HOADONTHUE hoaDon = new HOADONTHUE();
            hoaDon.TongTien = tongTien;
            hoaDon.HinhThucThanhToan = cboHinhThucThanhToan.Text;
            hoaDon.PhuThu = double.Parse(txtPhuThu.Text);
            hoaDon.GiamGiaKH = double.Parse(txtGiamGiaKH.Text);
            hoaDon.MaPhieuThue = chiTietPhieuThue.PHIEUTHUEPHONG.MaPhieuThue;
            hoaDon.NgayLapHD = DateTime.Now;

            int maPhong = int.Parse(txtMaPhong.Text);
            int ketQua = HoaDonDAO.Instance.ThemMoiHoaDon(hoaDon, listChiTiet, maPhong);
            if (ketQua > 0)
            {
                MessageBoxEx.Show("Đã thêm mới hóa đơn thành công", "Thông báo");
            }
            else
            {
                MessageBoxEx.Show("Đã thêm mới hóa đơn thất bại", "Thông báo");
            }
            btnThoat.PerformClick();
        }
    }
}
