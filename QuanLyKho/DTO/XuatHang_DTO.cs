using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class XuatHang_DTO
    {
        public KhachHang_DTO KhachHang { get; set; }
        public LoaiSanPham_DTO LoaiSanPham { get; set; }
        public NhanVien_DTO NhanVien { get; set; }
        public NhaSanXuat_DTO NhaSanXuat { get; set; }
        public int Ma_CTPX { get; set; }
        public Nullable<int> Ma_PX { get; set; }
        public string TenKH { get; set; }
        public Nullable<int> Ma_Sanpham { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> DonGia { get; set; }
        public string TenNV { get; set; }

        public XuatHang_DTO()
        {
            KhachHang = new KhachHang_DTO();
            LoaiSanPham = new LoaiSanPham_DTO();
            NhanVien = new NhanVien_DTO();
            NhaSanXuat = new NhaSanXuat_DTO();
            Ma_CTPX = 0;
            Ma_PX = null;
            Ma_Sanpham = null;
            TenSanPham = "";
            SoLuong = null;
            DonGia = null;
            TenKH = "";
            TenNV = "";
        }

        public XuatHang_DTO(DataRow dr)
        {
            KhachHang = new KhachHang_DTO(dr);
            LoaiSanPham = new LoaiSanPham_DTO(dr);
            NhanVien = new NhanVien_DTO(dr);
            NhaSanXuat = new NhaSanXuat_DTO(dr);
            Ma_CTPX = (int)dr["Ma_CTPX"];
            Ma_PX = (int)dr["Ma_PX"];
            Ma_Sanpham = (int)dr["Ma_Sanpham"];
            SoLuong = (int)dr["SoLuong"];
            DonGia = (int)dr["DonGia"];
            TenSanPham = (string)dr["TenSanPham"];
            TenKH = KhachHang.Ten_KH;
            TenNV = NhanVien.Ten_NV;
        }
    }
}
