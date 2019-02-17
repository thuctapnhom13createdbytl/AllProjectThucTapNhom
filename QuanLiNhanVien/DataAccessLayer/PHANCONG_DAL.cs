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
    public class PHANCONG_DAL
    {
        public static List<PHANCONG_DTO> LoadTatCaPhanCong()
        {
            try
            {
                List<PHANCONG_DTO> lstPhanCong = new List<PHANCONG_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadTatCaPhanCongDuAn";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PHANCONG_DTO pcDTO = new PHANCONG_DTO();
                    pcDTO.MaNV = int.Parse(reader["MaNV"].ToString());
                    pcDTO.HoTen = reader["HoTen"].ToString();
                    pcDTO.MaDA = int.Parse(reader["MaDA"].ToString());
                    pcDTO.SoGio = int.Parse(reader["SoGio"].ToString());
                    pcDTO.TenDA = reader["TenDA"].ToString();
                    lstPhanCong.Add(pcDTO);
                }
                reader.Close();
                return lstPhanCong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int XoaPhanCong(PHANCONG_DTO pcDTO)
        {
            try
            {
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaPhanCongDuAn";
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = pcDTO.MaNV;
                cmd.Parameters.Add("@MaDA", SqlDbType.Int).Value = pcDTO.MaDA;
                cmd.Connection = db;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static int ThemPhanCong(PHANCONG_DTO pcDTO)
        {
            try
            {
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemPhanCong";
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = pcDTO.MaNV;
                cmd.Parameters.Add("@MaDA", SqlDbType.Int).Value = pcDTO.MaDA;
                cmd.Parameters.Add("@SoGio", SqlDbType.Int).Value = pcDTO.SoGio;
                cmd.Connection = db;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static int CapNhatPhanCong(PHANCONG_DTO pcDTO)
        {
            try
            {
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CapNhatPhanCong";
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = pcDTO.MaNV;
                cmd.Parameters.Add("@MaDA", SqlDbType.Int).Value = pcDTO.MaDA;
                cmd.Parameters.Add("@SoGio", SqlDbType.Int).Value = pcDTO.SoGio;
                cmd.Connection = db;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static List<PHANCONG_DTO> TimKiemPhanCongTheoNhanVien(string searchStr)
        {
            try
            {
                List<PHANCONG_DTO> lstPhanCong = new List<PHANCONG_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT nv.MaNV, nv.HoTen, da.MaDA, da.TenDA, pc.SoGio" +

                                    " FROM NHANVIEN nv INNER JOIN PHANCONG pc ON nv.MaNV = pc.MaNV" +

                                    " INNER JOIN DUAN da ON da.MaDA = pc.MaDA" +

                                    " WHERE nv.Hoten LIKE " + "N'%" + searchStr + "%'";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PHANCONG_DTO pcDTO = new PHANCONG_DTO();
                    pcDTO.MaNV = int.Parse(reader["MaNV"].ToString());
                    pcDTO.HoTen = reader["HoTen"].ToString();
                    pcDTO.MaDA = int.Parse(reader["MaDA"].ToString());
                    pcDTO.SoGio = int.Parse(reader["SoGio"].ToString());
                    pcDTO.TenDA = reader["TenDA"].ToString();
                    lstPhanCong.Add(pcDTO);
                }
                reader.Close();
                return lstPhanCong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
