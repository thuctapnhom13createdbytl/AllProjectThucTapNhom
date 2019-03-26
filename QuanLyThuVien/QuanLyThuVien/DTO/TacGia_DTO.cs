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
        private string maTacGia;
        private string tenTacGia;
        private string diaChi;
        private string sdt;
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

        
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaTacGia { get => maTacGia; set => maTacGia = value; }
    }

}

