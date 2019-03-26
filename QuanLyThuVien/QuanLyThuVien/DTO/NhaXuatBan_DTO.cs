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
        private string maNXB;
        private string tenNXB;
        private string diaChi;
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
        
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }
    }

}

