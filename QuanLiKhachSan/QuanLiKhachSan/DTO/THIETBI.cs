namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THIETBI")]
    public partial class THIETBI
    {
        [Key]
        public int MaThietBi { get; set; }

        [StringLength(250)]
        public string TenThietBi { get; set; }

        public int MaLoaiPhong { get; set; }

        public int? SoLuong { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }
    }
}
