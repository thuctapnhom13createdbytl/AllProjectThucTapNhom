using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class DonViDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static DonViDAO _instance;
        public static DonViDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new DonViDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<DONVI> LoadAllDonVi()
        {
            try
            {
                return db.DONVIs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemDonVi(DONVI dv)
        {
            try
            {
                db.DONVIs.Add(dv);
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int XoaDonVi(int maDV)
        {
            try
            {
                DONVI dv = db.DONVIs.SingleOrDefault(item => item.MaDonVi == maDV);
                if (dv == null)
                {
                    return 0;
                }
                else
                {
                    db.DONVIs.Remove(dv);
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int ChinhSuaDonVi(DONVI dv)
        {
            try
            {
                DONVI dvDT = db.DONVIs.SingleOrDefault(item => item.MaDonVi == dv.MaDonVi);
                if (dvDT == null)
                {
                    return 0;
                }
                else
                {
                    dvDT.TenDonVi = dv.TenDonVi;
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
