
CREATE DATABASE [QuanLyKho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyKho.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyKho_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyKho] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKho] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKho] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKho] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyKho] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyKho]
GO
/****** Object:  Table [dbo].[CT_PhieuNhap]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuNhap](
	[Ma_CTPN] [int] IDENTITY(1,1) NOT NULL,
	[Ma_PN] [int] NULL,
	[Ma_Sanpham] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CT_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[Ma_CTPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PhieuXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuXuat](
	[Ma_CTPX] [int] IDENTITY(1,1) NOT NULL,
	[Ma_PX] [int] NULL,
	[Ma_Sanpham] [int] NULL,
	[Soluong] [int] NULL,
	[Dongia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CT_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[Ma_CTPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Ma_KH] [int] IDENTITY(1,1) NOT NULL,
	[Ten_KH] [nvarchar](max) NULL,
	[DiaChi_KH] [nvarchar](max) NULL,
	[SDT_KH] [varchar](50) NULL,
	[Email_KH] [varchar](255) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Ma_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[Ma_LoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[Ma_LoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Ma_NV] [int] IDENTITY(1,1) NOT NULL,
	[Ten_NV] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Ngaysinh_NV] [date] NULL,
	[SDT_NV] [varchar](50) NULL,
	[Email_NV] [varchar](255) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[Ma_NSX] [int] IDENTITY(1,1) NOT NULL,
	[Ten_NSX] [nvarchar](max) NULL,
	[DiaChi_NSX] [nvarchar](max) NULL,
	[SDT_NSX] [varchar](50) NULL,
	[Website_NSX] [varchar](max) NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[Ma_NSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[Ma_PN] [int] IDENTITY(1,1) NOT NULL,
	[Ma_NV] [int] NULL,
	[Ma_NSX] [int] NULL,
	[Ngaynhap] [datetime] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[Ma_PN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[Ma_PX] [int] IDENTITY(1,1) NOT NULL,
	[Ma_NV] [int] NULL,
	[Ma_KH] [int] NULL,
	[Ngayxuat] [datetime] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[Ma_PX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[Ma_Sanpham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](max) NULL,
	[Ma_NSX] [int] NULL,
	[Thongso_Kt] [nvarchar](255) NULL,
	[Ma_LoaiSP] [int] NULL,
	[Gia] [decimal](18, 0) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[Ma_Sanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[aaa]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[aaa] as
select * from NhanVien


GO
/****** Object:  View [dbo].[SP_max]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[SP_max] as 
select sum(Soluong) as tongSL, CT_PhieuXuat.Ma_PX
from CT_PhieuXuat join PhieuXuat on CT_PhieuXuat.Ma_PX = PhieuXuat.Ma_PX
group by CT_PhieuXuat.Ma_PX


GO
/****** Object:  View [dbo].[sp_nv]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sp_nv] as
select count(Ma_PX) as PX, PhieuXuat.Ma_NV
from NhanVien,PhieuXuat
where NhanVien.Ma_NV = PhieuXuat.Ma_NV
group by PhieuXuat.Ma_NV


GO
/****** Object:  View [dbo].[sss]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sss] as select * from NhanVien


GO
/****** Object:  View [dbo].[tongKH]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tongKH] as
select count(PhieuXuat.Ma_KH) as soKH,NhanVien.Ma_NV,NhanVien.Ten_NV
from NhanVien join PhieuXuat on NhanVien.Ma_NV = PhieuXuat.Ma_NV join KhachHang on PhieuXuat.Ma_KH = KhachHang.Ma_KH
group by NhanVien.Ma_NV,NhanVien.Ten_NV


GO
/****** Object:  View [dbo].[tongSL_SP]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tongSL_SP] as 
select sum(Soluong) as tongSL, CT_PhieuXuat.Ma_PX,Ma_Sanpham,PhieuXuat.Ma_NV
from CT_PhieuXuat join PhieuXuat on CT_PhieuXuat.Ma_PX = PhieuXuat.Ma_PX
group by CT_PhieuXuat.Ma_PX,Ma_Sanpham,PhieuXuat.Ma_NV
having sum(Soluong)>50


GO
/****** Object:  View [dbo].[tongSL_SP1]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[tongSL_SP1] as
select sum(Soluong) as tongSL,Ma_Sanpham
from CT_PhieuXuat
group by Ma_Sanpham


GO
/****** Object:  View [dbo].[tongSLSP]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tongSLSP] as
select sum(Soluong) as tongSL,Ma_Sanpham
from CT_PhieuXuat
group by Ma_Sanpham


GO
SET IDENTITY_INSERT [dbo].[CT_PhieuNhap] ON 

INSERT [dbo].[CT_PhieuNhap] ([Ma_CTPN], [Ma_PN], [Ma_Sanpham], [SoLuong], [DonGia]) VALUES (1, 1021, 1057, 30, CAST(21590000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuNhap] ([Ma_CTPN], [Ma_PN], [Ma_Sanpham], [SoLuong], [DonGia]) VALUES (2, 1021, 1060, 30, CAST(10890000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuNhap] ([Ma_CTPN], [Ma_PN], [Ma_Sanpham], [SoLuong], [DonGia]) VALUES (3, 1021, 1061, 30, CAST(15590000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuNhap] ([Ma_CTPN], [Ma_PN], [Ma_Sanpham], [SoLuong], [DonGia]) VALUES (4, 1022, 1054, 15, CAST(960000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuNhap] ([Ma_CTPN], [Ma_PN], [Ma_Sanpham], [SoLuong], [DonGia]) VALUES (5, 1022, 1052, 9, CAST(1790000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuNhap] ([Ma_CTPN], [Ma_PN], [Ma_Sanpham], [SoLuong], [DonGia]) VALUES (6, 1023, 1043, 7, CAST(15390000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[CT_PhieuNhap] OFF
SET IDENTITY_INSERT [dbo].[CT_PhieuXuat] ON 

INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (1, 1012, 1051, 2, CAST(1490000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (2, 1012, 1053, 3, CAST(3690000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (3, 1012, 1057, 6, CAST(21590000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (4, 1012, 1059, 4, CAST(20790000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (5, 1012, 1048, 10, CAST(11990000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (6, 1013, 1043, 3, CAST(15390000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (7, 1013, 1060, 2, CAST(10890000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (8, 1013, 1051, 7, CAST(1490000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (9, 1013, 1048, 13, CAST(11990000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (10, 1013, 1054, 3, CAST(960000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (11, 1014, 1043, 4, CAST(15390000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (12, 1014, 1053, 3, CAST(3690000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (13, 1014, 1061, 20, CAST(15590000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (14, 1014, 1058, 15, CAST(36450000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PhieuXuat] ([Ma_CTPX], [Ma_PX], [Ma_Sanpham], [Soluong], [Dongia]) VALUES (15, 1014, 1045, 7, CAST(4190000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[CT_PhieuXuat] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [DiaChi_KH], [SDT_KH], [Email_KH]) VALUES (2, N'Đinh Thị Nhung', N'Hoàng Mai, Hà Nội', N'0365874563', N'nhung.dinh@gmail.com')
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [DiaChi_KH], [SDT_KH], [Email_KH]) VALUES (3, N'Nguyễn Xuân Công', N'Tân Lập - Đan Phượng - Hà Nội', N'', N'')
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [DiaChi_KH], [SDT_KH], [Email_KH]) VALUES (4, N'Nguyễn Đăng Hải', N'tân lập - đan phượng - hà nội', N'03659565458', N'hai@gmail.com')
INSERT [dbo].[KhachHang] ([Ma_KH], [Ten_KH], [DiaChi_KH], [SDT_KH], [Email_KH]) VALUES (6, N'Nguyễn Ngọc Dương', N'Hà Nội', N'0659578746', N'')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiSanPham] ON 

INSERT [dbo].[LoaiSanPham] ([Ma_LoaiSP], [TenLoai], [GhiChu]) VALUES (15, N'SamSung', N'')
INSERT [dbo].[LoaiSanPham] ([Ma_LoaiSP], [TenLoai], [GhiChu]) VALUES (16, N'XiaoMi', N'')
INSERT [dbo].[LoaiSanPham] ([Ma_LoaiSP], [TenLoai], [GhiChu]) VALUES (17, N'Nokia', N'')
INSERT [dbo].[LoaiSanPham] ([Ma_LoaiSP], [TenLoai], [GhiChu]) VALUES (18, N'oppo', N'')
INSERT [dbo].[LoaiSanPham] ([Ma_LoaiSP], [TenLoai], [GhiChu]) VALUES (19, N'Iphone', N'')
SET IDENTITY_INSERT [dbo].[LoaiSanPham] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([Ma_NV], [Ten_NV], [GioiTinh], [Ngaysinh_NV], [SDT_NV], [Email_NV]) VALUES (4, N'Nguyễn Ngọc Trường', N'Nam', CAST(N'1998-10-27' AS Date), N'0321545648', N'Truong@gmail.com')
INSERT [dbo].[NhanVien] ([Ma_NV], [Ten_NV], [GioiTinh], [Ngaysinh_NV], [SDT_NV], [Email_NV]) VALUES (5, N'Nguyễn Văn Phú', N'Nam', CAST(N'1998-01-27' AS Date), N'03656594558', N'phuvan@gmail.com')
INSERT [dbo].[NhanVien] ([Ma_NV], [Ten_NV], [GioiTinh], [Ngaysinh_NV], [SDT_NV], [Email_NV]) VALUES (6, N'Thế Bằng Phi', N'Nam', CAST(N'1998-01-30' AS Date), N'09655842214', N'Phi@gmail.com')
INSERT [dbo].[NhanVien] ([Ma_NV], [Ten_NV], [GioiTinh], [Ngaysinh_NV], [SDT_NV], [Email_NV]) VALUES (7, N'Nguyễn Đăng Hải', N'Nam', CAST(N'1998-01-27' AS Date), N'032315648332', N'DangHai@gmail.com')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[NhaSanXuat] ON 

INSERT [dbo].[NhaSanXuat] ([Ma_NSX], [Ten_NSX], [DiaChi_NSX], [SDT_NSX], [Website_NSX]) VALUES (13, N'Nokia', N'Hà nội', N'03265654856', N'nokia.com.vn')
INSERT [dbo].[NhaSanXuat] ([Ma_NSX], [Ten_NSX], [DiaChi_NSX], [SDT_NSX], [Website_NSX]) VALUES (14, N'XiaoMi', N'Trung quốc', N'03659545489', N'')
INSERT [dbo].[NhaSanXuat] ([Ma_NSX], [Ten_NSX], [DiaChi_NSX], [SDT_NSX], [Website_NSX]) VALUES (15, N'Apple', N'', N'', N'')
INSERT [dbo].[NhaSanXuat] ([Ma_NSX], [Ten_NSX], [DiaChi_NSX], [SDT_NSX], [Website_NSX]) VALUES (16, N'oppo', N'', N'', N'')
INSERT [dbo].[NhaSanXuat] ([Ma_NSX], [Ten_NSX], [DiaChi_NSX], [SDT_NSX], [Website_NSX]) VALUES (17, N'SamSung Việt Nam', N'Bắc Ninh', N'02565485642', N'SamSung.com.vn')
SET IDENTITY_INSERT [dbo].[NhaSanXuat] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([Ma_PN], [Ma_NV], [Ma_NSX], [Ngaynhap]) VALUES (1021, 5, 15, CAST(N'2019-06-09 00:42:15.000' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma_PN], [Ma_NV], [Ma_NSX], [Ngaynhap]) VALUES (1022, 7, 13, CAST(N'2019-06-09 00:42:15.000' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma_PN], [Ma_NV], [Ma_NSX], [Ngaynhap]) VALUES (1023, 4, 17, CAST(N'2019-06-09 00:44:38.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
SET IDENTITY_INSERT [dbo].[PhieuXuat] ON 

INSERT [dbo].[PhieuXuat] ([Ma_PX], [Ma_NV], [Ma_KH], [Ngayxuat]) VALUES (1012, 5, 3, CAST(N'2019-06-04 00:36:29.000' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma_PX], [Ma_NV], [Ma_KH], [Ngayxuat]) VALUES (1013, 5, 6, CAST(N'2019-05-29 00:40:03.000' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma_PX], [Ma_NV], [Ma_KH], [Ngayxuat]) VALUES (1014, 4, 6, CAST(N'2019-06-09 00:41:14.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[PhieuXuat] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1043, N'SamSung galaxy s10', 17, N'', 15, CAST(15390000 AS Decimal(18, 0)), 100)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1044, N'SamSung galaxy A50', 17, N'6GB/128GB', 15, CAST(6990000 AS Decimal(18, 0)), 70)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1045, N'SamSung galaxy M20', 17, N'pin 5000 mAh', 15, CAST(4190000 AS Decimal(18, 0)), 8)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1046, N'Samsung Galaxy Note 9 ', 17, N'Dual: 12 MP (f/1.5-2.4, 26mm, 1/2.55", 1.4µm, dual pixel PDAF) + 12MP (f/2.4, 52mm, 1/3.6", 1µm, AF), OIS, 2x optical zoom, LED flash', 15, CAST(23290000 AS Decimal(18, 0)), 15)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1047, N'XiaoMi red mi note 7', 14, N'3GB/32GB', 16, CAST(3990000 AS Decimal(18, 0)), 15)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1048, N'XiaoMi Mi 9', 14, N'6GB/64GB', 16, CAST(11990000 AS Decimal(18, 0)), 2)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1049, N'XiaoMi Mi Mix 3', 14, N'', 16, CAST(11490000 AS Decimal(18, 0)), 65)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1050, N'Xiaomi Mi A2 Lite ', 14, N' Ram 4G - 64GB - Chính hãng Digiworld

', 16, CAST(3650000 AS Decimal(18, 0)), 90)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1051, N'Nokia 2.1', 13, N'', 17, CAST(1490000 AS Decimal(18, 0)), 26)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1052, N'nokia 3.1', 13, N'', 17, CAST(1790000 AS Decimal(18, 0)), 24)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1053, N'nokia 3.2', 13, N'3GB/32GB', 15, CAST(3690000 AS Decimal(18, 0)), 33)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1054, N'nokia 8110 4G', 13, N'', 15, CAST(960000 AS Decimal(18, 0)), 27)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1055, N'oppo f9', 16, N'', 18, CAST(6990000 AS Decimal(18, 0)), 65)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1056, N'oppo A3S ', 13, N'16GB-chính hãng', 15, CAST(2990000 AS Decimal(18, 0)), 60)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1057, N'iphone xr ', 15, N'256GB', 19, CAST(21590000 AS Decimal(18, 0)), 49)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1058, N'Iphone XS max', 15, N'512GB chính hãng VN/A', 19, CAST(36450000 AS Decimal(18, 0)), 55)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1059, N'Iphone 8 plus', 15, N'256GB - chính hãng', 19, CAST(20790000 AS Decimal(18, 0)), 56)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1060, N'iphone 7 ', 15, N'32GB', 19, CAST(10890000 AS Decimal(18, 0)), 73)
INSERT [dbo].[SanPham] ([Ma_Sanpham], [TenSanPham], [Ma_NSX], [Thongso_Kt], [Ma_LoaiSP], [Gia], [SoLuong]) VALUES (1061, N'iPhone 7 plus', 15, N'128GB-chính hãng VN/A', 19, CAST(15590000 AS Decimal(18, 0)), 78)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap] FOREIGN KEY([Ma_PN])
REFERENCES [dbo].[PhieuNhap] ([Ma_PN])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_SanPham] FOREIGN KEY([Ma_Sanpham])
REFERENCES [dbo].[SanPham] ([Ma_Sanpham])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [FK_CT_PhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[CT_PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuXuat_PhieuXuat] FOREIGN KEY([Ma_PX])
REFERENCES [dbo].[PhieuXuat] ([Ma_PX])
GO
ALTER TABLE [dbo].[CT_PhieuXuat] CHECK CONSTRAINT [FK_CT_PhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[CT_PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuXuat_SanPham] FOREIGN KEY([Ma_Sanpham])
REFERENCES [dbo].[SanPham] ([Ma_Sanpham])
GO
ALTER TABLE [dbo].[CT_PhieuXuat] CHECK CONSTRAINT [FK_CT_PhieuXuat_SanPham]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[NhanVien] ([Ma_NV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaSanXuat] FOREIGN KEY([Ma_NSX])
REFERENCES [dbo].[NhaSanXuat] ([Ma_NSX])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaSanXuat]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_KhachHang] FOREIGN KEY([Ma_KH])
REFERENCES [dbo].[KhachHang] ([Ma_KH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_KhachHang]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien1] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[NhanVien] ([Ma_NV])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien1]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([Ma_LoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([Ma_LoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaSanXuat] FOREIGN KEY([Ma_NSX])
REFERENCES [dbo].[NhaSanXuat] ([Ma_NSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaSanXuat]
GO
/****** Object:  StoredProcedure [dbo].[LayCTPhieuNhapTheoMa]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayCTPhieuNhapTheoMa](@MaPN int)
as
begin
	select CT_PhieuNhap.*,TenSanPham
	from CT_PhieuNhap,SanPham
	where CT_PhieuNhap.Ma_PN = @MaPN and CT_PhieuNhap.Ma_Sanpham = SanPham.Ma_Sanpham
end
GO
/****** Object:  StoredProcedure [dbo].[LayCTPhieuXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LayCTPhieuXuat](@MaPX int)
as
begin
select CT_PhieuXuat.*,TenSanPham from CT_PhieuXuat,SanPham
where CT_PhieuXuat.Ma_Sanpham = SanPham.Ma_Sanpham and CT_PhieuXuat.Ma_PX = @MaPX 
end
GO
/****** Object:  StoredProcedure [dbo].[LayHoaDonXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayHoaDonXuat](@MaPX int)
as
begin
	select CT_PhieuXuat.*,PhieuXuat.Ma_NV,PhieuXuat.Ma_KH,PhieuXuat.Ngayxuat,Ten_KH,Ten_NV,TenSanPham, (CT_PhieuXuat.Soluong * CT_PhieuXuat.Dongia) as TongTien
	 from PhieuXuat,CT_PhieuXuat,NhanVien,KhachHang,SanPham
	 where PhieuXuat.Ma_PX = CT_PhieuXuat.Ma_PX
	 and PhieuXuat.Ma_KH = KhachHang.Ma_KH
	 and PhieuXuat.Ma_NV = NhanVien.Ma_NV
	 and PhieuXuat.Ma_PX = @MaPX
	 and CT_PhieuXuat.Ma_Sanpham = SanPham.Ma_Sanpham
end
GO
/****** Object:  StoredProcedure [dbo].[LayPhieuNhap]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayPhieuNhap]
as
begin
select PhieuNhap.*,NhaSanXuat.Ten_NSX,NhanVien.Ten_NV from PhieuNhap,NhaSanXuat,NhanVien
where PhieuNhap.Ma_NSX = NhaSanXuat.Ma_NSX and PhieuNhap.Ma_NV = NhanVien.Ma_NV
end
GO
/****** Object:  StoredProcedure [dbo].[LayPhieuXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayPhieuXuat]
as
begin
	select PhieuXuat.*, Ten_KH,Ten_NV from PhieuXuat, KhachHang,NhanVien
	where PhieuXuat.Ma_KH = KhachHang.Ma_KH and PhieuXuat.Ma_NV = NhanVien.Ma_NV 
end

GO
/****** Object:  StoredProcedure [dbo].[LayTatCaKhachHang]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayTatCaKhachHang]
as
begin
select * from KhachHang
end

GO
/****** Object:  StoredProcedure [dbo].[LayTatCaSanPham]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LayTatCaSanPham]
as begin
select Ma_Sanpham,SanPham.Ma_LoaiSP,TenSanPham, SanPham.Ma_NSX, Thongso_Kt,Gia,SoLuong, TenLoai, Ten_NSX 
from SanPham,NhaSanXuat,LoaiSanPham 
where SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP and SanPham.Ma_NSX = NhaSanXuat.Ma_NSX
end

GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoKhachHang]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoKhachHang]
AS 
	SELECT *
	FROM dbo.KhachHang


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoLoaiSanPham]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoLoaiSanPham]
AS 
	SELECT *
	FROM dbo.LoaiSanPham


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoNhanVien]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoNhanVien]
AS 
	
	SELECT nv.Ma_NV, nv.Ten_NV + ' - ' + nv.SDT_NV AS ThongTin, nv.Ten_NV, nv.Ngaysinh_NV, nv.GioiTinh, nv.SDT_NV, nv.Email_NV
	FROM dbo.NhanVien nv


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoNhaSanXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoNhaSanXuat]
AS 
	SELECT *
	FROM dbo.NhaSanXuat


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoPhieuNhap]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoPhieuNhap]
AS
	SELECT ct.Ma_CTPN, ct.Ma_PN, ct.Ma_Sanpham, sp.TenSanPham, lsp.Ma_LoaiSP, lsp.TenLoai,
	ct.SoLuong, ct.DonGia, nsx.Ma_NSX, nsx.Ten_NSX, nv.Ma_NV, nv.Ten_NV
	FROM dbo.PhieuNhap pn INNER JOIN dbo.NhanVien nv ON nv.Ma_NV = pn.Ma_NV
	INNER JOIN dbo.NhaSanXuat nsx ON nsx.Ma_NSX = pn.Ma_NSX
	INNER JOIN dbo.CT_PhieuNhap ct ON ct.Ma_PN = pn.Ma_PN
	INNER JOIN dbo.SanPham sp ON ct.Ma_Sanpham = sp.Ma_Sanpham
	INNER JOIN dbo.LoaiSanPham lsp ON lsp.Ma_LoaiSP = sp.Ma_LoaiSP


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoPhieuXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoPhieuXuat]
AS
	SELECT kh.*, nsx.*, nv.*, lsp.*, ct.Ma_CTPX, ct.Ma_PX, ct.Ma_Sanpham, ct.Soluong, ct.Dongia, sp.TenSanPham, nv.Ten_NV + ' - ' + nv.SDT_NV AS ThongTin
	FROM dbo.PhieuXuat px INNER JOIN dbo.NhanVien nv ON nv.Ma_NV = px.Ma_NV
	INNER JOIN dbo.KhachHang kh ON kh.Ma_KH = px.Ma_KH
	INNER JOIN dbo.CT_PhieuXuat ct ON ct.Ma_PX = px.Ma_PX
	INNER JOIN dbo.SanPham sp ON sp.Ma_Sanpham = ct.Ma_Sanpham
	INNER JOIN dbo.LoaiSanPham lsp ON lsp.Ma_LoaiSP = sp.Ma_LoaiSP
	INNER JOIN dbo.NhaSanXuat nsx ON nsx.Ma_NSX = sp.Ma_NSX


GO
/****** Object:  StoredProcedure [dbo].[SPTheoNSX]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPTheoNSX](@MaNSX int)
as begin
select Ma_Sanpham,SanPham.Ma_LoaiSP,TenSanPham, SanPham.Ma_NSX, Thongso_Kt,Gia,SoLuong, TenLoai, Ten_NSX 
from SanPham,NhaSanXuat,LoaiSanPham 
where SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP and SanPham.Ma_NSX = NhaSanXuat.Ma_NSX and SanPham.Ma_NSX = @MaNSX
end
GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuNhap]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemChiTietPhieuNhap]
@Ma_PN INT,
@Ma_Sanpham INT,
@SoLuong INT,
@DonGia INT
AS
	INSERT dbo.CT_PhieuNhap
	        ( Ma_PN, Ma_Sanpham, SoLuong, DonGia )
	VALUES  ( @Ma_PN, -- Ma_PN - int
	          @Ma_Sanpham, -- Ma_Sanpham - int
	          @SoLuong, -- SoLuong - int
	          @DonGia  -- DonGia - int
	          )


GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuXuat]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemChiTietPhieuXuat]
@Ma_PX INT,
@Ma_Sanpham INT,
@SoLuong INT,
@DonGia INT
AS
	INSERT dbo.CT_PhieuXuat
	        ( Ma_PX, Ma_Sanpham, Soluong, Dongia )
	VALUES  ( @Ma_PX, -- Ma_PN - int
	          @Ma_Sanpham, -- Ma_Sanpham - int
	          @SoLuong, -- SoLuong - int
	          @DonGia  -- DonGia - int
	          )


GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemKhachHang](@tenkh nvarchar(50),@diachi nvarchar(50),@sdt varchar(50),@mail varchar(255))
as
begin
	insert into KhachHang values(@tenkh,@diachi,@sdt,@mail)
end

GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHangMoi]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemKhachHangMoi]
@Ten_KH NVARCHAR(MAX),
@DiaChi_KH NVARCHAR(MAX),
@SDT_KH VARCHAR(50),
@Email_KH VARCHAR(255)
AS 
	INSERT dbo.KhachHang
	        ( Ten_KH, DiaChi_KH, SDT_KH, Email_KH )
	VALUES  ( @Ten_KH, -- Ten_KH - nvarchar(max)
	          @DiaChi_KH, -- DiaChi_KH - nvarchar(max)
	          @SDT_KH, -- SDT_KH - varchar(50)
	          @Email_KH  -- Email_KH - varchar(255)
	          )


GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemNhanVien] (@tenNV nvarchar(50), @gioitinh nvarchar(10), @ngaysinh date, @sdtNV varchar(50), @emailNV varchar(255))
as begin 
INSERT INTO dbo.NhanVien VALUES(@tenNV, @gioitinh, @ngaysinh, @sdtNV, @emailNV)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap_SPCu]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhieuNhap_SPCu]
@Ma_NSX INT,
@Ma_Sanpham INT,
@SoLuong INT,
@DonGia INT,
@Ma_NV INT
AS
	DECLARE @Ma_PN INT
	UPDATE dbo.SanPham 
	SET SoLuong = SoLuong + @SoLuong, Gia = @DonGia
	WHERE Ma_Sanpham = @Ma_Sanpham

	EXEC dbo.ThemPhieuNhapMoi @Ma_NV, @Ma_NSX
	SELECT @Ma_PN = @@IDENTITY

	EXEC dbo.ThemChiTietPhieuNhap @Ma_PN, @Ma_Sanpham, @SoLuong, @DonGia


GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap_SPMoi]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhieuNhap_SPMoi]
@TenSanPham NVARCHAR(MAX),
@Ma_NSX INT,
@Ma_LoaiSP INT,
@SoLuong INT,
@DonGia INT,
@Ma_NV INT
AS
	DECLARE @Ma_Sanpham INT, @Ma_PN INT
	EXEC ThemSanPhamMoi @TenSanPham, @Ma_NSX, @Ma_LoaiSP, @DonGia, @SoLuong
	SELECT @Ma_Sanpham = @@IDENTITY

	EXEC dbo.ThemPhieuNhapMoi @Ma_NV, @Ma_NSX
	SELECT @Ma_PN = @@IDENTITY

	EXEC dbo.ThemChiTietPhieuNhap @Ma_PN, @Ma_Sanpham, @SoLuong, @DonGia


GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhapMoi]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhieuNhapMoi]
@Ma_NV INT,
@Ma_NSX INT
AS 
	INSERT dbo.PhieuNhap
	        ( Ma_NV, Ma_NSX, Ngaynhap )
	VALUES  ( @Ma_NV, -- Ma_NV - int
	          @Ma_NSX, -- Ma_NSX - int
	          GETDATE()  -- Ngaynhap - datetime
	          )


GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuXuat_KHCu]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhieuXuat_KHCu]
@Ma_KH INT,
@Ma_Sanpham INT,
@SoLuong INT,
@DonGia INT,
@Ma_NV INT
AS
	DECLARE @Ma_PX INT
	UPDATE dbo.SanPham 
	SET SoLuong = SoLuong - @SoLuong
	WHERE Ma_Sanpham = @Ma_Sanpham

	EXEC dbo.ThemPhieuXuatMoi @Ma_NV, @Ma_KH
	SELECT @Ma_PX = @@IDENTITY

	EXEC dbo.ThemChiTietPhieuXuat @Ma_PX, @Ma_Sanpham, @SoLuong, @DonGia


GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuXuat_KHMoi]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhieuXuat_KHMoi]
@Ten_KH NVARCHAR(MAX),
@DiaChi_KH NVARCHAR(MAX),
@SDT_KH VARCHAR(50),
@Email_KH VARCHAR(255),
@Ma_Sanpham INT,
@SoLuong INT,
@DonGia INT,
@Ma_NV INT
AS
	DECLARE @Ma_PX INT, @Ma_KH INT
	EXEC ThemKhachHangMoi @Ten_KH, @DiaChi_KH, @SDT_KH, @Email_KH
	SELECT @Ma_KH = @@IDENTITY

	UPDATE dbo.SanPham
	SET SoLuong = SoLuong - @SoLuong
	WHERE Ma_Sanpham = @Ma_Sanpham

	EXEC dbo.ThemPhieuXuatMoi @Ma_NV, @Ma_KH
	SELECT @Ma_PX = @@IDENTITY

	EXEC dbo.ThemChiTietPhieuXuat @Ma_PX, @Ma_Sanpham, @SoLuong, @DonGia


GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuXuatMoi]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhieuXuatMoi]
@Ma_NV INT,
@Ma_KH INT
AS 
	INSERT dbo.PhieuXuat
	        ( Ma_NV, Ma_KH, Ngayxuat )
	VALUES  ( @Ma_NV, -- Ma_NV - int
	          @Ma_KH, -- Ma_KH - int
	          GETDATE()  -- Ngayxuat - datetime
	          )


GO
/****** Object:  StoredProcedure [dbo].[ThemSanPham]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemSanPham](@Ten nvarchar(50), @maNSX int,@thongso nvarchar(255), @maLoai int,@gia int, @soluong int )
as begin 
insert into SanPham values(@Ten,@maNSX,@thongso,@maLoai,@gia,@soluong)
end

GO
/****** Object:  StoredProcedure [dbo].[ThemSanPhamMoi]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemSanPhamMoi]
@TenSanPham NVARCHAR(MAX),
@Ma_NSX INT,
@Ma_LoaiSP INT,
@Gia INT,
@SoLuong INT
AS
	INSERT dbo.SanPham
	        ( TenSanPham ,
	          Ma_NSX ,
	          Ma_LoaiSP ,
	          Gia ,
	          SoLuong
	        )
	VALUES  ( @TenSanPham , -- TenSanPham - nvarchar(max)
	          @Ma_NSX , -- Ma_NSX - int
	          @Ma_LoaiSP , -- Ma_LoaiSP - int
	          @Gia , -- Gia - int
	          @SoLuong -- SoLuong - int
	        )

GO
/****** Object:  StoredProcedure [dbo].[TimKiemSP]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemSP](@tenSP nvarchar(50))
as begin
select Ma_Sanpham,TenSanPham, Thongso_Kt,Gia,SoLuong, TenLoai, Ten_NSX,SanPham.Ma_NSX,SanPham.Ma_LoaiSP
from SanPham left join NhaSanXuat on SanPham.Ma_NSX = NhaSanXuat.Ma_NSX left join  LoaiSanPham on SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP
where TenSanPham like N'%'+@tenSP+'%'
end

GO
/****** Object:  StoredProcedure [dbo].[XuatHoaDonNhap]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XuatHoaDonNhap](@MaPN int)
as
begin
	select PhieuNhap.Ma_NV,PhieuNhap.Ma_NSX,Ngaynhap,CT_PhieuNhap.*,TenSanPham,Ten_NV,Ten_NSX,(CT_PhieuNhap.SoLuong*CT_PhieuNhap.DonGia) as TongTien 
	from PhieuNhap, CT_PhieuNhap,NhaSanXuat,NhanVien,SanPham
	where PhieuNhap.Ma_PN = CT_PhieuNhap.Ma_PN
	and PhieuNhap.Ma_NSX = NhaSanXuat.Ma_NSX
	and PhieuNhap.Ma_NV = NhanVien.Ma_NV
	and CT_PhieuNhap.Ma_Sanpham = SanPham.Ma_Sanpham
	and PhieuNhap.Ma_PN = @MaPN
end
GO
/****** Object:  Trigger [dbo].[XoaKH]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[XoaKH] on [dbo].[KhachHang] instead of delete
as declare @maKH int
 begin
 select @maKH = Ma_KH from deleted
 update PhieuXuat set Ma_KH = null where Ma_KH = @maKH
 delete from KhachHang where Ma_KH = @maKH
 end

GO
/****** Object:  Trigger [dbo].[xoaLSP]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE trigger [dbo].[xoaLSP] on [dbo].[LoaiSanPham] instead of delete
 as declare @maLSP int
 begin
 select @maLSP = Ma_LoaiSP from deleted
 update SanPham set Ma_LoaiSP = null where SanPham.Ma_LoaiSP = @maLSP
 delete from LoaiSanPham where Ma_LoaiSP = @maLSP
 end

GO
/****** Object:  Trigger [dbo].[xoaNhanVien]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE trigger [dbo].[xoaNhanVien] on [dbo].[NhanVien] instead of delete
 as declare @maNV int
 begin
 select @maNV = Ma_NV from deleted
 update dbo.PhieuNhap set Ma_NV = null where dbo.PhieuNhap.Ma_NV = @maNV
 UPDATE dbo.PhieuXuat SET Ma_NV = NULL WHERE dbo.PhieuXuat.Ma_NV = @maNV
 delete from dbo.NhanVien where Ma_NV = @maNV
 end


GO
/****** Object:  Trigger [dbo].[xoaNSX]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE trigger [dbo].[xoaNSX] on [dbo].[NhaSanXuat] instead of delete
 as declare @maNSX int
 begin
 select @maNSX = Ma_NSX from deleted
 update SanPham set Ma_NSX = null where SanPham.Ma_NSX = @maNSX
 delete from PhieuNhap where Ma_NSX = @maNSX
 delete from NhaSanXuat where Ma_NSX = @maNSX
 END
GO
/****** Object:  Trigger [dbo].[xoaSP]    Script Date: 6/9/2019 12:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[xoaSP] on [dbo].[SanPham] instead of delete
 as declare @maSP int
 begin
 select @maSP = Ma_Sanpham from deleted
 update CT_PhieuNhap set Ma_Sanpham = null where Ma_Sanpham = @maSP
 update CT_PhieuXuat set Ma_Sanpham = null where Ma_Sanpham = @maSP
 delete from SanPham where Ma_Sanpham = @maSP
 end

GO
USE [master]
GO
ALTER DATABASE [QuanLyKho] SET  READ_WRITE 
GO
