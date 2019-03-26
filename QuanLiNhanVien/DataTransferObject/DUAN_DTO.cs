using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DUAN_DTO
    {
        public Nullable<int> MaDA { get; set; }
        public string TenDA { get; set; }
        public string DiaDiem { get; set; }
        public Nullable<int> MaPB { get; set; }

        public DUAN_DTO()
        {
            MaDA = 0;
            TenDA = "";
            DiaDiem = "";
            MaPB = null;
        }
    }
}
