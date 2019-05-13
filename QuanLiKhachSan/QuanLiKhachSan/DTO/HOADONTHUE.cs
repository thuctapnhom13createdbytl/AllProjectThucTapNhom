namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONTHUE")]
    public partial class HOADONTHUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONTHUE()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        [Key]
        public int MaHoaDon { get; set; }

        public int MaPhieuThue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLapHD { get; set; }

        public double? PhuThu { get; set; }

        public double? GiamGiaKH { get; set; }

        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }

        public double? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual PHIEUTHUEPHONG PHIEUTHUEPHONG { get; set; }
    }
}
