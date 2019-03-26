using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class PHONGBAN_DTO
    {
        public Nullable<int> MaPB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> MaTP { get; set; }
        public Nullable<DateTime> NgayNhanChuc { get; set; }
        public string TenTP { get; set; }
        public PHONGBAN_DTO()
        {
            MaPB = null;
            TenPB = "";
            MaTP = null;
            TenTP = "";
            NgayNhanChuc = null;
        }
    }
}
