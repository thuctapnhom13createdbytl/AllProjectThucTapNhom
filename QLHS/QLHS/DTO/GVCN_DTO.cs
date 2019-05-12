using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class GVCN_DTO
    {
        int MaLop { get; set; }
        int MaGiaoVien { get; set; }
        public GVCN_DTO()
        {
            MaLop = 0;
            MaGiaoVien = 0;
        }
        public GVCN_DTO(DataRow data)
        {
            MaLop = (int)(data["MaLop"]);
            MaGiaoVien = (int)(data["MaGiaoVien"]); ;
        }
    }
}
