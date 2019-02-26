using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class LoaiSanPham_DTO
    {
        private int maLSP;
        private string tenLSP;
        private string ghiChu;

        public LoaiSanPham_DTO()
        {
            maLSP = 0;
            tenLSP = "";
            ghiChu = "";
        }
        public LoaiSanPham_DTO(int malsp, string tenlsp, string ghichu)
        {
            this.GhiChu = ghichu;
            this.MaLSP = malsp;
            this.TenLSP = tenlsp;
        }
        public LoaiSanPham_DTO(DataRow row)
        {
            this.GhiChu = row["GhiChu"].ToString();
            this.MaLSP = (int)row["Ma_LoaiSP"];
            this.TenLSP = row["TenLoai"].ToString();
        }
        public int MaLSP
        {
            get
            {
                return maLSP;
            }

            set
            {
                maLSP = value;
            }
        }

        public string TenLSP
        {
            get
            {
                return tenLSP;
            }

            set
            {
                tenLSP = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }
    }
}
