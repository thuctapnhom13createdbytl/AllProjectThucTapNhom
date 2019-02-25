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
    public partial class ucPhongBan : UserControl
    {
        public ucPhongBan()
        {
            InitializeComponent();
        }
        List<PHONGBAN_DTO> lstPhongBan;
        List<PHONGBAN_DTO> lstPhongBan_TruongPhong;
        List<PHONGBAN_DTO> lstPhongBan_TimKiem;

        protected override void OnLoad(EventArgs e)
        {
            lstPhongBan = PHONGBAN_BUL.LoadTatCaPhongBan();
            lstPhongBan_TruongPhong = PHONGBAN_BUL.LoadComboBoxPhongBan();

            cboTruongPhong.DataSource = lstPhongBan_TruongPhong;
            cboTruongPhong.DisplayMember = "Ho";
            cboTruongPhong.ValueMember = "MaTP";

            dgvPhongBan.DataSource = typeof(List<PHONGBAN_DTO>);
            dgvPhongBan.DataSource = lstPhongBan;
            EditDataGridView();;

        }

        private void EditDataGridView()
        {
            dgvPhongBan.Columns["MaPB"].Visible = false;
            dgvPhongBan.Columns["TenPB"].HeaderText = "Tên Phòng Ban";
            dgvPhongBan.Columns["TenPB"].Width = 240;
            dgvPhongBan.Columns["TenTP"].HeaderText = "Tên Trưởng Phòng";
            dgvPhongBan.Columns["NgayNhanChuc"].HeaderText = "Ngày Nhận Chức";
            dgvPhongBan.Columns["NgayNhanChuc"].Width = 170;
            dgvPhongBan.Columns["MaTP"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucPhongBan uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucPhongBan>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

        private void dgvPhongBan_CellClick( object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvPhongBan.Rows[index];
                lblMaPB.Text = dr.Cells["MaPB"].Value == null ? "" : dr.Cells["MaPB"].Value.ToString();
                txtTenPhongBan.Text = dr.Cells["TenPB"].Value.ToString();
                cboTruongPhong.SelectedValue = dr.Cells["MaTP"].Value;
                dtpNgayNhanChuc.Value = dr.Cells["NgayNhanChuc"].Value == null ? DateTime.Now : DateTime.Parse(dr.Cells["NgayNhanChuc"].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
            lstPhongBan.Add(pbDTO);
            dgvPhongBan.DataSource = typeof(List<PHONGBAN_DTO>);
            dgvPhongBan.DataSource = lstPhongBan;
            dgvPhongBan.Rows[dgvPhongBan.Rows.Count - 1].Selected = true;
            ResetAll();
            EditDataGridView();
        }

        private void ResetAll()
        {
            lblMaPB.Text = "";
            txtTenPhongBan.Text = "";
            dtpNgayNhanChuc.Value = DateTime.Now;
            cboTruongPhong.SelectedValue = lstPhongBan[0];
        }

        //private int ValidateData(PHONGBAN_DTO pbDTO)
        //{
        //    var lstPBTrungMA = lstPhongBan.Where(item => item.MaPB == pbDTO.MaPB);
        //    int err = 0;
        //    if (lstPhongBan.Count != 0)
        //    {
        //        lblMaPB.BackColor = Color.Coral;
        //        err++;
        //    }
        //    if(pbDTO.TenPB == "")
        //    {
        //        txtTenPhongBan.BackColor = Color.Coral;
        //        err++;
        //    }
        //    return err;
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(dgvPhongBan.SelectedRows.Count == 0)
            {
                return;
            }
            TextBox txt = sender as TextBox;
            DataGridViewRow dr = dgvPhongBan.SelectedRows[0];
            dr.Cells[txt.Tag.ToString()].Value = txt.Text;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")

            {
                dgvPhongBan.DataSource = typeof(List<PHONGBAN_DTO>);
                dgvPhongBan.DataSource = lstPhongBan;
                EditDataGridView();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = txtSearch.Text;
            lstPhongBan_TimKiem = PHONGBAN_BUL.TimKiemPhongBan(searchStr);
            if(lstPhongBan_TimKiem == null || lstPhongBan_TimKiem.Count == 0)
            {
                MessageBox.Show("Không Tìm Thấy Kết Quả");
                return;
            }
            dgvPhongBan.DataSource = typeof(List<PHONGBAN_DTO>);
            dgvPhongBan.DataSource = lstPhongBan_TimKiem;
            EditDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvPhongBan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn Ít Nhất Một Phòng Ban", "Thông Báo");
                return;
            }

            int maPB = int.Parse(dgvPhongBan.SelectedRows[0].Cells["MaPB"].Value.ToString()); ;
            DialogResult result = MessageBox.Show("Chắc Chắn Muốn Xóa Phòng Ban?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                int kq = PHONGBAN_BUL.XoaPhongBan(maPB);
                if(kq > 0)
                {
                    MessageBox.Show("Xóa Phòng Ban Thành Công", "Thông báo");
                    PHONGBAN_DTO pbDTO = lstPhongBan.Single(item => item.MaPB == maPB);
                    lstPhongBan.Remove(pbDTO);
                    dgvPhongBan.DataSource = typeof(List<PHONGBAN_DTO>);
                    dgvPhongBan.DataSource = lstPhongBan;
                    EditDataGridView();
                }
                else
                {
                    MessageBox.Show("Xoá Phòng Ban Thất Bại", "Thông Báo");
                }
            }
        }

        //private void txt_TextChanged(object sender, EventArgs e)
        //{
        //    if(dgvPhongBan.SelectedRows.Count == 0)
        //    {
        //        return;
        //    }
        //    TextBox txt = sender as TextBox;
        //    DataGridViewRow dr = dgvPhongBan.SelectedRows[0];
        //    dr.Cells[txt.Tag.ToString()].Value = txt.Text;
        //}

        private void dtpNgayNhanChuc_ValueChanged(object sender, EventArgs e)
        {
            if(dgvPhongBan.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dr = dgvPhongBan.SelectedRows[0];
            dr.Cells["NgayNhanChuc"].Value = dtpNgayNhanChuc.Value.ToShortDateString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <lstPhongBan.Count; i++)
            {
                if(lstPhongBan[i].MaPB == null)
                {
                    lstPhongBan.Remove(lstPhongBan[i]);
                    i--;
                }
            }
            dgvPhongBan.DataSource = typeof(List<PHONGBAN_DTO>);
            dgvPhongBan.DataSource = lstPhongBan;
            EditDataGridView();
        }

        private void cboTruongPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroComboBox cbo = sender as MetroComboBox;
            if(dgvPhongBan.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dr = dgvPhongBan.SelectedRows[0];
            dr.Cells[cbo.Tag.ToString()].Value = cbo.Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
            pbDTO.MaPB = lblMaPB.Text == "" ? 0 : int.Parse(lblMaPB.Text);
            pbDTO.TenPB = txtTenPhongBan.Text;
            pbDTO.MaTP = (int)cboTruongPhong.SelectedValue;
            pbDTO.NgayNhanChuc = dtpNgayNhanChuc.Value;

            int kq = PHONGBAN_BUL.CapNhatPhongBan(pbDTO);
            if(kq > 0)
            {
                if(pbDTO.MaPB == 0)
                {
                    MessageBox.Show("Thêm Phòng Ban Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                }
            }
            else
            {
                if (pbDTO.MaPB == 0)
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
                }
            }
        }
    }
}
