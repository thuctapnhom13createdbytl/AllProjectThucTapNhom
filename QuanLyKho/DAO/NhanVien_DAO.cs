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
    }
}
