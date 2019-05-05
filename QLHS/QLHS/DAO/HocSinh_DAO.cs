using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class HocSinh_DAO
    {
        private static HocSinh_DAO instance;
        public static HocSinh_DAO Instance
        {
            get
            {
                if (instance == null) instance = new HocSinh_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
    }
}
