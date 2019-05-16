using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class PhieuMuon_DAO
    {
        private static PhieuMuon_DAO instance;
        public static PhieuMuon_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuMuon_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<PhieuMuon_DTO> LoadTatCaPhieuMuuon()
        {

            try
            {
                List<PhieuMuon_DTO> lstPhieuMuon = new List<PhieuMuon_DTO>();

                string query = "SELECT pm.*, nv.HoTen AS TenNhanVien, dg.TenDocGia FROM dbo.PhieuMuon pm INNER JOIN " +
                    "NhanVien nv ON  nv.MaNhanVien = pm.MaNhanVien INNER JOIN DocGia dg ON dg.MaDocGia = pm.MaDocGia";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    PhieuMuon_DTO pm = new PhieuMuon_DTO(item);
                    lstPhieuMuon.Add(pm);
                }

                return lstPhieuMuon;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int XoaPhieuMuon(string soPhieuMuon)
        {
            try
            {
                int kq = DataProvider.Instance.ExecuteNonQuery("prc_Delete_PhieuMuon @SoPhieuMuon", new object[] { soPhieuMuon } );
                return kq;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int CapNhatPhieuMuon(PhieuMuon_DTO pm)
        {
            try
            {
                int kq = DataProvider.Instance.ExecuteNonQuery("prc_Update_PhieuMuon @NgayMuon , @NgayHenTra , @MaNhanVien , @MaDocGia , @SoPhieuMuon",
                    new object[] { pm.NgayMuon, pm.NgayHenTra, pm.MaNhanVien, pm.MaDocGia, pm.SoPhieuMuon });
                return kq;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int ThemPhieuMuon(PhieuMuon_DTO pm)
        {
            try
            {
                int kq = DataProvider.Instance.ExecuteNonQuery("prc_Insert_PhieuMuon @NgayMuon , @NgayHenTra , @MaNhanVien , @MaDocGia , @SoPhieuMuon",
                    new object[] { pm.NgayMuon, pm.NgayHenTra, pm.MaNhanVien, pm.MaDocGia, pm.SoPhieuMuon });
                return kq;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}

