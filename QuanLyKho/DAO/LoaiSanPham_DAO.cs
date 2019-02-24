using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKho.DTO;

namespace QuanLyKho.DAO
{
    public class LoaiSanPham_DAO
    {
        private static LoaiSanPham_DAO instance;
        public static LoaiSanPham_DAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiSanPham_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<LoaiSanPham_DTO> LoadToanBoLoaiSanPham()
        {
            List<LoaiSanPham_DTO> lstLoaiSP = new List<LoaiSanPham_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LoadToanBoLoaiSanPham");
            foreach (DataRow item in data.Rows)
            {
                LoaiSanPham_DTO loaiSP = new LoaiSanPham_DTO(item);
                lstLoaiSP.Add(loaiSP);
            }
            return lstLoaiSP;
        }
    }
}
