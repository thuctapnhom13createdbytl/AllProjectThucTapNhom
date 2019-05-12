using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;
using QuanLiKhachSan.DAO;

namespace QuanLiKhachSan.DAO
{
    public class LoaiTinhTrangDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static LoaiTinhTrangDAO _instance;
        public static LoaiTinhTrangDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new LoaiTinhTrangDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<LOAITINHTRANG> LoadAllLoaiTinhTrang()
        {
            try
            {
                return db.LOAITINHTRANGs.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
