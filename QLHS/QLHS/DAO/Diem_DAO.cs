using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;
using System.Data;

namespace QLHS.DAO
{
    public class Diem_DAO
    {
        private static Diem_DAO instance;
        public static Diem_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Diem_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<Diem_DTO> LayTatCaDiem()
        {
            List<Diem_DTO> DSDiem = new List<Diem_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LoadDiemHocSinh");
            foreach( DataRow item in data.Rows)
            {
                Diem_DTO diem = new Diem_DTO(item);
                DSDiem.Add(diem);
            }
            return DSDiem;
        }

        public List<Diem_DTO> TimKiemDiemHS(string str)
        {
            List<Diem_DTO> DSDiem = new List<Diem_DTO>();
            string query = string.Format("TimKiemHocSinh N'%{0}%'", str);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Diem_DTO diem = new Diem_DTO(item);
                DSDiem.Add(diem);
            }
            return DSDiem;
        }

        public bool  SuaDiem (int madiemmon,  double trungbinh, double diem15, double diemgiuaky, double diemthi)
        {
            try
            {
                string query = string.Format("UPDATE dbo.DiemMon SET  TrungBinh = {0}, Diem15 = {1}, DiemGiuaKy = {2}, DiemThi = {3} where MaDiemMon = " + madiemmon, trungbinh, diem15, diemgiuaky, diemthi);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaDiem(int madiemmon)
        {
            try
            {
                string query = "DELETE FROM dbo.DiemMon WHERE MaDiemMon = " + madiemmon;
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        //public int ThemDiem( int MaDiemMon, double TrungBinh, string TenHocSinh, string TenMonHoc, string TenHocKy, double Diem15, double DiemGiuaKy, double DiemThi)
        //{
        //    try
        //    {
        //        string query = string.Format("insert into"); // Cần xem lại

        //       int ThemDiem = DataProvider.Instance.ExecuteNonQuery(query);
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}

    }
}
