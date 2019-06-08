using QuanLyKho.DAO;
using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.VIEW
{
    public partial class fDSPhieuNhap : MetroFramework.Forms.MetroForm
    {
        List<PhieuNhap_DTO> dsPhieuNhap = new List<PhieuNhap_DTO>();
        List<CTPhieuNhap_DTO> ctPhieuNhap = new List<CTPhieuNhap_DTO>();
        public fDSPhieuNhap()
        {
            InitializeComponent();
            load();
        }
        
        void load()
        {
            // dtgvDSPhieuNhap.DataSource = typeof(List<PhieuNhap_DTO>);
            dtgvDSPhieuNhap.DataSource = PhieuNhap_DAO.Instance.LayPhieuNhap();
        }

        private void dtgvDSPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maPN = Convert.ToInt32(dtgvDSPhieuNhap.CurrentRow.Cells["DS_MaPN"].Value);
            dtgvCTPhieuNhap.DataSource = CTPhieuNhap_DAO.Instance.LayPhieuNhapTheoMa(maPN);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            fThemPhieuNhap f = new fThemPhieuNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
            dtgvDSPhieuNhap.DataSource = PhieuNhap_DAO.Instance.LayPhieuNhap();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDSPhieuNhap.RowCount > 0)
                {
                    int maPN = Convert.ToInt32(dtgvDSPhieuNhap.CurrentRow.Cells["DS_MaPN"].Value);
                    fHoaDonNhap f = new fHoaDonNhap(maPN);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Không có phiếu nào");
                }

            }
            catch
            {
                return;
            }

        }
    }
}
