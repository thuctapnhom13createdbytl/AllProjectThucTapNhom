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
        private string soThe;
        private string ngayBatDau;
        private string ngayKetThuc;
        private string maDocGia;
        public TheThuVien_DTO()
	    {
            this.SoThe = "";
            this.NgayBatDau = "";
            this.NgayKetThuc = "";
            this.MaDocGia = "";
	    }
        public TheThuVien_DTO(DataRow row)
        {
            this.SoThe = row["SoThe"].ToString();
            this.NgayBatDau =row["NgayBatDau"].ToString();
            this.NgayKetThuc = row["NgayKetThuc"].ToString();
            this.MaDocGia = row["MaDocGia"].ToString();
        }

    
        public string NgayBatDau { get ; set ; }
        public string NgayKetThuc { get ; set ; }
        public string MaDocGia { get ; set; }
        public string SoThe { get ; set ; }
    }
}

