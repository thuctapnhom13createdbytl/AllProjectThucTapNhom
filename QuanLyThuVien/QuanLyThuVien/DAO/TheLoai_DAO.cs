using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class TheLoai_DAO
    {
        private static TheLoai_DAO instance;
        public static TheLoai_DAO Instance
        {
            get { if (instance == null) instance = new TheLoai_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<TheLoai_DTO> LayTatCaTheLoai()
        {
            List<TheLoai_DTO> DanhSachTheLoai = new List<TheLoai_DTO>();

                DataTable data = DataProvider.Instance.ExecuteQuery("select * from TheLoai");
                foreach (DataRow item in data.Rows)
                {
                    TheLoai_DTO TL = new TheLoai_DTO(item);
                    DanhSachTheLoai.Add(TL);
                }
            return DanhSachTheLoai;
        }
        public List<TheLoai_DTO> TimKiemTheLoai(string param)
        {
            List<TheLoai_DTO> DanhSachTheLoai = new List<TheLoai_DTO>();
            string query = string.Format("select * from TheLoai where MaTheLoai like N'%{0}%' or TenTheLoai like N'%{0}%'",param);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheLoai_DTO TL = new TheLoai_DTO(item);
                DanhSachTheLoai.Add(TL);
            }
            return DanhSachTheLoai;
        }
    }

}


