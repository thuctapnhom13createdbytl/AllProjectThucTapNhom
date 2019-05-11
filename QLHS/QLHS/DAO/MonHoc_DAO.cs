using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;
using System.Data;

namespace QLHS.DAO
{
    public class MonHoc_DAO
    {
        private static MonHoc_DAO instance;
        public static MonHoc_DAO Instance
        {
            get
            {
                if (instance == null) instance = new MonHoc_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<MonHoc_DTO> LayTatCaMonHoc()
        {
            List<MonHoc_DTO> DSMH = new List<MonHoc_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from MonHoc");
            foreach(DataRow item in data.Rows)
            {
                MonHoc_DTO mh = new MonHoc_DTO(item);
                DSMH.Add(mh);
            }
            return DSMH;
        }

        public List<MonHoc_DTO> LayTatCaMonHoc_Diem()
        {
            List<MonHoc_DTO> dsMonHoc_Diem = new List<MonHoc_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT DISTINCT dbo.MonHoc.MaMonHoc, dbo.MonHoc.TenMonHoc FROM dbo.MonHoc LEFT JOIN dbo.DiemMon ON DiemMon.MaMonHoc = MonHoc.MaMonHoc");
            foreach (DataRow item in data.Rows)
            {
                MonHoc_DTO monhoc_diem = new MonHoc_DTO(item);
                dsMonHoc_Diem.Add(monhoc_diem);
            }
            return dsMonHoc_Diem;
        }
    }
}
