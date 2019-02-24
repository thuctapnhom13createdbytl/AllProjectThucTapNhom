using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    public class LoaiSanPham_DAO
    {
        private static LoaiSanPham_DAO instance;
        public static LoaiSanPham_DAO Instance
        {
            get { if (instance == null) instance = new LoaiSanPham_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<LoaiSanPham_DTO> LayTatCaLoaiSanPham()
        {
            List<LoaiSanPham_DTO> DanhSachLSP = new List<LoaiSanPham_DTO>();

            string query = "select * from LoaiSanPham";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSanPham_DTO LSP = new LoaiSanPham_DTO(item);
                DanhSachLSP.Add(LSP);
            }

            return DanhSachLSP;
        }
    }
}
