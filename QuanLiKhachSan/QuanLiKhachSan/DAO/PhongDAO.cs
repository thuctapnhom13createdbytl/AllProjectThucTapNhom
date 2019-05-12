using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class PhongDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static PhongDAO _instance;
        public static PhongDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new PhongDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<PHONG> LoadAllPhong()
        {
            try
            {
                db = new QuanLyKhachSanDbContext();
                return db.PHONGs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public PHONG LoadChiTietPhong(int maPhong)
        {
            try
            {
                return db.PHONGs.SingleOrDefault(item => item.MaPhong == maPhong);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public int ChinhSuaPhong(PHONG phong)
        {
            try
            {
                PHONG phongDT = db.PHONGs.SingleOrDefault(item => item.MaPhong == phong.MaPhong);
                if (phongDT == null)
                {
                    return 0;
                }
                else
                {
                    phongDT.MaLoaiPhong = phong.MaLoaiPhong;
                    phongDT.MaLoaiTinhTrang = phong.MaLoaiTinhTrang;
                    phongDT.GhiChu = phong.GhiChu;
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void CheckTrangThaiPhong()
        {
            try
            {
                var listPhong = db.PHONGs.ToList();
                var listChiTietPhieuThue = db.CHITIETPHIEUTHUEs.ToList();
                foreach(CHITIETPHIEUTHUE ct in listChiTietPhieuThue)
                {
                    if ((ct.NgayThuePhong == DateTime.Now) && (ct.PHONG.LOAITINHTRANG.TenLoaiTinhTrang == "Đặt"))
                    {
                        PHONG phong = listPhong.SingleOrDefault(item => item.MaPhong == ct.MaPhong);
                        if (phong != null)
                        {
                            phong.MaLoaiTinhTrang = 2; // Có người ở
                        }
                    }
                    if ((ct.NgayTraPhong < DateTime.Now) && (ct.PHONG.LOAITINHTRANG.TenLoaiTinhTrang == "Có người ở"))
                    {
                        PHONG phong = listPhong.SingleOrDefault(item => item.MaPhong == ct.MaPhong);
                        if (phong != null)
                        {
                            phong.MaLoaiTinhTrang = 1; // trống
                        }
                    }
                }
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
