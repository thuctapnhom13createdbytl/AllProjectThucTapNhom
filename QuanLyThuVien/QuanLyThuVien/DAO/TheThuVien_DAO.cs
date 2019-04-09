using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data.SqlTypes;



namespace QuanLyThuVien.DAO
{
    public class TheThuVien_DAO
    {
        private static TheThuVien_DAO instance;
        public static TheThuVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new TheThuVien_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<TheThuVien_DTO> LoadToanBoTheThuVien()
        {
            List<TheThuVien_DTO> lstTheThuVien = new List<TheThuVien_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayTatCaTheThuVien");
            foreach (DataRow item in data.Rows)
            {
                TheThuVien_DTO tt = new TheThuVien_DTO(item);
                lstTheThuVien.Add(tt);
            }
            return lstTheThuVien;
        }
    }

}


