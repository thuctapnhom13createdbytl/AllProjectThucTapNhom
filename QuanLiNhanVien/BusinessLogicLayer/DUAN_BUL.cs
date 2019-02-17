using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DUAN_BUL
    {
        public static List<DUAN_DTO> LoadComboBoxDuAn()
        {
            return DUAN_DAL.LoadComboBoxDuAn();
        }
    }
}
