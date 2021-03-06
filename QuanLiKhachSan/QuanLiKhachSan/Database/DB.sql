USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 13/05/2019 1:02:13 AM ******/
CREATE DATABASE [QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLKS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLKS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKS', N'ON'
GO
USE [QLKS]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHoaDon] [int] NOT NULL,
	[MaDichVu] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUTHUE]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTHUE](
	[MaPhieuThue] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[NgayThuePhong] [datetime] NULL,
	[NgayTraPhong] [datetime] NULL,
 CONSTRAINT [PK_CHITIETPHIEUTHUE] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiDichVu] [int] NOT NULL,
	[MaDonVi] [int] NOT NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONVI]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVI](
	[MaDonVi] [int] IDENTITY(1,1) NOT NULL,
	[TenDonVi] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONVI] PRIMARY KEY CLUSTERED 
(
	[MaDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONTHUE]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONTHUE](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuThue] [int] NOT NULL,
	[NgayLapHD] [date] NULL,
	[PhuThu] [float] NULL,
	[GiamGiaKH] [float] NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_HOADONTHUE] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](150) NULL,
	[CMND] [varchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](250) NULL,
	[DienThoai] [varchar](20) NULL,
	[QuocTich] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIDICHVU]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDICHVU](
	[MaLoaiDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiDichVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIDICHVU] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MaLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[SoNguoiTieuChuan] [int] NULL,
	[SoNguoiToiDa] [int] NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAITINHTRANG]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITINHTRANG](
	[MaLoaiTinhTrang] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAITINHTRANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](250) NULL,
	[GioiTinh] [bit] NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUTHUEPHONG]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUEPHONG](
	[MaPhieuThue] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[MaNhanVien] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUTHUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiPhong] [int] NOT NULL,
	[MaLoaiTinhTrang] [int] NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THIETBI]    Script Date: 13/05/2019 1:02:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THIETBI](
	[MaThietBi] [int] IDENTITY(1,1) NOT NULL,
	[TenThietBi] [nvarchar](250) NULL,
	[MaLoaiPhong] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_THIETBI] PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaDichVu], [SoLuong]) VALUES (1, 1, NULL)
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (1, 3, CAST(N'2019-05-18 00:00:00.000' AS DateTime), CAST(N'2019-05-20 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (2, 8, CAST(N'2019-05-22 00:00:00.000' AS DateTime), CAST(N'2019-05-25 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (3, 14, CAST(N'2019-05-17 00:00:00.000' AS DateTime), CAST(N'2019-05-22 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (4, 18, CAST(N'2019-05-19 00:00:00.000' AS DateTime), CAST(N'2019-05-20 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (5, 2, CAST(N'2019-05-10 00:00:00.000' AS DateTime), CAST(N'2019-05-15 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (6, 7, CAST(N'2019-05-10 00:00:00.000' AS DateTime), CAST(N'2019-05-15 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (7, 12, CAST(N'2019-05-10 00:00:00.000' AS DateTime), CAST(N'2019-05-15 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (8, 16, CAST(N'2019-05-10 00:00:00.000' AS DateTime), CAST(N'2019-05-15 00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (12, 5, CAST(N'2019-05-13 02:40:32.000' AS DateTime), CAST(N'2019-05-16 02:40:32.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUTHUE] ([MaPhieuThue], [MaPhong], [NgayThuePhong], [NgayTraPhong]) VALUES (18, 1, CAST(N'2019-05-14 15:59:17.000' AS DateTime), CAST(N'2019-05-18 15:59:17.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[DICHVU] ON 

INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (1, 9, 2, 2500000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (2, 6, 11, 500000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (3, 1, 12, 100000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (4, 4, 5, 20000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (5, 7, 1, 50000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (6, 8, 1, 35000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (7, 11, 1, 30000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (8, 12, 1, 70000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (9, 17, 1, 15000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (10, 18, 1, 20000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (11, 14, 10, 9000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (12, 20, 10, 8500)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (13, 10, 9, 200000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (14, 19, 8, 30000)
INSERT [dbo].[DICHVU] ([MaDichVu], [MaLoaiDichVu], [MaDonVi], [DonGia]) VALUES (15, 16, 4, 35000)
SET IDENTITY_INSERT [dbo].[DICHVU] OFF
SET IDENTITY_INSERT [dbo].[DONVI] ON 

INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (1, N'Giặt là lấy ngay Trần Duy Hưng')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (2, N'Massage full service Trần Duy Hưng')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (3, N'Chuyển đồ nhanh Grab')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (4, N'FastFood Go')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (5, N'Photocopy Royal')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (7, N'Bia Hải Xồm 69 Trần Duy Hưng')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (8, N'Super Transporter')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (9, N'Karaoke Sóng Thần 48 Trần Duy Hưng')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (10, N'Bia Hải Xồm 69')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (11, N'ZaloTree Trần Duy Hưng')
INSERT [dbo].[DONVI] ([MaDonVi], [TenDonVi]) VALUES (12, N'KingOfWar Gaming')
SET IDENTITY_INSERT [dbo].[DONVI] OFF
SET IDENTITY_INSERT [dbo].[HOADONTHUE] ON 

INSERT [dbo].[HOADONTHUE] ([MaHoaDon], [MaPhieuThue], [NgayLapHD], [PhuThu], [GiamGiaKH], [HinhThucThanhToan], [TongTien]) VALUES (1, 6, CAST(N'2019-05-12' AS Date), 100000, 200000, N'Ghi nợ', 3040000)
SET IDENTITY_INSERT [dbo].[HOADONTHUE] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (1, N'Trần Viết Thanh', N'101291233', 0, N'Mỹ Đình, Hà Nội', N'0125684333', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (2, N'Trần Thị Lan Anh', N'101291001', 1, N'Bạch Mai, Hà Nội', N'0373358674', N'Thái Lan')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (3, N'Dương Thị Minh Nguyệt', N'101291238', 1, N'Khương Đình, Hà Nội', N'0362668851', N'Qatar')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (5, N'Đỗ Thị Quyên', N'101291025', 1, N'Xuân Thủy, Hà Nội', N'0369251235', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (6, N'Lê Thị Ngọc Hân', N'101291039', 1, N'Thanh Xuân, Hà Nội', N'0341568652', N'Hàn Quốc')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (7, N'Phạm Hùng Triều', N'101291656', 0, N'Nguyễn Xiển, Hà Nội', N'0382010469', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (8, N'Nguyễn Thành Đô', N'101291357', 0, N'Nguyễn Chí Thanh, Hà Nội', N'0385339113', N'Nhật Bản')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [CMND], [GioiTinh], [DiaChi], [DienThoai], [QuocTich]) VALUES (12, N'Nguyễn Thị Huyền', N'101291253', 0, N'Mỹ Đình, Hà Nội', N'0366666666', N'Sin-ga-po')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[LOAIDICHVU] ON 

INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (1, N'PUBG')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (2, N'Tập GYM')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (3, N'Tập Cardio')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (4, N'Photocopy tài liệu')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (5, N'Chăm sóc da')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (6, N'Bầu bạn đêm khuya')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (7, N'Giặt áo dài')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (8, N'Giặt quần jeans')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (9, N'Massage full service')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (10, N'Karaoke')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (11, N'Giặt váy ngắn')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (12, N'Giặt comple')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (13, N'Nước lọc')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (14, N'Bia 333')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (15, N'Wakeup 247')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (16, N'Cơm đùi gà')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (17, N'Ủi áo dài')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (18, N'Ủi comple')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (19, N'Chuyển phát nhanh')
INSERT [dbo].[LOAIDICHVU] ([MaLoaiDichVu], [TenLoaiDichVu]) VALUES (20, N'Tiger Bear')
SET IDENTITY_INSERT [dbo].[LOAIDICHVU] OFF
SET IDENTITY_INSERT [dbo].[LOAIPHONG] ON 

INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [SoNguoiTieuChuan], [SoNguoiToiDa]) VALUES (1, N'Đặc biệt', 720000, 2, 4)
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [SoNguoiTieuChuan], [SoNguoiToiDa]) VALUES (2, N'Loại I', 320000, 2, 4)
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [SoNguoiTieuChuan], [SoNguoiToiDa]) VALUES (3, N'Loại II', 270000, 2, 4)
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong], [DonGia], [SoNguoiTieuChuan], [SoNguoiToiDa]) VALUES (4, N'Loại III', 150000, 1, 2)
SET IDENTITY_INSERT [dbo].[LOAIPHONG] OFF
SET IDENTITY_INSERT [dbo].[LOAITINHTRANG] ON 

INSERT [dbo].[LOAITINHTRANG] ([MaLoaiTinhTrang], [TenLoaiTinhTrang]) VALUES (1, N'Trống')
INSERT [dbo].[LOAITINHTRANG] ([MaLoaiTinhTrang], [TenLoaiTinhTrang]) VALUES (2, N'Có người ở')
INSERT [dbo].[LOAITINHTRANG] ([MaLoaiTinhTrang], [TenLoaiTinhTrang]) VALUES (3, N'Đặt')
SET IDENTITY_INSERT [dbo].[LOAITINHTRANG] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [GioiTinh], [SDT]) VALUES (1, N'Dương Thị Minh Nguyệt', 1, N'0362668851')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [GioiTinh], [SDT]) VALUES (2, N'Trần Thị Hoài Thương', 1, N'0989908651')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [GioiTinh], [SDT]) VALUES (3, N'Đỗ Thị Quyên', 1, N'0123456789')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [GioiTinh], [SDT]) VALUES (4, N'Vũ Diệu Linh', 1, N'0902229182')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [GioiTinh], [SDT]) VALUES (5, N'Tuyền Luis', 0, N'0963566703')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTHUEPHONG] ON 

INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (1, 1, 3)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (2, 2, 4)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (3, 3, 2)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (4, 2, 1)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (5, 5, 5)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (6, 6, 2)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (7, 7, 3)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (8, 8, 4)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (12, 12, 1)
INSERT [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue], [MaKhachHang], [MaNhanVien]) VALUES (18, 5, 5)
SET IDENTITY_INSERT [dbo].[PHIEUTHUEPHONG] OFF
SET IDENTITY_INSERT [dbo].[PHONG] ON 

INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (1, 1, 3, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (2, 1, 2, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (3, 1, 3, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (4, 1, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (5, 2, 3, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (6, 2, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (7, 2, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (8, 2, 3, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (12, 2, 2, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (13, 3, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (14, 3, 3, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (15, 4, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (16, 4, 2, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (17, 4, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrang], [GhiChu]) VALUES (18, 4, 3, NULL)
SET IDENTITY_INSERT [dbo].[PHONG] OFF
SET IDENTITY_INSERT [dbo].[THIETBI] ON 

INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (1, N'Bộ điều khiển máy lạnh từ xa', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (2, N'Bộ điều khiển máy lạnh từ xa', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (3, N'Bộ điều khiển máy lạnh từ xa', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (4, N'Bộ điều khiển máy lạnh từ xa', 4, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (5, N'Bộ điều khiển tivi', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (6, N'Bộ điều khiển tivi', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (7, N'Bộ điều khiển tivi', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (8, N'Bình thủy', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (9, N'Dép', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (10, N'Dép', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (11, N'Dép', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (12, N'Dép', 4, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (13, N'Đồng hồ', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (14, N'Đồng hồ', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (15, N'Đồng hồ', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (16, N'Đồng hồ', 4, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (17, N'Điện thoại', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (18, N'Điện thoại', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (19, N'Đĩa úp ly', 1, 2)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (20, N'Đĩa úp ly', 2, 2)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (21, N'Gạt tàn', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (22, N'Gạt tàn', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (23, N'Gạt tàn', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (24, N'Gạt tàn', 4, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (25, N'Máy sấy tóc', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (26, N'Tivi', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (27, N'Tivi', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (28, N'Tivi', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (29, N'Máy lạnh', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (30, N'Máy lạnh', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (31, N'Máy lạnh', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (32, N'Máy lạnh', 4, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (33, N'Tủ lạnh', 1, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (34, N'Khăn tắm', 1, 3)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (35, N'Khăn tắm', 2, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (36, N'Khăn tắm', 3, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (37, N'Khăn tắm', 4, 1)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (38, N'Ly', 1, 5)
INSERT [dbo].[THIETBI] ([MaThietBi], [TenThietBi], [MaLoaiPhong], [SoLuong]) VALUES (39, N'Ly', 2, 5)
SET IDENTITY_INSERT [dbo].[THIETBI] OFF
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_DICHVU] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DICHVU] ([MaDichVu])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_DICHVU]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADONTHUE] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADONTHUE] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADONTHUE]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTHUE_PHIEUTHUEPHONG] FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHUE] CHECK CONSTRAINT [FK_CHITIETPHIEUTHUE_PHIEUTHUEPHONG]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTHUE_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHUE] CHECK CONSTRAINT [FK_CHITIETPHIEUTHUE_PHONG]
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD  CONSTRAINT [FK_DICHVU_DONVI] FOREIGN KEY([MaDonVi])
REFERENCES [dbo].[DONVI] ([MaDonVi])
GO
ALTER TABLE [dbo].[DICHVU] CHECK CONSTRAINT [FK_DICHVU_DONVI]
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD  CONSTRAINT [FK_DICHVU_LOAIDICHVU] FOREIGN KEY([MaLoaiDichVu])
REFERENCES [dbo].[LOAIDICHVU] ([MaLoaiDichVu])
GO
ALTER TABLE [dbo].[DICHVU] CHECK CONSTRAINT [FK_DICHVU_LOAIDICHVU]
GO
ALTER TABLE [dbo].[HOADONTHUE]  WITH CHECK ADD  CONSTRAINT [FK_HOADONTHUE_PHIEUTHUEPHONG] FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PHIEUTHUEPHONG] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[HOADONTHUE] CHECK CONSTRAINT [FK_HOADONTHUE_PHIEUTHUEPHONG]
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUEPHONG_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG] CHECK CONSTRAINT [FK_PHIEUTHUEPHONG_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUEPHONG_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG] CHECK CONSTRAINT [FK_PHIEUTHUEPHONG_NHANVIEN]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAIPHONG] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAIPHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAITINHTRANG] FOREIGN KEY([MaLoaiTinhTrang])
REFERENCES [dbo].[LOAITINHTRANG] ([MaLoaiTinhTrang])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAITINHTRANG]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_LOAIPHONG] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_LOAIPHONG]
GO
/****** Object:  StoredProcedure [dbo].[prc_PhieuThue_Insert]    Script Date: 13/05/2019 1:02:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[prc_PhieuThue_Insert] 
@MaKhachHang INT,
@MaNhanVien INT,
@MaPhong INT,
@NgayThuePhong DATETIME,
@NgayTraPhong DATETIME
AS
	INSERT dbo.PHIEUTHUEPHONG
	        ( MaKhachHang, MaNhanVien )
	VALUES  ( @MaKhachHang, -- MaKhachHang - int
	          @MaNhanVien  -- MaNhanVien - int
	          )
	
	INSERT dbo.CHITIETPHIEUTHUE
	        ( MaPhieuThue ,
	          MaPhong ,
	          NgayThuePhong ,
	          NgayTraPhong
	        )
	VALUES  ( @@IDENTITY , -- MaPhieuThue - int
	          @MaPhong , -- MaPhong - int
	          @NgayThuePhong , -- NgayThuePhong - datetime
	          @NgayTraPhong  -- NgayTraPhong - datetime
	        )
	UPDATE dbo.PHONG SET MaLoaiTinhTrang = 3 WHERE MaPhong = @MaPhong

GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
