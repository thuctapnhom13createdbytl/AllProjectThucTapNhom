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
                string query = string.Format("insert into KhachHang values(N'{0}',N'{1}',N'{2}',N'{3}')",tenkh, diachi, sdt, email);
                var a = query;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaKhachHang(int maKH)
        {
            try
            {
                string query = " delete from KhachHang where Ma_KH = " + maKH;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<KhachHang_DTO> TimKiemKH(string str)
        {
            List<KhachHang_DTO> DanhSachKH = new List<KhachHang_DTO>();

            string query =  "select Ma_KH, Ten_KH,DiaChi_KH,SDT_KH,Email_KH"
                            + " from KhachHang "
                            + "where Ten_KH like N'%" + str + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang_DTO KH = new KhachHang_DTO(item);
                DanhSachKH.Add(KH);
            }

            return DanhSachKH;
        }
        public bool CapNhatKhachhang(int makh, string tenkh, string diachi, string sdt, string email)
        {
            try
            {
                string query = string.Format(" update KhachHang set Ten_KH = N'{0}', DiaChi_KH = N'{1}', SDT_KH = N'{2}',Email_KH = N'{3}' where Ma_KH = " + makh, tenkh, diachi, sdt, email);
                var a = query;
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
