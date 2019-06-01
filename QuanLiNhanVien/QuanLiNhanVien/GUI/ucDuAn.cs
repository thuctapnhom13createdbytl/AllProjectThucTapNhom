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
    public partial class ucDuAn : UserControl
    {
        public ucDuAn()
        {
            InitializeComponent();
        }
        List<PHONGBAN_DTO> lstPhongBan;
        List<DUAN_DTO> lstDuAn;
        List<DUAN_DTO> lstTimKiemDuAn;
        protected override void OnLoad(EventArgs e)
        {
            lstDuAn = DUAN_BUL.LoadTatCaDuAn();
            dtgvDuAn.DataSource = typeof(List<DUAN_DTO>);
            dtgvDuAn.DataSource = lstDuAn;
            //EditDataGridView();
            lstPhongBan = PHONGBAN_BUL.LoadTatCaPhongBan();
            coboPhongBan.DataSource = lstPhongBan;
            coboPhongBan.DisplayMember = "TenPB";
            coboPhongBan.ValueMember = "MaPB";
        }
        private void EditDataGridView()
        {
           // dtgvDuAn.Columns["MaDA"].Visible = false;
            //dtgvDuAn.Columns["MaDA"].HeaderText = "Mã Du An";
            //dtgvDuAn.Columns["MaDA"].Width = 240;
            //dtgvDuAn.Columns["TenDA"].HeaderText = "Ten Du An";
            //dtgvDuAn.Columns["TenDA"].Width = 240;
            //dtgvDuAn.Columns["DiaDiem"].HeaderText = "Dia Diem";
            //dtgvDuAn.Columns["DiaDiem"].Width = 190;
           // dtgvDuAn.Columns["MaPB"].Visible = false;
        }
    
        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucDuAn uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucDuAn>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvDuAn.Rows[index];
                lblMaDuAn.Text = dr.Cells["MaDA"].Value == null ? "" : dr.Cells["MaDA"].Value.ToString();
                txtTenDuAn.Text = dr.Cells["TenDA"].Value.ToString();
                txtDiaDiem.Text = dr.Cells["DiaDiem"].Value.ToString();
                coboPhongBan.SelectedValue = dr.Cells["MaPB"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txtTenDuAn_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DUAN_DTO daDTO = new DUAN_DTO();
            lstDuAn.Add(daDTO);
            dtgvDuAn.DataSource = typeof(List<DUAN_DTO>);
            dtgvDuAn.DataSource = lstDuAn;
            dtgvDuAn.Rows[dtgvDuAn.Rows.Count - 1].Selected = true;
            ResetAll();
            EditDataGridView();
        }
        private void ResetAll()
        {
            lblMaDuAn.Text = "";
            txtTenDuAn.Text = "";
            txtDiaDiem.Text = "";
            coboPhongBan.SelectedValue= "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DUAN_DTO daDTO = new DUAN_DTO();
            daDTO.MaDA = lblMaDuAn.Text == "" ? 0 : int.Parse(lblMaDuAn.Text);
            daDTO.TenDA = txtTenDuAn.Text;
            daDTO.DiaDiem = txtDiaDiem.Text;
            daDTO.MaPB = (int)coboPhongBan.SelectedValue;
            
            int kq = DUAN_BUL.CapNhatDuAn(daDTO);
            if (kq > 0)
            {
                if (daDTO.MaDA == 0)
                {
                    MessageBox.Show("Thêm mới dự án thành công", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Cập nhật dự án thành công", "Thông báo");
                }
            }
            else
            {
                if (daDTO.MaDA == 0)
                {
                    MessageBox.Show("Thêm mới dự án thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật dự án thất bại", "Thông báo");
                }
            }

            lstDuAn = DUAN_BUL.LoadTatCaDuAn();
            dtgvDuAn.DataSource = typeof(List<DUAN_DTO>);
            dtgvDuAn.DataSource = lstDuAn;
            EditDataGridView();
        }

        private void coboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
             PHONGBAN_BUL.LoadComboBoxPhongBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDuAn.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ít nhất một dự án để xóa", "Thông báo");
                return;
            }

            int maDA = int.Parse(dtgvDuAn.SelectedRows[0].Cells["MaDA"].Value.ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dự án này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int kq = DUAN_BUL.XoaDuAn(maDA);
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa dự án thành công", "Thông báo");
                   DUAN_DTO daDTO= lstDuAn.Single(item => item.MaDA == maDA);
                    lstDuAn.Remove(daDTO);
                    dtgvDuAn.DataSource = typeof(List<DUAN_DTO>);
                    dtgvDuAn.DataSource = lstDuAn;
                    EditDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa dự án thất bại", "Thông báo");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                dtgvDuAn.DataSource = typeof(List<DUAN_DTO>);
                dtgvDuAn.DataSource = lstDuAn;
                EditDataGridView();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string searchStr = txtSearch.Text;
            lstTimKiemDuAn = DUAN_BUL.TimKiemDuAn(searchStr);
            if (lstTimKiemDuAn == null || lstTimKiemDuAn.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả");
                return;
            }
            dtgvDuAn.DataSource = typeof(List<DUAN_DTO>);
            dtgvDuAn.DataSource = lstTimKiemDuAn;
            EditDataGridView();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstDuAn.Count; i++)
            {
                if (lstDuAn[i].MaDA == null || lstDuAn[i].MaDA == 0)
                {
                    lstDuAn.Remove(lstDuAn[i]);
                    i--;
                }
            }
            dtgvDuAn.DataSource = typeof(List<DUAN_DTO>);
            dtgvDuAn.DataSource = lstDuAn;
            EditDataGridView();
        }
    }
}
