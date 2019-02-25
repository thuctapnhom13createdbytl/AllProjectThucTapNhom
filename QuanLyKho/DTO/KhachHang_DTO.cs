using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class KhachHang_DTO
    {
        public int Ma_KH { get; set; }
        public string Ten_KH { get; set; }
        public string DiaChi_KH { get; set; }
        public string SDT_KH { get; set; }
        public string Email_KH { get; set; }

        public KhachHang_DTO()
        {
            Ma_KH = 0;
            Ten_KH = "";
            DiaChi_KH = "";
            SDT_KH = "";
            Email_KH = "";
        }

        public KhachHang_DTO(DataRow dr)
        {
            Ma_KH = (int)dr["Ma_KH"];
            Ten_KH = (string)dr["Ten_KH"];
            DiaChi_KH = (string)dr["DiaChi_KH"];
            SDT_KH = (string)dr["SDT_KH"];
            Email_KH = (string)dr["Email_KH"];
        }
    }
}
