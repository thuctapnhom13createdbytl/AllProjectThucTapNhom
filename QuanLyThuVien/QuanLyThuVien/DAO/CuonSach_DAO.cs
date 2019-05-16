using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{

    public class CuonSach_DAO
    {
        private static CuonSach_DAO instance;
        public static CuonSach_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CuonSach_DAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<CuonSach_DTO> LoadTatCaCuonSach()
        {

            try
            {
                List<CuonSach_DTO> lstCuonSach = new List<CuonSach_DTO>();

                string query = "SELECT cs.*, ds.TenDauSach FROM CuonSach cs INNER JOIN DauSach ds ON cs.MaDauSach = ds.MaDauSach";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    CuonSach_DTO cs = new CuonSach_DTO(item);
                    lstCuonSach.Add(cs);
                }

                return lstCuonSach;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal List<CuonSach_DTO> LoadCuonSachCuaPhieuMuon(string soPhieuMuon)
        {
            try
            {
                List<CuonSach_DTO> lstCuonSach = new List<CuonSach_DTO>();

                string query = "SELECT cs.* FROM dbo.CuonSach cs INNER JOIN dbo.ThongTinMuonTra tt ON tt.MaCuonSach = cs.MaCuonSach WHERE tt.SoPhieuMuon = '" + soPhieuMuon + "'";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    CuonSach_DTO cs = new CuonSach_DTO(item);
                    lstCuonSach.Add(cs);
                }

                return lstCuonSach;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<CuonSach_DTO> LoadTatCaCuonSachCheckBoxList()
        {

            try
            {
                List<CuonSach_DTO> lstCuonSach = new List<CuonSach_DTO>();

                string query = "SELECT cs.*, ds.TenDauSach FROM CuonSach cs INNER JOIN DauSach ds ON cs.MaDauSach = ds.MaDauSach WHERE cs.TinhTrangSach = 1";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    CuonSach_DTO cs = new CuonSach_DTO(item);
                    lstCuonSach.Add(cs);
                }

                return lstCuonSach;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

}
