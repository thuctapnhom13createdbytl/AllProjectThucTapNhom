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
        private string maCuonSach;
        private int tinhTrangSach;
        private string maDauSach;

        public string MaCuonSach { get ; set; }
        public int TinhTrangSach { get; set; }
        public string MaDauSach { get; set ; }

        public CuonSach_DTO()
        {
            MaCuonSach = "";
            TinhTrangSach = 0;
            MaDauSach = "";
        }
        public CuonSach_DTO(string macuonsach, int tinhtrangsach, string madausach)
        {
            this.MaCuonSach = macuonsach;
            this.MaDauSach = madausach;
            this.TinhTrangSach = tinhtrangsach;
        }
        public CuonSach_DTO(DataRow row)
        {
            this.MaCuonSach = row["MaCuonSach"].ToString();
            this.MaDauSach = row["MaDauSach"].ToString();
            this.TinhTrangSach = (int)row["TinhTrangSach"];
        }

        
    }
}

