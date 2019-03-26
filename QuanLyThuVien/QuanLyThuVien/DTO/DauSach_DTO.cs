using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyThuVien.DTO
{
    public class DauSach_DTO
    {
        private string maDauSach;
        private string tenDauSach;
        private string maTheLoai;
        private string maNXB;

        public string MaDauSach { get => maDauSach; set => maDauSach = value; }
        public string TenDauSach { get => tenDauSach; set => tenDauSach = value; }
        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }

        public DauSach_DTO()
        {
            MaDauSach = "";
            TenDauSach = "";
            MaTheLoai = "";
            MaNXB = "";
        }
        public DauSach_DTO(string madausach, string tendausach, string matheloai, string manxb)
        {
            this.MaDauSach = madausach;
            this.TenDauSach = tendausach;
            this.MaTheLoai = matheloai;
            this.MaNXB = manxb;
        }
        public DauSach_DTO(DataRow row)
        {
            this.MaDauSach = row["MaDauSach"].ToString();
            this.TenDauSach = row["TenDauSach"].ToString();
            this.MaTheLoai = row["MaTheLoai"].ToString();
            this.MaNXB = row["MaNXB"].ToString();

        }

    }

}

