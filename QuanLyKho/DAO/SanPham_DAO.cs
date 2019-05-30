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
        public bool ThemSanPham(string tenSP, int Ma_NSX,string thongso,int maLSP,decimal gia,int soluong)
        {
            try
            {
                string query = string.Format("insert into SanPham values(N'{0}',{1},N'{2}',{3},{4},{5})", tenSP, Ma_NSX, thongso, maLSP, gia, soluong);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SuaSanPham(int id, string tenSP, int Ma_NSX, string thongso, int maLSP, decimal gia, int soluong)
        {
            try
            {
                string query = string.Format(" update SanPham set TenSanPham = N'{0}',Ma_NSX = {1}, Thongso_Kt = N'{2}', Ma_LoaiSP = {3},Gia = {4},SoLuong = {5} where Ma_Sanpham = " + id, tenSP, Ma_NSX, thongso, maLSP, gia, soluong);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaSanPham(int maSP)
        {
            try
            {
                // chú ý tạo trigger trong database
                string query = " delete from SanPham where Ma_Sanpham = " + maSP;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<SanPham_DTO> TimKiemSP(string str)
        {
            List<SanPham_DTO> DanhSachSP = new List<SanPham_DTO>();

            string query = "select Ma_Sanpham,TenSanPham, Thongso_Kt,Gia,SoLuong, TenLoai, Ten_NSX,SanPham.Ma_NSX,SanPham.Ma_LoaiSP "
                            +"from SanPham left join NhaSanXuat on SanPham.Ma_NSX = NhaSanXuat.Ma_NSX left "
                            +"join LoaiSanPham on SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP "
                            +"where TenSanPham like N'%"+str+"%'";
            
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham_DTO LSP = new SanPham_DTO(item);
                DanhSachSP.Add(LSP);
            }

            return DanhSachSP;
        }
    }
}
