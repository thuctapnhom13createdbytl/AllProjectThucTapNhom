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

        public int MaHocSinh { get; set; }
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public string TenHocSinh { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string TonGiao { get; set; }
        public string DanToc { get; set; }
        public string TenCha { get; set; }
        public string TenMe { get; set; }

        //private Nullable<DateTime> NgaySinh_HS;

        public HocSinh_DTO()
        {
           this.MaHocSinh = 0;
            this.MaLop = 0;
            this.TenLop = "";
            this.TenHocSinh = "";
            this.GioiTinh = "";
            this.NgaySinh = null;
            this.DiaChi = "";
            this.SDT = "";
            this.TonGiao = "";
            this.DanToc = "";
            this.TenCha = "";
            this.TenMe = "";
        }

        public HocSinh_DTO(DataRow dr)
        {
            MaHocSinh = (int)dr["MaHocSinh"];
            MaLop = (int)dr["MaLop"];
            TenLop = dr["TenLop"].ToString();
            TenHocSinh = dr["TenHocSinh"].ToString();
            NgaySinh =(DateTime)dr["NgaySinh"];
            GioiTinh = dr["GioiTinh"].ToString();
            DiaChi = dr["DiaChi"].ToString();
            SDT = dr["SDT"].ToString();
            TonGiao = dr["TonGiao"].ToString();
            DanToc = dr["DanToc"].ToString();
            TenCha = dr["TenCha"].ToString();
            TenMe = dr["TenMe"].ToString();
        }


    }
}
