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
        public DateTime NgayNhanChuc { get; set; }

    }
}
