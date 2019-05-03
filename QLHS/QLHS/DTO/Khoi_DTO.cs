using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHS.DTO
{
    public class Khoi_DTO
    {
        public int MaKhoi { get; set; }
        public string TenKhoi { get; set; }

        public Khoi_DTO()
        {
            this.MaKhoi = 0;
            this.TenKhoi = "";
        }

        public Khoi_DTO( DataRow dr)
        {
            MaKhoi =  (int)dr["MaKhoi"];
            TenKhoi = (string)dr["TenKhoi"];
        }
    }
}
