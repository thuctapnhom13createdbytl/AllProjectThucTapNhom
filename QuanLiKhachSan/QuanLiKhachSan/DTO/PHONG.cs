namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            CHITIETPHIEUTHUEs = new HashSet<CHITIETPHIEUTHUE>();
        }

        [Key]
        public int MaPhong { get; set; }

        public int MaLoaiPhong { get; set; }

        public int MaLoaiTinhTrang { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUTHUE> CHITIETPHIEUTHUEs { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        public virtual LOAITINHTRANG LOAITINHTRANG { get; set; }
    }
}
