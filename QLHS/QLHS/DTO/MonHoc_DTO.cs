using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHS.DTO
{
    public class MonHoc_DTO
    {
        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTiet { get; set; }

        public MonHoc_DTO()
        {
            MaMonHoc = 0;
            TenMonHoc = " ";
            SoTiet = 0;
        }

        public MonHoc_DTO(DataRow dr)
        {
            MaMonHoc = (int)dr["MaMonHoc"];
            TenMonHoc = (string)dr["TenMocHoc"];
            SoTiet = (int)dr["SoTiet"];
        }
    }
}
