using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class DocGia_DAO
    {
        private static DocGia_DAO instance;
        public static DocGia_DAO Instance
        {
            get
            {
                if (instance == null) instance = new DocGia_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<DocGia_DTO> LoadToanBoDocGia()
        {
            List<DocGia_DTO> lstDocGia = new List<DocGia_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayTatCaDocGia");
            foreach (DataRow item in data.Rows)
            {
                DocGia_DTO x = new DocGia_DTO(item);
                lstDocGia.Add(x);
            }
            return lstDocGia;
        }

        public bool ThemDocGia(string maDocGia, string tenDocGia, string diaChi, string sdt)
        {
            try
            {
                string query = string.Format("insert into DocGia values(N'{0}', N'{1}', N'{2}', N'{3}')", maDocGia, tenDocGia, diaChi, sdt);
                var a = query;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaDocGia(string maDocGia)
        {
            string query = "delete from DocGia where maDocGia ='" + maDocGia + "'";
            var a = query;
            DataProvider.Instance.ExecuteNonQuery(query);
            return true;
        }
        
        public List<DocGia_DTO> TimKiemDG(string str)
        {
            List<DocGia_DTO> DanhSachDG = new List<DocGia_DTO>();

            string query = "select maDocGia,tenDocGia,diaChi,SDT"
                            + " from DocGia "
                            + "where tenDocGia like N'%" + str + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                DocGia_DTO DG = new DocGia_DTO(item);
                DanhSachDG.Add(DG);
            }
            return DanhSachDG;
        }

        public bool CapNhatDocGia(string maDocGia, string tenDocGia, string diaChi, string sdt)
        {
            try
            {
                string query = string.Format("update DocGia set TenDocGia = N'{0}', DiaChi=N'{1}', SDT = '{2}' where MaDocGia = '" + maDocGia + "'", tenDocGia, diaChi, sdt);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}