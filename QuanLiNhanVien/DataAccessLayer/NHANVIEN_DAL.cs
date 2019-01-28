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
    public class NHANVIEN_DAL
    {
        public static List<NHANVIEN_DTO> LoadTatCaNhanVien()
        {
            try
            {
                List<NHANVIEN_DTO> lstNhanVien = new List<NHANVIEN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadAllNhanVien";
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
                    int MaNGS;
                    int MaPB;
                    nvDTO.MaNV = int.Parse(reader["MaNV"].ToString());
                    nvDTO.Hoten = reader["HoTen"].ToString();
                    nvDTO.NgaySinh = (DateTime)reader["NgaySinh"];
                    nvDTO.Luong = (decimal)reader["Luong"];
                    nvDTO.MaNGS = int.TryParse(reader["MaNGS"].ToString(), out MaNGS) == true ? MaNGS : 0;
                    nvDTO.MaPB = int.TryParse(reader["MaPB"].ToString(), out MaPB) == true ? MaPB : 0;
                    nvDTO.DiaChi = reader["DiaChi"].ToString();
                    nvDTO.TenNGS = reader["TenNGS"].ToString();
                    nvDTO.GioiTinh = reader["GioiTinh"].ToString();
                    nvDTO.TenPB = reader["TenPB"].ToString();
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

        public static List<NHANVIEN_DTO> TimKiemNhanVien(string searchStr)
        {
            try
            {
                List<NHANVIEN_DTO> lstNhanVien = new List<NHANVIEN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT nv.MaNV, nv.Hoten, nv.NgaySinh, nv.DiaChi, nv.GioiTinh, nv.Luong, pb.MaPB, pb.TenPB, gs.MaNV AS MaNGS, gs.Hoten AS TenNGS" +

                                    " FROM NHANVIEN nv LEFT JOIN PHONGBAN pb ON nv.MaPB = pb.MaPB" +

                                    " LEFT JOIN NHANVIEN gs ON nv.MaNGS = gs.MaNV" +

                                    " WHERE nv.Hoten LIKE " + "N'%" + searchStr + "%'";
                //cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = searchStr;
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
                    int MaNGS;
                    int MaPB;
                    nvDTO.MaNV = int.Parse(reader["MaNV"].ToString());
                    nvDTO.Hoten = reader["HoTen"].ToString();
                    nvDTO.NgaySinh = (DateTime)reader["NgaySinh"];
                    nvDTO.Luong = (decimal)reader["Luong"];
                    nvDTO.MaNGS = int.TryParse(reader["MaNGS"].ToString(), out MaNGS) == true ? MaNGS : 0;
                    nvDTO.MaPB = int.TryParse(reader["MaPB"].ToString(), out MaPB) == true ? MaPB : 0;
                    nvDTO.DiaChi = reader["DiaChi"].ToString();
                    nvDTO.TenNGS = reader["TenNGS"].ToString();
                    nvDTO.GioiTinh = reader["GioiTinh"].ToString();
                    nvDTO.TenPB = reader["TenPB"].ToString();
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

        public static int CapNhatNhanVien(NHANVIEN_DTO nvDTO)
        {
            try
            {
                if (nvDTO.MaNV == 0) //Thêm mới nhân viên
                {
                    //nvDTO.MaPB = nvDTO.MaPB == 0 ? null : nvDTO.MaPB;
                    //nvDTO.MaNGS = nvDTO.MaNGS == 0 ? null : nvDTO.MaNGS;
                    string setNGS = nvDTO.MaNGS == 0 ? "NULL" : nvDTO.MaNGS.ToString();
                    string setPB = nvDTO.MaPB == 0 ? "NULL" : nvDTO.MaPB.ToString();
                    DateTime ngaySinh = (DateTime)nvDTO.NgaySinh;
                    string setDate = ngaySinh.ToString("yyyyMMdd");
                    SqlConnection db = DataProvider.dbContext;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO NHANVIEN ( HoTen , NgaySinh, DiaChi, GioiTinh, Luong, MaPB, MaNGS)" + 
                                      " VALUES ( N'" + nvDTO.Hoten + "', '" + setDate  + "'," +
                                      " N'" + nvDTO.DiaChi + "', " + " N'" + nvDTO.GioiTinh + "', " +
                                      nvDTO.Luong + ", " + setPB + ", " + setNGS + " )";
                    cmd.Connection = db;
                    return cmd.ExecuteNonQuery();
                }
                else
                {
                    string setNGS = nvDTO.MaNGS == 0 ? "NULL" : nvDTO.MaNGS.ToString();
                    string setPB = nvDTO.MaPB == 0 ? "NULL" : nvDTO.MaPB.ToString();
                    DateTime ngaySinh = (DateTime)nvDTO.NgaySinh;
                    string setDate = ngaySinh.ToString("yyyyMMdd");
                    SqlConnection db = DataProvider.dbContext;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE NHANVIEN SET HoTen = " + " N'" + nvDTO.Hoten + "', " +
                                      "NgaySinh = '" + setDate + "', " +
                                      "GioiTinh = '" + nvDTO.GioiTinh + "', " +
                                      "DiaChi = N'" + nvDTO.DiaChi + "', " +
                                      "Luong = '" + nvDTO.Luong + "', " +
                                      "MaPB = " + setPB + ", " +
                                      "MaNGS = " + setNGS + " WHERE MaNV = " + nvDTO.MaNV;
                    cmd.Connection = db;
                    return cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public static List<NHANVIEN_DTO> LoadComboBoxNGS()
        {
            try
            {
                List<NHANVIEN_DTO> lstNhanVien = new List<NHANVIEN_DTO>();
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadComboBoxNGS";
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

        public static int XoaNhanVien(int maNV)
        {
            try
            {
                SqlConnection db = DataProvider.dbContext;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaNhanVienTheoMa";
                cmd.Parameters.Add("@maNV", SqlDbType.Int).Value = maNV;
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
