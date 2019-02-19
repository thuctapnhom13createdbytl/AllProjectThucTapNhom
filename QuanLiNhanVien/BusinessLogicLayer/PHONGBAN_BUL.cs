using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class PHONGBAN_BUL
    {
        public static List<PHONGBAN_DTO> LoadTatCaPhongBan()
        {
            var lstPhongBan = PHONGBAN_DAL.LoadTatCaPhongBan();
            for(int i = 0; i < lstPhongBan.Count; i++)
            {
                if(lstPhongBan[i].MaTP == 0)
                {
                    lstPhongBan[i].TenTP = "Chưa Có Trưởng Phòng";
                }
            }
            return lstPhongBan;
        }

        public static List<PHONGBAN_DTO> LoadComboBoxPhongBan()
        {
            List<PHONGBAN_DTO> lstPhongBan = PHONGBAN_DAL.LoadComboBoxPhongBan();
            PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
            pbDTO.MaPB = 0;
            pbDTO.TenPB = "Chưa Có Phòng Ban";
            lstPhongBan.Insert(0, pbDTO);
            return lstPhongBan;
        }

        public static List<PHONGBAN_DTO> TimKiemPhongBan(string searchStr)
        {
            var lstPhongBan = PHONGBAN_DAL.TimKiemPhongBan(searchStr);
            for(int i =0;i<lstPhongBan.Count; i++)
            {
                if (lstPhongBan[i].MaTP == 0)
                {
                    lstPhongBan[i].TenPB = "Chưa Có Phòng Ban";
                }
            }
            return lstPhongBan;
        }

        public static int XoaPhongBan( int MaPB)
        {
            return PHONGBAN_DAL.XoaPhongBan(MaPB);
        }

        public static int CapNhatPhongBan(PHONGBAN_DTO pbDTO)
        {
            return PHONGBAN_DAL.CapNhatPhongBan(pbDTO);
        }
    }
}
