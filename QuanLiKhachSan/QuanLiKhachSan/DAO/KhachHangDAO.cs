using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class KhachHangDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static KhachHangDAO _instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new KhachHangDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<KHACHHANG> LoadAllKhachHang()
        {
            try
            {
                return db.KHACHHANGs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemKhachHang(KHACHHANG kh)
        {
            try
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
                return kh.MaKhachHang;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int XoaKhachHang(int maKH)
        {
            try
            {
                KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(item => item.MaKhachHang == maKH);
                if (kh == null)
                {
                    return 0;
                }
                else
                {
                    db.KHACHHANGs.Remove(kh);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int ChinhSuaKhachHang(KHACHHANG kh)
        {
            try
            {
                KHACHHANG khDT = db.KHACHHANGs.SingleOrDefault(item => item.MaKhachHang == kh.MaKhachHang);
                if (khDT == null)
                {
                    return 0;
                }
                else
                {
                    khDT.TenKhachHang = kh.TenKhachHang;
                    khDT.CMND = kh.CMND;
                    khDT.GioiTinh = kh.GioiTinh;
                    khDT.DiaChi = kh.DiaChi;
                    khDT.DienThoai = kh.DienThoai;
                    khDT.QuocTich = kh.QuocTich;
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
