using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHS.DTO
{
    public class Diem_DTO
    {   public int MaDiemMon { get; set; }
        public int MaMonHoc { get; set; }
        public int MaHocKy { get; set; }
        public int MaHocSinh { get; set; }
       // public string TenHocSinh { get; set; }
        public string TenMonHoc { get; set; }
        public string TenHocKy { get; set; }
        public double Diem15 { get; set; }
        public double DiemGiuaKy { get; set; }
        public double DiemThi { get; set; }
        public double TrungBinh { get; set; }


        public Diem_DTO()
        {
            this.MaMonHoc = 0;
            this.MaHocKy = 0;
            this.TrungBinh = 0;
            this.MaHocSinh = 0;
            //this.TenHocSinh = "";
            this.TenMonHoc = "";
            this.TenHocKy = "";
            this.Diem15 = 0;
            this.DiemGiuaKy = 0;
            this.DiemThi = 0;
        }

        public Diem_DTO(DataRow dr)
        {
            MaDiemMon = (int)dr["MaDiemMon"];
            MaMonHoc = (int)dr["MaMonHoc"];
            MaHocKy = (int)dr["MaHocKy"];
            TrungBinh = Convert.ToDouble(dr["TrungBinh"]);
            MaHocSinh = (int)dr["MaHocSinh"];
           // TenHocSinh = (string)dr["TenHocSinh"];
            TenMonHoc = (string)dr["TenMonHoc"];
            TenHocKy = (string)dr["TenHocKy"];
            Diem15 = Convert.ToDouble(dr["Diem15"]);
            DiemGiuaKy = Convert.ToDouble(dr["DiemGiuaKy"]);
            DiemThi = Convert.ToDouble(dr["DiemThi"]);
        }
    }
}
