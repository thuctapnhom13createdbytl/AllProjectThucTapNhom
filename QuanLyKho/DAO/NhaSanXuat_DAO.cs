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
            get { if (instance == null) instance = new NhaSanXuat_DAO(); return instance; }
            private set { instance = value; }
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
        public bool ThemNSX(string tenNSX, string diachi,string sdt,string website)
        {
            try
            {
                string query = string.Format("insert into NhaSanXuat values (N'{0}',N'{1}','{2}','{3}')", tenNSX, diachi, sdt, website);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SuaNSX(int id, string tenNSX, string diachi, string sdt, string website)
        {
            try
            {
                string query = string.Format("update NhaSanXuat set Ten_NSX = N'{0}',DiaChi_NSX = N'{1}',SDT_NSX = '{2}',Website_NSX = '{3}' where Ma_NSX = " + id, tenNSX, diachi, sdt, website);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaNSX(int maNSX)
        {
            try
            {
                // chú ý tạo trigger trong database
                string query = "delete from NhaSanXuat where Ma_NSX = " + maNSX;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<NhaSanXuat_DTO> TimKiemNSX(string str)
        {
            List<NhaSanXuat_DTO> DanhSachNSX = new List<NhaSanXuat_DTO>();

            string query = "select * from NhaSanXuat where Ten_NSX like N'%" + str + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaSanXuat_DTO LSP = new NhaSanXuat_DTO(item);
                DanhSachNSX.Add(LSP);
            }

            return DanhSachNSX;
        }
    }
}
