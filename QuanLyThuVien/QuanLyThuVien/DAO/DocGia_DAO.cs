using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class DocGia_DAO
    {
        private static DocGia_DAO instance;
        public static DocGia_DAO Instance
        {
            get
            {
                if (instance == null) instance = new DocGia_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<DocGia_DTO> LoadDocGiaComboBox()
        {
            List<DocGia_DTO> lstDocGia = new List<DocGia_DTO>();
            string query = " SELECT * FROM DocGia";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DocGia_DTO kh = new DocGia_DTO(item);
                lstDocGia.Add(kh);
            }
            return lstDocGia;
        }
    }

}