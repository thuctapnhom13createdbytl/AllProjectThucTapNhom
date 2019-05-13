using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class NhanVienDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static NhanVienDAO _instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new NhanVienDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<NHANVIEN> LoadAllNhanVien()
        {
            try
            {
                return db.NHANVIENs.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public int ThemNhanVien(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Add(nv);
                return db.SaveChanges();
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int XoaNhanVien(int maNV)
        {
            try
            {
                NHANVIEN nv = db.NHANVIENs.SingleOrDefault(item => item.MaNhanVien == maNV);
                if (nv == null)
                {
                    return 0;
                }
                else
                {
                    db.NHANVIENs.Remove(nv);
                    return db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int ChinhSuaNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN nvDT = db.NHANVIENs.SingleOrDefault(item => item.MaNhanVien == nv.MaNhanVien);
                if (nvDT == null)
                {
                    return 0;
                }
                else
                {
                    nvDT.TenNhanVien = nv.TenNhanVien;
                    nvDT.SDT = nv.SDT;
                    nvDT.GioiTinh = nv.GioiTinh;
                    return db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
