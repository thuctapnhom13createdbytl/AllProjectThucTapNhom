using System;
using System.Data;

namespace QuanLyThuVien.DTO
{
    public class ViPham_DTO
    {
        private string maViPham;
        private string tenViPham;
        private string hinhThucPhat;
        public ViPham_DTO()
        {
            this.MaViPham = "";
            this.TenViPham = "";
            this.HinhThucPhat = "";
        }
        public ViPham_DTO(DataRow row)
        {
            this.MaViPham = row["MaViPham"].ToString();
            this.TenViPham = row["TenViPham"].ToString();
            this.HinhThucPhat = row["HinhThucPhat"].ToString();
        }

        public string MaViPham { get ; set ; }
        public string TenViPham { get ; set ; }
        public string HinhThucPhat { get ; set ; }
    }

}

