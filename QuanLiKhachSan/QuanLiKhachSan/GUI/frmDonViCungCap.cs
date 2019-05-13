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
    public partial class frmDonViCungCap : Office2007Form
    {
        public frmDonViCungCap()
        {
            InitializeComponent();
        }

        private List<DONVI> listDonVi;
        private List<DONVI> listDonViTimKiem;
        private void frmDonViCungCap_Load(object sender, EventArgs e)
        {
            LoadDonViCungCap();
        }

        private void LoadDonViCungCap()
        {
            listDonVi = DonViDAO.Instance.LoadAllDonVi();
            lvDonVi.Items.Clear();
            foreach (DONVI donVi in listDonVi)
            {
                ListViewItem listViewItem = new ListViewItem(donVi.MaDonVi.ToString());
                listViewItem.SubItems.Add(donVi.TenDonVi);

                lvDonVi.Items.Add(listViewItem);
            }
        }

        private void lvDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDonVi.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lvDonVi.SelectedItems[0];
                txtMaDV.Text = lvItem.SubItems[0].Text;
                txtTenDV.Text = lvItem.SubItems[1].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetLayout();
        }

        private void ResetLayout()
        {
            txtMaDV.Text = txtTenDV.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDonVi.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 đơn vị cung cấp để xóa", "Thông báo");
            }
            else
            {
                int maDV = txtMaDV.Text == "" ? 0 : int.Parse(txtMaDV.Text);
                if (maDV == 0)
                {
                    MessageBoxEx.Show("Không thể xóa đơn vị cung cấp này", "Thông báo");
                }
                else
                {
                    int ketQua = DonViDAO.Instance.XoaDonVi(maDV);
                    if (ketQua > 0)
                    {
                        MessageBoxEx.Show("Xóa đơn vị cung cấp thành công", "Thông báo");
                        LoadDonViCungCap();
                        ResetLayout();
                    }
                    else
                    {
                        MessageBoxEx.Show("Xóa đơn vị cung cấp thất bại", "Thông báo");
                        LoadDonViCungCap();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DONVI dv = new DONVI();
            dv.MaDonVi = txtMaDV.Text == "" ? 0 : int.Parse(txtMaDV.Text);
            dv.TenDonVi = txtTenDV.Text.Trim();

            if (dv.MaDonVi == 0)
            {
                int ketQua = DonViDAO.Instance.ThemDonVi(dv);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Thêm mới đơn vị cung cấp thành công", "Thông báo");
                    LoadDonViCungCap();
                }
                else
                {
                    MessageBoxEx.Show("Thêm mới đơn vị cung cấp thất bại", "Thông báo");
                    LoadDonViCungCap();
                }
            }
            else
            {
                int ketQua = DonViDAO.Instance.ChinhSuaDonVi(dv);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Chỉnh sửa đơn vị thành công", "Thông báo");
                    LoadDonViCungCap();
                }
                else
                {
                    MessageBoxEx.Show("Chỉnh sửa đơn vị thất bại", "Thông báo");
                    LoadDonViCungCap();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadDonViCungCap();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strTimKiem = txtTimKiem.Text.Trim().ToLower();
            listDonViTimKiem = listDonVi.Where(item => item.TenDonVi.ToLower().Contains(strTimKiem)).ToList();
            if (listDonViTimKiem == null || listDonViTimKiem.Count == 0)
            {
                MessageBoxEx.Show("Không tìm thấy đơn vị cung cấp này", "Thông báo");
                LoadDonViCungCap();
                return;
            }

            lvDonVi.Items.Clear();
            foreach (DONVI donVi in listDonViTimKiem)
            {
                ListViewItem listViewItem = new ListViewItem(donVi.MaDonVi.ToString());
                listViewItem.SubItems.Add(donVi.TenDonVi);

                lvDonVi.Items.Add(listViewItem);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
