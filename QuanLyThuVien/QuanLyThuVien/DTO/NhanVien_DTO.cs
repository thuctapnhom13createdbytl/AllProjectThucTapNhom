using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class NhanVien_DTO
{
        private string maNhanVien;
        private string hoTen;
        private string diaChi;
        private string sdt;
	public NhanVien_DTO()
	{
            this.MaNhanVien = "";
            this.HoTen = "";
            this.DiaChi = "";
            this.Sdt = "";
	}
        public NhanVien_DTO(string manhanvien,string hoten, string diachi, string sdt)
        {
            this.MaNhanVien = manhanvien;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.Sdt = sdt;
        }
        public NhanVien_DTO(DataRow row)
        {
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }

     
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }

}
