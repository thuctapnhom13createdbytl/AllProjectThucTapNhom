using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKho.DTO
{
    public class NhaSanXuat_DTO
    {
        public int Ma_NSX { get; set; }
        public string Ten_NSX { get; set; }
        public string DiaChi_NSX { get; set; }
        public string SDT_NSX { get; set; }
        public string Website_NSX { get; set; }

        public NhaSanXuat_DTO ()
        {
            Ma_NSX = 0;
            Ten_NSX = "";
            DiaChi_NSX = "";
            SDT_NSX = "";
            Website_NSX = "";
        }

        public NhaSanXuat_DTO (DataRow dr)
        {
            Ma_NSX = (int)dr["Ma_NSX"];
            Ten_NSX = (string)dr["Ten_NSX"];
            DiaChi_NSX = (string)dr["DiaChi_NSX"];
            SDT_NSX = (string)dr["SDT_NSX"];
            Website_NSX = (string)dr["Website_NSX"];
        }
    }
}
