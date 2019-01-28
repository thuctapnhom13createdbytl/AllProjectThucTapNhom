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
        public static List<PHONGBAN_DTO> LoadComboBoxPhongBan()
        {
            List<PHONGBAN_DTO> lstPhongBan = PHONGBAN_DAL.LoadComboBoxPhongBan();
            PHONGBAN_DTO pbDTO = new PHONGBAN_DTO();
            pbDTO.MaPB = 0;
            pbDTO.TenPB = "Chưa Có Phòng Ban";
            lstPhongBan.Insert(0, pbDTO);
            return lstPhongBan;
        }
    }
}
