using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyThuVien.DTO
{
    public class NhaXuatBan_DTO
    {

        public NhaXuatBan_DTO()
        {
            this.MaNXB = "";
            this.TenNXB = "";
            this.DiaChi = "";
        }
        public NhaXuatBan_DTO(string manxb, string tennxb, string diachi)
        {
            this.MaNXB = manxb;
            this.TenNXB = tennxb;
            this.DiaChi = diachi;
        }
        public NhaXuatBan_DTO(DataRow row)
        {
            this.MaNXB = row["MaNXB"].ToString();
            this.TenNXB = row["TenNXB"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }

        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public string MaNXB { get; set; }
    }

}

