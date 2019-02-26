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
            get { if (instance == null) instance = new LoaiSanPham_DAO(); return instance; }
            private set { instance = value; }
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
        public bool ThemLoaiSanPham(string tenLSP,string ghichu)
        {
            try
            {
                string query = string.Format("insert into LoaiSanPham VALUES  ( N'{0}', N'{1}')", tenLSP, ghichu);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }
        public bool SuaLoaiSanPham(int id,string tenLSP, string ghichu)
        {
            try
            {
                string query = string.Format("update LoaiSanPham set TenLoai = N'{0}', GhiChu = N'{1}' where Ma_LoaiSP = "+id, tenLSP, ghichu);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaLoaiSanPham(int maLSP)
        {
            try
            {
                // chú ý tạo trigger trong database
                string query = "delete from LoaiSanPham where Ma_LoaiSP = " + maLSP;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<LoaiSanPham_DTO> TimKiemLSP(string str)
        {
            List<LoaiSanPham_DTO> DanhSachLSP = new List<LoaiSanPham_DTO>();

            string query = "select * from LoaiSanPham where TenLoai like N'%"+str+"'";

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
