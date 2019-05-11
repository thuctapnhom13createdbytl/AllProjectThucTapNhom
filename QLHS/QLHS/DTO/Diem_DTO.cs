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
        public double TrungBinh { get; set; }
        public int MaHocSinh { get; set; }
        public Double Diem15 { get; set; }
        public Double DiemGiuaKy { get; set; }
        public Double DiemThi { get; set; }
        public string TenMonHoc { get; set; }
        public string TenHocKy { get; set; }
        public string TenHocSinh { get; set; }

        public Diem_DTO()
        {
            this.MaMonHoc = 0;
            this.MaHocKy = 0;
            this.TrungBinh = 0;
            this.MaHocSinh = 0;
            this.Diem15 = 0;
            this.DiemGiuaKy = 0;
            this.DiemThi = 0;
            this.TenHocKy = "";
            this.TenMonHoc = "";
            this.TenHocKy = "";
        }

        public Diem_DTO(DataRow dr)
        {
            MaDiemMon = (int)dr["MaDiemMon"];
            MaMonHoc = (int)dr["MaMonHoc"];
            MaHocKy = (int)dr["MaHocKy"];
            TrungBinh = (double)dr["TrungBinh"];
            MaHocSinh = (int)dr["MaHocSinh"];
            Diem15 = (Double)dr["Diem15"];
            DiemGiuaKy = (Double)dr["DiemGiuaKy"];
            DiemThi = (Double)dr["DiemThi"];
            TenMonHoc = (string)dr["TenMonHoc"];
            TenHocKy = (string)dr["TenHocKy"];
            TenHocSinh = (string)dr["TenHocSinh"];
        }
    }
}
