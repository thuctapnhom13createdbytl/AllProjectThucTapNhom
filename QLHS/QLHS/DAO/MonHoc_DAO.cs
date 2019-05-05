using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;

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
    }
}
