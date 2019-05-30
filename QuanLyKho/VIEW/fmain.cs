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
    public partial class fmain : MetroFramework.Forms.MetroForm
    {
        public fmain()
        {
            InitializeComponent();
        }

 

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            fSanPham f = new fSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnNhapSanPham_Click(object sender, EventArgs e)
        {
            fNhapHang f = new fNhapHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnXuatSanPham_Click(object sender, EventArgs e)
        {
            fXuatHang f = new fXuatHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
