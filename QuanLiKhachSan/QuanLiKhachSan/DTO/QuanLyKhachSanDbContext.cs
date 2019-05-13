namespace QuanLiKhachSan.DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyKhachSanDbContext : DbContext
    {
        public QuanLyKhachSanDbContext()
            : base("name=QuanLyKhachSanDbContext")
        {
        }

        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETPHIEUTHUE> CHITIETPHIEUTHUEs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<DONVI> DONVIs { get; set; }
        public virtual DbSet<HOADONTHUE> HOADONTHUEs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIDICHVU> LOAIDICHVUs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<LOAITINHTRANG> LOAITINHTRANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONVI>()
                .HasMany(e => e.DICHVUs)
                .WithRequired(e => e.DONVI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONTHUE>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADONTHUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUTHUEPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIDICHVU>()
                .HasMany(e => e.DICHVUs)
                .WithRequired(e => e.LOAIDICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.THIETBIs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAITINHTRANG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAITINHTRANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHUEPHONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .HasMany(e => e.CHITIETPHIEUTHUEs)
                .WithRequired(e => e.PHIEUTHUEPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .HasMany(e => e.HOADONTHUEs)
                .WithRequired(e => e.PHIEUTHUEPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CHITIETPHIEUTHUEs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);
        }
    }
}
