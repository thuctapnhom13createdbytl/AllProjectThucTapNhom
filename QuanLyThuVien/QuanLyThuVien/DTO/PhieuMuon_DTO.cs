using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class PhieuMuon_DTO
    {
        public PhieuMuon_DTO()
        {
            this.SoPhieuMuon = "";
            this.NgayMuon = DateTime.Now;
            this.NgayHenTra = DateTime.Now;
            this.MaNhanVien = "";
            this.MaDocGia = "";
            this.TenNhanVien = "";
            this.TenDocGia = "";
        }
        public PhieuMuon_DTO(DataRow row)
        {
            this.SoPhieuMuon = row["SoPhieuMuon"].ToString();
            this.NgayMuon = (DateTime)row["NgayMuon"];
            this.NgayHenTra = (DateTime)row["NgayHenTra"];
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.MaDocGia = row["MaDocGia"].ToString();
            this.TenDocGia = row["TenDocGia"].ToString();
            this.TenNhanVien = row["TenNhanVien"].ToString();
        }

        public string SoPhieuMuon { get ; set; }
        public DateTime NgayMuon { get ; set ; }
        public DateTime NgayHenTra { get; set ; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }

    }

}

