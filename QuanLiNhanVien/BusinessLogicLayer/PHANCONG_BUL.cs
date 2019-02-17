using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class PHANCONG_BUL
    {
        public static List<PHANCONG_DTO> LoadTatCaPhanCong()
        {
            return PHANCONG_DAL.LoadTatCaPhanCong();
        }

        public static int XoaPhanCong(PHANCONG_DTO pcDTO)
        {
            return PHANCONG_DAL.XoaPhanCong(pcDTO);
        }

        public static int ThemPhanCong(PHANCONG_DTO pcDTO)
        {
            return PHANCONG_DAL.ThemPhanCong(pcDTO);
        }

        public static int CapNhatPhanCong(PHANCONG_DTO pcDTO)
        {
            return PHANCONG_DAL.CapNhatPhanCong(pcDTO);
        }

        public static List<PHANCONG_DTO> TimKiemPhanCongTheoNhanVien(string searchStr)
        {
            return PHANCONG_DAL.TimKiemPhanCongTheoNhanVien(searchStr);
        }
    }
}
