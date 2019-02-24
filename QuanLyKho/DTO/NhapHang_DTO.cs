using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class NhapHang_DTO
    {
        public int Ma_CTPN { get; set; }
        public Nullable<int> Ma_PN { get; set; }
        public Nullable<int> Ma_SanPham { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> Ma_LoaiSP { get; set; }
        public string TenLoai { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> Ma_NSX { get; set; }
        public string Ten_NSX { get; set; }
        public Nullable<int> Ma_NV { get; set; }
        public string Ten_NV { get; set; }


        public NhapHang_DTO (DataRow dr)
        {
            Ma_CTPN = (int)dr["Ma_CTPN"];
            Ma_PN = (int)dr["Ma_PN"];
            Ma_SanPham = (int)dr["Ma_SanPham"];
            SoLuong = (int)dr["SoLuong"];
            DonGia = (int)dr["DonGia"];
            Ma_NSX = (int)dr["Ma_NSX"];
            Ma_LoaiSP = (int)dr["Ma_LoaiSP"];
            TenSanPham = (string)dr["TenSanPham"];
            Ten_NSX = (string)dr["Ten_NSX"];
            Ma_NV = (int)dr["Ma_NV"];
            Ten_NV = (string)dr["Ten_NV"];
            TenLoai = (string)dr["TenLoai"];

        }

        public NhapHang_DTO ()
        {
            Ma_CTPN = 0;
            Ma_PN = null;
            Ma_SanPham = null;
            SoLuong = null;
            DonGia = null;
            Ma_NSX = null;
            Ma_LoaiSP = null;
            TenSanPham = "";
            Ten_NSX = "";
            Ma_NV = null;
            Ten_NV = "";
            TenLoai = "";
        }
    }
}
