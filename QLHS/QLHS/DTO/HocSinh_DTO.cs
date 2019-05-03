using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHS.DTO
{
    public class HocSinh_DTO
    {
        public int MaHocSinh_HS { get; set; }
        public int MaLop_HS { get; set; }
        public string TenHocSinh_HS { get; set; }
        public string GioiTinh_HS { get; set; }
        public Nullable<DateTime> NgaySinh_HS { get; set; }
        public string DiaChi_HS { get; set; }
        public string SDT_HS { get; set; }
        public string TonGiao_HS { get; set; }
        public string DanToc_HS { get; set; }
        public string TenCha_HS { get; set; }
        public string TenMe_HS { get; set; }

        //private Nullable<DateTime> NgaySinh_HS;

        public HocSinh_DTO()
        {
           this.MaHocSinh_HS = 0;
            this.MaLop_HS = 0;
            this.TenHocSinh_HS = "";
            this.GioiTinh_HS = "";
            this.NgaySinh_HS = null;
            this.DiaChi_HS = "";
            this.SDT_HS = "";
            this.TonGiao_HS = "";
            this.DanToc_HS = "";
            this.TenCha_HS = "";
            this.TenMe_HS = "";
        }

        public HocSinh_DTO(DataRow dr)
        {
            MaHocSinh_HS = (int)dr["MaHocSinh"];
            MaLop_HS = (int)dr["MaLop"];
            TenHocSinh_HS = (string)dr["TenHocSinh"];
            GioiTinh_HS = (DateTime)dr["GioiTinh"];
        }


    }
}
