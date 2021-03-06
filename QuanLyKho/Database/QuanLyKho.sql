USE [QuanLyKho]
GO
/****** Object:  Table [dbo].[CT_PhieuNhap]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[CT_PhieuXuat]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  View [dbo].[aaa]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[aaa] as
select * from NhanVien


GO
/****** Object:  View [dbo].[SP_max]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[SP_max] as 
select sum(Soluong) as tongSL, CT_PhieuXuat.Ma_PX
from CT_PhieuXuat join PhieuXuat on CT_PhieuXuat.Ma_PX = PhieuXuat.Ma_PX
group by CT_PhieuXuat.Ma_PX


GO
/****** Object:  View [dbo].[sp_nv]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  View [dbo].[sss]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sss] as select * from NhanVien


GO
/****** Object:  View [dbo].[tongKH]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tongKH] as
select count(PhieuXuat.Ma_KH) as soKH,NhanVien.Ma_NV,NhanVien.Ten_NV
from NhanVien join PhieuXuat on NhanVien.Ma_NV = PhieuXuat.Ma_NV join KhachHang on PhieuXuat.Ma_KH = KhachHang.Ma_KH
group by NhanVien.Ma_NV,NhanVien.Ten_NV


GO
/****** Object:  View [dbo].[tongSL_SP]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  View [dbo].[tongSL_SP1]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[tongSL_SP1] as
select sum(Soluong) as tongSL,Ma_Sanpham
from CT_PhieuXuat
group by Ma_Sanpham


GO
/****** Object:  View [dbo].[tongSLSP]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tongSLSP] as
select sum(Soluong) as tongSL,Ma_Sanpham
from CT_PhieuXuat
group by Ma_Sanpham


GO
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
/****** Object:  StoredProcedure [dbo].[LayTatCaKhachHang]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayTatCaSanPham]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LoadToanBoKhachHang]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoKhachHang]
AS 
	SELECT *
	FROM dbo.KhachHang


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoLoaiSanPham]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoLoaiSanPham]
AS 
	SELECT *
	FROM dbo.LoaiSanPham


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoNhanVien]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoNhanVien]
AS 
	
	SELECT nv.Ma_NV, nv.Ten_NV + ' - ' + nv.SDT_NV AS ThongTin, nv.Ten_NV, nv.Ngaysinh_NV, nv.GioiTinh, nv.SDT_NV, nv.Email_NV
	FROM dbo.NhanVien nv


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoNhaSanXuat]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadToanBoNhaSanXuat]
AS 
	SELECT *
	FROM dbo.NhaSanXuat


GO
/****** Object:  StoredProcedure [dbo].[LoadToanBoPhieuNhap]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LoadToanBoPhieuXuat]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuNhap]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuXuat]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemKhachHangMoi]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemNhanVien] (@tenNV nvarchar(50), @gioitinh nvarchar(10), @ngaysinh date, @sdtNV varchar(50), @emailNV varchar(255))
as begin 
INSERT INTO dbo.NhanVien VALUES(@tenNV, @gioitinh, @ngaysinh, @sdtNV, @emailNV)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap_SPCu]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap_SPMoi]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhapMoi]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemPhieuXuat_KHCu]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemPhieuXuat_KHMoi]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemPhieuXuatMoi]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemSanPham]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemSanPham](@Ten nvarchar(50), @maNSX int,@thongso nvarchar(255), @maLoai int,@gia int, @soluong int )
as begin 
insert into SanPham values(@Ten,@maNSX,@thongso,@maLoai,@gia,@soluong)
end

GO
/****** Object:  StoredProcedure [dbo].[ThemSanPhamMoi]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TimKiemSP]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Trigger [dbo].[XoaKH]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Trigger [dbo].[xoaLSP]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Trigger [dbo].[xoaNhanVien]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Trigger [dbo].[xoaNSX]    Script Date: 5/21/2019 11:36:44 PM ******/
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
/****** Object:  Trigger [dbo].[xoaPN]    Script Date: 5/21/2019 11:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[xoaPN] on [dbo].[PhieuNhap] instead of delete
 as
 declare @maPN int
 begin
 select @maPN = Ma_PN from deleted
 delete from CT_PhieuNhap where Ma_PN = @maPN
 delete from PhieuNhap where Ma_PN = @maPN
 end
GO
/****** Object:  Trigger [dbo].[xoaSP]    Script Date: 5/21/2019 11:36:44 PM ******/
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
