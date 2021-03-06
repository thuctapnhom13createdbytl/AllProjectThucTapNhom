USE [QLDiemHocSinh]
GO
/****** Object:  Table [dbo].[DiemMon]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemMon](
	[MaDiemMon] [int] IDENTITY(1,1) NOT NULL,
	[MaMonHoc] [int] NULL,
	[MaHocKy] [int] NULL,
	[TrungBinh] [float] NULL,
	[MaHocSinh] [int] NOT NULL,
	[Diem15] [float] NULL,
	[DiemGiuaKy] [float] NULL,
	[DiemThi] [float] NULL,
 CONSTRAINT [PK_DiemMon] PRIMARY KEY CLUSTERED 
(
	[MaDiemMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGiaoVien] [int] IDENTITY(1,1) NOT NULL,
	[MaMonHoc] [int] NULL,
	[TenGiaoVien] [nvarchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GVCN]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GVCN](
	[MaLop] [int] NOT NULL,
	[MaGaioVien] [int] NOT NULL,
 CONSTRAINT [PK_GVCN] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[MaGaioVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocKi]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKi](
	[MaHocKy] [int] IDENTITY(1,1) NOT NULL,
	[TenHocKy] [nvarchar](50) NULL,
 CONSTRAINT [PK_HocKi] PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHocSinh] [int] IDENTITY(1,1) NOT NULL,
	[MaLop] [int] NULL,
	[TenHocSinh] [nvarchar](150) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[TonGiao] [nvarchar](50) NULL,
	[DanToc] [nvarchar](50) NULL,
	[TenCha] [nvarchar](150) NULL,
	[TenMe] [nvarchar](150) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoi]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoi](
	[MaKhoi] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoi] PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[SiSo] [int] NULL,
	[MaKhoi] [int] NULL,
 CONSTRAINT [PK_Lop_1] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [int] IDENTITY(1,1) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DiemMon]  WITH CHECK ADD  CONSTRAINT [FK_DiemMon_HocKi] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HocKi] ([MaHocKy])
GO
ALTER TABLE [dbo].[DiemMon] CHECK CONSTRAINT [FK_DiemMon_HocKi]
GO
ALTER TABLE [dbo].[DiemMon]  WITH CHECK ADD  CONSTRAINT [FK_DiemMon_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[DiemMon] CHECK CONSTRAINT [FK_DiemMon_MonHoc]
GO
ALTER TABLE [dbo].[DiemMon]  WITH CHECK ADD  CONSTRAINT [FK_DiemMon_SinhVien] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HocSinh] ([MaHocSinh])
GO
ALTER TABLE [dbo].[DiemMon] CHECK CONSTRAINT [FK_DiemMon_SinhVien]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_MonHoc]
GO
ALTER TABLE [dbo].[GVCN]  WITH CHECK ADD  CONSTRAINT [FK_GVCN_GiaoVien] FOREIGN KEY([MaGaioVien])
REFERENCES [dbo].[GiaoVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[GVCN] CHECK CONSTRAINT [FK_GVCN_GiaoVien]
GO
ALTER TABLE [dbo].[GVCN]  WITH CHECK ADD  CONSTRAINT [FK_GVCN_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[GVCN] CHECK CONSTRAINT [FK_GVCN_Lop]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoi] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[Khoi] ([MaKhoi])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoi]
GO
/****** Object:  StoredProcedure [dbo].[LoadDiemHocSinh]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[LoadDiemHocSinh] @tenhs nvarchar(100)
AS
BEGIN
SELECT dbo.DiemMon.MaDiemMon, dbo.MonHoc.TenMonHoc, dbo.DiemMon.TrungBinh, dbo.HocSinh.TenHocSinh, dbo.HocKi.TenHocKy, Diem15, DiemGiuaKy, DiemThi
FROM dbo.Lop, dbo.HocSinh, dbo.DiemMon, dbo.HocKi, dbo.MonHoc
WHERE dbo.DiemMon.MaMonHoc =  dbo.MonHoc.MaMonHoc AND dbo.DiemMon.MaHocKy = dbo.HocKi.MaHocKy AND dbo.DiemMon.MaHocSinh = dbo.HocSinh.MaHocSinh AND dbo.HocSinh.MaLop = dbo.Lop.MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[TimKiemHocSinh]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[TimKiemHocSinh] @diemhs nvarchar(100)
AS
begin
SELECT dbo.DiemMon.MaDiemMon, dbo.MonHoc.MaMonHoc, dbo.DiemMon.TrungBinh, dbo.HocSinh.MaHocSinh, dbo.HocKi.MaHocKy, Diem15, DiemGiuaKy, DiemThi,dbo.MonHoc.TenMonHoc, dbo.HocKi.TenHocKy, dbo.HocSinh.TenHocSinh
FROM dbo.Lop, dbo.HocSinh, dbo.DiemMon, dbo.HocKi, dbo.MonHoc
WHERE dbo.DiemMon.MaMonHoc =  dbo.MonHoc.MaMonHoc AND dbo.DiemMon.MaHocKy = dbo.HocKi.MaHocKy AND dbo.DiemMon.MaHocSinh = dbo.HocSinh.MaHocSinh AND dbo.HocSinh.MaLop = dbo.Lop.MaLop AND dbo.HocSinh.TenHocSinh LIKE @diemhs
END
GO
/****** Object:  StoredProcedure [dbo].[TimKiemHS]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiemHS](@param nvarchar(250))
as 
begin
	select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop
	where TenHocSinh like N'%'+@param+'%' 
		or HocSinh.MaLop = CONVERT(int, @param)
		or MaHocSinh = CONVERT(int, @param)
end
GO
/****** Object:  Trigger [dbo].[ThemDiem]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ThemDiem] on [dbo].[DiemMon] instead of insert
as
declare @DiemTB float,@MaMonHoc int,@MaHocKy int,@MaHocSinh int,@Diem15 float,@DiemGiuaKy float,@DiemThi float
begin
	select @DiemTB = ROUND((Diem15+2*DiemGiuaKy+3*DiemThi)/6,1) from inserted
	select @MaMonHoc = MaMonHoc,@MaHocKy = MaHocKy,@MaHocSinh = MaHocSinh,@Diem15 = Diem15,@DiemGiuaKy = DiemGiuaKy,@DiemThi = DiemThi from inserted
	insert into DiemMon(MaMonHoc,MaHocKy,MaHocSinh,Diem15,DiemGiuaKy,DiemThi,TrungBinh) values (@MaMonHoc,@MaHocKy,@MaHocSinh,@Diem15,@DiemGiuaKy,@DiemThi,@DiemTB)
end
GO
/****** Object:  Trigger [dbo].[XoaDiem2]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[XoaDiem2] ON [dbo].[DiemMon] INSTEAD of DELETE
AS DECLARE @madiemmon INT
BEGIN 
		SELECT @madiemmon = MaDiemMon FROM deleted
		DELETE FROM dbo.DiemMon WHERE MaDiemMon = @madiemmon
END
GO
/****** Object:  Trigger [dbo].[XoaGV]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[XoaGV] on [dbo].[GiaoVien] instead of delete
as
declare @maGV int
begin
	select @maGV = MaGiaoVien from deleted
	delete from GVCN where MaGaioVien = @maGV
	delete from GiaoVien where MaGiaoVien = @maGV
end
GO
/****** Object:  Trigger [dbo].[XoaHS]    Script Date: 5/20/2019 9:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[XoaHS] on [dbo].[HocSinh] instead of delete
as
declare @maHS int
begin
	select @maHS = MaHocSinh from deleted
	delete from DiemMon where MaHocSinh = @maHS
	delete from HocSinh where MaHocSinh = @maHS
end
GO
