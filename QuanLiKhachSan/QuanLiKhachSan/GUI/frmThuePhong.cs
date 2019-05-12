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
using QuanLiKhachSan.DAO;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.GUI
{
    public partial class frmThuePhong : Office2007Form
    {
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private PHONG phongThue;
        private List<NHANVIEN> listNhanVien;
        private List<KHACHHANG> listKhachHang;
        private bool isLoading = true;
        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            pnlThongTinKH.Visible = false;
            LoadDuLieuThuePhong();
        }

        private void LoadDuLieuThuePhong()
        {
            phongThue = PhongDAO.Instance.LoadChiTietPhong(Common.phongThue.MaPhong);
            listNhanVien = NhanVienDAO.Instance.LoadAllNhanVien();
            listKhachHang = KhachHangDAO.Instance.LoadAllKhachHang();

            BindingData();
        }

        private void BindingData()
        {
            if (phongThue != null)
            {
                lblMaSoPhong.Text = phongThue.MaPhong.ToString();
                txtLoaiPhong.Text = phongThue.LOAIPHONG.TenLoaiPhong.ToString();
                txtGiaPhong.Text = phongThue.LOAIPHONG.DonGia.ToString();
            }

            if (listNhanVien != null)
            {
                cboNhanVien.DataSource = listNhanVien;
                cboNhanVien.DisplayMember = "TenNhanVien";
                cboNhanVien.ValueMember = "MaNhanVien";
            }

            if (listKhachHang != null)
            {
                cboKhachHang.DataSource = listKhachHang;
                cboKhachHang.DisplayMember = "TenKhachHang";
                cboKhachHang.ValueMember = "MaKhachHang";
                cboKhachHang.Text = "";
            }

            dtpNgayThue.Value = dtpNgayTra.Value = DateTime.Now;
            LoadDataComboBoxQuocTich();
            isLoading = false;
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

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                pnlThongTinKH.Visible = true;
                int maKhachHang = (int)cboKhachHang.SelectedValue;
                KHACHHANG khachHang = listKhachHang.SingleOrDefault(item => item.MaKhachHang == maKhachHang);
                if (khachHang != null)
                {
                    txtTenKH.Text = khachHang.TenKhachHang;
                    txtCMND.Text = khachHang.CMND;
                    txtDiaChi.Text = khachHang.DiaChi;
                    txtSDT.Text = khachHang.DienThoai;
                    cboQuocTich.Text = khachHang.QuocTich;
                    radNam.Checked = khachHang.GioiTinh.Value ? false : true;
                    radNu.Checked = !radNam.Checked;
                }
            }
        }

        private void radKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            cboKhachHang.Text = "";
            RadioButton rad = sender as RadioButton;
            if (rad.Tag.ToString() == "Mới")
            {
                pnlThongTinKH.Visible = true;
                ResetControl();
            }
            else
            {
                pnlThongTinKH.Visible = false;
            }
        }

        private int ValidationForm()
        {
            int check = 0;
            if (dtpNgayThue.Value < DateTime.Now)
            {
                dtpNgayThue.BackColor = Color.Coral;
                check++;
            }

            if (dtpNgayTra.Value < dtpNgayThue.Value)
            {
                dtpNgayThue.BackColor = Color.Coral;
                check++;
            }

            if (txtTenKH.Text.Trim() == "")
            {
                txtTenKH.BackColor = Color.Coral;
                check++;
            }

            if (txtCMND.Text.Trim() == "")
            {
                txtCMND.BackColor = Color.Coral;
                check++;
            }

            return check;
        }

        private void itemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemLuu_Click(object sender, EventArgs e)
        {
            if (ValidationForm() > 0)
            {
                MessageBoxEx.Show("Dữ liệu bạn nhập bị sai. Xin kiểm tra lại", "Thông báo");
                return;
            }

            PHIEUTHUEPHONG phieuThue = new PHIEUTHUEPHONG();
            CHITIETPHIEUTHUE chiTiet = new CHITIETPHIEUTHUE();
            int maKH = 0;

            if (radKhachHangMoi.Checked)
            {
                KHACHHANG kh = new KHACHHANG();
                kh.TenKhachHang = txtTenKH.Text.Trim();
                kh.DienThoai = txtSDT.Text;
                kh.GioiTinh = radNam.Checked ? false : true;
                kh.DiaChi = txtDiaChi.Text;
                kh.CMND = txtCMND.Text;
                kh.QuocTich = cboQuocTich.Text;

                maKH = KhachHangDAO.Instance.ThemKhachHang(kh);
            }
            else
            {
                maKH = (int)cboKhachHang.SelectedValue;
            }

            phieuThue.MaKhachHang = maKH;
            phieuThue.MaNhanVien = (int)cboNhanVien.SelectedValue;

            chiTiet.MaPhong = int.Parse(lblMaSoPhong.Text);
            chiTiet.NgayThuePhong = dtpNgayThue.Value;
            chiTiet.NgayTraPhong = dtpNgayTra.Value;

            int ketQua = ThuePhongDAO.Instance.ThemPhieuThuePhong(phieuThue, chiTiet);
            if (ketQua > 0)
            {
                MessageBoxEx.Show("Đã thêm phiếu thuê phòng thành công", "Thông báo");
            }
            else
            {
                MessageBoxEx.Show("Đã thêm phiếu thuê phòng thất bại", "Thông báo");
            }
            ChangeBackColor();
            itemThoat.PerformClick();
        }

        private void ChangeBackColor()
        {
            dtpNgayThue.BackColor = dtpNgayTra.BackColor = txtTenKH.BackColor = txtCMND.BackColor = Color.White;
        }

        private void ResetControl()
        {
            txtCMND.Text = txtDiaChi.Text = txtSDT.Text = txtTenKH.Text = "";
            radNam.Checked = true;
            cboQuocTich.Text = "";
        }
    }
}
