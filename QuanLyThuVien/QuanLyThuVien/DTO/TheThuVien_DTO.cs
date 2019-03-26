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
        private int maDocGia;
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

    
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int MaDocGia { get => maDocGia; set => maDocGia = value; }
        public string SoThe { get => soThe; set => soThe = value; }
    }
}

