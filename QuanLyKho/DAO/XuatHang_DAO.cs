using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.DTO;
using System.Data;

namespace QuanLyKho.DAO
{
    public class XuatHang_DAO
    {
        private static XuatHang_DAO instance;
        public static XuatHang_DAO Instance
        {
            get
            {
                if (instance == null) instance = new XuatHang_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<XuatHang_DTO> LoadDanhSachPhieuXuat()
        {
            try
            {
                List<XuatHang_DTO> listXuatHang = new List<XuatHang_DTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("LoadToanBoPhieuXuat");
                foreach (DataRow item in data.Rows)
                {
                    XuatHang_DTO xuatHang = new XuatHang_DTO(item);
                    listXuatHang.Add(xuatHang);
                }
                return listXuatHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemPhieuXuat(List<XuatHang_DTO> lstPhieuXuatMoi)
        {
            try
            {
                int ketQua = 0;
                foreach (XuatHang_DTO phieuXuat in lstPhieuXuatMoi)
                {
                    // Khách hàng mới
                    if (phieuXuat.KhachHang.Ma_KH == 0)
                    {
                        int kq = DataProvider.Instance.ExecuteNonQuery
                            ("ThemPhieuXuat_KHMoi @Ten_KH , @DiaChi_KH , @SDT_KH , @Email_KH , @Ma_Sanpham , @SoLuong , @DonGia , @Ma_NV",
                            new object[] { phieuXuat.KhachHang.Ten_KH, phieuXuat.KhachHang.DiaChi_KH, phieuXuat.KhachHang.SDT_KH, phieuXuat.KhachHang.Email_KH, phieuXuat.Ma_Sanpham, phieuXuat.SoLuong, phieuXuat.DonGia, phieuXuat.NhanVien.Ma_NV}
                            );
                        if (kq > 0) ketQua++;
                    }
                    else //Khách hàng cũ
                    {
                        int kq = DataProvider.Instance.ExecuteNonQuery
                            ("ThemPhieuXuat_KHCu @Ma_KH , @Ma_Sanpham , @SoLuong , @DonGia , @Ma_NV",
                            new object[] { phieuXuat.KhachHang.Ma_KH, phieuXuat.Ma_Sanpham, phieuXuat.SoLuong, phieuXuat.DonGia, phieuXuat.NhanVien.Ma_NV }
                            );
                        if (kq > 0) ketQua++;
                    }
                }
                return ketQua;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
