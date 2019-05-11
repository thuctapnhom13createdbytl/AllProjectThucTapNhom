using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;
using System.Data;
using QLHS.DAO;

namespace QLHS.DAO
{
    public class HocKi_DAO
    {
        private static HocKi_DAO instance;
        public static HocKi_DAO Instance
        {
            get
            {
                if (instance == null) instance = new HocKi_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<HocKi_DTO> LoadTatCaHocKi_Diem()
        {
            List<HocKi_DTO> dsHocKi_Diem = new List<HocKi_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT DISTINCT dbo.HocKi.MaHocKy,dbo.HocKi.TenHocKy FROM dbo.HocKi LEFT JOIN dbo.DiemMon ON DiemMon.MaHocKy = HocKi.MaHocKy");
            foreach( DataRow item in data.Rows)
            {
                HocKi_DTO hocki_diem = new HocKi_DTO(item);
                dsHocKi_Diem.Add(hocki_diem);
            }
            return dsHocKi_Diem;
        }
    }
}
