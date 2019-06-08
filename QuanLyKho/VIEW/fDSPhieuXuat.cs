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
    public partial class fDSPhieuXuat : MetroFramework.Forms.MetroForm
    {
        List<PhieuXuat_DTO> DSPX = new List<PhieuXuat_DTO>();
        public fDSPhieuXuat()
        {
            InitializeComponent();
            load();
        }
        
        void load()
        {
            dtgvDSPhieuXuat.DataSource = PhieuXuat_DAO.Instance.LayPhieuXuat();
        }

        private void dtgvDSPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                int MaPX = Convert.ToInt32(dtgvDSPhieuXuat.CurrentRow.Cells["DS_MaPX"].Value);
                dtgvCTPhieuXuat.DataSource = CTPhieuXuat_DAO.Instance.LayPhieuXuat(MaPX);
            }
            catch
            {
                return;
            }
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            fThemPhieuXuat f = new fThemPhieuXuat();
            this.Hide();
            f.ShowDialog();
            this.Show();
            dtgvDSPhieuXuat.DataSource = PhieuXuat_DAO.Instance.LayPhieuXuat();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtgvDSPhieuXuat.RowCount > 0)
                {
                    int MaPX = (int)dtgvDSPhieuXuat.CurrentRow.Cells["DS_MaPX"].Value;
                    fHoaDonXuat f = new fHoaDonXuat(MaPX);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Không có phiếu xuất nào");
                }

            }
            catch
            {
                return;
            }

        }
    }
}
