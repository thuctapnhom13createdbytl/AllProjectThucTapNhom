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
        public static List<PHONGBAN_DTO> LoadTatCaPhongBan()
        {
            try
            {
                List<PHONGBAN_DTO> lstPhongBan = new List<PHONGBAN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadTatCaPhongBan";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
                    int MaTP;
                    pbDTO.MaPB = int.Parse(reader["MaPB"].ToString());
                    pbDTO.TenPB = reader["TenPB"].ToString();
                    pbDTO.MaTP = int.TryParse(reader["MaTP"].ToString(), out MaTP) == true ? MaTP : 0;
                    pbDTO.NgayNhanChuc = (DateTime)reader["NgayNhanChuc"];
                    pbDTO.TenTP = reader["TenTP"].ToString();
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

        public static List<PHONGBAN_DTO> TimKiemPhongBan(string seachStr)
        {
            try
            {
                List<PHONGBAN_DTO> lstPHONGBAN = new List<PHONGBAN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select pb.MaPB, pb.TenPB, pb.MaTP, pb.NgayNhanChuc" +
                                   " from PHONGBAN pb " +
                                   "where pb.TenPB LIKE " + "N'%" + seachStr + "%'";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
                    int MaTP;
                    pbDTO.MaPB = int.Parse(reader["MaPB"].ToString());
                    pbDTO.TenPB = reader["TenPB"].ToString();
                    pbDTO.MaTP = int.TryParse(reader["MaTP"].ToString(), out MaTP) == true ? MaTP : 0;
                    pbDTO.NgayNhanChuc = (DateTime)reader["NgayNhanChuc"];
                    lstPHONGBAN.Add(pbDTO);
                }
                reader.Close();
                return lstPHONGBAN;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int CapNhatPhongBan(PHONGBAN_DTO pbDTO)
        {
            try
            {
                if(pbDTO.MaPB == 0) // Thêm mới phong ban
                {
                    string setMaTP = pbDTO.MaTP == 0 ? "NULL" : pbDTO.MaTP.ToString();
                    DateTime ngayNhanChuc = (DateTime)pbDTO.NgayNhanChuc;
                    string setDate = ngayNhanChuc.ToString("yyyyMMdd");
                    SqlConnection db = DataProvider.dbContext;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO PHONGBAN ( TenPB , MaTP, NgayNhanChuc) " +
                                       " VALUES (N'" + pbDTO.TenPB + "'," + setMaTP + "," +
                                       " '" + setDate + "')";
                    cmd.Connection = db;
                    return cmd.ExecuteNonQuery();
                }
                else
                {
                    string setMaTP = pbDTO.MaTP == 0 ? "NULL" : pbDTO.MaTP.ToString();
                    DateTime ngayNhanChuc = (DateTime)pbDTO.NgayNhanChuc;
                    string setDate = ngayNhanChuc.ToString("yyyyMMdd");
                    SqlConnection db = DataProvider.dbContext;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " UPDATE PHONGBAN SET TenPB = " + " N'" + pbDTO.TenPB + "'," +
                                      "MaTP = " + setMaTP + "," +
                                      " NgayNhanChuc = '" + setDate + "' WHERE MaPB = " + pbDTO.MaPB;
                    cmd.Connection = db;
                    return cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                return -1;
            }
        }
        public static List<PHONGBAN_DTO> LoadComboBoxPhongBan()
        {
            try
            {
                List<PHONGBAN_DTO> lstPhongBan = new List<PHONGBAN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadComboBoxTenTruongPhong";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
                    pbDTO.MaTP = int.Parse(reader["MaNV"].ToString());
                    pbDTO.TenTP = reader["HoTen"].ToString();
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

        public static int XoaPhongBan(int maPB)
        {
            try
            {
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaPhongBanTheoMa";
                cmd.Parameters.Add("@maPB", SqlDbType.Int).Value = maPB;
                cmd.Connection = db;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }

}
