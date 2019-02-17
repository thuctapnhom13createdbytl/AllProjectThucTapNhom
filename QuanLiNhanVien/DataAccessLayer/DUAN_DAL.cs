using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DUAN_DAL
    {
        public static List<DUAN_DTO> LoadComboBoxDuAn()
        {
            try
            {
                List<DUAN_DTO> lstDuAn = new List<DUAN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadComboBoxDuAn";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DUAN_DTO daTO = new DUAN_DTO();
                    daTO.MaDA = int.Parse(reader["MaDA"].ToString());
                    daTO.TenDA = reader["TenDA"].ToString();
                    lstDuAn.Add(daTO);
                }
                reader.Close();
                return lstDuAn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
