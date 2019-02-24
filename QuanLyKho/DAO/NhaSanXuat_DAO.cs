using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    public class NhaSanXuat_DAO
    {
        private static NhaSanXuat_DAO instance;
        public static NhaSanXuat_DAO Instance
        {
            get { if (instance == null) instance = new NhaSanXuat_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhaSanXuat_DTO> LayTatCaNSX()
        {
            List<NhaSanXuat_DTO> DanhSachNSX = new List<NhaSanXuat_DTO>();

            string query = "select * from NhaSanXuat";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaSanXuat_DTO NSX = new NhaSanXuat_DTO(item);
                DanhSachNSX.Add(NSX);
            }

            return DanhSachNSX;
        }
    }
}
