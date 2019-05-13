using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class DichVuDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static DichVuDAO _instance;
        public static DichVuDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new DichVuDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<DICHVU> LoadAllDichVu()
        {
            try
            {
                return db.DICHVUs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemDichVu(DICHVU dv)
        {
            try
            {
                db.DICHVUs.Add(dv);
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int XoaDichVu(int maDV)
        {
            try
            {
                DICHVU dv = db.DICHVUs.SingleOrDefault(item => item.MaDichVu == maDV);
                if (dv == null)
                {
                    return 0;
                }
                else
                {
                    db.DICHVUs.Remove(dv);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int ChinhSuaDichVu(DICHVU dv)
        {
            try
            {
                DICHVU dvDT = db.DICHVUs.SingleOrDefault(item => item.MaDichVu == dv.MaDichVu);
                if (dvDT == null)
                {
                    return 0;
                }
                else
                {
                    dvDT.MaDonVi = dv.MaDonVi;
                    dvDT.MaLoaiDichVu = dv.MaLoaiDichVu;
                    dvDT.DonGia = dv.DonGia;
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
