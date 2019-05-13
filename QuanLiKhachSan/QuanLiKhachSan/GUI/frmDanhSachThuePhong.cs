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
    public partial class frmDanhSachThuePhong : Office2007Form
    {
        public frmDanhSachThuePhong()
        {
            InitializeComponent();
        }
        private List<CHITIETPHIEUTHUE> listPhieuThuePhong;

        private void frmDanhSachThuePhong_Load(object sender, EventArgs e)
        {
            LoadPhieuThuePhong();
        }

        private void LoadPhieuThuePhong()
        {
            listPhieuThuePhong = ThuePhongDAO.Instance.LoadAllPhieuThuePhong();

            lvPhieuThue.Items.Clear();
            foreach (CHITIETPHIEUTHUE chiTiet in listPhieuThuePhong)
            {
                ListViewItem listViewItem = new ListViewItem(chiTiet.MaPhieuThue.ToString());
                listViewItem.SubItems.Add(chiTiet.PHIEUTHUEPHONG.KHACHHANG.TenKhachHang);
                listViewItem.SubItems.Add(chiTiet.PHIEUTHUEPHONG.NHANVIEN.TenNhanVien);
                listViewItem.SubItems.Add(chiTiet.PHONG.MaPhong.ToString());
                listViewItem.SubItems.Add(chiTiet.NgayThuePhong.Value.ToString());
                listViewItem.SubItems.Add(chiTiet.NgayTraPhong.Value.ToString());

                lvPhieuThue.Items.Add(listViewItem);
            }
        }

        private void tstbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
