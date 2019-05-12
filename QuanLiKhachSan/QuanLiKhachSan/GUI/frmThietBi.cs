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
    public partial class frmThietBi : Office2007Form
    {
        public frmThietBi()
        {
            InitializeComponent();
        }

        private List<THIETBI> listThietBi;
        private List<THIETBI> listThietBiTimKiem;
        private List<LOAIPHONG> listLoaiPhong;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            LoadThietBi();
        }

        private void LoadThietBi()
        {
            listLoaiPhong = LoaiPhongDAO.Instance.LoadAllLoaiPhong();
            listThietBi = ThietBiDAO.Instance.LoadAllThietBi();

            lvThietBi.Items.Clear();
            foreach (THIETBI thietBi in listThietBi)
            {
                ListViewItem listViewItem = new ListViewItem(thietBi.MaThietBi.ToString());
                listViewItem.SubItems.Add(thietBi.TenThietBi);
                listViewItem.SubItems.Add(thietBi.LOAIPHONG.TenLoaiPhong);
                listViewItem.SubItems.Add(thietBi.SoLuong.ToString());

                lvThietBi.Items.Add(listViewItem);
            }

            cboLoaiPhong.DataSource = listLoaiPhong;
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void lvThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThietBi.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lvThietBi.SelectedItems[0];
                txtMaTB.Text = lvItem.SubItems[0].Text;
                txtTenTB.Text = lvItem.SubItems[1].Text;
                cboLoaiPhong.Text = lvItem.SubItems[2].Text;
                txtSoLuong.Text = lvItem.SubItems[3].Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvThietBi.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 thiết bị để xóa", "Thông báo");
            }
            else
            {
                int maTB = txtMaTB.Text == "" ? 0 : int.Parse(txtMaTB.Text);
                if (maTB == 0)
                {
                    MessageBoxEx.Show("Không thể xóa thiết bị này", "Thông báo");
                }
                else
                {
                    int ketQua = ThietBiDAO.Instance.XoaThietBi(maTB);
                    if (ketQua > 0)
                    {
                        MessageBoxEx.Show("Xóa thiết bị thành công", "Thông báo");
                        LoadThietBi();
                        ResetLayout();
                    }
                    else
                    {
                        MessageBoxEx.Show("Xóa thiết bị thất bại", "Thông báo");
                        LoadThietBi();
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetLayout();
        }

        private void ResetLayout()
        {
            txtMaTB.Text = "";
            txtTenTB.Text = "";
            txtSoLuong.Text = "";
            cboLoaiPhong.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soLuong = 0;
            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBoxEx.Show("Bạn nhập sai số lượng", "Thông báo");
                txtSoLuong.BackColor = Color.Coral;
                return;
            }
            THIETBI tb = new THIETBI();
            tb.MaThietBi = txtMaTB.Text == "" ? 0 : int.Parse(txtMaTB.Text);
            tb.TenThietBi = txtTenTB.Text.Trim();
            tb.MaLoaiPhong = (int)cboLoaiPhong.SelectedValue;
            tb.SoLuong = soLuong;

            if (tb.MaThietBi == 0)
            {
                int ketQua = ThietBiDAO.Instance.ThemThietBi(tb);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Thêm mới thiết bị thành công", "Thông báo");
                    txtSoLuong.BackColor = Color.White;
                    LoadThietBi();
                }
                else
                {
                    MessageBoxEx.Show("Thêm mới thiết bị thất bại", "Thông báo");
                    txtSoLuong.BackColor = Color.White;
                    LoadThietBi();
                }
            }
            else
            {
                int ketQua = ThietBiDAO.Instance.ChinhSuaThietBi(tb);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Chỉnh sửa thiết bị thành công", "Thông báo");
                    txtSoLuong.BackColor = Color.White;
                    LoadThietBi();
                }
                else
                {
                    MessageBoxEx.Show("Chỉnh sửa thiết bị thất bại", "Thông báo");
                    txtSoLuong.BackColor = Color.White;
                    LoadThietBi();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadThietBi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strTimKiem = txtTimKiem.Text.Trim().ToLower();
            listThietBiTimKiem = listThietBi.Where(item => item.TenThietBi.ToLower().Contains(strTimKiem)).ToList();
            if (listThietBiTimKiem == null || listThietBiTimKiem.Count == 0)
            {
                MessageBoxEx.Show("Không tìm thấy thiết bị này", "Thông báo");
                LoadThietBi();
                return;
            }

            lvThietBi.Items.Clear();
            foreach (THIETBI thietBi in listThietBiTimKiem)
            {
                ListViewItem listViewItem = new ListViewItem(thietBi.MaThietBi.ToString());
                listViewItem.SubItems.Add(thietBi.TenThietBi);
                listViewItem.SubItems.Add(thietBi.LOAIPHONG.TenLoaiPhong);
                listViewItem.SubItems.Add(thietBi.SoLuong.ToString());

                lvThietBi.Items.Add(listViewItem);
            }
        }
    }
}
