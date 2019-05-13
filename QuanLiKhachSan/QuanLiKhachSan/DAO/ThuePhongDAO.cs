using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class ThuePhongDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static ThuePhongDAO _instance;
        public static ThuePhongDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new ThuePhongDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<CHITIETPHIEUTHUE> LoadAllPhieuThuePhong()
        {
            try
            {
                return db.CHITIETPHIEUTHUEs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CHITIETPHIEUTHUE LoadChiTietPhongThue(int maPhong)
        {
            try
            {
                var listChiTietPhieuThue = db.CHITIETPHIEUTHUEs.Where(item => item.MaPhong == maPhong).OrderByDescending(item => item.MaPhieuThue).ToList();
                return listChiTietPhieuThue[0];
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public int ThemPhieuThuePhong(PHIEUTHUEPHONG phieuThue, CHITIETPHIEUTHUE chiTiet)
        {
            try
            {
                object[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@MaKhachHang", phieuThue.MaKhachHang),
                    new SqlParameter("@MaNhanVien", phieuThue.MaNhanVien),
                    new SqlParameter("@MaPhong", chiTiet.MaPhong),
                    new SqlParameter("@NgayThuePhong", chiTiet.NgayThuePhong),
                    new SqlParameter("@NgayTraPhong", chiTiet.NgayTraPhong),
                };
                int ketQua = db.Database.ExecuteSqlCommand("prc_PhieuThue_Insert @MaKhachHang,@MaNhanVien,@MaPhong,@NgayThuePhong,@NgayTraPhong", sqlParams);
                db.SaveChanges();
                return ketQua;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
