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
    public partial class frmLoaiPhong : Office2007Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private List<LOAIPHONG> listLoaiPhong;
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
        }

        private void LoadLoaiPhong()
        {
            listLoaiPhong = LoaiPhongDAO.Instance.LoadAllLoaiPhong();

            lvLoaiPhong.Items.Clear();
            foreach (LOAIPHONG loaiPhong in listLoaiPhong)
            {
                ListViewItem listViewItem = new ListViewItem(loaiPhong.MaLoaiPhong.ToString());
                listViewItem.SubItems.Add(loaiPhong.TenLoaiPhong);
                listViewItem.SubItems.Add(loaiPhong.DonGia.ToString());
                listViewItem.SubItems.Add(loaiPhong.SoNguoiTieuChuan.ToString());
                listViewItem.SubItems.Add(loaiPhong.SoNguoiToiDa.ToString());

                lvLoaiPhong.Items.Add(listViewItem);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoaiPhong.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lvLoaiPhong.SelectedItems[0];
                txtMaLP.Text = lvItem.SubItems[0].Text;
                txtTenLP.Text = lvItem.SubItems[1].Text;
                txtDonGia.Text = lvItem.SubItems[2].Text;
                txtTieuChuan.Text = lvItem.SubItems[3].Text;
                txtToiDa.Text = lvItem.SubItems[4].Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvLoaiPhong.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 loại phòng để xóa", "Thông báo");
            }
            else
            {
                int maLP = txtMaLP.Text == "" ? 0 : int.Parse(txtMaLP.Text);
                if (maLP == 0)
                {
                    MessageBoxEx.Show("Không thể xóa loại phòng này", "Thông báo");
                }
                else
                {
                    int ketQua = LoaiPhongDAO.Instance.XoaLoaiPhong(maLP);
                    if (ketQua > 0)
                    {
                        MessageBoxEx.Show("Xóa loại phòng thành công", "Thông báo");
                        LoadLoaiPhong();
                        ResetLayout();
                    }
                    else
                    {
                        MessageBoxEx.Show("Xóa loại phòng thất bại", "Thông báo");
                        LoadLoaiPhong();
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
            txtMaLP.Text = "";
            txtTenLP.Text = "";
            txtDonGia.Text = "";
            txtTieuChuan.Text = "";
            txtToiDa.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soLuong = 0;
            if (ValidateControl() > 0)
            {
                MessageBoxEx.Show("Dữ liệu bạn nhập bị sai. Xin kiểm tra lại", "Thông báo");
                return;
            }

            LOAIPHONG lp = new LOAIPHONG();
            lp.MaLoaiPhong = txtMaLP.Text == "" ? 0 : int.Parse(txtMaLP.Text);
            lp.TenLoaiPhong = txtTenLP.Text.Trim();
            lp.DonGia = double.Parse(txtDonGia.Text);
            lp.SoNguoiTieuChuan = int.Parse(txtTieuChuan.Text);
            lp.SoNguoiToiDa = int.Parse(txtToiDa.Text);

            if (lp.MaLoaiPhong == 0)
            {
                int ketQua = LoaiPhongDAO.Instance.ThemLoaiPhong(lp);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Thêm mới loại phòng thành công", "Thông báo");
                    LoadLoaiPhong();
                    ChangeBackColor();
                }
                else
                {
                    MessageBoxEx.Show("Thêm mới loại phòng thất bại", "Thông báo");
                    LoadLoaiPhong();
                }
            }
            else
            {
                int ketQua = LoaiPhongDAO.Instance.ChinhSuaLoaiPhong(lp);
                if (ketQua > 0)
                {
                    MessageBoxEx.Show("Chỉnh sửa loại phòng thành công", "Thông báo");
                    LoadLoaiPhong();
                    ChangeBackColor();
                }
                else
                {
                    MessageBoxEx.Show("Chỉnh sửa loại phòng thất bại", "Thông báo");
                    LoadLoaiPhong();
                }
            }
        }

        private int ValidateControl()
        {
            int check = 0;
            double donGia = 0;
            int soNguoiTieuChuan = 0;
            int soNguoiToiDa = 0;
            if (!double.TryParse(txtDonGia.Text, out donGia))
            {
                check++;
                txtDonGia.BackColor = Color.Coral;
            }
            if (!int.TryParse(txtTieuChuan.Text, out soNguoiTieuChuan))
            {
                check++;
                txtTieuChuan.BackColor = Color.Coral;
            }
            if (!int.TryParse(txtToiDa.Text, out soNguoiToiDa))
            {
                check++;
                txtToiDa.BackColor = Color.Coral;
            }
            return check;
        }

        private void ChangeBackColor()
        {
            txtDonGia.BackColor = txtTieuChuan.BackColor = txtToiDa.BackColor = Color.White;
        }
    }
}
