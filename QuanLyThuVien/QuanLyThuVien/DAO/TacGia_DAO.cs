using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class TacGia_DAO
    {
        private static TacGia_DAO instance;
        public static TacGia_DAO Instance
        {
            get { if (instance == null) instance = new TacGia_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<TacGia_DTO> LayTatCaTacGia()
        {
            List<TacGia_DTO> DanhSachTG = new List<TacGia_DTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TacGia");
            foreach (DataRow item in data.Rows)
            {
                TacGia_DTO TG = new TacGia_DTO(item);
                DanhSachTG.Add(TG);
            }
            return DanhSachTG;
        }
        public List<TacGia_DTO> TimKiemTG(string param)
        {
            List<TacGia_DTO> DanhSachTG = new List<TacGia_DTO>();
            string query = string.Format("select * from TacGia where MaTacGia like N'%{0}%' or TenTacGia like N'%{0}%' or DiaChi like N'%{0}%' or SDT like '%{0}%'", param);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TacGia_DTO TG = new TacGia_DTO(item);
                DanhSachTG.Add(TG);
            }
            return DanhSachTG;
        }
    }


}

