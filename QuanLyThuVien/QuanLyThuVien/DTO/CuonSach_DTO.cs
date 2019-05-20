using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThuVien.DTO
{
    public class CuonSach_DTO
    {
        public string MaCuonSach { get ; set; }
        public string TenDauSach { get; set; }
        public int TinhTrangSach { get; set; }
        public string MaDauSach { get; set ; }
        public string TenHienThi { get; set; }


        public CuonSach_DTO()
        {
            MaCuonSach = "";
            TinhTrangSach = 1;
            MaDauSach = "";
            TenDauSach = "";
            TenHienThi = "";
        }
        public CuonSach_DTO(string macuonsach, int tinhtrangsach, string madausach, string tendausach)
        {
            this.MaCuonSach = macuonsach;
            this.MaDauSach = madausach;
            this.TinhTrangSach = tinhtrangsach;
            this.TenDauSach = tendausach;
        }
        public CuonSach_DTO(DataRow row)
        {
            this.MaCuonSach = row["MaCuonSach"].ToString();
            this.MaDauSach = row["MaDauSach"].ToString();
            this.TinhTrangSach = (int)row["TinhTrangSach"];
            this.TenDauSach = row["TenDauSach"] != null ? row["TenDauSach"].ToString() : "";
            this.TenHienThi = TenDauSach + " - Mã cuốn sách: " + MaCuonSach;
        }

        
    }
}

