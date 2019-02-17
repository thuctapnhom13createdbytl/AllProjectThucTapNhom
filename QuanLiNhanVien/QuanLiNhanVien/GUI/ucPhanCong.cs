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
using DataTransferObject;
using BusinessLogicLayer;

namespace QuanLiNhanVien.GUI
{
    public partial class ucPhanCong : UserControl
    {
        public ucPhanCong()
        {
            InitializeComponent();
        }

        List<PHANCONG_DTO> lstPhanCong;
        List<DUAN_DTO> lstDuAn;
        List<NHANVIEN_DTO> lstNhanVien;
        List<PHANCONG_DTO> lstPhanCongTimKiem;

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucPhanCong uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucPhanCong>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            lstPhanCong = PHANCONG_BUL.LoadTatCaPhanCong();
            lstDuAn = DUAN_BUL.LoadComboBoxDuAn();
            lstNhanVien = NHANVIEN_BUL.LoadTatCaNhanVien();

            chklstNhanVien.DataSource = lstNhanVien;
            chklstNhanVien.DisplayMember = "HoTen";
            chklstNhanVien.ValueMember = "MaNV";

            cboDuAn.DataSource = lstDuAn;
            cboDuAn.DisplayMember = "TenDA";
            cboDuAn.ValueMember = "MaDA";

            dgvPhanCong.DataSource = typeof(List<PHANCONG_DTO>);
            dgvPhanCong.DataSource = lstPhanCong;
            EditDataGridView();
        }

        private void EditDataGridView()
        {
            dgvPhanCong.Columns["MaNV"].Visible = false;
            dgvPhanCong.Columns["HoTen"].HeaderText = "Nhân Viên";
            dgvPhanCong.Columns["HoTen"].Width = 300;
            dgvPhanCong.Columns["MaDA"].Visible = false;
            dgvPhanCong.Columns["TenDA"].HeaderText = "Dự Án";
            dgvPhanCong.Columns["TenDA"].Width = 300;
            dgvPhanCong.Columns["SoGio"].HeaderText = "Số Giờ Làm Việc";
            dgvPhanCong.Columns["SoGio"].Width = 300;
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow dr = dgvPhanCong.Rows[idx];
            txtSoGio.Text = dr.Cells["SoGio"].Value.ToString();
            cboDuAn.SelectedItem = dr.Cells["MaDA"].Value.ToString();
            ResetColorAllControl();

            for (int i = 0; i < chklstNhanVien.Items.Count; i++)
            {
                chklstNhanVien.SetItemChecked(i, false);
                NHANVIEN_DTO nvChecked = chklstNhanVien.Items[i] as NHANVIEN_DTO;
                if (nvChecked.MaNV == (int)dr.Cells["MaNV"].Value)
                {
                    chklstNhanVien.SetItemChecked(i, true);
                }
            }
        }

        private void ResetColorAllControl()
        {
            cboDuAn.BackColor = Color.White;
            txtSoGio.BackColor = Color.White;
            chklstNhanVien.BackColor = Color.White;
        }

        private int ValidateData()
        {
            int soGio;
            if (!int.TryParse(txtSoGio.Text, out soGio))
            {
                return 1;
            }

            int count = 0;
            for(int i = 0; i < chklstNhanVien.Items.Count; i++)
            {
                if (chklstNhanVien.GetItemCheckState(i) == CheckState.Checked)
                {
                    count++;
                }
            }
            if (count == 0) return 2;
            if (count > 1) return 3;
            return 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int validate = ValidateData();
            ResetColorAllControl();
            if (validate == 1)
            {
                MessageBox.Show("Số giờ bạn nhập không chính xác", "Thông báo");
                txtSoGio.BackColor = Color.Coral;
                return;
            }
            if (validate == 2)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào", "Thông báo");
                chklstNhanVien.BackColor = Color.Coral;
                return;
            }
            if (validate == 3)
            {
                MessageBox.Show("Bạn chỉ được chọn 1 nhân viên", "Thông báo");
                chklstNhanVien.BackColor = Color.Coral;
                return;
            }

            PHANCONG_DTO pcDTO = new PHANCONG_DTO();
            pcDTO.MaDA = (int)cboDuAn.SelectedValue;
            pcDTO.TenDA = cboDuAn.Text;
            pcDTO.SoGio = int.Parse(txtSoGio.Text);
            for (int i = 0; i < chklstNhanVien.Items.Count; i++)
            {
                if (chklstNhanVien.GetItemCheckState(i) == CheckState.Checked)
                {
                    NHANVIEN_DTO nvDTO = chklstNhanVien.Items[i] as NHANVIEN_DTO;
                    pcDTO.MaNV = nvDTO.MaNV;
                    pcDTO.HoTen = nvDTO.Hoten;
                    break;
                }
            }

