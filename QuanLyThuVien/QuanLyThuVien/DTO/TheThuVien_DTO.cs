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
        private Nullable<DateTime> ngayBatDau;
        private Nullable<DateTime> ngayKetThuc;
        private string maDocGia;
        public TheThuVien_DTO()
	    {
            this.SoThe = "";
            this.NgayBatDau = null;
            this.NgayKetThuc = null;
            this.MaDocGia = "";
	    }
        public TheThuVien_DTO(DataRow row)
        {
            this.SoThe = row["SoThe"].ToString();
            this.NgayBatDau =(DateTime)row["ngayBatDau"];
            this.NgayKetThuc = (DateTime)row["ngayKetThuc"];
            this.MaDocGia = row["TenDocGia"].ToString();
        }

    
        public Nullable<DateTime> NgayBatDau { get ; set ; }
        public Nullable<DateTime> NgayKetThuc { get ; set ; }
        public string MaDocGia { get ; set; }
        public string SoThe { get ; set ; }
    }
}

