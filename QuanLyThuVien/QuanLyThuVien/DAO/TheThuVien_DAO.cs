using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data.SqlTypes;



namespace QuanLyThuVien.DAO
{
    public class TheThuVien_DAO
    {
        private static TheThuVien_DAO instance;
        public static TheThuVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new TheThuVien_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<TheThuVien_DTO> LoadToanBoTheThuVien()
        {
            List<TheThuVien_DTO> lstTheThuVien = new List<TheThuVien_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayTatCaTheThuVien");
            foreach (DataRow item in data.Rows)
            {
                TheThuVien_DTO ttv = new TheThuVien_DTO(item);
                lstTheThuVien.Add(ttv);
            }
            return lstTheThuVien;
        }
        public bool ThemTheThuVien(string sothe, DateTime ngaybatdau, DateTime ngayketthuc, string madocgia )
        {
            try
            {
           
                string query = string.Format("insert into TheThuVien values('{0}','{1}','{2}','{3}')", sothe, ngaybatdau.ToShortDateString(), ngayketthuc.ToShortDateString(), madocgia);
                var a = query;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool XoaTheThuVien(string sothe)
        {
            string query = "delete from TheThuVien where SoThe = '" + sothe + "'";
            var a = query;
            DataProvider.Instance.ExecuteNonQuery(query);
            return true;
        }

        public List<TheThuVien_DTO> TimKiemTTV(string str)
        {
            List<TheThuVien_DTO> DanhSachTTV = new List<TheThuVien_DTO>();

            string query = "TimKiemTheThuVien '" + str + "'" ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                TheThuVien_DTO TTV = new TheThuVien_DTO(item);
                DanhSachTTV.Add(TTV);
            }
            return DanhSachTTV;
        }

        public bool CapNhatTheThuVien(string sothe, DateTime ngaybatdau, DateTime ngayketthuc, string tendocgia)
        {
            try
            {
                string query = string.Format("update TheThuVien set ngaybatdau = '{0}', ngayketthuc = '{1}', MaDocGia = (select DocGia.MaDocGia from DocGia where DocGia.TenDocGia like N'{2}') where sothe = '" + sothe + "'", ngaybatdau.ToShortDateString(), ngayketthuc.ToShortDateString(), tendocgia);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}


