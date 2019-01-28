using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class NHANVIEN_DTO
    {
        public Nullable<int> MaNV { get; set; }
        public string Hoten { get; set; }
        public Nullable<DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<decimal> Luong { get; set; }
        public Nullable<int> MaPB { get; set; }
        public Nullable<int> MaNGS { get; set; }
        public string TenPB { get; set; }
        public string TenNGS { get; set; }

        public NHANVIEN_DTO()
        {
            MaNV = null;
            Hoten = "";
            DiaChi = "";
            GioiTinh = "";
            Luong = null;
            MaPB = null;
            TenPB = "";
            TenNGS = "";
            MaNGS = null;
            NgaySinh = null;
        }
    }
}
