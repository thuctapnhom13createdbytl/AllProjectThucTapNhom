using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;
using System.Data;

namespace QLHS.DAO
{
    public class HocSinh_DAO
    {
        private static HocSinh_DAO instance;
        public static HocSinh_DAO Instance
        {
            get
            {
                if (instance == null) instance = new HocSinh_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<HocSinh_DTO> LayTatCaHS()
        {
            List<HocSinh_DTO> DSHS = new List<HocSinh_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop ");
            foreach(DataRow item in data.Rows)
            {
                HocSinh_DTO hs = new HocSinh_DTO(item);
                DSHS.Add(hs);
            }
            return DSHS;
        }
        public int ThemHS(int MaLop,string TenHS, string GioiTinh,DateTime NgaySinh, string DiaChi, string SDT, string TonGiao, string DanToc, string TenCha, string TenMe)
        {
            try
            {
                string query = string.Format("insert into HocSinh(MaLop, TenHocSinh,GioiTinh, NgaySinh,DiaChi,SDT,TonGiao,DanToc,TenCha,TenMe) values({0},N'{1}',N'{2}','{3}',N'{4}','{5}',N'{6}',N'{7}',N'{8}',N'{9}')",
                                                MaLop, TenHS, GioiTinh, NgaySinh, DiaChi, SDT, TonGiao, DanToc, TenCha, TenMe);
                int ThemHS = DataProvider.Instance.ExecuteNonQuery(query);
                return ThemHS;
            }
            catch
            {
                return 0;
            }

        }
        public int SuaHS(int MaHS,int MaLop, string TenHS, string GioiTinh, DateTime NgaySinh, string DiaChi, string SDT, string TonGiao, string DanToc, string TenCha, string TenMe)
        {
            try
            {
                string query = string.Format("update HocSinh set MaLop = {0}, TenHocSinh = N'{1}',GioiTinh = N'{2}',NgaySinh = '{3}',DiaChi = N'{4}', SDT = '{5}', TonGiao = N'{6}',DanToc = N'{7}',TenCha = N'{8}',TenMe = N'{9}' where MaHocSinh = " + MaHS,
                                                MaLop, TenHS, GioiTinh, NgaySinh, DiaChi, SDT, TonGiao, DanToc, TenCha, TenMe);
                int SuaHS = DataProvider.Instance.ExecuteNonQuery(query);
                return SuaHS;
            }
            catch
            {
                return 0;
            }

        }
        public int XoaHS(int MaHS)
        {
            try
            {
                int XoaHS = DataProvider.Instance.ExecuteNonQuery("delete from HocSinh where MaHocSinh = " + MaHS);
                return XoaHS;
            }
            catch
            {
                return 0;
            }
        }
        public List<HocSinh_DTO> TimKiemHS(string param)
        {
            List<HocSinh_DTO> DSHS = new List<HocSinh_DTO>();
            string query = string.Format("select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop where TenHocSinh like N'%{0}%'", param);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocSinh_DTO hs = new HocSinh_DTO(item);
                DSHS.Add(hs);
            }
            return DSHS;
        }
        public List<HocSinh_DTO> LayHocSinhTheoLop(int id)
        {
            List<HocSinh_DTO> DSHS = new List<HocSinh_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop where HocSinh.MaLop = " + id);
            foreach (DataRow item in data.Rows)
            {
                HocSinh_DTO hs = new HocSinh_DTO(item);
                DSHS.Add(hs);
            }
            return DSHS;
        }
        public List<HocSinh_DTO> TimKiemHSTheoLop(string param,int MaLop)
        {
            List<HocSinh_DTO> DSHS = new List<HocSinh_DTO>();
            string query = string.Format("select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop where TenHocSinh like N'%{0}%' and HocSinh.MaLop = " + MaLop, param);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocSinh_DTO hs = new HocSinh_DTO(item);
                DSHS.Add(hs);
            }
            return DSHS;
        }
    }
}
