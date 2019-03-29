using System;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class ThongTinMuonTra_DTO
    {
        private string maCuonSach;
        private string soPhieuMuon;
        private string ngayTra;
        private int tinhTrangSach;
        private string maViPham;
        public ThongTinMuonTra_DTO()
        {
            this.MaCuonSach = "";
            this.SoPhieuMuon = "";
            this.NgayTra = "";
            this.TinhTrangSach = 0;
            this.MaViPham = "";
        }
        public ThongTinMuonTra_DTO(DataRow row)
        {
            this.MaCuonSach = row["MaCuonSach"].ToString();
            this.SoPhieuMuon = row["SoPhieuMuon"].ToString();
            this.NgayTra = row["NgayTra"].ToString();
            this.TinhTrangSach = (int)row["TinhTrangSach"];
            this.MaViPham = row["MaViPham"].ToString();
        }

        public string MaCuonSach { get ; set ; }
        public string SoPhieuMuon { get ; set; }
        public string NgayTra { get ; set ; }
        public int TinhTrangSach { get ; set ; }
        public string MaViPham { get ; set ; }
    }

}


