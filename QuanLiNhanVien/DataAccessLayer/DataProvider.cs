using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DataProvider
    {
        private static SqlConnection con = null;
        public static SqlConnection dbContext
        {
            get
            {
                string conStr = "Data Source=(local);Initial Catalog=TTN_QLNV;Integrated Security=True";
                if (con == null)
                {
                    con = new SqlConnection(conStr);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
        }
    }
}
