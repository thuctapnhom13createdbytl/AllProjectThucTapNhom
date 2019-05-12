using QLHS.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }


        private void fHocSinh_Click(object sender, EventArgs e)
        {
            fHocSinh f = new fHocSinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            fGiaoVien f = new fGiaoVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fmain_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnThongTinGiangDay_Click(object sender, EventArgs e)
        {
            fQuanLyGiangDay f = new fQuanLyGiangDay();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
