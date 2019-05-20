using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyThuVien.DTO
{
    public class TacGia_DTO
    {
        public TacGia_DTO()
        {
            this.MaTacGia = "";
            this.TenTacGia = "";
            this.DiaChi = "";
            this.Sdt = "";
        }
        public TacGia_DTO(DataRow row)
        {
            this.MaTacGia = row["MaTacGia"].ToString();
            this.TenTacGia = row["TenTacGia"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }

        
        public string TenTacGia { get; set ; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string MaTacGia { get; set; }
    }

}

