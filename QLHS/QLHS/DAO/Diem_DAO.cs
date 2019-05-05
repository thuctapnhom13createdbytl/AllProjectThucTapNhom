using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class Diem_DAO
    {
        private static Diem_DAO instance;
        public static Diem_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Diem_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
    }
}
