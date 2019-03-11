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
using DataAccessLayer;

namespace QuanLiNhanVien.GUI
{
    public partial class ucThanNhan : UserControl
    {
        BindingSource listNV = new BindingSource();
        List<THANNHAN_DTO> listTN = THANNHAN_BUL.layTatCaThanNhan();
        string TenTNUpdate;
        public ucThanNhan()
        {
            InitializeComponent();
            
            List<NHANVIEN_DTO> listNV = THANNHAN_BUL.LoadComboBoxNV();
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "MaNV";
            cbGioiTinh.Text = "Nam";
            dtgvThanNhan.DataSource = listTN;
            cbNhanVien.DataSource = listNV;
          //  bindingData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucThanNhan uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucThanNhan>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }
        public void layDanhSachNV()
        {

        }
        public void bindingData()
        {
            cbNhanVien.DataBindings.Add(new Binding("Text", dtgvThanNhan.DataSource, "tenNV", true, DataSourceUpdateMode.Never));
            tbQuanHe.DataBindings.Add(new Binding("Text", dtgvThanNhan.DataSource, "QuanHe", true, DataSourceUpdateMode.Never));
            tbTenTN.DataBindings.Add(new Binding("Text", dtgvThanNhan.DataSource, "TenTN", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dtgvThanNhan.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
           // mtMaNV.DataBindings.Add(new Binding("Text", dtgvThanNhan.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            dtpkNgaySinh.DataBindings.Add(new Binding("Text", dtgvThanNhan.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            this.TenTNUpdate = tbTenTN.Text;
        }

        private void dtgvThanNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvThanNhan.Rows[index];
                cbNhanVien.Text = dr.Cells["tenNV"].Value.ToString();
                tbTenTN.Text = dr.Cells["TenTN"].Value.ToString();
                cbGioiTinh.Text = dr.Cells["GioiTinh"].Value.ToString();
                tbQuanHe.Text = dr.Cells["QuanHe"].Value.ToString();
                dtpkNgaySinh.Value = dr.Cells["ngaysinhTN"].Value == null ? DateTime.Now : DateTime.Parse(dr.Cells["ngaysinhTN"].Value.ToString());
                this.TenTNUpdate = tbTenTN.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                THANNHAN_DTO tnDTO = new THANNHAN_DTO();
                tnDTO.MaNV = (int)cbNhanVien.SelectedValue;
                tnDTO.GioiTinh = cbGioiTinh.Text;
                tnDTO.NgaySinh = dtpkNgaySinh.Value;
                tnDTO.QuanHe = tbQuanHe.Text;
                tnDTO.tenNV = cbNhanVien.Text;
                tnDTO.TenTN = tbTenTN.Text;
                THANNHAN_BUL.themTN(tnDTO);
               dtgvThanNhan.DataSource = THANNHAN_BUL.layTatCaThanNhan();
                bindingData();
                MessageBox.Show("Thêm mới thành công");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetAll()
        {
            
            tbQuanHe.Text = "";
            tbTenTN.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thân nhân này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    THANNHAN_DTO tnDTO = new THANNHAN_DTO();
                    tnDTO.MaNV = (int)cbNhanVien.SelectedValue;
                    tnDTO.GioiTinh = cbGioiTinh.Text;
                    tnDTO.NgaySinh = dtpkNgaySinh.Value;
                    tnDTO.QuanHe = tbQuanHe.Text;
                    tnDTO.tenNV = cbNhanVien.Text;
                    tnDTO.TenTN = tbTenTN.Text;
                    var a = this.TenTNUpdate;
                    int capnhat = THANNHAN_BUL.CapNhapTN(tnDTO, this.TenTNUpdate);
                    if (capnhat > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    dtgvThanNhan.DataSource = THANNHAN_BUL.layTatCaThanNhan();
                    //   bindingData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dtgvThanNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sxóa thân nhân này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int xoa = THANNHAN_BUL.XoaTN(this.TenTNUpdate);
                    if (xoa > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    dtgvThanNhan.DataSource = THANNHAN_BUL.layTatCaThanNhan();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
   
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbNhanVien.Text = "Chưa có nhân viên";
            tbTenTN.Text = "";
            cbGioiTinh.Text = "Nam";
            tbQuanHe.Text = "";
            dtpkNgaySinh.Value = DateTime.Now;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List<THANNHAN_DTO> listTN = THANNHAN_BUL.TimKiemTN(txtSearch.Text);
            dtgvThanNhan.DataSource = listTN;
        }
    }
}
