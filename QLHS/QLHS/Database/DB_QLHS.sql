USE [QLDiemHocSinh]
GO
/****** Object:  Table [dbo].[DiemMon]    Script Date: 5/4/2019 6:56:17 AM ******/
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
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 5/4/2019 6:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[GVCN]    Script Date: 5/4/2019 6:56:18 AM ******/
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
/****** Object:  Table [dbo].[HocKi]    Script Date: 5/4/2019 6:56:18 AM ******/
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
/****** Object:  Table [dbo].[HocSinh]    Script Date: 5/4/2019 6:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Khoi]    Script Date: 5/4/2019 6:56:18 AM ******/
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
/****** Object:  Table [dbo].[Lop]    Script Date: 5/4/2019 6:56:18 AM ******/
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
/****** Object:  Table [dbo].[MonHoc]    Script Date: 5/4/2019 6:56:18 AM ******/
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
SET IDENTITY_INSERT [dbo].[DiemMon] ON 

INSERT [dbo].[DiemMon] ([MaDiemMon], [MaMonHoc], [MaHocKy], [TrungBinh], [MaHocSinh], [Diem15], [DiemGiuaKy], [DiemThi]) VALUES (1, 1, 1, 6, 1, 5, 6, 7)
INSERT [dbo].[DiemMon] ([MaDiemMon], [MaMonHoc], [MaHocKy], [TrungBinh], [MaHocSinh], [Diem15], [DiemGiuaKy], [DiemThi]) VALUES (2, 2, 1, 6, 1, 4, 7, 8)
INSERT [dbo].[DiemMon] ([MaDiemMon], [MaMonHoc], [MaHocKy], [TrungBinh], [MaHocSinh], [Diem15], [DiemGiuaKy], [DiemThi]) VALUES (3, 1, 2, 7.5, 3, 8, 8, 8)
INSERT [dbo].[DiemMon] ([MaDiemMon], [MaMonHoc], [MaHocKy], [TrungBinh], [MaHocSinh], [Diem15], [DiemGiuaKy], [DiemThi]) VALUES (4, 3, 2, 9, 2, 9, 9, 9)
INSERT [dbo].[DiemMon] ([MaDiemMon], [MaMonHoc], [MaHocKy], [TrungBinh], [MaHocSinh], [Diem15], [DiemGiuaKy], [DiemThi]) VALUES (6, 4, 1, 6.5, 4, 6, 1, 1)
SET IDENTITY_INSERT [dbo].[DiemMon] OFF
SET IDENTITY_INSERT [dbo].[GiaoVien] ON 

INSERT [dbo].[GiaoVien] ([MaGiaoVien], [MaMonHoc], [TenGiaoVien], [SDT], [Email]) VALUES (1, 1, N'Trần Như Quỳnh', N'012312312', N'quynh@gmail.cok')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [MaMonHoc], [TenGiaoVien], [SDT], [Email]) VALUES (2, 2, N'Bùi Văn Đại', N'012312', N'abc@gmail')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [MaMonHoc], [TenGiaoVien], [SDT], [Email]) VALUES (3, 2, N'Trần Văn Hiệp', N'01231234', N'abc@.com')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [MaMonHoc], [TenGiaoVien], [SDT], [Email]) VALUES (4, 3, N'Nguyễn Văn Luận', N'01231231', N'bcd@gmail.com')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [MaMonHoc], [TenGiaoVien], [SDT], [Email]) VALUES (5, 4, N'Hoàng Đắc Thái', N'09874273', N'ada@gmail.com')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [MaMonHoc], [TenGiaoVien], [SDT], [Email]) VALUES (6, 5, N'Trần Như Hai', N'041514', N'hlm@gmail.com')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [MaMonHoc], [TenGiaoVien], [SDT], [Email]) VALUES (7, 6, N'Tạ Đình Hoàng', N'0124235123', N'hoang@gmail.com')
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
INSERT [dbo].[GVCN] ([MaLop], [MaGaioVien]) VALUES (1, 1)
INSERT [dbo].[GVCN] ([MaLop], [MaGaioVien]) VALUES (2, 2)
INSERT [dbo].[GVCN] ([MaLop], [MaGaioVien]) VALUES (2, 3)
INSERT [dbo].[GVCN] ([MaLop], [MaGaioVien]) VALUES (4, 5)
SET IDENTITY_INSERT [dbo].[HocKi] ON 

