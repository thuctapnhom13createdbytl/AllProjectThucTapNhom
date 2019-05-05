using System;
using System.Collections.Generic;
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
    }
}
