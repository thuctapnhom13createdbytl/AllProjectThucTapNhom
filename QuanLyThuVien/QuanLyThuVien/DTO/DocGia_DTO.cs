using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyThuVien.DTO
{
    public class DocGia_DTO
    {
        private string maDocGia;
        private string tenDocGia;
        private string diaChi;
        private string sdt;
        public DocGia_DTO()
        {
            this.MaDocGia = "";
            this.TenDocGia = "";
            this.DiaChi = "";
            this.Sdt = "";
        }
        public DocGia_DTO(string madocgia, string tendocgia, string diachi, string sdt)
        {
            this.MaDocGia = madocgia;
            this.TenDocGia = tendocgia;
            this.DiaChi = diachi;
            this.Sdt = sdt;
        }

        public DocGia_DTO(DataRow row)
        {
            this.MaDocGia = row["MaDocGia"].ToString();
            this.TenDocGia = row["TenDocGia"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }
      
        public string TenDocGia { get => tenDocGia; set => tenDocGia = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
    }

}
