using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiKhachSan.DTO;

namespace QuanLiKhachSan.DAO
{
    public class LoaiDichVuDAO
    {
        private QuanLyKhachSanDbContext db = new QuanLyKhachSanDbContext();
        private static LoaiDichVuDAO _instance;
        public static LoaiDichVuDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new LoaiDichVuDAO();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<LOAIDICHVU> LoadAllLoaiDichVu()
        {
            try
            {
                return db.LOAIDICHVUs.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

    }
}