            int kq = PHANCONG_BUL.ThemPhanCong(pcDTO);
            if (kq > 0)
            {
                MessageBox.Show("Thêm phân công dự án thành công", "Thông báo");
                lstPhanCong.Add(pcDTO);
                dgvPhanCong.DataSource = typeof(List<PHANCONG_DTO>);
                dgvPhanCong.DataSource = lstPhanCong;
                EditDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm phân công dự án thất bại. Đã tồn tại phân công này", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ít nhất một phân công dự án để xóa", "Thông báo");
                return;
            }

            int maNV = int.Parse(dgvPhanCong.SelectedRows[0].Cells["MaNV"].Value.ToString());
            int maDA = int.Parse(dgvPhanCong.SelectedRows[0].Cells["MaDA"].Value.ToString());

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phân công dự án này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                PHANCONG_DTO pcDTO = new PHANCONG_DTO() { MaNV = maNV, MaDA = maDA };
                int kq = PHANCONG_BUL.XoaPhanCong(pcDTO);
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa phân công dự án thành công", "Thông báo");
                    PHANCONG_DTO pcRemoved = lstPhanCong.Single(item => item.MaNV == maNV && item.MaDA == maDA);
                    lstPhanCong.Remove(pcRemoved);
                    dgvPhanCong.DataSource = typeof(List<PHANCONG_DTO>);
                    dgvPhanCong.DataSource = lstPhanCong;
                    EditDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa phân công dự án thất bại", "Thông báo");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ít nhất một phân công dự án để chỉnh sửa", "Thông báo");
                return;
            }
            DataGridViewRow dr = dgvPhanCong.SelectedRows[0];
            PHANCONG_DTO pcDTO = new PHANCONG_DTO();
            pcDTO.MaNV = int.Parse(dr.Cells["MaNV"].Value.ToString());
            pcDTO.MaDA = int.Parse(dr.Cells["MaDA"].Value.ToString());

            if ((int)cboDuAn.SelectedValue != pcDTO.MaDA)
            {
                MessageBox.Show("Bạn chỉ có thể thay đổi số giờ phân công dự án", "Thông báo");
                cboDuAn.BackColor = Color.Coral;
                return;
            }

            for (int i = 0; i < chklstNhanVien.Items.Count; i++)
            {
                NHANVIEN_DTO nvDTO = chklstNhanVien.Items[i] as NHANVIEN_DTO;
                if (chklstNhanVien.GetItemCheckState(i) == CheckState.Checked && nvDTO.MaNV != pcDTO.MaNV)
                {
                    MessageBox.Show("Bạn chỉ có thể thay đổi số giờ phân công dự án", "Thông báo");
                    chklstNhanVien.BackColor = Color.Coral;
                    return;
                }
            }

            int soGio;
            if (!int.TryParse(txtSoGio.Text, out soGio))
            {
                MessageBox.Show("Số giờ phân công không hợp lệ", "Thông báo");
                txtSoGio.BackColor = Color.Coral;
                return;
            }

            pcDTO.SoGio = soGio;
            int kq = PHANCONG_BUL.CapNhatPhanCong(pcDTO);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật phân công dự án thành công", "Thông báo");
                dr.Cells["SoGio"].Value = soGio;
                PHANCONG_DTO pcUpdated = lstPhanCong.Single(item => item.MaNV == pcDTO.MaNV && item.MaDA == pcDTO.MaDA);
                pcUpdated.SoGio = soGio;
            }
            else
            {
                MessageBox.Show("Cập nhật phân công dự án thất bại", "Thông báo");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string searchStr = txtSearch.Text;
            lstPhanCongTimKiem = PHANCONG_BUL.TimKiemPhanCongTheoNhanVien(searchStr);
            if (lstPhanCongTimKiem == null || lstPhanCongTimKiem.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả");
                return;
            }
            dgvPhanCong.DataSource = typeof(List<PHANCONG_DTO>);
            dgvPhanCong.DataSource = lstPhanCongTimKiem;
            EditDataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvPhanCong.DataSource = typeof(List<PHANCONG_DTO>);
                dgvPhanCong.DataSource = lstPhanCong;
                EditDataGridView();
            }
        }
    }
}
