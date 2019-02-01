using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class THANNHAN_DTO
    {
        public Nullable<int> MaNV { get; set; }
        public string TenTN { get; set; }
        public string GioiTinh { get; set; }
        public string QuanHe { get; set; }
        public Nullable<DateTime> NgaySinh { get; set; }
        public THANNHAN_DTO()
        {
            this.MaNV = null;
            this.TenTN = "";
            this.GioiTinh = "";
            this.QuanHe = "";
            this.NgaySinh = null;
        }
    }
}
