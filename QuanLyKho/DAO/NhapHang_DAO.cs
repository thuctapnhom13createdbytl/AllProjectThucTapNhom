using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.DTO;
using System.Data;

namespace QuanLyKho.DAO
{
    public class NhapHang_DAO
    {
        private static NhapHang_DAO instance;
        public static NhapHang_DAO Instance
        {
            get
            {
                if (instance == null) instance = new NhapHang_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<NhapHang_DTO> LoadDanhSachPhieuNhap()
        {
            try
            {
                List<NhapHang_DTO> listNhapHang = new List<NhapHang_DTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("LoadToanBoPhieuNhap");
                foreach (DataRow item in data.Rows)
                {
                    NhapHang_DTO nhapHang = new NhapHang_DTO(item);
                    listNhapHang.Add(nhapHang);
                }
                return listNhapHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemPhieuNhap(List<NhapHang_DTO> lstPhieuNhapMoi)
        {
            try
            {
                int ketQua = 0;
                //List<NhapHang_DTO> lstPhieuNhapSPMoi = lstPhieuNhapMoi.Where(item => item.Ma_SanPham == 0).ToList();
                //List<NhapHang_DTO> lstPhieuNhapSPCu = lstPhieuNhapMoi.Where(item => item.Ma_SanPham != 0).ToList();
                foreach(NhapHang_DTO phieuNhap in lstPhieuNhapMoi)
                {
                    // Sản phẩm mới
                    if (phieuNhap.Ma_SanPham == 0)
                    {
                        int kq = DataProvider.Instance.ExecuteNonQuery
                            ("ThemPhieuNhap_SPMoi @TenSanPham , @Ma_NSX , @Ma_LoaiSP , @SoLuong , @DonGia , @Ma_NV",
                            new object[] { phieuNhap.TenSanPham, phieuNhap.Ma_NSX, phieuNhap.Ma_LoaiSP, phieuNhap.SoLuong, phieuNhap.DonGia, phieuNhap.Ma_NV }
                            );
                        if (kq > 0) ketQua++;
                    }
                    else //Sản phẩm cũ
                    {
                        int kq = DataProvider.Instance.ExecuteNonQuery
                            ("ThemPhieuNhap_SPCu @Ma_NSX , @Ma_Sanpham , @SoLuong , @DonGia , @Ma_NV",
                            new object[] { phieuNhap.Ma_NSX, phieuNhap.Ma_SanPham, phieuNhap.SoLuong, phieuNhap.DonGia, phieuNhap.Ma_NV }
                            );
                        if (kq > 0) ketQua++;
                    }
                }
                return ketQua;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
