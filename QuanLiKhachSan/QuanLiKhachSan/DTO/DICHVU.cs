namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        [Key]
        public int MaDichVu { get; set; }

        public int MaLoaiDichVu { get; set; }

        public int MaDonVi { get; set; }

        public double? DonGia { get; set; }

        public string TenHienThi
        {
            get
            {
                return LOAIDICHVU.TenLoaiDichVu + " - " + DonGia; 
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual DONVI DONVI { get; set; }

        public virtual LOAIDICHVU LOAIDICHVU { get; set; }
    }
}
