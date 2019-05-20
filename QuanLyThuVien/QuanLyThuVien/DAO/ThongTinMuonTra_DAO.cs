using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    public class ThongTinMuonTra_DAO
    {
        private static ThongTinMuonTra_DAO instance;
        public static ThongTinMuonTra_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinMuonTra_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        
        public List<ThongTinMuonTra_DTO> LoadTatCaThongTinMuonTra()
        {

            try
            {
                List<ThongTinMuonTra_DTO> lstThongTinMuonTra = new List<ThongTinMuonTra_DTO>();

                string query = "SELECT tt.*, ds.TenDauSach FROM ThongTinMuonTra tt INNER JOIN CuonSach cs ON tt.MaCuonSach = cs.MaCuonSach" +
                " INNER JOIN DauSach ds ON cs.MaDauSach = ds.MaDauSach";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    ThongTinMuonTra_DTO thongTin = new ThongTinMuonTra_DTO(item);
                    lstThongTinMuonTra.Add(thongTin);
                }

                return lstThongTinMuonTra;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ThemChiTietPhieuMuon(List<ThongTinMuonTra_DTO> lstThongTin)
        {
            try
            {
                string query = "INSERT dbo.ThongTinMuonTra (MaCuonSach, SoPhieuMuon, NgayTra, TinhTrangSach, MaViPham ) VALUES ";
                for(int i = 0; i < lstThongTin.Count; i++)
                {
                    ThongTinMuonTra_DTO tt = lstThongTin[i];
                    if (i < lstThongTin.Count - 1)
                    {
                        query += "('" + tt.MaCuonSach + "','" + tt.SoPhieuMuon + "', NULL, 100, NULL),";
                    }
                    else
                    {
                        query += "('" + tt.MaCuonSach + "','" + tt.SoPhieuMuon + "', NULL, 100, NULL)";
                    }
                }
                int kq = DataProvider.Instance.ExecuteNonQuery(query);
                return kq;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}


