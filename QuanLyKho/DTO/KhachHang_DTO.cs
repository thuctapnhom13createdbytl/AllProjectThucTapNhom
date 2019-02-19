using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class KhachHang_DTO
    {
        public class SanPham_DTO
        {
            private int maKH;
            private string tenKH;
            private string diaChiKH;
            private int sdtKH;
            private string emailKH;

            public int MaKH { get => maKH; set => maKH = value; }
            public string TenKH { get => tenKH; set => tenKH = value; }
            public string DiaChiKH { get => diaChiKH; set => diaChiKH = value; }
            public int SdtKH { get => sdtKH; set => sdtKH = value; }
            public string EmailKH { get => emailKH; set => emailKH = value; }

            public SanPham_DTO(int MaKH, string TenKH, String DiaChiKH, int SdtKH, string EmailKH)
            {
                this.MaKH = MaKH;
                this.TenKH = TenKH;
                this.DiaChiKH = DiaChiKH;
                this.SdtKH = SdtKH;
                this.EmailKH = EmailKH;
            }

            public SanPham_DTO(DataRow row)
            {
                this.MaKH = (int)row["Ma_KH"];
                this.TenKH = row["Ten_KH"].ToString();
                this.DiaChiKH = row["DiaChi_KH"].ToString();
                this.SdtKH = (int)row["SDT_KH"];
                this.EmailKH = row["Email_kH"].ToString();
            }

           
        }
    }
}
