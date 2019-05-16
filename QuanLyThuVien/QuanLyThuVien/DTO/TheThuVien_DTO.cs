using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class TheThuVien_DTO
    {
        public TheThuVien_DTO()
	    {
            this.SoThe = "";
            this.NgayBatDau = "";
            this.NgayKetThuc = "";
            this.MaDocGia = 0;
	    }
        public TheThuVien_DTO(DataRow row)
        {
            this.SoThe = row["SoThe"].ToString();
            this.NgayBatDau =row["NgayBatDau"].ToString();
            this.NgayKetThuc = row["NgayKetThuc"].ToString();
            this.MaDocGia = (int)row["MaDocGia"];
        }

    
        public string NgayBatDau { get ; set ; }
        public string NgayKetThuc { get ; set ; }
        public int MaDocGia { get ; set; }
        public string SoThe { get ; set ; }
    }
}

