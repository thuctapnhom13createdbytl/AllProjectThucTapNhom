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
    public partial class frmDichVu : Office2007Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        private List<DICHVU> listDichVu;
        private List<DICHVU> listDichVuTimKiem;
        private List<LOAIDICHVU> listLoaiDichVu;
        private List<DONVI> listDonVi;


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
        }

        private void LoadDichVu()
        {
            listDichVu = DichVuDAO.Instance.LoadAllDichVu();
            listDonVi = DonViDAO.Instance.LoadAllDonVi();
            listLoaiDichVu = LoaiDichVuDAO.Instance.LoadAllLoaiDichVu();

            lvDichVu.Items.Clear();
            foreach (DICHVU dichVu in listDichVu)
            {
                ListViewItem listViewItem = new ListViewItem(dichVu.MaDichVu.ToString());
                listViewItem.SubItems.Add(dichVu.LOAIDICHVU.TenLoaiDichVu);
                listViewItem.SubItems.Add(dichVu.DONVI.TenDonVi);
                listViewItem.SubItems.Add(dichVu.DonGia.ToString());

                lvDichVu.Items.Add(listViewItem);
            }

            cboTenDV.DataSource = listLoaiDichVu;
            cboTenDV.DisplayMember = "TenLoaiDichVu";
            cboTenDV.ValueMember = "MaLoaiDichVu";

            cboTenDVCC.DataSource = listDonVi;
            cboTenDVCC.DisplayMember = "TenDonVi";
            cboTenDVCC.ValueMember = "MaDonVi";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lvDichVu.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 dịch vụ để chỉnh sửa", "Thông báo");
            }
            else
            {
                double donGia = 0;
                if (!double.TryParse(txtDonGia.Text, out donGia))
                {
                    MessageBoxEx.Show("Bạn đã nhập sai đơn giá", "Thông báo");
                    txtDonGia.BackColor = Color.Coral;
                    return;
                }
                DICHVU dv = new DICHVU();
                dv.MaDichVu = int.Parse(txtMaDV.Text);
                dv.MaLoaiDichVu = (int)cboTenDV.SelectedValue;
                dv.MaDonVi = (int)cboTenDVCC.SelectedValue;
                dv.DonGia = donGia;

                int ketQua = DichVuDAO.Instance.ChinhSuaDichVu(dv);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Chỉnh sửa dịch vụ thành công", "Thông báo");
                    txtDonGia.BackColor = Color.White;
                    LoadDichVu();
                }
                else
                {
                    MessageBoxEx.Show("Chỉnh sửa dịch vụ thất bại", "Thông báo");
                    txtDonGia.BackColor = Color.White;
                    LoadDichVu();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDichVu.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 dịch vụ để xóa", "Thông báo");
            }
            else
            {
                int maDV = txtMaDV.Text == "" ? 0 : int.Parse(txtMaDV.Text);
                if (maDV == 0)
                {
                    MessageBoxEx.Show("Không thể xóa dịch vụ này", "Thông báo");
                }
                else
                {
                    int ketQua = DichVuDAO.Instance.XoaDichVu(maDV);
                    if (ketQua > 0)
                    {
                        MessageBoxEx.Show("Xóa dịch vụ thành công", "Thông báo");
                        LoadDichVu();
                        ResetLayout();
                    }
                    else
                    {
                        MessageBoxEx.Show("Xóa dịch vụ thất bại", "Thông báo");
                        LoadDichVu();
                    }
                }
            }
        }

        private void ResetLayout()
        {
            txtMaDV.Text = "";
            cboTenDV.Text = "";
            cboTenDVCC.Text = "";
            txtDonGia.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadDichVu();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strTimKiem = txtTimKiem.Text.Trim().ToLower();
            listDichVuTimKiem = listDichVu.Where(item => item.LOAIDICHVU.TenLoaiDichVu.ToLower().Contains(strTimKiem)).ToList();
            if (listDichVuTimKiem == null || listDichVuTimKiem.Count == 0)
            {
                MessageBoxEx.Show("Không tìm thấy dịch vụ này", "Thông báo");
                LoadDichVu();
                return;
            }

            lvDichVu.Items.Clear();
            foreach (DICHVU dichVu in listDichVuTimKiem)
            {
                ListViewItem listViewItem = new ListViewItem(dichVu.MaDichVu.ToString());
                listViewItem.SubItems.Add(dichVu.LOAIDICHVU.TenLoaiDichVu);
                listViewItem.SubItems.Add(dichVu.DONVI.TenDonVi);
                listViewItem.SubItems.Add(dichVu.DonGia.ToString());

                lvDichVu.Items.Add(listViewItem);
            }
        }

        private void lvDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDichVu.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lvDichVu.SelectedItems[0];
                txtMaDV.Text = lvItem.SubItems[0].Text;
                cboTenDV.Text = lvItem.SubItems[1].Text;
                cboTenDVCC.Text = lvItem.SubItems[2].Text;
                txtDonGia.Text = lvItem.SubItems[3].Text;
            }
        }
    }
}
