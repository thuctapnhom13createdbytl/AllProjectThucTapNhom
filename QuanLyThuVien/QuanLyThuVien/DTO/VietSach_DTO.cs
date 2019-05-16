using System;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class VietSach_DTO
    {
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

        public string MaDauSach { get ; set ; }
        public string MaTacGia { get ; set ; }
        public int SoTrang { get ; set ; }
        public string VaiTro { get ; set ; }
    }
}


