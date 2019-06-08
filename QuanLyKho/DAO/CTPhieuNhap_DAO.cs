using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    public class CTPhieuNhap_DAO
    {
        private static CTPhieuNhap_DAO instance;
        public static CTPhieuNhap_DAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuNhap_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<CTPhieuNhap_DTO> LayPhieuNhapTheoMa(int MaPN)
        {
            List<CTPhieuNhap_DTO> ds = new List<CTPhieuNhap_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("LayCTPhieuNhapTheoMa @MaPN",new object[] { MaPN });
            foreach (DataRow item in data.Rows)
            {
                CTPhieuNhap_DTO nhapHang = new CTPhieuNhap_DTO(item);
                ds.Add(nhapHang);
            }
            return ds;
        }

        public bool ThemCTPhieuNhap(int MaPN, int MaSanPham,int SoLuong, decimal DonGia)
        {
            try
            {
                string query = string.Format("insert into CT_PhieuNhap(Ma_PN,Ma_Sanpham,SoLuong,DonGia) values ({0},{1},{2},{3})", MaPN, MaSanPham, SoLuong, DonGia);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
