using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    public class SanPham_DTO
    {
        private int soLuong;
        private string tenNSX;
        private float donGia;
        private int maSP;
        private string tenSP;
        private string thongSoKyThuat;
        private string tenLoaiSP;
        private int maLoaiSP;
        private int maNSX;

        public SanPham_DTO (int soLuong, string tenNSX, float donGia, int maSP, string tenSP, string thongSoKyThuat, string tenLoaiSP, int maLoaiSP, int maNSX)
        {
            this.SoLuong = soLuong;
            this.TenNSX = tenNSX;
            this.DonGia = donGia;
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.ThongSoKyThuat = thongSoKyThuat;
            this.TenLoaiSP = tenLoaiSP;
            this.MaLoaiSP = maLoaiSP;
            this.MaNSX = maNSX;
        }

        public SanPham_DTO (DataRow row)
        {
            this.SoLuong = (int)row["soLuong"];
            this.TenNSX = row["Ten_NSX"].ToString();
            this.DonGia = (int)row["Gia"];
            this.MaSP = (int)row["Ma_Sanpham"];
            this.TenSP = row["TenSanPham"].ToString();
            this.ThongSoKyThuat = row["Thongso_Kt"].ToString();
            this.TenLoaiSP = row["TenLoai"].ToString();
            this.MaLoaiSP = (int)row["ma_loaiSP"]; ;
            this.MaNSX = (int)row["Ma_NSX"];
        }
        public int MaSP
        {
            get
            {
                return maSP;
            }

            set
            {
                maSP = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string TenSP
        {
            get
            {
                return tenSP;
            }

            set
            {
                tenSP = value;
            }
        }

        public string ThongSoKyThuat
        {
            get
            {
                return thongSoKyThuat;
            }

            set
            {
                thongSoKyThuat = value;
            }
        }

        public string TenLoaiSP
        {
            get
            {
                return tenLoaiSP;
            }

            set
            {
                tenLoaiSP = value;
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

        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public int MaLoaiSP
        {
            get
            {
                return maLoaiSP;
            }

            set
            {
                maLoaiSP = value;
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
    }
}
