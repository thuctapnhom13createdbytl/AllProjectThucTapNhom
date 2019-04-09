using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class NhaXuatBan_DAO
    {
        private static NhaXuatBan_DAO instance;
        public static NhaXuatBan_DAO Instance
        {
            get { if (instance == null) instance = new NhaXuatBan_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhaXuatBan_DTO> LayTatCaNXB()
        {
            List<NhaXuatBan_DTO> DanhSachNXB = new List<NhaXuatBan_DTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhaXuatBan");
            foreach (DataRow item in data.Rows)
            {
                NhaXuatBan_DTO NXB = new NhaXuatBan_DTO(item);
                DanhSachNXB.Add(NXB);
            }
            return DanhSachNXB;
        }
        public List<NhaXuatBan_DTO> TimKiemNXB(string param)
        {
            List<NhaXuatBan_DTO> DanhSachNXB = new List<NhaXuatBan_DTO>();
            string query = string.Format("select * from NhaXuatBan where MaNXB like N'%{0}%' or TenNXB like N'%{0}%' or DiaChi like N'%{0}%'", param);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhaXuatBan_DTO NXB = new NhaXuatBan_DTO(item);
                DanhSachNXB.Add(NXB);
            }
            return DanhSachNXB;
        }
    }

}


