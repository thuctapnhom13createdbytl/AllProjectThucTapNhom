using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class ThietBiDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static ThietBiDAO _instance;
        public static ThietBiDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new ThietBiDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<THIETBI> LoadAllThietBi()
        {
            try
            {
                return db.THIETBIs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemThietBi(THIETBI tb)
        {
            try
            {
                db.THIETBIs.Add(tb);
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int XoaThietBi(int maTB)
        {
            try
            {
                THIETBI tb = db.THIETBIs.SingleOrDefault(item => item.MaThietBi == maTB);
                if (tb == null)
                {
                    return 0;
                }
                else
                {
                    db.THIETBIs.Remove(tb);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int ChinhSuaThietBi(THIETBI tb)
        {
            try
            {
                THIETBI tbDT = db.THIETBIs.SingleOrDefault(item => item.MaThietBi == tb.MaThietBi);
                if (tbDT == null)
                {
                    return 0;
                }
                else
                {
                    tbDT.TenThietBi = tb.TenThietBi;
                    tbDT.MaLoaiPhong = tb.MaLoaiPhong;
                    tbDT.SoLuong = tb.SoLuong;
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
