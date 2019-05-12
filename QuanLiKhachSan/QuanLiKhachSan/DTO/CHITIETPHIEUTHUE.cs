namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUTHUE")]
    public partial class CHITIETPHIEUTHUE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuThue { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhong { get; set; }

        public DateTime? NgayThuePhong { get; set; }

        public DateTime? NgayTraPhong { get; set; }

        public virtual PHIEUTHUEPHONG PHIEUTHUEPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
