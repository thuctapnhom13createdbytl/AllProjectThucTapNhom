using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.VIEW
{
    public partial class fQuanLyGiangDay : Form
    {
        BindingSource DSLop = new BindingSource();
        int IDLopHoc;
        string TenLopHoc;
        public fQuanLyGiangDay()
        {
            InitializeComponent();
            IDLopHoc = 0;
            load();
        }
        void load()
        {

            dtgvLop.DataSource = DSLop;
            DSLop.DataSource = Lop_DAO.Instance.LayTatCaLop();
        }

        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvLop.Rows[index];
                txtLop.Text = dr.Cells["TenLop"].Value.ToString();
                txtKhoi.Text = dr.Cells["TenKhoi"].Value.ToString();
                txtSiSo.Text = dr.Cells["SiSo"].Value.ToString();
                txtTenGiaoVien.Text = dr.Cells["TenGVCN"].Value.ToString();
                this.IDLopHoc = Convert.ToInt32(dr.Cells["MaLop"].Value);
                TenLopHoc = dr.Cells["TenLop"].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnDanhSachLop_Click(object sender, EventArgs e)
        {
            if(IDLopHoc == 0)
            {
                MessageBox.Show("bạn phải chọn ít nhất 1 lớp");
                return;
            }
            fThongTinLopHoc f = new fThongTinLopHoc(IDLopHoc, TenLopHoc);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DSLop.DataSource = Lop_DAO.Instance.TimKiemLop(txtTimKiem.Text);
        }
    }
}
