using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class GVCN_DAO
    {
        private static GVCN_DAO instance;
        public static GVCN_DAO Instance
        {
            get
            {
                if (instance == null) instance = new GVCN_DAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
    }
}
