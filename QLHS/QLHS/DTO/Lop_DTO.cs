using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHS.DTO
{
    public class Lop_DTO
    {
        //public Khoi_DTO Khoi { get; set; }
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public int MaKhoi { get; set; }
        public string TenKhoi { get; set; }
        //public int MaGVCN { get; set; }
        public string TenGVCN { get; set; } 

        public Lop_DTO()
        {
            //Khoi = new Khoi_DTO();
            MaLop = 0;
            TenLop = "";
            SiSo = 0;
            MaKhoi = 0;
            TenKhoi = "";
           // MaGVCN = 0;
            TenGVCN = "";
        }

        public Lop_DTO(DataRow dr)
        {
           // Khoi = new Khoi_DTO(dr);
            MaLop = (int)dr["MaLop"];
            TenLop = dr["TenLop"].ToString();
            SiSo = (int)dr["SiSo"];
            MaKhoi = (int)dr["MaKhoi"];
            TenKhoi = dr["TenKhoi"].ToString();
            //MaGVCN = dr["MaGiaoVien"];
            TenGVCN = dr["TenGiaoVien"].ToString();
        }
    }
}
