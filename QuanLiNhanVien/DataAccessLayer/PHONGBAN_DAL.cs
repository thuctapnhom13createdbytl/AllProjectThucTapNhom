using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class PHONGBAN_DAL
    {
        public static List<PHONGBAN_DTO> LoadComboBoxPhongBan()
        {
            try
            {
                List<PHONGBAN_DTO> lstPhongBan = new List<PHONGBAN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadComboBoxPhongBan";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
                    pbDTO.MaPB = int.Parse(reader["MaPB"].ToString());
                    pbDTO.TenPB = reader["TenPB"].ToString();
                    lstPhongBan.Add(pbDTO);
                }
                reader.Close();
                return lstPhongBan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
