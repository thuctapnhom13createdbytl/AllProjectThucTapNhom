using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class NhaSanXuat_DTO
    {
        private int maNSX;
        private string tenNSX, diaChiNSX, sdtNSX, websiteNSX;

        public NhaSanXuat_DTO()
        {
            maNSX = 0;
            tenNSX = diaChiNSX = sdtNSX = websiteNSX = "";
        }

        public NhaSanXuat_DTO(int mansx, string tennsx, string diachi, string sdt, string web)
        {
            this.MaNSX = mansx;
            this.TenNSX = tennsx;
            this.DiaChiNSX = diachi;
            this.SdtNSX = sdt;
            this.WebsiteNSX = web;
        }
        public NhaSanXuat_DTO(DataRow row)
        {
            this.MaNSX = (int)row["Ma_NSX"];
            this.TenNSX = row["ten_NSX"].ToString();
            this.DiaChiNSX = row["DiaChi_NSX"].ToString();
            this.SdtNSX = row["SDT_NSX"].ToString();
            this.WebsiteNSX = row["Website_NSX"].ToString();
        }
        public string DiaChiNSX
        {
            get
            {
                return diaChiNSX;
            }

            set
            {
                diaChiNSX = value;
            }
        }

        public int MaNSX
        {
            get
            {
                return maNSX;
            }

            set
            {
                maNSX = value;
            }
        }

        public string SdtNSX
        {
            get
            {
                return sdtNSX;
            }

            set
            {
                sdtNSX = value;
            }
        }

        public string TenNSX
        {
            get
            {
                return tenNSX;
            }

            set
            {
                tenNSX = value;
            }
        }

        public string WebsiteNSX
        {
            get
            {
                return websiteNSX;
            }

            set
            {
                websiteNSX = value;
            }
        }
    }
}
