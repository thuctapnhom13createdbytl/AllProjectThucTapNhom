namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUEPHONG")]
    public partial class PHIEUTHUEPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHUEPHONG()
        {
            CHITIETPHIEUTHUEs = new HashSet<CHITIETPHIEUTHUE>();
            HOADONTHUEs = new HashSet<HOADONTHUE>();
        }

        [Key]
        public int MaPhieuThue { get; set; }

        public int MaKhachHang { get; set; }

        public int MaNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUTHUE> CHITIETPHIEUTHUEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONTHUE> HOADONTHUEs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
