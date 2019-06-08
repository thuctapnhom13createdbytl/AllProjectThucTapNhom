using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    public class CTPhieuXuat_DTO
    {
        public Nullable<int> Ma_CTPX { get; set; }
        public Nullable<int> Ma_PX { get; set; }
        public Nullable<int> Ma_Sanpham { get; set; }
        public string TenSanPham { get; set; }
        public int Soluong { get; set; }
        public decimal Dongia { get; set; }
        
        public CTPhieuXuat_DTO()
        {
            Ma_CTPX = null;
            Ma_PX = null;
            Ma_Sanpham = null;
            TenSanPham = "";
            Soluong = 0;
            Dongia = 0;
        }

        public CTPhieuXuat_DTO(DataRow dr)
        {
            Ma_CTPX = (int)dr["Ma_CTPX"];
            Ma_PX = (int)dr["Ma_PX"];
            Ma_Sanpham = (int)dr["Ma_Sanpham"];
            TenSanPham = dr["TenSanPham"].ToString();
            Soluong = (int)dr["Soluong"];
            Dongia = Convert.ToDecimal(dr["Dongia"]);
        }
    }
}
