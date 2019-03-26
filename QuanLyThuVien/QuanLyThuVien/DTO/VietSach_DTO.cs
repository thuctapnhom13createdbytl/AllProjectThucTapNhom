using System;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class VietSach_DTO
    {
        private string maDauSach;
        private string maTacGia;
        private int soTrang;
        private string vaiTro;
        public VietSach_DTO()
        {
            this.MaDauSach = "";
            this.MaTacGia = "";
            this.SoTrang = 0;
            this.VaiTro = "";
        }
        public VietSach_DTO(DataRow row)
        {
            this.MaDauSach = row["MaDauSach"].ToString();
            this.MaTacGia = row["MaTacGia"].ToString();
            this.SoTrang = (int)row["SoTrang"];
            this.VaiTro = row["VaiTro"].ToString();
        }

        public string MaDauSach { get => maDauSach; set => maDauSach = value; }
        public string MaTacGia { get => maTacGia; set => maTacGia = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }
        public string VaiTro { get => vaiTro; set => vaiTro = value; }
    }
}


