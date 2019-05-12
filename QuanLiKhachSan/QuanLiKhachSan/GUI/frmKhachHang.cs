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
    public partial class frmKhachHang : Office2007Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private List<KHACHHANG> listKhachHang;
        private List<KHACHHANG> listKhachHangTimKiem;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            listKhachHang = KhachHangDAO.Instance.LoadAllKhachHang();
            lvKhachHang.Items.Clear();
            foreach (KHACHHANG khachHang in listKhachHang)
            {
                ListViewItem listViewItem = new ListViewItem(khachHang.MaKhachHang.ToString());
                listViewItem.SubItems.Add(khachHang.TenKhachHang);
                listViewItem.SubItems.Add(khachHang.GioiTinh.Value ? "Nữ" : "Nam");
                listViewItem.SubItems.Add(khachHang.CMND);
                listViewItem.SubItems.Add(khachHang.DienThoai);
                listViewItem.SubItems.Add(khachHang.DiaChi);
                listViewItem.SubItems.Add(khachHang.QuocTich);

                lvKhachHang.Items.Add(listViewItem);
            }

            LoadDataComboBoxQuocTich();
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

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lvKhachHang.SelectedItems[0];
                txtMaKH.Text = lvItem.SubItems[0].Text;
                txtTenKH.Text = lvItem.SubItems[1].Text;
                radNam.Checked = lvItem.SubItems[2].Text == "Nam" ? true : false;
                radNu.Checked = !radNam.Checked;
                txtCMND.Text = lvItem.SubItems[3].Text;
                txtSDT.Text = lvItem.SubItems[4].Text;
                txtDiaChi.Text = lvItem.SubItems[5].Text;
                cboQuocTich.Text = lvItem.SubItems[6].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetLayout();
        }

        private void ResetLayout()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            radNam.Checked = true;
            radNu.Checked = false;
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            cboQuocTich.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 khách hàng để xóa", "Thông báo");
            }
            else
            {
                int maKH = txtMaKH.Text == "" ? 0 : int.Parse(txtMaKH.Text);
                if (maKH == 0)
                {
                    MessageBoxEx.Show("Không thể xóa khách hàng này", "Thông báo");
                }
                else
                {
                    int ketQua = KhachHangDAO.Instance.XoaKhachHang(maKH);
                    if (ketQua > 0)
                    {
                        MessageBoxEx.Show("Xóa khách hàng thành công", "Thông báo");
                        LoadKhachHang();
                        ResetLayout();
                    }
                    else
                    {
                        MessageBoxEx.Show("Xóa khách hàng thất bại", "Thông báo");
                        LoadKhachHang();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.MaKhachHang = txtMaKH.Text == "" ? 0 : int.Parse(txtMaKH.Text);
            kh.TenKhachHang = txtTenKH.Text.Trim();
            kh.DienThoai = txtSDT.Text;
            kh.GioiTinh = radNam.Checked ? false : true;
            kh.DiaChi = txtDiaChi.Text;
            kh.CMND = txtCMND.Text;
            kh.QuocTich = cboQuocTich.Text;

            if (kh.MaKhachHang == 0)
            {
                int ketQua = KhachHangDAO.Instance.ThemKhachHang(kh);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Thêm mới khách hàng thành công", "Thông báo");
                    LoadKhachHang();
                }
                else
                {
                    MessageBoxEx.Show("Thêm mới khách hàng thất bại", "Thông báo");
                    LoadKhachHang();
                }
            }
            else
            {
                int ketQua = KhachHangDAO.Instance.ChinhSuaKhachHang(kh);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Chỉnh sửa khách hàng thành công", "Thông báo");
                    LoadKhachHang();
                }
                else
                {
                    MessageBoxEx.Show("Chỉnh sửa khách hàng thất bại", "Thông báo");
                    LoadKhachHang();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadKhachHang();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strTimKiem = txtTimKiem.Text.Trim().ToLower();
            listKhachHangTimKiem = listKhachHang.Where(item => item.TenKhachHang.ToLower().Contains(strTimKiem)).ToList();
            if (listKhachHangTimKiem == null || listKhachHangTimKiem.Count == 0)
            {
                MessageBoxEx.Show("Không tìm thấy khách hàng này", "Thông báo");
                LoadKhachHang();
                return;
            }

            lvKhachHang.Items.Clear();
            foreach (KHACHHANG khachHang in listKhachHangTimKiem)
            {
                ListViewItem listViewItem = new ListViewItem(khachHang.MaKhachHang.ToString());
                listViewItem.SubItems.Add(khachHang.TenKhachHang);
                listViewItem.SubItems.Add(khachHang.GioiTinh.Value ? "Nữ" : "Nam");
                listViewItem.SubItems.Add(khachHang.CMND);
                listViewItem.SubItems.Add(khachHang.DienThoai);
                listViewItem.SubItems.Add(khachHang.DiaChi);
                listViewItem.SubItems.Add(khachHang.QuocTich);

                lvKhachHang.Items.Add(listViewItem);
            }
        }
    }
}
