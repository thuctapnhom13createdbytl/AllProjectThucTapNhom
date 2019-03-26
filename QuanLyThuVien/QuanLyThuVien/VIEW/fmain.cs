using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.VIEW
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            fSach f = new fSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            fDocGia f = new fDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSachMuon_Click(object sender, EventArgs e)
        {
            fThongTinSach f = new fThongTinSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
