using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QuanLiKhachSan.GUI
{
    public partial class frmMain : Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            switch (btn.Name)
            {
                case "btnHoSoNhanVien":
                    Common.frmNhanVien = new frmNhanVien();
                    Common.frmNhanVien.ShowDialog();
                    Common.frmNhanVien = null;
                    break;
                case "btnDichVu":
                    Common.frmDichVu = new frmDichVu();
                    Common.frmDichVu.ShowDialog();
                    Common.frmDichVu = null;
                    break;
                case "btnThietBi":
                    Common.frmThietBi = new frmThietBi();
                    Common.frmThietBi.ShowDialog();
                    Common.frmThietBi = null;
                    break;
                case "btnKhachHang":
                    Common.frmKhachHang = new frmKhachHang();
                    Common.frmKhachHang.ShowDialog();
                    Common.frmKhachHang = null;
                    break;
                case "btnDonViCungCap":
                    Common.frmDonViCungCap = new frmDonViCungCap();
                    Common.frmDonViCungCap.ShowDialog();
                    Common.frmDonViCungCap = null;
                    break;
                case "btnDanhSachPhong":
                    Common.frmPhong = new frmPhong();
                    Common.frmPhong.ShowDialog();
                    Common.frmPhong = null;
                    break;
                case "btnLoaiPhong":
                    Common.frmLoaiPhong = new frmLoaiPhong();
                    Common.frmLoaiPhong.ShowDialog();
                    Common.frmLoaiPhong = null;
                    break;
                case "btnThongTinThue":
                    Common.frmDanhSachThuePhong = new frmDanhSachThuePhong();
                    Common.frmDanhSachThuePhong.ShowDialog();
                    Common.frmDanhSachThuePhong = null;
                    break;
                case "btnHoaDon":
                    Common.frmDanhSachHoaDon = new frmDanhSachHoaDon();
                    Common.frmDanhSachHoaDon.ShowDialog();
                    Common.frmDanhSachHoaDon = null;
                    break;
                
            }
        }
    }
}
