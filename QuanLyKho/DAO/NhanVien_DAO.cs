using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.DTO;
using System.Data;

namespace QuanLyKho.DAO
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

        public List<NhanVien_DTO> LoadDanhSachNhanVien()
        {
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LoadToanBoNhanVien");
            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO nv = new NhanVien_DTO(item);
                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }

        public bool ThemNhanVien(string tenNV, string gioitinh, DateTime ngaysinh, string sdtNV, string emailNV)
        {
            try
            {
                string query = string.Format("insert into NhanVien values (N'{0}', N'{1}','{2}','{3}','{4}')", tenNV, gioitinh, ngaysinh, sdtNV, emailNV); 
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool SuaNhanVien(int maNV, string tenNV, string gioitinh, DateTime ngaysinh, string sdtNV, string emailNV)
        {
            try
            {
                string query = string.Format("update NhanVien set Ten_NV = N'{0}', GioiTinh = N'{1}', Ngaysinh_NV = '{2}', SDT_NV ='{3}', Email_NV='{4}' where Ma_NV = " + maNV, tenNV, gioitinh, ngaysinh, sdtNV, emailNV); //check lai giong bai hiep
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool XoaNhanVien(int maNV)
        {
            try
            {
                string query = "delete from NhanVien where Ma_NV = " + maNV;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
             catch(Exception e)
            {
                return false;
            }
        }

        public List<NhanVien_DTO> TimKiemNV(string str)
        {
            List<NhanVien_DTO> DanhSachNhanVien = new List<NhanVien_DTO>();

            string query = "select Ma_NV, Ten_NV, Gioitinh, NgaysinhNv, SDT_NV, Email_NV "
                            + "from NhanVIen where Ten_NV like N'%" + str + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO NV = new NhanVien_DTO(item);
                DanhSachNhanVien.Add(NV);
            }
            return DanhSachNhanVien;
        }
    }
}
