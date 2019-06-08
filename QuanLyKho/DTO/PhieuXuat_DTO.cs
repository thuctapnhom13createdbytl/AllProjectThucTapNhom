using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    public class PhieuXuat_DTO
    {
        public Nullable<int> Ma_PX { get; set; }
        public Nullable<int> Ma_NV { get; set; }
        public string Ten_NV { get; set; }
        public Nullable<int> Ma_KH { get; set; }
        public string Ten_KH { get; set; }
        public DateTime Ngayxuat { get; set; }

        public PhieuXuat_DTO()
        {
            Ma_PX = null;
            Ma_NV = null;
            Ma_KH = null;
            Ten_KH = "";
            Ten_NV = "";
            Ngayxuat = DateTime.Now;
        }

        public PhieuXuat_DTO(DataRow dr)
        {
            Ma_PX = (int)dr["Ma_PX"];
            Ma_NV = (int)dr["Ma_NV"];
            Ma_KH = (int)dr["Ma_KH"];
            Ten_KH = dr["Ten_KH"].ToString();
            Ten_NV = dr["Ten_NV"].ToString();
            Ngayxuat = Convert.ToDateTime(dr["Ngayxuat"]);
        }
    }
}
