using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;
using System.Data;

namespace QLHS.DAO
{
    public class GiaoVien_DAO
    {
        private static GiaoVien_DAO instance;
        public static GiaoVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new GiaoVien_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<GiaoVien_DTO> TimKiemGV(string param)
        {
            List<GiaoVien_DTO> DSGV = new List<GiaoVien_DTO>();
            string query = string.Format("select GiaoVien.*,TenMonHoc from GiaoVien join MonHoc on GiaoVien.MaMonHoc = MonHoc.MaMonHoc where TenGiaoVien like N'%{0}%' or TenMonHoc like N'%{0}%'", param);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien_DTO gv = new GiaoVien_DTO(item);
                DSGV.Add(gv);
            }
            return DSGV;
        }
        public int ThemGV(int MaMH,string TenGV,string SDT,string Email)
        {
            try
            {
                string query = string.Format("insert into GiaoVien(MaMonHoc,TenGiaoVien,SDT,Email) values({0},N'{1}','{2}','{3}')", MaMH, TenGV, SDT, Email);
                int ThemGV = DataProvider.Instance.ExecuteNonQuery(query);
                return ThemGV;
            }
            catch
            {
                return -1;
            }
        }
        public int SuaGV(int MaGV,int MaMH, string TenGV, string SDT, string Email)
        {
            try
            {
                string query = string.Format("update GiaoVien set MaMonHoc = {0}, TenGiaoVien = N'{1}',SDT = '{2}',Email = '{3}' where MaGiaoVien = "+MaGV, MaMH, TenGV, SDT, Email);
                int Sua = DataProvider.Instance.ExecuteNonQuery(query);
                return Sua;
            }
            catch
            {
                return -1;
            }
        }
        public int XoaGV(int MaGV)
        {
            try
            {
                int xoa = DataProvider.Instance.ExecuteNonQuery("delete from GiaoVien where MaGiaoVien = " + MaGV);
                return xoa;
            }
            catch
            {
                return -1;
            }
        }
    }
}
