using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class HoaDonDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static HoaDonDAO _instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new HoaDonDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<HOADONTHUE> LoadAllHoaDon()
        {
            try
            {
                return db.HOADONTHUEs.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public int ThemMoiHoaDon(HOADONTHUE hoadon, List<CHITIETHOADON> listChiTiet, int maPhong)
        {
            try
            {
                db.HOADONTHUEs.Add(hoadon);
                db.SaveChanges();
                foreach(CHITIETHOADON ct in listChiTiet)
                {
                    ct.MaHoaDon = hoadon.MaHoaDon;
                    db.CHITIETHOADONs.Add(ct);
                }
                PHONG phong = db.PHONGs.SingleOrDefault(item => item.MaPhong == maPhong);
                phong.MaLoaiTinhTrang = 1;
                return db.SaveChanges();
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
