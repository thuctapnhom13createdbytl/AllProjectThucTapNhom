using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.DTO;

namespace QuanLyKho.DAO
{
    public class KhachHang_DAO
    {
        private static KhachHang_DAO instance;
        public static KhachHang_DAO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHang_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<KhachHang_DTO> LoadToanBoKhachHang()
        {
            List<KhachHang_DTO> lstKhachHang = new List<KhachHang_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayTatCaKhachHang");
            foreach (DataRow item in data.Rows)
            {
                KhachHang_DTO kh = new KhachHang_DTO(item);
                lstKhachHang.Add(kh);
            }
            return lstKhachHang;
        }
        public bool ThemKhachHang(string tenkh, string diachi, string sdt, string email)
        {
            try
            {
                string query = string.Format("insert into KhachHang values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",tenkh, diachi, sdt, email);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
