using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class HocKi_DTO
    {
        int MaHocKy { get; set; }
        string TenHocKy { get; set; }
        public HocKi_DTO()
        {
            MaHocKy = 0;
            TenHocKy = "";
        }
        public HocKi_DTO(DataRow data)
        {
            MaHocKy = (int)data["MaHocKy"];
            TenHocKy = data["TenHocKy"].ToString();
        }
    }
}
