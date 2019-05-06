using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHS.DTO
{
    public class GiaoVien_DTO
    {
        public int MaGiaoVien { get; set; }
        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public string TenGiaoVien { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public GiaoVien_DTO()
        {
            MaGiaoVien = 0;
            MaMonHoc = 0;
            TenGiaoVien = " ";
            SDT = " ";
            Email = " ";
            TenMonHoc = " ";
        }

        public GiaoVien_DTO (DataRow dr)
        {
            MaGiaoVien = (int)dr["MaGiaoVien"];
            MaMonHoc = (int)dr["MaMonHoc"];
            TenGiaoVien = dr["TenGiaoVien"].ToString();
            TenMonHoc = dr["TenMonHoc"].ToString();
            SDT = dr["SDT"].ToString();
            Email = dr["Email"].ToString();
        }
    }
}
