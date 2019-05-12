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
        public List<Diem_DTO> LayDiemTheoHS(int id,int MaHK)
        {
                List<Diem_DTO> DSDiem = new List<Diem_DTO>();
                string query = string.Format("select DiemMon.*,TenMonHoc, TenHocKy  from DiemMon join MonHoc on DiemMon.MaMonHoc = MonHoc.MaMonHoc join HocKi on HocKi.MaHocKy = DiemMon.MaHocKy where MaHocSinh = {0} and DiemMon.MaHocKy = {1}" ,id,MaHK);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach(DataRow item in data.Rows)
                {
                    Diem_DTO diem = new Diem_DTO(item);
                    DSDiem.Add(diem);
                }
            return DSDiem;
        }
        public int ThemDiem(int MaMonHoc, int MaHocKy, int MaHocSinh,double Diem15, double DiemGiuaKy, double DiemThi )
        {
            try
            {
                string query = string.Format("insert into DiemMon(MaMonHoc,MaHocKy,MaHocSinh,Diem15,DiemGiuaKy,DiemThi) values ({0},{1},{2},{3},{4},{5})", MaMonHoc, MaHocKy, MaHocSinh, Diem15, DiemGiuaKy, DiemThi);
                int Them = DataProvider.Instance.ExecuteNonQuery(query);
                return Them;
            }
            catch
            {
                return -1;
            }
        }
        public int XoaDiem(int id)
        {
            try
            {
                int xoa = DataProvider.Instance.ExecuteNonQuery("delete from DiemMon where MaDiemMon = " + id);
                return xoa;
            }
            catch
            {
                return -1;
            }
        }
        public int CapNhatDiem(int maDiem,int MaMonHoc, int MaHocKy, int MaHocSinh, double Diem15, double DiemGiuaKy, double DiemThi)
        {
            try
            {
                double tb = Math.Round((Diem15 + DiemGiuaKy * 2 + DiemThi * 3) / 6, 1);
                string query = string.Format("update DiemMon set MaMonHoc = {0}, MaHocKy = {1}, MaHocSinh = {2}, Diem15 = {3},DiemGiuaKy = {4},DiemThi = {5},TrungBinh = {6} where MaDiemMon = " + maDiem, MaMonHoc, MaHocKy, MaHocSinh, Diem15, DiemGiuaKy, DiemThi, tb);
                int capnhat = DataProvider.Instance.ExecuteNonQuery(query);
                return capnhat;
            }
            catch
            {
                return -1;
            }
        }
    }
}
