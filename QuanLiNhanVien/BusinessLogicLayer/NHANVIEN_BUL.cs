using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class NHANVIEN_BUL
    {
        public static List<NHANVIEN_DTO> LoadTatCaNhanVien()
        {
            List<NHANVIEN_DTO> lstNhanVien = NHANVIEN_DAL.LoadTatCaNhanVien();
            for(int i = 0; i < lstNhanVien.Count; i++)
            {
                if (lstNhanVien[i].MaNGS == 0)
                {
                    lstNhanVien[i].TenNGS = "Chưa Có Người Giám Sát";
                }
                if (lstNhanVien[i].MaPB == 0)
                {
                    lstNhanVien[i].TenPB = "Chưa Có Phòng Ban";
                }
            }
            return lstNhanVien;
        }
        public static List<NHANVIEN_DTO> LoadComboBoxNGS()
        {
            List<NHANVIEN_DTO> lstNhanVien = NHANVIEN_DAL.LoadComboBoxNGS();
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
            nvDTO.MaNV = 0;
            nvDTO.Hoten = "Chưa Có Người Giám Sát";
            lstNhanVien.Insert(0, nvDTO);
            return lstNhanVien;
        }

        public static List<NHANVIEN_DTO> TimKiemNhanVien(string searchStr)
        {
            var lstNhanVien = NHANVIEN_DAL.TimKiemNhanVien(searchStr);
            for (int i = 0; i < lstNhanVien.Count; i++)
            {
                if (lstNhanVien[i].MaNGS == 0)
                {
                    lstNhanVien[i].TenNGS = "Chưa Có Người Giám Sát";
                }
                if (lstNhanVien[i].MaPB == 0)
                {
                    lstNhanVien[i].TenPB = "Chưa Có Phòng Ban";
                }
            }
            return lstNhanVien;
        }

        public static int XoaNhanVien(int maNV)
        {
            return NHANVIEN_DAL.XoaNhanVien(maNV);
        }

        public static int CapNhatNhanVien(NHANVIEN_DTO nvDTO)
        {
            return NHANVIEN_DAL.CapNhatNhanVien(nvDTO);
        }
    }
}
