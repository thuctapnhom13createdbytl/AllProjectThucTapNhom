namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            PHONGs = new HashSet<PHONG>();
            THIETBIs = new HashSet<THIETBI>();
        }

        [Key]
        public int MaLoaiPhong { get; set; }

        [StringLength(50)]
        public string TenLoaiPhong { get; set; }

        public double? DonGia { get; set; }

        public int? SoNguoiTieuChuan { get; set; }

        public int? SoNguoiToiDa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THIETBI> THIETBIs { get; set; }
    }
}
