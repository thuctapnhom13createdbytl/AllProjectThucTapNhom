using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    public class PhieuNhap_DTO
    {
        public Nullable<int> Ma_PN { get; set; }
        public Nullable<int> Ma_NV { get; set; }
        public Nullable<int> Ma_NSX { get; set; }
        public DateTime Ngaynhap { get; set; }
        public string Ten_NV { get; set; }
        public string Ten_NSX { get; set; }
        public PhieuNhap_DTO(DataRow dr)
        {
            Ma_PN = Convert.ToInt32(dr["Ma_PN"]);
            Ma_NV = Convert.ToInt32(dr["Ma_NV"]);
            Ma_NSX = Convert.ToInt32(dr["Ma_NSX"]);
            Ngaynhap = Convert.ToDateTime(dr["Ngaynhap"]);
            Ten_NV = dr["Ten_NV"].ToString();
            Ten_NSX = dr["Ten_NSX"].ToString();
        }

        public PhieuNhap_DTO()
        {
            Ma_PN = null;
            Ma_NV = null;
            Ma_NSX = null;
            Ngaynhap = DateTime.Now;
            Ten_NV = "";
            Ten_NSX = "";
        }
    }
}
