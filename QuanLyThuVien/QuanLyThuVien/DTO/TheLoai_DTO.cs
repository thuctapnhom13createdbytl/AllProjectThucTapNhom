using System;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class TheLoai_DTO
    {
        private string maTheLoai;
        private string tenTheLoai;
        public TheLoai_DTO()
        {
            this.MaTheLoai = "";
            this.TenTheLoai = "";
        }
        public TheLoai_DTO(DataRow row)
        {
            this.MaTheLoai = row["MaTheLoai"].ToString();
            this.TenTheLoai = row["TenTheLoai"].ToString();
        }

       
        public string TenTheLoai { get; set; }
        public string MaTheLoai { get; set; }
    }

}

