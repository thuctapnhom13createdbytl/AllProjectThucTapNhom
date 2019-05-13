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
    public partial class frmPhong : Office2007Form
    {
        public frmPhong()
        {
            InitializeComponent();
            PhongDAO.Instance.CheckTrangThaiPhong();
        }

        private List<PHONG> listPhong;
        private List<LOAIPHONG> listLoaiPhong;
        private List<LOAITINHTRANG> listLoaiTinhTrang;

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhong();
        }

        private void LoadDanhSachPhong()
        {
            listPhong = PhongDAO.Instance.LoadAllPhong();
            listLoaiPhong = LoaiPhongDAO.Instance.LoadAllLoaiPhong();
            listLoaiTinhTrang = LoaiTinhTrangDAO.Instance.LoadAllLoaiTinhTrang();

            int idx = 0;
            foreach(ButtonX btn in grpDanhSachPhong.Controls)
            {
                PHONG phong = listPhong[idx++];
                btn.Text = "Mã phòng: " + phong.MaPhong;
                btn.Tag = phong.MaPhong;
                switch (phong.LOAIPHONG.MaLoaiPhong)
                {
                    case 1:
                        btn.Image = QuanLiKhachSan.Properties.Resources.DB;
                        break;
                    case 2:
                        btn.Image = QuanLiKhachSan.Properties.Resources.LoaiI;
                        break;
                    case 3:
                        btn.Image = QuanLiKhachSan.Properties.Resources.LoaiII;
                        break;
                    case 4:
                        btn.Image = QuanLiKhachSan.Properties.Resources.LoaiIII;
                        break;
                }

                if (phong.LOAITINHTRANG.TenLoaiTinhTrang == "Trống")
                {
                    btn.BackColor = Color.RoyalBlue;
                }
                else if (phong.LOAITINHTRANG.TenLoaiTinhTrang == "Có người ở")
                {
                    btn.BackColor = Color.Coral;
                }
                else if (phong.LOAITINHTRANG.TenLoaiTinhTrang == "Đặt")
                {
                    btn.BackColor = Color.Yellow;
                }
            }

            LoadDataComboBox();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ButtonX btnPhong = sender as ButtonX;
            int maPhong = (int)btnPhong.Tag;
            PHONG phong = listPhong.SingleOrDefault(item => item.MaPhong == maPhong);
            if (phong != null)
            {
                txtMaPhong.Text = phong.MaPhong.ToString();
                txtGhiChu.Text = phong.GhiChu == null ? "" : phong.GhiChu.ToString();
                txtTienPhong.Text = phong.LOAIPHONG.DonGia.ToString();
                cboLoaiPhong.Text = phong.LOAIPHONG.TenLoaiPhong;
                cboTinhTrang.Text = phong.LOAITINHTRANG.TenLoaiTinhTrang;

                if (phong.LOAITINHTRANG.TenLoaiTinhTrang == "Đặt" || phong.LOAITINHTRANG.TenLoaiTinhTrang == "Có người ở")
                {
                    btnDatPhong.Enabled = false;
                }
                else
                {
                    btnDatPhong.Enabled = true;
                }

                if (phong.LOAITINHTRANG.TenLoaiTinhTrang == "Có người ở")
                {
                    btnThanhToan.Enabled = true;
                }
                else
                {
                    btnThanhToan.Enabled = false;
                }
            }
        }

        private void LoadDataComboBox()
        {
            if (listLoaiTinhTrang != null)
            {
                cboTinhTrang.DataSource = listLoaiTinhTrang;
                cboTinhTrang.DisplayMember = "TenLoaiTinhTrang";
                cboTinhTrang.ValueMember = "MaLoaiTinhTrang";
            }

            if (listLoaiPhong != null)
            {
                cboLoaiPhong.DataSource = listLoaiPhong;
                cboLoaiPhong.DisplayMember = "TenLoaiPhong";
                cboLoaiPhong.ValueMember = "MaLoaiPhong";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBoxEx.Show("Bạn phải chọn 1 phòng để chỉnh sửa", "Thông báo");
            }
            else
            {
                PHONG phong = new PHONG();
                phong.MaLoaiPhong = (int)cboLoaiPhong.SelectedValue;
                phong.MaLoaiTinhTrang = (int)cboTinhTrang.SelectedValue;
                phong.GhiChu = txtGhiChu.Text.Trim();

                int ketQua = PhongDAO.Instance.ChinhSuaPhong(phong);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Chỉnh sửa phòng thành công", "Thông báo");
                    LoadDanhSachPhong();
                }
                else
                {
                    MessageBoxEx.Show("Chỉnh sửa phòng thất bại", "Thông báo");
                    LoadDanhSachPhong();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBoxEx.Show("Bạn phải chọn 1 phòng để đặt", "Thông báo");
                return;
            }

            Common.phongThue = listPhong.SingleOrDefault(item => item.MaPhong == int.Parse(txtMaPhong.Text));
            if (Common.phongThue != null)
            {
                Common.frmThuePhong = new frmThuePhong();
                Common.frmThuePhong.ShowDialog();
                LoadDanhSachPhong();
                Common.phongThue = null;
                Common.frmThuePhong = null;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBoxEx.Show("Bạn phải chọn 1 phòng để thanh toán hóa đơn", "Thông báo");
                return;
            }

            Common.phongThue = listPhong.SingleOrDefault(item => item.MaPhong == int.Parse(txtMaPhong.Text));
            if (Common.phongThue != null)
            {
                Common.frmChiTietHoaDon = new frmChiTietHoaDon();
                Common.frmChiTietHoaDon.ShowDialog();
                LoadDanhSachPhong();
                Common.phongThue = null;
                Common.frmChiTietHoaDon = null;
            }
        }
    }
}
