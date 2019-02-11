using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class THANNHAN_DAL
    {
        public static List<THANNHAN_DTO> layTatCaThanNhan()
        {
            try
            {
                List<THANNHAN_DTO> listTN = new List<THANNHAN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TN_loadAll";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    THANNHAN_DTO tnDTO = new THANNHAN_DTO();
                    tnDTO.MaNV = int.Parse(reader["MaNV"].ToString());
                    tnDTO.TenTN = reader["TenTN"].ToString();
                    tnDTO.GioiTinh = reader["GioiTinh"].ToString();
                    tnDTO.QuanHe = reader["QuanHe"].ToString();
                    tnDTO.NgaySinh = (DateTime)reader["NgaySinh"];
                    tnDTO.tenNV = reader["HoTen"].ToString();
                    listTN.Add(tnDTO);
                }
                reader.Close();
                return listTN;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static List<NHANVIEN_DTO> LoadComboBoxNV()
        {
            try
            {
                List<NHANVIEN_DTO> lstNhanVien = new List<NHANVIEN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadComboBoxNV";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
                    nvDTO.MaNV = int.Parse(reader["MaNV"].ToString());
                    nvDTO.Hoten = reader["HoTen"].ToString();
                    lstNhanVien.Add(nvDTO);
                }
                reader.Close();
                return lstNhanVien;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
