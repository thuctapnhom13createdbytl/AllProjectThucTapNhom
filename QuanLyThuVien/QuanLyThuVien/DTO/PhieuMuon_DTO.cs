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

        public string SoPhieuMuon { get => soPhieuMuon; set => soPhieuMuon = value; }
        public string NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public string NgayHenTra { get => ngayHenTra; set => ngayHenTra = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
    }

}

