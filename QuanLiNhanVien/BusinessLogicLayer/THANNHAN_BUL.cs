using BusinessLogicLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class THANNHAN_BUL
    {
        public static List<THANNHAN_DTO> layTatCaThanNhan()
        {
            var listTN = THANNHAN_DAL.layTatCaThanNhan();
            for (int i = 0; i < listTN.Count; i++)
            {
                if (listTN[i].QuanHe == "")
                {
                    listTN[i].QuanHe = "không có quan hệ với nhân viên nào";
                }
            }
            return listTN;
        }
        public static List<NHANVIEN_DTO> LoadComboBoxNV()
        {
            List<NHANVIEN_DTO> lstNhanVien = THANNHAN_DAL.LoadComboBoxNV();
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
            nvDTO.MaNV = 0;
            nvDTO.Hoten = "Chưa có nhân viên";
            lstNhanVien.Insert(0, nvDTO);
            return lstNhanVien;
        }
    }
}
