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
        private string soPhieuMuon;
        private string ngayMuon;
        private string ngayHenTra;
        private string maNhanVien;
        private string maDocGia;
        public PhieuMuon_DTO()
        {
            this.SoPhieuMuon = "";
            this.NgayMuon = "";
            this.NgayHenTra = "";
            this.MaNhanVien = "";
            this.MaDocGia = "";
        }
        public PhieuMuon_DTO(DataRow row)
        {
            this.SoPhieuMuon = row["SoPhieuMuon"].ToString();
            this.NgayMuon = row["NgayMuon"].ToString();
            this.NgayHenTra = row["NgayHenTra"].ToString();
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.MaDocGia = row["MaDocGia"].ToString();
        }

        public string SoPhieuMuon { get ; set; }
        public string NgayMuon { get ; set ; }
        public string NgayHenTra { get; set ; }
        public string MaNhanVien { get; set; }
        public string MaDocGia { get; set; }
    }

}

