using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    public class PhieuNhap_DAO
    {
        private static PhieuNhap_DAO instance;
        public static PhieuNhap_DAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuNhap_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<PhieuNhap_DTO> LayPhieuNhap()
        {
            List<PhieuNhap_DTO> DS = new List<PhieuNhap_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayPhieuNhap");
            foreach (DataRow item in data.Rows)
            {
                PhieuNhap_DTO nhapHang = new PhieuNhap_DTO(item);
                DS.Add(nhapHang);
            }
            return DS;
        }
        
        public bool ThemPhieuNhap(int MaNV, int MaNSX, DateTime NgayNhap)
        {
            try
            {
                string query = string.Format("insert into PhieuNhap(Ma_NV,Ma_NSX,Ngaynhap) values({0},{1},N'{2}')", MaNV, MaNSX, NgayNhap);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            } catch
            {
                return false;
            }
        }
        public int LayMaPNMoi()
        {
            int id = 0;
            string query = string.Format("select max(Ma_PN) as Ma_PN from PhieuNhap");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                foreach (DataRow item in data.Rows)
                {
                    id = Convert.ToInt32(item["Ma_PN"]);
                }
            }
            return id;
        }
    }
}
