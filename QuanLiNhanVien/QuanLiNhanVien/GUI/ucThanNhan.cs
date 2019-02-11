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
    public partial class ucThanNhan : UserControl
    {
        BindingSource listNV = new BindingSource();
        public ucThanNhan()
        {
            InitializeComponent();
            List<THANNHAN_DTO> listTN = THANNHAN_BUL.layTatCaThanNhan();
            List<NHANVIEN_DTO> listNV = THANNHAN_BUL.LoadComboBoxNV();
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "MaNV";
            dtgvThanNhan.DataSource = listTN;
            cbNhanVien.DataSource = listNV;
            bindingData();
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
            mtMaNV.DataBindings.Add(new Binding("Text", dtgvThanNhan.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
        }

        private void dtgvThanNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int index = e.RowIndex;
            //    DataGridViewRow dr = dtgvThanNhan.Rows[index];

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string a = cbGioiTinh.Text;
        }
    }
}
