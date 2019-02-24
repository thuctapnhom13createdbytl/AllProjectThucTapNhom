using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.DTO;
using System.Data;

namespace QuanLyKho.DAO
{
    public class NhaSanXuat_DAO
    {
        private static NhaSanXuat_DAO instance;
        public static NhaSanXuat_DAO Instance
        {
            get
            {
                if (instance == null) instance = new NhaSanXuat_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<NhaSanXuat_DTO> LoadToanBoNSX()
        {
            List<NhaSanXuat_DTO> lstNSX = new List<NhaSanXuat_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LoadToanBoNhaSanXuat");
            foreach (DataRow item in data.Rows)
            {
                NhaSanXuat_DTO nsx = new NhaSanXuat_DTO(item);
                lstNSX.Add(nsx);
            }
            return lstNSX;
        }
    }
}
