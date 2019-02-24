using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class NhanVien_DTO
    {
        public int Ma_NV { get; set; }
        public string Ten_NV { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<DateTime> Ngaysinh_NV { get; set; }
        public string SDT_NV { get; set; }
        public string Email_NV { get; set; }
        public string ThongTin { get; set; }

        public NhanVien_DTO()
        {
            Ma_NV = 0;
            Ten_NV = "";
            GioiTinh = "";
            Ngaysinh_NV = null;
            SDT_NV = "";
            Email_NV = "";
            ThongTin = "";
        }

        public NhanVien_DTO(DataRow dr)
        {
            Ma_NV = (int)dr["Ma_NV"];
            Ten_NV = (string)dr["Ten_NV"];
            GioiTinh = (string)dr["GioiTinh"];
            Ngaysinh_NV = (DateTime)dr["Ngaysinh_NV"];
            SDT_NV = (string)dr["SDT_NV"];
            Email_NV = (string)dr["Email_NV"];
            ThongTin = (string)dr["ThongTin"];
        }
    }
}
