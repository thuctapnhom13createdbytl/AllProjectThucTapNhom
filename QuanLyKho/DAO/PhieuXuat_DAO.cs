using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    public class PhieuXuat_DAO
    {
        private static PhieuXuat_DAO instance;
        public static PhieuXuat_DAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuXuat_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<PhieuXuat_DTO> LayPhieuXuat()
        {
            try
            {
                List<PhieuXuat_DTO> listXuatHang = new List<PhieuXuat_DTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("LayPhieuXuat");
                foreach (DataRow item in data.Rows)
                {
                    PhieuXuat_DTO xuatHang = new PhieuXuat_DTO(item);
                    listXuatHang.Add(xuatHang);
                }
                return listXuatHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool ThemPhieuXuat(int MaNV, int MaKH, DateTime NgayXuat)
        {
            try
            {
                string query = string.Format("insert into PhieuXuat(Ma_NV,Ma_KH,Ngayxuat) values({0},{1},N'{2}')", MaNV, MaKH, NgayXuat);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int LayMaPXMoi()
        {
            int id = 0;
            string query = string.Format("select max(Ma_PX) as Ma_PX from PhieuXuat ");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                foreach (DataRow item in data.Rows)
                {
                    id = Convert.ToInt32(item["Ma_PX"]);
                }
            }
            return id;
        }
    }
}
