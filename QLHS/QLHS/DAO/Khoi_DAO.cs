using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class Khoi_DAO
    {
        private static Khoi_DAO instance;
        public static Khoi_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Khoi_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
    }
}
