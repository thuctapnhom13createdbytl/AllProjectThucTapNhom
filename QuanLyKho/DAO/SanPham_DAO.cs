using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    public class SanPham_DAO
    {
        private static SanPham_DAO instance;

        public static SanPham_DAO Instance
        {
            get { if (instance == null) instance = new SanPham_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<SanPham_DTO> LayTatCaSanPham()
        {
            List<SanPham_DTO> DanhSachSP = new List<SanPham_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayTatCaSanPham");
            foreach (DataRow item in data.Rows)
            {
                SanPham_DTO SanPham = new SanPham_DTO(item);
                DanhSachSP.Add(SanPham);
            }
            return DanhSachSP;
        }
    }
}
