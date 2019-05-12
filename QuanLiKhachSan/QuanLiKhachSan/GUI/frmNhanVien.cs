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
using QuanLiKhachSan.DTO;
using QuanLiKhachSan.DAO;

namespace QuanLiKhachSan.GUI
{
    public partial class frmNhanVien : Office2007Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private List<NHANVIEN> listNhanVien;
        private List<NHANVIEN> listNhanVienTimKiem;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            listNhanVien = NhanVienDAO.Instance.LoadAllNhanVien();
            lvNhanVien.Items.Clear();
            foreach (NHANVIEN nhanVien in listNhanVien)
            {
                ListViewItem listViewItem = new ListViewItem(nhanVien.MaNhanVien.ToString());
                listViewItem.SubItems.Add(nhanVien.TenNhanVien);
                listViewItem.SubItems.Add(nhanVien.GioiTinh.Value ? "Nữ" : "Nam");
                listViewItem.SubItems.Add(nhanVien.SDT);

                lvNhanVien.Items.Add(listViewItem);
            }
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lvNhanVien.SelectedItems[0];
                txtMaNV.Text = lvItem.SubItems[0].Text;
                txtTenNV.Text = lvItem.SubItems[1].Text;
                radNam.Checked = lvItem.SubItems[2].Text == "Nam" ? true : false;
                radNu.Checked = !radNam.Checked;
                txtSDT.Text = lvItem.SubItems[3].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetLayout();
        }

        private void ResetLayout()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            radNam.Checked = true;
            radNu.Checked = false;
            txtSDT.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 nhân viên để xóa", "Thông báo");
            }
            else
            {
                int maNV = txtMaNV.Text == "" ? 0 : int.Parse(txtMaNV.Text);
                if (maNV == 0)
                {
                    MessageBoxEx.Show("Không thể xóa nhân viên này", "Thông báo");
                }
                else
                {
                    int ketQua = NhanVienDAO.Instance.XoaNhanVien(maNV);
                    if (ketQua > 0)
                    {
                        MessageBoxEx.Show("Xóa nhân viên thành công", "Thông báo");
                        LoadNhanVien();
                        ResetLayout();
                    }
                    else
                    {
                        MessageBoxEx.Show("Xóa nhân viên thất bại", "Thông báo");
                        LoadNhanVien();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MaNhanVien = txtMaNV.Text == "" ? 0 : int.Parse(txtMaNV.Text);
            nv.TenNhanVien = txtTenNV.Text.Trim();
            nv.SDT = txtSDT.Text;
            nv.GioiTinh = radNam.Checked ? false : true;

            if (nv.MaNhanVien == 0)
            {
                int ketQua = NhanVienDAO.Instance.ThemNhanVien(nv);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Thêm mới nhân viên thành công", "Thông báo");
                    LoadNhanVien();
                }
                else
                {
                    MessageBoxEx.Show("Thêm mới nhân viên thất bại", "Thông báo");
                    LoadNhanVien();
                }
            }
            else
            {
                int ketQua = NhanVienDAO.Instance.ChinhSuaNhanVien(nv);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Chỉnh sửa nhân viên thành công", "Thông báo");
                    LoadNhanVien();
                }
                else
                {
                    MessageBoxEx.Show("Chỉnh sửa nhân viên thất bại", "Thông báo");
                    LoadNhanVien();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadNhanVien();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strTimKiem = txtTimKiem.Text.Trim().ToLower();
            listNhanVienTimKiem = listNhanVien.Where(item => item.TenNhanVien.ToLower().Contains(strTimKiem)).ToList();
            if (listNhanVienTimKiem == null || listNhanVienTimKiem.Count == 0)
            {
                MessageBoxEx.Show("Không tìm thấy nhân viên này", "Thông báo");
                LoadNhanVien();
                return;
            }

            lvNhanVien.Items.Clear();
            foreach (NHANVIEN nhanVien in listNhanVienTimKiem)
            {
                ListViewItem listViewItem = new ListViewItem(nhanVien.MaNhanVien.ToString());
                listViewItem.SubItems.Add(nhanVien.TenNhanVien);
                listViewItem.SubItems.Add(nhanVien.GioiTinh.Value ? "Nữ" : "Nam");
                listViewItem.SubItems.Add(nhanVien.SDT);

                lvNhanVien.Items.Add(listViewItem);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
