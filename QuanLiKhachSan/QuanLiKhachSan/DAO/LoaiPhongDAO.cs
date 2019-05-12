using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class LoaiPhongDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static LoaiPhongDAO _instance;
        public static LoaiPhongDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new LoaiPhongDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<LOAIPHONG> LoadAllLoaiPhong()
        {
            try
            {
                return db.LOAIPHONGs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemLoaiPhong(LOAIPHONG lp)
        {
            try
            {
                db.LOAIPHONGs.Add(lp);
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int XoaLoaiPhong(int maLP)
        {
            try
            {
                LOAIPHONG lp = db.LOAIPHONGs.SingleOrDefault(item => item.MaLoaiPhong == maLP);
                if (lp == null)
                {
                    return 0;
                }
                else
                {
                    db.LOAIPHONGs.Remove(lp);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int ChinhSuaLoaiPhong(LOAIPHONG lp)
        {
            try
            {
                LOAIPHONG lpDT = db.LOAIPHONGs.SingleOrDefault(item => item.MaLoaiPhong == lp.MaLoaiPhong);
                if (lpDT == null)
                {
                    return 0;
                }
                else
                {
                    lpDT.TenLoaiPhong = lp.TenLoaiPhong;
                    lpDT.SoNguoiTieuChuan = lp.SoNguoiTieuChuan;
                    lpDT.SoNguoiToiDa = lp.SoNguoiToiDa;
                    lpDT.DonGia = lp.DonGia;
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
