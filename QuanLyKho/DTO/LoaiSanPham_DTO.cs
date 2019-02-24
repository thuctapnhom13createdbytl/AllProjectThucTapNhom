using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class LoaiSanPham_DTO
    {
        public int Ma_LoaiSP { get; set; }
        public string TenLoai { get; set; }
        public string GhiChu { get; set; }

        public LoaiSanPham_DTO ()
        {
            Ma_LoaiSP = 0;
            TenLoai = "";
            GhiChu = "";
        }

        public LoaiSanPham_DTO (DataRow dr)
        {
            Ma_LoaiSP = (int)dr["Ma_LoaiSP"];
            TenLoai = (string)dr["TenLoai"];
            GhiChu = (string)dr["GhiChu"];
        }
    }
}
