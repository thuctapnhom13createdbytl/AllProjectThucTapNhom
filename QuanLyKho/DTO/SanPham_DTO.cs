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
        private int maSP;
        private string tenSP;
        private int maNSX;
        private string tenNSX;
        private int maLoaiSP;
        private string tenLoaiSP;
        private int soLuong;
        private decimal donGia;
        private string thongSoKyThuat;
        private Nullable<decimal> tongTien;

        public SanPham_DTO (int soLuong, string tenNSX, decimal donGia, int maSP, string tenSP, string thongSoKyThuat, string tenLoaiSP, int maLoaiSP, int maNSX)
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
            this.TongTien = 0;
        }

        public SanPham_DTO (DataRow row)
        {
            this.SoLuong = (int)row["soLuong"];
            this.TenNSX = row["Ten_NSX"].ToString()!= "" ? row["Ten_NSX"].ToString(): "chưa có nhà sản xuất" ;
            this.DonGia = Convert.ToDecimal(row["Gia"]);
            this.MaSP = (int)row["Ma_Sanpham"];
            this.TenSP = row["TenSanPham"].ToString();
            this.ThongSoKyThuat = row["Thongso_Kt"].ToString();
            this.TenLoaiSP = row["TenLoai"].ToString() != "" ? row["TenLoai"].ToString() : "chưa có loại sản phẩm" ;
            this.MaLoaiSP = row["ma_loaiSP"].ToString() != "" ? (int)row["ma_loaiSP"] : 0;
            this.MaNSX = row["Ma_NSX"].ToString() != "" ? (int)row["Ma_NSX"] : 0;
            this.TongTien = 0;
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

        public decimal DonGia
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

        public decimal? TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
    }
}
