USE [TTN_QLNV]
GO

/****** Object:  StoredProcedure [dbo].[LoadAllNhanVien]    Script Date: 24/02/2019 10:26:59 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LoadTatCaPhongBan]
AS 
	SELECT pb.MaPB, pb.TenPB, pb.NgayNhanChuc, nv.HoTen as TenTP
	FROM PHONGBAN pb left join NHANVIEN nv on nv.MaNV = pb.MaTP

GO

LoadTatCaPhongBan

--LoadComboBoxPhongBan
USE [TTN_QLNV]
GO

/****** Object:  StoredProcedure [dbo].[LoadAllNhanVien]    Script Date: 24/02/2019 10:26:59 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LoadComboBoxTenTruongPhong]
AS 
	SELECT nv.MaNV, nv.HoTen
	FROM NHANVIEN nv

GO

LoadComboBoxTenTruongPhong

--Xoa phong ban theo ma

create procedure XoaPhongBanTheoMa
@maPB int
as
	begin 
	delete from PHONGBAN where MaPB = @maPB
	end 
