using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    public class CTPhieuXuat_DAO
    {
        private static CTPhieuXuat_DAO instance;
        public static CTPhieuXuat_DAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuXuat_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<CTPhieuXuat_DTO> LayPhieuXuat(int MaPX)
        {
            try
            {
                List<CTPhieuXuat_DTO> listXuatHang = new List<CTPhieuXuat_DTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("LayCTPhieuXuat @MaPX", new object[] { MaPX });
                foreach (DataRow item in data.Rows)
                {
                    CTPhieuXuat_DTO xuatHang = new CTPhieuXuat_DTO(item);
                    listXuatHang.Add(xuatHang);
                }
                return listXuatHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool ThemCTPhieuXuat(int MaPX, int MaSanPham, int SoLuong, decimal DonGia)
        {
            try
            {
                string query = string.Format("insert into CT_PhieuXuat(Ma_PX,Ma_Sanpham,Soluong,Dongia) values ({0},{1},{2},{3})", MaPX, MaSanPham, SoLuong, DonGia);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
