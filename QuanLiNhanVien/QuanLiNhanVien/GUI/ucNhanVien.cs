using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using BusinessLogicLayer;
using DataTransferObject;

namespace QuanLiNhanVien.GUI
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        List<NHANVIEN_DTO> lstNhanVien;
        List<NHANVIEN_DTO> lstNhanVien_NGS;
        List<PHONGBAN_DTO> lstPhongBan;
        List<NHANVIEN_DTO> lstNhanVienTimKiem;
        protected override void OnLoad(EventArgs e)
        {
            lstNhanVien = NHANVIEN_BUL.LoadTatCaNhanVien();
            lstNhanVien_NGS = NHANVIEN_BUL.LoadComboBoxNGS();
            lstPhongBan = PHONGBAN_BUL.LoadTatCaPhongBan();

            cboNguoiGS.DataSource = lstNhanVien_NGS;
            cboNguoiGS.DisplayMember = "HoTen";
            cboNguoiGS.ValueMember = "MaNV";

            cboPhongBan.DataSource = lstPhongBan;
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";

            dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
            dgvNhanVien.DataSource = lstNhanVien;
            EditDataGridView();
        }

        private void EditDataGridView()
        {
            dgvNhanVien.Columns["MaNV"].Visible = false;
            dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["HoTen"].Width = 240;
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["NgaySinh"].Width = 170;
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["DiaChi"].Width = 190;
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvNhanVien.Columns["GioiTinh"].Width = 104;
            dgvNhanVien.Columns["Luong"].HeaderText = "Lương";
            dgvNhanVien.Columns["Luong"].Width = 140;
            dgvNhanVien.Columns["MaPB"].Visible = false;
            dgvNhanVien.Columns["MaNGS"].Visible = false;
            dgvNhanVien.Columns["TenPB"].HeaderText = "Tên Phòng Ban";
            dgvNhanVien.Columns["TenPB"].Width = 220;
            dgvNhanVien.Columns["TenNGS"].HeaderText = "Người Giám Sát";
            dgvNhanVien.Columns["TenNGS"].Width = 220;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach(ucNhanVien uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucNhanVien>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvNhanVien.Rows[index];
                lblMaNV.Text = dr.Cells["MaNV"].Value == null ? "" : dr.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = dr.Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
                txtLuong.Text = dr.Cells["Luong"].Value == null ? "0" : dr.Cells["Luong"].Value.ToString();
                cboPhongBan.SelectedValue = dr.Cells["MaPB"].Value;
                cboNguoiGS.SelectedValue = dr.Cells["MaNGS"].Value;
                radNam.Checked = dr.Cells["GioiTinh"].Value.ToString() == "Nam" ? true : false;
                radNu.Checked = !radNam.Checked;
                dtpNgaySinh.Value = dr.Cells["NgaySinh"].Value == null ? DateTime.Now : DateTime.Parse(dr.Cells["NgaySinh"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
            lstNhanVien.Add(nvDTO);
            dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
            dgvNhanVien.DataSource = lstNhanVien;
            dgvNhanVien.Rows[dgvNhanVien.Rows.Count - 1].Selected = true;
            ResetAll();
            EditDataGridView();
        }

        private void ResetAll()
        {
            lblMaNV.Text = "";
            txtHoTen.Text = "";
            txtLuong.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cboPhongBan.SelectedValue = lstPhongBan[0];
            cboNguoiGS.SelectedValue = lstNhanVien_NGS[0];
        }

        private int ValidateData(NHANVIEN_DTO nvDTO)
        {
            var lstNVTrungMa = lstNhanVien.Where(item => item.MaNV == nvDTO.MaNV);
            int err = 0;
            if (lstNhanVien.Count != 0)
            {
                lblMaNV.BackColor = Color.Coral;
                err++;
            }
            if (nvDTO.Hoten == "")
            {
                txtHoTen.BackColor = Color.Coral;
                err++;
            }
            if (nvDTO.Luong < 0)
            {
                txtLuong.BackColor = Color.Coral;
                err++;
            }
            return err;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
                dgvNhanVien.DataSource = lstNhanVien;
                EditDataGridView();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = txtSearch.Text;
            lstNhanVienTimKiem = NHANVIEN_BUL.TimKiemNhanVien(searchStr);
            if (lstNhanVienTimKiem == null || lstNhanVienTimKiem.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả");
                return;
            }
            dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
            dgvNhanVien.DataSource = lstNhanVienTimKiem;
            EditDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ít nhất một nhân viên để xóa", "Thông báo");
                return;
            }

            int maNV = int.Parse(dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int kq = NHANVIEN_BUL.XoaNhanVien(maNV);
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa nhân viên thành công", "Thông báo");
                    NHANVIEN_DTO nvDTO = lstNhanVien.Single(item => item.MaNV == maNV);
                    lstNhanVien.Remove(nvDTO);
                    dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
                    dgvNhanVien.DataSource = lstNhanVien;
                    EditDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại", "Thông báo");
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e) //txtLuong
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                return;
            }
            TextBox txt = sender as TextBox;
            DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
            dr.Cells[txt.Tag.ToString()].Value = txt.Text;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                return;
            }
            MetroRadioButton rad = sender as MetroRadioButton;
            DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
            dr.Cells["GioiTinh"].Value = rad.Tag.ToString();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
            dr.Cells["NgaySinh"].Value = dtpNgaySinh.Value.ToShortDateString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstNhanVien.Count; i++)
            {
                if (lstNhanVien[i].MaNV == null)
                {
                    lstNhanVien.Remove(lstNhanVien[i]);
                    i--;
                }
            }
            dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
            dgvNhanVien.DataSource = lstNhanVien;
            EditDataGridView();
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroComboBox cbo = sender as MetroComboBox;
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
            dr.Cells[cbo.Tag.ToString()].Value = cbo.Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
            nvDTO.MaNV = lblMaNV.Text == "" ? 0 : int.Parse(lblMaNV.Text);
            nvDTO.Hoten = txtHoTen.Text;
            nvDTO.NgaySinh = dtpNgaySinh.Value;
            nvDTO.DiaChi = txtDiaChi.Text;
            nvDTO.Luong = decimal.Parse(txtLuong.Text);
            nvDTO.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            nvDTO.MaPB = (int)cboPhongBan.SelectedValue;
            nvDTO.MaNGS = (int)cboNguoiGS.SelectedValue;
            int kq = NHANVIEN_BUL.CapNhatNhanVien(nvDTO);
            if (kq > 0)
            {
                if (nvDTO.MaNV == 0)
                {
                    MessageBox.Show("Thêm mới nhân viên thành công", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo");
                }
            } 
            else
            {
                if (nvDTO.MaNV == 0)
                {
                    MessageBox.Show("Thêm mới nhân viên thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo");
                }
            }

            lstNhanVien = NHANVIEN_BUL.LoadTatCaNhanVien();
            dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
            dgvNhanVien.DataSource = lstNhanVien;
            EditDataGridView();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
