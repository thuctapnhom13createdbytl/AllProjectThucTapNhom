using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class ViPham_DAO
    {
        private static ViPham_DAO instance;
        public static ViPham_DAO Instance
        {
            get
            {
                if (instance == null) instance = new ViPham_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<ViPham_DTO> LoadTatCaViPham()
        {
            
            try
            {
                List<ViPham_DTO> listViPham = new List<ViPham_DTO>();

                string query = "SELECT * FROM ViPham";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    ViPham_DTO vp = new ViPham_DTO(item);
                    listViPham.Add(vp);
                }

                return listViPham;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

	
