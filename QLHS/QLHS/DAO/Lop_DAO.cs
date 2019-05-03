using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;

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
    }
}
