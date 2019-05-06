using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;
using System.Data;

namespace QLHS.DAO
{
    public class Lop_DAO
    {
        private static Lop_DAO instance;
        public static Lop_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Lop_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<Lop_DTO> LayTatCaLop()
        {
            List<Lop_DTO> dsLop = new List<Lop_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select Lop.*,TenKhoi from Lop join Khoi on Khoi.MaKhoi = Lop.MaKhoi");
            foreach(DataRow row in data.Rows)
            {
                Lop_DTO lop = new Lop_DTO(row);
                dsLop.Add(lop);
            }
            return dsLop;
        }
    }
}
