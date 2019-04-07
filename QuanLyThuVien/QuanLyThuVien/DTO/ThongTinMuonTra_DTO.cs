using System;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class ThongTinMuonTra_DTO
    {
        public ThongTinMuonTra_DTO()
        {
            this.SoPhieuMuon = "";
            this.MaCuonSach = "";
            this.TenDauSach = "";
            this.NgayTra = "";
            this.TinhTrangSach = 0;
            this.MaViPham = "";

        }
        public ThongTinMuonTra_DTO(DataRow row)
        {
            this.MaCuonSach = row["MaCuonSach"].ToString();
            this.SoPhieuMuon = row["SoPhieuMuon"].ToString();
            this.TenDauSach = row["TenDauSach"].ToString();
            this.NgayTra = row["NgayTra"].ToString() == "" ? "" : ((DateTime)row["NgayTra"]).ToString("dd-MM-yyyy");
            this.TinhTrangSach = (int)row["TinhTrangSach"];
            this.MaViPham = row["MaViPham"].ToString();
        }

        public string SoPhieuMuon { get; set; }
        public string MaCuonSach { get ; set ; }
        public string TenDauSach { get; set; }
        public string NgayTra { get ; set ; }
        public int TinhTrangSach { get ; set ; }
        public string MaViPham { get ; set ; }
    }

}


