using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class DUAN_BUL
    {

        public static List<DUAN_DTO> LoadTatCaDuAn()
        {
            var lstDuAn = DUAN_DAL.LoadTatCaDuAn();
            for (int i = 0; i < lstDuAn.Count; i++)
            {
                if (lstDuAn[i].MaPB == 0)
                {
                    lstDuAn[i].TenDA = " Chưa thuộc phòng ban ";
                }
            }
            return lstDuAn;
        }

        public static int XoaDuAn(int maDA)
        {
            return DUAN_DAL.XoaDuAn(maDA);
        }


        public static int CapNhatDuAn(DUAN_DTO daDTO)
        {
            return DUAN_DAL.CapNhatDuAn(daDTO);
        }
    }
}


