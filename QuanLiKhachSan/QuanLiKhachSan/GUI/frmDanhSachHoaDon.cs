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
using QuanLiKhachSan.DTO;
using QuanLiKhachSan.DAO;

namespace QuanLiKhachSan.GUI
{
    public partial class frmDanhSachHoaDon : Office2007Form
    {
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }
        private List<HOADONTHUE> listHoaDonThuePhong;

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void LoadDanhSachHoaDon()
        {
            listHoaDonThuePhong = HoaDonDAO.Instance.LoadAllHoaDon();

            lvDanhSachHoaDon.Items.Clear();
            foreach (HOADONTHUE hoaDon in listHoaDonThuePhong)
            {
                ListViewItem listViewItem = new ListViewItem(hoaDon.MaHoaDon.ToString());
                listViewItem.SubItems.Add(hoaDon.MaPhieuThue.ToString());
                listViewItem.SubItems.Add(hoaDon.NgayLapHD.Value.ToString());
                listViewItem.SubItems.Add(hoaDon.HinhThucThanhToan);
                listViewItem.SubItems.Add(hoaDon.PhuThu.ToString());
                listViewItem.SubItems.Add(hoaDon.GiamGiaKH.ToString());
                listViewItem.SubItems.Add(hoaDon.TongTien.ToString());

                lvDanhSachHoaDon.Items.Add(listViewItem);
            }
        }

        private void tstbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
