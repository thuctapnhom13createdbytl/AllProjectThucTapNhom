using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO

{
public class DauSach_DAO
{
        private static DauSach_DAO instance;
        public static DauSach_DAO Instance
        {
            get { if (instance == null) instance = new DauSach_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<DauSach_DTO> LayTatCaDauSach()
        {
            List<DauSach_DTO> DanhSachDauSach = new List<DauSach_DTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("LayTatCaDauSach");
            foreach (DataRow item in data.Rows)
            {
                DauSach_DTO DauSach = new DauSach_DTO(item);
                DanhSachDauSach.Add(DauSach);
            }
            return DanhSachDauSach;
        }
        public bool ThemDauSach(string Ma,string Ten, string MaTL,string MaNXB)
        {
            try
            {
                string query = string.Format("insert into DauSach values('{0}',N'{1}','{2}','{3}')",Ma,Ten,MaTL,MaNXB);
                DataProvider.Instance.ExecuteQuery(query);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public bool CapNhatDauSach(string Ma, string Ten, string MaTL, string MaNXB)
        {
            try
            {
                string query = string.Format("update DauSach set TenDauSach = N'{0}',MaNXB = '{1}', MaTheLoai = '{2}' where MaDauSach = '{3}'" ,Ten, MaNXB,MaTL,Ma);
                DataProvider.Instance.ExecuteQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool XoaDauSach(string ma)
        {
            try
            {
                string query = string.Format("delete from DauSach where MaDauSach = '{0}'",ma);
                DataProvider.Instance.ExecuteQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<DauSach_DTO> TimKiemDauSach(string ten)
        {
            List<DauSach_DTO> DanhSachDauSach = new List<DauSach_DTO>();
            
            DataTable data = DataProvider.Instance.ExecuteQuery("TimKiemDauSach @param",new object[] { ten});
            foreach (DataRow item in data.Rows)
            {
                DauSach_DTO DauSach = new DauSach_DTO(item);
                DanhSachDauSach.Add(DauSach);
            }
            return DanhSachDauSach;
        }
    }
}

