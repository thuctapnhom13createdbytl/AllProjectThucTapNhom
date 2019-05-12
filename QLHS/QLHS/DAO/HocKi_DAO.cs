using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<HocKi_DTO> LayTatCahocKy()
        {
            List<HocKi_DTO> DSHK = new List<HocKi_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HocKi");
            foreach(DataRow item in data.Rows)
            {
                HocKi_DTO hk = new HocKi_DTO(item);
                DSHK.Add(hk);
            }
            return DSHK;
        }
    }
}
