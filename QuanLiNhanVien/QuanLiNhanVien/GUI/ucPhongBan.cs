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

        private void dgvNhanvien_CellClick( object sender, DataGridViewCellEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(true)
            {
                return;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
