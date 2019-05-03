using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class GiaoVien_DAO
    {
        private static GiaoVien_DAO instance;
        public static GiaoVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new GiaoVien_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
    }
}
