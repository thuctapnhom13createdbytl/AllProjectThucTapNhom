using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class NhanVien_DAO
    {
        private static NhanVien_DAO instance;
        public static NhanVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVien_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<NhanVien_DTO> LoadToanBoNhanVien()
        {
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayTatCaNhanVien");
            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO kh = new NhanVien_DTO(item);
                lstNhanVien.Add(kh);
            }
            return lstNhanVien;
        }
        public bool ThemNhanVien(string manhanvien, string hoten, string diachi, string sdt)
        {
            try
            {
                string query = string.Format("insert into NhanVien values(N'{0}',N'{1}',N'{2}',N'{3}')", manhanvien, hoten, diachi, sdt);
                var a = query;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaNhanVien(string maNV)
        {
            // try
            //  {" ... = ' " + maNV + "'"
            string query = " delete from NhanVien where MaNhanVien ='" + maNV+"'";
            var a = query;
            DataProvider.Instance.ExecuteNonQuery(query);
                return true;
         //   }
         //   catch (Exception e)
        //    {
         //       return false;
          //  }
        }
        public List<NhanVien_DTO> TimKiemNV(string str)
        {
            List<NhanVien_DTO> DanhSachNV = new List<NhanVien_DTO>();

            string query = "select MaNhanVien, HoTen,DiaChi,SDT"
                            + " from NhanVien "
                            + "where HoTen like N'%" + str + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
               NhanVien_DTO NV = new NhanVien_DTO(item);
                DanhSachNV.Add(NV);
            }

            return DanhSachNV;
        }
        public bool CapNhatNhanVien(string manv, string hoten, string diachi, int sdt)
        {
            try
            {
                string query = string.Format(" update NhanVien set  HoTen = N'{0}', DiaChi = N'{1}',SDT = {2} where MaNhanVien='"+manv+"'", hoten, diachi, sdt);
              //  var a = query;
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