INSERT [dbo].[HocKi] ([MaHocKy], [TenHocKy]) VALUES (1, N'HK1')
INSERT [dbo].[HocKi] ([MaHocKy], [TenHocKy]) VALUES (2, N'HK2')
INSERT [dbo].[HocKi] ([MaHocKy], [TenHocKy]) VALUES (3, N'Hk3')
INSERT [dbo].[HocKi] ([MaHocKy], [TenHocKy]) VALUES (4, N'HK4')
INSERT [dbo].[HocKi] ([MaHocKy], [TenHocKy]) VALUES (5, N'Hk4')
INSERT [dbo].[HocKi] ([MaHocKy], [TenHocKy]) VALUES (6, N'HK7')
SET IDENTITY_INSERT [dbo].[HocKi] OFF
SET IDENTITY_INSERT [dbo].[HocSinh] ON 

INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (1, 1, N'Bui Văn A', N'nam', CAST(N'2019-01-02' AS Date), N'Ha Nội', N'091239', N'không ', N'Kinh', N'Bui Văn B', N'Trần Thị C')
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (2, 1, N'Nguyễn Gia Long', N'n?', CAST(N'2019-01-02' AS Date), N'Ha Nội', N'091239', N'không ', N'Kinh', N'Nguyễn Gia Bảo', N'Bùi Thị Tâm')
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (3, 2, N'NGọc', N'n?', CAST(N'2019-01-02' AS Date), N'Thái Bình', N'0121', N'không', N'Kinh', N'Nthais', N'Hòa')
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (4, 2, N'Thảo', N'N?', CAST(N'2019-01-02' AS Date), N'Hài Dương', N'012123', N'k', N'TháiNULL', N'Hồng', N'Huyền ANh')
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (5, 2, N'Tài', N'n?', CAST(N'2019-01-02' AS Date), N'HP', N'088', N'không', N'kinh', N'abc', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (6, 3, N'Hoa', N'nam', CAST(N'2019-01-02' AS Date), N'QL', N'98746756', N'không', N'Kinh', N'zxc', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (7, 3, N'Hồng ', N'nam', CAST(N'2019-01-02' AS Date), N'Hạ Long', N'54523452345', N'không', N'thái', N'vbn', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (8, 4, N'Huệ', N'nam', CAST(N'2019-01-02' AS Date), N'Vũng Tàu', N'4523453245', N'không', N'mường', N'mlk', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (9, 4, N'Thắm', N'nam', CAST(N'2019-01-02' AS Date), N'Bình Đinh', N'5325234', N'cóa', N'Mông', N'jghj', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (10, 4, N'Hoài', N'nam', CAST(N'2019-01-02' AS Date), N'Phú Yên', N'5452345234', N'không', N'ede', N'dfsdfwqerq', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (11, 4, N'Hường', N'nam', CAST(N'2019-01-02' AS Date), N'Cần Thơi', N'455234', N'không', N'kinh', N'ẻtt', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (12, NULL, N'', NULL, NULL, NULL, N'', NULL, NULL, N'rtert', NULL)
INSERT [dbo].[HocSinh] ([MaHocSinh], [MaLop], [TenHocSinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TonGiao], [DanToc], [TenCha], [TenMe]) VALUES (14, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', NULL)
SET IDENTITY_INSERT [dbo].[HocSinh] OFF
SET IDENTITY_INSERT [dbo].[Khoi] ON 

INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (1, N'Khối 1')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (2, N'Khối 2')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (3, N'Khối 3')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (4, N'Khối 4')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (5, N'Khối 5')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (6, N'Khối Toán')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (7, N'Khối Ngoại Ngữ')
INSERT [dbo].[Khoi] ([MaKhoi], [TenKhoi]) VALUES (8, N'Khối Khoa Học Tự Nhiên')
SET IDENTITY_INSERT [dbo].[Khoi] OFF
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (1, N'Lớp 1A', 44, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (2, N'Lớp 1B', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (3, N'Lớp 1c', 44, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (4, N'Lớp 1D', 33, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (5, N'Lớp 1E', 46, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (6, N'Lớp 2A', 10, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (7, N'Lớp 2B', 43, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo], [MaKhoi]) VALUES (8, N'Lớp 3A', 39, 3)
SET IDENTITY_INSERT [dbo].[Lop] OFF
SET IDENTITY_INSERT [dbo].[MonHoc] ON 

INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (1, N'Toán 1', 40)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (2, N'Toán Đại 1', 40)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (3, N'Toán Hình 1', 23)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (4, N'Ngữ Văn 2', 44)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (5, N'GDCD 3', 33)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (6, N'Địa Lý 4', 45)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (7, N'Lịch Sử 5', 33)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet]) VALUES (8, N'Thể Chất', 40)
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
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
