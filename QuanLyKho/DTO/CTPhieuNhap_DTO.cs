using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    public class CTPhieuNhap_DTO
    {
        public Nullable<int> Ma_CTPN { get; set; }
        public Nullable<int> Ma_PN { get; set; }
        public Nullable<int> Ma_Sanpham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public string TenSanPham { get; set; }

        public CTPhieuNhap_DTO()
        {
            Ma_CTPN = null;
            Ma_PN = null;
            Ma_Sanpham = null;
            SoLuong = 0;
            DonGia = 0;
            TenSanPham = "";
        }

        public CTPhieuNhap_DTO(DataRow dr)
        {
            Ma_CTPN = Convert.ToInt32(dr["Ma_CTPN"]);
            Ma_PN = Convert.ToInt32(dr["Ma_PN"]);
            Ma_Sanpham = Convert.ToInt32(dr["Ma_Sanpham"]);
            SoLuong = Convert.ToInt32(dr["SoLuong"]);
            DonGia = Convert.ToDecimal(dr["DonGia"]);
            TenSanPham = dr["TenSanPham"].ToString();
        }

    }
}
